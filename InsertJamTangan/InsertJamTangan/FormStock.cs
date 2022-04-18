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
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        //string connectString = "server=localhost;uid=root;pwd=;database=jam_tangan";
        string sqlQuery;
        public static string SKU;

        FormLogin fLogIn;
        public void init(FormLogin f)
        {
            fLogIn = f;
        }

        //DIPAKE WAKTU MUNCULIN FILTER ALL
        private void ShowAll(object sender, EventArgs e)
        {
            DataTable dtstock = new DataTable();
            //sqlConnect = new MySqlConnection(connectString);        
            sqlCommand = new MySqlCommand(sqlQuery, fLogIn.conn);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtstock);
            dgvStock.DataSource = dtstock;
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            try
            {
                cboxMerk.Text = "All";
                sqlQuery = "SELECT j_sku as `SKU`, j_merk as `Product Name`, concat(`j_warna`, ' (', `j_ukuran`, ')') as `Details`, j_stok as `Stock` from jam_tangan where j_delete=0";
                ShowAll(sender, e);
                labelJmlproduk.Text = "Jumlah Produk: " + (dgvStock.Rows.Count - 1) + " item";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboxMerk_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboxMerk.Text == "All")
                {
                    FormStock_Load(sender, e);
                }
                else
                {
                    sqlQuery = "SELECT j_sku as `SKU`, j_merk as `Product Name`, concat(`j_warna`, ' (', `j_ukuran`, ')') as `Details`, j_stok as `Stock` from jam_tangan where j_merk like '"+ cboxMerk.Text +"%'";
                    ShowAll(sender, e);
                    labelJmlproduk.Text = "Jumlah Produk: " + (dgvStock.Rows.Count - 1) + " item";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBackStock_Click(object sender, EventArgs e)
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

        public void stock_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SKU = dgvStock.Rows[e.RowIndex].Cells["SKU"].Value.ToString();
                FormUpdate formUpdate = new FormUpdate();
                formUpdate.init(fLogIn);
                formUpdate.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelJmlproduk_Click(object sender, EventArgs e)
        {

        }
    }
}
