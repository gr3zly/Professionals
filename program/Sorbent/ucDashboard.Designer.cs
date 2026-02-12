namespace Sorbent
{
    partial class ucDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDashboard));
            lblTitle = new Label();
            lblDateShift = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(24, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(227, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Дашборд технолога";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblDateShift
            // 
            lblDateShift.AutoSize = true;
            lblDateShift.Font = new Font("Segoe UI", 10F);
            lblDateShift.Location = new Point(24, 55);
            lblDateShift.Name = "lblDateShift";
            lblDateShift.Size = new Size(380, 19);
            lblDateShift.TabIndex = 1;
            lblDateShift.Text = "Сегодня: 11 февраля 2026   Смена: Дневная   08:00–20:00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(24, 97);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 3;
            label1.Text = "Метрики";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 244);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(284, 183);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(24, 204);
            label2.Name = "label2";
            label2.Size = new Size(182, 21);
            label2.TabIndex = 6;
            label2.Text = "График производства";
            // 
            // ucDashboard
            // 
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(lblDateShift);
            Name = "ucDashboard";
            Size = new Size(540, 472);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Объявления всех элементов
        private Label lblTitle;
        private Label lblDateShift;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
    }
}
