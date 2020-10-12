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
            this._productGroupBox = new System.Windows.Forms.GroupBox();
            this._productTabControl = new System.Windows.Forms.TabControl();
            this._productDetailGroupBox = new System.Windows.Forms.GroupBox();
            this._productDescriptionLabel = new System.Windows.Forms.Label();
            this._addButton = new System.Windows.Forms.Button();
            this._orderLabel = new System.Windows.Forms.Label();
            this._orderDataGridView = new System.Windows.Forms.DataGridView();
            this._orderAmountLabel = new System.Windows.Forms.Label();
            this._productPriceLabel = new System.Windows.Forms.Label();
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
            this._productGroupBox.Size = new System.Drawing.Size(563, 455);
            this._productGroupBox.TabIndex = 0;
            this._productGroupBox.TabStop = false;
            this._productGroupBox.Text = "商品";
            // 
            // _productTabControl
            // 
            this._productTabControl.Location = new System.Drawing.Point(10, 30);
            this._productTabControl.Name = "_productTabControl";
            this._productTabControl.SelectedIndex = 0;
            this._productTabControl.Size = new System.Drawing.Size(536, 205);
            this._productTabControl.TabIndex = 2;
            // 
            // _productDetailGroupBox
            // 
            this._productDetailGroupBox.Controls.Add(this._productPriceLabel);
            this._productDetailGroupBox.Controls.Add(this._productDescriptionLabel);
            this._productDetailGroupBox.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._productDetailGroupBox.Location = new System.Drawing.Point(10, 241);
            this._productDetailGroupBox.Name = "_productDetailGroupBox";
            this._productDetailGroupBox.Size = new System.Drawing.Size(536, 162);
            this._productDetailGroupBox.TabIndex = 0;
            this._productDetailGroupBox.TabStop = false;
            this._productDetailGroupBox.Text = "商品介紹";
            // 
            // _productDescriptionLabel
            // 
            this._productDescriptionLabel.AutoSize = true;
            this._productDescriptionLabel.Location = new System.Drawing.Point(23, 35);
            this._productDescriptionLabel.Name = "_productDescriptionLabel";
            this._productDescriptionLabel.Size = new System.Drawing.Size(0, 19);
            this._productDescriptionLabel.TabIndex = 0;
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(426, 409);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(120, 40);
            this._addButton.TabIndex = 1;
            this._addButton.Text = "加入";
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // _orderLabel
            // 
            this._orderLabel.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderLabel.Location = new System.Drawing.Point(581, 9);
            this._orderLabel.Name = "_orderLabel";
            this._orderLabel.Size = new System.Drawing.Size(345, 30);
            this._orderLabel.TabIndex = 1;
            this._orderLabel.Text = "我的訂單";
            this._orderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _orderDataGridView
            // 
            this._orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._orderDataGridView.Location = new System.Drawing.Point(581, 42);
            this._orderDataGridView.Name = "_orderDataGridView";
            this._orderDataGridView.RowTemplate.Height = 24;
            this._orderDataGridView.Size = new System.Drawing.Size(350, 395);
            this._orderDataGridView.TabIndex = 2;
            // 
            // _orderAmountLabel
            // 
            this._orderAmountLabel.AutoSize = true;
            this._orderAmountLabel.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderAmountLabel.Location = new System.Drawing.Point(581, 440);
            this._orderAmountLabel.Name = "_orderAmountLabel";
            this._orderAmountLabel.Size = new System.Drawing.Size(152, 27);
            this._orderAmountLabel.TabIndex = 3;
            this._orderAmountLabel.Text = "總金額 : 0";
            // 
            // _productPriceLabel
            // 
            this._productPriceLabel.AutoSize = true;
            this._productPriceLabel.Location = new System.Drawing.Point(395, 126);
            this._productPriceLabel.Name = "_productPriceLabel";
            this._productPriceLabel.Size = new System.Drawing.Size(0, 19);
            this._productPriceLabel.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 476);
            this.Controls.Add(this._orderAmountLabel);
            this.Controls.Add(this._orderDataGridView);
            this.Controls.Add(this._orderLabel);
            this.Controls.Add(this._productGroupBox);
            this.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Main";
            this.Text = "訂購";
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
        private System.Windows.Forms.Label _productDescriptionLabel;
        private System.Windows.Forms.Label _productPriceLabel;
    }
}

