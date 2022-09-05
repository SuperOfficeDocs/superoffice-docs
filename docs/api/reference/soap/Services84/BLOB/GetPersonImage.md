---
title: Services84.BLOBAgent.GetPersonImage SOAP
generated: 1
uid: Services84-BLOB-GetPersonImage
---

# Services84 BLOB GetPersonImage

SOAP request and response examples **Remote/Services84/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IBLOBAgent.GetPersonImage">SuperOffice.Services84.IBLOBAgent.GetPersonImage</see> method.

## GetPersonImage

Returns the person image that is displayed in the CRM application.

* **personId:** The person id of the person the image belongs to.

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a Base64 encoded string.)


[WSDL file for Services84/BLOB](../Services84-BLOB.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPersonImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <BLOB:ApplicationToken>1234567-1234-9876</BLOB:ApplicationToken>
  <BLOB:Credentials>
    <BLOB:Ticket>7T:1234abcxyzExample==</BLOB:Ticket>
  </BLOB:Credentials>
 <SOAP-ENV:Body>
   <BLOB:GetPersonImage>
    <BLOB:PersonId xsi:type="xsd:int">0</BLOB:PersonId>
   </BLOB:GetPersonImage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPersonImage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <BLOB:GetPersonImageResponse>
   <BLOB:Response xsi:type="xsd:base64Binary"></BLOB:Response>
  </BLOB:GetPersonImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

