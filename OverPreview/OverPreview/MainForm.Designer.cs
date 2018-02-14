namespace OverPreview
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
			this.btStandrtPre = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.btCoolPre = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btStandrtPre
			// 
			this.btStandrtPre.Location = new System.Drawing.Point(12, 72);
			this.btStandrtPre.Name = "btStandrtPre";
			this.btStandrtPre.Size = new System.Drawing.Size(194, 54);
			this.btStandrtPre.TabIndex = 0;
			this.btStandrtPre.Text = "Standart Preview";
			this.btStandrtPre.UseVisualStyleBackColor = true;
			this.btStandrtPre.Click += new System.EventHandler(this.button1_Click);
			// 
			// printDocument1
			// 
			this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// btCoolPre
			// 
			this.btCoolPre.Location = new System.Drawing.Point(12, 12);
			this.btCoolPre.Name = "btCoolPre";
			this.btCoolPre.Size = new System.Drawing.Size(194, 54);
			this.btCoolPre.TabIndex = 1;
			this.btCoolPre.Text = "Cool Preview";
			this.btCoolPre.UseVisualStyleBackColor = true;
			this.btCoolPre.Click += new System.EventHandler(this.btCoolPre_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 522);
			this.Controls.Add(this.btCoolPre);
			this.Controls.Add(this.btStandrtPre);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStandrtPre;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.Button btCoolPre;
	}
}

