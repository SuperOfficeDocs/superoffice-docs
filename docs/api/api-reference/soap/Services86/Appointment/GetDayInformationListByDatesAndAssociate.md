---
uid: services86-appointment-getdayinformationlistbydatesandassociate
title: Services86.AppointmentAgent.GetDayInformationListByDatesAndAssociate SOAP
Generated: true
---

# Services86 Appointment GetDayInformationListByDatesAndAssociate SOAP

SOAP request and response examples **Remote/Services86/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IAppointmentAgent.GetDayInformationListByDatesAndAssociate">SuperOffice.Services86.IAppointmentAgent.GetDayInformationListByDatesAndAssociate</see> method.

## GetDayInformationListByDatesAndAssociate

Get combined day information (activity + redletter summary) for one or more days according to the given date interval. The time portion of the dates is ignored. Private appointments are counted, but may not be visible through tooltips or other more detailed services.

* **startDate:** Start date of interval. Time portion is ignored.
* **endDate:** End date of interval. Time portion is ignored.
* **associateId:** Associate id to identify the calendar to scan. If 0 is passed in, the currently authenticated associate is used instead.

**Returns:** Exactly one item per day of the given time span is returned. Days where nothing happens will have all values set to 0, but will still be in the returned array. Start end dates are treated as inclusive.


[WSDL file for Services86/Appointment](../Services86-Appointment.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDayInformationListByDatesAndAssociate Request

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
   <Appointment:GetDayInformationListByDatesAndAssociate>
    <Appointment:StartDate xsi:type="xsd:dateTime">2021-03-25T21:36:01Z</Appointment:StartDate>
    <Appointment:EndDate xsi:type="xsd:dateTime">2021-03-25T21:36:01Z</Appointment:EndDate>
    <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
   </Appointment:GetDayInformationListByDatesAndAssociate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDayInformationListByDatesAndAssociate Response

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
  <Appointment:GetDayInformationListByDatesAndAssociateResponse>
   <Appointment:Response xsi:type="Appointment:ArrayOfDayInformationListItem">
    <Appointment:DayInformationListItem xsi:type="Appointment:DayInformationListItem">
     <Appointment:ActivityInformation xsi:type="Appointment:ActivitySummary">
      <Appointment:NumBusyActivities xsi:type="xsd:int">0</Appointment:NumBusyActivities>
      <Appointment:NumFreeActivities xsi:type="xsd:int">0</Appointment:NumFreeActivities>
      <Appointment:PercentageBusy xsi:type="xsd:int">0</Appointment:PercentageBusy>
     </Appointment:ActivityInformation>
     <Appointment:RedLetterInformation xsi:type="Appointment:RedLetterSummary">
      <Appointment:IsOwnCountryHoliday xsi:type="xsd:boolean">false</Appointment:IsOwnCountryHoliday>
      <Appointment:IsOtherCountryHoliday xsi:type="xsd:boolean">false</Appointment:IsOtherCountryHoliday>
     </Appointment:RedLetterInformation>
     <Appointment:Date xsi:type="xsd:dateTime">2021-03-25T21:36:01Z</Appointment:Date>
    </Appointment:DayInformationListItem>
   </Appointment:Response>
  </Appointment:GetDayInformationListByDatesAndAssociateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

