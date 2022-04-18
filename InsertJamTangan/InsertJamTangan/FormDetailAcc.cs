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

namespace InsertJamTangan
{
    public partial class FormDetailAcc : Form
    {
        public FormDetailAcc()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        //string connectString = "server=localhost;uid=root;pwd=;database=jam_tangan";
        string sqlQuery;

        FormLogin fLogIn;
        public void init(FormLogin f)
        {
            fLogIn = f;
        }

        //MINOQ
        private void buttonBackAcc_Click(object sender, EventArgs e)
        {
            FormAcc formAcc = new FormAcc();
            formAcc.init(fLogIn);
            formAcc.Show();
            this.Hide();
        }

        private void FormDetailAcc_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtAcc = new DataTable();
                //sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select j_merk as `Product Name`, concat(`j_warna`, ' (', `j_ukuran`, ')') as `Details`, db_qty as `Quantity`, dr_price as `Price ($)` from detail_beli d, jam_tangan j where d.j_sku=j.j_sku and d.BELI_ID='"+ FormAcc.IDBeli+"'";
                sqlCommand = new MySqlCommand(sqlQuery, fLogIn.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtAcc);
                dgvDetailAcc.DataSource = dtAcc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to accept this purchase?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "update transaksi_pembelian set beli_acc=1 where beli_id='" + FormAcc.IDBeli + "'";
                    sqlCommand = new MySqlCommand(sqlQuery, fLogIn.conn);
                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    FormAcc formAcc = new FormAcc();
                    formAcc.init(fLogIn);
                    formAcc.Show();
                    this.Hide();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDetailAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
