---
uid: services82-email-createdefaultemailenvelope
title: Services82.EMailAgent.CreateDefaultEMailEnvelope SOAP
Generated: true
---

# Services82 EMail CreateDefaultEMailEnvelope SOAP

SOAP request and response examples **Remote/Services82/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IEMailAgent.CreateDefaultEMailEnvelope">SuperOffice.Services82.IEMailAgent.CreateDefaultEMailEnvelope</see> method.

## CreateDefaultEMailEnvelope

Loading default values into a new EMailEnvelope.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New EMailEnvelope with default values


[WSDL file for Services82/EMail](../Services82-EMail.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultEMailEnvelope Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:CreateDefaultEMailEnvelope>
   </EMail:CreateDefaultEMailEnvelope>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultEMailEnvelope Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <EMail:CreateDefaultEMailEnvelopeResponse>
   <EMail:Response xsi:type="EMail:EMailEnvelope">
    <EMail:ServerId xsi:type="xsd:int">0</EMail:ServerId>
    <EMail:MessageId xsi:type="xsd:string"></EMail:MessageId>
    <EMail:Subject xsi:type="xsd:string"></EMail:Subject>
    <EMail:From xsi:type="EMail:EMailAddress">
     <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
     <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
     <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
     <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
     <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
     <EMail:Address xsi:type="xsd:string"></EMail:Address>
     <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
    </EMail:From>
    <EMail:To xsi:type="EMail:ArrayOfEMailAddress">
     <EMail:EMailAddress xsi:type="EMail:EMailAddress">
      <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
      <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
      <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
      <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
      <EMail:Address xsi:type="xsd:string"></EMail:Address>
      <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
     </EMail:EMailAddress>
    </EMail:To>
    <EMail:Sent xsi:type="xsd:dateTime">2021-03-25T21:34:45Z</EMail:Sent>
    <EMail:Priority xsi:type="EMail:EMailPriority">NoPriority</EMail:Priority>
    <EMail:Flags xsi:type="EMail:EMailFlags">Seen</EMail:Flags>
    <EMail:Size xsi:type="xsd:int">0</EMail:Size>
    <EMail:EMailSOInfo xsi:type="EMail:EMailSOInfo">
     <EMail:DocumentId xsi:type="xsd:int">0</EMail:DocumentId>
     <EMail:AppointmentId xsi:type="xsd:int">0</EMail:AppointmentId>
     <EMail:ProjectId xsi:type="xsd:int">0</EMail:ProjectId>
     <EMail:SaleId xsi:type="xsd:int">0</EMail:SaleId>
     <EMail:Archived xsi:type="xsd:boolean">false</EMail:Archived>
    </EMail:EMailSOInfo>
   </EMail:Response>
  </EMail:CreateDefaultEMailEnvelopeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

