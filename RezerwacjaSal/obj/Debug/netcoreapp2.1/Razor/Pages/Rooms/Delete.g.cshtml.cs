#pragma checksum "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f0ebec2dd5a540431d31840057d8eac87845b29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RezerwacjaSal.Pages.Rooms.Pages_Rooms_Delete), @"mvc.1.0.razor-page", @"/Pages/Rooms/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Rooms/Delete.cshtml", typeof(RezerwacjaSal.Pages.Rooms.Pages_Rooms_Delete), null)]
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
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\_ViewImports.cshtml"
using RezerwacjaSal;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f0ebec2dd5a540431d31840057d8eac87845b29", @"/Pages/Rooms/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"153ee7dfce6fce13f708644f3027e1f961ed1e17", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Rooms_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(99, 264, true);
            WriteLiteral(@"


<h3>Czy jesteś pewien, że chcesz usunąć ten pokój?</h3>
<h5 style=""color:red"">Usunięte zostaną także powiązane rezerwacje.</h5>

<div>
    <hr />
    <dl class=""dl-horizontal"">
        <dt>
            Numer:
        </dt>
        <dd>
            ");
            EndContext();
            BeginContext(364, 43, false);
#line 21 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Room.Number));

#line default
#line hidden
            EndContext();
            BeginContext(407, 93, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Rodzaj:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(501, 41, false);
#line 27 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Room.Type));

#line default
#line hidden
            EndContext();
            BeginContext(542, 103, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Opis wyposażenia:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(646, 46, false);
#line 33 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Room.Equipment));

#line default
#line hidden
            EndContext();
            BeginContext(692, 92, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Adres:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(785, 53, false);
#line 39 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Room.Building.Address));

#line default
#line hidden
            EndContext();
            BeginContext(838, 32, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    ");
            EndContext();
            BeginContext(870, 395, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca2cf731a18455fa449d22bce1766d1", async() => {
                BeginContext(890, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(900, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "846c157b236c4bfda1e19c091adf6cd4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 43 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Room.RoomID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(945, 50, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n\r\n            ");
                EndContext();
                BeginContext(995, 155, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b1bf9ec35e443cfa235475d11b30033", async() => {
                    BeginContext(1135, 11, true);
                    WriteLiteral("Lista pokoi");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-buildingid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 46 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Delete.cshtml"
                                                                  WriteLiteral(Model.BuildingIdRoute);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["buildingid"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-buildingid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["buildingid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 46 "C:\Users\krzys\source\repos\KrzysztofV\rezerwacjasal\RezerwacjaSal\Pages\Rooms\Delete.cshtml"
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
                BeginContext(1150, 108, true);
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Usuń\" class=\"btn btn-default btn-danger\"  />\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1265, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RezerwacjaSal.Pages.Rooms.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RezerwacjaSal.Pages.Rooms.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RezerwacjaSal.Pages.Rooms.DeleteModel>)PageContext?.ViewData;
        public RezerwacjaSal.Pages.Rooms.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
