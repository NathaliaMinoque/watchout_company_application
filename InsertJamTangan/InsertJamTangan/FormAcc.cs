using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace InsertJamTangan
{
    public partial class FormAcc : Form
    {
        public FormAcc()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        //string connectString = "server=localhost;uid=root;pwd=;database=jam_tangan";
        string sqlQuery;
        public static string IDBeli;

        FormLogin fLogIn;
        public void init(FormLogin f)
        {
            fLogIn = f;
        }

        //MINOQ
        private void FormAcc_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtAcc = new DataTable();
                //sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "SELECT beli_tanggal as `Date`, beli_id as `ID`, r_nama as `Reseller Name`, beli_jmlbrg as `Quantity`, t.beli_diskon as `Discount (%)`, BELI_TOTALFINAL as `Price ($)` from transaksi_pembelian t, reseller r, membership m where beli_acc='0' and t.R_ID=r.R_ID and r.m_id=m.m_id";
                sqlCommand = new MySqlCommand(sqlQuery, fLogIn.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtAcc);
                dgvAcc.DataSource = dtAcc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBackAcc_Click(object sender, EventArgs e)
        {
            try
            {
                FormHome formHome = new FormHome();
                formHome.init(fLogIn);
                formHome.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDBeli = dgvAcc.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to accept this purchase?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "update transaksi_pembelian set beli_acc=1 where beli_id='"+ IDBeli +"'";
                    sqlCommand = new MySqlCommand(sqlQuery, fLogIn.conn);
                    //sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    //sqlConnect.Close();
                    FormAcc_Load(sender, e);
                }
                else
                {
                    FormAcc_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            FormDetailAcc formAcc = new FormDetailAcc();
            formAcc.init(fLogIn);
            formAcc.Show();
            this.Hide();
        }
    }
}
