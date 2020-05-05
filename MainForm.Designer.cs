namespace TVavtomat
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOnOff = new System.Windows.Forms.Button();
            this.buttonMusic = new System.Windows.Forms.Button();
            this.buttonInternet = new System.Windows.Forms.Button();
            this.buttonTV = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.xOutput = new System.Windows.Forms.Label();
            this.yOutput = new System.Windows.Forms.Label();
            this.zOutput = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.z0 = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.12887F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.87113F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelButtons, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(776, 430);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 1;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Controls.Add(this.buttonOnOff, 0, 3);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonMusic, 0, 2);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonInternet, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonTV, 0, 0);
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(586, 3);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 4;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(186, 423);
            this.tableLayoutPanelButtons.TabIndex = 0;
            // 
            // buttonOnOff
            // 
            this.buttonOnOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOnOff.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonOnOff.Location = new System.Drawing.Point(3, 341);
            this.buttonOnOff.Name = "buttonOnOff";
            this.buttonOnOff.Size = new System.Drawing.Size(180, 60);
            this.buttonOnOff.TabIndex = 3;
            this.buttonOnOff.Text = "Вкл/Выкл";
            this.buttonOnOff.UseVisualStyleBackColor = false;
            this.buttonOnOff.Click += new System.EventHandler(this.ButtonOnOff_Click);
            // 
            // buttonMusic
            // 
            this.buttonMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMusic.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonMusic.Location = new System.Drawing.Point(3, 236);
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.Size = new System.Drawing.Size(180, 60);
            this.buttonMusic.TabIndex = 2;
            this.buttonMusic.Text = "Музыка";
            this.buttonMusic.UseVisualStyleBackColor = false;
            this.buttonMusic.Click += new System.EventHandler(this.ButtonMusic_Click);
            // 
            // buttonInternet
            // 
            this.buttonInternet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInternet.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonInternet.Location = new System.Drawing.Point(3, 130);
            this.buttonInternet.Name = "buttonInternet";
            this.buttonInternet.Size = new System.Drawing.Size(180, 60);
            this.buttonInternet.TabIndex = 1;
            this.buttonInternet.Text = "Интернет";
            this.buttonInternet.UseVisualStyleBackColor = false;
            this.buttonInternet.Click += new System.EventHandler(this.ButtonInternet_Click);
            // 
            // buttonTV
            // 
            this.buttonTV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTV.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonTV.Location = new System.Drawing.Point(3, 23);
            this.buttonTV.Name = "buttonTV";
            this.buttonTV.Size = new System.Drawing.Size(180, 60);
            this.buttonTV.TabIndex = 0;
            this.buttonTV.Text = "Телевидение";
            this.buttonTV.UseVisualStyleBackColor = false;
            this.buttonTV.Click += new System.EventHandler(this.ButtonTV_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.Location = new System.Drawing.Point(10, 15);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(562, 400);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(12, 449);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(22, 17);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "x :";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(12, 470);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(23, 17);
            this.labelZ.TabIndex = 2;
            this.labelZ.Text = "z :";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(12, 491);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(23, 17);
            this.labelY.TabIndex = 3;
            this.labelY.Text = "y :";
            // 
            // xOutput
            // 
            this.xOutput.AutoSize = true;
            this.xOutput.Location = new System.Drawing.Point(70, 449);
            this.xOutput.Name = "xOutput";
            this.xOutput.Size = new System.Drawing.Size(57, 17);
            this.xOutput.TabIndex = 4;
            this.xOutput.Text = "xOutput";
            // 
            // yOutput
            // 
            this.yOutput.AutoSize = true;
            this.yOutput.Location = new System.Drawing.Point(70, 491);
            this.yOutput.Name = "yOutput";
            this.yOutput.Size = new System.Drawing.Size(58, 17);
            this.yOutput.TabIndex = 5;
            this.yOutput.Text = "yOutput";
            // 
            // zOutput
            // 
            this.zOutput.AutoSize = true;
            this.zOutput.Location = new System.Drawing.Point(70, 470);
            this.zOutput.Name = "zOutput";
            this.zOutput.Size = new System.Drawing.Size(58, 17);
            this.zOutput.TabIndex = 6;
            this.zOutput.Text = "zOutput";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(713, 470);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 35);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // z0
            // 
            this.z0.AutoSize = true;
            this.z0.Location = new System.Drawing.Point(41, 470);
            this.z0.Name = "z0";
            this.z0.Size = new System.Drawing.Size(23, 17);
            this.z0.TabIndex = 8;
            this.z0.Text = "z0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.z0);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.zOutput);
            this.Controls.Add(this.yOutput);
            this.Controls.Add(this.xOutput);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "MainForm";
            this.Text = "Телевизор (Автомат Мили)";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button buttonInternet;
        private System.Windows.Forms.Button buttonTV;
        private System.Windows.Forms.Button buttonOnOff;
        private System.Windows.Forms.Button buttonMusic;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label xOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label yOutput;
        private System.Windows.Forms.Label zOutput;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label z0;
    }
}

