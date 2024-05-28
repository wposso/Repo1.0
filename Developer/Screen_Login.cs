using System.Runtime.InteropServices;

namespace Developer
{
    public partial class Screen_Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse

        );

        // References
        Screen_Calculator Screen_Calculator = new Screen_Calculator();

        public Screen_Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void chshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chshowpassword.Checked == true)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '�';
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btncalculator_Click(object sender, EventArgs e)
        {
            Screen_Calculator.Show();
        }

        private void Screen_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnminimize1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnresize_Click(object sender, EventArgs e)
        {

        }

        private void Screen_Login_Load_1(object sender, EventArgs e)
        {

        }

        private void btnminisize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlload_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenRegister(object Screen_Register)
        {
            if (this.pnlload.Controls.Count > 0)
                this.pnlload.Controls.RemoveAt(0);
            Form A = Screen_Register as Form;
            A.TopLevel = false;
            A.Dock = DockStyle.Fill;
            this.pnlload.Controls.Add(A);
            this.pnlload.Tag = A;
            A.Show();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            //OpenRegister(new Screen_Register());
            pnlmove.Location = new Point(993, 232);
        }

        private void OpenLogin(object Screen_Login)
        {
            if (this.pnlload.Controls.Count > 0)
                this.pnlload.Controls.RemoveAt(0);
            Form B = Screen_Login as Form;
            B.TopLevel = false;
            B.Dock = DockStyle.Fill;
            this.pnlload.Controls.Add(B);
            this.pnlload.Tag = B;
            B.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            //OpenRegister(new Screen_Login());
            pnlmove.Location = new Point(813, 232);
        }
    }
}
