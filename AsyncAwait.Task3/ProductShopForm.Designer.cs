namespace AsyncAwait.Task3
{
    partial class ProductShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductShopForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.excludeProductButton = new System.Windows.Forms.Button();
            this.shopTitleLabel = new System.Windows.Forms.Label();
            this.basketTitleLabel = new System.Windows.Forms.Label();
            this.totalPriceTitleLabel = new System.Windows.Forms.Label();
            this.totalPriceValueLabel = new System.Windows.Forms.Label();
            this.shopProductsListBox = new System.Windows.Forms.ListBox();
            this.basketProductsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(97, 44);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(76, 26);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Task 3";
            // 
            // addProductButton
            // 
            this.addProductButton.Enabled = false;
            this.addProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(386, 316);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(90, 44);
            this.addProductButton.TabIndex = 11;
            this.addProductButton.Text = "Add product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(73, 80);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(386, 65);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // excludeProductButton
            // 
            this.excludeProductButton.Enabled = false;
            this.excludeProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excludeProductButton.Location = new System.Drawing.Point(386, 373);
            this.excludeProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.excludeProductButton.Name = "excludeProductButton";
            this.excludeProductButton.Size = new System.Drawing.Size(90, 44);
            this.excludeProductButton.TabIndex = 15;
            this.excludeProductButton.Text = "Exclude product";
            this.excludeProductButton.UseVisualStyleBackColor = true;
            this.excludeProductButton.Click += new System.EventHandler(this.excludeProductButton_Click);
            // 
            // shopTitleLabel
            // 
            this.shopTitleLabel.AutoSize = true;
            this.shopTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopTitleLabel.Location = new System.Drawing.Point(127, 213);
            this.shopTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shopTitleLabel.Name = "shopTitleLabel";
            this.shopTitleLabel.Size = new System.Drawing.Size(63, 26);
            this.shopTitleLabel.TabIndex = 17;
            this.shopTitleLabel.Text = "Shop";
            // 
            // basketTitleLabel
            // 
            this.basketTitleLabel.AutoSize = true;
            this.basketTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basketTitleLabel.Location = new System.Drawing.Point(557, 213);
            this.basketTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.basketTitleLabel.Name = "basketTitleLabel";
            this.basketTitleLabel.Size = new System.Drawing.Size(79, 26);
            this.basketTitleLabel.TabIndex = 18;
            this.basketTitleLabel.Text = "Basket";
            // 
            // totalPriceTitleLabel
            // 
            this.totalPriceTitleLabel.AutoSize = true;
            this.totalPriceTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceTitleLabel.Location = new System.Drawing.Point(539, 537);
            this.totalPriceTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPriceTitleLabel.Name = "totalPriceTitleLabel";
            this.totalPriceTitleLabel.Size = new System.Drawing.Size(118, 26);
            this.totalPriceTitleLabel.TabIndex = 19;
            this.totalPriceTitleLabel.Text = "Total price:";
            // 
            // totalPriceValueLabel
            // 
            this.totalPriceValueLabel.AutoSize = true;
            this.totalPriceValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceValueLabel.Location = new System.Drawing.Point(661, 537);
            this.totalPriceValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPriceValueLabel.Name = "totalPriceValueLabel";
            this.totalPriceValueLabel.Size = new System.Drawing.Size(24, 26);
            this.totalPriceValueLabel.TabIndex = 20;
            this.totalPriceValueLabel.Text = "0";
            // 
            // shopProductsListBox
            // 
            this.shopProductsListBox.FormattingEnabled = true;
            this.shopProductsListBox.Location = new System.Drawing.Point(52, 254);
            this.shopProductsListBox.Name = "shopProductsListBox";
            this.shopProductsListBox.Size = new System.Drawing.Size(310, 316);
            this.shopProductsListBox.TabIndex = 21;
            this.shopProductsListBox.SelectedIndexChanged += new System.EventHandler(this.shopProductsListBox_SelectedIndexChanged);
            // 
            // basketProductsListBox
            // 
            this.basketProductsListBox.FormattingEnabled = true;
            this.basketProductsListBox.Location = new System.Drawing.Point(498, 254);
            this.basketProductsListBox.Name = "basketProductsListBox";
            this.basketProductsListBox.Size = new System.Drawing.Size(310, 264);
            this.basketProductsListBox.TabIndex = 22;
            this.basketProductsListBox.SelectedIndexChanged += new System.EventHandler(this.basketProductsListBox_SelectedIndexChanged);
            // 
            // ProductShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 631);
            this.Controls.Add(this.basketProductsListBox);
            this.Controls.Add(this.shopProductsListBox);
            this.Controls.Add(this.totalPriceValueLabel);
            this.Controls.Add(this.totalPriceTitleLabel);
            this.Controls.Add(this.basketTitleLabel);
            this.Controls.Add(this.shopTitleLabel);
            this.Controls.Add(this.excludeProductButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.descriptionLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductShopForm";
            this.Text = "Product shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button excludeProductButton;
        private System.Windows.Forms.Label shopTitleLabel;
        private System.Windows.Forms.Label basketTitleLabel;
        private System.Windows.Forms.Label totalPriceTitleLabel;
        private System.Windows.Forms.Label totalPriceValueLabel;
        private System.Windows.Forms.ListBox shopProductsListBox;
        private System.Windows.Forms.ListBox basketProductsListBox;
    }
}

