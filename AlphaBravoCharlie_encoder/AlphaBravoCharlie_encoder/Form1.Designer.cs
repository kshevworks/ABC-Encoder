namespace AlphaBravoCharlie_encoder
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainRTextBox = new System.Windows.Forms.RichTextBox();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.SpeedLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTxtFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TextSpeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VolumeTrk = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.glitchCB = new System.Windows.Forms.CheckBox();
            this.IntervalBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrk)).BeginInit();
            this.SuspendLayout();
            // 
            // MainRTextBox
            // 
            this.MainRTextBox.Location = new System.Drawing.Point(12, 78);
            this.MainRTextBox.Name = "MainRTextBox";
            this.MainRTextBox.Size = new System.Drawing.Size(592, 336);
            this.MainRTextBox.TabIndex = 0;
            this.MainRTextBox.Text = "";
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(514, 27);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(90, 23);
            this.EncodeButton.TabIndex = 1;
            this.EncodeButton.Text = "Кодировать!";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // SpeedLbl
            // 
            this.SpeedLbl.Location = new System.Drawing.Point(12, 59);
            this.SpeedLbl.Name = "SpeedLbl";
            this.SpeedLbl.Size = new System.Drawing.Size(121, 17);
            this.SpeedLbl.TabIndex = 2;
            this.SpeedLbl.Text = "Пауза между буквами";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.AboutMenuButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTxtFile,
            this.toolStripMenuItem1,
            this.Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileToolStripMenuItem.Text = "Меню";
            // 
            // OpenTxtFile
            // 
            this.OpenTxtFile.Name = "OpenTxtFile";
            this.OpenTxtFile.Size = new System.Drawing.Size(209, 22);
            this.OpenTxtFile.Text = "Открыть текстовый файл";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(206, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(209, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AboutMenuButton
            // 
            this.AboutMenuButton.Name = "AboutMenuButton";
            this.AboutMenuButton.Size = new System.Drawing.Size(92, 20);
            this.AboutMenuButton.Text = "О программе";
            // 
            // TextSpeed
            // 
            this.TextSpeed.Location = new System.Drawing.Point(49, 30);
            this.TextSpeed.Name = "TextSpeed";
            this.TextSpeed.Size = new System.Drawing.Size(40, 20);
            this.TextSpeed.TabIndex = 4;
            this.TextSpeed.Text = "200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ms";
            // 
            // VolumeTrk
            // 
            this.VolumeTrk.Location = new System.Drawing.Point(139, 27);
            this.VolumeTrk.Maximum = 100;
            this.VolumeTrk.Name = "VolumeTrk";
            this.VolumeTrk.Size = new System.Drawing.Size(161, 45);
            this.VolumeTrk.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Громкость помех";
            // 
            // glitchCB
            // 
            this.glitchCB.AutoSize = true;
            this.glitchCB.Location = new System.Drawing.Point(306, 29);
            this.glitchCB.Name = "glitchCB";
            this.glitchCB.Size = new System.Drawing.Size(116, 17);
            this.glitchCB.TabIndex = 8;
            this.glitchCB.Text = "Включить щелчки";
            this.glitchCB.UseVisualStyleBackColor = true;
            this.glitchCB.CheckedChanged += new System.EventHandler(this.glitchCB_CheckedChanged);
            // 
            // IntervalBox
            // 
            this.IntervalBox.Enabled = false;
            this.IntervalBox.Location = new System.Drawing.Point(369, 50);
            this.IntervalBox.Name = "IntervalBox";
            this.IntervalBox.Size = new System.Drawing.Size(29, 20);
            this.IntervalBox.TabIndex = 9;
            this.IntervalBox.Text = "2000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Период:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 426);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IntervalBox);
            this.Controls.Add(this.glitchCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VolumeTrk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextSpeed);
            this.Controls.Add(this.SpeedLbl);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.MainRTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "AlphaBravoCharlie Encoder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MainRTextBox;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Label SpeedLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenTxtFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuButton;
        private System.Windows.Forms.TextBox TextSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar VolumeTrk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox glitchCB;
        private System.Windows.Forms.TextBox IntervalBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

