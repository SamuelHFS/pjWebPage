using pjWebPage.model;
using System;
using System.Collections.Generic;
using System.Text;
[assembly: Xamarin.Forms.Dependency(typeof(BaseUrlInterface))]
namespace pjWebPage.model
{
    interface IBaseUrl
    {
        String Get();
    }
}
