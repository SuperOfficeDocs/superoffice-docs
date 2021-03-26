---
uid: services84-person-createtemporarykey
title: Services84.PersonAgent.CreateTemporaryKey SOAP
Generated: true
---

# Services84 Person CreateTemporaryKey SOAP

SOAP request and response examples **Remote/Services84/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IPersonAgent.CreateTemporaryKey">SuperOffice.Services84.IPersonAgent.CreateTemporaryKey</see> method.

## CreateTemporaryKey

Create a temporary key in the database from the given parameters and return the key string. Used for temporary keys for accessing customer centric functionality, such as UpdateSubscriptions.

* **domain:** The domain this key is for
* **targetId:** The primary key of the entity this is for. Depends on domain.
* **personId:** The person this key is for. May be null.
* **expires:** When the key will expire (servers local time)

**Returns:** The key as base64, ready to be used e.g. in a URL


[WSDL file for Services84/Person](../Services84-Person.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateTemporaryKey Request

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
   <Person:CreateTemporaryKey>
    <Person:Domain xsi:type="Person:TemporaryKeyDomain">Unknown</Person:Domain>
    <Person:TargetId xsi:type="xsd:int">0</Person:TargetId>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:Expires xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:Expires>
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
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Person:CreateTemporaryKeyResponse>
   <Person:Response xsi:type="xsd:string"></Person:Response>
  </Person:CreateTemporaryKeyResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

