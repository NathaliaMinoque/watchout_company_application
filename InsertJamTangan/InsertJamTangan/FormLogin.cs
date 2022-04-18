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
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
        }

        public MySqlConnection conn;
       

        private void openDBConn()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "server=" + tboxHost.Text + "; uid=" + tboxUser.Text + "; pwd=" + tboxPass.Text + "; database=KMMI6;";

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                MessageBox.Show("Connected!");
                FormHome fHome = new FormHome();
                fHome.init(this);
                fHome.ShowDialog();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            openDBConn();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            try
            {
                tboxHost.Clear();
                tboxPass.Clear();
                tboxUser.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
