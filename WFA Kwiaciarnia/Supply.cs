using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WFA_Kwiaciarnia
{
    public partial class Supply : Form
    {
        public Otworz_baze_WF supply_otworz_Baze_ref;

        public Supply()
        {
            InitializeComponent();
            supply_color_change();
        }

        /// <summary>
        /// Pobiera nazwę kwiata zaznaczonego pola(która jest następnie przechowywana w polu name)
        /// i tworzy label z tą nazwa, obok tworzy textbox w który wprowadza się dostawę.
        /// Nazwa textboxu przechowuje M_id danego kwiata.
        /// </summary>
        /// <param name="GV"> podajemy nazwę naszego głównego GridView</param>
        public void Check_convert(DataGridView GV)
        {
            foreach (DataGridViewRow row in GV.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    string name = (string)row.Cells["M_name"].Value;
                    int id = (int)row.Cells["M_Id"].Value;

                    Create_label_textbox(name, id);
                }
            }
        }

        int lbl_start_position = 40;
        int tb_start_position = 37;
        /// <summary>
        /// Funkcja jest automatycznie wywoływana prze fukcje Check_convert(GV);
        /// Funcja dynamicznie tworzy label z nazwą i textbox przechowujący w swojej nazwie id
        /// dla uprzednio zaznaczonego kwiata.
        /// W textboxie wprowadzamy ilość dostawy.
        /// </summary>
        /// <remarks lbl_start_position="40">jest pozycją początkową dla pierwszego tworzonego label'a</remarks>
        /// <remarks tb_start_position="37">jest pozycja początkową dla pierwszego stworzonego textbox'a</remarks>
        /// <param name="my_name"> nazwa kwiata</param>
        /// <param name="my_int">id danego kwiata w bazie danych</param>
        public void Create_label_textbox(string my_name, int my_int)
        {
            Label dynamically_label = new Label();
            panel1.Controls.Add(dynamically_label);
            dynamically_label.BackColor = Color.Transparent;
            dynamically_label.FlatStyle = FlatStyle.Popup;
            dynamically_label.Font = new Font("Caladea", 10, FontStyle.Bold, GraphicsUnit.Point);
            dynamically_label.ForeColor = Color.White;
            dynamically_label.TextAlign = ContentAlignment.MiddleRight;
            dynamically_label.Text = my_name + ":";
            dynamically_label.Top = lbl_start_position;
            dynamically_label.Left = 40 ;
            dynamically_label.Size = new Size(100, 17);
            lbl_start_position += 30;

            TextBox dynamically_TB = new TextBox();
            panel1.Controls.Add(dynamically_TB);
            dynamically_TB.Name = my_int.ToString();
            dynamically_TB.Top = tb_start_position;
            dynamically_TB.Left = 140;
            tb_start_position += 30;
            
        }
        
        /// <summary>
        /// Aktualizuje stan bazy, tzn. do stanu w bazie dodaje wprowadzoną dostawę.
        /// </summary>
        private void Zatwierdz_B_Click(object sender, EventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is TextBox)
                {
                    int download_id;
                    int.TryParse(control.Name, out download_id);

                    int supply_quantity;
                    int.TryParse(control.Text, out supply_quantity);

                    SqlCommand cmd = supply_otworz_Baze_ref.form1_ref.conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"UPDATE MAGAZYN SET M_quantity += {supply_quantity} where M_Id = {download_id}";
                    cmd.ExecuteNonQuery();
                }

            }
            supply_otworz_Baze_ref.Show_data();
            this.Close();
        }

        private void supply_color_change()
        {
            panel1.BackColor = Color.FromArgb(120, 0, 0, 0);
            zatwierdz_B.BackColor = Color.FromArgb(200, 0, 0, 0);
        }

    }
}
