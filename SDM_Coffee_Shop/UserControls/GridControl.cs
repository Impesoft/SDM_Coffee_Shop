using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using System.Reflection;

namespace SDM_Coffee_Shop.UserControls
{
    public partial class GridControl : UserControl
    {
        private ShoppingCart _cart;

        private IBeverageRepo _repo;

        public int GridID { get; set; }

        public GridControl()
        {
            InitializeComponent();

            _cart = ShoppingCart.GetShoppingCart();
            _repo = new BeverageRepo();
        }

        public string MyProductName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string Price
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public string Image
        {
            set
            {
                if (value != null)
                {
                    ResourceManager rm = Properties.Resources.ResourceManager;
                    Bitmap myImage = (Bitmap)rm.GetObject(value);

                    PBGrid.BackgroundImage = myImage;
                }
            }
        }

        private void btnInfosmall_Click(object sender, EventArgs e)
        {
            Type bevtype = _repo.GetBeverage(GridID).GetType();
            Beverage beverage = (Beverage)Activator.CreateInstance(bevtype);
            beverage.UniqueID = beverage.ProductID;

            FormOrder form = new FormOrder(beverage);

            form.OrderButtonClicked += AddToCartButtonClicked;
            form.ShowDialog();
        }

        public event EventHandler AddToCartButtonClicked;

        private void buttonHoover_MouseLeave(object sender, EventArgs e)
        {
            PBGrid.Image = null;
        }

        private void PBGrid_MouseEnter(object sender, EventArgs e)
        {
            ResourceManager rm = Properties.Resources.ResourceManager;
            Bitmap myImage = (Bitmap)rm.GetObject("Overlay");
            PBGrid.Image = myImage;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.LightGray, ButtonBorderStyle.None);
        }
    }
}