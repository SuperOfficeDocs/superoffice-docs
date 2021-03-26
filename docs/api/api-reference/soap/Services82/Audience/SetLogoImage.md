---
uid: services82-audience-setlogoimage
title: Services82.AudienceAgent.SetLogoImage SOAP
Generated: true
---

# Services82 Audience SetLogoImage SOAP

SOAP request and response examples **Remote/Services82/Audience.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IAudienceAgent.SetLogoImage">SuperOffice.Services82.IAudienceAgent.SetLogoImage</see> method.

## SetLogoImage



* **layoutName:** 
* **image:** 



[WSDL file for Services82/Audience](../Services82-Audience.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetLogoImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <Audience:ApplicationToken>1234567-1234-9876</Audience:ApplicationToken>
  <Audience:Credentials>
    <Audience:Ticket>7T:1234abcxyzExample==</Audience:Ticket>
  </Audience:Credentials>
 <SOAP-ENV:Body>
   <Audience:SetLogoImage>
    <Audience:LayoutName xsi:type="xsd:string"></Audience:LayoutName>
    <Audience:Image xsi:type="xsd:base64Binary"></Audience:Image>
   </Audience:SetLogoImage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetLogoImage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <Audience:SetLogoImageResponse>
  </Audience:SetLogoImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

