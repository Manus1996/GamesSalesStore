using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace GamesSalesStore.MarkupExtensions
{
    internal class EmbeddedImage : IMarkupExtension
    {
        public string ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
           // if (String.IsNullOrWhiteSpace(ResourceId))
           //     return null;
            return ImageSource.FromResource(ResourceId);
        }

        //"GameSalesStore.Images.gaming-wallpaper.jpg"
    }
}
