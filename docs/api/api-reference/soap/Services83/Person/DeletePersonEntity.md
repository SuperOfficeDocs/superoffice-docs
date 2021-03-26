---
uid: services83-person-deletepersonentity
title: Services83.PersonAgent.DeletePersonEntity SOAP
Generated: true
---

# Services83 Person DeletePersonEntity SOAP

SOAP request and response examples **Remote/Services83/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IPersonAgent.DeletePersonEntity">SuperOffice.Services83.IPersonAgent.DeletePersonEntity</see> method.

## DeletePersonEntity

Deletes the PersonEntity

* **personEntityId:** The identity of the PersonEntity



[WSDL file for Services83/Person](../Services83-Person.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeletePersonEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Person:ApplicationToken>1234567-1234-9876</Person:ApplicationToken>
  <Person:Credentials>
    <Person:Ticket>7T:1234abcxyzExample==</Person:Ticket>
  </Person:Credentials>
 <SOAP-ENV:Body>
   <Person:DeletePersonEntity>
    <Person:PersonEntityId xsi:type="xsd:int">0</Person:PersonEntityId>
   </Person:DeletePersonEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeletePersonEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Person:DeletePersonEntityResponse>
  </Person:DeletePersonEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

