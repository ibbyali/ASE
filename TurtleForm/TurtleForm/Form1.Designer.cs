namespace TurtleForm
{
    partial class execute
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drawBox
            // 
            this.drawBox.BackColor = System.Drawing.SystemColors.Window;
            this.drawBox.Location = new System.Drawing.Point(652, 23);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(466, 489);
            this.drawBox.TabIndex = 3;
            this.drawBox.TabStop = false;
            this.drawBox.Click += new System.EventHandler(this.drawBox_Click);
            this.drawBox.Paint += new System.Windows.Forms.PaintEventHandler(this.drawBox_Paint_1);
            // 
            // commandLineBox
            // 
            this.commandLineBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandLineBox.Location = new System.Drawing.Point(32, 543);
            this.commandLineBox.Name = "commandLineBox";
            this.commandLineBox.Size = new System.Drawing.Size(196, 21);
            this.commandLineBox.TabIndex = 4;
            this.commandLineBox.TextChanged += new System.EventHandler(this.commandLineBox_TextChanged_1);
            this.commandLineBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandLineBox_KeyDown);
            // 
            // multiLineCmd
            // 
            this.multiLineCmd.BackColor = System.Drawing.SystemColors.Window;
            this.multiLineCmd.Location = new System.Drawing.Point(32, 38);
            this.multiLineCmd.Name = "multiLineCmd";
            this.multiLineCmd.Size = new System.Drawing.Size(446, 474);
            this.multiLineCmd.TabIndex = 5;
            this.multiLineCmd.Text = "";
            this.multiLineCmd.TextChanged += new System.EventHandler(this.multiLineCmd_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(391, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(1034, 542);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Location = new System.Drawing.Point(32, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 27);
            this.button3.TabIndex = 9;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Location = new System.Drawing.Point(89, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 27);
            this.button4.TabIndex = 10;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // execute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1153, 642);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.multiLineCmd);
            this.Controls.Add(this.commandLineBox);
            this.Controls.Add(this.drawBox);
            this.Name = "execute";
            this.Text = "Turtle Graphics";
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox drawBox;
        private System.Windows.Forms.TextBox commandLineBox;
        private System.Windows.Forms.RichTextBox multiLineCmd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

