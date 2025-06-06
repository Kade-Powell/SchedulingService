﻿using SchedulingService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingService.Views
{
    public partial class UserScheduleForm : Form
    {
        public MasterSchedule MasterSchedule = new MasterSchedule();
        public UserScheduleForm()
        {
            InitializeComponent();
            userScheduleDataGrid.DataSource = MasterSchedule;
            userComboBox.DataSource = MasterSchedule.UsersSchedules.Values.ToList();
            userComboBox.DisplayMember = "Username";
            userComboBox.ValueMember = "UserId";
            userScheduleDataGrid.Visible = true;
            Schedule selectedSchedule = (Schedule)userComboBox.SelectedItem;
            userScheduleDataGrid.DataSource = selectedSchedule.UsersAppointments;
        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Schedule selectedSchedule = (Schedule)userComboBox.SelectedItem;
            userScheduleDataGrid.DataSource = selectedSchedule.UsersAppointments;
        }
    }
}
