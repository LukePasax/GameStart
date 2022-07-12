
namespace GameStartApp
{
    partial class AddSaleOnline
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
            this.DateSaleOnline = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBSaleOnlineCodClient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBSaleOnlinePromotion = new System.Windows.Forms.ComboBox();
            this.CBSaleOnlineProdId = new System.Windows.Forms.ComboBox();
            this.TxtSaleOnlineProdN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSaleOnlineAddProd = new System.Windows.Forms.Button();
            this.GVSaleOnlineProduct = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSaleOnlineOk = new System.Windows.Forms.Button();
            this.BtnSaleOnlineCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CBSaleOnlineShipper = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GVSaleOnlineProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // DateSaleOnline
            // 
            this.DateSaleOnline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateSaleOnline.Location = new System.Drawing.Point(11, 120);
            this.DateSaleOnline.Margin = new System.Windows.Forms.Padding(2);
            this.DateSaleOnline.Name = "DateSaleOnline";
            this.DateSaleOnline.Size = new System.Drawing.Size(429, 35);
            this.DateSaleOnline.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 63);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add A Sale Online";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // CBSaleOnlineCodClient
            // 
            this.CBSaleOnlineCodClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBSaleOnlineCodClient.FormattingEnabled = true;
            this.CBSaleOnlineCodClient.Location = new System.Drawing.Point(11, 171);
            this.CBSaleOnlineCodClient.Margin = new System.Windows.Forms.Padding(2);
            this.CBSaleOnlineCodClient.Name = "CBSaleOnlineCodClient";
            this.CBSaleOnlineCodClient.Size = new System.Drawing.Size(429, 37);
            this.CBSaleOnlineCodClient.TabIndex = 6;
            this.CBSaleOnlineCodClient.SelectedIndexChanged += new System.EventHandler(this.CBSaleOnlineCodClient_Change);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cod Client";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Promotion";
            // 
            // CBSaleOnlinePromotion
            // 
            this.CBSaleOnlinePromotion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBSaleOnlinePromotion.FormattingEnabled = true;
            this.CBSaleOnlinePromotion.Location = new System.Drawing.Point(11, 226);
            this.CBSaleOnlinePromotion.Margin = new System.Windows.Forms.Padding(2);
            this.CBSaleOnlinePromotion.Name = "CBSaleOnlinePromotion";
            this.CBSaleOnlinePromotion.Size = new System.Drawing.Size(429, 37);
            this.CBSaleOnlinePromotion.TabIndex = 10;
            // 
            // CBSaleOnlineProdId
            // 
            this.CBSaleOnlineProdId.FormattingEnabled = true;
            this.CBSaleOnlineProdId.Location = new System.Drawing.Point(9, 330);
            this.CBSaleOnlineProdId.Margin = new System.Windows.Forms.Padding(2);
            this.CBSaleOnlineProdId.Name = "CBSaleOnlineProdId";
            this.CBSaleOnlineProdId.Size = new System.Drawing.Size(193, 37);
            this.CBSaleOnlineProdId.TabIndex = 11;
            // 
            // TxtSaleOnlineProdN
            // 
            this.TxtSaleOnlineProdN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSaleOnlineProdN.Location = new System.Drawing.Point(240, 332);
            this.TxtSaleOnlineProdN.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSaleOnlineProdN.Name = "TxtSaleOnlineProdN";
            this.TxtSaleOnlineProdN.Size = new System.Drawing.Size(198, 35);
            this.TxtSaleOnlineProdN.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 330);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Product";
            // 
            // BtnSaleOnlineAddProd
            // 
            this.BtnSaleOnlineAddProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaleOnlineAddProd.Location = new System.Drawing.Point(9, 377);
            this.BtnSaleOnlineAddProd.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSaleOnlineAddProd.Name = "BtnSaleOnlineAddProd";
            this.BtnSaleOnlineAddProd.Size = new System.Drawing.Size(429, 78);
            this.BtnSaleOnlineAddProd.TabIndex = 14;
            this.BtnSaleOnlineAddProd.Text = "Add Product";
            this.BtnSaleOnlineAddProd.UseVisualStyleBackColor = true;
            this.BtnSaleOnlineAddProd.Click += new System.EventHandler(this.BtnSaleOnlineAddProd_Click);
            // 
            // GVSaleOnlineProduct
            // 
            this.GVSaleOnlineProduct.AllowUserToAddRows = false;
            this.GVSaleOnlineProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVSaleOnlineProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVSaleOnlineProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVSaleOnlineProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Quantity});
            this.GVSaleOnlineProduct.Location = new System.Drawing.Point(11, 459);
            this.GVSaleOnlineProduct.Margin = new System.Windows.Forms.Padding(2);
            this.GVSaleOnlineProduct.Name = "GVSaleOnlineProduct";
            this.GVSaleOnlineProduct.RowHeadersVisible = false;
            this.GVSaleOnlineProduct.RowHeadersWidth = 92;
            this.GVSaleOnlineProduct.RowTemplate.Height = 37;
            this.GVSaleOnlineProduct.Size = new System.Drawing.Size(427, 165);
            this.GVSaleOnlineProduct.TabIndex = 15;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 11;
            this.Id.Name = "Id";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 11;
            this.Quantity.Name = "Quantity";
            // 
            // BtnSaleOnlineOk
            // 
            this.BtnSaleOnlineOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSaleOnlineOk.Location = new System.Drawing.Point(11, 645);
            this.BtnSaleOnlineOk.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSaleOnlineOk.Name = "BtnSaleOnlineOk";
            this.BtnSaleOnlineOk.Size = new System.Drawing.Size(315, 65);
            this.BtnSaleOnlineOk.TabIndex = 16;
            this.BtnSaleOnlineOk.Text = "Ok";
            this.BtnSaleOnlineOk.UseVisualStyleBackColor = true;
            this.BtnSaleOnlineOk.Click += new System.EventHandler(this.BtnSaleOnlineOk_Click);
            // 
            // BtnSaleOnlineCancel
            // 
            this.BtnSaleOnlineCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaleOnlineCancel.Location = new System.Drawing.Point(346, 645);
            this.BtnSaleOnlineCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSaleOnlineCancel.Name = "BtnSaleOnlineCancel";
            this.BtnSaleOnlineCancel.Size = new System.Drawing.Size(315, 65);
            this.BtnSaleOnlineCancel.TabIndex = 17;
            this.BtnSaleOnlineCancel.Text = "Cancel";
            this.BtnSaleOnlineCancel.UseVisualStyleBackColor = true;
            this.BtnSaleOnlineCancel.Click += new System.EventHandler(this.BtnSaleOnlineCancel_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Shipper";
            // 
            // CBSaleOnlineShipper
            // 
            this.CBSaleOnlineShipper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBSaleOnlineShipper.FormattingEnabled = true;
            this.CBSaleOnlineShipper.Location = new System.Drawing.Point(9, 275);
            this.CBSaleOnlineShipper.Margin = new System.Windows.Forms.Padding(2);
            this.CBSaleOnlineShipper.Name = "CBSaleOnlineShipper";
            this.CBSaleOnlineShipper.Size = new System.Drawing.Size(429, 37);
            this.CBSaleOnlineShipper.TabIndex = 20;
            // 
            // AddSaleOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 721);
            this.Controls.Add(this.CBSaleOnlineShipper);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSaleOnlineCancel);
            this.Controls.Add(this.BtnSaleOnlineOk);
            this.Controls.Add(this.GVSaleOnlineProduct);
            this.Controls.Add(this.BtnSaleOnlineAddProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSaleOnlineProdN);
            this.Controls.Add(this.CBSaleOnlineProdId);
            this.Controls.Add(this.CBSaleOnlinePromotion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBSaleOnlineCodClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateSaleOnline);
            this.Name = "AddSaleOnline";
            this.Text = "AddSaleOnline";
            this.Load += new System.EventHandler(this.AddSaleOnline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVSaleOnlineProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateSaleOnline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBSaleOnlineCodClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBSaleOnlinePromotion;
        private System.Windows.Forms.ComboBox CBSaleOnlineProdId;
        private System.Windows.Forms.TextBox TxtSaleOnlineProdN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSaleOnlineAddProd;
        private System.Windows.Forms.DataGridView GVSaleOnlineProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button BtnSaleOnlineOk;
        private System.Windows.Forms.Button BtnSaleOnlineCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBSaleOnlineShipper;
    }
}