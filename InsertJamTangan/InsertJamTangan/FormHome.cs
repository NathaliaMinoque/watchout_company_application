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
    public partial class FormHome : Form
    {
        public FormHome()
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
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                FormInsert formInsert = new FormInsert();
                formInsert.init(fLogIn);
                formInsert.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonStock_Click(object sender, EventArgs e)
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

        private void buttonAcc_Click(object sender, EventArgs e)
        {
            try
            {
                FormAcc formAcc = new FormAcc();
                formAcc.init(fLogIn);
                formAcc.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLaporan_Click(object sender, EventArgs e)
        {
            try
            {
                FormLaporan formLaporan = new FormLaporan();
                formLaporan.init(fLogIn);
                formLaporan.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPenjualan_Click(object sender, EventArgs e)
        {
            try
            {
                FormPenjualan formPenjualan = new FormPenjualan();
                formPenjualan.init(fLogIn);
                formPenjualan.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelhome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
