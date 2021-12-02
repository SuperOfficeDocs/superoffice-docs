---
title: Services87.AudienceAgent.SetDefaultProjectImage SOAP
generated: 1
uid: Services87-Audience-SetDefaultProjectImage
---

# Services87 Audience SetDefaultProjectImage

SOAP request and response examples **Remote/Services87/Audience.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IAudienceAgent.SetDefaultProjectImage">SuperOffice.Services87.IAudienceAgent.SetDefaultProjectImage</see> method.

## SetDefaultProjectImage

Stores the default project or event image that is displayed in Audience when no project/event image is found. The image is set on a specific Audience layout instance.

* **layoutName:** Name of the Audience layout instance
* **image:** The default project/event image to be stored for this Audience layout instance (System.Drawing.Image)



[WSDL file for Services87/Audience](../Services87-Audience.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetDefaultProjectImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Audience:ApplicationToken>1234567-1234-9876</Audience:ApplicationToken>
  <Audience:Credentials>
    <Audience:Ticket>7T:1234abcxyzExample==</Audience:Ticket>
  </Audience:Credentials>
 <SOAP-ENV:Body>
   <Audience:SetDefaultProjectImage>
    <Audience:LayoutName xsi:type="xsd:string"></Audience:LayoutName>
    <Audience:Image xsi:type="xsd:base64Binary"></Audience:Image>
   </Audience:SetDefaultProjectImage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetDefaultProjectImage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Audience="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Audience:SetDefaultProjectImageResponse>
  </Audience:SetDefaultProjectImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

