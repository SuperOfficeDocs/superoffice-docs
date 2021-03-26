---
uid: services86-person-checktemporarykey
title: Services86.PersonAgent.CheckTemporaryKey SOAP
Generated: true
---

# Services86 Person CheckTemporaryKey SOAP

SOAP request and response examples **Remote/Services86/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IPersonAgent.CheckTemporaryKey">SuperOffice.Services86.IPersonAgent.CheckTemporaryKey</see> method.

## CheckTemporaryKey

Check a temporary key for validity, and in case it is valid, return its domain, targetId and personId

* **temporaryKey:** The base64 encoded key value, as returned by CreateTemporaryKey

**Returns:** The info about the temporary key. Domain will be Unknown if key is not valid.


[WSDL file for Services86/Person](../Services86-Person.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CheckTemporaryKey Request

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
   <Person:CheckTemporaryKey>
    <Person:TemporaryKey xsi:type="xsd:string"></Person:TemporaryKey>
   </Person:CheckTemporaryKey>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CheckTemporaryKey Response

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
  <Person:CheckTemporaryKeyResponse>
   <Person:Response xsi:type="Person:TemporaryKeyInfo">
    <Person:Domain xsi:type="Person:TemporaryKeyDomain">Unknown</Person:Domain>
    <Person:TargetId xsi:type="xsd:int">0</Person:TargetId>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:IsExpired xsi:type="xsd:boolean">false</Person:IsExpired>
   </Person:Response>
  </Person:CheckTemporaryKeyResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

