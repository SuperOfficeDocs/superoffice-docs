---
title: Services88.PersonAgent.CreateTemporaryKeyWithPayload SOAP
generated: true
uid: Services88-Person-CreateTemporaryKeyWithPayload
content_type: reference
---

# Services88 Person CreateTemporaryKeyWithPayload

SOAP request and response examples **Remote/Services88/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPersonAgent.CreateTemporaryKeyWithPayload">SuperOffice.Services88.IPersonAgent.CreateTemporaryKeyWithPayload</see> method.

## CreateTemporaryKeyWithPayload





[WSDL file for Services88/Person](../Services88-Person.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateTemporaryKeyWithPayload Request

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
   <Person:CreateTemporaryKeyWithPayload>
    <Person:Domain xsi:type="Person:TemporaryKeyDomain">Unknown</Person:Domain>
    <Person:TargetId xsi:type="xsd:int">0</Person:TargetId>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:Expires xsi:type="xsd:dateTime">2025-09-19T01:40:55Z</Person:Expires>
    <Person:Payload xsi:type="xsd:string"></Person:Payload>
   </Person:CreateTemporaryKeyWithPayload>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateTemporaryKeyWithPayload Response

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
  <Person:CreateTemporaryKeyWithPayloadResponse>
   <Person:Response xsi:type="xsd:string"></Person:Response>
  </Person:CreateTemporaryKeyWithPayloadResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

