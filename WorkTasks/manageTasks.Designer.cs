
namespace WorkTasks
{
    partial class manageTasks
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
            this.label1 = new System.Windows.Forms.Label();
            this.openStatus = new System.Windows.Forms.Button();
            this.inProgressStatus = new System.Windows.Forms.Button();
            this.completedStatus = new System.Windows.Forms.Button();
            this.blockedStatus = new System.Windows.Forms.Button();
            this.closedStatus = new System.Windows.Forms.Button();
            this.deleteCompleted = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(122, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task Status";
            // 
            // openStatus
            // 
            this.openStatus.Location = new System.Drawing.Point(479, 57);
            this.openStatus.Name = "openStatus";
            this.openStatus.Size = new System.Drawing.Size(154, 47);
            this.openStatus.TabIndex = 2;
            this.openStatus.Text = "Open";
            this.openStatus.UseVisualStyleBackColor = true;
            this.openStatus.Click += new System.EventHandler(this.openStatus_Click);
            // 
            // inProgressStatus
            // 
            this.inProgressStatus.Location = new System.Drawing.Point(479, 110);
            this.inProgressStatus.Name = "inProgressStatus";
            this.inProgressStatus.Size = new System.Drawing.Size(154, 47);
            this.inProgressStatus.TabIndex = 3;
            this.inProgressStatus.Text = "In Progress";
            this.inProgressStatus.UseVisualStyleBackColor = true;
            this.inProgressStatus.Click += new System.EventHandler(this.inProgressStatus_Click);
            // 
            // completedStatus
            // 
            this.completedStatus.Location = new System.Drawing.Point(479, 163);
            this.completedStatus.Name = "completedStatus";
            this.completedStatus.Size = new System.Drawing.Size(154, 47);
            this.completedStatus.TabIndex = 4;
            this.completedStatus.Text = "Completed";
            this.completedStatus.UseVisualStyleBackColor = true;
            this.completedStatus.Click += new System.EventHandler(this.completedStatus_Click);
            // 
            // blockedStatus
            // 
            this.blockedStatus.Location = new System.Drawing.Point(479, 216);
            this.blockedStatus.Name = "blockedStatus";
            this.blockedStatus.Size = new System.Drawing.Size(154, 47);
            this.blockedStatus.TabIndex = 5;
            this.blockedStatus.Text = "Blocked";
            this.blockedStatus.UseVisualStyleBackColor = true;
            this.blockedStatus.Click += new System.EventHandler(this.blockedStatus_Click);
            // 
            // closedStatus
            // 
            this.closedStatus.Location = new System.Drawing.Point(479, 269);
            this.closedStatus.Name = "closedStatus";
            this.closedStatus.Size = new System.Drawing.Size(154, 47);
            this.closedStatus.TabIndex = 6;
            this.closedStatus.Text = "Closed";
            this.closedStatus.UseVisualStyleBackColor = true;
            this.closedStatus.Click += new System.EventHandler(this.closedStatus_Click);
            // 
            // deleteCompleted
            // 
            this.deleteCompleted.Location = new System.Drawing.Point(479, 322);
            this.deleteCompleted.Name = "deleteCompleted";
            this.deleteCompleted.Size = new System.Drawing.Size(154, 47);
            this.deleteCompleted.TabIndex = 7;
            this.deleteCompleted.Text = "Delete Completed";
            this.deleteCompleted.UseVisualStyleBackColor = true;
            this.deleteCompleted.Click += new System.EventHandler(this.deleteCompleted_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(479, 375);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deleteAll.Size = new System.Drawing.Size(154, 47);
            this.deleteAll.TabIndex = 8;
            this.deleteAll.Text = "Delete All";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(122, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 354);
            this.dataGridView1.TabIndex = 9;
            // 
            // manageTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.deleteCompleted);
            this.Controls.Add(this.closedStatus);
            this.Controls.Add(this.blockedStatus);
            this.Controls.Add(this.completedStatus);
            this.Controls.Add(this.inProgressStatus);
            this.Controls.Add(this.openStatus);
            this.Controls.Add(this.label1);
            this.Name = "manageTasks";
            this.Text = "manageTasks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openStatus;
        private System.Windows.Forms.Button inProgressStatus;
        private System.Windows.Forms.Button completedStatus;
        private System.Windows.Forms.Button blockedStatus;
        private System.Windows.Forms.Button closedStatus;
        private System.Windows.Forms.Button deleteCompleted;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}