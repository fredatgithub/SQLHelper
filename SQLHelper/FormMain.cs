using LibraryHelper;
using SQLHelper.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
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
        // create the file serverList.txt if not exists
        using (StreamWriter streamWriter = new StreamWriter(serverListFileName))
        {
          streamWriter.WriteLine("server1");
        }
      }

      using (StreamReader streamReader = new StreamReader(serverListFileName))
      {
        while (!streamReader.EndOfStream)
        {
          string line = streamReader.ReadLine();
          listBoxAvailable.Items.Add(line);
        }

        labelCountAvailable.Text = $"Count: {listBoxAvailable.Items.Count}";
      }

      DisplayTitle();
      GetWindowValue();
      EnableDisableButtons();
      // disable not implemented menu items:
      annulerToolStripMenuItem.Enabled = false;
      rétablirToolStripMenuItem.Enabled = false;
      outilsToolStripMenuItem.Enabled = false;
      personnaliserToolStripMenuItem.Enabled = false;
      optionsToolStripMenuItem.Enabled = false;
      sommaireToolStripMenuItem.Enabled = false;
      indexToolStripMenuItem.Enabled = false;
      rechercherToolStripMenuItem.Enabled = false;
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.textBoxAvailable = textBoxAvailable.Text;
      Settings.Default.Save();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
      textBoxAvailable.Text = Settings.Default.textBoxAvailable;
    }

    private void DisplayTitle()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      Text += string.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
    }

    private void ButtonAddToAvailable_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(textBoxAvailable.Text))
      {
        listBoxAvailable.Items.Add(textBoxAvailable.Text);
        labelCountAvailable.Text = $"Count: {listBoxAvailable.Items.Count}";
      }

      EnableDisableButtons();
    }

    private void ButtonMoveToAvailable_Click(object sender, EventArgs e)
    {
      WindowsHelper.MoveItemsFromListBoxToListBox(listBoxToDeploy, listBoxAvailable);
      EnableDisableButtons();
    }

    private void ButtonMoveToDeploy_Click(object sender, EventArgs e)
    {
      WindowsHelper.MoveItemsFromListBoxToListBox(listBoxAvailable, listBoxToDeploy);
      EnableDisableButtons();
    }

    private void UpdateCounterLabels()
    {
      labelCountAvailable.Text = $"Count: {listBoxAvailable.Items.Count}";
      labelCountDeploy.Text = $"Count: {listBoxToDeploy.Items.Count}";
    }

    private void ButtonClear_Click(object sender, EventArgs e)
    {
      WindowsHelper.ClearListbox(listBoxAvailable);
      EnableDisableButtons();
    }

    private void ButtonDelete_Click(object sender, EventArgs e)
    {
      WindowsHelper.DeleteSelectedItemsFromListbox(listBoxAvailable);
      EnableDisableButtons();
    }

    private void ButtonGenerate_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(textBoxSource.Text))
      {
        return;
      }

      if (listBoxToDeploy.SelectedItems.Count != 0)
      {
        return;
      }

      buttonGenerate.Enabled = false; 
      textBoxResult.Text = string.Empty;
      textBoxResult.Text = "Please wait";
      Application.DoEvents();

      progressBarMain.Minimum = 0;
      int counter = 0;
      progressBarMain.Value = progressBarMain.Minimum;
      progressBarMain.Maximum = listBoxToDeploy.Items.Count;
      foreach (string serverName in listBoxToDeploy.Items)
      {
        textBoxResult.Text += $"-- Start of script for server: {serverName}";
        textBoxResult.Text += Environment.NewLine;
        textBoxResult.Text += textBoxSource.Text.Replace("%%ServerName%%", serverName);
        textBoxResult.Text += Environment.NewLine;
        textBoxResult.Text += $"-- End of script for server: {serverName}";
        textBoxResult.Text += Environment.NewLine;
        textBoxResult.Text += Environment.NewLine;
        progressBarMain.Value = counter;
        counter++;
      }

      progressBarMain.Value = progressBarMain.Minimum;
      MessageBox.Show("The SQL script has been created.", "Done", MessageBoxButtons.OK);
      buttonGenerate.Enabled = true;
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      SaveWindowValue();
    }

    private void ButtonSelectAll_Click(object sender, EventArgs e)
    {
      WindowsHelper.SelectAllItemsFromListBox(listBoxAvailable);
      EnableDisableButtons();
    }

    private void ButtonUnselectAll_Click(object sender, EventArgs e)
    {
      WindowsHelper.SelectAllItemsFromListBox(listBoxAvailable, false);
      EnableDisableButtons();
    }

    private void ButtonCopyToClipBoard_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(textBoxResult.Text);
      MessageBox.Show("Script SQL has been copied to the clipboard", "copied", MessageBoxButtons.OK);
    }

    private void CouperToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { textBoxResult, textBoxSource, textBoxAvailable });
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        CutToClipboard(tb);
      }
    }

    private void CopierToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { textBoxResult, textBoxSource, textBoxAvailable });
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        CopyToClipboard(tb);
      }
    }

    private void CollerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { textBoxResult, textBoxSource, textBoxAvailable });
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        PasteFromClipboard(tb);
      }
    }

    private void SelectionnertoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { textBoxResult, textBoxSource, textBoxAvailable });
      TextBox control = focusedControl as TextBox;
      if (control != null)
      {
        control.SelectAll();
      }
    }

    private void CutToClipboard(TextBoxBase textbox)
    {
      if (textbox != ActiveControl)
      {
        return;
      }

      if (string.IsNullOrEmpty(textbox.Text))
      {
        MessageBox.Show("there is an error, no text is present", "No Text", MessageBoxButtons.OK);
        return;
      }

      if (string.IsNullOrEmpty(textbox.SelectedText))
      {
        MessageBox.Show("there is no text selected", "No Text selected", MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(textbox.SelectedText);
      textbox.SelectedText = string.Empty;
    }

    private void CopyToClipboard(TextBoxBase textbox)
    {
      if (textbox != ActiveControl)
      {
        return;
      }

      if (string.IsNullOrEmpty(textbox.Text))
      {
        MessageBox.Show("there is nothing to copy", "Nothing to copy", MessageBoxButtons.OK);
        return;
      }

      if (string.IsNullOrEmpty(textbox.SelectedText))
      {
        MessageBox.Show("No text has been selected", "No Text selected", MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(textbox.SelectedText);
    }

    private void PasteFromClipboard(TextBoxBase textbox)
    {
      if (textbox != ActiveControl)
      {
        return;
      }

      var selectionIndex = textbox.SelectionStart;
      textbox.SelectedText = Clipboard.GetText();
      textbox.SelectionStart = selectionIndex + Clipboard.GetText().Length;
    }

    private static Control FindFocusedControl(Control container)
    {
      foreach (Control childControl in container.Controls.Cast<Control>().Where(childControl => childControl.Focused))
      {
        return childControl;
      }

      return (from Control childControl in container.Controls select FindFocusedControl(childControl)).FirstOrDefault(maybeFocusedControl => maybeFocusedControl != null);
    }

    private static Control FindFocusedControl(List<Control> container)
    {
      return container.FirstOrDefault(control => control.Focused);
    }

    private static Control FindFocusedControl(params Control[] container)
    {
      return container.FirstOrDefault(control => control.Focused);
    }

    private static Control FindFocusedControl(IEnumerable<Control> container)
    {
      return container.FirstOrDefault(control => control.Focused);
    }

    private void TextBoxAvailable_TextChanged(object sender, EventArgs e)
    {
      buttonAddToAvailable.Enabled = textBoxAvailable.Text != string.Empty;
    }

    private void ListBoxToDeploy_SelectedIndexChanged(object sender, EventArgs e)
    {
      EnableDisableButtons();
    }

    private void ListBoxAvailable_SelectedIndexChanged(object sender, EventArgs e)
    {
      EnableDisableButtons();
    }

    private void TextBoxSource_TextChanged(object sender, EventArgs e)
    {
      buttonGenerate.Enabled = textBoxSource.Text != string.Empty;
    }

    private void TextBoxResult_TextChanged(object sender, EventArgs e)
    {
      buttonCopyToClipBoard.Enabled = textBoxResult.Text != string.Empty;
      buttonClearResult.Enabled = textBoxResult.Text != string.Empty;
      buttonSaveToFile.Enabled = textBoxResult.Text != string.Empty;
    }

    private void EnableDisableButtons()
    {
      buttonAddToAvailable.Enabled = textBoxAvailable.Text != string.Empty;
      buttonMoveToAvailable.Enabled = listBoxToDeploy.Items.Count != 0;
      buttonMoveToAvailable.Enabled = listBoxToDeploy.SelectedIndex != -1;
      buttonMoveToDeploy.Enabled = listBoxAvailable.Items.Count != 0;
      buttonMoveToDeploy.Enabled = listBoxAvailable.SelectedIndex != -1;
      buttonGenerate.Enabled = textBoxSource.Text != string.Empty;
      buttonCopyToClipBoard.Enabled = textBoxResult.Text != string.Empty;
      buttonDelete.Enabled = listBoxAvailable.Items.Count != 0;
      buttonDelete.Enabled = listBoxAvailable.SelectedIndex != -1;
      buttonSelectAll.Enabled = listBoxAvailable.Items.Count > 0;
      buttonUnselectAll.Enabled = listBoxAvailable.Items.Count > 0;
      buttonUnselectAll.Enabled = listBoxAvailable.SelectedIndex != -1;
      buttonClear.Enabled = listBoxAvailable.Items.Count > 0;

      buttonDeployClear.Enabled = listBoxToDeploy.Items.Count > 0;
      buttonDeployDelete.Enabled = listBoxToDeploy.Items.Count != 0;
      buttonDeployDelete.Enabled = listBoxToDeploy.SelectedIndex != -1;
      buttonDeploySelectAll.Enabled = listBoxToDeploy.Items.Count != 0;
      buttonDeployUnselectAll.Enabled = listBoxToDeploy.Items.Count != 0;
      buttonDeployUnselectAll.Enabled = listBoxToDeploy.Items.Count > 0;
      buttonDeployUnselectAll.Enabled = listBoxToDeploy.SelectedIndex != -1;
      buttonGenerate.Enabled = listBoxToDeploy.Items.Count > 0;
      buttonCopyToClipBoard.Enabled = textBoxResult.Text.Length > 0;
      UpdateCounterLabels();
    }

    private void ListBoxAvailable_SizeChanged(object sender, EventArgs e)
    {
      EnableDisableButtons();
    }

    private void EnregistrerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog
      {
        Filter = "SQL Script files (*.sql)|*.sql |All files (*.*)|*.*",
        Title = "Save SQL file"
      };

      saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        try
        {
          using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
          {
            streamWriter.Write(textBoxResult.Text);
          }
        }
        catch (Exception exception)
        {
          MessageBox.Show($"Error while trying to save the script file. {Environment.NewLine}{exception.Message}", "Error", MessageBoxButtons.OK);
        }
      }
    }

    private void EnregistrersousToolStripMenuItem_Click(object sender, EventArgs e)
    {
      EnregistrerToolStripMenuItem_Click(sender, e);
    }

    private void OuvrirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog
      {
        Filter = "SQL Script files (*.sql)|*.sql |All files (*.*)|*.*",
        Title = "Open SQL file"
      };

      openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        string openFileContent = string.Empty;
        try
        {
          using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
          {
            openFileContent = streamReader.ReadToEnd();
          }
        }
        catch (Exception exception)
        {
          MessageBox.Show($"There was an error while reading the file {openFileDialog.FileName}{Environment.NewLine}{exception.Message}");
        }

        if (textBoxSource.Text != string.Empty)
        {
          if (MessageBox.Show("Do you want to replace existing text?", "Replace text", MessageBoxButtons.YesNo) == DialogResult.Yes)
          {
            textBoxSource.Text = openFileContent;
          }
        }
        else
        {
          textBoxSource.Text = openFileContent;
        }
      }
    }

    private void NouveauToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (textBoxSource.Text != string.Empty)
      {
        if (MessageBox.Show("Do you want to delete the existing text?", "Delete text", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          textBoxSource.Text = string.Empty;
        }
      }
    }

    private void ButtonDeployClear_Click(object sender, EventArgs e)
    {
      WindowsHelper.ClearListbox(listBoxToDeploy);
      EnableDisableButtons();
    }

    private void ButtonDeployDelete_Click(object sender, EventArgs e)
    {
      WindowsHelper.DeleteSelectedItemsFromListbox(listBoxToDeploy);
      EnableDisableButtons();
    }

    private void ButtonDeploySelectAll_Click(object sender, EventArgs e)
    {
      WindowsHelper.SelectAllItemsFromListBox(listBoxToDeploy);
      EnableDisableButtons();
    }

    private void ListBoxToDeploy_SizeChanged(object sender, EventArgs e)
    {
      EnableDisableButtons();
    }

    private void ButtonDeployUnselectAll_Click(object sender, EventArgs e)
    {
      WindowsHelper.SelectAllItemsFromListBox(listBoxToDeploy, false);
      EnableDisableButtons();
    }

    private void ÀproposdeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutBoxApplication aboutBox = new AboutBoxApplication();
      aboutBox.ShowDialog();
    }

    private void ButtonClearResult_Click(object sender, EventArgs e)
    {
      textBoxResult.Text = string.Empty;
    }

    private void ButtonSaveToFile_Click(object sender, EventArgs e)
    {
      var fileContent = string.Empty;
      var filePath = string.Empty;

      using (SaveFileDialog sfd = new SaveFileDialog())
      {
        sfd.Filter = "SQL files (*.sql)|*.sql|Text files (*.txt)|*.txt|All files (*.*)|*.*";
        sfd.FilterIndex = 0;
        sfd.RestoreDirectory = true;
        if (sfd.ShowDialog() == DialogResult.OK)
        {
          filePath = sfd.FileName;
          using (StreamWriter writer = new StreamWriter(filePath))
          {
            writer.Write(textBoxResult.Text);
          }
        }
      }
    }
  }
}
