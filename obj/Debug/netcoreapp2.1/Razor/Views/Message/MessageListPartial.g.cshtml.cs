#pragma checksum "C:\Users\Fred\Documents\C#\Wall\Views\Message\MessageListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbece54a94717b2c595fe46d8b87a01a3b5c4fc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_MessageListPartial), @"mvc.1.0.view", @"/Views/Message/MessageListPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Message/MessageListPartial.cshtml", typeof(AspNetCore.Views_Message_MessageListPartial))]
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
#line 1 "C:\Users\Fred\Documents\C#\Wall\Views\_ViewImports.cshtml"
using Wall;

#line default
#line hidden
#line 2 "C:\Users\Fred\Documents\C#\Wall\Views\_ViewImports.cshtml"
using Wall.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbece54a94717b2c595fe46d8b87a01a3b5c4fc1", @"/Views/Message/MessageListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"087dc1efdb6a89ed46a72156b1116f85a093d338", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_MessageListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Fred\Documents\C#\Wall\Views\Message\MessageListPartial.cshtml"
  
    foreach(var mess in @ViewBag.allMessage)
    {

#line default
#line hidden
            BeginContext(59, 116, true);
            WriteLiteral("        <p>---------------------------------------------------------------------------------------</p>\r\n        <h4>");
            EndContext();
            BeginContext(176, 19, false);
#line 6 "C:\Users\Fred\Documents\C#\Wall\Views\Message\MessageListPartial.cshtml"
       Write(mess.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(195, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(197, 18, false);
#line 6 "C:\Users\Fred\Documents\C#\Wall\Views\Message\MessageListPartial.cshtml"
                            Write(mess.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(215, 19, true);
            WriteLiteral("</h4>\r\n        <h5>");
            EndContext();
            BeginContext(235, 19, false);
#line 7 "C:\Users\Fred\Documents\C#\Wall\Views\Message\MessageListPartial.cshtml"
       Write(mess.User.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(254, 18, true);
            WriteLiteral("</h5>\r\n        <p>");
            EndContext();
            BeginContext(273, 12, false);
#line 8 "C:\Users\Fred\Documents\C#\Wall\Views\Message\MessageListPartial.cshtml"
      Write(mess.message);

#line default
#line hidden
            EndContext();
            BeginContext(285, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 9 "C:\Users\Fred\Documents\C#\Wall\Views\Message\MessageListPartial.cshtml"

        
        foreach(var com in @mess.Comments)
        {

#line default
#line hidden
            BeginContext(358, 123, true);
            WriteLiteral("            <p>---------------------------------------------------------------------------------------</p>\r\n            <p>");
            EndContext();
            BeginContext(482, 18, false);
#line 14 "C:\Users\Fred\Documents\C#\Wall\Views\Message\MessageListPartial.cshtml"
          Write(com.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(500, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(502, 17, false);
#line 14 "C:\Users\Fred\Documents\C#\Wall\Views\Message\MessageListPartial.cshtml"
                              Write(com.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(519, 21, true);
            WriteLiteral("</p>\r\n            <p>");
            EndContext();
            BeginContext(541, 11, false);
#line 15 "C:\Users\Fred\Documents\C#\Wall\Views\Message\MessageListPartial.cshtml"
          Write(com.comment);

#line default
#line hidden
            EndContext();
            BeginContext(552, 21, true);
            WriteLiteral("</p>\r\n            <p>");
            EndContext();
            BeginContext(574, 13, false);
#line 16 "C:\Users\Fred\Documents\C#\Wall\Views\Message\MessageListPartial.cshtml"
          Write(com.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(587, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 17 "C:\Users\Fred\Documents\C#\Wall\Views\Message\MessageListPartial.cshtml"
            
        }

#line default
#line hidden
            BeginContext(618, 104, true);
            WriteLiteral("        <p>---------------------------------------------------------------------------------------</p>\r\n");
            EndContext();
            BeginContext(733, 282, false);
#line 21 "C:\Users\Fred\Documents\C#\Wall\Views\Message\MessageListPartial.cshtml"
   Write(Html.Partial(
                    "CommentFormPartial.cshtml",
                    new ViewDataDictionary(this.Vi‌​ewData) {
                        {
                        "messageid", @mess.messageId 
                        } 
                    }
                    ));

#line default
#line hidden
            EndContext();
#line 28 "C:\Users\Fred\Documents\C#\Wall\Views\Message\MessageListPartial.cshtml"
                     ;

    }


#line default
#line hidden
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