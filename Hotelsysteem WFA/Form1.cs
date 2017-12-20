using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelsysteem_WFA
{
    public partial class Form1 : Form
    {
        int[] ids;
        string[] beginDates;
        string[] endDates;
        string[] rooms;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_nr_Click(object sender, EventArgs e)
        {
            ReservationForm reserve = new ReservationForm();
            reserve.Show();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadDatabase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDatabase();
        }

        void LoadDatabase()
        {
            lb_reservations.Items.Clear();
            string fileLocation = @"C:\Users\guest_t0gyw3i\OneDrive\Documenten\Fontys\Pst7\OIS12\Week 14+\Hotelsysteem WFA\Hotelsysteem WFA\db.txt";
            string[] reservations = File.ReadAllLines(fileLocation);
            ids = new int[reservations.Length];
            beginDates = new string[reservations.Length];
            endDates = new string[reservations.Length];
            rooms = new string[reservations.Length];
            try
            {
                for (int i = 0; i < reservations.Length; i++)
                {
                    string newString = reservations[i];
                    int startIndex = reservations[i].IndexOf(':') + 1;
                    ids[i] = Convert.ToInt32(reservations[i].Substring(startIndex, reservations[i].IndexOf(';') - startIndex));
                    newString = reservations[i].Substring(reservations[i].IndexOf('B'));

                    startIndex = newString.IndexOf(':') + 1;
                    beginDates[i] = newString.Substring(startIndex, newString.IndexOf(';') - startIndex);
                    newString = newString.Substring(newString.IndexOf('E'));

                    startIndex = newString.IndexOf(':') + 1;
                    endDates[i] = newString.Substring(startIndex, newString.IndexOf(';') - startIndex);
                    newString = newString.Substring(newString.IndexOf('R'));

                    startIndex = newString.IndexOf(':') + 1;
                    rooms[i] = newString.Substring(startIndex, newString.IndexOf(';') - startIndex);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            foreach (int id in ids)
            {
                lb_reservations.Items.Add(id);
            }
        }

        private void lb_reservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int IndexSelected = lb_reservations.SelectedIndex;
                tb_begindate.Text = beginDates[IndexSelected];
                tb_enddate.Text = endDates[IndexSelected];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btn_addname_Click(object sender, EventArgs e)
        {
            AddNames addnameform = new AddNames(lb_reservations.SelectedIndex);
            addnameform.Show();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string fileLocation = @"C:\Users\guest_t0gyw3i\OneDrive\Documenten\Fontys\Pst7\OIS12\Week 14+\Hotelsysteem WFA\Hotelsysteem WFA\db.txt";
            string[] reservations = File.ReadAllLines(fileLocation);
            List<string> tempReserv = reservations.ToList();
            int IndexSelected = lb_reservations.SelectedIndex;
            int startIndex = reservations[IndexSelected].IndexOf(':') + 1;
            tempReserv.RemoveAt(IndexSelected);

        }
    }
}
