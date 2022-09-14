namespace DiceRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiceRoller.ClearDice();
        }

        private void pbx_Add_D4_Click(object sender, EventArgs e)
        {
            DialogResult fetchAmount = ShowDialog(new How_many());
        }
    }
}