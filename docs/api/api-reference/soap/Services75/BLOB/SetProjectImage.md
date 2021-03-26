---
uid: services75-blob-setprojectimage
title: Services75.BLOBAgent.SetProjectImage SOAP
Generated: true
---

# Services75 BLOB SetProjectImage SOAP

SOAP request and response examples **Remote/Services75/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IBLOBAgent.SetProjectImage">SuperOffice.Services75.IBLOBAgent.SetProjectImage</see> method.

## SetProjectImage

Stores the project image that is displayed in the CRM application.

* **projectId:** The project id of the project the image belongs to.
* **image:** The image that is stored on the project (System.Drawing.Image)



[WSDL file for Services75/BLOB](../Services75-BLOB.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetProjectImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <BLOB:ApplicationToken>1234567-1234-9876</BLOB:ApplicationToken>
  <BLOB:Credentials>
    <BLOB:Ticket>7T:1234abcxyzExample==</BLOB:Ticket>
  </BLOB:Credentials>
 <SOAP-ENV:Body>
   <BLOB:SetProjectImage>
    <BLOB:ProjectId xsi:type="xsd:int">0</BLOB:ProjectId>
    <BLOB:Image xsi:type="xsd:base64Binary"></BLOB:Image>
   </BLOB:SetProjectImage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetProjectImage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <BLOB:SetProjectImageResponse>
  </BLOB:SetProjectImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

