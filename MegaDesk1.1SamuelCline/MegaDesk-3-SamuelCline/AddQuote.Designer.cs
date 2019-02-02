namespace MegaDesk_3_SamuelCline
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.depthBox = new System.Windows.Forms.NumericUpDown();
            this.widthBox = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.shippingBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.drawerBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.outputBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelBtn.Location = new System.Drawing.Point(6, 282);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(135, 41);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okBtn.Location = new System.Drawing.Point(147, 282);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(136, 41);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "Save";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desk Width";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Desk Depth";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.drawerBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.depthBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.widthBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.okBtn, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cancelBtn, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.nameBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.shippingBox, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(289, 329);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // depthBox
            // 
            this.depthBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depthBox.Location = new System.Drawing.Point(6, 52);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(135, 20);
            this.depthBox.TabIndex = 7;
            this.depthBox.Validating += new System.ComponentModel.CancelEventHandler(this.depthBox_Validating);
            // 
            // widthBox
            // 
            this.widthBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.widthBox.Location = new System.Drawing.Point(6, 6);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(135, 20);
            this.widthBox.TabIndex = 6;
            this.widthBox.Validating += new System.ComponentModel.CancelEventHandler(this.widthBox_Validating);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.outputBox1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(591, 335);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // materialBox
            // 
            this.materialBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialBox.FormattingEnabled = true;
            this.materialBox.Location = new System.Drawing.Point(6, 98);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(135, 21);
            this.materialBox.TabIndex = 8;
            this.materialBox.SelectedIndexChanged += new System.EventHandler(this.materialBox1_SelectedIndexChanged);
            // 
            // nameBox
            // 
            this.nameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameBox.Location = new System.Drawing.Point(6, 144);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(135, 20);
            this.nameBox.TabIndex = 10;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "Material";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 46);
            this.label4.TabIndex = 10;
            this.label4.Text = "Customer Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // shippingBox
            // 
            this.shippingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shippingBox.FormattingEnabled = true;
            this.shippingBox.Items.AddRange(new object[] {
            "14 Days (Standard)",
            "3 Days",
            "5 Days",
            "7 Days"});
            this.shippingBox.Location = new System.Drawing.Point(6, 190);
            this.shippingBox.Name = "shippingBox";
            this.shippingBox.Size = new System.Drawing.Size(135, 21);
            this.shippingBox.TabIndex = 11;
            this.shippingBox.SelectedIndexChanged += new System.EventHandler(this.shippingBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 46);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rush Order (Standard 14 Days)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // drawerBox
            // 
            this.drawerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawerBox.Location = new System.Drawing.Point(6, 236);
            this.drawerBox.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawerBox.Name = "drawerBox";
            this.drawerBox.Size = new System.Drawing.Size(135, 20);
            this.drawerBox.TabIndex = 13;
            this.drawerBox.ValueChanged += new System.EventHandler(this.drawerBox_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 46);
            this.label6.TabIndex = 14;
            this.label6.Text = "Number of Drawers";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputBox1
            // 
            this.outputBox1.Location = new System.Drawing.Point(298, 3);
            this.outputBox1.Multiline = true;
            this.outputBox1.Name = "outputBox1";
            this.outputBox1.Size = new System.Drawing.Size(169, 105);
            this.outputBox1.TabIndex = 7;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(591, 335);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown depthBox;
        private System.Windows.Forms.NumericUpDown widthBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox materialBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox shippingBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown drawerBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox outputBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}