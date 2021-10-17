using pjWebPage.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(BaseUrlInterface))]
namespace pjWebPage.model
{
    interface IBaseUrl
    {
        string Get();
    }
}
