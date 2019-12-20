using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using SQLHelper.Properties;

namespace SQLHelper
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      string serverListFileName = "serverList.txt";
      if (!File.Exists(serverListFileName))
      {
        // create the file
        using (StreamWriter sw = new StreamWriter(serverListFileName))
        {
          sw.WriteLine("server1");
        }
      }

      using (StreamReader sr = new StreamReader(serverListFileName))
      {
        while (!sr.EndOfStream)
        {
          string line = sr.ReadLine();
          listBoxAvailable.Items.Add(line);
        }

        labelCountAvailable.Text = $"Count: {listBoxAvailable.Items.Count}";
      }

      DisplayTitle();
      GetWindowValue();
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.Save();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
    }

    private void DisplayTitle()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      Text += string.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
    }

    private void ButtonAddToAvailable_Click(object sender, EventArgs e)
    {
      if (textBoxAvailable.Text != string.Empty)
      {
        listBoxAvailable.Items.Add(textBoxAvailable.Text);
        labelCountAvailable.Text = $"Count: {listBoxAvailable.Items.Count}";
      }
    }

    private void ButtonMoveToAvailable_Click(object sender, EventArgs e)
    {
      if (listBoxToDeploy.SelectedItems.Count != 0)
      {
        foreach (var item in listBoxToDeploy.SelectedItems)
        {
          listBoxAvailable.Items.Add(item);
        }

        UpdateCounterLAbels();
        listBoxToDeploy.SelectedIndex = -1;
      }
    }

    private void ButtonMoveToDeploy_Click(object sender, EventArgs e)
    {
      if (listBoxAvailable.SelectedItems.Count != 0)
      {
        foreach (var item in listBoxAvailable.SelectedItems)
        {
          listBoxToDeploy.Items.Add(item);
        }
        //for (int x = listBox1.SelectedIndices.Count - 1; x >= 0; x--)
        //{
        //  int index = listBox1.SelectedIndices[x];
        //  listBox2.Items.Add(listBox1.Items[index]);
        //  listBox1.Items.RemoveAt(index);
        //}

        //for (int i = listBoxAvailable.SelectedIndices.Count; i >= 0; i--)
        //{
        //  int index = listBoxAvailable.SelectedIndices[i - 1];
        //  listBoxToDeploy.Items.Add(listBoxAvailable.Items[index]);
        //  listBoxAvailable.Items.RemoveAt(index);
        //}

        listBoxAvailable.SelectedIndex = -1;

        UpdateCounterLAbels();
      }
    }

    private void UpdateCounterLAbels()
    {
      labelCountAvailable.Text = $"Count: {listBoxAvailable.Items.Count}";
      labelCountDeploy.Text = $"Count: {listBoxToDeploy.Items.Count}";
    }

    private void ButtonClear_Click(object sender, EventArgs e)
    {
      listBoxAvailable.Items.Clear();
    }

    private void ButtonDelete_Click(object sender, EventArgs e)
    {
      if (listBoxAvailable.SelectedItems.Count != 0)
      {
        listBoxAvailable.Items.RemoveAt(listBoxAvailable.SelectedIndex);
      }
      
    }

    private void ButtonGenerate_Click(object sender, EventArgs e)
    {
      if (textBoxSource.Text == string.Empty)
      {
        return;
      }

      if (listBoxToDeploy.SelectedItems.Count != 0)
      {
        return;
      }

      textBoxResult.Text = string.Empty;

      foreach (string serverName in listBoxToDeploy.Items)
      {
        textBoxResult.Text += textBoxSource.Text.Replace("%%ServerName%%", serverName);
        textBoxResult.Text += Environment.NewLine;
        textBoxResult.Text += Environment.NewLine;
        textBoxResult.Text += $"-- server: {serverName}";
        textBoxResult.Text += Environment.NewLine;
      }

    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      SaveWindowValue();
    }
  }
}
