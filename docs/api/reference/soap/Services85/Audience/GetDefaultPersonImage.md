---
title: Services85.AudienceAgent.GetDefaultPersonImage SOAP
generated: 1
uid: Services85-Audience-GetDefaultPersonImage
---

# Services85 Audience GetDefaultPersonImage

SOAP request and response examples **Remote/Services85/Audience.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IAudienceAgent.GetDefaultPersonImage">SuperOffice.Services85.IAudienceAgent.GetDefaultPersonImage</see> method.

## GetDefaultPersonImage

Returns the default person (sales rep) image that is displayed in Audience when no person image is found. The image belongs to a specific Audience layout instance.

* **layoutName:** Name of the Audience layout instance

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a Base64 encoded string.)


[WSDL file for Services85/Audience](../Services85-Audience.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDefaultPersonImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Audience:ApplicationToken>1234567-1234-9876</Audience:ApplicationToken>
  <Audience:Credentials>
    <Audience:Ticket>7T:1234abcxyzExample==</Audience:Ticket>
  </Audience:Credentials>
 <SOAP-ENV:Body>
   <Audience:GetDefaultPersonImage>
    <Audience:LayoutName xsi:type="xsd:string"></Audience:LayoutName>
   </Audience:GetDefaultPersonImage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDefaultPersonImage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Audience:GetDefaultPersonImageResponse>
   <Audience:Response xsi:type="xsd:base64Binary"></Audience:Response>
  </Audience:GetDefaultPersonImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

