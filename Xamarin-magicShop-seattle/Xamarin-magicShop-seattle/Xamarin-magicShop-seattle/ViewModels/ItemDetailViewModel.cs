using System;

using Xamarin_magicShop_seattle.Models;

namespace Xamarin_magicShop_seattle.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
