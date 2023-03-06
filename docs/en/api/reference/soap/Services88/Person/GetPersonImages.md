---
title: Services88.PersonAgent.GetPersonImages SOAP
generated: 1
uid: Services88-Person-GetPersonImages
---

# Services88 Person GetPersonImages

SOAP request and response examples **Remote/Services88/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPersonAgent.GetPersonImages">SuperOffice.Services88.IPersonAgent.GetPersonImages</see> method.

## GetPersonImages





[WSDL file for Services88/Person](../Services88-Person.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPersonImages Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Person:ApplicationToken>1234567-1234-9876</Person:ApplicationToken>
  <Person:Credentials>
    <Person:Ticket>7T:1234abcxyzExample==</Person:Ticket>
  </Person:Credentials>
 <SOAP-ENV:Body>
   <Person:GetPersonImages>
    <Person:PersonIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Person:PersonIds>
    <Person:ScaledWidth xsi:type="xsd:int">0</Person:ScaledWidth>
    <Person:ScaledHeight xsi:type="xsd:int">0</Person:ScaledHeight>
   </Person:GetPersonImages>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPersonImages Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Person:GetPersonImagesResponse>
   <Person:Response xsi:type="Person:ArrayOfPersonImage">
    <Person:PersonImage xsi:type="Person:PersonImage">
     <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
     <Person:ImageData xsi:type="xsd:base64Binary"></Person:ImageData>
    </Person:PersonImage>
   </Person:Response>
  </Person:GetPersonImagesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

