namespace DiceRoller
{
    public partial class Form1 : Form
    {
        How_many fetchAmount = new How_many();
        public int howMany = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiceRoller.ClearDice();
            amount_D4.Text = "0";
            amount_D6.Text = "0";
            amount_D8.Text = "0";
            amount_D10.Text = "0";
            amount_D12.Text = "0";
            amount_D20.Text = "0";
            result_lbl.Text = "0";
            ind_Rolls.Text = "0";
        }

        private void btn_Roll_Dice_Click(object sender, EventArgs e)
        {
            result_lbl.Text = DiceRoller.Roll().ToString();

            string storeRolls = "";
            for (int i = 0; i < DiceRoller.indivRolls.Count; i++)
            {
                storeRolls = storeRolls + DiceRoller.indivRolls[i].ToString();
                if (i < DiceRoller.indivRolls.Count - 1)
                {
                    storeRolls = storeRolls + " + ";
                }
            }
            ind_Rolls.Text = storeRolls;
        }

        private void Add_Die_Clicked(object sender, EventArgs e)
        {
            fetchAmount.ShowDialog();

            if (fetchAmount.DialogResult == DialogResult.OK)
            {
                PictureBox diceClicked = (PictureBox)sender;
                if (diceClicked != null && diceClicked.Name != null)
                {
                    switch (diceClicked.Name.Split('_')[2].ToUpper())
                    {
                        case "D4": DiceRoller.AddDie(new D4(), ref amount_D4); break;
                        case "D6": DiceRoller.AddDie(new D6(), ref amount_D6); break;
                        case "D8": DiceRoller.AddDie(new D8(), ref amount_D8); break;
                        case "D10": DiceRoller.AddDie(new D10(), ref amount_D10); break;
                        case "D12": DiceRoller.AddDie(new D12(), ref amount_D12); break;
                        case "D20": DiceRoller.AddDie(new D20(), ref amount_D20); break;
                        default: MessageBox.Show("Something went REALLY wrong.\nCheck your privilige."); break;
                    }
                }
            }
        }
    }
}