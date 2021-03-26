---
uid: services85-person-undelete
title: Services85.PersonAgent.Undelete SOAP
Generated: true
---

# Services85 Person Undelete SOAP

SOAP request and response examples **Remote/Services85/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IPersonAgent.Undelete">SuperOffice.Services85.IPersonAgent.Undelete</see> method.

## Undelete

This entity supports Soft Delete. Call this method to Undelete a previously soft-deleted record

* **id:** The primary key of the entity to undelete

**Returns:** This method has no return value


[WSDL file for Services85/Person](../Services85-Person.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## Undelete Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Person:ApplicationToken>1234567-1234-9876</Person:ApplicationToken>
  <Person:Credentials>
    <Person:Ticket>7T:1234abcxyzExample==</Person:Ticket>
  </Person:Credentials>
 <SOAP-ENV:Body>
   <Person:Undelete>
    <Person:Id xsi:type="xsd:int">0</Person:Id>
   </Person:Undelete>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## Undelete Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Person:UndeleteResponse>
  </Person:UndeleteResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

