using AsyncAwait.Task3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait.Task3
{
    public partial class ProductShopForm : Form
    {
        private ProductShop _productShop = new ProductShop();

        public ProductShopForm()
        {
            InitializeComponent();
            InitilizeShopListView();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            var selectedProduct = shopProductsListBox.SelectedItem;
            var addProductTask = _productShop.AddProductToBasketAsync(
                _productShop
                    .ShopList
                    .First(product => Equals(product.Name, selectedProduct)));

            RefreshBusketListBoxAsync(addProductTask);
            RefreshTotalPriceLabelAsync(addProductTask);
        }

        private void excludeProductButton_Click(object sender, EventArgs e)
        {
            var selectedProduct = shopProductsListBox.SelectedItem;
            var excludeProductTask = _productShop.ExcludeProductFromBasketAsync(
                _productShop
                    .ShopList
                    .First(product => Equals(product.Name, selectedProduct)));

            RefreshBusketListBoxAsync(excludeProductTask);
            RefreshTotalPriceLabelAsync(excludeProductTask);
        }

        private void shopProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addProductButton.Enabled = true;
            excludeProductButton.Enabled = false;
        }

        private void basketProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addProductButton.Enabled = false;
            excludeProductButton.Enabled = true;
        }

        private void RefreshListBox(ListBox listBox, IList<Product> productsList)
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(
                productsList
                    .Select(product => product.Name + " " + product.Price.ToString())
                    .ToArray());
        }

        private void InitilizeShopListView()
        {
            RefreshListBox(
                shopProductsListBox,
                _productShop.ShopList);
        }

        private async void RefreshBusketListBoxAsync(Task operationTask)
        {
            await operationTask;
            RefreshListBox(
                basketProductsListBox,
                _productShop.BasketList);
        }

        private async void RefreshTotalPriceLabelAsync(Task operationTask)
        {
            await operationTask;
            totalPriceValueLabel.Text = _productShop.CurentTotalPrice.ToString();
        }
    }
}
