using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Search : UserControl
    {
        public Search()
        {
            InitializeComponent();
        }
        Classes.Words wordsOperations = new Classes.Words();


        private void Search_Load(object sender, EventArgs e)
        {
            randomList();
        }

        
      

        private void SearchButton_Click(object sender, EventArgs e)
        {   ListView searchResult = new ListView();
            searchResult = wordsOperations.wordSearch(searchText.Text, 1);
            wordList(searchResult, searchResult.Items.Count);
        }

        void randomList()
        {
            ListView searchResult = new ListView();
            searchResult = wordsOperations.showWords(1);
            wordList(searchResult, searchResult.Items.Count);
        }
        void wordList(ListView listListview, int itemCount)
        {
            searchListView.Items.Clear();
            for (int i = 0; i < itemCount; i++)
            {
                ListViewItem item = new ListViewItem(listListview.Items[i].SubItems[0].Text);
                item.SubItems.Add(listListview.Items[i].SubItems[1].Text);
                item.SubItems.Add(listListview.Items[i].SubItems[2].Text);
                item.SubItems.Add(listListview.Items[i].SubItems[3].Text);
                item.SubItems.Add(listListview.Items[i].SubItems[4].Text);
                item.SubItems.Add(listListview.Items[i].SubItems[5].Text);
                searchListView.Items.Add(item);

            }
        }

        private void RandomButton_Click(object sender, EventArgs e) { randomList(); }

        private void MyListButton_Click(object sender, EventArgs e)
        {

        }
    }
}
