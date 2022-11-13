using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssesedExercise1C
{
    public partial class Form1 : Form
    {
        LinkListGen<Book> BookList = new LinkListGen<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void typeBookNametxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeISBNtxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBookbtn_Click(object sender, EventArgs e)
        {
            /*             List<Book> books = new List<Book>();
                        Book books = new Book(typeBookNametxtBox, typeISBNtxtBox);
                        String insertedBookname = Convert.ToString(typeBookNametxtBox.Text);
                        Book newbooks = new Book();
                        BookList.AddItem(newbooks);
                        DisplayLabel.Text = BookList.DisplayItems();*/

            string isbnvalue = typeISBNtxtBox.Text;
            string titlevalue = typeBookNametxtBox.Text;
            
            

            Book books = new Book(isbnvalue, titlevalue);
            books.ToString();
            // String insertedBookname = Convert.ToString(typeBookNametxtBox);

            //  Book newbooks = new Book(titlevalue, isbnvalue);
            listOfBooks.Items.Add(books);           
            BookList.AddItem(books);


            
           // listOfBooks.Text = BookList.DisplayItems();
          // DisplayLabel.Text = BookList.DisplayItems();


        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RemoveBookbtn_Click(object sender, EventArgs e)
        {
            string isbnvalue = typeISBNtxtBox.Text;
            string titlevalue = typeBookNametxtBox.Text;


            Book removeBook = new Book(isbnvalue, titlevalue);
            listOfBooks.Items.Remove(removeBook);
            BookList.RemoveItem(removeBook);
            
        }
    }
}
