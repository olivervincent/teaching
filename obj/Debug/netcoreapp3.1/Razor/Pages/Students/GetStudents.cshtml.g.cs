#pragma checksum "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreTeaching_RazorPages/EFCoreTeaching_RazorPages/Pages/Students/GetStudents.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1ac57284f8d054603906b35338813104374728590ca6f43c1f3566e4ca495f04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EFCoreTeaching_RazorPages.Pages.Students.Pages_Students_GetStudents), @"mvc.1.0.razor-page", @"/Pages/Students/GetStudents.cshtml")]
namespace EFCoreTeaching_RazorPages.Pages.Students
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreTeaching_RazorPages/EFCoreTeaching_RazorPages/Pages/_ViewImports.cshtml"
using EFCoreTeaching_RazorPages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1ac57284f8d054603906b35338813104374728590ca6f43c1f3566e4ca495f04", @"/Pages/Students/GetStudents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d2a31c266bee4928ba4ac3e3f31c9f5bd9d3395befa8f6a3c9b25870529c6904", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Students_GetStudents : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Students/Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Students/Student_Enrollments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreTeaching_RazorPages/EFCoreTeaching_RazorPages/Pages/Students/GetStudents.cshtml"
  
    ViewData["Title"] = "GetStudents";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ac57284f8d054603906b35338813104374728590ca6f43c1f3566e4ca495f044320", async() => {
                WriteLiteral("Create New Student");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </p>\n<h3 style=\"color:red\"> List of students</h3>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th> Student Id </th>\n            <th> Name </th>\n            <th>  Address </th>\n        </tr>\n    </thead>\n    <tbody>\n\n");
#nullable restore
#line 20 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreTeaching_RazorPages/EFCoreTeaching_RazorPages/Pages/Students/GetStudents.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreTeaching_RazorPages/EFCoreTeaching_RazorPages/Pages/Students/GetStudents.cshtml"
             foreach (var item in Model.Students)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>  ");
#nullable restore
#line 25 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreTeaching_RazorPages/EFCoreTeaching_RazorPages/Pages/Students/GetStudents.cshtml"
                     Write(item.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                    <td>  ");
#nullable restore
#line 26 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreTeaching_RazorPages/EFCoreTeaching_RazorPages/Pages/Students/GetStudents.cshtml"
                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\n                    <td>\n                       <p>\n                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ac57284f8d054603906b35338813104374728590ca6f43c1f3566e4ca495f047322", async() => {
                WriteLiteral("Show Enrollments");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreTeaching_RazorPages/EFCoreTeaching_RazorPages/Pages/Students/GetStudents.cshtml"
                                                                          WriteLiteral(item.StudentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                       </p>\n                    </td>\n                 </tr>\n");
#nullable restore
#line 33 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreTeaching_RazorPages/EFCoreTeaching_RazorPages/Pages/Students/GetStudents.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreTeaching_RazorPages/EFCoreTeaching_RazorPages/Pages/Students/GetStudents.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n\n\n\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EFCoreTeaching_RazorPages.Pages.Students.GetStudentsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EFCoreTeaching_RazorPages.Pages.Students.GetStudentsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EFCoreTeaching_RazorPages.Pages.Students.GetStudentsModel>)PageContext?.ViewData;
        public EFCoreTeaching_RazorPages.Pages.Students.GetStudentsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591