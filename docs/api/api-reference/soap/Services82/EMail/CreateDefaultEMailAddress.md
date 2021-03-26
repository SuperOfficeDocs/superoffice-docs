---
uid: services82-email-createdefaultemailaddress
title: Services82.EMailAgent.CreateDefaultEMailAddress SOAP
Generated: true
---

# Services82 EMail CreateDefaultEMailAddress SOAP

SOAP request and response examples **Remote/Services82/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IEMailAgent.CreateDefaultEMailAddress">SuperOffice.Services82.IEMailAgent.CreateDefaultEMailAddress</see> method.

## CreateDefaultEMailAddress

Loading default values into a new EMailAddress.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New EMailAddress with default values


[WSDL file for Services82/EMail](../Services82-EMail.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultEMailAddress Request

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
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services82">
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
   </EMail:Response>
  </EMail:CreateDefaultEMailAddressResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

