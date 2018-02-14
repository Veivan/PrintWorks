namespace OverPreview
{
	partial class CoolPrintPreviewDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoolPrintPreviewDialog));
			this.panel1 = new System.Windows.Forms.Panel();
			this.linkPageProps = new System.Windows.Forms.LinkLabel();
			this.cbOrientation = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbRange = new System.Windows.Forms.ComboBox();
			this.linkPrinterProps = new System.Windows.Forms.LinkLabel();
			this.cbPrinters = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btPrint = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this._toolStrip = new System.Windows.Forms.ToolStrip();
			this._btnPrint = new System.Windows.Forms.ToolStripButton();
			this._btnPageSetup = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this._btnZoom = new System.Windows.Forms.ToolStripSplitButton();
			this._itemActualSize = new System.Windows.Forms.ToolStripMenuItem();
			this._itemFullPage = new System.Windows.Forms.ToolStripMenuItem();
			this._itemPageWidth = new System.Windows.Forms.ToolStripMenuItem();
			this._itemTwoPages = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this._item500 = new System.Windows.Forms.ToolStripMenuItem();
			this._item200 = new System.Windows.Forms.ToolStripMenuItem();
			this._item150 = new System.Windows.Forms.ToolStripMenuItem();
			this._item100 = new System.Windows.Forms.ToolStripMenuItem();
			this._item75 = new System.Windows.Forms.ToolStripMenuItem();
			this._item50 = new System.Windows.Forms.ToolStripMenuItem();
			this._item25 = new System.Windows.Forms.ToolStripMenuItem();
			this._item10 = new System.Windows.Forms.ToolStripMenuItem();
			this._btnFirst = new System.Windows.Forms.ToolStripButton();
			this._btnPrev = new System.Windows.Forms.ToolStripButton();
			this._txtStartPage = new System.Windows.Forms.ToolStripTextBox();
			this._lblPageCount = new System.Windows.Forms.ToolStripLabel();
			this._btnNext = new System.Windows.Forms.ToolStripButton();
			this._btnLast = new System.Windows.Forms.ToolStripButton();
			this._separator = new System.Windows.Forms.ToolStripSeparator();
			this._btnCancel = new System.Windows.Forms.ToolStripButton();
			this._preview = new OverPreview.CoolPrintPreviewControl();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.panel2.SuspendLayout();
			this._toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.linkPageProps);
			this.panel1.Controls.Add(this.cbOrientation);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.cbRange);
			this.panel1.Controls.Add(this.linkPrinterProps);
			this.panel1.Controls.Add(this.cbPrinters);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btPrint);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(212, 687);
			this.panel1.TabIndex = 2;
			// 
			// linkPageProps
			// 
			this.linkPageProps.AutoSize = true;
			this.linkPageProps.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkPageProps.Location = new System.Drawing.Point(90, 256);
			this.linkPageProps.Name = "linkPageProps";
			this.linkPageProps.Size = new System.Drawing.Size(107, 13);
			this.linkPageProps.TabIndex = 9;
			this.linkPageProps.TabStop = true;
			this.linkPageProps.Text = "Свойства страницы";
			this.linkPageProps.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPageProps_LinkClicked);
			this.linkPageProps.Click += new System.EventHandler(this._btnPageSetup_Click);
			// 
			// cbOrientation
			// 
			this.cbOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOrientation.FormattingEnabled = true;
			this.cbOrientation.Items.AddRange(new object[] {
            "Книжная ориентация",
            "Альбомная ориентация"});
			this.cbOrientation.Location = new System.Drawing.Point(12, 223);
			this.cbOrientation.Name = "cbOrientation";
			this.cbOrientation.Size = new System.Drawing.Size(183, 21);
			this.cbOrientation.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Настройка";
			// 
			// cbRange
			// 
			this.cbRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRange.FormattingEnabled = true;
			this.cbRange.Items.AddRange(new object[] {
            "Напечатать все страницы"});
			this.cbRange.Location = new System.Drawing.Point(12, 196);
			this.cbRange.Name = "cbRange";
			this.cbRange.Size = new System.Drawing.Size(183, 21);
			this.cbRange.TabIndex = 6;
			// 
			// linkPrinterProps
			// 
			this.linkPrinterProps.AutoSize = true;
			this.linkPrinterProps.LinkColor = System.Drawing.SystemColors.ControlText;
			this.linkPrinterProps.Location = new System.Drawing.Point(90, 151);
			this.linkPrinterProps.Name = "linkPrinterProps";
			this.linkPrinterProps.Size = new System.Drawing.Size(105, 13);
			this.linkPrinterProps.TabIndex = 3;
			this.linkPrinterProps.TabStop = true;
			this.linkPrinterProps.Text = "Свойства принтера";
			this.linkPrinterProps.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrinterProps_LinkClicked);
			// 
			// cbPrinters
			// 
			this.cbPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPrinters.FormattingEnabled = true;
			this.cbPrinters.Location = new System.Drawing.Point(12, 127);
			this.cbPrinters.Name = "cbPrinters";
			this.cbPrinters.Size = new System.Drawing.Size(183, 21);
			this.cbPrinters.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Принтер";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(151, 39);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(95, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Копии:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(95, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Печать";
			// 
			// btPrint
			// 
			this.btPrint.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btPrint.Image = ((System.Drawing.Image)(resources.GetObject("btPrint.Image")));
			this.btPrint.Location = new System.Drawing.Point(12, 18);
			this.btPrint.Name = "btPrint";
			this.btPrint.Size = new System.Drawing.Size(65, 68);
			this.btPrint.TabIndex = 4;
			this.btPrint.Text = "Печать";
			this.btPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btPrint.UseVisualStyleBackColor = true;
			this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this._toolStrip);
			this.panel2.Controls.Add(this._preview);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(212, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(550, 687);
			this.panel2.TabIndex = 3;
			// 
			// _toolStrip
			// 
			this._toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
			this._toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._btnPrint,
            this._btnPageSetup,
            this.toolStripSeparator2,
            this._btnZoom,
            this._btnFirst,
            this._btnPrev,
            this._txtStartPage,
            this._lblPageCount,
            this._btnNext,
            this._btnLast,
            this._separator,
            this._btnCancel});
			this._toolStrip.Location = new System.Drawing.Point(0, 662);
			this._toolStrip.Name = "_toolStrip";
			this._toolStrip.Size = new System.Drawing.Size(550, 25);
			this._toolStrip.TabIndex = 3;
			this._toolStrip.Text = "toolStrip1";
			this._toolStrip.Click += new System.EventHandler(this._btnPrint_Click);
			// 
			// _btnPrint
			// 
			this._btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("_btnPrint.Image")));
			this._btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._btnPrint.Name = "_btnPrint";
			this._btnPrint.Size = new System.Drawing.Size(23, 22);
			this._btnPrint.Text = "Print Document";
			// 
			// _btnPageSetup
			// 
			this._btnPageSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._btnPageSetup.Image = ((System.Drawing.Image)(resources.GetObject("_btnPageSetup.Image")));
			this._btnPageSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._btnPageSetup.Name = "_btnPageSetup";
			this._btnPageSetup.Size = new System.Drawing.Size(23, 22);
			this._btnPageSetup.Text = "Page Setup";
			this._btnPageSetup.Visible = false;
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// _btnZoom
			// 
			this._btnZoom.AutoToolTip = false;
			this._btnZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._itemActualSize,
            this._itemFullPage,
            this._itemPageWidth,
            this._itemTwoPages,
            this.toolStripMenuItem1,
            this._item500,
            this._item200,
            this._item150,
            this._item100,
            this._item75,
            this._item50,
            this._item25,
            this._item10});
			this._btnZoom.Image = ((System.Drawing.Image)(resources.GetObject("_btnZoom.Image")));
			this._btnZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._btnZoom.Name = "_btnZoom";
			this._btnZoom.Size = new System.Drawing.Size(61, 22);
			this._btnZoom.Text = "&Зум";
			this._btnZoom.ButtonClick += new System.EventHandler(this._btnZoom_ButtonClick);
			this._btnZoom.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this._btnZoom_DropDownItemClicked);
			// 
			// _itemActualSize
			// 
			this._itemActualSize.Image = ((System.Drawing.Image)(resources.GetObject("_itemActualSize.Image")));
			this._itemActualSize.Name = "_itemActualSize";
			this._itemActualSize.Size = new System.Drawing.Size(195, 22);
			this._itemActualSize.Text = "Актуальный размер";
			// 
			// _itemFullPage
			// 
			this._itemFullPage.Image = ((System.Drawing.Image)(resources.GetObject("_itemFullPage.Image")));
			this._itemFullPage.Name = "_itemFullPage";
			this._itemFullPage.Size = new System.Drawing.Size(195, 22);
			this._itemFullPage.Text = "Страница полностью";
			// 
			// _itemPageWidth
			// 
			this._itemPageWidth.Image = ((System.Drawing.Image)(resources.GetObject("_itemPageWidth.Image")));
			this._itemPageWidth.Name = "_itemPageWidth";
			this._itemPageWidth.Size = new System.Drawing.Size(195, 22);
			this._itemPageWidth.Text = "По ширине страницы";
			// 
			// _itemTwoPages
			// 
			this._itemTwoPages.Image = ((System.Drawing.Image)(resources.GetObject("_itemTwoPages.Image")));
			this._itemTwoPages.Name = "_itemTwoPages";
			this._itemTwoPages.Size = new System.Drawing.Size(195, 22);
			this._itemTwoPages.Text = "Две страницы";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
			// 
			// _item500
			// 
			this._item500.Name = "_item500";
			this._item500.Size = new System.Drawing.Size(195, 22);
			this._item500.Text = "500%";
			// 
			// _item200
			// 
			this._item200.Name = "_item200";
			this._item200.Size = new System.Drawing.Size(195, 22);
			this._item200.Text = "200%";
			// 
			// _item150
			// 
			this._item150.Name = "_item150";
			this._item150.Size = new System.Drawing.Size(195, 22);
			this._item150.Text = "150%";
			// 
			// _item100
			// 
			this._item100.Name = "_item100";
			this._item100.Size = new System.Drawing.Size(195, 22);
			this._item100.Text = "100%";
			// 
			// _item75
			// 
			this._item75.Name = "_item75";
			this._item75.Size = new System.Drawing.Size(195, 22);
			this._item75.Text = "75%";
			// 
			// _item50
			// 
			this._item50.Name = "_item50";
			this._item50.Size = new System.Drawing.Size(195, 22);
			this._item50.Text = "50%";
			// 
			// _item25
			// 
			this._item25.Name = "_item25";
			this._item25.Size = new System.Drawing.Size(195, 22);
			this._item25.Text = "25%";
			// 
			// _item10
			// 
			this._item10.Name = "_item10";
			this._item10.Size = new System.Drawing.Size(195, 22);
			this._item10.Text = "10%";
			// 
			// _btnFirst
			// 
			this._btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("_btnFirst.Image")));
			this._btnFirst.ImageTransparentColor = System.Drawing.Color.Red;
			this._btnFirst.Name = "_btnFirst";
			this._btnFirst.Size = new System.Drawing.Size(23, 22);
			this._btnFirst.Text = "First Page";
			this._btnFirst.Click += new System.EventHandler(this._btnFirst_Click);
			// 
			// _btnPrev
			// 
			this._btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("_btnPrev.Image")));
			this._btnPrev.ImageTransparentColor = System.Drawing.Color.Red;
			this._btnPrev.Name = "_btnPrev";
			this._btnPrev.Size = new System.Drawing.Size(23, 22);
			this._btnPrev.Text = "Previous Page";
			this._btnPrev.Click += new System.EventHandler(this._btnPrev_Click);
			// 
			// _txtStartPage
			// 
			this._txtStartPage.AutoSize = false;
			this._txtStartPage.Name = "_txtStartPage";
			this._txtStartPage.Size = new System.Drawing.Size(32, 23);
			this._txtStartPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this._txtStartPage.Enter += new System.EventHandler(this._txtStartPage_Enter);
			this._txtStartPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtStartPage_KeyPress);
			this._txtStartPage.Validating += new System.ComponentModel.CancelEventHandler(this._txtStartPage_Validating);
			// 
			// _lblPageCount
			// 
			this._lblPageCount.Name = "_lblPageCount";
			this._lblPageCount.Size = new System.Drawing.Size(10, 22);
			this._lblPageCount.Text = " ";
			// 
			// _btnNext
			// 
			this._btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._btnNext.Image = ((System.Drawing.Image)(resources.GetObject("_btnNext.Image")));
			this._btnNext.ImageTransparentColor = System.Drawing.Color.Red;
			this._btnNext.Name = "_btnNext";
			this._btnNext.Size = new System.Drawing.Size(23, 22);
			this._btnNext.Text = "Next Page";
			this._btnNext.Click += new System.EventHandler(this._btnNext_Click);
			// 
			// _btnLast
			// 
			this._btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._btnLast.Image = ((System.Drawing.Image)(resources.GetObject("_btnLast.Image")));
			this._btnLast.ImageTransparentColor = System.Drawing.Color.Red;
			this._btnLast.Name = "_btnLast";
			this._btnLast.Size = new System.Drawing.Size(23, 22);
			this._btnLast.Text = "Last Page";
			this._btnLast.Click += new System.EventHandler(this._btnLast_Click);
			// 
			// _separator
			// 
			this._separator.Name = "_separator";
			this._separator.Size = new System.Drawing.Size(6, 25);
			this._separator.Visible = false;
			// 
			// _btnCancel
			// 
			this._btnCancel.AutoToolTip = false;
			this._btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("_btnCancel.Image")));
			this._btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(63, 22);
			this._btnCancel.Text = "Cancel";
			this._btnCancel.Visible = false;
			// 
			// _preview
			// 
			this._preview.AutoScroll = true;
			this._preview.Dock = System.Windows.Forms.DockStyle.Fill;
			this._preview.Document = null;
			this._preview.Location = new System.Drawing.Point(0, 0);
			this._preview.Name = "_preview";
			this._preview.Size = new System.Drawing.Size(550, 687);
			this._preview.TabIndex = 2;
			// 
			// CoolPrintPreviewDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(762, 687);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "CoolPrintPreviewDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Print Preview";
			this.Load += new System.EventHandler(this.CoolPrintPreviewDialog_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this._toolStrip.ResumeLayout(false);
			this._toolStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private CoolPrintPreviewControl _preview;
		private System.Windows.Forms.Button btPrint;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbPrinters;
		private System.Windows.Forms.LinkLabel linkPrinterProps;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbRange;
		private System.Windows.Forms.ComboBox cbOrientation;
		private System.Windows.Forms.LinkLabel linkPageProps;
		private System.Windows.Forms.ToolStrip _toolStrip;
		private System.Windows.Forms.ToolStripButton _btnPrint;
		private System.Windows.Forms.ToolStripButton _btnPageSetup;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSplitButton _btnZoom;
		private System.Windows.Forms.ToolStripMenuItem _itemActualSize;
		private System.Windows.Forms.ToolStripMenuItem _itemFullPage;
		private System.Windows.Forms.ToolStripMenuItem _itemPageWidth;
		private System.Windows.Forms.ToolStripMenuItem _itemTwoPages;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem _item500;
		private System.Windows.Forms.ToolStripMenuItem _item200;
		private System.Windows.Forms.ToolStripMenuItem _item150;
		private System.Windows.Forms.ToolStripMenuItem _item100;
		private System.Windows.Forms.ToolStripMenuItem _item75;
		private System.Windows.Forms.ToolStripMenuItem _item50;
		private System.Windows.Forms.ToolStripMenuItem _item25;
		private System.Windows.Forms.ToolStripMenuItem _item10;
		private System.Windows.Forms.ToolStripButton _btnFirst;
		private System.Windows.Forms.ToolStripButton _btnPrev;
		private System.Windows.Forms.ToolStripTextBox _txtStartPage;
		private System.Windows.Forms.ToolStripLabel _lblPageCount;
		private System.Windows.Forms.ToolStripButton _btnNext;
		private System.Windows.Forms.ToolStripButton _btnLast;
		private System.Windows.Forms.ToolStripSeparator _separator;
		private System.Windows.Forms.ToolStripButton _btnCancel;
	}
}