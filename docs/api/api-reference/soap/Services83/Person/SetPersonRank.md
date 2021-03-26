---
uid: services83-person-setpersonrank
title: Services83.PersonAgent.SetPersonRank SOAP
Generated: true
---

# Services83 Person SetPersonRank SOAP

SOAP request and response examples **Remote/Services83/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IPersonAgent.SetPersonRank">SuperOffice.Services83.IPersonAgent.SetPersonRank</see> method.

## SetPersonRank

Directly set the rank field of a person record, adjusting all other person records under the same contact as needed.&lt;para/&gt;This call may affect multiple records, potentially all person records belonging to one contact.&lt;para/&gt;You must have write access for to affected records for this method to succeed.

* **personId:** Id of person to change
* **desiredRank:** Desired rank to set, legal values are from 1 to the number of person records on this contact. Out of range values will be moved to the closest valid value and processed.

**Returns:** If movement occurred, or the person already had exactly the desired rank value, then the return value will be true. If movement did not occur, for any other reason, the return value is false.


[WSDL file for Services83/Person](../Services83-Person.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetPersonRank Request

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
   <Person:SetPersonRank>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:DesiredRank xsi:type="xsd:short">0</Person:DesiredRank>
   </Person:SetPersonRank>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetPersonRank Response

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
  <Person:SetPersonRankResponse>
   <Person:Response xsi:type="xsd:boolean">false</Person:Response>
  </Person:SetPersonRankResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

