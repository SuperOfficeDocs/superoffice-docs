---
title: Services84.AppointmentAgent.GetRedLetterInformationListByDatesAndAssociate SOAP
generated: 1
uid: Services84-Appointment-GetRedLetterInformationListByDatesAndAssociate
---

# Services84 Appointment GetRedLetterInformationListByDatesAndAssociate

SOAP request and response examples **Remote/Services84/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IAppointmentAgent.GetRedLetterInformationListByDatesAndAssociate">SuperOffice.Services84.IAppointmentAgent.GetRedLetterInformationListByDatesAndAssociate</see> method.

## GetRedLetterInformationListByDatesAndAssociate

Get detailed red letter day information (redletter summary + individual day texts) for one or more days according to the given date interval. The time portion of the dates is ignored.

* **startDate:** Start date of interval. Time portion is ignored.
* **endDate:** End date of interval. Time portion is ignored.
* **associateId:** Associate id to identify the calendar to scan. If 0 is passed in, the currently authenticated associate is used instead.

**Returns:** Exactly one item per day of the given time span is returned. Days where nothing happens will have all values set to 0, but will still be in the returned array. Start end dates are treated as inclusive.


[WSDL file for Services84/Appointment](../Services84-Appointment.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetRedLetterInformationListByDatesAndAssociate Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:GetRedLetterInformationListByDatesAndAssociate>
    <Appointment:StartDate xsi:type="xsd:dateTime">2021-11-30T13:22:04Z</Appointment:StartDate>
    <Appointment:EndDate xsi:type="xsd:dateTime">2021-11-30T13:22:04Z</Appointment:EndDate>
    <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
   </Appointment:GetRedLetterInformationListByDatesAndAssociate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetRedLetterInformationListByDatesAndAssociate Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Appointment:GetRedLetterInformationListByDatesAndAssociateResponse>
   <Appointment:Response xsi:type="Appointment:ArrayOfRedLetterInformationListItem">
    <Appointment:RedLetterInformationListItem xsi:type="Appointment:RedLetterInformationListItem">
     <Appointment:Date xsi:type="xsd:dateTime">2021-11-30T13:22:04Z</Appointment:Date>
     <Appointment:RedLetterInformation xsi:type="Appointment:RedLetterSummary">
      <Appointment:IsOwnCountryHoliday xsi:type="xsd:boolean">false</Appointment:IsOwnCountryHoliday>
      <Appointment:IsOtherCountryHoliday xsi:type="xsd:boolean">false</Appointment:IsOtherCountryHoliday>
     </Appointment:RedLetterInformation>
     <Appointment:RedLetterDetails xsi:type="Appointment:RedLetterDetails">
      <Appointment:OwnCountryDayTexts xsi:type="NetServerServices842:ArrayOfstring">
       <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
      </Appointment:OwnCountryDayTexts>
      <Appointment:OtherCountryDayTexts xsi:type="NetServerServices842:ArrayOfstring">
       <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
      </Appointment:OtherCountryDayTexts>
     </Appointment:RedLetterDetails>
    </Appointment:RedLetterInformationListItem>
   </Appointment:Response>
  </Appointment:GetRedLetterInformationListByDatesAndAssociateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

