#pragma checksum "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e11119364010cf70f83fe5d3bc74ecf1cf06516"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RezerwacjaSal.Pages.Rooms.Pages_Rooms_Details), @"mvc.1.0.razor-page", @"/Pages/Rooms/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Rooms/Details.cshtml", typeof(RezerwacjaSal.Pages.Rooms.Pages_Rooms_Details), null)]
namespace RezerwacjaSal.Pages.Rooms
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\_ViewImports.cshtml"
using RezerwacjaSal;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e11119364010cf70f83fe5d3bc74ecf1cf06516", @"/Pages/Rooms/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd8b6aac60d47664502caafeb84485740cfdbc6a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Rooms_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(100, 150, true);
            WriteLiteral("\r\n<h3>Szczegóły</h3>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Numer:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(251, 43, false);
#line 17 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.Room.Number));

#line default
#line hidden
            EndContext();
            BeginContext(294, 93, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Rodzaj:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(388, 41, false);
#line 23 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.Room.Type));

#line default
#line hidden
            EndContext();
            BeginContext(429, 99, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Ilość miejsc:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(529, 42, false);
#line 29 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.Room.Spots));

#line default
#line hidden
            EndContext();
            BeginContext(571, 98, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Wyposażenie:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(670, 46, false);
#line 35 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.Room.Equipment));

#line default
#line hidden
            EndContext();
            BeginContext(716, 92, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Adres:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(809, 53, false);
#line 41 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.Room.Building.Address));

#line default
#line hidden
            EndContext();
            BeginContext(862, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(909, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "440b9cb63a264daab3b13841ca180fda", async() => {
                BeginContext(1049, 11, true);
                WriteLiteral("Lista pokoi");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-buildingid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Details.cshtml"
                                                          WriteLiteral(Model.BuildingIdRoute);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["buildingid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-buildingid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["buildingid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Details.cshtml"
                                                                                                          WriteLiteral(Model.DepartmentIdRoute);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["departmentid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-departmentid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["departmentid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1064, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RezerwacjaSal.Pages.Rooms.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RezerwacjaSal.Pages.Rooms.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RezerwacjaSal.Pages.Rooms.DetailsModel>)PageContext?.ViewData;
        public RezerwacjaSal.Pages.Rooms.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
