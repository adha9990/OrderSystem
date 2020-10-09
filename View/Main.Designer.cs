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
            this.productGroup = new System.Windows.Forms.GroupBox();
            this.productTab = new System.Windows.Forms.TabControl();
            this.productDetail = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.orderLabel = new System.Windows.Forms.Label();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.orderAmountLabel = new System.Windows.Forms.Label();
            this.productGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productGroup
            // 
            this.productGroup.Controls.Add(this.productTab);
            this.productGroup.Controls.Add(this.productDetail);
            this.productGroup.Controls.Add(this.addButton);
            this.productGroup.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.productGroup.Location = new System.Drawing.Point(12, 12);
            this.productGroup.Name = "productGroup";
            this.productGroup.Size = new System.Drawing.Size(415, 437);
            this.productGroup.TabIndex = 0;
            this.productGroup.TabStop = false;
            this.productGroup.Text = "商品";
            // 
            // productTab
            // 
            this.productTab.Location = new System.Drawing.Point(10, 30);
            this.productTab.Name = "productTab";
            this.productTab.SelectedIndex = 0;
            this.productTab.Size = new System.Drawing.Size(399, 150);
            this.productTab.TabIndex = 2;
            // 
            // productDetail
            // 
            this.productDetail.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.productDetail.Location = new System.Drawing.Point(10, 186);
            this.productDetail.Name = "productDetail";
            this.productDetail.Size = new System.Drawing.Size(399, 199);
            this.productDetail.TabIndex = 0;
            this.productDetail.TabStop = false;
            this.productDetail.Text = "商品介紹";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(289, 391);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 40);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "加入";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderLabel
            // 
            this.orderLabel.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.orderLabel.Location = new System.Drawing.Point(438, 9);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(350, 30);
            this.orderLabel.TabIndex = 1;
            this.orderLabel.Text = "我的訂單";
            this.orderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderGridView
            // 
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(438, 42);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RowTemplate.Height = 24;
            this.orderGridView.Size = new System.Drawing.Size(350, 377);
            this.orderGridView.TabIndex = 2;
            this.orderGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderAmountLabel
            // 
            this.orderAmountLabel.AutoSize = true;
            this.orderAmountLabel.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.orderAmountLabel.Location = new System.Drawing.Point(438, 422);
            this.orderAmountLabel.Name = "orderAmountLabel";
            this.orderAmountLabel.Size = new System.Drawing.Size(152, 27);
            this.orderAmountLabel.TabIndex = 3;
            this.orderAmountLabel.Text = "總金額 : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.orderAmountLabel);
            this.Controls.Add(this.orderGridView);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.productGroup);
            this.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "訂購";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.productGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox productGroup;
        private System.Windows.Forms.TabControl productTab;
        private System.Windows.Forms.GroupBox productDetail;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.Label orderAmountLabel;
    }
}

