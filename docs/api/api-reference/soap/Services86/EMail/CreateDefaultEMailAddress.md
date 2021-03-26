---
uid: services86-email-createdefaultemailaddress
title: Services86.EMailAgent.CreateDefaultEMailAddress SOAP
Generated: true
---

# Services86 EMail CreateDefaultEMailAddress SOAP

SOAP request and response examples **Remote/Services86/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IEMailAgent.CreateDefaultEMailAddress">SuperOffice.Services86.IEMailAgent.CreateDefaultEMailAddress</see> method.

## CreateDefaultEMailAddress

Loading default values into a new EMailAddress.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.


**Returns:** New EMailAddress with default values


[WSDL file for Services86/EMail](../Services86-EMail.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultEMailAddress Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:CreateDefaultEMailAddress>
   </EMail:CreateDefaultEMailAddress>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultEMailAddress Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <EMail:CreateDefaultEMailAddressResponse>
   <EMail:Response xsi:type="EMail:EMailAddress">
    <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
    <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
    <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
    <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
    <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
    <EMail:Address xsi:type="xsd:string"></EMail:Address>
    <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
    <EMail:DuplicatePersonIds xsi:type="NetServerServices862:ArrayOfint">
     <NetServerServices862:int xsi:type="xsd:int">0</NetServerServices862:int>
    </EMail:DuplicatePersonIds>
    <EMail:Name xsi:type="xsd:string"></EMail:Name>
   </EMail:Response>
  </EMail:CreateDefaultEMailAddressResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

