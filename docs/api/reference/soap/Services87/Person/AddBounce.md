---
title: Services87.PersonAgent.AddBounce SOAP
generated: 1
uid: Services87-Person-AddBounce
---

# Services87 Person AddBounce

SOAP request and response examples **Remote/Services87/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IPersonAgent.AddBounce">SuperOffice.Services87.IPersonAgent.AddBounce</see> method.

## AddBounce

Add a bounce count on the email address if it exists

* **emailAddress:** The email address which we want to add a bounce count to



[WSDL file for Services87/Person](../Services87-Person.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AddBounce Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Person:ApplicationToken>1234567-1234-9876</Person:ApplicationToken>
  <Person:Credentials>
    <Person:Ticket>7T:1234abcxyzExample==</Person:Ticket>
  </Person:Credentials>
 <SOAP-ENV:Body>
   <Person:AddBounce>
    <Person:EmailAddress xsi:type="xsd:string"></Person:EmailAddress>
   </Person:AddBounce>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AddBounce Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Person:AddBounceResponse>
  </Person:AddBounceResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

