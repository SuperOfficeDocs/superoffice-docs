---
uid: services82-audience-getdefaultcountryflag
title: Services82.AudienceAgent.GetDefaultCountryFlag SOAP
Generated: true
---

# Services82 Audience GetDefaultCountryFlag SOAP

SOAP request and response examples **Remote/Services82/Audience.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IAudienceAgent.GetDefaultCountryFlag">SuperOffice.Services82.IAudienceAgent.GetDefaultCountryFlag</see> method.

## GetDefaultCountryFlag

Returns the default country flag image that is displayed in Audience when no person image is found. The image belongs to a specific Audience layout instance.

* **layoutName:** Name of the Audience layout instance

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a Base64 encoded string.)


[WSDL file for Services82/Audience](../Services82-Audience.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDefaultCountryFlag Request

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
   <Audience:GetDefaultCountryFlag>
    <Audience:LayoutName xsi:type="xsd:string"></Audience:LayoutName>
   </Audience:GetDefaultCountryFlag>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDefaultCountryFlag Response

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
  <Audience:GetDefaultCountryFlagResponse>
   <Audience:Response xsi:type="xsd:base64Binary"></Audience:Response>
  </Audience:GetDefaultCountryFlagResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

