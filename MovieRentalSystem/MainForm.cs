using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

      
        void MethodToReuseDialogDisplay(Form o)
        {
            o.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MethodToReuseDialogDisplay(new Return());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MethodToReuseDialogDisplay(new Reports());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lnk_AddCustomer_Click(object sender, EventArgs e)
        {
            ALLHIDE();
            pnl_customeradd.Visible = true;
        }

        private void ALLHIDE()
        {
            pnl_top10.Visible = pnl_return.Visible = pnl_viewmovie.Visible = pnl_customeradd.Visible = pnl_customerview.Visible = pnl_addmovie.Visible = false;
        }

        private void addcustomer_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "" || tb2.Text == "" || tb3.Text == "" || tb.Text == "")
            {
                MessageBox.Show("****Fill mandatory fields*****");
            }
            else
            {
                DBContextHelper database = new DBContextHelper();
                database.CreateCust(tb1.Text, tb2.Text, tb3.Text, tb.Text);
                MessageBox.Show("Customer Added");
                tb1.Text = tb2.Text = tb3.Text = tb.Text = "";
                ALLHIDE();
            }
        }

        private void lnk_ViewCustomers_Click(object sender, EventArgs e)
        {
            ALLHIDE();
            pnl_customerview.Visible = true;
            gridcustomer.DataSource = new DBContextHelper().GetAllCust();
        }

      
        private void editToolStripMenuItemCustomer_Click(object sender, EventArgs e)
        {
            EditCustomer obj = new EditCustomer(gridcustomer.SelectedRows[0].Cells[0].Value.ToString());

            obj.ShowDialog();
            gridcustomer.DataSource = new DBContextHelper().GetAllCust();
        }

        private void addmovie_Click(object sender, EventArgs e)
        {
            int a, b;

            if (textBoxtitle.Text == "" || textBoxrating.Text == "" || textBoxyear.Text == "" || textboxcopies.Text == "" || textboxplot.Text == "" || extboxgenere.Text == "")
            {
                MessageBox.Show("****Fill mandatory fields*****");
            }
            else if (!int.TryParse(textBoxyear.Text, out a) || !(int.TryParse(textboxcopies.Text, out b)))
            {
                MessageBox.Show("Year and Copies must be a correct value");
            }
            else
            {
                int rental = 0;
                if ((DateTime.Now.Year - a) > 5)
                {
                    rental = 2;
                }
                else
                {
                    rental = 5;
                }

                DBContextHelper database = new DBContextHelper();
                database.CreateMovie(textBoxtitle.Text, textBoxrating.Text, textBoxyear.Text, rental.ToString(), textboxcopies.Text, textboxplot.Text, extboxgenere.Text);

                MessageBox.Show("Movie Added");
                ALLHIDE();
            }
        }

        private void lnk_AddMovie_Click(object sender, EventArgs e)
        {
            ALLHIDE();
            pnl_addmovie.Visible = true;
        }

        private void lnk_ViewMovies_Click(object sender, EventArgs e)
        {
            ALLHIDE();
            pnl_viewmovie.Visible = true;
            gridmovie.DataSource = new DBContextHelper().GetAllMovies();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMovie obj = new EditMovie(gridmovie.SelectedRows[0].Cells[0].Value.ToString());
            obj.ShowDialog();
            gridmovie.DataSource = new DBContextHelper().GetAllMovies();
        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int copies = new DBContextHelper().CheckCopies(Convert.ToInt32(gridmovie.SelectedRows[0].Cells[0].Value));
            if (copies > 0)
            {
                Issue issueRental = new Issue(gridmovie.SelectedRows[0].Cells[0].Value.ToString());
                issueRental.ShowDialog();
                gridmovie.DataSource = new DBContextHelper().GetAllMovies();
            }
            else
            {
                MessageBox.Show("No copy available to rent");
            }
        }

        private void lnk_IssueMovie_Click(object sender, EventArgs e)
        {
            ALLHIDE();
            pnl_viewmovie.Visible = true;
            gridmovie.DataSource = new DBContextHelper().GetAllMovies();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to reurn this rental?", "Return Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string Date = DateTime.Now.ToString("MM/dd/yyyy") + " " + DateTime.Now.ToShortTimeString();
                DBContextHelper database = new DBContextHelper();
                database.ReturnMovie(Date, dataGridView1return.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show("Movie Returned");

                dataGridView1return.DataSource = new DBContextHelper().MoviesToBeReturned();
            }
        }

        private void lnk_ReturnMovie_Click(object sender, EventArgs e)
        {
            ALLHIDE();
            pnl_return.Visible = true;
            dataGridView1return.DataSource = new DBContextHelper().MoviesToBeReturned();
        }

        private void lnk_top10_Click(object sender, EventArgs e)
        {
            ALLHIDE();
            pnl_top10.Visible = true;
            gridc.DataSource = new DBContextHelper().GetMostValuedCust();
            gridm.DataSource = new DBContextHelper().GetBestSellers();
        }

        private void lnk_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
