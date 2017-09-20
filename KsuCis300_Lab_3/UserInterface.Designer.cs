namespace KsuCis300_Lab_3
{
    partial class UserInterface
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
            this.uxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.uxFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxTextBox = new System.Windows.Forms.TextBox();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFileToolStripMenuItem});
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Size = new System.Drawing.Size(958, 40);
            this.uxMenuStrip.TabIndex = 0;
            this.uxMenuStrip.Text = "menuStrip1";
            // 
            // uxFileToolStripMenuItem
            // 
            this.uxFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenToolStripMenuItem,
            this.uxSaveAsToolStripMenuItem});
            this.uxFileToolStripMenuItem.Name = "uxFileToolStripMenuItem";
            this.uxFileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.uxFileToolStripMenuItem.Text = "File";
            // 
            // uxOpenToolStripMenuItem
            // 
            this.uxOpenToolStripMenuItem.Name = "uxOpenToolStripMenuItem";
            this.uxOpenToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.uxOpenToolStripMenuItem.Text = "Open...";
            this.uxOpenToolStripMenuItem.Click += new System.EventHandler(this.uxOpenToolStripMenuItem_Click);
            // 
            // uxSaveAsToolStripMenuItem
            // 
            this.uxSaveAsToolStripMenuItem.Name = "uxSaveAsToolStripMenuItem";
            this.uxSaveAsToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.uxSaveAsToolStripMenuItem.Text = "Save As...";
            this.uxSaveAsToolStripMenuItem.Click += new System.EventHandler(this.uxSaveAsToolStripMenuItem_Click);
            // 
            // uxTextBox
            // 
            this.uxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBox.Location = new System.Drawing.Point(22, 68);
            this.uxTextBox.Multiline = true;
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxTextBox.Size = new System.Drawing.Size(914, 481);
            this.uxTextBox.TabIndex = 1;
            // 
            // uxOpenFileDialog
            // 
            this.uxOpenFileDialog.FileName = "openFileDialog1";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 577);
            this.Controls.Add(this.uxTextBox);
            this.Controls.Add(this.uxMenuStrip);
            this.MainMenuStrip = this.uxMenuStrip;
            this.Name = "UserInterface";
            this.Text = "Form1";
            this.uxMenuStrip.ResumeLayout(false);
            this.uxMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem uxFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxSaveAsToolStripMenuItem;
        private System.Windows.Forms.TextBox uxTextBox;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
    }
}

