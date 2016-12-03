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
           
    public string GetNotificationUrl(bool canAttend)
    {
        return  $"{BaseUrl}/index.html#/rsvp?ParticipantId={CourseParticipant.ParticipantId}&CourseId={CourseParticipant.CourseId}&Attending=" + (canAttend ? "1" : "0");
    }

        #line default
        #line hidden
        
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 11 "..\..\UserEmails\Inky\CourseInvite.cshtml"
   Layout = new SP.Web.UserEmails.LayoutTemplate { Title = "Course Invitation" }; 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 12 "..\..\UserEmails\Inky\CourseInvite.cshtml"
 if (CourseParticipant.Course.Cancelled)
{

            
            #line default
            #line hidden
WriteLiteral("    <callout");

WriteLiteral(" class=\"warning\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(">\r\n            A ");

            
            #line 16 "..\..\UserEmails\Inky\CourseInvite.cshtml"
         Write(CourseParticipant.Course.CourseFormat.CourseType.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 17 "..\..\UserEmails\Inky\CourseInvite.cshtml"
            
            
            #line default
            #line hidden
            
            #line 17 "..\..\UserEmails\Inky\CourseInvite.cshtml"
             if (!CourseParticipant.Course.CourseFormat.CourseType.Description.EndsWith("course", StringComparison.OrdinalIgnoreCase))
            {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("Course\r\n");

            
            #line 20 "..\..\UserEmails\Inky\CourseInvite.cshtml"
            } 

            
            #line default
            #line hidden
WriteLiteral("            for which you were a ");

            
            #line 21 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                             Write(CourseParticipant.IsFaculty ? "faculty member" : "participant");

            
            #line default
            #line hidden
WriteLiteral(" has been <strong>CANCELLED</strong>.\r\n        </p>\r\n        <p>Details of the ca" +
"ncelled course are:</p>\r\n    </callout>\r\n");

            
            #line 25 "..\..\UserEmails\Inky\CourseInvite.cshtml"

}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <callout");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">\r\n        <p>\r\n            You have been added as a ");

            
            #line 31 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                                 Write(CourseParticipant.IsFaculty ? "faculty member" : "participant");

            
            #line default
            #line hidden
WriteLiteral(" to an upcoming \r\n");

WriteLiteral("            ");

            
            #line 32 "..\..\UserEmails\Inky\CourseInvite.cshtml"
       Write(CourseParticipant.Course.CourseFormat.CourseType.Description);

            
            #line default
            #line hidden
WriteLiteral(" \r\n\r\n        </p>\r\n        <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(">Please check the details below and then confirm your availability.</p>\r\n    </ca" +
"llout>\r\n");

            
            #line 37 "..\..\UserEmails\Inky\CourseInvite.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<dl>\r\n    <dt>When</dt>\r\n    <dd>\r\n        <p>\r\n");

WriteLiteral("            ");

            
            #line 42 "..\..\UserEmails\Inky\CourseInvite.cshtml"
       Write(string.Format(FormatProvider, "{0:D} at {0:t}", CourseParticipant.Course.StartLocal));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </p>\r\n        <p");

WriteLiteral(" class=\"details\"");

WriteLiteral(">\r\n            (finishing ");

            
            #line 45 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                  Write(CourseParticipant.Course.FinishCourseLocal().ToString("g",FormatProvider));

            
            #line default
            #line hidden
WriteLiteral(")\r\n        </p>\r\n    </dd>\r\n\r\n    <dt>Department</dt>\r\n    <dd>\r\n");

WriteLiteral("        ");

            
            #line 51 "..\..\UserEmails\Inky\CourseInvite.cshtml"
   Write(CourseParticipant.Course.Department.Institution.Name);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 51 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                                                           Write(CourseParticipant.Course.Department.Name);

            
            #line default
            #line hidden
WriteLiteral(" \r\n    </dd>\r\n\r\n    <dt>Where</dt>\r\n    <dd>\r\n        <p>");

            
            #line 56 "..\..\UserEmails\Inky\CourseInvite.cshtml"
      Write(CourseParticipant.Course.Room.ShortDescription);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <p");

WriteLiteral(" class=\"details\"");

WriteLiteral(">(");

            
            #line 57 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                       Write(CourseParticipant.Course.Room.FullDescription);

            
            #line default
            #line hidden
WriteLiteral(")</p>\r\n    </dd>\r\n</dl>\r\n<h5>Organiser(s)</h5>\r\n<ul>\r\n");

            
            #line 62 "..\..\UserEmails\Inky\CourseInvite.cshtml"
    
            
            #line default
            #line hidden
            
            #line 62 "..\..\UserEmails\Inky\CourseInvite.cshtml"
     foreach (var o in (from cp in CourseParticipant.Course.CourseParticipants where cp.IsOrganiser select cp.Participant))
    {

            
            #line default
            #line hidden
WriteLiteral("        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2362), Tuple.Create("\"", 2382)
            
            #line 65 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 2369), Tuple.Create<System.Object, System.Int32>(GetMailTo(o)
            
            #line default
            #line hidden
, 2369), false)
);

WriteLiteral(">");

            
            #line 65 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                               Write(o.FullName);

            
            #line default
            #line hidden
WriteLiteral("</a> ");

            
            #line 65 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                                               Write(o.PhoneNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </li>\r\n");

            
            #line 67 "..\..\UserEmails\Inky\CourseInvite.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n<row>\r\n    <columns>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2477), Tuple.Create("\"", 2580)
            
            #line 71 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 2484), Tuple.Create<System.Object, System.Int32>(BaseInsecureUrl
            
            #line default
            #line hidden
, 2484), false)
, Tuple.Create(Tuple.Create("", 2500), Tuple.Create("/api/CoursePlanning/MyCalendar/", 2500), true)
            
            #line 71 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 2531), Tuple.Create<System.Object, System.Int32>(CourseParticipant.ParticipantId.ToString()
            
            #line default
            #line hidden
, 2531), false)
, Tuple.Create(Tuple.Create("", 2576), Tuple.Create(".ics", 2576), true)
);

WriteLiteral(">\r\n            <img");

WriteLiteral(" alt=\"Add To Calendar\"");

WriteLiteral(" title=\"Update my calendar\"");

WriteAttribute("src", Tuple.Create(" src=\"", 2649), Tuple.Create("\"", 2704)
            
            #line 72 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 2655), Tuple.Create<System.Object, System.Int32>(BaseInsecureUrl
            
            #line default
            #line hidden
, 2655), false)
, Tuple.Create(Tuple.Create("", 2671), Tuple.Create("/Content/Images/AddToCalendar.jpg", 2671), true)
);

WriteLiteral(" width=\"166\"");

WriteLiteral(" height=\"58\"");

WriteLiteral("/>\r\n        </a>\r\n    </columns>\r\n</row>\r\n\r\n<hr/>\r\n\r\n<row>\r\n    <columns");

WriteLiteral(" large=\"6\"");

WriteLiteral(">\r\n        <center>\r\n            <button");

WriteLiteral(" class=\"success radius\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2874), Tuple.Create("\"", 2906)
            
            #line 82 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 2881), Tuple.Create<System.Object, System.Int32>(GetNotificationUrl(true)
            
            #line default
            #line hidden
, 2881), false)
);

WriteLiteral(">Confirm</button>\r\n        </center>\r\n    </columns>\r\n    <columns");

WriteLiteral(" large=\"6\"");

WriteLiteral(">\r\n        <center>\r\n            <button");

WriteLiteral(" class=\"alert radius\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3044), Tuple.Create("\"", 3077)
            
            #line 87 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 3051), Tuple.Create<System.Object, System.Int32>(GetNotificationUrl(false)
            
            #line default
            #line hidden
, 3051), false)
);

WriteLiteral(">I\'m Unavailable</button>\r\n        </center>\r\n    </columns>\r\n</row>");

        }
    }
}
#pragma warning restore 1591
