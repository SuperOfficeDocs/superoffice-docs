---
uid: services81-person-changepersonrank
title: Services81.PersonAgent.ChangePersonRank SOAP
Generated: true
---

# Services81 Person ChangePersonRank SOAP

SOAP request and response examples **Remote/Services81/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IPersonAgent.ChangePersonRank">SuperOffice.Services81.IPersonAgent.ChangePersonRank</see> method.

## ChangePersonRank

Move one person up or down in the ranking in the Person Archive, if possible.&lt;para/&gt;The person record that has rank = 1 is the primary contact for a company, and is the one used in situations where no person has been explicitly chosen (such as in selections).&lt;para/&gt;This method corresponds to the move up/move down functions in the person archive in the contact panel.&lt;para/&gt;This method always affects two records.

* **personId:** Primary key of person record to move up or down. You must have write access both to this record AND to whatever record is adjacent in the direction you want to move.
* **moveUp:** If true, the given person is moved to an earlier rank (lower numeric rank value, down to a limit of 1; up in the GUI if sorted by ascending rank). If false, movement is to later priority (higher numeric rank value).

**Returns:** If movement occurred, the return value will be the ID of the OTHER person that got moved. A GUI should switch the positions of the original person ID and this return value.<para />If no movement occurred, for any reason,  0 is returned.


[WSDL file for Services81/Person](../Services81-Person.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ChangePersonRank Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Person:ApplicationToken>1234567-1234-9876</Person:ApplicationToken>
  <Person:Credentials>
    <Person:Ticket>7T:1234abcxyzExample==</Person:Ticket>
  </Person:Credentials>
 <SOAP-ENV:Body>
   <Person:ChangePersonRank>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:MoveUp xsi:type="xsd:boolean">false</Person:MoveUp>
   </Person:ChangePersonRank>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ChangePersonRank Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Person:ChangePersonRankResponse>
   <Person:Response xsi:type="xsd:int">0</Person:Response>
  </Person:ChangePersonRankResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

