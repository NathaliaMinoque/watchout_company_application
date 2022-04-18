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
    public partial class FormInsert : Form
    {
        public FormInsert()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        public static string merk;
        public static string name;
        public static string firstname;
        public static string lastname;
        public static string category;
        public static string color;
        public static string SKU;

        FormLogin fLogIn;
        public void init(FormLogin f)
        {
            fLogIn = f;
        }

        //MINOQ DAN ZEFA
        private void buttonChooseImage_Click(object sender, EventArgs e)
        {
            try
            {
                //MEMILIH IMAGE
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Choose Image (*.jpg; *.png)|*.jpg; *.png";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pictboxJam.Image = Image.FromFile(opf.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbutWomen.Checked == true)
                {
                    category = "W";
                }
                else if (rbutMen.Checked == true)
                {
                    category = "M";
                }
                else if (rbutKids.Checked == true)
                {
                    category = "K";
                }

                name = cboxMerk.Text + " " + tboxNameFirst.Text + " " + tboxNameLast.Text;
                SKU = category + merk + firstname + lastname + "/" + color + cboxSize.Text;      

                MemoryStream ms = new MemoryStream();
                pictboxJam.Image.Save(ms, pictboxJam.Image.RawFormat);
                byte[] img = ms.ToArray();

                sqlQuery = "insert into jam_tangan values ('" + SKU + "', '" + name + "', '" + tboxPrice.Text + "', '" + cboxColor.Text + "', '" + tboxQty.Text + "', '" + cboxSize.Text + "', '" + tboxDescription.Text + "', @img, '0')";
                sqlCommand = new MySqlCommand(sqlQuery, fLogIn.conn);
                sqlCommand = new MySqlCommand(sqlQuery, fLogIn.conn);

                sqlCommand.Parameters.Add("@img", MySqlDbType.Blob);
                sqlCommand.Parameters["@img"].Value = img;

                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Product "+ SKU + " has been inserted!");
                }
                //sqlConnect.Close();

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

        private void buttoncoba_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

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
                if(cboxMerk.Text=="Daniel Wellington")
                {
                    merk = "DW";
                }
                else if (cboxMerk.Text == "Lacoste")
                {
                    merk = "LE";
                }
                else if (cboxMerk.Text == "Timex")
                {
                    merk = "TX";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboxColor.Text == "Black")
                {
                    color = "BK";
                }
                else if (cboxColor.Text == "Blue")
                {
                    color = "BE";
                }
                else if (cboxColor.Text == "Gold")
                {
                    color = "GD";
                }
                else if (cboxColor.Text == "Green")
                {
                    color = "GN";
                }
                else if (cboxColor.Text == "Pink")
                {
                    color = "PK";
                }
                else if (cboxColor.Text == "Silver")
                {
                    color = "SR";
                }
                else if (cboxColor.Text == "White")
                {
                    color = "WE";
                }
                else if (cboxColor.Text == "Brown")
                {
                    color = "BN";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tboxNameLast_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tboxNameLast.Text != "")
                {
                    lastname = tboxNameLast.Text.Substring(0, 1).ToUpper();
                }
                else if (tboxNameLast.Text == "")
                {
                    lastname = "X";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tboxNameFirst_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tboxNameFirst.Text != "")
                {
                    firstname = tboxNameFirst.Text.Substring(0, 1).ToUpper();
                }
                else if (tboxNameLast.Text == "")
                {
                    firstname = "X";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tboxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxPrice_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //ini code biar yg masuk angka doang
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tboxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ini code biar yg masuk angka doang
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonBackIns_Click(object sender, EventArgs e)
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
    }
}
