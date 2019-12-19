using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
  }
}
