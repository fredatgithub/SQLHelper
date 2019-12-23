using System.Windows.Forms;

namespace LibraryHelper
{
  public static class WindowsHelper
    {
    public static void ClearListbox(ListBox listBox)
    {
      if (listBox.Items.Count > 0)
      {
        listBox.Items.Clear();
      }
    }

    public static void DeleteSelectedItemsFromListbox(ListBox listBox)
    {
      if (listBox.SelectedItems.Count != 0)
      {
        for (int i = listBox.SelectedIndices.Count - 1; i >= 0; i--)
        {
          listBox.Items.RemoveAt(listBox.SelectedIndices[i]);
        }

        listBox.SelectedIndex = -1;
      }
    }

    public static void SelectAllItemsFromListBox(ListBox listBox, bool selectOrUnselect = true)
    {
      for (int i = 0; i < listBox.Items.Count; i++)
      {
        listBox.SetSelected(i, selectOrUnselect);
      }
    }

    public static void UnSelectAllItemsFromListBox(ListBox listBox)
    {
      SelectAllItemsFromListBox(listBox, false);
    }

    public static void MoveItemsFromListBoxToListBox(ListBox listBoxFrom, ListBox listBoxTo)
    {
      if (listBoxFrom.SelectedItems.Count != 0)
      {
        foreach (var item in listBoxFrom.SelectedItems)
        {
          listBoxTo.Items.Add(item);
        }

        for (int i = listBoxFrom.SelectedIndices.Count - 1; i >= 0; i--)
        {
          listBoxFrom.Items.RemoveAt(listBoxFrom.SelectedIndices[i]);
        }

        listBoxFrom.SelectedIndex = -1;
      }
    }
  }
}
