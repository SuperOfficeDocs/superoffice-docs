---
title: Services88.PersonAgent.Move SOAP
generated: 1
uid: Services88-Person-Move
---

# Services88 Person Move

SOAP request and response examples **Remote/Services88/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPersonAgent.Move">SuperOffice.Services88.IPersonAgent.Move</see> method.

## Move

Move a person to a specified contact. You must specify the date after which activities will be moved along with the person.

* **personId:** The identifier for the person
* **destinationContactId:** The identifier for the contact which the person will be moved to
* **moveAfterDate:** Move activites after this date. Activities before this date are left alone.

[WSDL file for Services88/Person](../Services88-Person.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## Move Request

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
   <Person:Move>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:DestinationContactId xsi:type="xsd:int">0</Person:DestinationContactId>
    <Person:MoveAfterDate xsi:type="xsd:dateTime">2021-11-30T13:23:46Z</Person:MoveAfterDate>
   </Person:Move>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## Move Response

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
  <Person:MoveResponse>
  </Person:MoveResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
