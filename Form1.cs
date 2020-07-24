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
using System.Linq.Expressions;

namespace BillGen
{    
    public partial class Form1 : Form
    {           
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-M8R5KHRO\\SQLEXPRESS;Initial Catalog=Billing;Integrated Security=True");
        
        public List<string> stocklist = new List<string>();
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ID="";
            Guid id = Guid.NewGuid();
            ID = id.ToString().Substring(0, 5).Replace("-", "").ToUpper(); 

            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT invoiceId FROM sales WHERE invoiceId ='" + ID + "' ", con);
            SqlDataReader dr2 = cmd1.ExecuteReader();

            if (dr2.Read())
            {
                for (int i = 0; i < 1;) 
                {
                    id = Guid.NewGuid();
                    ID = id.ToString().Substring(0, 5).Replace("-", "").ToUpper();
                    dr2 = cmd1.ExecuteReader();
                    if (dr2.Read()) { i = 0; }
                    else { i = 1; }
                }
            }

            txtBillInvoiceNo.Text = ID;            
            con.Close();

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Enabled = false;
            Form3 f3 = new Form3(this);
            String sort = dataGridBill.CurrentRow.Cells[1].Value.ToString();

            for (var i = 0; i < stocklist.Count; i++)
            {
                con.Open();
                string check = "";
                SqlCommand cmd1 = new SqlCommand("SELECT itemId FROM stocks WHERE stockId= '" + stocklist[i] + "'  ", con);
                SqlDataReader item = null;
                item = cmd1.ExecuteReader();

                while (item.Read())
                {
                    check = item["itemId"].ToString();
                }
                if (sort == check)
                {
                    f3.cbStockIdRemove.Items.Add(stocklist[i]);
                }
                con.Close();
            }          
            f3.Show();           
        }

        private void txtBillTotal_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-M8R5KHRO\\SQLEXPRESS;Initial Catalog=Billing;Integrated Security=True");
            string state = "";
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT state FROM stocks WHERE stockId ='" + txtBillProductCode.Text + "' ", con);
            SqlDataReader dr2 = cmd1.ExecuteReader();
            if (dr2.Read()) 
            {
                 state = dr2["state"].ToString();                 
            }     
            con.Close();

            con.Open();
                SqlCommand cmd = new SqlCommand("SELECT brand,name,flavor,price FROM items WHERE itemId = (SELECT itemId From stocks Where stockId ='" + txtBillProductCode.Text + "')", con);
                SqlDataReader dr = cmd.ExecuteReader();           

            if (dr.Read() )
                {
                   if (state == "True")
                   {
                    txtBillDescription.Text = (dr["brand"].ToString() + " - " + dr["name"].ToString() + " - " + dr["flavor"].ToString());
                    txtBillPrice.Text = (dr["price"].ToString());
                   }
                }

                else
                {
                    txtBillDescription.Text = "";
                    txtBillPrice.Text = "";
                }
            con.Close();
        }
       

        private void addData(String item,String Description, String Price)
        {
            String[] row = { null,item, Description,Convert.ToString(1), Price,Price };
            dataGridBill.Rows.Add(row);
        }

        private void btnBillAdd_Click(object sender, EventArgs e)
        {
            stocklist.Add(txtBillProductCode.Text);

            if (txtBillPrice.Text.Length == 0) {
                MessageBox.Show("Please enter a valid Stock ID?", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBillProductCode.Text = "";
            }

            else
            {                
                con.Open();
                String itemId = "";
                SqlCommand cmd1 = new SqlCommand("SELECT itemId FROM stocks WHERE stockId= '" + txtBillProductCode.Text + "'  ", con);
                SqlCommand cmd2 = new SqlCommand("UPDATE stocks SET state = 0  WHERE stockId = '" + txtBillProductCode.Text + "'  ", con);
                SqlDataReader item = null;
                cmd2.ExecuteNonQuery();
                item = cmd1.ExecuteReader();

                while (item.Read())
                {
                    itemId = item["itemId"].ToString();                    
                }

                int x = -1;
                for (int i = 0; i < dataGridBill.Rows.Count; i++)
                {                    
                        if (dataGridBill.Rows[i].Cells[1].Value.ToString() == itemId )
                        {
                         x = i;
                        }                    
                }
                    if (x>=0)
                {
                    string val = dataGridBill.Rows[x].Cells[3].Value.ToString();
                    int valnxt = Convert.ToInt32(val);
                    valnxt = valnxt + 1;
                    val = Convert.ToString(valnxt);
                    dataGridBill.Rows[x].Cells[3].Value = val;
                    int unc = Convert.ToInt32(dataGridBill.Rows[x].Cells[4].Value.ToString());
                    int tpr = valnxt * unc;

                    dataGridBill.Rows[x].Cells[5].Value = Convert.ToString(tpr);
                }

                else
                {
                    addData(itemId, txtBillDescription.Text, txtBillPrice.Text);
                }                        

                txtBillSubTotal.Text = (from DataGridViewRow row in dataGridBill.Rows
                                        where row.Cells[5].FormattedValue.ToString() != string.Empty
                                        select Convert.ToInt32(row.Cells[5].FormattedValue)).Sum().ToString();
                                
                con.Close();

                txtBillProductCode.Text = "";
                txtBillDescription.Text = "";
                txtBillPrice.Text = "";
            }         
        }       

        private void txtBillSubTotal_TextChanged(object sender, EventArgs e)
        { 
            int one = 0;
            try {  one = Convert.ToInt32(txtBillSubTotal.Text); }
            catch (Exception) { };
            int two = 0;
            int three = 0;
            if (txtBillOther.Text.Length > 0) {  two = Convert.ToInt32(txtBillOther.Text); }
            if (txtBillDiscount.Text.Length > 0) {  three = Convert.ToInt32(txtBillDiscount.Text); }
            
            int four = one + two - three;
            String grandt = Convert.ToString(four);
            txBillGrandTotal.Text = grandt;            
        }

        private void txtBillOther_TextChanged(object sender, EventArgs e)
        {
            int gt = 0;
            try
            {
                 gt = Convert.ToInt32(txtBillSubTotal.Text);
            }
            catch (Exception) { }

            int ot = 0;             
            try
            {
                ot = Convert.ToInt32(txtBillOther.Text);
            }
            catch (Exception) { }

            int both = gt + ot;
            String grt = Convert.ToString(both);
            txBillGrandTotal.Text = grt;
        }       

        private void btnBillProceed_Click(object sender, EventArgs e)
        {    
            if (dataGridBill.Rows.Count < 1)
            {
                MessageBox.Show("No products are being sold", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(txtBillName.TextLength == 0)
            {
                MessageBox.Show("Please Enter customer details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                //-----------------------customer------------------------------
                con.Open();
                SqlDataAdapter nda = new SqlDataAdapter("SELECT contactNo FROM customer WHERE contactNo = '" + txtBillCntNo.Text + "'", con);
                DataTable datb = new DataTable();
                nda.Fill(datb);
                if (datb.Rows.Count == 0)                
                {
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO customer (contactNo,name,adress) VALUES ('" + txtBillCntNo.Text + "','" + txtBillName.Text + "','" + txtBillAdress.Text + "')", con);
                    cmd2.ExecuteNonQuery();                    
                }
                con.Close();
                //-------------------------customer-------------------------

                //-----------------sales-------------------
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO sales VALUES ('" + txtBillInvoiceNo.Text + "','" + txtBillDate.Text + "','" + txtBillOther.Text + "','"+txtBillDiscount.Text + "','" +txtBillCntNo.Text+ "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                //-----------------sales-------------------
                
                for (int i = 0; i < dataGridBill.Rows.Count; i++)
                {
                    con.Open();

                    //----------------items------------------------
                    int qt = 0;
                    SqlCommand cmd1 = new SqlCommand("SELECT qty FROM items WHERE itemId= '" + dataGridBill.Rows[i].Cells[1].Value + "'  ", con);
                    SqlDataReader item = null;
                    item = cmd1.ExecuteReader();

                    while (item.Read())
                    {
                        qt = Convert.ToInt32(item["qty"].ToString());
                                                
                    }
                   
                    int cq = Convert.ToInt32(dataGridBill.Rows[i].Cells[3].Value.ToString());
                    int fq = qt - cq;
                    con.Close();


                    con.Open();
                    SqlCommand cmdn = new SqlCommand("UPDATE items SET qty = '" + fq +"'  WHERE itemId = '" + dataGridBill.Rows[i].Cells[1].Value + "'  ", con);
                    cmdn.ExecuteNonQuery();

                    //--------------------items-------------------------

                    //------------sales_item-------------------------
                    SqlCommand cd = new SqlCommand("INSERT INTO sales_item (invoiceId,itemId,qty) VALUES ('" + txtBillInvoiceNo.Text + "','" + dataGridBill.Rows[i].Cells[1].Value + "','" + dataGridBill.Rows[i].Cells[3].Value + "')", con);
                    cd.ExecuteNonQuery();
                    //-----------------------sales_item-------------------------------

                    con.Close();
                }

                //----------------------------stocks-------------------------
                SqlCommand cd2 = new SqlCommand("DELETE FROM  stocks  WHERE state = 0 ", con);
                con.Open();
                cd2.ExecuteNonQuery();
                con.Close();
                //-------------------------stocks---------------------------------

                dataGridBill.Rows.Clear();

                try
                {
                    txtBillCntNo.Text = "";
                    txtBillName.Text = "";
                    txtBillAdress.Text = "";
                    txBillGrandTotal.Text = "";
                    txtBillDiscount.Text = "";
                    txtBillSubTotal.Text = "";
                    txtBillOther.Text = "";
                    txtBillDate.Value = DateTime.Now;
                    txtBillInvoiceNo.Text = "";
                    Form1_Load(this, null);
                }
                catch (Exception) { };                
            }
        }              

        private void txtBillDiscount_TextChanged(object sender, EventArgs e)
        {
                int val1 = 0;
                int val2 = 0;
                int val3 = 0;
            
            try
            {
                val1 = Convert.ToInt32(txtBillSubTotal.Text);
                val2 = Convert.ToInt32(txtBillOther.Text);
                val3 = Convert.ToInt32(txtBillDiscount.Text);
            }
            catch (Exception) { }          
                    
            int val4 = val1 + val2 - val3;
            String send = Convert.ToString(val4);
            txBillGrandTotal.Text = send;    
        
        }

        private void dataGridBill_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridBill.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void txtBillCntNo_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT name,adress FROM customer WHERE contactNo = '" + txtBillCntNo.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtBillName.Text = (dr["name"].ToString());
                if (dr["adress"].ToString() != null)
                {
                    txtBillAdress.Text = (dr["adress"].ToString());
                }
            }
            else
            {
                txtBillName.Text = "";
                txtBillAdress.Text = "";
            }
            con.Close();
        }        
        private void btnBillCancel_Click(object sender, EventArgs e)
        {                        
                if (MessageBox.Show("Are you sure you want to cancel this invoice?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                    for (var i = 0; i < stocklist.Count; i++)
                    {
                        con.Open();
                        SqlCommand cmd2 = new SqlCommand("UPDATE stocks SET state = 1  WHERE stockId = '" + stocklist[i] + "'  ", con);
                        cmd2.ExecuteNonQuery();
                        con.Close();
                    }

                    dataGridBill.Rows.Clear();
                    stocklist.Clear();

                    txtBillCntNo.Text = "";
                    txtBillName.Text = "";
                    txtBillAdress.Text = "";
                    txBillGrandTotal.Text = "";
                    txtBillDiscount.Text = "";
                    txtBillSubTotal.Text = "";
                    txtBillOther.Text = "";
                    txtBillDate.Value=  DateTime.Now;
                }
        }
    }
    }
