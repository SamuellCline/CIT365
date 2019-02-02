namespace MegaDesk_3_SamuelCline
{
    partial class MainMenu
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
            this.addQuoteBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addQuoteBtn
            // 
            this.addQuoteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addQuoteBtn.Location = new System.Drawing.Point(4, 4);
            this.addQuoteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addQuoteBtn.Name = "addQuoteBtn";
            this.addQuoteBtn.Size = new System.Drawing.Size(333, 158);
            this.addQuoteBtn.TabIndex = 0;
            this.addQuoteBtn.Text = "Add New Quote";
            this.addQuoteBtn.UseVisualStyleBackColor = true;
            this.addQuoteBtn.Click += new System.EventHandler(this.addQuoteBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewBtn.Location = new System.Drawing.Point(4, 170);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(333, 158);
            this.viewBtn.TabIndex = 1;
            this.viewBtn.Text = "View Quotes";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBtn.Location = new System.Drawing.Point(4, 336);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(333, 158);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search Quotes";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitBtn.Location = new System.Drawing.Point(4, 502);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(333, 159);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.9976F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0024F));
            this.tableLayoutPanel1.Controls.Add(this.addQuoteBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.exitBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.viewBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.searchBtn, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 665);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 665);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(860, 675);
            this.Name = "MainMenu";
            this.Text = "Mega Desk";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuoteBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

