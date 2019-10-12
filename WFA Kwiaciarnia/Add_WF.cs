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
    public partial class Add_WF : Form
    {
        public Otworz_baze_WF o_b_ref;

        public Add_WF()
        {
            InitializeComponent();
        }

        private void dodaj_ADD_B_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = o_b_ref.form1_ref.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"INSERT INTO MAGAZYN VALUES ('{nazwa_tB.Text}', {cena_tB.Text}, {ilosc_tB.Text})";
            cmd.ExecuteNonQuery();
            o_b_ref.Show_data();
            this.Close();
        }
    }
}
