namespace mayinTarlasi6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int canint = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            labelCan.Text = canint.ToString();
            button1.Enabled = false;
            int sayi1, sayi2, sayi3, sayi4, sayi5;
            Random rnd = new Random();
            sayi1 = rnd.Next(1, 10);
            sayi2 = rnd.Next(11, 20);
            sayi3 = rnd.Next(21, 30);
            sayi4 = rnd.Next(31, 40);
            sayi5 = rnd.Next(41, 50);
            for (int i = 1; i <= 50; i++)
            {
                Button btnTarla = new Button();
                btnTarla.Size = new System.Drawing.Size(50, 50);
                btnTarla.Name = "tarla" + i.ToString();
                btnTarla.Text = i.ToString();
                btnTarla.Tag = null;
                //mayýnlýlarýn tagýný iþaretleme
                if (i == sayi1 || i == sayi2 || i == sayi3 || i == sayi4 || i == sayi5)
                {
                    btnTarla.Tag = true;
                }
                else
                {
                    btnTarla.Tag = false;
                }
                btnTarla.Click += btnTarla_Click;
                flowLayoutPanel1.Controls.Add(btnTarla);

            }
        }
        private void btnTarla_Click(object? sender, EventArgs e)
        {
            int skorint = Convert.ToInt32(labelSkor.Text);
            Button btnBasilan = (Button) sender;
            bool mayin = (bool) btnBasilan.Tag;
            //tag kontolü
            if (mayin)
            {
                btnBasilan.BackColor = Color.Red;
                canint--;
                labelCan.Text = canint.ToString();
            }
            else
            {
                btnBasilan.BackColor = Color.Gray;
                skorint++;
                labelSkor.Text = skorint.ToString();
                btnBasilan.Enabled = false;
            }
            if (canint==0)
            {
                MessageBox.Show("OYUN BÝTTÝ\n" + "Skor: " + skorint);
                EkranTemizle();
            }
        }

        private void EkranTemizle()
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}