---
title: Services88.BLOBAgent.GetProjectImageWithSize SOAP
generated: 1
uid: Services88-BLOB-GetProjectImageWithSize
---

# Services88 BLOB GetProjectImageWithSize

SOAP request and response examples **Remote/Services88/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IBLOBAgent.GetProjectImageWithSize">SuperOffice.Services88.IBLOBAgent.GetProjectImageWithSize</see> method.

## GetProjectImageWithSize

Returns the project image that is displayed in the CRM application with a specified maximum size.

* **projectId:** The project id of the project the image belongs to.
* **width:** The maximum with of the returned image. Specify &lt;= 0 to preserve aspect ratio of existing image
* **height:** The maximum height of the returned image. Specify &lt;= 0 to preserve aspect ratio of existing image

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a jpeg/base64 encoded string.)


[WSDL file for Services88/BLOB](../Services88-BLOB.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProjectImageWithSize Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <BLOB:ApplicationToken>1234567-1234-9876</BLOB:ApplicationToken>
  <BLOB:Credentials>
    <BLOB:Ticket>7T:1234abcxyzExample==</BLOB:Ticket>
  </BLOB:Credentials>
 <SOAP-ENV:Body>
   <BLOB:GetProjectImageWithSize>
    <BLOB:ProjectId xsi:type="xsd:int">0</BLOB:ProjectId>
    <BLOB:Width xsi:type="xsd:int">0</BLOB:Width>
    <BLOB:Height xsi:type="xsd:int">0</BLOB:Height>
   </BLOB:GetProjectImageWithSize>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetProjectImageWithSize Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <BLOB:GetProjectImageWithSizeResponse>
   <BLOB:Response xsi:type="xsd:base64Binary"></BLOB:Response>
  </BLOB:GetProjectImageWithSizeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

