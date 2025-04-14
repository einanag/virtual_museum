using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace virtual_museum_f
{
    public partial class FormEmployeeLogin : Form
    {
        private readonly Dictionary<string, (string password, bool isAdmin)> validCredentials;
        public event EventHandler LoginSuccessful;
        public string LoggedInUsername { get; private set; }

        public FormEmployeeLogin()
        {
            InitializeComponent();
            validCredentials = new Dictionary<string, (string password, bool isAdmin)>
            {
                {"admin", ("admin123", true)},
                {"employee01", ("password01", false)},
                {"employee02", ("password02", false)},
                {"employee03", ("password03", false)},
                {"employee04", ("password04", false)},
                {"employee05", ("password05", false)},
                {"employee06", ("password06", false)},
                {"employee07", ("password07", false)},
                {"employee08", ("password08", false)},
                {"employee09", ("password09", false)},
                {"employee10", ("password10", false)}
            };
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε όλα τα πεδία.", "Προειδοποίηση", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AuthenticateUser(username, password, out bool isAdmin))
            {
                LoggedInUsername = username;
                LoginSuccessful?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            else
            {
                MessageBox.Show("Λάθος όνομα χρήστη ή κωδικός πρόσβασης.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password, out bool isAdmin)
        {
            isAdmin = false;
            if (validCredentials.TryGetValue(username, out var credentials))
            {
                if (credentials.password == password)
                {
                    isAdmin = credentials.isAdmin;
                    return true;
                }
            }
            return false;
        }

        private void FormEmployeeLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}