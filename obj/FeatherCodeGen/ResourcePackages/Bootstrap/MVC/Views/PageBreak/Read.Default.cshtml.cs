#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.PageBreak
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..MVC\Views\PageBreak\Read.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\PageBreak\Read.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/PageBreak/Read.Default.cshtml")]
    public partial class Read_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.PageBreak.PageBreakViewModel>
    {
        public Read_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 6 "..\..MVC\Views\PageBreak\Read.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 229), Tuple.Create("\"", 263)
            
            #line 8 "..\..MVC\Views\PageBreak\Read.Default.cshtml"
, Tuple.Create(Tuple.Create("", 237), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 237), false)
, Tuple.Create(Tuple.Create(" ", 252), Tuple.Create("form-group", 253), true)
);

WriteLiteral(">\n    <button");

WriteLiteral(" data-sf-btn-role=\"next\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(">");

            
            #line 9 "..\..MVC\Views\PageBreak\Read.Default.cshtml"
                                                                     Write(Html.HtmlSanitize(Model.NextStepText));

            
            #line default
            #line hidden
WriteLiteral("</button>\n");

            
            #line 10 "..\..MVC\Views\PageBreak\Read.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 10 "..\..MVC\Views\PageBreak\Read.Default.cshtml"
     if (Model.AllowGoBack)
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-sf-btn-role=\"prev\"");

WriteLiteral(">");

            
            #line 12 "..\..MVC\Views\PageBreak\Read.Default.cshtml"
                                                        Write(Html.HtmlSanitize(Model.PreviousStepText));

            
            #line default
            #line hidden
WriteLiteral("</a>\n");

            
            #line 13 "..\..MVC\Views\PageBreak\Read.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

            
            #line 15 "..\..MVC\Views\PageBreak\Read.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/PageBreak/page-break.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

        }
    }
}
#pragma warning restore 1591
