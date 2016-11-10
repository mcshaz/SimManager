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

namespace SP.Web.UserEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\UserEmails\ReverseConfirmation.cshtml"
    using SP.DataAccess;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class ReverseConfirmation : SP.Web.UserEmails.CourseParticipantEmailBase
    {
#line hidden
        #line 5 "..\..\UserEmails\ReverseConfirmation.cshtml"
           
    public string AuthorizationToken { get; set; }
    public string GetNotificationUrl(bool canAttend)
    {
        return BaseUrl + $"#/rsvp?ParticipantId={CourseParticipant.ParticipantId}&CourseId={CourseParticipant.CourseId}&Attending={(canAttend ? '1' : '0')}&Auth=" + AuthorizationToken;
    }

        #line default
        #line hidden
        
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 12 "..\..\UserEmails\ReverseConfirmation.cshtml"
   Layout = new SP.Web.UserEmails.LayoutTemplate
    {
        Title = string.Format(FormatProvider, "participant request to alter confirmation for {0} on {1:d}",
                                     CourseParticipant.Course.CourseFormat.CourseType.Abbreviation,
                                     CourseParticipant.Course.StartLocal)
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<table");

WriteLiteral(" class=\"callout\"");

WriteLiteral(" style=\"Margin-bottom: 16px; border-collapse: collapse; border-spacing: 0; margin" +
"-bottom: 16px; padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral("><tr");

WriteLiteral(" style=\"padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral("><th");

WriteLiteral(" class=\"callout-inner primary\"");

WriteLiteral(" style=\"Margin: 0; background: #def0fc; border: 1px solid #444444; color: #0a0a0a" +
"; font-family: Helvetica, Arial, sans-serif; font-size: 16px; font-weight: norma" +
"l; line-height: 1.3; margin: 0; padding: 10px; text-align: left; width: 100%;\"");

WriteLiteral(">\r\n    <table");

WriteLiteral(" class=\"row\"");

WriteLiteral(" style=\"border-collapse: collapse; border-spacing: 0; padding: 0; position: relat" +
"ive; text-align: left; vertical-align: top; width: 100%;\"");

WriteLiteral("><tbody><tr");

WriteLiteral(" style=\"padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" style=\"Margin: 0; Margin-bottom: 10px; color: #0a0a0a; font-family: Helvetica, A" +
"rial, sans-serif; font-size: 16px; font-weight: normal; line-height: 1.3; margin" +
": 0; margin-bottom: 10px; padding: 0; text-align: left;\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 23 "..\..\UserEmails\ReverseConfirmation.cshtml"
       Write(CourseParticipant.Participant.FullName);

            
            #line default
            #line hidden
WriteLiteral("\r\n            <small");

WriteLiteral(" style=\"color: #cacaca; font-size: 80%;\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 25 "..\..\UserEmails\ReverseConfirmation.cshtml"
           Write(CourseParticipant.Participant.ProfessionalRole.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </small>\r\n            had been confirmed as ");

            
            #line 27 "..\..\UserEmails\ReverseConfirmation.cshtml"
                              Write(CourseParticipant.IsConfirmed.Value?"attending":"unable to attend");

            
            #line default
            #line hidden
WriteLiteral("\r\n            as a ");

            
            #line 28 "..\..\UserEmails\ReverseConfirmation.cshtml"
             Write(CourseParticipant.IsFaculty?"faculty member":"participant");

            
            #line default
            #line hidden
WriteLiteral("\r\n            in the ");

            
            #line 29 "..\..\UserEmails\ReverseConfirmation.cshtml"
              Write(CourseName);

            
            #line default
            #line hidden
WriteLiteral(" on the ");

            
            #line 29 "..\..\UserEmails\ReverseConfirmation.cshtml"
                                 Write(CourseParticipant.Course.StartLocal.ToString("g",FormatProvider));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </p>\r\n        <p");

WriteLiteral(" style=\"Margin: 0; Margin-bottom: 10px; color: #0a0a0a; font-family: Helvetica, A" +
"rial, sans-serif; font-size: 16px; font-weight: normal; line-height: 1.3; margin" +
": 0; margin-bottom: 10px; padding: 0; text-align: left;\"");

WriteLiteral(">\r\n            However, he/she would like to <strong>change this response</strong" +
"> to being \r\n");

WriteLiteral("            ");

            
            #line 33 "..\..\UserEmails\ReverseConfirmation.cshtml"
        Write(CourseParticipant.IsConfirmed.Value?"unable":"able");

            
            #line default
            #line hidden
WriteLiteral(" to attend.\r\n        </p>\r\n    </tr></tbody></table>\r\n</th><th");

WriteLiteral(" class=\"expander\"");

WriteLiteral(" style=\"Margin: 0; color: #0a0a0a; font-family: Helvetica, Arial, sans-serif; fon" +
"t-size: 16px; font-weight: normal; line-height: 1.3; margin: 0; padding: 0 !impo" +
"rtant; text-align: left; visibility: hidden; width: 0;\"");

WriteLiteral("></th></tr></table>\r\n<table");

WriteLiteral(" class=\"row\"");

WriteLiteral(" style=\"border-collapse: collapse; border-spacing: 0; padding: 0; position: relat" +
"ive; text-align: left; vertical-align: top; width: 100%;\"");

WriteLiteral("><tbody><tr");

WriteLiteral(" style=\"padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral(">\r\n    <p");

WriteLiteral(" class=\"small\"");

WriteLiteral(" style=\"Margin: 0; Margin-bottom: 10px; color: #0a0a0a; font-family: Helvetica, A" +
"rial, sans-serif; font-size: 16px; font-weight: normal; line-height: 1.3; margin" +
": 0; margin-bottom: 10px; padding: 0; text-align: left;\"");

WriteLiteral("><em>Note:</em> you can also change the confirmation status for any or all partic" +
"ipants by logging in <a");

WriteLiteral(" href=\"<#= GetCourseRef() #>\"");

WriteLiteral(" style=\"Margin: 0; color: #2199e8; font-family: Helvetica, Arial, sans-serif; fon" +
"t-weight: normal; line-height: 1.3; margin: 0; padding: 0; text-align: left; tex" +
"t-decoration: none;\"");

WriteLiteral(">here</a></p>\r\n</tr></tbody></table>\r\n<table");

WriteLiteral(" class=\"row\"");

WriteLiteral(" style=\"border-collapse: collapse; border-spacing: 0; padding: 0; position: relat" +
"ive; text-align: left; vertical-align: top; width: 100%;\"");

WriteLiteral("><tbody><tr");

WriteLiteral(" style=\"padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral(">\r\n    <h3");

WriteLiteral(" style=\"Margin: 0; Margin-bottom: 10px; color: inherit; font-family: Helvetica, A" +
"rial, sans-serif; font-size: 28px; font-weight: normal; line-height: 1.3; margin" +
": 0; margin-bottom: 10px; padding: 0; text-align: left; word-wrap: normal;\"");

WriteLiteral(">Contact details for ");

            
            #line 41 "..\..\UserEmails\ReverseConfirmation.cshtml"
                                                                                                                                                                                                                                                                   Write(CourseParticipant.Participant.FullName);

            
            #line default
            #line hidden
WriteLiteral(":</h3>\r\n    <dl>\r\n        <dt>Email</dt>\r\n        <dd><a");

WriteAttribute("href", Tuple.Create(" href=\"", 4490), Tuple.Create("\"", 4538)
            
            #line 44 "..\..\UserEmails\ReverseConfirmation.cshtml"
, Tuple.Create(Tuple.Create("", 4497), Tuple.Create<System.Object, System.Int32>(GetMailTo(CourseParticipant.Participant)
            
            #line default
            #line hidden
, 4497), false)
);

WriteLiteral(" style=\"Margin: 0; color: #2199e8; font-family: Helvetica, Arial, sans-serif; fon" +
"t-weight: normal; line-height: 1.3; margin: 0; padding: 0; text-align: left; tex" +
"t-decoration: none;\"");

WriteLiteral(">");

            
            #line 44 "..\..\UserEmails\ReverseConfirmation.cshtml"
                                                                                                                                                                                                                                                Write(CourseParticipant.Participant.Email);

            
            #line default
            #line hidden
WriteLiteral("</a></dd>\r\n");

            
            #line 45 "..\..\UserEmails\ReverseConfirmation.cshtml"
        
            
            #line default
            #line hidden
            
            #line 45 "..\..\UserEmails\ReverseConfirmation.cshtml"
         if (CourseParticipant.Participant.PhoneNumber != null)
        {

            
            #line default
            #line hidden
WriteLiteral("            <dt>\r\n                Phone\r\n            </dt>\r\n");

WriteLiteral("            <dd>\r\n                CourseParticipant.Participant.PhoneNumber\r\n    " +
"        </dd>\r\n");

            
            #line 53 "..\..\UserEmails\ReverseConfirmation.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </dl>\r\n</tr></tbody></table>\r\n\r\n<hr>\r\n<table");

WriteLiteral(" class=\"row\"");

WriteLiteral(" style=\"border-collapse: collapse; border-spacing: 0; padding: 0; position: relat" +
"ive; text-align: left; vertical-align: top; width: 100%;\"");

WriteLiteral("><tbody><tr");

WriteLiteral(" style=\"padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral(">\r\n    <th");

WriteLiteral(" class=\"small-12 large-6 columns first\"");

WriteLiteral(@" style=""Margin: 0 auto; color: #0a0a0a; font-family: Helvetica, Arial, sans-serif; font-size: 16px; font-weight: normal; line-height: 1.3; margin: 0 auto; padding: 0; padding-bottom: 16px; padding-left: 16px; padding-right: 8px; text-align: left; width: 274px;""");

WriteLiteral("><table");

WriteLiteral(" style=\"border-collapse: collapse; border-spacing: 0; padding: 0; text-align: lef" +
"t; vertical-align: top; width: 100%;\"");

WriteLiteral("><tr");

WriteLiteral(" style=\"padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral("><th");

WriteLiteral(" style=\"Margin: 0; color: #0a0a0a; font-family: Helvetica, Arial, sans-serif; fon" +
"t-size: 16px; font-weight: normal; line-height: 1.3; margin: 0; padding: 0; text" +
"-align: left;\"");

WriteLiteral(">\r\n        <center");

WriteLiteral(" data-parsed=\"\"");

WriteLiteral(" style=\"min-width: 242px; width: 100%;\"");

WriteLiteral(">\r\n            <table");

WriteLiteral(" class=\"button success radius float-center\"");

WriteLiteral(" style=\"Margin: 0 0 16px 0; border-collapse: collapse; border-spacing: 0; float: " +
"none; margin: 0 0 16px 0; padding: 0; text-align: center; vertical-align: top; w" +
"idth: auto;\"");

WriteLiteral("><tr");

WriteLiteral(" style=\"padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral("><td");

WriteLiteral(@" style=""-moz-hyphens: auto; -webkit-hyphens: auto; Margin: 0; border-collapse: collapse !important; color: #0a0a0a; font-family: Helvetica, Arial, sans-serif; font-size: 16px; font-weight: normal; hyphens: auto; line-height: 1.3; margin: 0; padding: 0; text-align: left; vertical-align: top; word-wrap: break-word;""");

WriteLiteral("><table");

WriteLiteral(" style=\"border-collapse: collapse; border-spacing: 0; padding: 0; text-align: lef" +
"t; vertical-align: top; width: 100%;\"");

WriteLiteral("><tr");

WriteLiteral(" style=\"padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral("><td");

WriteLiteral(@" style=""-moz-hyphens: auto; -webkit-hyphens: auto; Margin: 0; background: #3adb76; border: 0px solid #3adb76; border-collapse: collapse !important; border-radius: 3px; color: #fefefe; font-family: Helvetica, Arial, sans-serif; font-size: 16px; font-weight: normal; hyphens: auto; line-height: 1.3; margin: 0; padding: 0; text-align: left; vertical-align: top; word-wrap: break-word;""");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 7225), Tuple.Create("\"", 7257)
            
            #line 61 "..\..\UserEmails\ReverseConfirmation.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 7232), Tuple.Create<System.Object, System.Int32>(GetNotificationUrl(true)
            
            #line default
            #line hidden
, 7232), false)
);

WriteLiteral(@" style=""Margin: 0; border: 0 solid #3adb76; border-radius: 3px; color: #fefefe; display: inline-block; font-family: Helvetica, Arial, sans-serif; font-size: 16px; font-weight: bold; line-height: 1.3; margin: 0; padding: 8px 16px 8px 16px; text-align: left; text-decoration: none;""");

WriteLiteral(">Confirm</a></td></tr></table></td></tr></table>\r\n        </center>\r\n    </th></t" +
"r></table></th>\r\n    <th");

WriteLiteral(" class=\"small-12 large-6 columns last\"");

WriteLiteral(@" style=""Margin: 0 auto; color: #0a0a0a; font-family: Helvetica, Arial, sans-serif; font-size: 16px; font-weight: normal; line-height: 1.3; margin: 0 auto; padding: 0; padding-bottom: 16px; padding-left: 8px; padding-right: 16px; text-align: left; width: 274px;""");

WriteLiteral("><table");

WriteLiteral(" style=\"border-collapse: collapse; border-spacing: 0; padding: 0; text-align: lef" +
"t; vertical-align: top; width: 100%;\"");

WriteLiteral("><tr");

WriteLiteral(" style=\"padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral("><th");

WriteLiteral(" style=\"Margin: 0; color: #0a0a0a; font-family: Helvetica, Arial, sans-serif; fon" +
"t-size: 16px; font-weight: normal; line-height: 1.3; margin: 0; padding: 0; text" +
"-align: left;\"");

WriteLiteral(">\r\n        <center");

WriteLiteral(" data-parsed=\"\"");

WriteLiteral(" style=\"min-width: 242px; width: 100%;\"");

WriteLiteral(">\r\n            <table");

WriteLiteral(" class=\"button alert radius float-center\"");

WriteLiteral(" style=\"Margin: 0 0 16px 0; border-collapse: collapse; border-spacing: 0; float: " +
"none; margin: 0 0 16px 0; padding: 0; text-align: center; vertical-align: top; w" +
"idth: auto;\"");

WriteLiteral("><tr");

WriteLiteral(" style=\"padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral("><td");

WriteLiteral(@" style=""-moz-hyphens: auto; -webkit-hyphens: auto; Margin: 0; border-collapse: collapse !important; color: #0a0a0a; font-family: Helvetica, Arial, sans-serif; font-size: 16px; font-weight: normal; hyphens: auto; line-height: 1.3; margin: 0; padding: 0; text-align: left; vertical-align: top; word-wrap: break-word;""");

WriteLiteral("><table");

WriteLiteral(" style=\"border-collapse: collapse; border-spacing: 0; padding: 0; text-align: lef" +
"t; vertical-align: top; width: 100%;\"");

WriteLiteral("><tr");

WriteLiteral(" style=\"padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral("><td");

WriteLiteral(@" style=""-moz-hyphens: auto; -webkit-hyphens: auto; Margin: 0; background: #ec5840; border: 0px solid #ec5840; border-collapse: collapse !important; border-radius: 3px; color: #fefefe; font-family: Helvetica, Arial, sans-serif; font-size: 16px; font-weight: normal; hyphens: auto; line-height: 1.3; margin: 0; padding: 0; text-align: left; vertical-align: top; word-wrap: break-word;""");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 9576), Tuple.Create("\"", 9609)
            
            #line 66 "..\..\UserEmails\ReverseConfirmation.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 9583), Tuple.Create<System.Object, System.Int32>(GetNotificationUrl(false)
            
            #line default
            #line hidden
, 9583), false)
);

WriteLiteral(@" style=""Margin: 0; border: 0 solid #ec5840; border-radius: 3px; color: #fefefe; display: inline-block; font-family: Helvetica, Arial, sans-serif; font-size: 16px; font-weight: bold; line-height: 1.3; margin: 0; padding: 8px 16px 8px 16px; text-align: left; text-decoration: none;""");

WriteLiteral(">I\'m Unavailable</a></td></tr></table></td></tr></table>\r\n        </center>\r\n    " +
"</th></tr></table></th>\r\n</tr></tbody></table>\r\n\t\t");

        }
    }
}
#pragma warning restore 1591
