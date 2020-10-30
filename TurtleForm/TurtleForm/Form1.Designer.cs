namespace TurtleForm
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
            this.drawBox = new System.Windows.Forms.PictureBox();
            this.commandLineBox = new System.Windows.Forms.TextBox();
            this.multiLineCmd = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drawBox
            // 
            this.drawBox.Location = new System.Drawing.Point(653, 28);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(466, 566);
            this.drawBox.TabIndex = 3;
            this.drawBox.TabStop = false;
            this.drawBox.Click += new System.EventHandler(this.drawBox_Click);
            this.drawBox.Paint += new System.Windows.Forms.PaintEventHandler(this.drawBox_Paint_1);
            // 
            // commandLineBox
            // 
            this.commandLineBox.Location = new System.Drawing.Point(32, 543);
            this.commandLineBox.Name = "commandLineBox";
            this.commandLineBox.Size = new System.Drawing.Size(180, 20);
            this.commandLineBox.TabIndex = 4;
            this.commandLineBox.TextChanged += new System.EventHandler(this.commandLineBox_TextChanged_1);
            this.commandLineBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandLineBox_KeyDown);
            // 
            // multiLineCmd
            // 
            this.multiLineCmd.Location = new System.Drawing.Point(32, 28);
            this.multiLineCmd.Name = "multiLineCmd";
            this.multiLineCmd.Size = new System.Drawing.Size(446, 484);
            this.multiLineCmd.TabIndex = 5;
            this.multiLineCmd.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 642);
            this.Controls.Add(this.multiLineCmd);
            this.Controls.Add(this.commandLineBox);
            this.Controls.Add(this.drawBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox drawBox;
        private System.Windows.Forms.TextBox commandLineBox;
        private System.Windows.Forms.RichTextBox multiLineCmd;
    }
}

