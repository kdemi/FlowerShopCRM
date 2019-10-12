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
using System.Diagnostics;

namespace WFA_Kwiaciarnia
{
    public partial class Otworz_baze_WF : Form
    {
        private SqlDataAdapter adpt;
        private DataTable warehouse = new DataTable();
        private SqlCommand cmd;
        private SqlCommandBuilder mcb;


        public Otworz_baze_WF()
        {
            InitializeComponent();
        }

        public Form1 form1_ref;

        /// <summary>
        /// metoda pobiera cała bazę danych i wyświetala ją w oknie do tego przeznaczonym.
        /// </summary>
        public void Show_data()
        {
            warehouse.Clear();
            adpt = new SqlDataAdapter("select * from MAGAZYN", form1_ref.conn);
            adpt.Fill(warehouse);
            Main_dGV.DataSource = warehouse;
            Main_dGV.Columns["M_id"].Visible = false;

            foreach (DataGridViewRow row in Main_dGV.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.ReadOnly = true;
                }
            }
        }

        private void Add_tslbl_Click(object sender, EventArgs e)
        {
            Add_WF add_WF_ref = new Add_WF();
            add_WF_ref.o_b_ref = this;
            add_WF_ref.Show();
        }


        /// <summary>
        /// Metoda ukrywa/uwidacznia możliwość edycji/usunięcia danego wiersza,
        /// Ustawia kolor Edit ponownie na czarny.
        /// </summary>
        /// <param name="open_close"></param>
        private void Show_toolStrip(bool open_close)
        {
            edit_tslbl.ForeColor = Color.Black;
            Save_changes_column.Visible = false;
            edit_tslbl.Visible = open_close;
            tsSeparator1.Visible = open_close;
            delete_tslbl.Visible = open_close;
            tsSeparator2.Visible = open_close;
            supply_tlsl_MGV.Visible = open_close;
            tlStripSeparator1.Visible = open_close;
        }

        private void Check_checkBox(DataGridViewCellEventArgs param)
        {
            if (param.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(Main_dGV.Rows[param.RowIndex].Cells[0].Value) == false)//cells 0 w tym wypadku to column checkbox.
                {
                    Show_toolStrip(true);
                    Main_dGV.Rows[param.RowIndex].SetValues(true);
                }
                else
                {
                    Edit_d_quantity(true);
                    int counter = 0;

                    foreach (DataGridViewRow row in Main_dGV.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value) == true)
                            counter++;
                    }

                    if (counter == 1)
                    {
                        Show_toolStrip(false);
                        Main_dGV.Rows[param.RowIndex].SetValues(false);
                    }
                    else
                    {
                        Main_dGV.Rows[param.RowIndex].SetValues(false);
                    }
                }
            }
            
        }

        /// <summary>
        /// kolumna index = 1 Save_changes. 
        /// po kliknięciu Tak zapisuje wprowadzone zmiany do bazy danych.
        /// </summary>
        /// <param name="param"></param>
        private void Save_changes(DataGridViewCellEventArgs param)//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!BŁĄD
        {
            if (param.ColumnIndex == 1)
            {
                if (MessageBox.Show("Czy na pewno chcesz zapisać wprowadzone zmiany?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    warehouse = ((DataTable)Main_dGV.DataSource).GetChanges();

                    if (warehouse != null)
                    {
                        mcb = new SqlCommandBuilder(adpt);
                        adpt.UpdateCommand = mcb.GetUpdateCommand();
                        adpt.Update(warehouse);
                        ((DataTable)Main_dGV.DataSource).AcceptChanges();

                        Show_toolStrip(false);
                        MessageBox.Show("Zaktualizowano dane", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }

        //Debug.WriteLine($"Kliknieto kolumne {e.ColumnIndex} i wiersz {e.RowIndex}");
        // wartość konkretnej komórki to Main_dGV.Rows[0].Cells[4].Value
        // może to też zapisać tak : Main_dGV.Row[e.RowIndex].Cells[M_quantity].Value
        // columna = 0, wartość cell = false wywołaj Show_toolStrip(),
        //sprawdz czy inne checkboxy są true
        //MessageBox.Show($"Kliknieto kolumne {e.ColumnIndex} i wiersz {e.RowIndex}");
        //column_index6(e);
        private void Main_dGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Check_checkBox(e);
            Save_changes(e);
        }

        /// <summary>
        /// umożliwia użytkownikowi edycję poszczególnych póla price w zaznczonych wierszach,
        /// nie umożliwia zmieny nazwy i ilośći(trzeba usunąć i na nowo stworzyć wiersz).
        /// (zablokowałam tą możliwość w DGV tasks)
        /// metoda jest wywoływana poprzez kliknięcie przycisku edit i zapisuje dane do bazy oraz wyświetla
        /// od razu tabele ze zmienionymi danymi.
        /// </summary>
        private void Edit_d_quantity(bool t_f_value)
        {
            foreach (DataGridViewRow row in Main_dGV.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    row.Cells["M_price"].ReadOnly = t_f_value;
                }
            }
        }

        private void Edit_tslbl_Click(object sender, EventArgs e)
        {
            edit_tslbl.ForeColor = Color.DeepSkyBlue;
            Save_changes_column.DisplayIndex = 5;
            Save_changes_column.Visible = true;
            Edit_d_quantity(false);
        }

        /// <summary>
        /// metoda usuwa cały row z datagridview oraz z głównej(internetowej) bazy danych po wcześniejszym
        /// zpytaniu czy na pewno usunąć, jeżli użytkownik wybierze tak usuwamy, jeżeli nie wracamy do datagridview;
        /// </summary>
        private void Delete_datas()
        {
            foreach (DataGridViewRow row in Main_dGV.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    int value = (int)row.Cells["M_Id"].Value;
                    cmd = new SqlCommand($"delete from MAGAZYN where M_ID = {value}", form1_ref.conn);
                    cmd.ExecuteNonQuery();
                }
            }
            
        }
        private void Delete_tslbl_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć wszytkie zaznaczone dane?", "Usuń", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                Delete_datas();
                Show_toolStrip(false);
                Show_data();
            }
        }

       /*private void Main_dGV_RowValidated_1(object sender, DataGridViewCellEventArgs e)
        {
            warehouse = ((DataTable)Main_dGV.DataSource).GetChanges();

            if (warehouse != null)
            {
                mcb = new SqlCommandBuilder(adpt);
                adpt.UpdateCommand = mcb.GetUpdateCommand();
                adpt.Update(warehouse);
                ((DataTable)Main_dGV.DataSource).AcceptChanges();

                Show_toolStrip(false);
                MessageBox.Show("Values updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }*/

        /// <summary>
        /// Metoda umożliwia wprowadzenie dostawy dla wybranego obiektu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Supply_tlsl_MGV_Click(object sender, EventArgs e)
        {
            Supply supply_ref = new Supply();
            supply_ref.supply_otworz_Baze_ref = this;
            supply_ref.Check_convert(Main_dGV);
            supply_ref.Show();
            Show_toolStrip(false);
        }
    }
}

