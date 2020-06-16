namespace Hayday_Seller
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radMinAmount = new System.Windows.Forms.RadioButton();
            this.radMinPrice = new System.Windows.Forms.RadioButton();
            this.radMaxAmount = new System.Windows.Forms.RadioButton();
            this.radMaxPrice = new System.Windows.Forms.RadioButton();
            this.radMidPrice = new System.Windows.Forms.RadioButton();
            this.BotWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbAutoSell = new System.Windows.Forms.CheckBox();
            this.tmHotkey = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radMinAmount
            // 
            this.radMinAmount.AutoSize = true;
            this.radMinAmount.Location = new System.Drawing.Point(12, 12);
            this.radMinAmount.Name = "radMinAmount";
            this.radMinAmount.Size = new System.Drawing.Size(93, 19);
            this.radMinAmount.TabIndex = 0;
            this.radMinAmount.Text = "Min Amount";
            this.radMinAmount.UseVisualStyleBackColor = true;
            // 
            // radMinPrice
            // 
            this.radMinPrice.AutoSize = true;
            this.radMinPrice.Location = new System.Drawing.Point(12, 6);
            this.radMinPrice.Name = "radMinPrice";
            this.radMinPrice.Size = new System.Drawing.Size(75, 19);
            this.radMinPrice.TabIndex = 1;
            this.radMinPrice.Text = "Min Price";
            this.radMinPrice.UseVisualStyleBackColor = true;
            // 
            // radMaxAmount
            // 
            this.radMaxAmount.AutoSize = true;
            this.radMaxAmount.Checked = true;
            this.radMaxAmount.Location = new System.Drawing.Point(111, 12);
            this.radMaxAmount.Name = "radMaxAmount";
            this.radMaxAmount.Size = new System.Drawing.Size(95, 19);
            this.radMaxAmount.TabIndex = 2;
            this.radMaxAmount.TabStop = true;
            this.radMaxAmount.Text = "Max Amount";
            this.radMaxAmount.UseVisualStyleBackColor = true;
            // 
            // radMaxPrice
            // 
            this.radMaxPrice.AutoSize = true;
            this.radMaxPrice.Checked = true;
            this.radMaxPrice.Location = new System.Drawing.Point(174, 6);
            this.radMaxPrice.Name = "radMaxPrice";
            this.radMaxPrice.Size = new System.Drawing.Size(77, 19);
            this.radMaxPrice.TabIndex = 3;
            this.radMaxPrice.TabStop = true;
            this.radMaxPrice.Text = "Max Price";
            this.radMaxPrice.UseVisualStyleBackColor = true;
            // 
            // radMidPrice
            // 
            this.radMidPrice.AutoSize = true;
            this.radMidPrice.Location = new System.Drawing.Point(93, 6);
            this.radMidPrice.Name = "radMidPrice";
            this.radMidPrice.Size = new System.Drawing.Size(75, 19);
            this.radMidPrice.TabIndex = 3;
            this.radMidPrice.Text = "Mid Price";
            this.radMidPrice.UseVisualStyleBackColor = true;
            // 
            // BotWorker
            // 
            this.BotWorker.WorkerReportsProgress = true;
            this.BotWorker.WorkerSupportsCancellation = true;
            this.BotWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BotWorker_DoWork);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radMinAmount);
            this.panel1.Controls.Add(this.radMaxAmount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 35);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbAutoSell);
            this.panel2.Controls.Add(this.radMidPrice);
            this.panel2.Controls.Add(this.radMinPrice);
            this.panel2.Controls.Add(this.radMaxPrice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 61);
            this.panel2.TabIndex = 5;
            // 
            // cbAutoSell
            // 
            this.cbAutoSell.AutoSize = true;
            this.cbAutoSell.Location = new System.Drawing.Point(93, 31);
            this.cbAutoSell.Name = "cbAutoSell";
            this.cbAutoSell.Size = new System.Drawing.Size(73, 19);
            this.cbAutoSell.TabIndex = 4;
            this.cbAutoSell.Text = "Auto Sell";
            this.cbAutoSell.UseVisualStyleBackColor = true;
            // 
            // tmHotkey
            // 
            this.tmHotkey.Enabled = true;
            this.tmHotkey.Interval = 10;
            this.tmHotkey.Tick += new System.EventHandler(this.tmHotkey_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 96);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(277, 111);
            this.Name = "FrmMain";
            this.Text = "Hayday Seller";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radMinAmount;
        private System.Windows.Forms.RadioButton radMinPrice;
        private System.Windows.Forms.RadioButton radMaxAmount;
        private System.Windows.Forms.RadioButton radMaxPrice;
        private System.Windows.Forms.RadioButton radMidPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer tmHotkey;
        private System.ComponentModel.BackgroundWorker BotWorker;
        private System.Windows.Forms.CheckBox cbAutoSell;
    }
}

