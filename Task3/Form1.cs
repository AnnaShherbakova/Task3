using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Task3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            IEdition book1 = new Directory(1987, 3, "A5", 253, "Hard", "Name1");
            IEdition book2 = new Directory(1998, 2, "A4", 61, "Soft", "Name2");
            Directory book3 = new Directory(2004, 1, "A4", 521, "Hard", "Name3");
            IEdition book4 = new Directory(2013, 4, "A5", 413, "Hard", "Name4");
            Directory book5 = new Directory(1977, 3, "A4", 644, "Hard", "Name5");

            book1.AddAuthor(2);
            book4.RemoveAuthor(1);
            book5.ChangeName("Name55");
            book3.SetBinding("Soft");

            List<IEdition> Books = new List<IEdition>
            {
                book1, book2, book3, book4, book5
            };

            for (int i = 0; i < Books.Count; i++)
            {
                textBox1.Text += Books[i].ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
