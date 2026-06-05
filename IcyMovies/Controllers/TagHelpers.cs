using System.Text;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Web;
using Microsoft.AspNetCore.Html;

namespace IcyMovies.Controllers
{
    [HtmlTargetElement("IcyNavbarTagHelper")]
    public class IcyNavbarTagHelper : TagHelper
    {
        [HtmlAttributeNotBound]  
        [ViewContext]  
        public ViewContext ViewContext { get; set; }  
        
        public string ForPage { get; set; }
        private HttpContext Context => ViewContext.HttpContext;
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string page = ForPage;
            if (ViewContext.HttpContext.Request.Path == page)
            {
                output.AddClass("navbar-active", HtmlEncoder.Default);
            }
            
        }
    }
}
