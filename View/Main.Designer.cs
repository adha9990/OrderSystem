namespace OrderSystem
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this._productGroupBox = new System.Windows.Forms.GroupBox();
            this._productTabControl = new System.Windows.Forms.TabControl();
            this._productDetailGroupBox = new System.Windows.Forms.GroupBox();
            this._productPriceLabel = new System.Windows.Forms.Label();
            this._addButton = new System.Windows.Forms.Button();
            this._orderLabel = new System.Windows.Forms.Label();
            this._orderDataGridView = new System.Windows.Forms.DataGridView();
            this._orderAmountLabel = new System.Windows.Forms.Label();
            this._productDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this._productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._productType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._productGroupBox.SuspendLayout();
            this._productDetailGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _productGroupBox
            // 
            this._productGroupBox.Controls.Add(this._productTabControl);
            this._productGroupBox.Controls.Add(this._productDetailGroupBox);
            this._productGroupBox.Controls.Add(this._addButton);
            this._productGroupBox.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._productGroupBox.Location = new System.Drawing.Point(12, 12);
            this._productGroupBox.Name = "_productGroupBox";
            this._productGroupBox.Size = new System.Drawing.Size(482, 559);
            this._productGroupBox.TabIndex = 0;
            this._productGroupBox.TabStop = false;
            this._productGroupBox.Text = "商品";
            // 
            // _productTabControl
            // 
            this._productTabControl.Location = new System.Drawing.Point(10, 30);
            this._productTabControl.Name = "_productTabControl";
            this._productTabControl.SelectedIndex = 0;
            this._productTabControl.Size = new System.Drawing.Size(455, 256);
            this._productTabControl.TabIndex = 2;
            // 
            // _productDetailGroupBox
            // 
            this._productDetailGroupBox.Controls.Add(this._productPriceLabel);
            this._productDetailGroupBox.Controls.Add(this._productDescriptionRichTextBox);
            this._productDetailGroupBox.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._productDetailGroupBox.Location = new System.Drawing.Point(10, 292);
            this._productDetailGroupBox.Name = "_productDetailGroupBox";
            this._productDetailGroupBox.Size = new System.Drawing.Size(455, 212);
            this._productDetailGroupBox.TabIndex = 0;
            this._productDetailGroupBox.TabStop = false;
            this._productDetailGroupBox.Text = "商品介紹";
            // 
            // _productPriceLabel
            // 
            this._productPriceLabel.AutoSize = true;
            this._productPriceLabel.Location = new System.Drawing.Point(331, 187);
            this._productPriceLabel.Name = "_productPriceLabel";
            this._productPriceLabel.Size = new System.Drawing.Size(0, 19);
            this._productPriceLabel.TabIndex = 1;
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(345, 510);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(120, 40);
            this._addButton.TabIndex = 1;
            this._addButton.Text = "加入";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this._addButton_Click);
            // 
            // _orderLabel
            // 
            this._orderLabel.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderLabel.Location = new System.Drawing.Point(500, 9);
            this._orderLabel.Name = "_orderLabel";
            this._orderLabel.Size = new System.Drawing.Size(304, 30);
            this._orderLabel.TabIndex = 1;
            this._orderLabel.Text = "我的訂單";
            this._orderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _orderDataGridView
            // 
            this._orderDataGridView.AllowUserToAddRows = false;
            this._orderDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._orderDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._orderDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._productName,
            this._productType,
            this._productPrice});
            this._orderDataGridView.Location = new System.Drawing.Point(500, 42);
            this._orderDataGridView.Name = "_orderDataGridView";
            this._orderDataGridView.ReadOnly = true;
            this._orderDataGridView.RowHeadersVisible = false;
            this._orderDataGridView.RowTemplate.Height = 24;
            this._orderDataGridView.Size = new System.Drawing.Size(304, 499);
            this._orderDataGridView.TabIndex = 2;
            // 
            // _orderAmountLabel
            // 
            this._orderAmountLabel.AutoSize = true;
            this._orderAmountLabel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderAmountLabel.Location = new System.Drawing.Point(500, 544);
            this._orderAmountLabel.Name = "_orderAmountLabel";
            this._orderAmountLabel.Size = new System.Drawing.Size(130, 24);
            this._orderAmountLabel.TabIndex = 3;
            this._orderAmountLabel.Text = "總金額:0元";
            // 
            // _productDescriptionRichTextBox
            // 
            this._productDescriptionRichTextBox.BackColor = System.Drawing.SystemColors.Control;
            this._productDescriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._productDescriptionRichTextBox.Location = new System.Drawing.Point(7, 29);
            this._productDescriptionRichTextBox.Name = "_productDescriptionRichTextBox";
            this._productDescriptionRichTextBox.Size = new System.Drawing.Size(313, 177);
            this._productDescriptionRichTextBox.TabIndex = 0;
            this._productDescriptionRichTextBox.Text = "";
            // 
            // _productName
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._productName.DefaultCellStyle = dataGridViewCellStyle3;
            this._productName.HeaderText = "商品名稱";
            this._productName.Name = "_productName";
            this._productName.ReadOnly = true;
            // 
            // _productType
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._productType.DefaultCellStyle = dataGridViewCellStyle4;
            this._productType.HeaderText = "商品類別";
            this._productType.Name = "_productType";
            this._productType.ReadOnly = true;
            // 
            // _productPrice
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._productPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this._productPrice.HeaderText = "單價";
            this._productPrice.Name = "_productPrice";
            this._productPrice.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 580);
            this.Controls.Add(this._orderAmountLabel);
            this.Controls.Add(this._orderDataGridView);
            this.Controls.Add(this._orderLabel);
            this.Controls.Add(this._productGroupBox);
            this.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Main";
            this.Text = "訂購系統";
            this.Load += new System.EventHandler(this.FormLoad);
            this._productGroupBox.ResumeLayout(false);
            this._productDetailGroupBox.ResumeLayout(false);
            this._productDetailGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._orderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _productGroupBox;
        private System.Windows.Forms.TabControl _productTabControl;
        private System.Windows.Forms.GroupBox _productDetailGroupBox;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Label _orderLabel;
        private System.Windows.Forms.DataGridView _orderDataGridView;
        private System.Windows.Forms.Label _orderAmountLabel;
        private System.Windows.Forms.Label _productPriceLabel;
        private System.Windows.Forms.RichTextBox _productDescriptionRichTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _productType;
        private System.Windows.Forms.DataGridViewTextBoxColumn _productPrice;
    }
}

