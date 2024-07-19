namespace BranchingPractice
{
    partial class Form1
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
            btnDisplayGreeting = new Button();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // btnDisplayGreeting
            // 
            btnDisplayGreeting.Location = new Point(91, 147);
            btnDisplayGreeting.Name = "btnDisplayGreeting";
            btnDisplayGreeting.Size = new Size(104, 23);
            btnDisplayGreeting.TabIndex = 0;
            btnDisplayGreeting.Text = "Display greeting";
            btnDisplayGreeting.UseVisualStyleBackColor = true;
            btnDisplayGreeting.Click += btnDisplayGreeting_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(91, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(btnDisplayGreeting);
            Name = "Form1";
            Text = "Branching Practice";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDisplayGreeting;
        private TextBox txtName;
    }
}
