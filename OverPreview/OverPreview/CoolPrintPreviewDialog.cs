﻿using System;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace OverPreview
{
	/// <summary>
	/// Represents a dialog containing a <see cref="CoolPrintPreviewControl"/> control
	/// used to preview and print <see cref="PrintDocument"/> objects.
	/// </summary>
	/// <remarks>
	/// This dialog is similar to the standard <see cref="PrintPreviewDialog"/>
	/// but provides additional options such printer and page setup buttons,
	/// a better UI based on the <see cref="ToolStrip"/> control, and built-in
	/// PDF export.
	/// </remarks>
	internal partial class CoolPrintPreviewDialog : Form
    {
        //--------------------------------------------------------------------
        #region ** fields

        PrintDocument _doc;

		#endregion

		//--------------------------------------------------------------------
		#region ** ctor

		/// <summary>
		/// Initializes a new instance of a <see cref="CoolPrintPreviewDialog"/>.
		/// </summary>
		public CoolPrintPreviewDialog() : this(null)
        {
        }
        /// <summary>
        /// Initializes a new instance of a <see cref="CoolPrintPreviewDialog"/>.
        /// </summary>
        /// <param name="parentForm">Parent form that defines the initial size for this dialog.</param>
        public CoolPrintPreviewDialog(Control parentForm)
        {
            InitializeComponent();
            if (parentForm != null)
            {
                Size = parentForm.Size;
            }
        }
        #endregion

        //--------------------------------------------------------------------
        #region ** object model

        /// <summary>
        /// Gets or sets the <see cref="PrintDocument"/> to preview.
        /// </summary>
        public PrintDocument Document
        {
            get { return _doc; }
            set
            {
                // unhook event handlers
                if (_doc != null)
                {
                    _doc.BeginPrint -= _doc_BeginPrint;
                    _doc.EndPrint -= _doc_EndPrint;
                }

                // save the value
                _doc = value;

                // hook up event handlers
                if (_doc != null)
                {
                    _doc.BeginPrint += _doc_BeginPrint;
                    _doc.EndPrint += _doc_EndPrint;
                }


                // don't assign document to preview until this form becomes visible
                if (Visible)
                {
                    _preview.Document = Document;
                }
            }
        }

		public PrinterSettings dlgPrinterSettings
		{
			get { return _doc.PrinterSettings; }
		}


		#endregion

		private void CoolPrintPreviewDialog_Load(object sender, EventArgs e)
		{
			var printers = PrinterSettings.InstalledPrinters;
			foreach (string item in printers)
				cbPrinters.Items.Add(item);

			var psizes = dlgPrinterSettings.PaperSizes;
			foreach (PaperSize item in psizes)
				cbPageSize.Items.Add(item.PaperName);
			PrinterSettings_Changed();

			numCopies.ValueChanged += Props_Changed;
			cbPrinters.SelectedIndexChanged += Props_Changed;
			cbRange.SelectedIndexChanged += Props_Changed;
			cbOrientation.SelectedIndexChanged += Props_Changed;
			cbPageSize.SelectedIndexChanged += Props_Changed;
		}

		//--------------------------------------------------------------------
		#region ** overloads

		/// <summary>
		/// Overridden to assign document to preview control only after the 
		/// initial activation.
		/// </summary>
		/// <param name="e"><see cref="EventArgs"/> that contains the event data.</param>
		protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            _preview.Document = Document;
        }
        /// <summary>
        /// Overridden to cancel any ongoing previews when closing form.
        /// </summary>
        /// <param name="e"><see cref="FormClosingEventArgs"/> that contains the event data.</param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (_preview.IsRendering && !e.Cancel)
            {
                _preview.Cancel();
            }
        }

		#endregion

		//--------------------------------------------------------------------
		#region ** main commands

		private void btPrint_Click(object sender, EventArgs e)
		{
			var ps = dlgPrinterSettings;
			ps.MinimumPage = ps.FromPage = 1;
			ps.MaximumPage = ps.ToPage = _preview.PageCount;

			// print selected page range
			_preview.Print();
		}

		void _btnPrint_Click(object sender, EventArgs e)
        {
            using (var dlg = new PrintDialog())
            {
                // configure dialog
                dlg.AllowSomePages = true;
                dlg.AllowSelection = true;
                dlg.UseEXDialog = true;
                dlg.Document = Document;

                // show allowed page range
                var ps = dlg.PrinterSettings;
                ps.MinimumPage = ps.FromPage = 1;
                ps.MaximumPage = ps.ToPage = _preview.PageCount;

                // show dialog
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    // print selected page range
                    _preview.Print();
                }
            }
        }

        void _btnPageSetup_Click(object sender, EventArgs e)
        {
            using (var dlg = new PageSetupDialog())
            {
                dlg.Document = Document;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
					PrinterSettings_Changed();
					// to show new page layout
					_preview.RefreshPreview();
				}
			}
        }

		private void linkPrinterProps_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			dlgPrinterSettings.PrinterName = cbPrinters.SelectedItem.ToString();
			EditPrinterSettings(dlgPrinterSettings);
		}

		private void Props_Changed(object sender, EventArgs e)
		{
			dlgPrinterSettings.Copies = (short)numCopies.Value;
			dlgPrinterSettings.PrinterName = cbPrinters.SelectedItem.ToString();
			dlgPrinterSettings.PrintRange = cbRange.SelectedIndex < 3 ? (PrintRange)cbRange.SelectedIndex : PrintRange.CurrentPage;
			dlgPrinterSettings.DefaultPageSettings.Landscape = cbOrientation.SelectedIndex == 1;
			Document.DefaultPageSettings.Landscape = cbOrientation.SelectedIndex == 1;
			Document.DefaultPageSettings.PaperSize = getPaperSize(cbPageSize.SelectedItem.ToString());
			//dlgPrinterSettings.DefaultPageSettings.PaperSize = getPaperSize(cbPageSize.SelectedItem.ToString());
			// to show new page layout
			_preview.RefreshPreview();
		}

		private PaperSize getPaperSize(string sizename)
		{
			PaperSize result = null;
			var etr = dlgPrinterSettings.PaperSizes.GetEnumerator();
			while (etr.MoveNext())
				if ((etr.Current as PaperSize).PaperName == sizename)
				{
					result = (PaperSize)etr.Current;
					break;
				}
			return result;
		}

		private void PrinterSettings_Changed()
		{
			numCopies.Value = dlgPrinterSettings.Copies;
			cbPrinters.SelectedIndex = cbPrinters.Items.IndexOf(dlgPrinterSettings.PrinterName);
			cbRange.SelectedIndex = (int)dlgPrinterSettings.PrintRange;
			cbOrientation.SelectedIndex = Document.DefaultPageSettings.Landscape ? 1 : 0;
			cbPageSize.SelectedIndex = cbPageSize.Items.IndexOf(Document.DefaultPageSettings.PaperSize.PaperName);
		}

		#endregion

		//--------------------------------------------------------------------
		#region ** zoom

		void _btnZoom_ButtonClick(object sender, EventArgs e)
        {
            _preview.ZoomMode = _preview.ZoomMode == ZoomMode.ActualSize
                ? ZoomMode.FullPage
                : ZoomMode.ActualSize;
        }
        void _btnZoom_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == _itemActualSize)
            {
                _preview.ZoomMode = ZoomMode.ActualSize;
            }
            else if (e.ClickedItem == _itemFullPage)
            {
                _preview.ZoomMode = ZoomMode.FullPage;
            }
            else if (e.ClickedItem == _itemPageWidth)
            {
                _preview.ZoomMode = ZoomMode.PageWidth;
            }
            else if (e.ClickedItem == _itemTwoPages)
            {
                _preview.ZoomMode = ZoomMode.TwoPages;
            }
            if (e.ClickedItem == _item10)
            {
                _preview.Zoom = .1;
            }
            else if (e.ClickedItem == _item100)
            {
                _preview.Zoom = 1;
            }
            else if (e.ClickedItem == _item150)
            {
                _preview.Zoom = 1.5;
            }
            else if (e.ClickedItem == _item200)
            {
                _preview.Zoom = 2;
            }
            else if (e.ClickedItem == _item25)
            {
                _preview.Zoom = .25;
            }
            else if (e.ClickedItem == _item50)
            {
                _preview.Zoom = .5;
            }
            else if (e.ClickedItem == _item500)
            {
                _preview.Zoom = 5;
            }
            else if (e.ClickedItem == _item75)
            {
                _preview.Zoom = .75;
            }
        }
        #endregion

        //--------------------------------------------------------------------
        #region ** page navigation

        void _btnFirst_Click(object sender, EventArgs e)
        {
            _preview.StartPage = 0;
        }
        void _btnPrev_Click(object sender, EventArgs e)
        {
            _preview.StartPage--;
        }
        void _btnNext_Click(object sender, EventArgs e)
        {
            _preview.StartPage++;
        }
        void _btnLast_Click(object sender, EventArgs e)
        {
            _preview.StartPage = _preview.PageCount - 1;
        }
        void _txtStartPage_Enter(object sender, EventArgs e)
        {
            _txtStartPage.SelectAll();
        }
        void _txtStartPage_Validating(object sender, CancelEventArgs e)
        {
            CommitPageNumber();
        }
        void _txtStartPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            var c = e.KeyChar;
            if (c == (char)13)
            {
                CommitPageNumber();
                e.Handled = true;
            }
            else if (c > ' ' && !char.IsDigit(c))
            {
                e.Handled = true;
            }
        }
        void CommitPageNumber()
        {
            int page;
            if (int.TryParse(_txtStartPage.Text, out page))
            {
                _preview.StartPage = page - 1;
            }
        }
        void _preview_StartPageChanged(object sender, EventArgs e)
        {
            var page = _preview.StartPage + 1;
            _txtStartPage.Text = page.ToString();
        }
        private void _preview_PageCountChanged(object sender, EventArgs e)
        {
            this.Update();
            Application.DoEvents();
            _lblPageCount.Text = string.Format("of {0}", _preview.PageCount);
        }

        #endregion

        //--------------------------------------------------------------------
        #region ** job control

        void _btnCancel_Click(object sender, EventArgs e)
        {
            if (_preview.IsRendering)
            {
                _preview.Cancel();
            }
            else
            {
                Close();
            }
        }
        void _doc_BeginPrint(object sender, PrintEventArgs e)
        {
            _btnCancel.Text = "&Cancel";
            _btnPrint.Enabled = _btnPageSetup.Enabled = false;
        }
        void _doc_EndPrint(object sender, PrintEventArgs e)
        {
            _btnCancel.Text = "&Close";
            _btnPrint.Enabled = _btnPageSetup.Enabled = true;
        }

		#endregion

		#region Printer settings

		[DllImport("kernel32.dll")]
		static extern IntPtr GlobalLock(IntPtr hMem);
		[DllImport("kernel32.dll")]
		static extern bool GlobalUnlock(IntPtr hMem);
		[DllImport("kernel32.dll")]
		static extern bool GlobalFree(IntPtr hMem);
		[DllImport("winspool.Drv", EntryPoint = "DocumentPropertiesW", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
		static extern int DocumentProperties(IntPtr hwnd, IntPtr hPrinter, [MarshalAs(UnmanagedType.LPWStr)] string pDeviceName, IntPtr pDevModeOutput, IntPtr pDevModeInput, int fMode);

		private const int DM_PROMPT = 4;
		private const int DM_OUT_BUFFER = 2;
		private const int DM_IN_BUFFER = 8;

		private DialogResult EditPrinterSettings(PrinterSettings printerSettings)
		{
			DialogResult myReturnValue = DialogResult.Cancel;
			IntPtr hDevMode = printerSettings.GetHdevmode(printerSettings.DefaultPageSettings);
			IntPtr pDevMode = GlobalLock(hDevMode);
			int sizeNeeded = DocumentProperties(this.Handle, IntPtr.Zero, printerSettings.PrinterName, IntPtr.Zero, pDevMode, 0);
			IntPtr devModeData = Marshal.AllocHGlobal(sizeNeeded);
			long userChoice = DocumentProperties(this.Handle, IntPtr.Zero, printerSettings.PrinterName, devModeData, pDevMode, DM_IN_BUFFER | DM_PROMPT | DM_OUT_BUFFER);
			long IDOK = (long)DialogResult.OK;
			if (userChoice == IDOK)
			{
				myReturnValue = DialogResult.OK;
				printerSettings.SetHdevmode(devModeData);
				printerSettings.DefaultPageSettings.SetHdevmode(devModeData);
			}
			GlobalUnlock(hDevMode);
			GlobalFree(hDevMode);
			Marshal.FreeHGlobal(devModeData);
			return myReturnValue;
		}

		#endregion
	}
}
