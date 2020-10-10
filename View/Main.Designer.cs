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
            this._addButton = new System.Windows.Forms.Button();
            this._orderLabel = new System.Windows.Forms.Label();
            this._orderDataGridView = new System.Windows.Forms.DataGridView();
            this._orderAmountLabel = new System.Windows.Forms.Label();
            this._productGroupBox.SuspendLayout();
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
            this._productGroupBox.Size = new System.Drawing.Size(558, 437);
            this._productGroupBox.TabIndex = 0;
            this._productGroupBox.TabStop = false;
            this._productGroupBox.Text = "商品";
            // 
            // _productTabControl
            // 
            this._productTabControl.Location = new System.Drawing.Point(10, 30);
            this._productTabControl.Name = "_productTabControl";
            this._productTabControl.SelectedIndex = 0;
            this._productTabControl.Size = new System.Drawing.Size(542, 187);
            this._productTabControl.TabIndex = 2;
            // 
            // _productDetailGroupBox
            // 
            this._productDetailGroupBox.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._productDetailGroupBox.Location = new System.Drawing.Point(10, 223);
            this._productDetailGroupBox.Name = "_productDetailGroupBox";
            this._productDetailGroupBox.Size = new System.Drawing.Size(542, 162);
            this._productDetailGroupBox.TabIndex = 0;
            this._productDetailGroupBox.TabStop = false;
            this._productDetailGroupBox.Text = "商品介紹";
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(432, 391);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(120, 40);
            this._addButton.TabIndex = 1;
            this._addButton.Text = "加入";
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // _orderLabel
            // 
            this._orderLabel.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderLabel.Location = new System.Drawing.Point(576, 9);
            this._orderLabel.Name = "_orderLabel";
            this._orderLabel.Size = new System.Drawing.Size(350, 30);
            this._orderLabel.TabIndex = 1;
            this._orderLabel.Text = "我的訂單";
            this._orderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _orderDataGridView
            // 
            this._orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._orderDataGridView.Location = new System.Drawing.Point(576, 42);
            this._orderDataGridView.Name = "_orderDataGridView";
            this._orderDataGridView.RowTemplate.Height = 24;
            this._orderDataGridView.Size = new System.Drawing.Size(350, 377);
            this._orderDataGridView.TabIndex = 2;
            // 
            // _orderAmountLabel
            // 
            this._orderAmountLabel.AutoSize = true;
            this._orderAmountLabel.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderAmountLabel.Location = new System.Drawing.Point(576, 422);
            this._orderAmountLabel.Name = "_orderAmountLabel";
            this._orderAmountLabel.Size = new System.Drawing.Size(152, 27);
            this._orderAmountLabel.TabIndex = 3;
            this._orderAmountLabel.Text = "總金額 : 0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 461);
            this.Controls.Add(this._orderAmountLabel);
            this.Controls.Add(this._orderDataGridView);
            this.Controls.Add(this._orderLabel);
            this.Controls.Add(this._productGroupBox);
            this.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Main";
            this.Text = "訂購";
            this.Load += new System.EventHandler(this.FormLoad);
            this._productGroupBox.ResumeLayout(false);
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
    }
}

