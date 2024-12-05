using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueBooks issueBooks = new IssueBooks();
            issueBooks.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentsPage studentsPage = new StudentsPage();
            studentsPage.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BooksPage booksPage = new BooksPage();
            booksPage.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnPage returnPage = new ReturnPage();
            returnPage.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrariansPage lib = new LibrariansPage();
            lib.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Updates updates = new Updates();
            updates.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            Dash dash = new Dash();
            dash.Show();
        }
    }
}
