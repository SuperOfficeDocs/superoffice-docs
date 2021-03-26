---
uid: services82-appointment-createdefaultrecurrence
title: Services82.AppointmentAgent.CreateDefaultRecurrence SOAP
Generated: true
---

# Services82 Appointment CreateDefaultRecurrence SOAP

SOAP request and response examples **Remote/Services82/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IAppointmentAgent.CreateDefaultRecurrence">SuperOffice.Services82.IAppointmentAgent.CreateDefaultRecurrence</see> method.

## CreateDefaultRecurrence

Creates a RecurrenceInfo object populated with the default values for the specific type.


**Returns:** RecurrenceInfo object with default values.


[WSDL file for Services82/Appointment](../Services82-Appointment.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultRecurrence Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:CreateDefaultRecurrence>
   </Appointment:CreateDefaultRecurrence>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultRecurrence Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <Appointment:CreateDefaultRecurrenceResponse>
   <Appointment:Response xsi:type="Appointment:RecurrenceInfo">
    <Appointment:RecurrenceId xsi:type="xsd:int">0</Appointment:RecurrenceId>
    <Appointment:StartDate xsi:type="xsd:dateTime">2021-03-25T21:34:40Z</Appointment:StartDate>
    <Appointment:EndDate xsi:type="xsd:dateTime">2021-03-25T21:34:40Z</Appointment:EndDate>
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
      <Appointment:Date xsi:type="xsd:dateTime">2021-03-25T21:34:40Z</Appointment:Date>
      <Appointment:IsConflict xsi:type="xsd:boolean">false</Appointment:IsConflict>
      <Appointment:Description xsi:type="xsd:string"></Appointment:Description>
      <Appointment:DescriptionStyleHint xsi:type="xsd:string"></Appointment:DescriptionStyleHint>
      <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
     </Appointment:RecurrenceDate>
    </Appointment:Dates>
    <Appointment:RecurrenceCounter xsi:type="xsd:int">0</Appointment:RecurrenceCounter>
    <Appointment:IsRecurrence xsi:type="xsd:boolean">false</Appointment:IsRecurrence>
   </Appointment:Response>
  </Appointment:CreateDefaultRecurrenceResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

