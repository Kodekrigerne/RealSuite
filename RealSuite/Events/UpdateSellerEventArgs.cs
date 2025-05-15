using Models;

namespace RealSuite.Events
{
    public class UpdateSellerEventArgs : EventArgs
    {
        public Seller Seller { get; }

        public UpdateSellerEventArgs(Seller seller)
        {
            Seller = seller;
        }
    }
}
