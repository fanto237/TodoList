namespace TodoListForms
{
    partial class TodoListWindow
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
            this.toDoListSaveButton = new System.Windows.Forms.Button();
            this.toDoListGroupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // toDoListSaveButton
            // 
            this.toDoListSaveButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toDoListSaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.toDoListSaveButton.Location = new System.Drawing.Point(401, 835);
            this.toDoListSaveButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.toDoListSaveButton.Name = "toDoListSaveButton";
            this.toDoListSaveButton.Size = new System.Drawing.Size(233, 70);
            this.toDoListSaveButton.TabIndex = 0;
            this.toDoListSaveButton.Text = "Speichern";
            this.toDoListSaveButton.UseVisualStyleBackColor = true;
            this.toDoListSaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // toDoListGroupBox
            // 
            this.toDoListGroupBox.Location = new System.Drawing.Point(607, 76);
            this.toDoListGroupBox.Name = "toDoListGroupBox";
            this.toDoListGroupBox.Size = new System.Drawing.Size(426, 606);
            this.toDoListGroupBox.TabIndex = 1;
            this.toDoListGroupBox.TabStop = false;
            this.toDoListGroupBox.Text = "Liste von Todos";
            // 
            // TodoListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 961);
            this.Controls.Add(this.toDoListGroupBox);
            this.Controls.Add(this.toDoListSaveButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TodoListWindow";
            this.Text = "Todo List Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button toDoListSaveButton;
        private GroupBox toDoListGroupBox;
    }
}