---
uid: services88-person-isnumbervalid
title: Services88.PersonAgent.IsNumberValid SOAP
Generated: true
---

# Services88 Person IsNumberValid SOAP

SOAP request and response examples **Remote/Services88/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPersonAgent.IsNumberValid">SuperOffice.Services88.IPersonAgent.IsNumberValid</see> method.

## IsNumberValid

Checks if the number is unique or required.  The setting is configured from admin under system options.

* **contactId:** 
* **number:** Number to check.

**Returns:** True if number is ok (passes uniqueness/required checks)


[WSDL file for Services88/Person](../Services88-Person.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## IsNumberValid Request

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
   <Person:IsNumberValid>
    <Person:ContactId xsi:type="xsd:int">0</Person:ContactId>
    <Person:Number xsi:type="xsd:string"></Person:Number>
   </Person:IsNumberValid>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## IsNumberValid Response

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
  <Person:IsNumberValidResponse>
   <Person:Response xsi:type="xsd:boolean">false</Person:Response>
  </Person:IsNumberValidResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

