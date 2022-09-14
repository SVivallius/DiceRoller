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

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void pbx_Add_D4_Click(object sender, EventArgs e)
        {
            fetchAmount.ShowDialog();

            if (fetchAmount.DialogResult == DialogResult.OK)
            {
                DiceRoller.AddDie(new D4());
                amount_D4.Text = DiceRoller.CountDice(new D4()).ToString();
            }
        }

        private void pbx_Add_D6_Click(object sender, EventArgs e)
        {
            fetchAmount.ShowDialog();

            if (fetchAmount.DialogResult == DialogResult.OK)
            {
                DiceRoller.AddDie(new D6());
                amount_D6.Text = DiceRoller.CountDice(new D6()).ToString();
            }
        }

        private void pbx_Add_D8_Click(object sender, EventArgs e)
        {
            fetchAmount.ShowDialog();

            if (fetchAmount.DialogResult == DialogResult.OK)
            {
                DiceRoller.AddDie(new D8());
                amount_D8.Text = DiceRoller.CountDice(new D8()).ToString();
            }
        }

        private void pbx_Add_D10_Click(object sender, EventArgs e)
        {
            fetchAmount.ShowDialog();

            if (fetchAmount.DialogResult == DialogResult.OK)
            {
                DiceRoller.AddDie(new D10());
                amount_D10.Text = DiceRoller.CountDice(new D10()).ToString();
            }
        }

        private void pbx_Add_D12_Click(object sender, EventArgs e)
        {
            fetchAmount.ShowDialog();

            if (fetchAmount.DialogResult == DialogResult.OK)
            {
                DiceRoller.AddDie(new D12());
                amount_D12.Text = DiceRoller.CountDice(new D12()).ToString();
            }
        }

        private void pbx_Add_D20_Click(object sender, EventArgs e)
        {
            fetchAmount.ShowDialog();

            if (fetchAmount.DialogResult == DialogResult.OK)
            {
                DiceRoller.AddDie(new D20());
                amount_D20.Text = DiceRoller.CountDice(new D20()).ToString();
            }
        }

        private void btn_Roll_Dice_Click(object sender, EventArgs e)
        {
            result_lbl.Text = DiceRoller.Roll().ToString();

            ind_Rolls.Text = "";
            for (int i = 0; i < DiceRoller.indivRolls.Count; i++)
            {
                ind_Rolls.Text = ind_Rolls.Text + DiceRoller.indivRolls[i].ToString();
                if (i < DiceRoller.indivRolls.Count - 1)
                {
                    ind_Rolls.Text = ind_Rolls.Text + " + ";
                }
            }
        }
    }
}