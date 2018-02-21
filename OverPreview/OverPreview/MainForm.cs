using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverPreview
{
    public partial class MainForm : Form
    {
		int _page = 0;
		Font _font = new Font("Segoe UI", 14);


		public MainForm()
        {
            InitializeComponent();

            InitializePrintPreviewDialog();
        }

        internal PrintPreviewDialog PrintPreviewDialog1;

        // Declare a PrintDocument object named document.
        private System.Drawing.Printing.PrintDocument document =
            new System.Drawing.Printing.PrintDocument();

        // Initalize the dialog.
        private void InitializePrintPreviewDialog()
        {

            // Create a new PrintPreviewDialog using constructor.
            this.PrintPreviewDialog1 = new PrintPreviewDialog();

            //Set the size, location, and name.
            this.PrintPreviewDialog1.ClientSize =
                new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog1.Location =
                new System.Drawing.Point(29, 29);
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";

            // Associate the event-handling method with the 
            // document's PrintPage event.
            this.document.PrintPage +=
                new System.Drawing.Printing.PrintPageEventHandler
                (document_PrintPage);

            // Set the minimum size the dialog can be resized to.
            this.PrintPreviewDialog1.MinimumSize =
                new System.Drawing.Size(375, 250);

            // Set the UseAntiAlias property to true, which will allow the 
            // operating system to smooth fonts.
            this.PrintPreviewDialog1.UseAntiAlias = true;
        }

        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Insert code to render the page here.
            // This code will be called when the PrintPreviewDialog.Show 
            // method is called.

            // The following code will render a simple
            // message on the document in the dialog.
            string text = "In document_PrintPage method.";
            System.Drawing.Font printFont =
                new System.Drawing.Font("Arial", 35,
                System.Drawing.FontStyle.Regular);

            e.Graphics.DrawString(text, printFont,
                System.Drawing.Brushes.Black, 0, 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            document.DocumentName = "c:\\temp\\1.rtf";

            // Set the PrintPreviewDialog.Document property to
            // the PrintDocument object selected by the user.
            PrintPreviewDialog1.Document = document;

            // Call the ShowDialog method. This will trigger the document's
            //  PrintPage event.
            PrintPreviewDialog1.ShowDialog();
        }

		private void btCoolPre_Click(object sender, EventArgs e)
		{
			using (var dlg = new CoolPrintPreviewDialog())
			{
				dlg.Document = this.printDocument1;
				dlg.ShowDialog(this);
			}

		}

		private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{
			_page = 0;
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Image img = Image.FromFile("1q.bmp");
			Point loc = new Point(0, 0);
			e.Graphics.DrawImage(img, loc);
			e.HasMorePages = false;

			/*/ fill page with text
			Rectangle rc = e.MarginBounds;
			rc.Height = _font.Height + 10;
			for (int i = 0; ; i++)
			{
				var text = string.Format("line {0} on page {1}", i + 1, _page + 1);
				e.Graphics.DrawString(text, _font, Brushes.Black, rc);
				rc.Y += rc.Height;
				if (rc.Bottom > e.MarginBounds.Bottom)
				{
					break;
				}
			}

			// move on to next page
			_page++;
			e.HasMorePages = _page < 2; */
		}
	}
}
