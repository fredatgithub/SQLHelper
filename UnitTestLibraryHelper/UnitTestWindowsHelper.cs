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
  }
}
