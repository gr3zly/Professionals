namespace Sorbent
{
    partial class ucTasks
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
            tabControlTasks = new TabControl();
            tabNew = new TabPage();
            dgvNew = new DataGridView();
            tabInWork = new TabPage();
            dgvInWork = new DataGridView();
            tabCompleted = new TabPage();
            dgvCompleted = new DataGridView();
            btnRefresh = new Button();
            btnNewTask = new Button();
            tabControlTasks.SuspendLayout();
            tabNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNew).BeginInit();
            tabInWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInWork).BeginInit();
            tabCompleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompleted).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(24, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(167, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Задачи смены";
            // 
            // tabControlTasks
            // 
            tabControlTasks.Controls.Add(tabNew);
            tabControlTasks.Controls.Add(tabInWork);
            tabControlTasks.Controls.Add(tabCompleted);
            tabControlTasks.Location = new Point(24, 45);
            tabControlTasks.Name = "tabControlTasks";
            tabControlTasks.SelectedIndex = 0;
            tabControlTasks.Size = new Size(492, 339);
            tabControlTasks.TabIndex = 1;
            // 
            // tabNew
            // 
            tabNew.Controls.Add(dgvNew);
            tabNew.Location = new Point(4, 24);
            tabNew.Name = "tabNew";
            tabNew.Size = new Size(484, 311);
            tabNew.TabIndex = 0;
            tabNew.Text = "Новые";
            // 
            // dgvNew
            // 
            dgvNew.AllowUserToAddRows = false;
            dgvNew.Dock = DockStyle.Fill;
            dgvNew.Location = new Point(0, 0);
            dgvNew.Name = "dgvNew";
            dgvNew.ReadOnly = true;
            dgvNew.RowHeadersVisible = false;
            dgvNew.Size = new Size(484, 311);
            dgvNew.TabIndex = 0;
            // 
            // tabInWork
            // 
            tabInWork.Controls.Add(dgvInWork);
            tabInWork.Location = new Point(4, 24);
            tabInWork.Name = "tabInWork";
            tabInWork.Size = new Size(484, 311);
            tabInWork.TabIndex = 1;
            tabInWork.Text = "В работе";
            // 
            // dgvInWork
            // 
            dgvInWork.AllowUserToAddRows = false;
            dgvInWork.Dock = DockStyle.Fill;
            dgvInWork.Location = new Point(0, 0);
            dgvInWork.Name = "dgvInWork";
            dgvInWork.ReadOnly = true;
            dgvInWork.RowHeadersVisible = false;
            dgvInWork.Size = new Size(484, 311);
            dgvInWork.TabIndex = 0;
            // 
            // tabCompleted
            // 
            tabCompleted.Controls.Add(dgvCompleted);
            tabCompleted.Location = new Point(4, 24);
            tabCompleted.Name = "tabCompleted";
            tabCompleted.Size = new Size(484, 311);
            tabCompleted.TabIndex = 2;
            tabCompleted.Text = "Завершённые";
            // 
            // dgvCompleted
            // 
            dgvCompleted.AllowUserToAddRows = false;
            dgvCompleted.Dock = DockStyle.Fill;
            dgvCompleted.Location = new Point(0, 0);
            dgvCompleted.Name = "dgvCompleted";
            dgvCompleted.ReadOnly = true;
            dgvCompleted.RowHeadersVisible = false;
            dgvCompleted.Size = new Size(484, 311);
            dgvCompleted.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(28, 387);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(180, 40);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Обновить список";
            // 
            // btnNewTask
            // 
            btnNewTask.Location = new Point(214, 387);
            btnNewTask.Name = "btnNewTask";
            btnNewTask.Size = new Size(180, 40);
            btnNewTask.TabIndex = 3;
            btnNewTask.Text = "Создать новую задачу";
            // 
            // ucTasks
            // 
            Controls.Add(lblTitle);
            Controls.Add(tabControlTasks);
            Controls.Add(btnRefresh);
            Controls.Add(btnNewTask);
            Name = "ucTasks";
            Size = new Size(540, 472);
            tabControlTasks.ResumeLayout(false);
            tabNew.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNew).EndInit();
            tabInWork.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInWork).EndInit();
            tabCompleted.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCompleted).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControlTasks;
        private System.Windows.Forms.TabPage tabNew;
        private System.Windows.Forms.TabPage tabInWork;
        private System.Windows.Forms.TabPage tabCompleted;
        private System.Windows.Forms.DataGridView dgvNew;
        private System.Windows.Forms.DataGridView dgvInWork;
        private System.Windows.Forms.DataGridView dgvCompleted;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNewTask;
    }
}
