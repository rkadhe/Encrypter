namespace EncrypterApp
{
    partial class EncrypterApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncrypterApp));
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EncryptMessage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DecryptMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.InstructionsPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.InstructionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.EncryptMessage);
            this.panel2.Location = new System.Drawing.Point(12, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 457);
            this.panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Garamond", 16F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox2.Location = new System.Drawing.Point(17, 358);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(464, 75);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(10, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type sentence to encrypt:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EncrypterApp.Properties.Resources.icons8_lock_48;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(187, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // EncryptMessage
            // 
            this.EncryptMessage.BackColor = System.Drawing.Color.Gold;
            this.EncryptMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EncryptMessage.Font = new System.Drawing.Font("Garamond", 16.125F);
            this.EncryptMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EncryptMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EncryptMessage.Location = new System.Drawing.Point(28, 20);
            this.EncryptMessage.Name = "EncryptMessage";
            this.EncryptMessage.Size = new System.Drawing.Size(453, 142);
            this.EncryptMessage.TabIndex = 0;
            this.EncryptMessage.Text = "Encrypt Message";
            this.EncryptMessage.UseVisualStyleBackColor = false;
            this.EncryptMessage.Click += new System.EventHandler(this.EncryptMessage_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.DecryptMessage);
            this.panel3.Location = new System.Drawing.Point(516, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 457);
            this.panel3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Garamond", 16F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.Location = new System.Drawing.Point(15, 358);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(464, 75);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(16, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type code to decrypt:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EncrypterApp.Properties.Resources.icons8_padlock_48;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(195, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // DecryptMessage
            // 
            this.DecryptMessage.BackColor = System.Drawing.Color.Gold;
            this.DecryptMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DecryptMessage.Font = new System.Drawing.Font("Garamond", 16.125F);
            this.DecryptMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DecryptMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DecryptMessage.Location = new System.Drawing.Point(24, 20);
            this.DecryptMessage.Name = "DecryptMessage";
            this.DecryptMessage.Size = new System.Drawing.Size(450, 142);
            this.DecryptMessage.TabIndex = 2;
            this.DecryptMessage.Text = "Decrypt Message";
            this.DecryptMessage.UseVisualStyleBackColor = false;
            this.DecryptMessage.Click += new System.EventHandler(this.DecryptMessage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.125F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(424, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Encrypter ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Garamond", 16F);
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(35, 672);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(459, 104);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Garamond", 16F);
            this.richTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.richTextBox2.Location = new System.Drawing.Point(531, 672);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(455, 104);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.clearAllFieldsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(12, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(283, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(92, 36);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // clearAllFieldsToolStripMenuItem
            // 
            this.clearAllFieldsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.clearAllFieldsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearAllFieldsToolStripMenuItem.Name = "clearAllFieldsToolStripMenuItem";
            this.clearAllFieldsToolStripMenuItem.Size = new System.Drawing.Size(183, 36);
            this.clearAllFieldsToolStripMenuItem.Text = "Clear All Fields";
            this.clearAllFieldsToolStripMenuItem.Click += new System.EventHandler(this.clearAllFieldsToolStripMenuItem_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Exit.Location = new System.Drawing.Point(954, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(58, 69);
            this.Exit.TabIndex = 1;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.White;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Garamond", 16.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.Color.Black;
            this.richTextBox3.Location = new System.Drawing.Point(29, 616);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(387, 50);
            this.richTextBox3.TabIndex = 15;
            this.richTextBox3.Text = "Encrypted message is:";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.White;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Garamond", 16.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.ForeColor = System.Drawing.Color.Black;
            this.richTextBox4.Location = new System.Drawing.Point(531, 616);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(384, 50);
            this.richTextBox4.TabIndex = 16;
            this.richTextBox4.Text = "Decrypted message is:";
            // 
            // InstructionsPanel
            // 
            this.InstructionsPanel.Controls.Add(this.pictureBox4);
            this.InstructionsPanel.Controls.Add(this.pictureBox3);
            this.InstructionsPanel.Controls.Add(this.label7);
            this.InstructionsPanel.Controls.Add(this.label8);
            this.InstructionsPanel.Controls.Add(this.label6);
            this.InstructionsPanel.Controls.Add(this.label5);
            this.InstructionsPanel.Controls.Add(this.Start);
            this.InstructionsPanel.Controls.Add(this.label4);
            this.InstructionsPanel.Controls.Add(this.button1);
            this.InstructionsPanel.Location = new System.Drawing.Point(3, 12);
            this.InstructionsPanel.Name = "InstructionsPanel";
            this.InstructionsPanel.Size = new System.Drawing.Size(1023, 780);
            this.InstructionsPanel.TabIndex = 17;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::EncrypterApp.Properties.Resources.icons8_padlock_48;
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(771, 625);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(86, 87);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EncrypterApp.Properties.Resources.icons8_lock_48;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(87, 625);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Garamond", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(52, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(967, 157);
            this.label7.TabIndex = 10;
            this.label7.Text = "Type a sentence to encrypt.\r\n\r\nClick Encrypt Message button to get a code.\r\n\r\n";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Garamond", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(52, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(967, 151);
            this.label8.TabIndex = 9;
            this.label8.Text = "Type a code to decrypt.\r\n\r\nClick Decrypt Message button to get back the message.\r" +
    "\n\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(54, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 48);
            this.label6.TabIndex = 8;
            this.label6.Text = "Encrypt Message:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(52, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 48);
            this.label5.TabIndex = 7;
            this.label5.Text = "Decrypt Message:";
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.BackColor = System.Drawing.Color.Gold;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Garamond", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Start.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Start.Location = new System.Drawing.Point(370, 625);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(258, 77);
            this.Start.TabIndex = 5;
            this.Start.Text = "Lets Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Instructions";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(954, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 69);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EncrypterApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 788);
            this.Controls.Add(this.InstructionsPanel);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EncrypterApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.InstructionsPanel.ResumeLayout(false);
            this.InstructionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EncryptMessage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button DecryptMessage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearAllFieldsToolStripMenuItem;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel InstructionsPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

