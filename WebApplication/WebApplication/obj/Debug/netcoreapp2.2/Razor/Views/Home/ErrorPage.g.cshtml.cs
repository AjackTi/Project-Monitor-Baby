#pragma checksum "/Users/ajackti/Documents/GitHub/Project-Monitor-Baby/WebApplication/WebApplication/Views/Home/ErrorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "045b4a9feaa28d420b6e0ccaf633e2624d8c1319"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ErrorPage), @"mvc.1.0.view", @"/Views/Home/ErrorPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ErrorPage.cshtml", typeof(AspNetCore.Views_Home_ErrorPage))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/ajackti/Documents/GitHub/Project-Monitor-Baby/WebApplication/WebApplication/Views/_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#line 2 "/Users/ajackti/Documents/GitHub/Project-Monitor-Baby/WebApplication/WebApplication/Views/_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"045b4a9feaa28d420b6e0ccaf633e2624d8c1319", @"/Views/Home/ErrorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ErrorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/font-awesome.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/ajackti/Documents/GitHub/Project-Monitor-Baby/WebApplication/WebApplication/Views/Home/ErrorPage.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(25, 35, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            EndContext();
            BeginContext(60, 665, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "045b4a9feaa28d420b6e0ccaf633e2624d8c13194901", async() => {
                BeginContext(66, 386, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <title>404 HTML Template by Colorlib</title>

    <link href=""https://fonts.googleapis.com/css?family=Muli:400"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Passion+One"" rel=""stylesheet"">

    ");
                EndContext();
                BeginContext(452, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "045b4a9feaa28d420b6e0ccaf633e2624d8c13195679", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(527, 119, true);
                WriteLiteral("\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\n");
                EndContext();
                BeginContext(717, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(725, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(727, 637, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "045b4a9feaa28d420b6e0ccaf633e2624d8c13198092", async() => {
                BeginContext(733, 624, true);
                WriteLiteral(@"

    <div id=""notfound"">
        <div class=""notfound-bg""></div>
        <div class=""notfound"">
            <div class=""notfound-404"">
                <h1>404</h1>
            </div>
            <h2>Oops! Page Not Found</h2>
            <div class=""notfound-social"">
                <a href=""#""><i class=""fa fa-facebook""></i></a>
                <a href=""#""><i class=""fa fa-twitter""></i></a>
                <a href=""#""><i class=""fa fa-pinterest""></i></a>
                <a href=""#""><i class=""fa fa-google-plus""></i></a>
            </div>
            <a href=""/Home/Index"">Back To Homepage</a>
        </div>
    </div>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1364, 3111, true);
            WriteLiteral(@"

</html>

<style>
    * {
  -webkit-box-sizing: border-box;
          box-sizing: border-box;
}

body {
  padding: 0;
  margin: 0;
}

#notfound {
  position: relative;
  height: 100vh;
}

#notfound .notfound-bg {
  position: absolute;
  width: 100%;
  height: 100%;
  background-image: url('../images/bg.jpg');
  background-size: cover;
  background-position: center;
}

#notfound .notfound-bg:after {
  content: '';
  position: absolute;
  width: 100%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0.25);
}

#notfound .notfound {
  position: absolute;
  left: 50%;
  top: 50%;
  -webkit-transform: translate(-50%, -50%);
      -ms-transform: translate(-50%, -50%);
          transform: translate(-50%, -50%);
}

#notfound .notfound:after {
  content: '';
  position: absolute;
  left: 50%;
  top: 50%;
  -webkit-transform: translate(-50% , -50%);
      -ms-transform: translate(-50% , -50%);
          transform: translate(-50% , -50%);
  width: 100%;
  height: 600px;
  background-color: rgba(255, 255, 255, 0.7);
  ");
            WriteLiteral(@"-webkit-box-shadow: 0px 0px 0px 30px rgba(255, 255, 255, 0.7) inset;
          box-shadow: 0px 0px 0px 30px rgba(255, 255, 255, 0.7) inset;
  z-index: -1;
}

.notfound {
  max-width: 600px;
  width: 100%;
  text-align: center;
  padding: 30px;
  line-height: 1.4;
}

.notfound .notfound-404 {
  position: relative;
  height: 200px;
}

.notfound .notfound-404 h1 {
  font-family: 'Passion One', cursive;
  position: absolute;
  left: 50%;
  top: 50%;
  -webkit-transform: translate(-50%, -50%);
      -ms-transform: translate(-50%, -50%);
          transform: translate(-50%, -50%);
  font-size: 220px;
  margin: 0px;
  color: #222225;
  text-transform: uppercase;
}

.notfound h2 {
  font-family: 'Muli', sans-serif;
  font-size: 26px;
  font-weight: 400;
  text-transform: uppercase;
  color: #222225;
  margin-top: 26px;
  margin-bottom: 20px;
}

.notfound-search {
  position: relative;
  padding-right: 120px;
  max-width: 420px;
  width: 100%;
  margin: 30px auto 20px;
}

.notfound-search input {
  font-family: 'Muli'");
            WriteLiteral(@", sans-serif;
  width: 100%;
  height: 40px;
  padding: 3px 15px;
  color: #fff;
  font-weight: 400;
  font-size: 18px;
  background: #222225;
  border: none;
}

.notfound-search button {
  font-family: 'Muli', sans-serif;
  position: absolute;
  right: 0px;
  top: 0px;
  width: 120px;
  height: 40px;
  text-align: center;
  border: none;
  background: #ff00b4;
  cursor: pointer;
  padding: 0;
  color: #fff;
  font-weight: 400;
  font-size: 16px;
  text-transform: uppercase;
}

.notfound a {
  font-family: 'Muli', sans-serif;
  display: inline-block;
  font-weight: 400;
  text-decoration: none;
  background-color: transparent;
  color: #222225;
  text-transform: uppercase;
  font-size: 14px;
}

.notfound-social {
  margin-bottom: 15px;
}
.notfound-social>a {
  display: inline-block;
  height: 40px;
  line-height: 40px;
  width: 40px;
  font-size: 14px;
  color: #fff;
  background-color: #222225;
  margin: 3px;
  -webkit-transition: 0.2s all;
  transition: 0.2s all;
}
.notfound-social>a:hover {
  color: #fff;
");
            WriteLiteral("  background-color: #ff00b4;\n}\n</style>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
