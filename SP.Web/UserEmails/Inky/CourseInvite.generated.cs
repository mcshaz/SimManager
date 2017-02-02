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
    public string GetNotificationUrl(bool canAttend)
    {
        return  $"{BaseUrl}/rsvp?ParticipantId={CourseParticipant.ParticipantId}&CourseId={CourseParticipant.CourseId}&Attending=" + (canAttend ? "1" : "0");
    }

        #line default
        #line hidden
        
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 12 "..\..\UserEmails\Inky\CourseInvite.cshtml"
   Layout = new SP.Web.UserEmails.LayoutTemplate { Title = "Course Invitation" }; 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..\UserEmails\Inky\CourseInvite.cshtml"
 if (CourseParticipant.Course.Cancelled)
{

            
            #line default
            #line hidden
WriteLiteral("    <callout");

WriteLiteral(" class=\"warning\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(">\r\n            A ");

            
            #line 17 "..\..\UserEmails\Inky\CourseInvite.cshtml"
         Write(CourseParticipant.Course.CourseFormat.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n            (");

            
            #line 18 "..\..\UserEmails\Inky\CourseInvite.cshtml"
        Write(CourseParticipant.Course.CourseFormat.CourseType.Description);

            
            #line default
            #line hidden
WriteLiteral(")\r\n");

            
            #line 19 "..\..\UserEmails\Inky\CourseInvite.cshtml"
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\UserEmails\Inky\CourseInvite.cshtml"
             if (!CourseParticipant.Course.CourseFormat.CourseType.Description.EndsWith("course", StringComparison.OrdinalIgnoreCase))
            {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("Course\r\n");

            
            #line 22 "..\..\UserEmails\Inky\CourseInvite.cshtml"
            } 

            
            #line default
            #line hidden
WriteLiteral("            for which you were a ");

            
            #line 23 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                             Write(CourseParticipant.IsFaculty ? "faculty member" : "participant");

            
            #line default
            #line hidden
WriteLiteral(" has been <strong>CANCELLED</strong>.\r\n        </p>\r\n        <p>Details of the ca" +
"ncelled course are:</p>\r\n    </callout>\r\n");

            
            #line 27 "..\..\UserEmails\Inky\CourseInvite.cshtml"
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

            
            #line 37 "..\..\UserEmails\Inky\CourseInvite.cshtml"
               Write(string.Format(FormatProvider, "{0:D} at {0:t}", CourseParticipant.Course.StartLocal));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </strong>.\r\n            </p>\r\n            <p><small>(Note the c" +
"hange from the <strong>old</strong> start of ");

            
            #line 40 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                                                                         Write(string.Format(FormatProvider, "{0:D} at {0:t}", OldStart.Value));

            
            #line default
            #line hidden
WriteLiteral(")</small></p>\r\n        </callout>\r\n");

WriteLiteral("        <hr />\r\n");

            
            #line 43 "..\..\UserEmails\Inky\CourseInvite.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <callout");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">\r\n        <p>\r\n            You have been added as a ");

            
            #line 46 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                                 Write(CourseParticipant.IsFaculty ? "faculty member" : "participant");

            
            #line default
            #line hidden
WriteLiteral(" to an upcoming \r\n");

WriteLiteral("            ");

            
            #line 47 "..\..\UserEmails\Inky\CourseInvite.cshtml"
       Write(CourseParticipant.Course.CourseFormat.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n            (");

            
            #line 48 "..\..\UserEmails\Inky\CourseInvite.cshtml"
        Write(CourseParticipant.Course.CourseFormat.CourseType.Description);

            
            #line default
            #line hidden
WriteLiteral(")\r\n");

            
            #line 49 "..\..\UserEmails\Inky\CourseInvite.cshtml"
            
            
            #line default
            #line hidden
            
            #line 49 "..\..\UserEmails\Inky\CourseInvite.cshtml"
             if (!CourseParticipant.Course.CourseFormat.CourseType.Description.EndsWith("course", StringComparison.OrdinalIgnoreCase))
            {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("Course\r\n");

            
            #line 52 "..\..\UserEmails\Inky\CourseInvite.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </p>\r\n        <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(">Please check the details below and then confirm your availability.</p>\r\n    </ca" +
"llout>\r\n");

            
            #line 56 "..\..\UserEmails\Inky\CourseInvite.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<dl>\r\n    <dt>When</dt>\r\n    <dd>\r\n        <p>\r\n");

WriteLiteral("            ");

            
            #line 61 "..\..\UserEmails\Inky\CourseInvite.cshtml"
       Write(string.Format(FormatProvider, "{0:D} at {0:t}", CourseParticipant.Course.StartLocal));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </p>\r\n        <p");

WriteLiteral(" class=\"details\"");

WriteLiteral(">\r\n            (finishing ");

            
            #line 64 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                  Write(CourseParticipant.Course.FinishCourseLocal().ToString("g",FormatProvider));

            
            #line default
            #line hidden
WriteLiteral(")\r\n        </p>\r\n    </dd>\r\n\r\n    <dt>Department</dt>\r\n    <dd>\r\n");

WriteLiteral("        ");

            
            #line 70 "..\..\UserEmails\Inky\CourseInvite.cshtml"
   Write(CourseParticipant.Course.Department.Institution.Name);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 70 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                                                           Write(CourseParticipant.Course.Department.Name);

            
            #line default
            #line hidden
WriteLiteral(" \r\n    </dd>\r\n\r\n    <dt>Where</dt>\r\n    <dd>\r\n        <p>");

            
            #line 75 "..\..\UserEmails\Inky\CourseInvite.cshtml"
      Write(CourseParticipant.Course.Room.ShortDescription);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <p");

WriteLiteral(" class=\"details\"");

WriteLiteral(">(");

            
            #line 76 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                       Write(CourseParticipant.Course.Room.FullDescription);

            
            #line default
            #line hidden
WriteLiteral(")</p>\r\n    </dd>\r\n</dl>\r\n<h5>Organiser(s)</h5>\r\n<ul>\r\n");

            
            #line 81 "..\..\UserEmails\Inky\CourseInvite.cshtml"
    
            
            #line default
            #line hidden
            
            #line 81 "..\..\UserEmails\Inky\CourseInvite.cshtml"
     foreach (var o in (from cp in CourseParticipant.Course.CourseParticipants where cp.IsOrganiser select cp.Participant))
    {

            
            #line default
            #line hidden
WriteLiteral("        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3307), Tuple.Create("\"", 3327)
            
            #line 84 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 3314), Tuple.Create<System.Object, System.Int32>(GetMailTo(o)
            
            #line default
            #line hidden
, 3314), false)
);

WriteLiteral(">");

            
            #line 84 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                               Write(o.FullName);

            
            #line default
            #line hidden
WriteLiteral("</a> ");

            
            #line 84 "..\..\UserEmails\Inky\CourseInvite.cshtml"
                                               Write(o.PhoneNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </li>\r\n");

            
            #line 86 "..\..\UserEmails\Inky\CourseInvite.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n<row>\r\n    <columns>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3422), Tuple.Create("\"", 3517)
            
            #line 90 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 3429), Tuple.Create<System.Object, System.Int32>(BaseUrl
            
            #line default
            #line hidden
, 3429), false)
, Tuple.Create(Tuple.Create("", 3437), Tuple.Create("/api/CoursePlanning/MyCalendar/", 3437), true)
            
            #line 90 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 3468), Tuple.Create<System.Object, System.Int32>(CourseParticipant.ParticipantId.ToString()
            
            #line default
            #line hidden
, 3468), false)
, Tuple.Create(Tuple.Create("", 3513), Tuple.Create(".ics", 3513), true)
);

WriteLiteral(">\r\n            <img");

WriteLiteral(" alt=\"Add To Calendar\"");

WriteLiteral(" title=\"Update my calendar\"");

WriteAttribute("src", Tuple.Create(" src=\"", 3586), Tuple.Create("\"", 3641)
            
            #line 91 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 3592), Tuple.Create<System.Object, System.Int32>(BaseInsecureUrl
            
            #line default
            #line hidden
, 3592), false)
, Tuple.Create(Tuple.Create("", 3608), Tuple.Create("/Content/Images/AddToCalendar.jpg", 3608), true)
);

WriteLiteral(" width=\"166\"");

WriteLiteral(" height=\"58\"");

WriteLiteral("/>\r\n        </a>\r\n    </columns>\r\n</row>\r\n\r\n<hr/>\r\n\r\n<row>\r\n    <columns");

WriteLiteral(" large=\"6\"");

WriteLiteral(">\r\n        <center>\r\n            <button");

WriteLiteral(" class=\"success radius\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3811), Tuple.Create("\"", 3843)
            
            #line 101 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 3818), Tuple.Create<System.Object, System.Int32>(GetNotificationUrl(true)
            
            #line default
            #line hidden
, 3818), false)
);

WriteLiteral(">Confirm</button>\r\n        </center>\r\n    </columns>\r\n    <columns");

WriteLiteral(" large=\"6\"");

WriteLiteral(">\r\n        <center>\r\n            <button");

WriteLiteral(" class=\"alert radius\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3981), Tuple.Create("\"", 4014)
            
            #line 106 "..\..\UserEmails\Inky\CourseInvite.cshtml"
, Tuple.Create(Tuple.Create("", 3988), Tuple.Create<System.Object, System.Int32>(GetNotificationUrl(false)
            
            #line default
            #line hidden
, 3988), false)
);

WriteLiteral(">I\'m Unavailable</button>\r\n        </center>\r\n    </columns>\r\n</row>");

        }
    }
}
#pragma warning restore 1591
