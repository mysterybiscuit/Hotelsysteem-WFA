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
            string fileLocation = @"C:\Users\guest_t0gyw3i\OneDrive\Documenten\Fontys\Pst7\OIS12\Week 14+\Hotelsysteem WFA\Hotelsysteem WFA\db.txt";
            //string fileLocation = @"C:\Users\guest_4bce0kr\Documents\GitHub\Hotelsysteem-WFA\Hotelsysteem WFA\db.txt";
            string[] opened = File.ReadAllLines(fileLocation);
            if (opened.Length != 0)
            {
                try
                {

                }
                catch
                {

                }
            }
            else
            {

            }
        }
    }
}
