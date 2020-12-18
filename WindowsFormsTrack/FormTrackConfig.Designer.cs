namespace WindowsFormsTrack
{
    partial class FormTrackConfig
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
            this.groupBoxTrackType = new System.Windows.Forms.GroupBox();
            this.labelBenzovoz = new System.Windows.Forms.Label();
            this.labelTrack = new System.Windows.Forms.Label();
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.checkBoxDangerLight = new System.Windows.Forms.CheckBox();
            this.checkBoxCistern = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.groupColors = new System.Windows.Forms.GroupBox();
            this.panelFuchsia = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelTrack = new System.Windows.Forms.Panel();
            this.pictureBoxTrack = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxTrackType.SuspendLayout();
            this.groupBoxParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.groupColors.SuspendLayout();
            this.panelFuchsia.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panelYellow.SuspendLayout();
            this.panelTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTrackType
            // 
            this.groupBoxTrackType.Controls.Add(this.labelBenzovoz);
            this.groupBoxTrackType.Controls.Add(this.labelTrack);
            this.groupBoxTrackType.Location = new System.Drawing.Point(84, 31);
            this.groupBoxTrackType.Name = "groupBoxTrackType";
            this.groupBoxTrackType.Size = new System.Drawing.Size(114, 105);
            this.groupBoxTrackType.TabIndex = 0;
            this.groupBoxTrackType.TabStop = false;
            this.groupBoxTrackType.Text = "Тип грузовика";
            // 
            // labelBenzovoz
            // 
            this.labelBenzovoz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBenzovoz.Location = new System.Drawing.Point(6, 67);
            this.labelBenzovoz.Name = "labelBenzovoz";
            this.labelBenzovoz.Size = new System.Drawing.Size(100, 35);
            this.labelBenzovoz.TabIndex = 1;
            this.labelBenzovoz.Text = "Бензовоз";
            this.labelBenzovoz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelBenzovoz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBenzovoz_MouseDown);
            // 
            // labelTrack
            // 
            this.labelTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTrack.Location = new System.Drawing.Point(6, 16);
            this.labelTrack.Name = "labelTrack";
            this.labelTrack.Size = new System.Drawing.Size(100, 40);
            this.labelTrack.TabIndex = 0;
            this.labelTrack.Text = "Обычный грузовик";
            this.labelTrack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTrack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTrack_MouseDown);
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.checkBoxDangerLight);
            this.groupBoxParams.Controls.Add(this.checkBoxCistern);
            this.groupBoxParams.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParams.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParams.Controls.Add(this.labelWeight);
            this.groupBoxParams.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParams.Location = new System.Drawing.Point(90, 245);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(354, 159);
            this.groupBoxParams.TabIndex = 2;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Параметры";
            // 
            // checkBoxDangerLight
            // 
            this.checkBoxDangerLight.AutoSize = true;
            this.checkBoxDangerLight.Location = new System.Drawing.Point(199, 72);
            this.checkBoxDangerLight.Name = "checkBoxDangerLight";
            this.checkBoxDangerLight.Size = new System.Drawing.Size(84, 17);
            this.checkBoxDangerLight.TabIndex = 5;
            this.checkBoxDangerLight.Text = "DangerLight";
            this.checkBoxDangerLight.UseVisualStyleBackColor = true;
            // 
            // checkBoxCistern
            // 
            this.checkBoxCistern.AutoSize = true;
            this.checkBoxCistern.Location = new System.Drawing.Point(199, 33);
            this.checkBoxCistern.Name = "checkBoxCistern";
            this.checkBoxCistern.Size = new System.Drawing.Size(75, 17);
            this.checkBoxCistern.TabIndex = 4;
            this.checkBoxCistern.Text = "Цистерна";
            this.checkBoxCistern.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(26, 129);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(26, 60);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.Location = new System.Drawing.Point(23, 103);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(100, 23);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.Location = new System.Drawing.Point(23, 33);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(100, 23);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макс. скорость";
            // 
            // groupColors
            // 
            this.groupColors.Controls.Add(this.panelFuchsia);
            this.groupColors.Controls.Add(this.panelYellow);
            this.groupColors.Controls.Add(this.panelGreen);
            this.groupColors.Controls.Add(this.panelWhite);
            this.groupColors.Controls.Add(this.panelBlue);
            this.groupColors.Controls.Add(this.panelBlack);
            this.groupColors.Controls.Add(this.panelOrange);
            this.groupColors.Controls.Add(this.panelRed);
            this.groupColors.Controls.Add(this.labelDopColor);
            this.groupColors.Controls.Add(this.labelMainColor);
            this.groupColors.Location = new System.Drawing.Point(518, 31);
            this.groupColors.Name = "groupColors";
            this.groupColors.Size = new System.Drawing.Size(248, 170);
            this.groupColors.TabIndex = 4;
            this.groupColors.TabStop = false;
            this.groupColors.Text = "Цвета";
            // 
            // panelFuchsia
            // 
            this.panelFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.panelFuchsia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFuchsia.Controls.Add(this.panel11);
            this.panelFuchsia.Controls.Add(this.panel9);
            this.panelFuchsia.Controls.Add(this.panel10);
            this.panelFuchsia.Location = new System.Drawing.Point(6, 117);
            this.panelFuchsia.Name = "panelFuchsia";
            this.panelFuchsia.Size = new System.Drawing.Size(41, 37);
            this.panelFuchsia.TabIndex = 9;
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(-31, 86);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 100);
            this.panel11.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(174, 29);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 100);
            this.panel9.TabIndex = 6;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel5);
            this.panel10.Location = new System.Drawing.Point(-78, -45);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(41, 37);
            this.panel10.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(109, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(41, 37);
            this.panel5.TabIndex = 5;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Controls.Add(this.panel12);
            this.panelYellow.Location = new System.Drawing.Point(70, 117);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(41, 37);
            this.panelYellow.TabIndex = 10;
            // 
            // panel12
            // 
            this.panel12.Location = new System.Drawing.Point(171, 39);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 100);
            this.panel12.TabIndex = 8;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(129, 117);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(41, 37);
            this.panelGreen.TabIndex = 11;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(196, 117);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(41, 37);
            this.panelWhite.TabIndex = 12;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(129, 68);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(41, 37);
            this.panelBlue.TabIndex = 5;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(196, 68);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(41, 37);
            this.panelBlack.TabIndex = 6;
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(70, 68);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(41, 37);
            this.panelOrange.TabIndex = 4;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(6, 68);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(41, 37);
            this.panelRed.TabIndex = 3;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(166, 33);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(76, 23);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(6, 33);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(90, 23);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // panelTrack
            // 
            this.panelTrack.AllowDrop = true;
            this.panelTrack.Controls.Add(this.pictureBoxTrack);
            this.panelTrack.Location = new System.Drawing.Point(237, 36);
            this.panelTrack.Name = "panelTrack";
            this.panelTrack.Size = new System.Drawing.Size(207, 141);
            this.panelTrack.TabIndex = 5;
            this.panelTrack.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTrack_DragDrop);
            this.panelTrack.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTrack_DragEnter);
            // 
            // pictureBoxTrack
            // 
            this.pictureBoxTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTrack.Location = new System.Drawing.Point(27, 11);
            this.pictureBoxTrack.Name = "pictureBoxTrack";
            this.pictureBoxTrack.Size = new System.Drawing.Size(153, 112);
            this.pictureBoxTrack.TabIndex = 6;
            this.pictureBoxTrack.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(679, 245);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 35);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(680, 296);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 39);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormTrackConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelTrack);
            this.Controls.Add(this.groupColors);
            this.Controls.Add(this.groupBoxParams);
            this.Controls.Add(this.groupBoxTrackType);
            this.Name = "FormTrackConfig";
            this.Text = "FormTrackConfig";
            this.groupBoxTrackType.ResumeLayout(false);
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.groupColors.ResumeLayout(false);
            this.panelFuchsia.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panelYellow.ResumeLayout(false);
            this.panelTrack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTrackType;
        private System.Windows.Forms.Label labelBenzovoz;
        private System.Windows.Forms.Label labelTrack;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxDangerLight;
        private System.Windows.Forms.CheckBox checkBoxCistern;
        private System.Windows.Forms.GroupBox groupColors;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelTrack;
        private System.Windows.Forms.PictureBox pictureBoxTrack;
        private System.Windows.Forms.Panel panelFuchsia;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}