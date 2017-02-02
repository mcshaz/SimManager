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
    
    #line 2 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
    using SP.DataAccess;
    
    #line default
    #line hidden
    
    #line 3 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
    using SP.Dto.Utilities;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class NotifyNewRegistrationRequest : SP.Web.UserEmails.EmailBase
    {
#line hidden
        #line 5 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
           
    public Participant PersonRequesting { get; set; }

        #line default
        #line hidden
        
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 8 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
  
    Layout = new SP.Web.UserEmails.LayoutTemplate
    {
        Title = "Registration Request"
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n<row>\r\n    <columns");

WriteLiteral(" large=\"12\"");

WriteLiteral(">\r\n        <callout");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">\r\n            <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(@">
                A request has been submitted to register a new institution, department &amp; user - details below.
            </p>
        </callout>
    </columns>
</row>
<row>
    <columns>
        <h3>
            Institution
        </h3>
        <dl>
            <dt>
                Name
            </dt>
            <dd>
");

WriteLiteral("                ");

            
            #line 33 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
           Write(PersonRequesting.Department.Institution.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Abbreviation\r\n            " +
"</dt>\r\n            <dd>\r\n");

WriteLiteral("                ");

            
            #line 39 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
           Write(PersonRequesting.Department.Institution.Abbreviation);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Locale Code\r\n            <" +
"/dt>\r\n            <dd>\r\n");

WriteLiteral("                ");

            
            #line 45 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
           Write(PersonRequesting.Department.Institution.LocaleCode);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Time Zone\r\n            </d" +
"t>\r\n            <dd>\r\n");

WriteLiteral("                ");

            
            #line 51 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
           Write(PersonRequesting.Department.Institution.TimeZone.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dd>\r\n");

            
            #line 53 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
            
            
            #line default
            #line hidden
            
            #line 53 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
             if (!string.IsNullOrEmpty(PersonRequesting.Department.Institution.HomepageUrl))
            {

            
            #line default
            #line hidden
WriteLiteral("                <dt>\r\n                    URL\r\n                </dt>\r\n");

WriteLiteral("                <dd>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1638), Tuple.Create("\"", 1697)
            
            #line 59 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
, Tuple.Create(Tuple.Create("", 1645), Tuple.Create<System.Object, System.Int32>(PersonRequesting.Department.Institution.HomepageUrl
            
            #line default
            #line hidden
, 1645), false)
);

WriteLiteral(">");

            
            #line 59 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
                                                                              Write(PersonRequesting.Department.Institution.HomepageUrl);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    <small>please examine URL carefully before clicking on " +
"the link</small>\r\n                </dd>\r\n");

            
            #line 62 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 63 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
             if (PersonRequesting.Department.Institution.Latitude.HasValue && PersonRequesting.Department.Institution.Longitude.HasValue)
            {

            
            #line default
            #line hidden
WriteLiteral("                <dt>\r\n                    Location\r\n                </dt>\r\n");

WriteLiteral("                <dd>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2161), Tuple.Create("\"", 2324)
, Tuple.Create(Tuple.Create("", 2168), Tuple.Create("https://www.google.com/maps/place/", 2168), true)
            
            #line 69 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
, Tuple.Create(Tuple.Create("", 2202), Tuple.Create<System.Object, System.Int32>(PersonRequesting.Department.Institution.Latitude.ToString()
            
            #line default
            #line hidden
, 2202), false)
, Tuple.Create(Tuple.Create("", 2262), Tuple.Create(",", 2262), true)
            
            #line 69 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
                                            , Tuple.Create(Tuple.Create("", 2263), Tuple.Create<System.Object, System.Int32>(PersonRequesting.Department.Institution.Longitude.ToString()
            
            #line default
            #line hidden
, 2263), false)
);

WriteLiteral(">Google Maps</a>\r\n                </dd>\r\n");

            
            #line 71 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 72 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
             if (!string.IsNullOrWhiteSpace(PersonRequesting.Department.Institution.LogoImageFileName))
            {

            
            #line default
            #line hidden
WriteLiteral("                <dt>\r\n                    Logo\r\n                </dt>\r\n");

WriteLiteral("                <dd>\r\n                    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2618), Tuple.Create("\"", 2743)
            
            #line 78 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
, Tuple.Create(Tuple.Create("", 2624), Tuple.Create<System.Object, System.Int32>(BaseInsecureUrl + '/' + IAssociateFileTools.ServerPathToUrl(PersonRequesting.Department.Institution.GetServerPath())
            
            #line default
            #line hidden
, 2624), false)
);

WriteLiteral(" width=\"200\"");

WriteAttribute("alt", Tuple.Create(" alt=\"", 2756), Tuple.Create("\"", 2816)
, Tuple.Create(Tuple.Create("", 2762), Tuple.Create("logo", 2762), true)
, Tuple.Create(Tuple.Create(" ", 2766), Tuple.Create("for", 2767), true)
            
            #line 78 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
                                                                                                , Tuple.Create(Tuple.Create(" ", 2770), Tuple.Create<System.Object, System.Int32>(PersonRequesting.Department.Institution.Name
            
            #line default
            #line hidden
, 2771), false)
);

WriteLiteral("/>\r\n                </dd>\r\n");

            
            #line 80 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 81 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
             if (!string.IsNullOrWhiteSpace(PersonRequesting.Department.Institution.About))
            {

            
            #line default
            #line hidden
WriteLiteral("                <dt>\r\n                    About\r\n                </dt>\r\n");

WriteLiteral("                <dd>\r\n");

WriteLiteral("                    ");

            
            #line 87 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
               Write(PersonRequesting.Department.Institution.About);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </dd>\r\n");

            
            #line 89 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </dl>\r\n    </columns>\r\n</row>\r\n<row>\r\n    <columns>\r\n        <h3>\r\n      " +
"      Department\r\n        </h3>\r\n        <dl>\r\n            <dt>\r\n               " +
" Name\r\n            </dt>\r\n            <dd>\r\n");

WriteLiteral("                ");

            
            #line 103 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
           Write(PersonRequesting.Department.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Abbreviation\r\n            " +
"</dt>\r\n            <dd>\r\n");

WriteLiteral("                ");

            
            #line 109 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
           Write(PersonRequesting.Department.Abbreviation);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </columns>\r\n</row>\r\n<row>\r\n    <columns>\r" +
"\n        <h3>\r\n            Proposed administrator\r\n        </h3>\r\n        <dl>\r\n" +
"            <dt>\r\n                Name\r\n            </dt>\r\n            <dd>\r\n");

WriteLiteral("                ");

            
            #line 124 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
           Write(PersonRequesting.FullName);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Email\r\n            </dt>\r\n" +
"            <dd>\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3981), Tuple.Create("\"", 4016)
            
            #line 130 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
, Tuple.Create(Tuple.Create("", 3988), Tuple.Create<System.Object, System.Int32>(GetMailTo(PersonRequesting)
            
            #line default
            #line hidden
, 3988), false)
);

WriteLiteral(">");

            
            #line 130 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
                                                  Write(PersonRequesting.Email);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 130 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
                                                                          Write(PersonRequesting.AlternateEmail);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </dd>\r\n");

            
            #line 132 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
            
            
            #line default
            #line hidden
            
            #line 132 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
             if (!string.IsNullOrEmpty(PersonRequesting.PhoneNumber))
            {

            
            #line default
            #line hidden
WriteLiteral("                <dt>\r\n                    Phone Number\r\n                </dt>\r\n");

WriteLiteral("                <dd>\r\n");

WriteLiteral("                    ");

            
            #line 138 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
               Write(PersonRequesting.PhoneNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </dd>\r\n");

            
            #line 140 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <dt>\r\n                Professional Role\r\n            </dt>\r\n         " +
"   <dd>\r\n                <strong>");

            
            #line 145 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
                   Write(PersonRequesting.ProfessionalRole.Category.ToString());

            
            #line default
            #line hidden
WriteLiteral("</strong> - ");

            
            #line 145 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
                                                                                     Write(PersonRequesting.ProfessionalRole.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        \r\n    </columns>\r\n</row>\r\n<row>\r\n    " +
"<columns>\r\n        <hr />\r\n        <callout");

WriteLiteral(" class=\"secondary\"");

WriteLiteral(">\r\n            <p>\r\n                In order to approve or delete this request, p" +
"lease go to the <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4842), Tuple.Create("\"", 4938)
            
            #line 156 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
      , Tuple.Create(Tuple.Create("", 4849), Tuple.Create<System.Object, System.Int32>(BaseUrl
            
            #line default
            #line hidden
, 4849), false)
, Tuple.Create(Tuple.Create("", 4857), Tuple.Create("/reviewRegistrationRequest/", 4857), true)
            
            #line 156 "..\..\UserEmails\Inky\NotifyNewRegistrationRequest.cshtml"
                                         , Tuple.Create(Tuple.Create("", 4884), Tuple.Create<System.Object, System.Int32>(PersonRequesting.Department.Institution.Id.ToString()
            
            #line default
            #line hidden
, 4884), false)
);

WriteLiteral(">Review Registration Requests</a> page (will require login details).\r\n           " +
" </p>\r\n        </callout>\r\n    </columns>\r\n</row>");

        }
    }
}
#pragma warning restore 1591
