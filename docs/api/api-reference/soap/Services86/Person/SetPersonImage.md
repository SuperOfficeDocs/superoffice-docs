---
uid: services86-person-setpersonimage
title: Services86.PersonAgent.SetPersonImage SOAP
Generated: true
---

# Services86 Person SetPersonImage SOAP

SOAP request and response examples **Remote/Services86/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IPersonAgent.SetPersonImage">SuperOffice.Services86.IPersonAgent.SetPersonImage</see> method.

## SetPersonImage

Stores the person image that is displayed in the CRM application.

* **personId:** The person id of the person the image belongs to.
* **image:** The image that is stored on the person (System.Drawing.Image)



[WSDL file for Services86/Person](../Services86-Person.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetPersonImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Person:ApplicationToken>1234567-1234-9876</Person:ApplicationToken>
  <Person:Credentials>
    <Person:Ticket>7T:1234abcxyzExample==</Person:Ticket>
  </Person:Credentials>
 <SOAP-ENV:Body>
   <Person:SetPersonImage>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:Image xsi:type="xsd:base64Binary"></Person:Image>
   </Person:SetPersonImage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetPersonImage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Person:SetPersonImageResponse>
  </Person:SetPersonImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

