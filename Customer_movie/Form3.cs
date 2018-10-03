using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_movie
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void rented_moviesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rented_moviesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.Rented_movies' table. You can move, or remove it, as needed.
            this.rented_moviesTableAdapter.Fill(this.customersDataSet.Rented_movies);

        }

        private void button1_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
