using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WFA_Kwiaciarnia
{


    public partial class Form1 : Form
    {
        public SqlConnection conn;
        public SqlDataAdapter adpt;
        public DataTable warehouse;


        private void przygotuj_zamowienie_B_Click(object sender, EventArgs e)
        {
            Prepare_order prep_order_ref = new Prepare_order();
            prep_order_ref.form1_Po_ref = this;
            prep_order_ref.Show();
            prep_order_ref.show_order();

        }


        private void otworz_baze_B_Click(object sender, EventArgs e)
        {
            Otworz_baze_WF otworz_b_ref = new Otworz_baze_WF();
            otworz_b_ref.form1_ref = this;
            otworz_b_ref.Show();
            otworz_b_ref.Show_data();
        }

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=kasiasqldb.database.windows.net;Initial Catalog=KasiaSQLDB;User ID=IDDatabase;Password=DataBasePassword");
            if (conn.State == ConnectionState.Broken || conn.State == ConnectionState.Closed)
                conn.Open();
            color_change();
        }


        private void Zamknij_program_B_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }

        private void color_change()
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            przygotuj_zamowienie_B.BackColor = Color.FromArgb(150, 0, 0, 0);
            wprowadz_dostawe_B.BackColor = Color.FromArgb(150, 0, 0, 0);
            otworz_baze_B.BackColor = Color.FromArgb(150, 0, 0, 0);
            zamknij_program_B.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

    }
}
