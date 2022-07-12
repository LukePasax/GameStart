
namespace GameStartApp
{
    partial class AddSaleStore
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
            this.label1 = new System.Windows.Forms.Label();
            this.DateSaleStore = new System.Windows.Forms.DateTimePicker();
            this.CBSaleStoreCodClient = new System.Windows.Forms.ComboBox();
            this.CBSaleStoreCodEmp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBSaleStorePromotion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GVSaleStoreProduct = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBSaleStoreProdId = new System.Windows.Forms.ComboBox();
            this.TxtSaleStoreProdN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSaleStoreAddProd = new System.Windows.Forms.Button();
            this.BtnSaleStoreOk = new System.Windows.Forms.Button();
            this.BtnSaleStoreCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVSaleStoreProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add A Sale in Store";
            // 
            // DateSaleStore
            // 
            this.DateSaleStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateSaleStore.Location = new System.Drawing.Point(5, 54);
            this.DateSaleStore.Margin = new System.Windows.Forms.Padding(1);
            this.DateSaleStore.Name = "DateSaleStore";
            this.DateSaleStore.Size = new System.Drawing.Size(186, 20);
            this.DateSaleStore.TabIndex = 1;
            // 
            // CBSaleStoreCodClient
            // 
            this.CBSaleStoreCodClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBSaleStoreCodClient.FormattingEnabled = true;
            this.CBSaleStoreCodClient.Location = new System.Drawing.Point(5, 76);
            this.CBSaleStoreCodClient.Margin = new System.Windows.Forms.Padding(1);
            this.CBSaleStoreCodClient.Name = "CBSaleStoreCodClient";
            this.CBSaleStoreCodClient.Size = new System.Drawing.Size(186, 21);
            this.CBSaleStoreCodClient.TabIndex = 2;
            this.CBSaleStoreCodClient.SelectedValueChanged += new System.EventHandler(this.CBSaleStoreCodClient_Change);
            // 
            // CBSaleStoreCodEmp
            // 
            this.CBSaleStoreCodEmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBSaleStoreCodEmp.FormattingEnabled = true;
            this.CBSaleStoreCodEmp.Location = new System.Drawing.Point(5, 99);
            this.CBSaleStoreCodEmp.Margin = new System.Windows.Forms.Padding(1);
            this.CBSaleStoreCodEmp.Name = "CBSaleStoreCodEmp";
            this.CBSaleStoreCodEmp.Size = new System.Drawing.Size(186, 21);
            this.CBSaleStoreCodEmp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cod Client";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cod Employee";
            // 
            // CBSaleStorePromotion
            // 
            this.CBSaleStorePromotion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBSaleStorePromotion.FormattingEnabled = true;
            this.CBSaleStorePromotion.Location = new System.Drawing.Point(5, 122);
            this.CBSaleStorePromotion.Margin = new System.Windows.Forms.Padding(1);
            this.CBSaleStorePromotion.Name = "CBSaleStorePromotion";
            this.CBSaleStorePromotion.Size = new System.Drawing.Size(186, 21);
            this.CBSaleStorePromotion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Promotion";
            // 
            // GVSaleStoreProduct
            // 
            this.GVSaleStoreProduct.AllowUserToAddRows = false;
            this.GVSaleStoreProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVSaleStoreProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVSaleStoreProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVSaleStoreProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Quantity});
            this.GVSaleStoreProduct.Location = new System.Drawing.Point(5, 204);
            this.GVSaleStoreProduct.Margin = new System.Windows.Forms.Padding(1);
            this.GVSaleStoreProduct.Name = "GVSaleStoreProduct";
            this.GVSaleStoreProduct.RowHeadersVisible = false;
            this.GVSaleStoreProduct.RowHeadersWidth = 92;
            this.GVSaleStoreProduct.RowTemplate.Height = 37;
            this.GVSaleStoreProduct.Size = new System.Drawing.Size(183, 74);
            this.GVSaleStoreProduct.TabIndex = 9;
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
            // CBSaleStoreProdId
            // 
            this.CBSaleStoreProdId.FormattingEnabled = true;
            this.CBSaleStoreProdId.Location = new System.Drawing.Point(5, 145);
            this.CBSaleStoreProdId.Margin = new System.Windows.Forms.Padding(1);
            this.CBSaleStoreProdId.Name = "CBSaleStoreProdId";
            this.CBSaleStoreProdId.Size = new System.Drawing.Size(85, 21);
            this.CBSaleStoreProdId.TabIndex = 10;
            // 
            // TxtSaleStoreProdN
            // 
            this.TxtSaleStoreProdN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSaleStoreProdN.Location = new System.Drawing.Point(104, 145);
            this.TxtSaleStoreProdN.Margin = new System.Windows.Forms.Padding(1);
            this.TxtSaleStoreProdN.Name = "TxtSaleStoreProdN";
            this.TxtSaleStoreProdN.Size = new System.Drawing.Size(87, 20);
            this.TxtSaleStoreProdN.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Product";
            // 
            // BtnSaleStoreAddProd
            // 
            this.BtnSaleStoreAddProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaleStoreAddProd.Location = new System.Drawing.Point(5, 167);
            this.BtnSaleStoreAddProd.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSaleStoreAddProd.Name = "BtnSaleStoreAddProd";
            this.BtnSaleStoreAddProd.Size = new System.Drawing.Size(186, 35);
            this.BtnSaleStoreAddProd.TabIndex = 13;
            this.BtnSaleStoreAddProd.Text = "Add Product";
            this.BtnSaleStoreAddProd.UseVisualStyleBackColor = true;
            this.BtnSaleStoreAddProd.Click += new System.EventHandler(this.BtnSaleStoreAddProd_Click);
            // 
            // BtnSaleStoreOk
            // 
            this.BtnSaleStoreOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSaleStoreOk.Location = new System.Drawing.Point(10, 289);
            this.BtnSaleStoreOk.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSaleStoreOk.Name = "BtnSaleStoreOk";
            this.BtnSaleStoreOk.Size = new System.Drawing.Size(135, 29);
            this.BtnSaleStoreOk.TabIndex = 14;
            this.BtnSaleStoreOk.Text = "Ok";
            this.BtnSaleStoreOk.UseVisualStyleBackColor = true;
            this.BtnSaleStoreOk.Click += new System.EventHandler(this.BtnSaleStoreOk_Click);
            // 
            // BtnSaleStoreCancel
            // 
            this.BtnSaleStoreCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaleStoreCancel.Location = new System.Drawing.Point(148, 289);
            this.BtnSaleStoreCancel.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSaleStoreCancel.Name = "BtnSaleStoreCancel";
            this.BtnSaleStoreCancel.Size = new System.Drawing.Size(135, 29);
            this.BtnSaleStoreCancel.TabIndex = 15;
            this.BtnSaleStoreCancel.Text = "Cancel";
            this.BtnSaleStoreCancel.UseVisualStyleBackColor = true;
            this.BtnSaleStoreCancel.Click += new System.EventHandler(this.BtnSaleStoreCancel_Click);
            // 
            // AddSaleStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 323);
            this.Controls.Add(this.BtnSaleStoreCancel);
            this.Controls.Add(this.BtnSaleStoreOk);
            this.Controls.Add(this.BtnSaleStoreAddProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSaleStoreProdN);
            this.Controls.Add(this.CBSaleStoreProdId);
            this.Controls.Add(this.GVSaleStoreProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBSaleStorePromotion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBSaleStoreCodEmp);
            this.Controls.Add(this.CBSaleStoreCodClient);
            this.Controls.Add(this.DateSaleStore);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "AddSaleStore";
            this.Text = "AddSaleStore";
            this.Load += new System.EventHandler(this.AddSaleStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVSaleStoreProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateSaleStore;
        private System.Windows.Forms.ComboBox CBSaleStoreCodClient;
        private System.Windows.Forms.ComboBox CBSaleStoreCodEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBSaleStorePromotion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GVSaleStoreProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.ComboBox CBSaleStoreProdId;
        private System.Windows.Forms.TextBox TxtSaleStoreProdN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSaleStoreAddProd;
        private System.Windows.Forms.Button BtnSaleStoreOk;
        private System.Windows.Forms.Button BtnSaleStoreCancel;
    }
}