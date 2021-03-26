---
uid: services80-person-getpersonimage
title: Services80.PersonAgent.GetPersonImage SOAP
Generated: true
---

# Services80 Person GetPersonImage SOAP

SOAP request and response examples **Remote/Services80/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IPersonAgent.GetPersonImage">SuperOffice.Services80.IPersonAgent.GetPersonImage</see> method.

## GetPersonImage

Returns the person image that is displayed in the CRM application.

* **personId:** The person id of the person the image belongs to.

**Returns:** The image as a System.Drawing.Image. (If the the image is returned over webservices, the stream is returned as a Base64 encoded string.)


[WSDL file for Services80/Person](../Services80-Person.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPersonImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Person:ApplicationToken>1234567-1234-9876</Person:ApplicationToken>
  <Person:Credentials>
    <Person:Ticket>7T:1234abcxyzExample==</Person:Ticket>
  </Person:Credentials>
 <SOAP-ENV:Body>
   <Person:GetPersonImage>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
   </Person:GetPersonImage>

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
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Person:GetPersonImageResponse>
   <Person:Response xsi:type="xsd:base64Binary"></Person:Response>
  </Person:GetPersonImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

