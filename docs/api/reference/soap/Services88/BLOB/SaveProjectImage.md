---
title: Services88.BLOBAgent.SaveProjectImage SOAP
generated: 1
uid: Services88-BLOB-SaveProjectImage
---

# Services88 BLOB SaveProjectImage

SOAP request and response examples **Remote/Services88/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IBLOBAgent.SaveProjectImage">SuperOffice.Services88.IBLOBAgent.SaveProjectImage</see> method.

## SaveProjectImage

Saves a project image that is displayed in the CRM application's project image selection dialog to the database.

* **description:** Image description. Should be image name (e.g. winter.jpg) for project images
* **image:** The project image (System.Drawing.Image)



[WSDL file for Services88/BLOB](../Services88-BLOB.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveProjectImage Request

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
   <BLOB:SaveProjectImage>
    <BLOB:Description xsi:type="xsd:string"></BLOB:Description>
    <BLOB:Image xsi:type="xsd:base64Binary"></BLOB:Image>
   </BLOB:SaveProjectImage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveProjectImage Response

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
  <BLOB:SaveProjectImageResponse>
  </BLOB:SaveProjectImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

