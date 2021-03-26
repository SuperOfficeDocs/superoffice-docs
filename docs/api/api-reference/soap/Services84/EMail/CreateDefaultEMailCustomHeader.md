---
uid: services84-email-createdefaultemailcustomheader
title: Services84.EMailAgent.CreateDefaultEMailCustomHeader SOAP
Generated: true
---

# Services84 EMail CreateDefaultEMailCustomHeader SOAP

SOAP request and response examples **Remote/Services84/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IEMailAgent.CreateDefaultEMailCustomHeader">SuperOffice.Services84.IEMailAgent.CreateDefaultEMailCustomHeader</see> method.

## CreateDefaultEMailCustomHeader

Loading default values into a new EMailCustomHeader.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New EMailCustomHeader with default values


[WSDL file for Services84/EMail](../Services84-EMail.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultEMailCustomHeader Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:CreateDefaultEMailCustomHeader>
   </EMail:CreateDefaultEMailCustomHeader>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultEMailCustomHeader Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <EMail:CreateDefaultEMailCustomHeaderResponse>
   <EMail:Response xsi:type="EMail:EMailCustomHeader">
    <EMail:Name xsi:type="xsd:string"></EMail:Name>
    <EMail:Values xsi:type="NetServerServices842:ArrayOfstring">
     <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
    </EMail:Values>
   </EMail:Response>
  </EMail:CreateDefaultEMailCustomHeaderResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

