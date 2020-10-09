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
            this._productGroup = new System.Windows.Forms.GroupBox();
            this._productTab = new System.Windows.Forms.TabControl();
            this._productDetail = new System.Windows.Forms.GroupBox();
            this._addButton = new System.Windows.Forms.Button();
            this._orderLabel = new System.Windows.Forms.Label();
            this._orderGridView = new System.Windows.Forms.DataGridView();
            this._orderAmountLabel = new System.Windows.Forms.Label();
            this._productGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._orderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productGroup
            // 
            this._productGroup.Controls.Add(this._productTab);
            this._productGroup.Controls.Add(this._productDetail);
            this._productGroup.Controls.Add(this._addButton);
            this._productGroup.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._productGroup.Location = new System.Drawing.Point(12, 12);
            this._productGroup.Name = "_productGroup";
            this._productGroup.Size = new System.Drawing.Size(415, 437);
            this._productGroup.TabIndex = 0;
            this._productGroup.TabStop = false;
            this._productGroup.Text = "商品";
            // 
            // _productTab
            // 
            this._productTab.Location = new System.Drawing.Point(10, 30);
            this._productTab.Name = "_productTab";
            this._productTab.SelectedIndex = 0;
            this._productTab.Size = new System.Drawing.Size(399, 150);
            this._productTab.TabIndex = 2;
            // 
            // productDetail
            // 
            this._productDetail.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._productDetail.Location = new System.Drawing.Point(10, 186);
            this._productDetail.Name = "_productDetail";
            this._productDetail.Size = new System.Drawing.Size(399, 199);
            this._productDetail.TabIndex = 0;
            this._productDetail.TabStop = false;
            this._productDetail.Text = "商品介紹";
            // 
            // addButton
            // 
            this._addButton.Location = new System.Drawing.Point(289, 391);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(120, 40);
            this._addButton.TabIndex = 1;
            this._addButton.Text = "加入";
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // orderLabel
            // 
            this._orderLabel.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderLabel.Location = new System.Drawing.Point(438, 9);
            this._orderLabel.Name = "_orderLabel";
            this._orderLabel.Size = new System.Drawing.Size(350, 30);
            this._orderLabel.TabIndex = 1;
            this._orderLabel.Text = "我的訂單";
            this._orderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderGridView
            // 
            this._orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._orderGridView.Location = new System.Drawing.Point(438, 42);
            this._orderGridView.Name = "_orderGridView";
            this._orderGridView.RowTemplate.Height = 24;
            this._orderGridView.Size = new System.Drawing.Size(350, 377);
            this._orderGridView.TabIndex = 2;
            // 
            // orderAmountLabel
            // 
            this._orderAmountLabel.AutoSize = true;
            this._orderAmountLabel.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderAmountLabel.Location = new System.Drawing.Point(438, 422);
            this._orderAmountLabel.Name = "_orderAmountLabel";
            this._orderAmountLabel.Size = new System.Drawing.Size(152, 27);
            this._orderAmountLabel.TabIndex = 3;
            this._orderAmountLabel.Text = "總金額 : 0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this._orderAmountLabel);
            this.Controls.Add(this._orderGridView);
            this.Controls.Add(this._orderLabel);
            this.Controls.Add(this._productGroup);
            this.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Main";
            this.Text = "訂購";
            this.Load += new System.EventHandler(this.FormLoad);
            this._productGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._orderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _productGroup;
        private System.Windows.Forms.TabControl _productTab;
        private System.Windows.Forms.GroupBox _productDetail;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Label _orderLabel;
        private System.Windows.Forms.DataGridView _orderGridView;
        private System.Windows.Forms.Label _orderAmountLabel;
    }
}

