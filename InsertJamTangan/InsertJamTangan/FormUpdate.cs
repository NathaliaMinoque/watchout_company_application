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
    public partial class FormUpdate : Form
    {
        public FormUpdate()
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

        //INEZ
        public void FormUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                //UNTUK NGISI DATA TEXTBOX
                DataTable dtall = new DataTable();
                sqlQuery = "select j_sku as `SKU`, substring(j_sku,1,1) as `Category`, j_merk as `Merk`, j_ukuran as `Size`, j_warna as `Color`, j_harga as `Price`, j_stok as `Qty`, j_deskripsi as `Desc` from jam_tangan j where j.j_sku = '" + FormStock.SKU+"'  ";
                //sqlConnect = new MySqlConnection(connectString);
                sqlCommand = new MySqlCommand(sqlQuery, fLogIn.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtall);

                tboxSKUUpdate.Text = FormStock.SKU;
                tboxMerkUpdate.Text = dtall.Rows[0]["Merk"].ToString();
                tboxColorUpdate.Text = dtall.Rows[0]["Color"].ToString();
                tboxSizeUpdate.Text = dtall.Rows[0]["Size"].ToString();
                tboxPriceUpd.Text = dtall.Rows[0]["Price"].ToString();
                tboxDescriptionUpd.Text = dtall.Rows[0]["Desc"].ToString();
                tboxQtyUpd.Text = dtall.Rows[0]["Qty"].ToString();
                if (dtall.Rows[0]["Category"].ToString() == "K")
                {
                    tboxCategory.Text = "Kids";
                }
                else if (dtall.Rows[0]["Category"].ToString() == "W")
                {
                    tboxCategory.Text = "Women";
                }
                else if (dtall.Rows[0]["Category"].ToString() == "M")
                {
                    tboxCategory.Text = "Men";
                }

                //NGISI GAMBAR WOY             
                //sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select J_FOTO from jam_tangan where J_SKU='" + FormStock.SKU + "'";
                sqlCommand = new MySqlCommand(sqlQuery, fLogIn.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable dtGambar = new DataTable();
                sqlAdapter.Fill(dtGambar);
                byte[] img = (byte[])dtGambar.Rows[0][0];

                MemoryStream memoryStream = new MemoryStream(img);
                pictboxJamUpd.Image = Image.FromStream(memoryStream);
                sqlAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBackInsUpd_Click(object sender, EventArgs e)
        {
            try
            {
                FormStock formStock = new FormStock();
                formStock.init(fLogIn);
                formStock.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //UNTUK NGISI DATA TEXTBOX
                DataTable dtall = new DataTable();
                sqlQuery = "select j_harga as `Price`, j_stok as `Qty`, j_deskripsi as `Desc` from jam_tangan j where j.j_sku = '" + FormStock.SKU + "'  ";
                //sqlConnect = new MySqlConnection(connectString);
                sqlCommand = new MySqlCommand(sqlQuery, fLogIn.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtall);

                if (tboxPriceUpd.Text == "" || tboxQtyUpd.Text == "" || tboxDescriptionUpd.Text == "")
                {
                    MessageBox.Show("Please fill out all fields!");
                }
                else
                {

                    //sqlConnect = new MySqlConnection(connectString);
                    MemoryStream ms = new MemoryStream();
                    pictboxJamUpd.Image.Save(ms, pictboxJamUpd.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    sqlQuery = "UPDATE jam_tangan j SET j_harga = '" + tboxPriceUpd.Text + "', j_stok = '" + tboxQtyUpd.Text + "', j_deskripsi = '" + tboxDescriptionUpd.Text + "', j_foto= @img  WHERE j.j_sku = '" + FormStock.SKU + "'";

                    sqlCommand = new MySqlCommand(sqlQuery, fLogIn.conn);
                    //sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, fLogIn.conn);

                    sqlCommand.Parameters.Add("@img", MySqlDbType.Blob);
                    sqlCommand.Parameters["@img"].Value = img;

                    if (sqlCommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Update success!");
                    }
                    //sqlConnect.Close();
                    buttonBackInsUpd_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                //sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "UPDATE jam_tangan j SET j_delete = '1' where j_sku = '"+FormStock.SKU+"'";

                sqlCommand = new MySqlCommand(sqlQuery, fLogIn.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                //sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                //sqlConnect.Close();
                MessageBox.Show("Product deleted!");

                buttonBackInsUpd_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void buttonChooseImageUpd_Click(object sender, EventArgs e)
        {
            //MEMILIH IMAGE
            //sqlConnect = new MySqlConnection(connectString);
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image (*.jpg; *.png)|*.jpg; *.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictboxJamUpd.Image = Image.FromFile(opf.FileName);
            }     
        }

        private void pictureBoxRestart_Click(object sender, EventArgs e)
        {
            FormUpdate_Load(sender, e);
        }
    }
}
