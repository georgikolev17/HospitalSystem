using Business;
using Data;
using Data.Models;

namespace HospitalSystem
{
    public partial class LoginForm : Form
    {
        private readonly IUsersBusiness usersBusiness;
        public LoginForm()
        {
            InitializeComponent();
            usersBusiness = new UsersBusiness();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dbContext = new ApplicationDbContext();
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            var userName = textBox1.Text;
            var password = textBox2.Text;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Email")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e) // Placeholder
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Email";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e) // Placeholder
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.PasswordChar = '\0';
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var signupForm = new RegistrationForm();
            signupForm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var email = textBox1.Text;
            var password = textBox2.Text;

            try
            {
                var user = this.usersBusiness.LoginUser(email, password);
                if (user.UserType == UserType.Patient)
                {
                    var patientAccount = new PatientAccount(user as Patient);
                    this.Close();
                    patientAccount.ShowDialog();
                }
                else
                {
                    var doctorAccount = new DoctorAccount(user as Doctor);
                    this.Close();
                    doctorAccount.ShowDialog();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}