---
title: Services87.EMailAgent.GetEmailAppointmentRecurrence SOAP
generated: 1
uid: Services87-EMail-GetEmailAppointmentRecurrence
---

# Services87 EMail GetEmailAppointmentRecurrence

SOAP request and response examples **Remote/Services87/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IEMailAgent.GetEmailAppointmentRecurrence">SuperOffice.Services87.IEMailAgent.GetEmailAppointmentRecurrence</see> method.

## GetEmailAppointmentRecurrence

Get recurrence data contained in the email iCal attachment
<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.

* **mailItemId:** Id identifying the email

**Returns:** Recurrence information


[WSDL file for Services87/EMail](../Services87-EMail.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetEmailAppointmentRecurrence Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:GetEmailAppointmentRecurrence>
    <EMail:MailItemId xsi:type="xsd:int">0</EMail:MailItemId>
   </EMail:GetEmailAppointmentRecurrence>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetEmailAppointmentRecurrence Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <EMail:GetEmailAppointmentRecurrenceResponse>
   <EMail:Response xsi:type="EMail:RecurrenceInfo">
    <EMail:RecurrenceId xsi:type="xsd:int">0</EMail:RecurrenceId>
    <EMail:StartDate xsi:type="xsd:dateTime">2022-08-26T08:56:58Z</EMail:StartDate>
    <EMail:EndDate xsi:type="xsd:dateTime">2022-08-26T08:56:58Z</EMail:EndDate>
    <EMail:RecurrenceEndType xsi:type="EMail:RecurrenceEndType">Unknown</EMail:RecurrenceEndType>
    <EMail:Pattern xsi:type="EMail:RecurrencePattern">Unknown</EMail:Pattern>
    <EMail:DayPattern xsi:type="EMail:RecurrenceDayPattern">
     <EMail:Cycle xsi:type="xsd:int">0</EMail:Cycle>
     <EMail:Pattern xsi:type="EMail:RecurrenceDailyPattern">Unknown</EMail:Pattern>
    </EMail:DayPattern>
    <EMail:WeekPattern xsi:type="EMail:RecurrenceWeekPattern">
     <EMail:Cycle xsi:type="xsd:int">0</EMail:Cycle>
     <EMail:Weekdays xsi:type="EMail:Weekday">Monday</EMail:Weekdays>
    </EMail:WeekPattern>
    <EMail:MonthPattern xsi:type="EMail:RecurrenceMonthPattern">
     <EMail:Cycle xsi:type="xsd:int">0</EMail:Cycle>
     <EMail:Day xsi:type="xsd:int">0</EMail:Day>
     <EMail:Weekday xsi:type="EMail:Weekday">Monday</EMail:Weekday>
     <EMail:WeekOfMonth xsi:type="EMail:WeekOfMonth">Unknown</EMail:WeekOfMonth>
     <EMail:Pattern xsi:type="EMail:RecurrenceMonthlyPattern">Unknown</EMail:Pattern>
    </EMail:MonthPattern>
    <EMail:YearPattern xsi:type="EMail:RecurrenceYearPattern">
     <EMail:Cycle xsi:type="xsd:int">0</EMail:Cycle>
     <EMail:Day xsi:type="xsd:int">0</EMail:Day>
     <EMail:Weekday xsi:type="EMail:Weekday">Monday</EMail:Weekday>
     <EMail:WeekOfMonth xsi:type="EMail:WeekOfMonth">Unknown</EMail:WeekOfMonth>
     <EMail:Pattern xsi:type="EMail:RecurrenceYearlyPattern">Unknown</EMail:Pattern>
    </EMail:YearPattern>
    <EMail:Dates xsi:type="EMail:ArrayOfRecurrenceDate">
     <EMail:RecurrenceDate xsi:type="EMail:RecurrenceDate">
      <EMail:Date xsi:type="xsd:dateTime">2022-08-26T08:56:58Z</EMail:Date>
      <EMail:IsConflict xsi:type="xsd:boolean">false</EMail:IsConflict>
      <EMail:Description xsi:type="xsd:string"></EMail:Description>
      <EMail:DescriptionStyleHint xsi:type="xsd:string"></EMail:DescriptionStyleHint>
      <EMail:Tooltip xsi:type="xsd:string"></EMail:Tooltip>
     </EMail:RecurrenceDate>
    </EMail:Dates>
    <EMail:RecurrenceCounter xsi:type="xsd:int">0</EMail:RecurrenceCounter>
    <EMail:IsRecurrence xsi:type="xsd:boolean">false</EMail:IsRecurrence>
   </EMail:Response>
  </EMail:GetEmailAppointmentRecurrenceResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

