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
    
    #line 2 "..\..\UserEmails\CourseInvite.cshtml"
    using SP.DataAccess;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class CourseInvite : SP.Web.UserEmails.CourseParticipantEmailBase
    {
#line hidden
        #line 5 "..\..\UserEmails\CourseInvite.cshtml"
           
    public DateTime? OldStart { get; set; }
    public string Token { get; set; }
    public string GetNotificationUrl(bool canAttend)
    {
        return  $"{BaseUrl}/rsvp?ParticipantId={CourseParticipant.ParticipantId:N}&CourseId={CourseParticipant.CourseId:N}&Attending={(canAttend ? '1' : '0')}&Token={Token}";
    }

        #line default
        #line hidden
        
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 13 "..\..\UserEmails\CourseInvite.cshtml"
   
    Layout = new SP.Web.UserEmails.LayoutTemplate { Title = "Course Invitation" };

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..\UserEmails\CourseInvite.cshtml"
 if (CourseParticipant.Course.Cancelled)
    {

            
            #line default
            #line hidden
WriteLiteral("    <table");

WriteLiteral(" class=\"callout\"");

WriteLiteral(" style=\"Margin-bottom: 16px; border-collapse: collapse; border-spacing: 0; margin" +
"-bottom: 16px; padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral("><tr");

WriteLiteral(" style=\"padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral("><th");

WriteLiteral(" class=\"callout-inner warning\"");

WriteLiteral(" style=\"Margin: 0; background: #fff3d9; border: 1px solid #996800; color: #fefefe" +
"; font-family: Helvetica, Arial, sans-serif; font-size: 16px; font-weight: norma" +
"l; line-height: 1.3; margin: 0; padding: 10px; text-align: left; width: 100%;\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(" style=\"Margin: 0; Margin-bottom: 10px; color: #0a0a0a; font-family: Helvetica, A" +
"rial, sans-serif; font-size: 20px; font-weight: normal; line-height: 1.6; margin" +
": 0; margin-bottom: 10px; padding: 0; text-align: left;\"");

WriteLiteral(">\r\n            A ");

            
            #line 20 "..\..\UserEmails\CourseInvite.cshtml"
         Write(CourseParticipant.Course.CourseFormat.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n            (");

            
            #line 21 "..\..\UserEmails\CourseInvite.cshtml"
        Write(CourseParticipant.Course.CourseFormat.CourseType.Description);

            
            #line default
            #line hidden
WriteLiteral(")\r\n");

            
            #line 22 "..\..\UserEmails\CourseInvite.cshtml"
            
            
            #line default
            #line hidden
            
            #line 22 "..\..\UserEmails\CourseInvite.cshtml"
             if (!CourseParticipant.Course.CourseFormat.CourseType.Description.EndsWith("course", StringComparison.OrdinalIgnoreCase))
            {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("Course\r\n");

            
            #line 25 "..\..\UserEmails\CourseInvite.cshtml"
            } 

            
            #line default
            #line hidden
WriteLiteral("            for which you were a ");

            
            #line 26 "..\..\UserEmails\CourseInvite.cshtml"
                             Write(CourseParticipant.IsFaculty ? "faculty member" : "participant");

            
            #line default
            #line hidden
WriteLiteral(" has been <strong>CANCELLED</strong>.\r\n        </p>\r\n        <p");

WriteLiteral(" style=\"Margin: 0; Margin-bottom: 10px; color: #0a0a0a; font-family: Helvetica, A" +
"rial, sans-serif; font-size: 16px; font-weight: normal; line-height: 1.3; margin" +
": 0; margin-bottom: 10px; padding: 0; text-align: left;\"");

WriteLiteral(">Details of the cancelled course are:</p>\r\n    </th><th");

WriteLiteral(" class=\"expander\"");

WriteLiteral(" style=\"Margin: 0; color: #0a0a0a; font-family: Helvetica, Arial, sans-serif; fon" +
"t-size: 16px; font-weight: normal; line-height: 1.3; margin: 0; padding: 0 !impo" +
"rtant; text-align: left; visibility: hidden; width: 0;\"");

WriteLiteral("></th></tr></table>\r\n");

            
            #line 30 "..\..\UserEmails\CourseInvite.cshtml"
}
else
{
    if (OldStart.HasValue)
    {

            
            #line default
            #line hidden
WriteLiteral("        <table");

WriteLiteral(" class=\"callout\"");

WriteLiteral(" style=\"Margin-bottom: 16px; border-collapse: collapse; border-spacing: 0; margin" +
"-bottom: 16px; padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral("><tr");

WriteLiteral(" style=\"padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral("><th");

WriteLiteral(" class=\"callout-inner danger\"");

WriteLiteral(" style=\"Margin: 0; background: #fefefe; border: 1px solid #cbcbcb; color: #0a0a0a" +
"; font-family: Helvetica, Arial, sans-serif; font-size: 16px; font-weight: norma" +
"l; line-height: 1.3; margin: 0; padding: 10px; text-align: left; width: 100%;\"");

WriteLiteral(">\r\n            <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(" style=\"Margin: 0; Margin-bottom: 10px; color: #0a0a0a; font-family: Helvetica, A" +
"rial, sans-serif; font-size: 20px; font-weight: normal; line-height: 1.6; margin" +
": 0; margin-bottom: 10px; padding: 0; text-align: left;\"");

WriteLiteral(">\r\n                Please note the <em>change in schedule</em> for this event!\r\n " +
"               <strong>\r\n                    The new start is\r\n");

WriteLiteral("                    ");

            
            #line 40 "..\..\UserEmails\CourseInvite.cshtml"
               Write(string.Format(FormatProvider, "{0:D} at {0:t}", CourseParticipant.IsFaculty?CourseParticipant.Course.StartFacultyLocal: CourseParticipant.Course.StartParticipantLocal()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </strong>.\r\n            </p>\r\n            <p");

WriteLiteral(" style=\"Margin: 0; Margin-bottom: 10px; color: #0a0a0a; font-family: Helvetica, A" +
"rial, sans-serif; font-size: 16px; font-weight: normal; line-height: 1.3; margin" +
": 0; margin-bottom: 10px; padding: 0; text-align: left;\"");

WriteLiteral("><small");

WriteLiteral(" style=\"color: #cacaca; font-size: 80%;\"");

WriteLiteral(">(Note the change from the <strong>old</strong> start of ");

            
            #line 43 "..\..\UserEmails\CourseInvite.cshtml"
                                                                                                                                                                                                                                                                                                                                          Write(string.Format(FormatProvider, "{0:D} at {0:t}", OldStart.Value));

            
            #line default
            #line hidden
WriteLiteral(")</small></p>\r\n        </th><th");

WriteLiteral(" class=\"expander\"");

WriteLiteral(" style=\"Margin: 0; color: #0a0a0a; font-family: Helvetica, Arial, sans-serif; fon" +
"t-size: 16px; font-weight: normal; line-height: 1.3; margin: 0; padding: 0 !impo" +
"rtant; text-align: left; visibility: hidden; width: 0;\"");

WriteLiteral("></th></tr></table>\r\n");

WriteLiteral("        <hr>\r\n");

            
            #line 46 "..\..\UserEmails\CourseInvite.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <table");

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

WriteLiteral(">\r\n        <p");

WriteLiteral(" style=\"Margin: 0; Margin-bottom: 10px; color: #0a0a0a; font-family: Helvetica, A" +
"rial, sans-serif; font-size: 16px; font-weight: normal; line-height: 1.3; margin" +
": 0; margin-bottom: 10px; padding: 0; text-align: left;\"");

WriteLiteral(">\r\n            You have been added as a ");

            
            #line 49 "..\..\UserEmails\CourseInvite.cshtml"
                                 Write(CourseParticipant.IsFaculty ? "faculty member" : "participant");

            
            #line default
            #line hidden
WriteLiteral(" to an upcoming\r\n");

WriteLiteral("            ");

            
            #line 50 "..\..\UserEmails\CourseInvite.cshtml"
       Write(CourseParticipant.Course.CourseFormat.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n            (");

            
            #line 51 "..\..\UserEmails\CourseInvite.cshtml"
        Write(CourseParticipant.Course.CourseFormat.CourseType.Description);

            
            #line default
            #line hidden
WriteLiteral(")\r\n");

            
            #line 52 "..\..\UserEmails\CourseInvite.cshtml"
            
            
            #line default
            #line hidden
            
            #line 52 "..\..\UserEmails\CourseInvite.cshtml"
             if (!CourseParticipant.Course.CourseFormat.CourseType.Description.EndsWith("course", StringComparison.OrdinalIgnoreCase))
            {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("Course\r\n");

            
            #line 55 "..\..\UserEmails\CourseInvite.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </p>\r\n        <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(" style=\"Margin: 0; Margin-bottom: 10px; color: #0a0a0a; font-family: Helvetica, A" +
"rial, sans-serif; font-size: 20px; font-weight: normal; line-height: 1.6; margin" +
": 0; margin-bottom: 10px; padding: 0; text-align: left;\"");

WriteLiteral(">Please check the details below and then confirm your availability.</p>\r\n    </th" +
"><th");

WriteLiteral(" class=\"expander\"");

WriteLiteral(" style=\"Margin: 0; color: #0a0a0a; font-family: Helvetica, Arial, sans-serif; fon" +
"t-size: 16px; font-weight: normal; line-height: 1.3; margin: 0; padding: 0 !impo" +
"rtant; text-align: left; visibility: hidden; width: 0;\"");

WriteLiteral("></th></tr></table>\r\n");

            
            #line 59 "..\..\UserEmails\CourseInvite.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<dl>\r\n    <dt>When</dt>\r\n    <dd>\r\n        <p");

WriteLiteral(" style=\"Margin: 0; Margin-bottom: 10px; color: #0a0a0a; font-family: Helvetica, A" +
"rial, sans-serif; font-size: 16px; font-weight: normal; line-height: 1.3; margin" +
": 0; margin-bottom: 10px; padding: 0; text-align: left;\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 64 "..\..\UserEmails\CourseInvite.cshtml"
       Write(string.Format(FormatProvider, "{0:D} at {0:t}", CourseParticipant.IsFaculty ? CourseParticipant.Course.StartFacultyLocal : CourseParticipant.Course.StartParticipantLocal()));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </p>\r\n        <p");

WriteLiteral(" class=\"details\"");

WriteLiteral(" style=\"Margin: 0; Margin-bottom: 10px; color: #0a0a0a; font-family: Helvetica, A" +
"rial, sans-serif; font-size: 16px; font-weight: normal; line-height: 1.3; margin" +
": 0; margin-bottom: 10px; padding: 0; text-align: left;\"");

WriteLiteral(">\r\n            (finishing ");

            
            #line 67 "..\..\UserEmails\CourseInvite.cshtml"
                   Write((CourseParticipant.IsFaculty?CourseParticipant.Course.FinishCourseFacultyLocal(): CourseParticipant.Course.FinishCourseParticipantLocal()).ToString("g",FormatProvider));

            
            #line default
            #line hidden
WriteLiteral(")\r\n        </p>\r\n    </dd>\r\n\r\n    <dt>Department</dt>\r\n    <dd>\r\n");

WriteLiteral("        ");

            
            #line 73 "..\..\UserEmails\CourseInvite.cshtml"
   Write(CourseParticipant.Course.Department.Institution.Name);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 73 "..\..\UserEmails\CourseInvite.cshtml"
                                                           Write(CourseParticipant.Course.Department.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </dd>\r\n\r\n    <dt>Where</dt>\r\n    <dd>\r\n        <p");

WriteLiteral(" style=\"Margin: 0; Margin-bottom: 10px; color: #0a0a0a; font-family: Helvetica, A" +
"rial, sans-serif; font-size: 16px; font-weight: normal; line-height: 1.3; margin" +
": 0; margin-bottom: 10px; padding: 0; text-align: left;\"");

WriteLiteral(">");

            
            #line 78 "..\..\UserEmails\CourseInvite.cshtml"
                                                                                                                                                                                                                               Write(CourseParticipant.Course.Room.ShortDescription);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <p");

WriteLiteral(" class=\"details\"");

WriteLiteral(" style=\"Margin: 0; Margin-bottom: 10px; color: #0a0a0a; font-family: Helvetica, A" +
"rial, sans-serif; font-size: 16px; font-weight: normal; line-height: 1.3; margin" +
": 0; margin-bottom: 10px; padding: 0; text-align: left;\"");

WriteLiteral(">(");

            
            #line 79 "..\..\UserEmails\CourseInvite.cshtml"
                                                                                                                                                                                                                                                Write(CourseParticipant.Course.Room.FullDescription);

            
            #line default
            #line hidden
WriteLiteral(")</p>\r\n    </dd>\r\n</dl>\r\n<h5");

WriteLiteral(" style=\"Margin: 0; Margin-bottom: 10px; color: inherit; font-family: Helvetica, A" +
"rial, sans-serif; font-size: 20px; font-weight: normal; line-height: 1.3; margin" +
": 0; margin-bottom: 10px; padding: 0; text-align: left; word-wrap: normal;\"");

WriteLiteral(">Organiser(s)</h5>\r\n<ul>\r\n");

            
            #line 84 "..\..\UserEmails\CourseInvite.cshtml"
    
            
            #line default
            #line hidden
            
            #line 84 "..\..\UserEmails\CourseInvite.cshtml"
     foreach (var o in (from cp in CourseParticipant.Course.CourseParticipants where cp.IsOrganiser select cp.Participant))
    {

            
            #line default
            #line hidden
WriteLiteral("        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 8278), Tuple.Create("\"", 8298)
            
            #line 87 "..\..\UserEmails\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 8285), Tuple.Create<System.Object, System.Int32>(GetMailTo(o)
            
            #line default
            #line hidden
, 8285), false)
);

WriteLiteral(" style=\"Margin: 0; color: #2199e8; font-family: Helvetica, Arial, sans-serif; fon" +
"t-weight: normal; line-height: 1.3; margin: 0; padding: 0; text-align: left; tex" +
"t-decoration: none;\"");

WriteLiteral(">");

            
            #line 87 "..\..\UserEmails\CourseInvite.cshtml"
                                                                                                                                                                                                                    Write(o.FullName);

            
            #line default
            #line hidden
WriteLiteral("</a> ");

            
            #line 87 "..\..\UserEmails\CourseInvite.cshtml"
                                                                                                                                                                                                                                    Write(o.PhoneNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </li>\r\n");

            
            #line 89 "..\..\UserEmails\CourseInvite.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n<table");

WriteLiteral(" class=\"row\"");

WriteLiteral(" style=\"border-collapse: collapse; border-spacing: 0; padding: 0; position: relat" +
"ive; text-align: left; vertical-align: top; width: 100%;\"");

WriteLiteral("><tbody><tr");

WriteLiteral(" style=\"padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral(">\r\n    <th");

WriteLiteral(" class=\"small-12 large-12 columns first last\"");

WriteLiteral(@" style=""Margin: 0 auto; color: #0a0a0a; font-family: Helvetica, Arial, sans-serif; font-size: 16px; font-weight: normal; line-height: 1.3; margin: 0 auto; padding: 0; padding-bottom: 16px; padding-left: 16px; padding-right: 16px; text-align: left; width: 564px;""");

WriteLiteral("><table");

WriteLiteral(" style=\"border-collapse: collapse; border-spacing: 0; padding: 0; text-align: lef" +
"t; vertical-align: top; width: 100%;\"");

WriteLiteral("><tr");

WriteLiteral(" style=\"padding: 0; text-align: left; vertical-align: top;\"");

WriteLiteral("><th");

WriteLiteral(" style=\"Margin: 0; color: #0a0a0a; font-family: Helvetica, Arial, sans-serif; fon" +
"t-size: 16px; font-weight: normal; line-height: 1.3; margin: 0; padding: 0; text" +
"-align: left;\"");

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 9465), Tuple.Create("\"", 9560)
            
            #line 93 "..\..\UserEmails\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 9472), Tuple.Create<System.Object, System.Int32>(BaseUrl
            
            #line default
            #line hidden
, 9472), false)
, Tuple.Create(Tuple.Create("", 9480), Tuple.Create("/api/CoursePlanning/MyCalendar/", 9480), true)
            
            #line 93 "..\..\UserEmails\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 9511), Tuple.Create<System.Object, System.Int32>(CourseParticipant.ParticipantId.ToString()
            
            #line default
            #line hidden
, 9511), false)
, Tuple.Create(Tuple.Create("", 9556), Tuple.Create(".ics", 9556), true)
);

WriteLiteral(" style=\"Margin: 0; color: #2199e8; font-family: Helvetica, Arial, sans-serif; fon" +
"t-weight: normal; line-height: 1.3; margin: 0; padding: 0; text-align: left; tex" +
"t-decoration: none;\"");

WriteLiteral(">\r\n            <img");

WriteLiteral(" alt=\"Add To Calendar\"");

WriteLiteral(" title=\"Update my calendar\"");

WriteAttribute("src", Tuple.Create(" src=\"", 9810), Tuple.Create("\"", 9865)
            
            #line 94 "..\..\UserEmails\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 9816), Tuple.Create<System.Object, System.Int32>(BaseInsecureUrl
            
            #line default
            #line hidden
, 9816), false)
, Tuple.Create(Tuple.Create("", 9832), Tuple.Create("/Content/Images/AddToCalendar.jpg", 9832), true)
);

WriteLiteral(" width=\"166\"");

WriteLiteral(" height=\"58\"");

WriteLiteral(" style=\"-ms-interpolation-mode: bicubic; border: none; clear: both; display: bloc" +
"k; max-width: 100%; outline: none; text-decoration: none; width: auto;\"");

WriteLiteral(">\r\n        </a>\r\n    </th>\r\n<th");

WriteLiteral(" class=\"expander\"");

WriteLiteral(" style=\"Margin: 0; color: #0a0a0a; font-family: Helvetica, Arial, sans-serif; fon" +
"t-size: 16px; font-weight: normal; line-height: 1.3; margin: 0; padding: 0 !impo" +
"rtant; text-align: left; visibility: hidden; width: 0;\"");

WriteLiteral("></th></tr></table></th>\r\n</tr></tbody></table>\r\n\r\n<hr>\r\n\r\n<table");

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

WriteAttribute("href", Tuple.Create(" href=\"", 12537), Tuple.Create("\"", 12569)
            
            #line 105 "..\..\UserEmails\CourseInvite.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 12544), Tuple.Create<System.Object, System.Int32>(GetNotificationUrl(true)
            
            #line default
            #line hidden
, 12544), false)
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

WriteAttribute("href", Tuple.Create(" href=\"", 14888), Tuple.Create("\"", 14921)
            
            #line 110 "..\..\UserEmails\CourseInvite.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 14895), Tuple.Create<System.Object, System.Int32>(GetNotificationUrl(false)
            
            #line default
            #line hidden
, 14895), false)
);

WriteLiteral(@" style=""Margin: 0; border: 0 solid #ec5840; border-radius: 3px; color: #fefefe; display: inline-block; font-family: Helvetica, Arial, sans-serif; font-size: 16px; font-weight: bold; line-height: 1.3; margin: 0; padding: 8px 16px 8px 16px; text-align: left; text-decoration: none;""");

WriteLiteral(">I\'m Unavailable</a></td></tr></table></td></tr></table>\r\n        </center>\r\n    " +
"</th></tr></table></th>\r\n</tr></tbody></table>");

        }
    }
}
#pragma warning restore 1591
