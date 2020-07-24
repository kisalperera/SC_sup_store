using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BillGen
{
    public partial class Form3 : Form
    {
        

        Form1 fgd;
        public Form3(Form1 fg)
        {
            InitializeComponent();
            this.fgd = fg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-M8R5KHRO\\SQLEXPRESS;Initial Catalog=Billing;Integrated Security=True");


            int q = fgd.dataGridBill.CurrentRow.Index;
            int cov = Convert.ToInt32(fgd.dataGridBill.CurrentRow.Cells[3].Value.ToString());
            string state = "";
            string war = "";


            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT state FROM stocks WHERE stockId ='" + cbStockIdRemove.Text + "' ", con);
            SqlDataReader dr2 = cmd1.ExecuteReader();
            if (dr2.Read())
            {
                state = dr2["state"].ToString();

            }
            else
            {
                 war ="No";
            }

            con.Close();

            if (state == "True" || cbStockIdRemove.Text.Length==0 || war=="No")
            {
                MessageBox.Show("Please Enter an item in the bill", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {


                if (MessageBox.Show("Are you sure you want to remove this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int a = 0;

                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("UPDATE stocks SET state = 1  WHERE stockId = '" + cbStockIdRemove.Text + "'  ", con);
                    cmd2.ExecuteNonQuery();

                    fgd.stocklist.Remove(cbStockIdRemove.Text);

                    if (cov > 1)
                    {
                        cov = cov - 1;
                        fgd.dataGridBill.Rows[q].Cells[3].Value = Convert.ToString(cov);


                        int unc = Convert.ToInt32(fgd.dataGridBill.Rows[q].Cells[4].Value.ToString());
                        int qc = Convert.ToInt32(fgd.dataGridBill.Rows[q].Cells[3].Value.ToString());
                        fgd.dataGridBill.Rows[q].Cells[5].Value = Convert.ToString(unc * qc);

                        a = Convert.ToInt32(fgd.dataGridBill.Rows[q].Cells[4].Value.ToString());

                    }
                    else
                    {
                        a = Convert.ToInt32(fgd.dataGridBill.Rows[q].Cells[4].Value.ToString());
                        fgd.dataGridBill.Rows.RemoveAt(q);
                    }


                    int b = Convert.ToInt32(fgd.txtBillSubTotal.Text);

                    fgd.txtBillSubTotal.Text = Convert.ToString(b - a);

                    cbStockIdRemove.Text = "";

                    con.Close();
                    fgd.Enabled = true;

                    this.Close();

                }
            }
        }

        private void btnRemoveCancel_Click(object sender, EventArgs e)
        {
            fgd.Enabled = true;
            this.Close();
            
        }

        private void cbStockIdRemove_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}