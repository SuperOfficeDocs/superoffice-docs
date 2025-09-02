---
title: Services88.PersonAgent.GetUserCandidateByPerson SOAP
generated: true
uid: Services88-Person-GetUserCandidateByPerson
content_type: reference
---

# Services88 Person GetUserCandidateByPerson

SOAP request and response examples **Remote/Services88/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPersonAgent.GetUserCandidateByPerson">SuperOffice.Services88.IPersonAgent.GetUserCandidateByPerson</see> method.

## GetUserCandidateByPerson





[WSDL file for Services88/Person](../Services88-Person.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUserCandidateByPerson Request

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
   <Person:GetUserCandidateByPerson>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
   </Person:GetUserCandidateByPerson>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetUserCandidateByPerson Response

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
  <Person:GetUserCandidateByPersonResponse>
   <Person:Response xsi:type="Person:UserCandidate">
    <Person:UserCandidateId xsi:type="xsd:int">0</Person:UserCandidateId>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:SecretKey xsi:type="xsd:string"></Person:SecretKey>
    <Person:SecretValue xsi:type="xsd:string"></Person:SecretValue>
   </Person:Response>
  </Person:GetUserCandidateByPersonResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

