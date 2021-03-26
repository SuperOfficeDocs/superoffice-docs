---
uid: services81-project-setprojectimage
title: Services81.ProjectAgent.SetProjectImage SOAP
Generated: true
---

# Services81 Project SetProjectImage SOAP

SOAP request and response examples **Remote/Services81/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IProjectAgent.SetProjectImage">SuperOffice.Services81.IProjectAgent.SetProjectImage</see> method.

## SetProjectImage

Stores the project image that is displayed in the CRM application.

* **projectId:** The project id of the project the image belongs to.
* **image:** The image that is stored on the project (System.Drawing.Image)



[WSDL file for Services81/Project](../Services81-Project.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetProjectImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:SetProjectImage>
    <Project:ProjectId xsi:type="xsd:int">0</Project:ProjectId>
    <Project:Image xsi:type="xsd:base64Binary"></Project:Image>
   </Project:SetProjectImage>

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
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Project:SetProjectImageResponse>
  </Project:SetProjectImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

