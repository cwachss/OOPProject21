using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface2._0
{
    class FormProvider
    {
        public static MainMenu MainMenu
        {
            get
            {
                if (_mainMenu == null)
                {
                    _mainMenu = new MainMenu();
                }
                return _mainMenu;
            }
        }
        private static MainMenu _mainMenu;

        public static ProductForm ProductForm
        {
            get
            {
                if (_productForm == null)
                {
                    _productForm = new ProductForm();
                }
                return _productForm;
            }
        }

        private static ProductForm _productForm;

        public static orderForm OrderForm
        {
            get
            {
                if (_orderForm == null)
                {
                    _orderForm = new orderForm();
                }
                return _orderForm;
            }
        }
        private static orderForm _orderForm;

        public static CustomerForm CustomerForm
        {
            get
            {
                if (_customerForm == null)
                {
                    _customerForm = new CustomerForm();
                }
                return _customerForm;
            }
        }
        private static CustomerForm _customerForm;

    }
}
