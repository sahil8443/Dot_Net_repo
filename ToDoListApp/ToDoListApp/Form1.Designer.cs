namespace ToDoListApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtTasks = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.btnMarkCompleted = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTasks
            // 
            this.txtTasks.Location = new System.Drawing.Point(92, 58);
            this.txtTasks.Name = "txtTasks";
            this.txtTasks.Size = new System.Drawing.Size(334, 20);
            this.txtTasks.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(464, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "AddTask";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.Location = new System.Drawing.Point(92, 110);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(334, 95);
            this.lstTasks.TabIndex = 3;
            this.lstTasks.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnMarkCompleted
            // 
            this.btnMarkCompleted.Location = new System.Drawing.Point(238, 245);
            this.btnMarkCompleted.Name = "btnMarkCompleted";
            this.btnMarkCompleted.Size = new System.Drawing.Size(106, 33);
            this.btnMarkCompleted.TabIndex = 4;
            this.btnMarkCompleted.Text = "MarkASComplete";
            this.btnMarkCompleted.UseVisualStyleBackColor = true;
            this.btnMarkCompleted.Click += new System.EventHandler(this.btnMarkCompleted_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(92, 245);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 33);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Task";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 492);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMarkCompleted);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTasks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTasks;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Button btnMarkCompleted;
        private System.Windows.Forms.Button btnDelete;
    }
}

