---
uid: services88-person-addbouncewithcount
title: Services88.PersonAgent.AddBounceWithCount SOAP
Generated: true
---

# Services88 Person AddBounceWithCount SOAP

SOAP request and response examples **Remote/Services88/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPersonAgent.AddBounceWithCount">SuperOffice.Services88.IPersonAgent.AddBounceWithCount</see> method.

## AddBounceWithCount

Add a number of bounce counts on the email address if it exists

* **emailAddress:** The email address which we want to add bounce counts to
* **counts:** The number of bounce counts to add



[WSDL file for Services88/Person](../Services88-Person.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AddBounceWithCount Request

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
   <Person:AddBounceWithCount>
    <Person:EmailAddress xsi:type="xsd:string"></Person:EmailAddress>
    <Person:Counts xsi:type="xsd:int">0</Person:Counts>
   </Person:AddBounceWithCount>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AddBounceWithCount Response

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
  <Person:AddBounceWithCountResponse>
  </Person:AddBounceWithCountResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

