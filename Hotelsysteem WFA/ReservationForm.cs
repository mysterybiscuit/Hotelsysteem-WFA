﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelsysteem_WFA
{
    public partial class ReservationForm : Form
    {
        DateTime begin, end;
        int room;
        //string fileLocation = @"C:\Users\guest_t0gyw3i\OneDrive\Documenten\Fontys\Pst7\OIS12\Week 14+\Hotelsysteem WFA\Hotelsysteem WFA\db.txt";
        string fileLocation = @"C:\Users\guest_4bce0kr\Documents\GitHub\Hotelsysteem-WFA\Hotelsysteem WFA\db.txt";

        int roomAmount = 213;

        public ReservationForm()
        {
            InitializeComponent();
            checkForRooms();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            mcal_selector.MinDate = today;
        }

        private void btn_beginDate_Click(object sender, EventArgs e)
        {
            begin = mcal_selector.SelectionStart;
            btn_beginDate.Text = mcal_selector.SelectionStart.ToLongDateString();
        }

        private void btn_endDate_Click(object sender, EventArgs e)
        {
            end = mcal_selector.SelectionEnd;
            if (begin < end)
            {
                btn_endDate.Text = mcal_selector.SelectionEnd.ToLongDateString();
            }
            else
            {
                MessageBox.Show("You can't have an end date before a begin date!");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (CheckForItems()) //Checks whether all the information has been entered.
            {
                string[] toOpen = { };
                try //Opening the file to check whether IDs are available
                {
                    toOpen = File.ReadAllLines(fileLocation);
                    bool selected = false;
                    if (toOpen.Length > 0)
                    {
                        for (int i = 0; i < toOpen.Length; i++)
                        {
                            string currentString = toOpen[i];
                            int idCheck = Convert.ToInt32(currentString.Substring(3, currentString.IndexOf(';') - 3));
                            if (idCheck != i)
                            {
                                id = i;
                                selected = true;
                                break;
                            }
                        }
                    }
                    if (!selected) //If no ID is available, add the reservation at the end.
                    {
                        id = toOpen.Length;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                try //Save to the textfile.
                {
                    int room = lb_rooms.SelectedIndex + 1;
                    string lineToSave = $"ID:{id};B:{begin.ToLongDateString()};E:{end.ToLongDateString()};R:{room};A:{tb_address.Text};RE:{tb_residence.Text};P1:{tb_fullname.Text};";
                    List<string> toSave = new List<string>();
                    toSave = toOpen.ToList<string>();
                    toSave.Add(lineToSave);
                    File.WriteAllLines(fileLocation, toSave);
                }
                catch
                {
                    MessageBox.Show("Couldn't save the database!");
                }
                try //Sort the text file by ID.
                {
                    toOpen = File.ReadAllLines(fileLocation);
                    List<string> toSave = toOpen.ToList();
                    toOpen.OrderBy(x => PadNumbers(x));
                    File.WriteAllLines(fileLocation, toOpen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                this.Close();
            }
        }

        private static string PadNumbers(string input) //Sorts numbers alphanumerically using ID
        {
            return Regex.Replace(input, "[0-9]+", match => match.Value.PadLeft(10, '0'));
        }

        private void checkForRooms()
        {
            List<string> availableRooms = new List<string>();
            for (int i = 1; i <= roomAmount; i++) //Make a list of all the rooms
            {
                string room = i.ToString();
                availableRooms.Add(room);
            }
            try //Remove occupied rooms
            {
                string[] toOpen = File.ReadAllLines(fileLocation);
                foreach (string line in toOpen) //Remove occupied rooms
                {
                    string room = line.Substring(line.IndexOf('R') + 2);
                    room = room.Remove(room.Length - 1, 1);
                    for (int i = 1; i <= roomAmount; i++)
                    {
                        if (i.ToString().Length == 1 && i.ToString() == $"00{room}")
                        {
                            availableRooms.RemoveAt(availableRooms.IndexOf(i.ToString()));
                        }
                        else if (i.ToString().Length == 2 && i.ToString() == $"0{room}")
                        {
                            availableRooms.RemoveAt(availableRooms.IndexOf(i.ToString()));
                        }
                        if (i.ToString() == room)
                        {
                            availableRooms.RemoveAt(availableRooms.IndexOf(i.ToString()));
                        }
                    }
                }
                foreach (string room in availableRooms)
                {
                    if (room.Length == 1)
                    {
                        lb_rooms.Items.Add($"00{room}");
                    }
                    else if (room.Length == 2)
                    {
                        lb_rooms.Items.Add($"0{room}");
                    }
                    else
                    {
                        lb_rooms.Items.Add(room);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CheckForItems()
        {
            if (begin >= DateTime.Today && end >= DateTime.Today && lb_rooms.SelectedIndex != -1 && tb_fullname.Text != "" && tb_address.Text != "" && tb_residence.Text != "")
            {
                return true;
            }
            else if (begin < DateTime.Today)
            {
                MessageBox.Show("You have to select a begin date!");
                return false;
            }
            else if (end < DateTime.Today)
            {
                MessageBox.Show("You have to select an end date!");
                return false;
            }
            else if (lb_rooms.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select a room!");
                return false;
            }
            else if (tb_fullname.Text == "")
            {
                MessageBox.Show("You have to enter a full name!");
                return false;
            }
            else if (tb_address.Text == "")
            {
                MessageBox.Show("You have to enter an address!");
                return false;
            }
            else if (tb_residence.Text == "")
            {
                MessageBox.Show("You have to enter a residence!");
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
