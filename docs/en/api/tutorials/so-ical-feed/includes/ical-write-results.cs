DateTime fromDate = DateTime.Now.AddDays(-10);
DateTime toDate = DateTime.Now.AddDays(39);
AppointmentCollection.CustomSearch q = new AppointmentCollection.CustomSearch();
q.Restriction = q.TableInfo.AssociateId.Equal( S.Parameter(associd)).And( q.TableInfo.Type.In(S.Parameter(1), S.Parameter(2), S.Parameter(6))).And( q.TableInfo.DoBy.Between(S.Parameter(fromDate), S.Parameter(toDate) ));
AppointmentCollection appoints = AppointmentCollection.GetFromCustomSearch(q);

Response.ContentType = "text/calendar";
Response.Charset = "";
Response.Cache.SetNoServerCaching();
Response.Cache.SetExpires(DateTime.Now);
Response.Cache.SetNoStore();
Response.ContentEncoding = Encoding.UTF8;

Response.Write("BEGIN:VCALENDAR\r\n");
Response.Write("PRODID:-//SuperOffice AS//SuperOffice Calendar 7//EN\r\n");
Response.Write("VERSION:2.0\r\n");
Response.Write("CALSCALE:GREGORIAN\r\n");
Response.Write("METHOD:PUBLISH\r\n");
Response.Write("X-WR-CALNAME:SO " + name + "\r\n");
Response.Write("X-WR-CALDESC:" + name + " SuperOffice calendar\r\n");
Response.Write("X-WR-TIMEZONE;VALUE=TEXT:Europe/Oslo\r\n");

private string MakeLocalDate(DateTime dt)
{
  return dt.ToString("yyyyMMdd\\THHmmss");
}

private string MakeDate(DateTime dt)
{
  return dt.ToUniversalTime().ToString("yyyyMMdd\\THHmmss\\Z");
}

foreach (Appointment a in appoints)
{
  string start = MakeLocalDate(a.DoBy);
  string end = MakeLocalDate(a.EndDate);
  string id = "appointmentid-" + a.AppointmentId.ToString() + "@" + Request.ServerVariables["SERVER_NAME"];
  string type = a.Task == null ? "" : a.Task.Name;
  string registered = MakeDate(a.Registered);
  string updated = a.Updated.Year < 1900 ? registered : MakeDate(a.Updated);
  string desc = a.AppointmentText == null ? "" :
                a.AppointmentText.Text.Replace("\r\n", "\\n").Replace("\n", "\\n").Replace("\r", "\\r");
  string cont = a.Contact == null ? "" : a.Contact.Name;
  string summary = type + ": " + desc;
  if (summary.Length > 60)
    summary = summary.Substring(0, 60) + "...";
  Response.Write("BEGIN:VEVENT\r\n");
  Response.Write("DTSTART;TZID=Europe/Oslo:" + start + "\r\n");
  Response.Write("DTEND;TZID=Europe/Oslo:" + end + "\r\n");
  Response.Write("DTSTAMP:" + updated + "\r\n");
  Response.Write("UID:" + id + "\r\n");
  Response.Write("CLASS:PUBLIC\r\n");
  Response.Write("CREATED:" + registered + "\r\n");
  Response.Write("LAST-MODIFIED:" + updated + "\r\n");
  Response.Write("SUMMARY:" + summary + "\r\n");
  Response.Write("CATEGORIES:" + type + "\r\n");
  Response.Write("DESCRIPTION:" + type + " / " + cont + " / " + desc + "\r\n");
  Response.Write("SEQUENCE:0\r\n");
  if( a.Type == AppointmentType.BookingForChecklist || a.Type == AppointmentType.BookingForDiary )
    Response.Write("STATUS:TENTATIVE\r\n");
  else
    Response.Write("STATUS:CONFIRMED\r\n");
  if( a.FreeBusy == 0 )
    Response.Write("TRANSP:OPAQUE\r\n");
  else
    Response.Write("TRANSP:TRANSPARENT\r\n");
  Response.Write("END:VEVENT\r\n");
}