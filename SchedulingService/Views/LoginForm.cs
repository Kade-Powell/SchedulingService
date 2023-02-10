using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingService
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

        private void LoginForm_Load(object sender, EventArgs e)
        {
			this.languageSelect.SelectedIndex = 0;
			this.timeZoneText.Text = TimeZone.CurrentTimeZone.StandardName;
        }
    }
}
