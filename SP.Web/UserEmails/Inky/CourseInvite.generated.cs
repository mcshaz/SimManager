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
    
    #line 2 "..\..\UserEmails\Inky\CourseInvite.cshtml"
    using SP.DataAccess;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class CourseInvite : SP.Web.UserEmails.CourseParticipantEmailBase
    {
#line hidden
        #line 5 "..\..\UserEmails\Inky\CourseInvite.cshtml"
           
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

            
            #line 13 "..\..\UserEmails\Inky\CourseInvite.cshtml"
   
    Layout = new SP.Web.UserEmails.LayoutTemplate { Title = "Course Invitation" };

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..\UserEmails\Inky\CourseInvite.cshtml"
 if (CourseParticipant.Course.Cancelled)
    {

            
            #line default
            #line hidden
WriteLiteral("    <callout");

WriteLiteral(" class=\"warning\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(">\r\n            A ");

            
            #line 20 "..\..\UserEmails\Inky\CourseInvite.cshtml"
         Write(CourseParticipant.Course.CourseFormat.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n            (");

            
            #line 21 "..\..\UserEmails\Inky\CourseInvite.cshtml"
        Write(CourseParticipant.Course.CourseFormat.CourseType.Description);

            
            #line default
            #line hidden
WriteLiteral(")\r\n");

            
            #line 22 "..\..\UserEmails\Inky\CourseInvite.cshtml"
            
            
            #line default
            #line hidden
            
            #line 22 "..\..\UserEmails\Inky\CourseInvite.cshtml"
             if (!CourseParticipant.Course.CourseFormat.CourseType.Description.EndsWith("course", StringComparison.OrdinalIgnoreCase))
            {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("Course\r\n");

            
            #line 25 "..\..\UserEmails\Inky\CourseInvite.cshtml"
            } 

            
            #line default
            #line hidden
WriteLiteral("            for which you were a ");

            
            #line 26 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                             Write(CourseParticipant.IsFaculty ? "faculty member" : "participant");

            
            #line default
            #line hidden
WriteLiteral(" has been <strong>CANCELLED</strong>.\r\n        </p>\r\n        <p>Details of the ca" +
"ncelled course are:</p>\r\n    </callout>\r\n");

            
            #line 30 "..\..\UserEmails\Inky\CourseInvite.cshtml"
}
else
{
    if (OldStart.HasValue)
    {

            
            #line default
            #line hidden
WriteLiteral("        <callout");

WriteLiteral(" class=\"danger\"");

WriteLiteral(">\r\n            <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(">\r\n                Please note the <em>change in schedule</em> for this event!\r\n " +
"               <strong>\r\n                    The new start is\r\n");

WriteLiteral("                    ");

            
            #line 40 "..\..\UserEmails\Inky\CourseInvite.cshtml"
               Write(string.Format(FormatProvider, "{0:D} at {0:t}", CourseParticipant.IsFaculty?CourseParticipant.Course.StartFacultyLocal: CourseParticipant.Course.StartParticipantLocal()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </strong>.\r\n            </p>\r\n            <p><small>(Note the c" +
"hange from the <strong>old</strong> start of ");

            
            #line 43 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                                                                         Write(string.Format(FormatProvider, "{0:D} at {0:t}", OldStart.Value));

            
            #line default
            #line hidden
WriteLiteral(")</small></p>\r\n        </callout>\r\n");

WriteLiteral("        <hr />\r\n");

            
            #line 46 "..\..\UserEmails\Inky\CourseInvite.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <callout");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">\r\n        <p>\r\n            You have been added as a ");

            
            #line 49 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                                 Write(CourseParticipant.IsFaculty ? "faculty member" : "participant");

            
            #line default
            #line hidden
WriteLiteral(" to an upcoming\r\n");

WriteLiteral("            ");

            
            #line 50 "..\..\UserEmails\Inky\CourseInvite.cshtml"
       Write(CourseParticipant.Course.CourseFormat.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n            (");

            
            #line 51 "..\..\UserEmails\Inky\CourseInvite.cshtml"
        Write(CourseParticipant.Course.CourseFormat.CourseType.Description);

            
            #line default
            #line hidden
WriteLiteral(")\r\n");

            
            #line 52 "..\..\UserEmails\Inky\CourseInvite.cshtml"
            
            
            #line default
            #line hidden
            
            #line 52 "..\..\UserEmails\Inky\CourseInvite.cshtml"
             if (!CourseParticipant.Course.CourseFormat.CourseType.Description.EndsWith("course", StringComparison.OrdinalIgnoreCase))
            {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("Course\r\n");

            
            #line 55 "..\..\UserEmails\Inky\CourseInvite.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </p>\r\n        <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(">Please check the details below and then confirm your availability.</p>\r\n    </ca" +
"llout>\r\n");

            
            #line 59 "..\..\UserEmails\Inky\CourseInvite.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<dl>\r\n    <dt>When</dt>\r\n    <dd>\r\n        <p>\r\n");

WriteLiteral("            ");

            
            #line 64 "..\..\UserEmails\Inky\CourseInvite.cshtml"
       Write(string.Format(FormatProvider, "{0:D} at {0:t}", CourseParticipant.IsFaculty ? CourseParticipant.Course.StartFacultyLocal : CourseParticipant.Course.StartParticipantLocal()));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </p>\r\n        <p");

WriteLiteral(" class=\"details\"");

WriteLiteral(">\r\n            (finishing ");

            
            #line 67 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                   Write((CourseParticipant.IsFaculty?CourseParticipant.Course.FinishCourseFacultyLocal(): CourseParticipant.Course.FinishCourseParticipantLocal()).ToString("g",FormatProvider));

            
            #line default
            #line hidden
WriteLiteral(")\r\n        </p>\r\n    </dd>\r\n\r\n    <dt>Department</dt>\r\n    <dd>\r\n");

WriteLiteral("        ");

            
            #line 73 "..\..\UserEmails\Inky\CourseInvite.cshtml"
   Write(CourseParticipant.Course.Department.Institution.Name);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 73 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                                                           Write(CourseParticipant.Course.Department.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </dd>\r\n\r\n    <dt>Where</dt>\r\n    <dd>\r\n        <p>");

            
            #line 78 "..\..\UserEmails\Inky\CourseInvite.cshtml"
      Write(CourseParticipant.Course.Room.ShortDescription);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <p");

WriteLiteral(" class=\"details\"");

WriteLiteral(">(");

            
            #line 79 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                       Write(CourseParticipant.Course.Room.FullDescription);

            
            #line default
            #line hidden
WriteLiteral(")</p>\r\n    </dd>\r\n</dl>\r\n<h5>Organiser(s)</h5>\r\n<ul>\r\n");

            
            #line 84 "..\..\UserEmails\Inky\CourseInvite.cshtml"
    
            
            #line default
            #line hidden
            
            #line 84 "..\..\UserEmails\Inky\CourseInvite.cshtml"
     foreach (var o in (from cp in CourseParticipant.Course.CourseParticipants where cp.IsOrganiser select cp.Participant))
    {

            
            #line default
            #line hidden
WriteLiteral("        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3641), Tuple.Create("\"", 3661)
            
            #line 87 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 3648), Tuple.Create<System.Object, System.Int32>(GetMailTo(o)
            
            #line default
            #line hidden
, 3648), false)
);

WriteLiteral(">");

            
            #line 87 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                               Write(o.FullName);

            
            #line default
            #line hidden
WriteLiteral("</a> ");

            
            #line 87 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                                               Write(o.PhoneNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </li>\r\n");

            
            #line 89 "..\..\UserEmails\Inky\CourseInvite.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n<row>\r\n    <columns>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3756), Tuple.Create("\"", 3851)
            
            #line 93 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 3763), Tuple.Create<System.Object, System.Int32>(BaseUrl
            
            #line default
            #line hidden
, 3763), false)
, Tuple.Create(Tuple.Create("", 3771), Tuple.Create("/api/CoursePlanning/MyCalendar/", 3771), true)
            
            #line 93 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 3802), Tuple.Create<System.Object, System.Int32>(CourseParticipant.ParticipantId.ToString()
            
            #line default
            #line hidden
, 3802), false)
, Tuple.Create(Tuple.Create("", 3847), Tuple.Create(".ics", 3847), true)
);

WriteLiteral(">\r\n            <img");

WriteLiteral(" alt=\"Add To Calendar\"");

WriteLiteral(" title=\"Update my calendar\"");

WriteAttribute("src", Tuple.Create(" src=\"", 3920), Tuple.Create("\"", 3975)
            
            #line 94 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 3926), Tuple.Create<System.Object, System.Int32>(BaseInsecureUrl
            
            #line default
            #line hidden
, 3926), false)
, Tuple.Create(Tuple.Create("", 3942), Tuple.Create("/Content/Images/AddToCalendar.jpg", 3942), true)
);

WriteLiteral(" width=\"166\"");

WriteLiteral(" height=\"58\"");

WriteLiteral("/>\r\n        </a>\r\n    </columns>\r\n</row>\r\n\r\n<hr/>\r\n\r\n<row>\r\n    <columns");

WriteLiteral(" large=\"6\"");

WriteLiteral(">\r\n        <center>\r\n            <button");

WriteLiteral(" class=\"success radius\"");

WriteAttribute("href", Tuple.Create(" href=\"", 4145), Tuple.Create("\"", 4177)
            
            #line 104 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 4152), Tuple.Create<System.Object, System.Int32>(GetNotificationUrl(true)
            
            #line default
            #line hidden
, 4152), false)
);

WriteLiteral(">Confirm</button>\r\n        </center>\r\n    </columns>\r\n    <columns");

WriteLiteral(" large=\"6\"");

WriteLiteral(">\r\n        <center>\r\n            <button");

WriteLiteral(" class=\"alert radius\"");

WriteAttribute("href", Tuple.Create(" href=\"", 4315), Tuple.Create("\"", 4348)
            
            #line 109 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 4322), Tuple.Create<System.Object, System.Int32>(GetNotificationUrl(false)
            
            #line default
            #line hidden
, 4322), false)
);

WriteLiteral(">I\'m Unavailable</button>\r\n        </center>\r\n    </columns>\r\n</row>");

        }
    }
}
#pragma warning restore 1591
