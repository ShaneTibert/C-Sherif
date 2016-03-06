namespace Assignment3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.populateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTakenQuizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.populateToolStripMenuItem,
            this.takeQuizToolStripMenuItem,
            this.displayTakenQuizesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(269, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // populateToolStripMenuItem
            // 
            this.populateToolStripMenuItem.Name = "populateToolStripMenuItem";
            this.populateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.populateToolStripMenuItem.Text = "populate";
            // 
            // takeQuizToolStripMenuItem
            // 
            this.takeQuizToolStripMenuItem.Name = "takeQuizToolStripMenuItem";
            this.takeQuizToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.takeQuizToolStripMenuItem.Text = "Take Quiz";
            // 
            // displayTakenQuizesToolStripMenuItem
            // 
            this.displayTakenQuizesToolStripMenuItem.Name = "displayTakenQuizesToolStripMenuItem";
            this.displayTakenQuizesToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.displayTakenQuizesToolStripMenuItem.Text = "Display taken Quizes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 26);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quiz";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem populateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayTakenQuizesToolStripMenuItem;
    }
}

