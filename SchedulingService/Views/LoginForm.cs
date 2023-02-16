using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;
using SchedulingService.Views;
using SchedulingService.Models;

namespace SchedulingService
{
	public partial class LoginForm : Form
	{
        public string errorMessage = "The username and password did not match any records in the database";
        public AuthState AuthState = new AuthState();
        public LoginForm()
        {
            InitializeComponent();
            timeZoneText.Text = TimeZone.CurrentTimeZone.StandardName;
            languageSelect.DataSource = new string[2] { "English/Ingles", "Spanish/Espanol"};
            languageSelect.SelectedItem = "English/Ingles";
        }

        public int FindUser(string userName, string password)
        {
            MySqlConnection c = new MySqlConnection(AuthState.connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT userId FROM user WHERE userName = '{userName}' AND password = '{password}'", c);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                AuthState.setCurrentUserId(Convert.ToInt32(rdr[0]));
                rdr.Close(); c.Close();
                return AuthState.getCurrentUserId();
            }
            return 0;
        }

        

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (FindUser(username.Text, password.Text) != 0)
            {
                AuthState.writeUserLog(AuthState.getCurrentUserId());
                Program.SetMainForm(new MainForm(AuthState.getCurrentUserId(), this.username.Text));
                Program.ShowMainForm();

                this.Close();
            }
            else
            {
                MessageBox.Show(errorMessage);
                password.Text = "";
            }
        }

        private void languageSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            if(languageSelect.SelectedValue.ToString() == "English/Ingles")
            {
                welcomeLabel.Text = "Welcome to scheduling services, please log-in.";
                usernameLabel.Text = "Username";
                passwordLabel.Text = "Password";
                loginButton.Text = "Login";
                cancelButton.Text = "Cancel";
                errorMessage = "The username and password did not match any records in the database.";
                timeZoneLabel.Text = "Time Zone:";
                languageLabel.Text = "Language";
            }
            else if(languageSelect.SelectedValue.ToString() == "Spanish/Espanol")
            {
                welcomeLabel.Text = "Bienvenido a los servicios de programación, inicie sesión.";
                usernameLabel.Text = "Nombre de usuario";
                passwordLabel.Text = "Contraseña";
                loginButton.Text = "Ingrese a su cuenta";
                cancelButton.Text = "Cancelar";
                errorMessage = "El nombre de usuario y la contraseña no coincidían con ningún registro en la base de datos.";
                timeZoneLabel.Text = "Zona Horaria:";
                languageLabel.Text = "Idioma";
            }
            else
            {
                MessageBox.Show("Unable to determine Language preference, reverting to english");
                this.languageSelect.SelectedIndex = 0;
            }
        }
    }

}
