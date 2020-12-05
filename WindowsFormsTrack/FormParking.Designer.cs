namespace WindowsFormsTrack
{
    partial class FormParking
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
			this.pictureBoxParking = new System.Windows.Forms.PictureBox();
			this.buttonSetBenzovoz = new System.Windows.Forms.Button();
			this.buttonSetTrack = new System.Windows.Forms.Button();
			this.groupBoxParking = new System.Windows.Forms.GroupBox();
			this.buttonPickUpTrack = new System.Windows.Forms.Button();
			this.maskedTextBoxParking = new System.Windows.Forms.MaskedTextBox();
			this.labelParking = new System.Windows.Forms.Label();
			this.labelParkings = new System.Windows.Forms.Label();
			this.buttonAddParking = new System.Windows.Forms.Button();
			this.listBoxParking = new System.Windows.Forms.ListBox();
			this.buttonDelParking = new System.Windows.Forms.Button();
			this.textBoxPlace = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
			this.groupBoxParking.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxParking
			// 
			this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxParking.Name = "pictureBoxParking";
			this.pictureBoxParking.Size = new System.Drawing.Size(884, 461);
			this.pictureBoxParking.TabIndex = 0;
			this.pictureBoxParking.TabStop = false;
			// 
			// buttonSetBenzovoz
			// 
			this.buttonSetBenzovoz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSetBenzovoz.Location = new System.Drawing.Point(891, 64);
			this.buttonSetBenzovoz.Name = "buttonSetBenzovoz";
			this.buttonSetBenzovoz.Size = new System.Drawing.Size(105, 57);
			this.buttonSetBenzovoz.TabIndex = 1;
			this.buttonSetBenzovoz.Text = "Припарковать бензовоз";
			this.buttonSetBenzovoz.UseVisualStyleBackColor = true;
			this.buttonSetBenzovoz.Click += new System.EventHandler(this.buttonSetBenzovoz_Click);
			// 
			// buttonSetTrack
			// 
			this.buttonSetTrack.Location = new System.Drawing.Point(891, 12);
			this.buttonSetTrack.Name = "buttonSetTrack";
			this.buttonSetTrack.Size = new System.Drawing.Size(104, 43);
			this.buttonSetTrack.TabIndex = 2;
			this.buttonSetTrack.Text = "Припарковать грузовик";
			this.buttonSetTrack.UseVisualStyleBackColor = true;
			this.buttonSetTrack.Click += new System.EventHandler(this.buttonSetTrack_Click);
			// 
			// groupBoxParking
			// 
			this.groupBoxParking.Controls.Add(this.buttonPickUpTrack);
			this.groupBoxParking.Controls.Add(this.maskedTextBoxParking);
			this.groupBoxParking.Controls.Add(this.labelParking);
			this.groupBoxParking.Location = new System.Drawing.Point(893, 128);
			this.groupBoxParking.Name = "groupBoxParking";
			this.groupBoxParking.Size = new System.Drawing.Size(103, 124);
			this.groupBoxParking.TabIndex = 3;
			this.groupBoxParking.TabStop = false;
			this.groupBoxParking.Text = "Забрать грузовик";
			// 
			// buttonPickUpTrack
			// 
			this.buttonPickUpTrack.Location = new System.Drawing.Point(12, 63);
			this.buttonPickUpTrack.Name = "buttonPickUpTrack";
			this.buttonPickUpTrack.Size = new System.Drawing.Size(75, 28);
			this.buttonPickUpTrack.TabIndex = 2;
			this.buttonPickUpTrack.Text = "Забрать";
			this.buttonPickUpTrack.UseVisualStyleBackColor = true;
			this.buttonPickUpTrack.Click += new System.EventHandler(this.buttonPickUpTrack_Click);
			// 
			// maskedTextBoxParking
			// 
			this.maskedTextBoxParking.Location = new System.Drawing.Point(55, 32);
			this.maskedTextBoxParking.Name = "maskedTextBoxParking";
			this.maskedTextBoxParking.Size = new System.Drawing.Size(33, 20);
			this.maskedTextBoxParking.TabIndex = 1;
			// 
			// labelParking
			// 
			this.labelParking.AutoSize = true;
			this.labelParking.Location = new System.Drawing.Point(7, 35);
			this.labelParking.Name = "labelParking";
			this.labelParking.Size = new System.Drawing.Size(42, 13);
			this.labelParking.TabIndex = 0;
			this.labelParking.Text = "Место:";
			// 
			// labelParkings
			// 
			this.labelParkings.AutoSize = true;
			this.labelParkings.Location = new System.Drawing.Point(914, 263);
			this.labelParkings.Name = "labelParkings";
			this.labelParkings.Size = new System.Drawing.Size(57, 13);
			this.labelParkings.TabIndex = 4;
			this.labelParkings.Text = "Парковки";
			// 
			// buttonAddParking
			// 
			this.buttonAddParking.Location = new System.Drawing.Point(890, 306);
			this.buttonAddParking.Name = "buttonAddParking";
			this.buttonAddParking.Size = new System.Drawing.Size(106, 34);
			this.buttonAddParking.TabIndex = 6;
			this.buttonAddParking.Text = "Добавить парковку";
			this.buttonAddParking.UseVisualStyleBackColor = true;
			this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
			// 
			// listBoxParking
			// 
			this.listBoxParking.FormattingEnabled = true;
			this.listBoxParking.Location = new System.Drawing.Point(891, 347);
			this.listBoxParking.Name = "listBoxParking";
			this.listBoxParking.Size = new System.Drawing.Size(104, 69);
			this.listBoxParking.TabIndex = 7;
			this.listBoxParking.SelectedIndexChanged += new System.EventHandler(this.listBoxParking_SelectedIndexChanged);
			// 
			// buttonDelParking
			// 
			this.buttonDelParking.Location = new System.Drawing.Point(891, 422);
			this.buttonDelParking.Name = "buttonDelParking";
			this.buttonDelParking.Size = new System.Drawing.Size(102, 35);
			this.buttonDelParking.TabIndex = 8;
			this.buttonDelParking.Text = "Удалить парковку";
			this.buttonDelParking.UseVisualStyleBackColor = true;
			this.buttonDelParking.Click += new System.EventHandler(this.buttonDelParking_Click);
			// 
			// textBoxPlace
			// 
			this.textBoxPlace.Location = new System.Drawing.Point(891, 280);
			this.textBoxPlace.Name = "textBoxPlace";
			this.textBoxPlace.Size = new System.Drawing.Size(105, 20);
			this.textBoxPlace.TabIndex = 9;
			// 
			// FormParking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1005, 461);
			this.Controls.Add(this.textBoxPlace);
			this.Controls.Add(this.buttonDelParking);
			this.Controls.Add(this.listBoxParking);
			this.Controls.Add(this.buttonAddParking);
			this.Controls.Add(this.labelParkings);
			this.Controls.Add(this.groupBoxParking);
			this.Controls.Add(this.buttonSetTrack);
			this.Controls.Add(this.buttonSetBenzovoz);
			this.Controls.Add(this.pictureBoxParking);
			this.Name = "FormParking";
			this.Text = "FormHangar";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
			this.groupBoxParking.ResumeLayout(false);
			this.groupBoxParking.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetBenzovoz;
        private System.Windows.Forms.Button buttonSetTrack;
        private System.Windows.Forms.GroupBox groupBoxParking;
        private System.Windows.Forms.Button buttonPickUpTrack;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxParking;
        private System.Windows.Forms.Label labelParking;
        private System.Windows.Forms.Label labelParkings;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.ListBox listBoxParking;
        private System.Windows.Forms.Button buttonDelParking;
		private System.Windows.Forms.MaskedTextBox textBoxPlace;
	}
}