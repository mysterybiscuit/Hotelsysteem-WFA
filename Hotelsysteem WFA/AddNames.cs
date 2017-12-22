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
    public partial class AddNames : Form
    {
        int id;

        public AddNames(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private void btn_addname_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            
            //string fileLocation = @"C:\Users\guest_t0gyw3i\OneDrive\Documenten\Fontys\Pst7\OIS12\Week 14+\Hotelsysteem WFA\Hotelsysteem WFA\db.txt";
            string fileLocation = @"C:\Users\guest_4bce0kr\Documents\GitHub\Hotelsysteem-WFA\Hotelsysteem WFA\db.txt";
            string[] opened = File.ReadAllLines(fileLocation);
            if (opened.Length != 0)
            {
                try
                {
                    string line = opened[id]; //Selects the line that we want to edit
                    if (line.Contains("P1") && !line.Contains("P2"))
                    {
                        line += $"P2:{name};";
                    }
                    else if (line.Contains("P2") && !line.Contains("P3"))
                    {
                        line += $"P3:{name};";
                    }
                    else if (line.Contains("P3") && !line.Contains("P4"))
                    {
                        line += $"P4:{name};";
                    }
                    else if (line.Contains("P4"))
                    {
                        MessageBox.Show("This reservation is full!");
                    }
                    else //If room has no people assigned to it.
                    {
                        line += $"P1:{name};";
                    }
                    opened[id] = line;
                    File.WriteAllLines(fileLocation, opened);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {

            }
        }
    }
}
