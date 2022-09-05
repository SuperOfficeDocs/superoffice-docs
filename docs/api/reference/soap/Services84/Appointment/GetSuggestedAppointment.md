---
title: Services84.AppointmentAgent.GetSuggestedAppointment SOAP
generated: 1
uid: Services84-Appointment-GetSuggestedAppointment
---

# Services84 Appointment GetSuggestedAppointment

SOAP request and response examples **Remote/Services84/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IAppointmentAgent.GetSuggestedAppointment">SuperOffice.Services84.IAppointmentAgent.GetSuggestedAppointment</see> method.

## GetSuggestedAppointment

Gets a SuggestedAppointment object.

* **suggestedAppointmentId:** The identifier of the SuggestedAppointment object

**Returns:** SuggestedAppointment


[WSDL file for Services84/Appointment](../Services84-Appointment.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSuggestedAppointment Request

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
   <Appointment:GetSuggestedAppointment>
    <Appointment:SuggestedAppointmentId xsi:type="xsd:int">0</Appointment:SuggestedAppointmentId>
   </Appointment:GetSuggestedAppointment>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSuggestedAppointment Response

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
  <Appointment:GetSuggestedAppointmentResponse>
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
  </Appointment:GetSuggestedAppointmentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

