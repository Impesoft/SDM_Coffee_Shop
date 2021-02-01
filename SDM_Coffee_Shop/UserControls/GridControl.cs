using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace SDM_Coffee_Shop.UserControls
{
    public partial class GridControl : UserControl
    {
        private ShoppingCart _cart;
        private IBeverageRepo _repo;

        public GridControl()
        {
            InitializeComponent();

            _cart = ShoppingCart.GetShoppingCart();
            _repo = new BeverageRepo();
        }

        public int ID { get; set; }

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

        //ADD EVENT HANDLER
        private void btnInfosmall_Click(object sender, EventArgs e)
        {
            IBeverage beverage = _repo.GetBeverage(ID);
            Form form = new FormOrder(beverage);

            form.OrderButtenClicked += AddToCartButtonClicked;
            
            form.ShowDialog();
        }

        //ADD EVENT HANDLER
        public event EventHandler AddToCartButtonClicked;

        protected virtual void OnAddToCartButtonClicked(EventArgs e)
        {
            AddToCartButtonClicked?.Invoke(this, e);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            OnAddToCartButtonClicked(e);
        }

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