using AspNetCoreMvc_eTicaret_MovieSales.Models;

namespace AspNetCoreMvc_eTicaret_MovieSales.ViewModels
{
    public class CustomerFaturaViewModel
    {
        public CustomerViewModel customerViewModel { get; set; }    //müşteri
        public MovieSaleViewModel movieSaleViewModel { get; set; }  //satış
        public List<CartItem> cartItems { get; set; }       //sepet
    }
}
