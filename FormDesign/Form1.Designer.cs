namespace FormDesign
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.flpVariants = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlCheckbox = new System.Windows.Forms.Panel();
			this.cbVariant6 = new System.Windows.Forms.CheckBox();
			this.cbVariant5 = new System.Windows.Forms.CheckBox();
			this.cbVariant4 = new System.Windows.Forms.CheckBox();
			this.cbVariant3 = new System.Windows.Forms.CheckBox();
			this.cbVariant2 = new System.Windows.Forms.CheckBox();
			this.cbVariant1 = new System.Windows.Forms.CheckBox();
			this.pnlRadiobutton = new System.Windows.Forms.Panel();
			this.rbVariant6 = new System.Windows.Forms.RadioButton();
			this.rbVariant5 = new System.Windows.Forms.RadioButton();
			this.rbVariant4 = new System.Windows.Forms.RadioButton();
			this.rbVariant3 = new System.Windows.Forms.RadioButton();
			this.rbVariant2 = new System.Windows.Forms.RadioButton();
			this.rbVariant1 = new System.Windows.Forms.RadioButton();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
			this.pnImage = new System.Windows.Forms.PictureBox();
			this.rtbDescription = new System.Windows.Forms.RichTextBox();
			this.lblCaption = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.tableLayoutPanel2.SuspendLayout();
			this.flpVariants.SuspendLayout();
			this.pnlCheckbox.SuspendLayout();
			this.pnlRadiobutton.SuspendLayout();
			this.tlpInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pnImage)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
			this.tableLayoutPanel2.Controls.Add(this.flpVariants, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnNext, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnPrevious, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 262);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(752, 161);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// flpVariants
			// 
			this.flpVariants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.flpVariants.AutoSize = true;
			this.flpVariants.Controls.Add(this.pnlCheckbox);
			this.flpVariants.Controls.Add(this.pnlRadiobutton);
			this.flpVariants.Controls.Add(this.btnStart);
			this.flpVariants.Location = new System.Drawing.Point(280, 3);
			this.flpVariants.Name = "flpVariants";
			this.flpVariants.Size = new System.Drawing.Size(191, 155);
			this.flpVariants.TabIndex = 4;
			// 
			// pnlCheckbox
			// 
			this.pnlCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.pnlCheckbox.AutoSize = true;
			this.pnlCheckbox.Controls.Add(this.cbVariant6);
			this.pnlCheckbox.Controls.Add(this.cbVariant5);
			this.pnlCheckbox.Controls.Add(this.cbVariant4);
			this.pnlCheckbox.Controls.Add(this.cbVariant3);
			this.pnlCheckbox.Controls.Add(this.cbVariant2);
			this.pnlCheckbox.Controls.Add(this.cbVariant1);
			this.pnlCheckbox.Location = new System.Drawing.Point(3, 3);
			this.pnlCheckbox.Name = "pnlCheckbox";
			this.pnlCheckbox.Size = new System.Drawing.Size(51, 139);
			this.pnlCheckbox.TabIndex = 4;
			// 
			// cbVariant6
			// 
			this.cbVariant6.AutoSize = true;
			this.cbVariant6.Location = new System.Drawing.Point(4, 119);
			this.cbVariant6.Name = "cbVariant6";
			this.cbVariant6.Size = new System.Drawing.Size(44, 17);
			this.cbVariant6.TabIndex = 5;
			this.cbVariant6.Text = "cb6";
			this.cbVariant6.UseVisualStyleBackColor = true;
			// 
			// cbVariant5
			// 
			this.cbVariant5.AutoSize = true;
			this.cbVariant5.Location = new System.Drawing.Point(4, 97);
			this.cbVariant5.Name = "cbVariant5";
			this.cbVariant5.Size = new System.Drawing.Size(44, 17);
			this.cbVariant5.TabIndex = 4;
			this.cbVariant5.Text = "cb5";
			this.cbVariant5.UseVisualStyleBackColor = true;
			// 
			// cbVariant4
			// 
			this.cbVariant4.AutoSize = true;
			this.cbVariant4.Location = new System.Drawing.Point(4, 73);
			this.cbVariant4.Name = "cbVariant4";
			this.cbVariant4.Size = new System.Drawing.Size(44, 17);
			this.cbVariant4.TabIndex = 3;
			this.cbVariant4.Text = "cb4";
			this.cbVariant4.UseVisualStyleBackColor = true;
			// 
			// cbVariant3
			// 
			this.cbVariant3.AutoSize = true;
			this.cbVariant3.Location = new System.Drawing.Point(4, 50);
			this.cbVariant3.Name = "cbVariant3";
			this.cbVariant3.Size = new System.Drawing.Size(44, 17);
			this.cbVariant3.TabIndex = 2;
			this.cbVariant3.Text = "cb3";
			this.cbVariant3.UseVisualStyleBackColor = true;
			// 
			// cbVariant2
			// 
			this.cbVariant2.AutoSize = true;
			this.cbVariant2.Location = new System.Drawing.Point(4, 27);
			this.cbVariant2.Name = "cbVariant2";
			this.cbVariant2.Size = new System.Drawing.Size(44, 17);
			this.cbVariant2.TabIndex = 1;
			this.cbVariant2.Text = "cb2";
			this.cbVariant2.UseVisualStyleBackColor = true;
			// 
			// cbVariant1
			// 
			this.cbVariant1.AutoSize = true;
			this.cbVariant1.Location = new System.Drawing.Point(4, 4);
			this.cbVariant1.Name = "cbVariant1";
			this.cbVariant1.Size = new System.Drawing.Size(44, 17);
			this.cbVariant1.TabIndex = 0;
			this.cbVariant1.Text = "cb1";
			this.cbVariant1.UseVisualStyleBackColor = true;
			// 
			// pnlRadiobutton
			// 
			this.pnlRadiobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.pnlRadiobutton.AutoSize = true;
			this.pnlRadiobutton.Controls.Add(this.rbVariant6);
			this.pnlRadiobutton.Controls.Add(this.rbVariant5);
			this.pnlRadiobutton.Controls.Add(this.rbVariant4);
			this.pnlRadiobutton.Controls.Add(this.rbVariant3);
			this.pnlRadiobutton.Controls.Add(this.rbVariant2);
			this.pnlRadiobutton.Controls.Add(this.rbVariant1);
			this.pnlRadiobutton.Location = new System.Drawing.Point(60, 3);
			this.pnlRadiobutton.Name = "pnlRadiobutton";
			this.pnlRadiobutton.Size = new System.Drawing.Size(47, 139);
			this.pnlRadiobutton.TabIndex = 3;
			// 
			// rbVariant6
			// 
			this.rbVariant6.AutoSize = true;
			this.rbVariant6.Location = new System.Drawing.Point(3, 119);
			this.rbVariant6.Name = "rbVariant6";
			this.rbVariant6.Size = new System.Drawing.Size(40, 17);
			this.rbVariant6.TabIndex = 5;
			this.rbVariant6.Text = "rb6";
			this.rbVariant6.UseVisualStyleBackColor = true;
			// 
			// rbVariant5
			// 
			this.rbVariant5.AutoSize = true;
			this.rbVariant5.Location = new System.Drawing.Point(4, 96);
			this.rbVariant5.Name = "rbVariant5";
			this.rbVariant5.Size = new System.Drawing.Size(40, 17);
			this.rbVariant5.TabIndex = 4;
			this.rbVariant5.Text = "rb5";
			this.rbVariant5.UseVisualStyleBackColor = true;
			// 
			// rbVariant4
			// 
			this.rbVariant4.AutoSize = true;
			this.rbVariant4.Location = new System.Drawing.Point(4, 73);
			this.rbVariant4.Name = "rbVariant4";
			this.rbVariant4.Size = new System.Drawing.Size(40, 17);
			this.rbVariant4.TabIndex = 3;
			this.rbVariant4.Text = "rb4";
			this.rbVariant4.UseVisualStyleBackColor = true;
			// 
			// rbVariant3
			// 
			this.rbVariant3.AutoSize = true;
			this.rbVariant3.Location = new System.Drawing.Point(4, 50);
			this.rbVariant3.Name = "rbVariant3";
			this.rbVariant3.Size = new System.Drawing.Size(40, 17);
			this.rbVariant3.TabIndex = 2;
			this.rbVariant3.Text = "rb3";
			this.rbVariant3.UseVisualStyleBackColor = true;
			// 
			// rbVariant2
			// 
			this.rbVariant2.AutoSize = true;
			this.rbVariant2.Location = new System.Drawing.Point(4, 27);
			this.rbVariant2.Name = "rbVariant2";
			this.rbVariant2.Size = new System.Drawing.Size(40, 17);
			this.rbVariant2.TabIndex = 1;
			this.rbVariant2.Text = "rb2";
			this.rbVariant2.UseVisualStyleBackColor = true;
			// 
			// rbVariant1
			// 
			this.rbVariant1.AutoSize = true;
			this.rbVariant1.Location = new System.Drawing.Point(4, 4);
			this.rbVariant1.Name = "rbVariant1";
			this.rbVariant1.Size = new System.Drawing.Size(40, 17);
			this.rbVariant1.TabIndex = 0;
			this.rbVariant1.Text = "rb1";
			this.rbVariant1.UseVisualStyleBackColor = true;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(113, 3);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 44);
			this.btnStart.TabIndex = 5;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Visible = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnNext
			// 
			this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnNext.Location = new System.Drawing.Point(691, 3);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(58, 155);
			this.btnNext.TabIndex = 5;
			this.btnNext.Text = ">";
			this.btnNext.UseVisualStyleBackColor = true;
			// 
			// btnPrevious
			// 
			this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnPrevious.Enabled = false;
			this.btnPrevious.Location = new System.Drawing.Point(3, 3);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(58, 155);
			this.btnPrevious.TabIndex = 6;
			this.btnPrevious.Text = "<";
			this.btnPrevious.UseVisualStyleBackColor = true;
			// 
			// tlpInfo
			// 
			this.tlpInfo.ColumnCount = 2;
			this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpInfo.Controls.Add(this.pnImage, 0, 0);
			this.tlpInfo.Controls.Add(this.rtbDescription, 1, 0);
			this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpInfo.Location = new System.Drawing.Point(3, 35);
			this.tlpInfo.Name = "tlpInfo";
			this.tlpInfo.RowCount = 1;
			this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpInfo.Size = new System.Drawing.Size(752, 221);
			this.tlpInfo.TabIndex = 1;
			// 
			// pnImage
			// 
			this.pnImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnImage.Image = ((System.Drawing.Image)(resources.GetObject("pnImage.Image")));
			this.pnImage.Location = new System.Drawing.Point(6, 6);
			this.pnImage.Margin = new System.Windows.Forms.Padding(6);
			this.pnImage.Name = "pnImage";
			this.pnImage.Size = new System.Drawing.Size(364, 209);
			this.pnImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pnImage.TabIndex = 0;
			this.pnImage.TabStop = false;
			// 
			// rtbDescription
			// 
			this.rtbDescription.BackColor = System.Drawing.SystemColors.Window;
			this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbDescription.Location = new System.Drawing.Point(382, 6);
			this.rtbDescription.Margin = new System.Windows.Forms.Padding(6);
			this.rtbDescription.Name = "rtbDescription";
			this.rtbDescription.ReadOnly = true;
			this.rtbDescription.Size = new System.Drawing.Size(364, 209);
			this.rtbDescription.TabIndex = 1;
			this.rtbDescription.Text = resources.GetString("rtbDescription.Text");
			// 
			// lblCaption
			// 
			this.lblCaption.AutoSize = true;
			this.lblCaption.Font = new System.Drawing.Font("Helvetica", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblCaption.Location = new System.Drawing.Point(3, 8);
			this.lblCaption.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.lblCaption.Name = "lblCaption";
			this.lblCaption.Size = new System.Drawing.Size(284, 22);
			this.lblCaption.TabIndex = 0;
			this.lblCaption.Text = "Question 1: What your name?";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.lblCaption, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tlpInfo, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 167F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 458);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 458);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "Form1";
			this.Text = "ExamToaster";
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.flpVariants.ResumeLayout(false);
			this.flpVariants.PerformLayout();
			this.pnlCheckbox.ResumeLayout(false);
			this.pnlCheckbox.PerformLayout();
			this.pnlRadiobutton.ResumeLayout(false);
			this.pnlRadiobutton.PerformLayout();
			this.tlpInfo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pnImage)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.FlowLayoutPanel flpVariants;
		private System.Windows.Forms.Panel pnlCheckbox;
		private System.Windows.Forms.CheckBox cbVariant6;
		private System.Windows.Forms.CheckBox cbVariant5;
		private System.Windows.Forms.CheckBox cbVariant4;
		private System.Windows.Forms.CheckBox cbVariant3;
		private System.Windows.Forms.CheckBox cbVariant2;
		private System.Windows.Forms.CheckBox cbVariant1;
		private System.Windows.Forms.Panel pnlRadiobutton;
		private System.Windows.Forms.RadioButton rbVariant6;
		private System.Windows.Forms.RadioButton rbVariant5;
		private System.Windows.Forms.RadioButton rbVariant4;
		private System.Windows.Forms.RadioButton rbVariant3;
		private System.Windows.Forms.RadioButton rbVariant2;
		private System.Windows.Forms.RadioButton rbVariant1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TableLayoutPanel tlpInfo;
		private System.Windows.Forms.PictureBox pnImage;
		private System.Windows.Forms.RichTextBox rtbDescription;
		private System.Windows.Forms.Label lblCaption;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}

