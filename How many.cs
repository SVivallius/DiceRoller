using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DiceRoller
{
    public partial class How_many : Form
    {
        public How_many()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                DiceRoller.amtToAdd = Int32.Parse(tbx_amount_Entered.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid input!\n\nField only accepts integer numerals.\nPlease try again.");
                tbx_amount_Entered.Text = "";
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void How_many_Load(object sender, EventArgs e)
        {
            this.tbx_amount_Entered.Focus();
            this.tbx_amount_Entered.Clear();
        }
    }
}