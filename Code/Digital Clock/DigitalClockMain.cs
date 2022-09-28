namespace Digital_Clock
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblHoursMins.Text = DateTime.Now.ToString("HH:mm");
            lblSeconds.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("dd. MMM");
            lblDay.Text = DateTime.Now.ToString("ddd");
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.background_red;
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.background_purple;
        }
        
        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.background_blue;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.background_green;
        }

        private void btnSilver_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.background_silver;
        }
    }
}