using days3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using days3.Models;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace days3
{
    public sealed partial class MainPage : Page
    {
        private List<Book> Books;
    }


    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Books = BookManage.GetBooks();
        }
        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var book = (Book)e.ClickedItem;
            ResultTextBlock.Text = "you selected" + book.Title;
        }
            }
}
