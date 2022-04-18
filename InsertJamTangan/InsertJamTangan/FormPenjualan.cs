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
    public partial class FormPenjualan : Form
    {
        public FormPenjualan()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtIDReseller = new DataTable();
        bool ada=false;
        public double subtotal;
        public double total;
        public double price;
        public double HargaSetelahDiskon;
        public string IDmembership;
        public string index;
        public string qty;
        public int totalQty;
        public string persen;
        FormLogin fLogIn;
        public void init(FormLogin f)
        {
            fLogIn = f;
        }

        private void IDJual()
        {
            try
            {
                MySqlCommand cmdIDJual = new MySqlCommand();
                cmdIDJual.Connection = fLogIn.conn;
                cmdIDJual.CommandText = "SELECT fGENBeliID()";
                tboxIDJual.Text = cmdIDJual.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FormPenjualan_Load(object sender, EventArgs e)
        {
            IDJual();
            IsiProduk();
            IsiNmPembeli();
        }

        private void IsiProduk()
        {
            try
            {
                DataTable dtProduk = new DataTable();
                if (rbutDW.Checked == true)
                {
                    sqlQuery = "SELECT concat('(', j_ukuran, ') ', j_warna, ' ', j_merk) as `produk`, j_sku as `SKU` from jam_tangan where J_MERK like 'Daniel Wellington%' order by `produk` asc";
                }
                else if (rbutLacoste.Checked == true)
                {
                    sqlQuery = "SELECT concat('(', j_ukuran, ') ', j_warna, ' ', j_merk) as `produk`, j_sku as `SKU` from jam_tangan where J_MERK like 'Lacoste%' order by `produk` asc";
                }
                else if (rbutTimex.Checked == true)
                {
                    sqlQuery = "SELECT concat('(', j_ukuran, ') ', j_warna, ' ', j_merk) as `produk`, j_sku as `SKU` from jam_tangan where J_MERK like 'Timex%' order by `produk` asc";
                }

                sqlCommand = new MySqlCommand(sqlQuery, fLogIn.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtProduk);
                cboxNamaProduk.DisplayMember = "produk";
                cboxNamaProduk.ValueMember = "SKU";
                cboxNamaProduk.SelectedValue = dtProduk.Rows[0]["SKU"].ToString();
                cboxNamaProduk.Text = dtProduk.Rows[0]["produk"].ToString();
                cboxNamaProduk.DataSource = dtProduk;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void IsiNmPembeli()
        {
            try
            {
                DataTable dtReseller = new DataTable();
                sqlQuery = "SELECT R_NAMA as `Nama Reseller`, R_ID as `ID Reseller` from reseller";
                sqlCommand = new MySqlCommand(sqlQuery, fLogIn.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtReseller);        
                cboxNamaPembeli.DisplayMember = "Nama Reseller";
                cboxNamaPembeli.ValueMember = "ID Reseller";
                cboxNamaPembeli.SelectedValue = dtReseller.Rows[0]["ID Reseller"].ToString();
                cboxNamaPembeli.Text = dtReseller.Rows[0]["Nama Reseller"].ToString();
                cboxNamaPembeli.DataSource = dtReseller;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cboxNamaProduk_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cboxNamaProduk.Text != "")
                {
                    //max jumlah
                    sqlQuery = "SELECT j_stok as `jumlah`, j_harga as `price` from jam_tangan where j_sku = '" + cboxNamaProduk.SelectedValue.ToString() + "'";
                    DataTable dtstock = new DataTable();
                    sqlCommand = new MySqlCommand(sqlQuery, fLogIn.conn);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtstock);
                    Jumlah.Maximum = Convert.ToInt32(dtstock.Rows[0]["jumlah"]);
                    Jumlah.Minimum = 1;

                    labelHarga.Text = dtstock.Rows[0]["price"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cboxNamaPembeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                fIDReseller();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbutDW_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cboxNamaProduk.Text = "";
                IsiProduk();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbutLacoste_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cboxNamaProduk.Text = "";
                IsiProduk();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbutTimex_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cboxNamaProduk.Text = "";
                IsiProduk();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBackPenjualan_Click(object sender, EventArgs e)
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

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = "SELECT m_diskon as `diskon`, m.m_id as `IDmembership` from membership m, reseller r where m.m_id = r.m_id and r.r_id = '" + cboxNamaPembeli.SelectedValue.ToString() + "'";
                DataTable dtMembership = new DataTable();
                sqlCommand = new MySqlCommand(sqlQuery, fLogIn.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtMembership);
                IDmembership = dtMembership.Rows[0]["IDmembership"].ToString();
      
                if (dgvPenjualan.RowCount > 1)
                { 
                    //TAMBAH DATA DI DGV DAN SORT
                    ada = false;
                    for (int i = 0; i < dgvPenjualan.Rows.Count-1; i++)
                    {
                        if (dgvPenjualan.Rows[i].Cells[0].Value.ToString() == cboxNamaProduk.SelectedValue.ToString())
                        {
                            ada = true;
                            qty = dgvPenjualan.Rows[i].Cells[2].Value.ToString();
                            qty = Convert.ToString(Convert.ToInt32(qty)+Convert.ToInt32(Jumlah.Value));

                            fSubtotal();

                            subtotal += Convert.ToDouble(dgvPenjualan.Rows[i].Cells[4].Value);
                            dgvPenjualan.Rows[i].Cells[2].Value = qty;
                            dgvPenjualan.Rows[i].Cells[4].Value = subtotal;
                            MessageBox.Show("Quantity has been changed");
                        }
                    }
                }
                if(ada==false)
                {
                    fSubtotal();
                    dgvPenjualan.Rows.Add(cboxNamaProduk.SelectedValue.ToString(), cboxNamaProduk.Text, Jumlah.Value.ToString(), labelHarga.Text, subtotal);
                }
                persen = dtMembership.Rows[0]["diskon"].ToString().Replace(',', '.');
                labelPersen.Text = dtMembership.Rows[0]["diskon"].ToString() + "%";
                fPenghitunganHarga();
                ada = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (index == "-1")
                {
                    MessageBox.Show("Choose product to be deleted");
                }
                else
                {
                    foreach (DataGridViewRow row in dgvPenjualan.SelectedRows)
                    {
                        total = total - Convert.ToDouble(dgvPenjualan.Rows[row.Index].Cells[4].Value);
                        fPenghitunganHarga();
                        dgvPenjualan.Rows.RemoveAt(row.Index);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fSubtotal()
        {
            try
            {
                MySqlCommand cmdSubtotal = new MySqlCommand();
                cmdSubtotal.Connection = fLogIn.conn;
                cmdSubtotal.CommandText = "select KMMI6.fSubtotalHarga('" + cboxNamaProduk.SelectedValue.ToString() + "', " + Jumlah.Value.ToString() + ")";
                subtotal = Convert.ToDouble(cmdSubtotal.ExecuteScalar().ToString());
                total += subtotal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fPenghitunganHarga()
        {
            try
            {
                MySqlCommand cmdHargaSetelahDiskon = new MySqlCommand();
                cmdHargaSetelahDiskon.Connection = fLogIn.conn;
                cmdHargaSetelahDiskon.CommandText = "select KMMI6.fHargaSetelahDiskon(" + total + ", '" + IDmembership + "')";
                HargaSetelahDiskon = Convert.ToDouble(cmdHargaSetelahDiskon.ExecuteScalar());
                labelSetelahDiskon.Text = "$" + HargaSetelahDiskon.ToString();
                labelTotalHarga.Text = ": $" + total.ToString();
                labelDiskon.Text = ": $" + Convert.ToString(total - HargaSetelahDiskon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fIDReseller()
        {
            try
            {
                MySqlCommand cmdtboxIDReseller = new MySqlCommand();
                cmdtboxIDReseller.Connection = fLogIn.conn;
                cmdtboxIDReseller.CommandText = "SELECT R_ID as `ID Reseller` from reseller where R_ID = '" + cboxNamaPembeli.SelectedValue.ToString() + "'";
                tboxIDReseller.Text = cmdtboxIDReseller.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                //DATAGRID KOSONG
                if (dgvPenjualan.Rows.Count <= 1)
                {
                    MessageBox.Show("Select a product first, please");
                }
                else
                {
                    for (int i = 0; i < dgvPenjualan.Rows.Count - 1; i++)
                    {
                        //TOTAL PCS PEMBELIAN
                        totalQty += Convert.ToInt32(dgvPenjualan.Rows[i].Cells[2].Value);
                        
                        //INSERT KE DETAIL
                        MySqlCommand cmdInsertDetail = new MySqlCommand();
                        cmdInsertDetail.Connection = fLogIn.conn;
                        cmdInsertDetail.CommandText = "call KMMI6.pInsertDetailBeli('"+ tboxIDJual.Text+"','"+ dgvPenjualan.Rows[i].Cells[0].Value.ToString() + "','"+ dgvPenjualan.Rows[i].Cells[2].Value.ToString() + "','"+ dgvPenjualan.Rows[i].Cells[4].Value.ToString() + "','0')";
                        cmdInsertDetail.ExecuteScalar();
                    }
                    //INSERT TRANSAKSI PEMBELIAN
                    MySqlCommand cmdInsertTrans = new MySqlCommand();
                    cmdInsertTrans.Connection = fLogIn.conn;
                    cmdInsertTrans.CommandText = "call KMMI6.pInsertTransaksiPembelian('" + tboxIDJual.Text + "','" + tboxIDReseller.Text + "','" + dateTimePickerPenjualan.Value.ToString("yyyy-MM-dd") + "','"+totalQty.ToString()+"','" + total.ToString() + "','"+ persen +"','"+HargaSetelahDiskon.ToString().Replace(',','.')+"','0','0')";
                    cmdInsertTrans.ExecuteScalar();
                }
                MessageBox.Show("Success!");
                dgvPenjualan.Rows.Clear();
                totalQty = 0;
                subtotal = 0;
                total = 0;
                price = 0;
                HargaSetelahDiskon = 0;
                Jumlah.Value = 1;
                IDJual();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
