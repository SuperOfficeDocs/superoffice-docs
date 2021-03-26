---
uid: services83-appointment-getnextsuggestedappointmentbysale
title: Services83.AppointmentAgent.GetNextSuggestedAppointmentBySale SOAP
Generated: true
---

# Services83 Appointment GetNextSuggestedAppointmentBySale SOAP

SOAP request and response examples **Remote/Services83/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IAppointmentAgent.GetNextSuggestedAppointmentBySale">SuperOffice.Services83.IAppointmentAgent.GetNextSuggestedAppointmentBySale</see> method.

## GetNextSuggestedAppointmentBySale

Gets the next suggested appointment for a given sale (or rather a given sale's guide).

* **saleId:** The identifier of the (guided) sale from which we want to find a suggested appointment
* **currentAppointmentId:** The identifier of the appointment from which we calculate the next suggestion. The next suggested appointment is the subsequent appointment defined in the SoAdmin's sales guide.
* **skipCompleteCheck:** If you want to get the next appointment step in a sales guide for an appointment which is not completed, this value must be true. In all other cases, this value should be false, as it would return the value of null if the current appointment is not completes.

**Returns:** The next suggestion based on the sale id of a guided sale and the id of the current apopintment. If we cannot find a next suggestion or the sale is not guided (or if any of the paramters are invalid), we will return null.


[WSDL file for Services83/Appointment](../Services83-Appointment.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNextSuggestedAppointmentBySale Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:GetNextSuggestedAppointmentBySale>
    <Appointment:SaleId xsi:type="xsd:int">0</Appointment:SaleId>
    <Appointment:CurrentAppointmentId xsi:type="xsd:int">0</Appointment:CurrentAppointmentId>
    <Appointment:SkipCompleteCheck xsi:type="xsd:boolean">false</Appointment:SkipCompleteCheck>
   </Appointment:GetNextSuggestedAppointmentBySale>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetNextSuggestedAppointmentBySale Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Appointment:GetNextSuggestedAppointmentBySaleResponse>
   <Appointment:Response xsi:type="Appointment:SuggestedAppointment">
    <Appointment:AutoSuggest xsi:type="xsd:short">0</Appointment:AutoSuggest>
    <Appointment:Deleted xsi:type="xsd:short">0</Appointment:Deleted>
    <Appointment:DaysFuture xsi:type="xsd:short">0</Appointment:DaysFuture>
    <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
    <Appointment:Text xsi:type="xsd:string"></Appointment:Text>
    <Appointment:TaskId xsi:type="xsd:int">0</Appointment:TaskId>
    <Appointment:SuggestedAppointmentId xsi:type="xsd:int">0</Appointment:SuggestedAppointmentId>
    <Appointment:SaleTypeStageLinkId xsi:type="xsd:int">0</Appointment:SaleTypeStageLinkId>
    <Appointment:RegisteredAssociateId xsi:type="xsd:int">0</Appointment:RegisteredAssociateId>
    <Appointment:Rank xsi:type="xsd:short">0</Appointment:Rank>
    <Appointment:ProjectTypeStatusLinkId xsi:type="xsd:int">0</Appointment:ProjectTypeStatusLinkId>
    <Appointment:Name xsi:type="xsd:string"></Appointment:Name>
    <Appointment:Duration xsi:type="xsd:short">0</Appointment:Duration>
    <Appointment:Associate xsi:type="Appointment:Associate">
     <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
     <Appointment:Name xsi:type="xsd:string"></Appointment:Name>
     <Appointment:PersonId xsi:type="xsd:int">0</Appointment:PersonId>
     <Appointment:Rank xsi:type="xsd:short">0</Appointment:Rank>
     <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
     <Appointment:Type xsi:type="Appointment:UserType">Unknown</Appointment:Type>
     <Appointment:GroupIdx xsi:type="xsd:int">0</Appointment:GroupIdx>
     <Appointment:FullName xsi:type="xsd:string"></Appointment:FullName>
     <Appointment:FormalName xsi:type="xsd:string"></Appointment:FormalName>
     <Appointment:Deleted xsi:type="xsd:boolean">false</Appointment:Deleted>
     <Appointment:EjUserId xsi:type="xsd:int">0</Appointment:EjUserId>
    </Appointment:Associate>
   </Appointment:Response>
  </Appointment:GetNextSuggestedAppointmentBySaleResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

