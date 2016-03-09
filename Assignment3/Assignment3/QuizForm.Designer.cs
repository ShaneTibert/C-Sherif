namespace Assignment3
{
    partial class QuizForm
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
            this.Option1 = new System.Windows.Forms.Button();
            this.Option2 = new System.Windows.Forms.Button();
            this.Option3 = new System.Windows.Forms.Button();
            this.Option4 = new System.Windows.Forms.Button();
            this.Option5 = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Option1
            // 
            this.Option1.Location = new System.Drawing.Point(13, 118);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(221, 42);
            this.Option1.TabIndex = 0;
            this.Option1.Text = "Option1";
            this.Option1.UseVisualStyleBackColor = true;
            // 
            // Option2
            // 
            this.Option2.Location = new System.Drawing.Point(249, 118);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(221, 42);
            this.Option2.TabIndex = 1;
            this.Option2.Text = "Option2";
            this.Option2.UseVisualStyleBackColor = true;
            this.Option2.Click += new System.EventHandler(this.Option2_Click);
            // 
            // Option3
            // 
            this.Option3.Location = new System.Drawing.Point(13, 181);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(221, 42);
            this.Option3.TabIndex = 2;
            this.Option3.Text = "Option3";
            this.Option3.UseVisualStyleBackColor = true;
            // 
            // Option4
            // 
            this.Option4.Location = new System.Drawing.Point(249, 181);
            this.Option4.Name = "Option4";
            this.Option4.Size = new System.Drawing.Size(221, 42);
            this.Option4.TabIndex = 3;
            this.Option4.Text = "Option4";
            this.Option4.UseVisualStyleBackColor = true;
            // 
            // Option5
            // 
            this.Option5.Location = new System.Drawing.Point(131, 236);
            this.Option5.Name = "Option5";
            this.Option5.Size = new System.Drawing.Size(221, 42);
            this.Option5.TabIndex = 4;
            this.Option5.Text = "Option5";
            this.Option5.UseVisualStyleBackColor = true;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(13, 13);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(75, 13);
            this.QuestionLabel.TabIndex = 5;
            this.QuestionLabel.Text = "QuestionLabel";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 290);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.Option5);
            this.Controls.Add(this.Option4);
            this.Controls.Add(this.Option3);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Option1;
        private System.Windows.Forms.Button Option2;
        private System.Windows.Forms.Button Option3;
        private System.Windows.Forms.Button Option4;
        private System.Windows.Forms.Button Option5;
        private System.Windows.Forms.Label QuestionLabel;
    }
}