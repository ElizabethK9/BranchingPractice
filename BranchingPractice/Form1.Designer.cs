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
            BtnDisplayGreeting = new Button();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // BtnDisplayGreeting
            // 
            BtnDisplayGreeting.Location = new Point(87, 126);
            BtnDisplayGreeting.Name = "BtnDisplayGreeting";
            BtnDisplayGreeting.Size = new Size(104, 44);
            BtnDisplayGreeting.TabIndex = 0;
            BtnDisplayGreeting.Text = "Display greeting";
            BtnDisplayGreeting.UseVisualStyleBackColor = true;
            BtnDisplayGreeting.Click += BtnDisplayGreeting_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(87, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(104, 23);
            txtName.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 240);
            Controls.Add(txtName);
            Controls.Add(BtnDisplayGreeting);
            Name = "Form1";
            Text = "Branching Practice";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnDisplayGreeting;
        private TextBox txtName;
    }
}
