namespace Sorbent
{
    partial class ucMonitoring
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
            lblTitle = new Label();
            lblDateTime = new Label();
            pnlStatus1 = new Panel();
            lblStatus1_Title = new Label();
            lblStatus1_Value = new Label();
            pnlStatus2 = new Panel();
            lblStatus2_Title = new Label();
            lblStatus2_Value = new Label();
            pnlStatus3 = new Panel();
            lblStatus3_Title = new Label();
            lblStatus3_Value = new Label();
            btnRefresh = new Button();
            btnJournal = new Button();
            dgvEvents = new DataGridView();
            pnlStatus1.SuspendLayout();
            pnlStatus2.SuspendLayout();
            pnlStatus3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(24, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(322, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Мониторинг текущей смены";
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI", 10F);
            lblDateTime.Location = new Point(24, 46);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(274, 19);
            lblDateTime.TabIndex = 1;
            lblDateTime.Text = "11 февраля 2026   14:35   Смена дневная";
            // 
            // pnlStatus1
            // 
            pnlStatus1.BackColor = Color.LightGreen;
            pnlStatus1.BorderStyle = BorderStyle.FixedSingle;
            pnlStatus1.Controls.Add(lblStatus1_Title);
            pnlStatus1.Controls.Add(lblStatus1_Value);
            pnlStatus1.Location = new Point(24, 88);
            pnlStatus1.Name = "pnlStatus1";
            pnlStatus1.Size = new Size(150, 90);
            pnlStatus1.TabIndex = 2;
            // 
            // lblStatus1_Title
            // 
            lblStatus1_Title.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblStatus1_Title.Location = new Point(10, 10);
            lblStatus1_Title.Name = "lblStatus1_Title";
            lblStatus1_Title.Size = new Size(100, 23);
            lblStatus1_Title.TabIndex = 0;
            lblStatus1_Title.Text = "Оборудование";
            // 
            // lblStatus1_Value
            // 
            lblStatus1_Value.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblStatus1_Value.Location = new Point(10, 40);
            lblStatus1_Value.Name = "lblStatus1_Value";
            lblStatus1_Value.Size = new Size(100, 23);
            lblStatus1_Value.TabIndex = 1;
            lblStatus1_Value.Text = "Норма";
            // 
            // pnlStatus2
            // 
            pnlStatus2.BackColor = Color.LightYellow;
            pnlStatus2.BorderStyle = BorderStyle.FixedSingle;
            pnlStatus2.Controls.Add(lblStatus2_Title);
            pnlStatus2.Controls.Add(lblStatus2_Value);
            pnlStatus2.Location = new Point(196, 88);
            pnlStatus2.Name = "pnlStatus2";
            pnlStatus2.Size = new Size(150, 90);
            pnlStatus2.TabIndex = 3;
            // 
            // lblStatus2_Title
            // 
            lblStatus2_Title.Location = new Point(10, 10);
            lblStatus2_Title.Name = "lblStatus2_Title";
            lblStatus2_Title.Size = new Size(100, 23);
            lblStatus2_Title.TabIndex = 0;
            lblStatus2_Title.Text = "Температура";
            // 
            // lblStatus2_Value
            // 
            lblStatus2_Value.Location = new Point(10, 45);
            lblStatus2_Value.Name = "lblStatus2_Value";
            lblStatus2_Value.Size = new Size(100, 23);
            lblStatus2_Value.TabIndex = 1;
            lblStatus2_Value.Text = "38 °C";
            // 
            // pnlStatus3
            // 
            pnlStatus3.BackColor = Color.LightCoral;
            pnlStatus3.BorderStyle = BorderStyle.FixedSingle;
            pnlStatus3.Controls.Add(lblStatus3_Title);
            pnlStatus3.Controls.Add(lblStatus3_Value);
            pnlStatus3.Location = new Point(366, 88);
            pnlStatus3.Name = "pnlStatus3";
            pnlStatus3.Size = new Size(150, 90);
            pnlStatus3.TabIndex = 4;
            // 
            // lblStatus3_Title
            // 
            lblStatus3_Title.Location = new Point(10, 10);
            lblStatus3_Title.Name = "lblStatus3_Title";
            lblStatus3_Title.Size = new Size(100, 23);
            lblStatus3_Title.TabIndex = 0;
            lblStatus3_Title.Text = "Давление";
            // 
            // lblStatus3_Value
            // 
            lblStatus3_Value.Location = new Point(10, 45);
            lblStatus3_Value.Name = "lblStatus3_Value";
            lblStatus3_Value.Size = new Size(100, 23);
            lblStatus3_Value.TabIndex = 1;
            lblStatus3_Value.Text = "Выше нормы";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(24, 388);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(180, 40);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Обновить данные";
            // 
            // btnJournal
            // 
            btnJournal.Location = new Point(219, 388);
            btnJournal.Name = "btnJournal";
            btnJournal.Size = new Size(180, 40);
            btnJournal.TabIndex = 7;
            btnJournal.Text = "Открыть полный журнал";
            btnJournal.Click += btnJournal_Click;
            // 
            // dgvEvents
            // 
            dgvEvents.AllowUserToAddRows = false;
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Location = new Point(24, 193);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.ReadOnly = true;
            dgvEvents.RowHeadersVisible = false;
            dgvEvents.Size = new Size(492, 180);
            dgvEvents.TabIndex = 5;
            // 
            // ucMonitoring
            // 
            Controls.Add(lblTitle);
            Controls.Add(lblDateTime);
            Controls.Add(pnlStatus3);
            Controls.Add(pnlStatus1);
            Controls.Add(pnlStatus2);
            Controls.Add(dgvEvents);
            Controls.Add(btnRefresh);
            Controls.Add(btnJournal);
            Name = "ucMonitoring";
            Size = new Size(540, 472);
            pnlStatus1.ResumeLayout(false);
            pnlStatus2.ResumeLayout(false);
            pnlStatus3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel pnlStatus1;
        private System.Windows.Forms.Panel pnlStatus2;
        private System.Windows.Forms.Panel pnlStatus3;
        private System.Windows.Forms.Label lblStatus1_Title;
        private System.Windows.Forms.Label lblStatus1_Value;
        private System.Windows.Forms.Label lblStatus2_Title;
        private System.Windows.Forms.Label lblStatus2_Value;
        private System.Windows.Forms.Label lblStatus3_Title;
        private System.Windows.Forms.Label lblStatus3_Value;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnJournal;
        private DataGridView dgvEvents;
    }
}
