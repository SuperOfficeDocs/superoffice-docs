---
title: Services87.AppointmentAgent.GetActivityInformationListByDatesAndAssociate SOAP
generated: 1
uid: Services87-Appointment-GetActivityInformationListByDatesAndAssociate
---

# Services87 Appointment GetActivityInformationListByDatesAndAssociate

SOAP request and response examples **Remote/Services87/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IAppointmentAgent.GetActivityInformationListByDatesAndAssociate">SuperOffice.Services87.IAppointmentAgent.GetActivityInformationListByDatesAndAssociate</see> method.

## GetActivityInformationListByDatesAndAssociate

Get activity information for one or more days according to the given date interval. The time portion of the dates is ignored. Private appointments are counted, but may not be visible through tooltips or other more detailed services.

* **startDate:** Start date of interval. Time portion is ignored.
* **endDate:** End date of interval. Time portion is ignored.
* **associateId:** Associate id to identify the calendar to scan. If 0 is passed in, the currently authenticated associate is used instead.

**Returns:** Exactly one item per day of the given time span is returned. Days where nothing happens will have all values set to 0, but will still be in the returned array. Start end dates are treated as inclusive.

[WSDL file for Services87/Appointment](../Services87-Appointment.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetActivityInformationListByDatesAndAssociate Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:GetActivityInformationListByDatesAndAssociate>
    <Appointment:StartDate xsi:type="xsd:dateTime">2022-08-26T08:56:14Z</Appointment:StartDate>
    <Appointment:EndDate xsi:type="xsd:dateTime">2022-08-26T08:56:14Z</Appointment:EndDate>
    <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
   </Appointment:GetActivityInformationListByDatesAndAssociate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetActivityInformationListByDatesAndAssociate Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Appointment:GetActivityInformationListByDatesAndAssociateResponse>
   <Appointment:Response xsi:type="Appointment:ArrayOfActivityInformationListItem">
    <Appointment:ActivityInformationListItem xsi:type="Appointment:ActivityInformationListItem">
     <Appointment:Date xsi:type="xsd:dateTime">2022-08-26T08:56:14Z</Appointment:Date>
     <Appointment:ActivityInformation xsi:type="Appointment:ActivitySummary">
      <Appointment:NumBusyActivities xsi:type="xsd:int">0</Appointment:NumBusyActivities>
      <Appointment:NumFreeActivities xsi:type="xsd:int">0</Appointment:NumFreeActivities>
      <Appointment:PercentageBusy xsi:type="xsd:int">0</Appointment:PercentageBusy>
     </Appointment:ActivityInformation>
    </Appointment:ActivityInformationListItem>
   </Appointment:Response>
  </Appointment:GetActivityInformationListByDatesAndAssociateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
