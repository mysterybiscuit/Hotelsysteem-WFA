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
        string[] addresses;
        string[] residences;
        string[] p1;
        string[] p2;
        string[] p3;
        string[] p4;

        //string fileLocation = @"C:\Users\guest_t0gyw3i\OneDrive\Documenten\Fontys\Pst7\OIS12\Week 14+\Hotelsysteem WFA\Hotelsysteem WFA\db.txt";
        string fileLocation = @"C:\Users\guest_4bce0kr\Documents\GitHub\Hotelsysteem-WFA\Hotelsysteem WFA\db.txt";

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
            
            string[] reservations = File.ReadAllLines(fileLocation);
            ids = new int[reservations.Length];
            beginDates = new string[reservations.Length];
            endDates = new string[reservations.Length];
            rooms = new string[reservations.Length];
            addresses = new string[reservations.Length];
            residences = new string[reservations.Length];
            p1 = new string[reservations.Length];
            p2 = new string[reservations.Length];
            p3 = new string[reservations.Length];
            p4 = new string[reservations.Length];
            try
            {
                for (int i = 0; i < reservations.Length; i++)
                {
                    string newString = reservations[i]; //String to be ripped into pieces

                    //Scan for IDs
                    int startIndex = reservations[i].IndexOf(':') + 1;
                    ids[i] = Convert.ToInt32(reservations[i].Substring(startIndex, reservations[i].IndexOf(';') - startIndex));
                    newString = reservations[i].Substring(reservations[i].IndexOf('B'));

                    //Scan for begin dates
                    startIndex = newString.IndexOf(':') + 1;
                    beginDates[i] = newString.Substring(startIndex, newString.IndexOf(';') - startIndex);
                    newString = newString.Substring(newString.IndexOf('E'));

                    //Scan for end dates
                    startIndex = newString.IndexOf(':') + 1;
                    endDates[i] = newString.Substring(startIndex, newString.IndexOf(';') - startIndex);
                    newString = newString.Substring(newString.IndexOf('R'));

                    //Scan for rooms
                    startIndex = newString.IndexOf(':') + 1;
                    rooms[i] = newString.Substring(startIndex, newString.IndexOf(';') - startIndex);
                    newString = newString.Substring(newString.IndexOf('A'));

                    startIndex = newString.IndexOf(':') + 1;
                    addresses[i] = newString.Substring(startIndex, newString.IndexOf(';') - startIndex);
                    newString = newString.Substring(newString.IndexOf("RE"));

                    startIndex = newString.IndexOf(':') + 1;
                    residences[i] = newString.Substring(startIndex, newString.IndexOf(';') - startIndex);
                    if (newString.Contains("P1")) //Checks whether there is a person assigned to this room
                    {
                        newString = newString.Substring(newString.IndexOf("P1"));
                        startIndex = newString.IndexOf(':') + 1;
                        p1[i] = newString.Substring(startIndex, newString.IndexOf(';') - startIndex);
                    }

                    if (newString.Contains("P2")) //Checks whether there is a second person assigned to this room
                    {
                        newString = newString.Substring(newString.IndexOf("P2"));
                        startIndex = newString.IndexOf(':') + 1;
                        p2[i] = newString.Substring(startIndex, newString.IndexOf(';') - startIndex);
                    }

                    if (newString.Contains("P3")) //Checks whether there is a third person assigned to this room
                    {
                        newString = newString.Substring(newString.IndexOf("P3"));
                        startIndex = newString.IndexOf(':') + 1;
                        p3[i] = newString.Substring(startIndex, newString.IndexOf(';') - startIndex);
                    }

                    if (newString.Contains("P4")) //Checks whether there is a fourth person assigned to this room
                    {
                        newString = newString.Substring(newString.IndexOf("P4"));
                        startIndex = newString.IndexOf(':') + 1;
                        p4[i] = newString.Substring(startIndex, newString.IndexOf(';') - startIndex);
                    }
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
                tb_roomnumber.Text = rooms[IndexSelected];
                lb_names.Items.Clear();
                if (p1[IndexSelected] != null)
                {
                    lb_names.Items.Add(p1[IndexSelected]);
                }
                if (p2[IndexSelected] != null)
                {
                    lb_names.Items.Add(p2[IndexSelected]);
                }
                if (p3[IndexSelected] != null)
                {
                    lb_names.Items.Add(p3[IndexSelected]);
                }
                if (p4[IndexSelected] != null)
                {
                    lb_names.Items.Add(p4[IndexSelected]);
                }
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
            string[] reservations = File.ReadAllLines(fileLocation);
            List<string> tempReserv = reservations.ToList();
            int IndexSelected = lb_reservations.SelectedIndex;
            int startIndex = reservations[IndexSelected].IndexOf(':') + 1;
            tempReserv.RemoveAt(IndexSelected);
            File.WriteAllLines(fileLocation, tempReserv);
        }

        private void lb_names_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
