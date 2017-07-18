using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.PublishedContentModels;

namespace Catering
{
    public static class SiteHelper
    {
        public static UmbracoHelper UmbHelper()
        {
            const string key = "umb-helper";
            if (!HttpContext.Current.Items.Contains(key))
            {
                HttpContext.Current.Items.Add(key, new UmbracoHelper(UmbracoContext.Current));
            }
            return HttpContext.Current.Items[key] as UmbracoHelper;
        }

        public static Home GetHomeNode()
        {
            return UmbHelper().TypedContentAtRoot().First(x => x.DocumentTypeAlias == Home.ModelTypeAlias) as Home;
        }
    }
}