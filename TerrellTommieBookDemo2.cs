using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookInfo book1 = new BookInfo();// Makes room in memory 
            BookInfo book2 = new BookInfo();
            BookInfo book3 = new BookInfo();




            book1.ISBN = 878444555;/// Information about each book. Infomation is sent to  boolean
            book1.Title = "History";
            book1.Author = " Richard-Gifts, Susan";
            book1.Price = 15;

            book2.ISBN = 878444555;
            book2.Title = "Spanish";
            book2.Author = "Swinn, Peter";
            book2.Price = 25;

            book3.ISBN = 776112945;
            book3.Title = "English";
            book3.Author = "Quarter, Lynn";
            book3.Price = 85;

           

            /// Displays results in label.

            lblResults.Text += "ISBN: " + book1.ISBN + " - " + book1.Title + " by : " + book1.Author + " will cost " + book1.Price.ToString() + "\n";
            lblResults.Text += "ISBN: " + book2.ISBN.Equals(book1.ISBN) + " This book has the same ISBN as Book 1\n";
            lblResults.Text += "ISBN: " + book3.ISBN + " - " + book3.Title + " by : " + book3.Author + " will cost " + book3.Price.ToString() + "\n";
           

        }

    }
}

class BookInfo /// Books information class
{
    private int isbn;
    private string title;
    private string author;
    protected double price;

    public int ISBN
    {
        get
        {
            return isbn;
        }
        set
        {
            isbn = value;
        }
    }
    public string Title
    {
        get
        {
            return this.title;
        }
        set
        {
            this.title = value;
        }
    }
    public string Author
    {
        get
        {
            return this.author;
        }
        set
        {
            this.author = value;
        }
    }
    public virtual double Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }
    public override bool Equals(object book2) ///This determines  if book1 and 2 have the same ISBN True or False.
    {
        bool equal;
        if (this.GetType() != book2.GetType())
            equal = false;
        else
        {
            BookInfo check = (BookInfo)book2;
            if (ISBN == check.ISBN)
            {
                equal = true;
            }
            else
                equal = false;
        }
        return equal;
    }
}




  
    
