using LibraryHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace UnitTestLibraryHelper
{
  [TestClass]
  public class UnitTestWindowsHelper
  {
    [TestMethod]
    public void TestMethod_ClearListbox()
    {
      ListBox source = new ListBox();
      source.Items.Add("item1");
      source.Items.Add("item2");
      WindowsHelper.ClearListbox(source);
      int expected = 0;
      int result = source.Items.Count;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DeleteSelectedItemsFromListbox()
    {
      ListBox source = new ListBox();
      source.Items.Add("item1");
      source.Items.Add("item2");
      source.Items.Add("item3");
      source.Items.Add("item4");
      source.SetSelected(0, true);
      WindowsHelper.DeleteSelectedItemsFromListbox(source);
      int expected = 3;
      int result = source.Items.Count;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DeleteSelectedItemsFromListbox_2_items()
    {
      ListBox source = new ListBox();
      source.Items.Add("item1");
      source.Items.Add("item2");
      source.Items.Add("item3");
      source.Items.Add("item4");
      source.SetSelected(0, true);
      source.SetSelected(3, true);
      WindowsHelper.DeleteSelectedItemsFromListbox(source);
      int expected = 2;
      int result = source.Items.Count;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_SelectAllItemsFromListBox()
    {
      ListBox source = new ListBox();
      source.Items.Add("item1");
      source.Items.Add("item2");
      source.Items.Add("item3");
      source.Items.Add("item4");
      WindowsHelper.SelectAllItemsFromListBox(source);
      bool expected = true;
      bool result = source.SelectedIndices.Count == source.Items.Count;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_UnSelectAllItemsFromListBox()
    {
      ListBox source = new ListBox();
      source.Items.Add("item1");
      source.Items.Add("item2");
      source.Items.Add("item3");
      source.Items.Add("item4");
      WindowsHelper.SelectAllItemsFromListBox(source);
      WindowsHelper.UnSelectAllItemsFromListBox(source);
      bool expected = true;
      bool result = source.SelectedIndices.Count == 0;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_MoveItemsFromListBoxToListBox()
    {
      ListBox source1 = new ListBox();
      ListBox source2 = new ListBox();
      source1.Items.Add("item1");
      source1.Items.Add("item2");
      source1.Items.Add("item3");
      source1.Items.Add("item4");
      int source1NumberOfItems = source1.Items.Count;
      WindowsHelper.SelectAllItemsFromListBox(source1);
      WindowsHelper.MoveItemsFromListBoxToListBox(source1, source2);
      int expected = source1NumberOfItems;
      int result = source2.Items.Count;
      Assert.AreEqual(result, expected);
    }

    private bool AreAllItemsSelected(ListBox listBox)
    {
      return listBox.SelectedIndices.Count == listBox.Items.Count;
    }
  }
}
