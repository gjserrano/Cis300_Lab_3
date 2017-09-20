using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KsuCis300_Lab_3
{
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Initializes the USerInterface
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The EventHandeler for the uxOpen part of the MenuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            string fileName = open.FileName;

            if(open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    uxTextBox.Text = File.ReadAllText(fileName);
                }
                catch(Exception ex)
                {
                    DisplayError(ex);
                }
            }
        }

        /// <summary>
        /// The EventHandler for the uxSave part of the MenuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            string contents = uxTextBox.Text;
            string fileName = save.FileName;

            if(save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(fileName, contents);
                }
                catch(Exception ex)
                {
                    DisplayError(ex);
                }
            }
        }

        /// <summary>
        /// Displays a MessageBox containing an Error
        /// </summary>
        /// <param name="ex">The Error being shown</param>
        private void DisplayError(Exception ex)
        {
            MessageBox.Show("The following error occured: " + ex);
        }
    }
}