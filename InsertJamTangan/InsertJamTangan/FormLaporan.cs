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
    public partial class FormLaporan : Form
    {
        public FormLaporan()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        //string connectString = "server=localhost;uid=root;pwd=;database=jam_tangan";
        string sqlQuery;

        public MySqlConnection conn;
        FormLogin fLogIn;

        public void init(FormLogin f)
        {
            fLogIn = f;
        }

        private void cboxJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                isiDgvLaporan(cboxJenis.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void isiDgvLaporan(int pilihan)
        {
            try
            {
                string query = "";
                if (pilihan == 0)
                {
                    query = "SELECT * FROM restok";
                }
                else if (pilihan == 1)
                {
                    query = "SELECT * FROM terlaris";
                }
                else if (pilihan == 2)
                {
                    query = "SELECT * FROM top_reseller";
                }

                DataTable dtLapor = new DataTable();
                sqlCommand = new MySqlCommand(query, fLogIn.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtLapor);
                dgvLaporan.DataSource = dtLapor;

                //MySqlDataAdapter daLaporan = new MySqlDataAdapter(query, fLogIn.conn);
                //DataSet dsLaporan = new DataSet();
                //daLaporan.Fill(dsLaporan);
                //dgvLaporan.DataSource = dsLaporan.Tables[0];
                //dgvLaporan.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonBackLap_Click(object sender, EventArgs e)
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
