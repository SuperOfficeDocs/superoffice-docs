---
uid: services84-audience-getlogoimage
title: Services84.AudienceAgent.GetLogoImage SOAP
Generated: true
---

# Services84 Audience GetLogoImage SOAP

SOAP request and response examples **Remote/Services84/Audience.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IAudienceAgent.GetLogoImage">SuperOffice.Services84.IAudienceAgent.GetLogoImage</see> method.

## GetLogoImage



* **layoutName:** 



[WSDL file for Services84/Audience](../Services84-Audience.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetLogoImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Audience:ApplicationToken>1234567-1234-9876</Audience:ApplicationToken>
  <Audience:Credentials>
    <Audience:Ticket>7T:1234abcxyzExample==</Audience:Ticket>
  </Audience:Credentials>
 <SOAP-ENV:Body>
   <Audience:GetLogoImage>
    <Audience:LayoutName xsi:type="xsd:string"></Audience:LayoutName>
   </Audience:GetLogoImage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetLogoImage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Audience:GetLogoImageResponse>
   <Audience:Response xsi:type="xsd:base64Binary"></Audience:Response>
  </Audience:GetLogoImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

