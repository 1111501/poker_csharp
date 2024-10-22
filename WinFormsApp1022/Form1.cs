namespace WinFormsApp1022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int point;
        int pointpc;
        Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            timer1.Interval = 100;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pointpc = random.Next(13);
            pictureBox1.Image = imageList1.Images[pointpc];
        }


        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (point > pointpc)
            {
                label3.Text = "you WIn";
            }
            else if (point < pointpc)
            {
                label3.Text = "computer win...";
            }
            else
            {
                label3.Text = "draw";
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            point = random.Next(13);

            pictureBox2.Image = imageList1.Images[point];
        }
    }
}