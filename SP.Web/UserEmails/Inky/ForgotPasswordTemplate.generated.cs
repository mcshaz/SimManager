﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SP.Web.UserEmails.Inky
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class ForgotPasswordTemplate : SP.Web.UserEmails.EmailBase
    {
#line hidden
        #line 3 "..\..\UserEmails\Inky\ForgotPasswordTemplate.cshtml"
            
    public string Token { get; set; }
    public Guid UserId { get; set; }

    public string AsQueryString()
    {
        return BaseUrl + "/resetPassword?token=" + System.Web.HttpUtility.UrlEncode(Token) + "&userId=" + UserId.ToString();
    }

        #line default
        #line hidden
        
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 13 "..\..\UserEmails\Inky\ForgotPasswordTemplate.cshtml"
   Layout = new SP.Web.UserEmails.LayoutTemplate { Title = "Forgot Password" }; 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<row>\r\n    <columns");

WriteLiteral(" large=\"12\"");

WriteLiteral(">\r\n        <spacer");

WriteLiteral(" size=\"16\"");

WriteLiteral("></spacer>\r\n\r\n        <h1");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">Forgot Your Password?</h1>\r\n\r\n        <spacer");

WriteLiteral(" size=\"16\"");

WriteLiteral("></spacer>\r\n\r\n        <p");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">Click the link below to reset your password.</p>\r\n        <button");

WriteLiteral(" class=\"large expand\"");

WriteAttribute("href", Tuple.Create(" href=\"", 780), Tuple.Create("\"", 805)
            
            #line 24 "..\..\UserEmails\Inky\ForgotPasswordTemplate.cshtml"
, Tuple.Create(Tuple.Create("", 787), Tuple.Create<System.Object, System.Int32>(AsQueryString()
            
            #line default
            #line hidden
, 787), false)
);

WriteLiteral(">Reset Password</button>\r\n\r\n    </columns>\r\n</row>\r\n");

        }
    }
}
#pragma warning restore 1591
