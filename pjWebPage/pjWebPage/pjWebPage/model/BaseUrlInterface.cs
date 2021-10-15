using System;
using System.Collections.Generic;
using System.Text;

namespace pjWebPage.model
{
    class BaseUrlInterface : IBaseUrl
    {
        public string Get()
        {
            return "file://android_assets/Index.html";
        }
    }
}
