#pragma checksum "D:\тестирую программы\Note\NoteBook\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "078a38e0f18cff667e5663a9ece37f8106b96fdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "D:\тестирую программы\Note\NoteBook\Views\_ViewImports.cshtml"
using NoteBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\тестирую программы\Note\NoteBook\Views\_ViewImports.cshtml"
using NoteBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"078a38e0f18cff667e5663a9ece37f8106b96fdb", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e152b44583f1b9764838e79f2f5d5a5bf0a124a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NoteBook.Models.Note>
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
#nullable restore
#line 2 "D:\тестирую программы\Note\NoteBook\Views\Home\Details.cshtml"
  
    ViewBag.Title = "Посмотреть";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "078a38e0f18cff667e5663a9ece37f8106b96fdb3384", async() => {
                WriteLiteral("\r\n    <title>Ежедневник</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "078a38e0f18cff667e5663a9ece37f8106b96fdb4383", async() => {
                WriteLiteral("\r\n\r\n    <h2>Ежедневник ");
#nullable restore
#line 13 "D:\тестирую программы\Note\NoteBook\Views\Home\Details.cshtml"
              Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n    <div>\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>Идентификатор</dt>\r\n            <dd>");
#nullable restore
#line 17 "D:\тестирую программы\Note\NoteBook\Views\Home\Details.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</dd>\r\n\r\n       \r\n\r\n            <dt>Задача</dt>\r\n            <dd>");
#nullable restore
#line 22 "D:\тестирую программы\Note\NoteBook\Views\Home\Details.cshtml"
           Write(Model.Task);

#line default
#line hidden
#nullable disable
                WriteLiteral("</dd>\r\n\r\n\r\n\r\n          \r\n        </dl>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NoteBook.Models.Note> Html { get; private set; }
    }
}
#pragma warning restore 1591
