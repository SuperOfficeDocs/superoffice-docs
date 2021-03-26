---
uid: services80-person-normalizeranks
title: Services80.PersonAgent.NormalizeRanks SOAP
Generated: true
---

# Services80 Person NormalizeRanks SOAP

SOAP request and response examples **Remote/Services80/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IPersonAgent.NormalizeRanks">SuperOffice.Services80.IPersonAgent.NormalizeRanks</see> method.

## NormalizeRanks

Nomralize the ranks for all persons that belong to a contact. This means that the persons will be sorted according to their current rank values, and the ranks will be made monotonically increasing from 1.

* **contactId:** Id of contact whose persons are to be rank normalized

**Returns:** The reutrn value is true if the operation suceeded, either because all persons were already normalized, or because normalization was done. It is false if Sentry blocks any required changes.


[WSDL file for Services80/Person](../Services80-Person.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## NormalizeRanks Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Person:ApplicationToken>1234567-1234-9876</Person:ApplicationToken>
  <Person:Credentials>
    <Person:Ticket>7T:1234abcxyzExample==</Person:Ticket>
  </Person:Credentials>
 <SOAP-ENV:Body>
   <Person:NormalizeRanks>
    <Person:ContactId xsi:type="xsd:int">0</Person:ContactId>
   </Person:NormalizeRanks>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## NormalizeRanks Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Person:NormalizeRanksResponse>
   <Person:Response xsi:type="xsd:boolean">false</Person:Response>
  </Person:NormalizeRanksResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

