
namespace WorkTasks
{
    partial class startForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.viewTasksButton = new System.Windows.Forms.Button();
            this.assignTasks = new System.Windows.Forms.Button();
            this.manageTasks = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current employees";
            // 
            // viewTasksButton
            // 
            this.viewTasksButton.Location = new System.Drawing.Point(160, 26);
            this.viewTasksButton.Name = "viewTasksButton";
            this.viewTasksButton.Size = new System.Drawing.Size(145, 54);
            this.viewTasksButton.TabIndex = 2;
            this.viewTasksButton.Text = "View Tasks";
            this.viewTasksButton.UseVisualStyleBackColor = true;
            this.viewTasksButton.Click += new System.EventHandler(this.viewTasksButton_Click);
            // 
            // assignTasks
            // 
            this.assignTasks.Location = new System.Drawing.Point(472, 26);
            this.assignTasks.Name = "assignTasks";
            this.assignTasks.Size = new System.Drawing.Size(155, 54);
            this.assignTasks.TabIndex = 3;
            this.assignTasks.Text = "Assign Tasks";
            this.assignTasks.UseVisualStyleBackColor = true;
            this.assignTasks.Click += new System.EventHandler(this.assignTasks_Click);
            // 
            // manageTasks
            // 
            this.manageTasks.Location = new System.Drawing.Point(633, 26);
            this.manageTasks.Name = "manageTasks";
            this.manageTasks.Size = new System.Drawing.Size(155, 54);
            this.manageTasks.TabIndex = 4;
            this.manageTasks.Text = "Manage Tasks";
            this.manageTasks.UseVisualStyleBackColor = true;
            this.manageTasks.Click += new System.EventHandler(this.manageTasks_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(311, 26);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(155, 54);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Task";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.manageTasks);
            this.Controls.Add(this.assignTasks);
            this.Controls.Add(this.viewTasksButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "startForm";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewTasksButton;
        private System.Windows.Forms.Button assignTasks;
        private System.Windows.Forms.Button manageTasks;
        private System.Windows.Forms.Button addButton;
    }
}

