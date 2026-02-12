namespace Sorbent
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelContent = new Panel();
            mainMenu = new MenuStrip();
            menuNavigation = new ToolStripMenuItem();
            miDashboard = new ToolStripMenuItem();
            miPersonalCabinet = new ToolStripMenuItem();
            miMonitoring = new ToolStripMenuItem();
            miTasks = new ToolStripMenuItem();
            menuFile = new ToolStripMenuItem();
            miExit = new ToolStripMenuItem();
            panelContent.SuspendLayout();
            mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BorderStyle = BorderStyle.FixedSingle;
            panelContent.Controls.Add(mainMenu);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(524, 461);
            panelContent.TabIndex = 0;
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new ToolStripItem[] { menuNavigation, menuFile });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(522, 24);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // menuNavigation
            // 
            menuNavigation.DropDownItems.AddRange(new ToolStripItem[] { miDashboard, miPersonalCabinet, miMonitoring, miTasks });
            menuNavigation.Name = "menuNavigation";
            menuNavigation.Size = new Size(78, 20);
            menuNavigation.Text = "Навигация";
            menuNavigation.Click += menuNavigation_Click;
            // 
            // miDashboard
            // 
            miDashboard.Name = "miDashboard";
            miDashboard.Size = new Size(166, 22);
            miDashboard.Text = "Дашборд";
            miDashboard.Click += miDashboard_Click;
            // 
            // miPersonalCabinet
            // 
            miPersonalCabinet.Name = "miPersonalCabinet";
            miPersonalCabinet.Size = new Size(166, 22);
            miPersonalCabinet.Text = "Личный кабинет";
            miPersonalCabinet.Click += miPersonalCabinet_Click;
            // 
            // miMonitoring
            // 
            miMonitoring.Name = "miMonitoring";
            miMonitoring.Size = new Size(166, 22);
            miMonitoring.Text = "Мониторинг";
            miMonitoring.Click += miMonitoring_Click;
            // 
            // miTasks
            // 
            miTasks.Name = "miTasks";
            miTasks.Size = new Size(166, 22);
            miTasks.Text = "Задачи";
            miTasks.Click += miTasks_Click;
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { miExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(48, 20);
            menuFile.Text = "Файл";
            menuFile.Click += menuFile_Click;
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            miExit.Size = new Size(108, 22);
            miExit.Text = "Выход";
            miExit.Click += miExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 461);
            Controls.Add(panelContent);
            MainMenuStrip = mainMenu;
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContent;
        private MenuStrip mainMenu;
        private ToolStripMenuItem menuNavigation;
        private ToolStripMenuItem miDashboard;
        private ToolStripMenuItem miPersonalCabinet;
        private ToolStripMenuItem miMonitoring;
        private ToolStripMenuItem miTasks;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem miExit;
    }
}
