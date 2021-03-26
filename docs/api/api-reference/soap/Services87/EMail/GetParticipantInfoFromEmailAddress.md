---
uid: services87-email-getparticipantinfofromemailaddress
title: Services87.EMailAgent.GetParticipantInfoFromEmailAddress SOAP
Generated: true
---

# Services87 EMail GetParticipantInfoFromEmailAddress SOAP

SOAP request and response examples **Remote/Services87/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IEMailAgent.GetParticipantInfoFromEmailAddress">SuperOffice.Services87.IEMailAgent.GetParticipantInfoFromEmailAddress</see> method.

## GetParticipantInfoFromEmailAddress

Get participant data associated with the participant in the emails iCal attachment
<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.

* **emailAddress:** Email address of participant
* **appointmentId:** Appointment id of participant

**Returns:** Person information


[WSDL file for Services87/EMail](../Services87-EMail.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetParticipantInfoFromEmailAddress Request

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
   <EMail:GetParticipantInfoFromEmailAddress>
    <EMail:EmailAddress xsi:type="xsd:string"></EMail:EmailAddress>
    <EMail:AppointmentId xsi:type="xsd:int">0</EMail:AppointmentId>
   </EMail:GetParticipantInfoFromEmailAddress>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetParticipantInfoFromEmailAddress Response

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
  <EMail:GetParticipantInfoFromEmailAddressResponse>
   <EMail:Response xsi:type="EMail:Person">
    <EMail:Position xsi:type="xsd:string"></EMail:Position>
    <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
    <EMail:Mrmrs xsi:type="xsd:string"></EMail:Mrmrs>
    <EMail:Firstname xsi:type="xsd:string"></EMail:Firstname>
    <EMail:Lastname xsi:type="xsd:string"></EMail:Lastname>
    <EMail:MiddleName xsi:type="xsd:string"></EMail:MiddleName>
    <EMail:Title xsi:type="xsd:string"></EMail:Title>
    <EMail:Description xsi:type="xsd:string"></EMail:Description>
    <EMail:Email xsi:type="xsd:string"></EMail:Email>
    <EMail:FullName xsi:type="xsd:string"></EMail:FullName>
    <EMail:DirectPhone xsi:type="xsd:string"></EMail:DirectPhone>
    <EMail:FormalName xsi:type="xsd:string"></EMail:FormalName>
    <EMail:CountryId xsi:type="xsd:int">0</EMail:CountryId>
    <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
    <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
    <EMail:Retired xsi:type="xsd:short">0</EMail:Retired>
    <EMail:Rank xsi:type="xsd:short">0</EMail:Rank>
    <EMail:ActiveInterests xsi:type="xsd:short">0</EMail:ActiveInterests>
    <EMail:ContactDepartment xsi:type="xsd:string"></EMail:ContactDepartment>
    <EMail:ContactCountryId xsi:type="xsd:int">0</EMail:ContactCountryId>
    <EMail:ContactOrgNr xsi:type="xsd:string"></EMail:ContactOrgNr>
    <EMail:FaxPhone xsi:type="xsd:string"></EMail:FaxPhone>
    <EMail:MobilePhone xsi:type="xsd:string"></EMail:MobilePhone>
    <EMail:ContactPhone xsi:type="xsd:string"></EMail:ContactPhone>
    <EMail:AssociateName xsi:type="xsd:string"></EMail:AssociateName>
    <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
    <EMail:UsePersonAddress xsi:type="xsd:boolean">false</EMail:UsePersonAddress>
    <EMail:ContactFax xsi:type="xsd:string"></EMail:ContactFax>
    <EMail:Kanafname xsi:type="xsd:string"></EMail:Kanafname>
    <EMail:Kanalname xsi:type="xsd:string"></EMail:Kanalname>
    <EMail:Post1 xsi:type="xsd:string"></EMail:Post1>
    <EMail:Post2 xsi:type="xsd:string"></EMail:Post2>
    <EMail:Post3 xsi:type="xsd:string"></EMail:Post3>
    <EMail:EmailName xsi:type="xsd:string"></EMail:EmailName>
    <EMail:ContactFullName xsi:type="xsd:string"></EMail:ContactFullName>
    <EMail:ActiveErpLinks xsi:type="xsd:int">0</EMail:ActiveErpLinks>
    <EMail:TicketPriorityId xsi:type="xsd:int">0</EMail:TicketPriorityId>
    <EMail:SupportLanguageId xsi:type="xsd:int">0</EMail:SupportLanguageId>
    <EMail:SupportAssociateId xsi:type="xsd:int">0</EMail:SupportAssociateId>
    <EMail:CategoryName xsi:type="xsd:string"></EMail:CategoryName>
   </EMail:Response>
  </EMail:GetParticipantInfoFromEmailAddressResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

