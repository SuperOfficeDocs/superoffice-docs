---
title: Services84.PersonAgent.SetPersonImage SOAP
generated: 1
uid: Services84-Person-SetPersonImage
---

# Services84 Person SetPersonImage

SOAP request and response examples **Remote/Services84/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IPersonAgent.SetPersonImage">SuperOffice.Services84.IPersonAgent.SetPersonImage</see> method.

## SetPersonImage

Stores the person image that is displayed in the CRM application.

* **personId:** The person id of the person the image belongs to.
* **image:** The image that is stored on the person (System.Drawing.Image)



[WSDL file for Services84/Person](../Services84-Person.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetPersonImage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services84">
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
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Person:SetPersonImageResponse>
  </Person:SetPersonImageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

