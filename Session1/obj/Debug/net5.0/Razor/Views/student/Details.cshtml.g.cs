#pragma checksum "C:\Mohan\App\ASPCORE_TRAINING\Session1\Session1\Views\student\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba13f6287ee55bb4fe112baab30b7641ac69e73f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_student_Details), @"mvc.1.0.view", @"/Views/student/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Mohan\App\ASPCORE_TRAINING\Session1\Session1\Views\_ViewImports.cshtml"
using Session1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Mohan\App\ASPCORE_TRAINING\Session1\Session1\Views\_ViewImports.cshtml"
using Session1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba13f6287ee55bb4fe112baab30b7641ac69e73f", @"/Views/student/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9794e598f40245a2af333a8b1052645e0537920a", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/student/_ViewImports.cshtml")]
    public class Views_student_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Session1.Models.StudentDetailsViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba13f6287ee55bb4fe112baab30b7641ac69e73f3504", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 15 "C:\Mohan\App\ASPCORE_TRAINING\Session1\Session1\Views\student\Details.cshtml"
      Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba13f6287ee55bb4fe112baab30b7641ac69e73f4713", async() => {
                WriteLiteral("\r\n    <h1>");
#nullable restore
#line 18 "C:\Mohan\App\ASPCORE_TRAINING\Session1\Session1\Views\student\Details.cshtml"
   Write(Model.Header);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n    <div>\r\n        StudentId : ");
#nullable restore
#line 20 "C:\Mohan\App\ASPCORE_TRAINING\Session1\Session1\Views\student\Details.cshtml"
               Write(Model.Student.StudentId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        Name : ");
#nullable restore
#line 23 "C:\Mohan\App\ASPCORE_TRAINING\Session1\Session1\Views\student\Details.cshtml"
          Write(Model.Student.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        Branch : ");
#nullable restore
#line 26 "C:\Mohan\App\ASPCORE_TRAINING\Session1\Session1\Views\student\Details.cshtml"
            Write(Model.Student.Branch);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        Section : ");
#nullable restore
#line 29 "C:\Mohan\App\ASPCORE_TRAINING\Session1\Session1\Views\student\Details.cshtml"
             Write(Model.Student.Section);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        Gender : ");
#nullable restore
#line 32 "C:\Mohan\App\ASPCORE_TRAINING\Session1\Session1\Views\student\Details.cshtml"
            Write(Model.Student.Gender);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <h1>Student Address</h1>\r\n    <div>\r\n        City : ");
#nullable restore
#line 37 "C:\Mohan\App\ASPCORE_TRAINING\Session1\Session1\Views\student\Details.cshtml"
          Write(Model.Address.City);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        State : ");
#nullable restore
#line 40 "C:\Mohan\App\ASPCORE_TRAINING\Session1\Session1\Views\student\Details.cshtml"
           Write(Model.Address.State);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        Country : ");
#nullable restore
#line 43 "C:\Mohan\App\ASPCORE_TRAINING\Session1\Session1\Views\student\Details.cshtml"
             Write(Model.Address.Country);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        Pin : ");
#nullable restore
#line 46 "C:\Mohan\App\ASPCORE_TRAINING\Session1\Session1\Views\student\Details.cshtml"
         Write(Model.Address.Pin);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"card-footer text-center\">\r\n        <a href=\"#\" class=\"btn btn-primary\">Back</a>\r\n        <a href=\"#\" class=\"btn btn-primary\">Edit</a>\r\n        <a href=\"#\" class=\"btn btn-danger\">Delete</a>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Session1.Models.StudentDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591