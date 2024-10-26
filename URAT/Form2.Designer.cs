namespace URAT
{
    partial class Form2
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
            button1 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 136);
            button1.Name = "button1";
            button1.Size = new Size(420, 34);
            button1.TabIndex = 13;
            button1.Text = "Login and launch";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 12;
            label3.Text = "Password:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(420, 31);
            textBox3.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 10;
            label2.Text = "Username:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(420, 31);
            textBox2.TabIndex = 9;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 180);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CollosalMW3 - Login";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
    }
}