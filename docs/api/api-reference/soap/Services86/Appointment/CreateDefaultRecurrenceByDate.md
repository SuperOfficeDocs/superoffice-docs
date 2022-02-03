---
title: Services86.AppointmentAgent.CreateDefaultRecurrenceByDate SOAP
generated: 1
uid: Services86-Appointment-CreateDefaultRecurrenceByDate
---

# Services86 Appointment CreateDefaultRecurrenceByDate

SOAP request and response examples **Remote/Services86/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IAppointmentAgent.CreateDefaultRecurrenceByDate">SuperOffice.Services86.IAppointmentAgent.CreateDefaultRecurrenceByDate</see> method.

## CreateDefaultRecurrenceByDate

Creates a RecurrenceInfo object populated with the default values for the specific type. Using startDate as start date for the recurreing pattern.

* **startDate:** Date of which the recurring pattern should start.



[WSDL file for Services86/Appointment](../Services86-Appointment.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultRecurrenceByDate Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:CreateDefaultRecurrenceByDate>
    <Appointment:StartDate xsi:type="xsd:dateTime">2021-11-30T13:22:45Z</Appointment:StartDate>
   </Appointment:CreateDefaultRecurrenceByDate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultRecurrenceByDate Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Appointment:CreateDefaultRecurrenceByDateResponse>
   <Appointment:Response xsi:type="Appointment:RecurrenceInfo">
    <Appointment:RecurrenceId xsi:type="xsd:int">0</Appointment:RecurrenceId>
    <Appointment:StartDate xsi:type="xsd:dateTime">2021-11-30T13:22:45Z</Appointment:StartDate>
    <Appointment:EndDate xsi:type="xsd:dateTime">2021-11-30T13:22:45Z</Appointment:EndDate>
    <Appointment:RecurrenceEndType xsi:type="Appointment:RecurrenceEndType">Unknown</Appointment:RecurrenceEndType>
    <Appointment:Pattern xsi:type="Appointment:RecurrencePattern">Unknown</Appointment:Pattern>
    <Appointment:DayPattern xsi:type="Appointment:RecurrenceDayPattern">
     <Appointment:Cycle xsi:type="xsd:int">0</Appointment:Cycle>
     <Appointment:Pattern xsi:type="Appointment:RecurrenceDailyPattern">Unknown</Appointment:Pattern>
    </Appointment:DayPattern>
    <Appointment:WeekPattern xsi:type="Appointment:RecurrenceWeekPattern">
     <Appointment:Cycle xsi:type="xsd:int">0</Appointment:Cycle>
     <Appointment:Weekdays xsi:type="Appointment:Weekday">Monday</Appointment:Weekdays>
    </Appointment:WeekPattern>
    <Appointment:MonthPattern xsi:type="Appointment:RecurrenceMonthPattern">
     <Appointment:Cycle xsi:type="xsd:int">0</Appointment:Cycle>
     <Appointment:Day xsi:type="xsd:int">0</Appointment:Day>
     <Appointment:Weekday xsi:type="Appointment:Weekday">Monday</Appointment:Weekday>
     <Appointment:WeekOfMonth xsi:type="Appointment:WeekOfMonth">Unknown</Appointment:WeekOfMonth>
     <Appointment:Pattern xsi:type="Appointment:RecurrenceMonthlyPattern">Unknown</Appointment:Pattern>
    </Appointment:MonthPattern>
    <Appointment:YearPattern xsi:type="Appointment:RecurrenceYearPattern">
     <Appointment:Cycle xsi:type="xsd:int">0</Appointment:Cycle>
     <Appointment:Day xsi:type="xsd:int">0</Appointment:Day>
     <Appointment:Weekday xsi:type="Appointment:Weekday">Monday</Appointment:Weekday>
     <Appointment:WeekOfMonth xsi:type="Appointment:WeekOfMonth">Unknown</Appointment:WeekOfMonth>
     <Appointment:Pattern xsi:type="Appointment:RecurrenceYearlyPattern">Unknown</Appointment:Pattern>
    </Appointment:YearPattern>
    <Appointment:Dates xsi:type="Appointment:ArrayOfRecurrenceDate">
     <Appointment:RecurrenceDate xsi:type="Appointment:RecurrenceDate">
      <Appointment:Date xsi:type="xsd:dateTime">2021-11-30T13:22:45Z</Appointment:Date>
      <Appointment:IsConflict xsi:type="xsd:boolean">false</Appointment:IsConflict>
      <Appointment:Description xsi:type="xsd:string"></Appointment:Description>
      <Appointment:DescriptionStyleHint xsi:type="xsd:string"></Appointment:DescriptionStyleHint>
      <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
     </Appointment:RecurrenceDate>
    </Appointment:Dates>
    <Appointment:RecurrenceCounter xsi:type="xsd:int">0</Appointment:RecurrenceCounter>
    <Appointment:IsRecurrence xsi:type="xsd:boolean">false</Appointment:IsRecurrence>
   </Appointment:Response>
  </Appointment:CreateDefaultRecurrenceByDateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

