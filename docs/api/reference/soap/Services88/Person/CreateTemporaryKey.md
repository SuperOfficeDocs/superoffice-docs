---
title: Services88.PersonAgent.CreateTemporaryKey SOAP
generated: 1
uid: Services88-Person-CreateTemporaryKey
---

# Services88 Person CreateTemporaryKey

SOAP request and response examples **Remote/Services88/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPersonAgent.CreateTemporaryKey">SuperOffice.Services88.IPersonAgent.CreateTemporaryKey</see> method.

## CreateTemporaryKey

Create a temporary key in the database from the given parameters and return the key string. Used for temporary keys for accessing customer centric functionality, such as UpdateSubscriptions.

* **domain:** The domain this key is for
* **targetId:** The primary key of the entity this is for. Depends on domain.
* **personId:** The person this key is for. May be null.
* **expires:** When the key will expire (servers local time)

**Returns:** The key as base64, ready to be used e.g. in a URL


[WSDL file for Services88/Person](../Services88-Person.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateTemporaryKey Request

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
   <Person:CreateTemporaryKey>
    <Person:Domain xsi:type="Person:TemporaryKeyDomain">Unknown</Person:Domain>
    <Person:TargetId xsi:type="xsd:int">0</Person:TargetId>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:Expires xsi:type="xsd:dateTime">2021-11-30T13:23:46Z</Person:Expires>
   </Person:CreateTemporaryKey>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateTemporaryKey Response

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
  <Person:CreateTemporaryKeyResponse>
   <Person:Response xsi:type="xsd:string"></Person:Response>
  </Person:CreateTemporaryKeyResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

