
namespace SchedulingService.Views
{
	partial class AppointmentForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.appointPageLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.customerId = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.contactLabel = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // appointPageLabel
            // 
            this.appointPageLabel.AutoSize = true;
            this.appointPageLabel.Location = new System.Drawing.Point(16, 11);
            this.appointPageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appointPageLabel.Name = "appointPageLabel";
            this.appointPageLabel.Size = new System.Drawing.Size(168, 17);
            this.appointPageLabel.TabIndex = 0;
            this.appointPageLabel.Text = "Add/Modify Appointments";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(220, 151);
            this.customerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(68, 17);
            this.customerLabel.TabIndex = 1;
            this.customerLabel.Text = "Customer";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(220, 186);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(118, 17);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Appointment Title";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(220, 221);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(220, 296);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(40, 17);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "Type";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(220, 334);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(36, 17);
            this.urlLabel.TabIndex = 5;
            this.urlLabel.Text = "URL";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(220, 257);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(62, 17);
            this.locationLabel.TabIndex = 6;
            this.locationLabel.Text = "Location";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(220, 370);
            this.startLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(73, 17);
            this.startLabel.TabIndex = 7;
            this.startLabel.Text = "Start Time";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(643, 370);
            this.endLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(68, 17);
            this.endLabel.TabIndex = 8;
            this.endLabel.Text = "End Time";
            // 
            // customerId
            // 
            this.customerId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.customerId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customerId.FormattingEnabled = true;
            this.customerId.Location = new System.Drawing.Point(403, 148);
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(178, 24);
            this.customerId.TabIndex = 9;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(403, 183);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(178, 22);
            this.title.TabIndex = 10;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(403, 218);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(348, 22);
            this.description.TabIndex = 11;
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(403, 254);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(348, 22);
            this.location.TabIndex = 12;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(403, 293);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(178, 22);
            this.type.TabIndex = 13;
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(403, 331);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(178, 22);
            this.url.TabIndex = 14;
            // 
            // start
            // 
            this.start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.start.Location = new System.Drawing.Point(403, 370);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(178, 22);
            this.start.TabIndex = 15;
            // 
            // end
            // 
            this.end.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.end.Location = new System.Drawing.Point(757, 365);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(178, 22);
            this.end.TabIndex = 16;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(288, 439);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(200, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(511, 439);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(200, 23);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(643, 296);
            this.contactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(56, 17);
            this.contactLabel.TabIndex = 19;
            this.contactLabel.Text = "Contact";
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(757, 296);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(178, 22);
            this.contact.TabIndex = 20;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.url);
            this.Controls.Add(this.type);
            this.Controls.Add(this.location);
            this.Controls.Add(this.description);
            this.Controls.Add(this.title);
            this.Controls.Add(this.customerId);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.appointPageLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label appointPageLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.ComboBox customerId;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.DateTimePicker start;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox contact;
    }
}