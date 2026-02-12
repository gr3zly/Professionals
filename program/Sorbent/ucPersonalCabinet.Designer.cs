namespace Sorbent
{
    partial class ucPersonalCabinet
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPersonalCabinet));
            pbPhoto = new PictureBox();
            lblFIO = new Label();
            lblSurname = new Label();
            lblName = new Label();
            lblPatronymic = new Label();
            lblPosition = new Label();
            lblExperience = new Label();
            lblWorkshop = new Label();
            txtSurname = new TextBox();
            txtName = new TextBox();
            txtPatronymic = new TextBox();
            txtPosition = new TextBox();
            txtExperience = new TextBox();
            txtWorkshop = new TextBox();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPhoto).BeginInit();
            SuspendLayout();
            // 
            // pbPhoto
            // 
            pbPhoto.BackColor = Color.WhiteSmoke;
            pbPhoto.BorderStyle = BorderStyle.FixedSingle;
            pbPhoto.Image = (Image)resources.GetObject("pbPhoto.Image");
            pbPhoto.Location = new Point(22, 47);
            pbPhoto.Margin = new Padding(3, 2, 3, 2);
            pbPhoto.Name = "pbPhoto";
            pbPhoto.Size = new Size(123, 125);
            pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbPhoto.TabIndex = 0;
            pbPhoto.TabStop = false;
            // 
            // lblFIO
            // 
            lblFIO.AutoSize = true;
            lblFIO.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFIO.Location = new Point(166, 47);
            lblFIO.Name = "lblFIO";
            lblFIO.Size = new Size(275, 25);
            lblFIO.TabIndex = 1;
            lblFIO.Text = "Личные данные сотрудника";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 10F);
            lblSurname.Location = new Point(166, 93);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(69, 19);
            lblSurname.TabIndex = 13;
            lblSurname.Text = "Фамилия:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(166, 123);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 19);
            lblName.TabIndex = 12;
            lblName.Text = "Имя:";
            // 
            // lblPatronymic
            // 
            lblPatronymic.AutoSize = true;
            lblPatronymic.Font = new Font("Segoe UI", 10F);
            lblPatronymic.Location = new Point(166, 153);
            lblPatronymic.Name = "lblPatronymic";
            lblPatronymic.Size = new Size(71, 19);
            lblPatronymic.TabIndex = 11;
            lblPatronymic.Text = "Отчество:";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 10F);
            lblPosition.Location = new Point(166, 190);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(82, 19);
            lblPosition.TabIndex = 10;
            lblPosition.Text = "Должность:";
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Font = new Font("Segoe UI", 10F);
            lblExperience.Location = new Point(166, 220);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(95, 19);
            lblExperience.TabIndex = 9;
            lblExperience.Text = "Стаж работы:";
            // 
            // lblWorkshop
            // 
            lblWorkshop.AutoSize = true;
            lblWorkshop.Font = new Font("Segoe UI", 10F);
            lblWorkshop.Location = new Point(166, 250);
            lblWorkshop.Name = "lblWorkshop";
            lblWorkshop.Size = new Size(97, 19);
            lblWorkshop.TabIndex = 8;
            lblWorkshop.Text = "Цех / участок:";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(281, 89);
            txtSurname.Margin = new Padding(3, 2, 3, 2);
            txtSurname.Name = "txtSurname";
            txtSurname.ReadOnly = true;
            txtSurname.Size = new Size(160, 23);
            txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(281, 119);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(160, 23);
            txtName.TabIndex = 3;
            // 
            // txtPatronymic
            // 
            txtPatronymic.Location = new Point(281, 149);
            txtPatronymic.Margin = new Padding(3, 2, 3, 2);
            txtPatronymic.Name = "txtPatronymic";
            txtPatronymic.ReadOnly = true;
            txtPatronymic.Size = new Size(160, 23);
            txtPatronymic.TabIndex = 4;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(281, 187);
            txtPosition.Margin = new Padding(3, 2, 3, 2);
            txtPosition.Name = "txtPosition";
            txtPosition.ReadOnly = true;
            txtPosition.Size = new Size(160, 23);
            txtPosition.TabIndex = 5;
            // 
            // txtExperience
            // 
            txtExperience.Location = new Point(281, 217);
            txtExperience.Margin = new Padding(3, 2, 3, 2);
            txtExperience.Name = "txtExperience";
            txtExperience.ReadOnly = true;
            txtExperience.Size = new Size(160, 23);
            txtExperience.TabIndex = 6;
            // 
            // txtWorkshop
            // 
            txtWorkshop.Location = new Point(281, 247);
            txtWorkshop.Margin = new Padding(3, 2, 3, 2);
            txtWorkshop.Name = "txtWorkshop";
            txtWorkshop.ReadOnly = true;
            txtWorkshop.Size = new Size(160, 23);
            txtWorkshop.TabIndex = 7;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(22, 190);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(123, 40);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Редактировать";
            // 
            // ucPersonalCabinet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefresh);
            Controls.Add(txtWorkshop);
            Controls.Add(txtExperience);
            Controls.Add(txtPosition);
            Controls.Add(txtPatronymic);
            Controls.Add(txtName);
            Controls.Add(txtSurname);
            Controls.Add(lblWorkshop);
            Controls.Add(lblExperience);
            Controls.Add(lblPosition);
            Controls.Add(lblPatronymic);
            Controls.Add(lblName);
            Controls.Add(lblSurname);
            Controls.Add(lblFIO);
            Controls.Add(pbPhoto);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucPersonalCabinet";
            Size = new Size(458, 346);
            ((System.ComponentModel.ISupportInitialize)pbPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label lblFIO;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblWorkshop;

        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.TextBox txtWorkshop;
        private Button btnRefresh;
    }
}
