---
title: Services88.PersonAgent.GetConsentInfos SOAP
generated: true
uid: Services88-Person-GetConsentInfos
---

# Services88 Person GetConsentInfos

SOAP request and response examples **Remote/Services88/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPersonAgent.GetConsentInfos">SuperOffice.Services88.IPersonAgent.GetConsentInfos</see> method.

## GetConsentInfos





[WSDL file for Services88/Person](../Services88-Person.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetConsentInfos Request

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
   <Person:GetConsentInfos>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
   </Person:GetConsentInfos>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetConsentInfos Response

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
  <Person:GetConsentInfosResponse>
   <Person:Response xsi:type="Person:ArrayOfConsentInfo">
    <Person:ConsentInfo xsi:type="Person:ConsentInfo">
     <Person:ConsentPersonId xsi:type="xsd:int">0</Person:ConsentPersonId>
     <Person:Comment xsi:type="xsd:string"></Person:Comment>
     <Person:Registered xsi:type="xsd:dateTime">2025-06-26T01:44:25Z</Person:Registered>
     <Person:RegisteredAssociateId xsi:type="xsd:int">0</Person:RegisteredAssociateId>
     <Person:Updated xsi:type="xsd:dateTime">2025-06-26T01:44:25Z</Person:Updated>
     <Person:UpdatedAssociateId xsi:type="xsd:int">0</Person:UpdatedAssociateId>
     <Person:LegalBaseId xsi:type="xsd:int">0</Person:LegalBaseId>
     <Person:LegalBaseKey xsi:type="xsd:string"></Person:LegalBaseKey>
     <Person:LegalBaseName xsi:type="xsd:string"></Person:LegalBaseName>
     <Person:ConsentPurposeId xsi:type="xsd:int">0</Person:ConsentPurposeId>
     <Person:ConsentPurposeKey xsi:type="xsd:string"></Person:ConsentPurposeKey>
     <Person:ConsentPurposeName xsi:type="xsd:string"></Person:ConsentPurposeName>
     <Person:ConsentSourceId xsi:type="xsd:int">0</Person:ConsentSourceId>
     <Person:ConsentSourceKey xsi:type="xsd:string"></Person:ConsentSourceKey>
     <Person:ConsentSourceName xsi:type="xsd:string"></Person:ConsentSourceName>
    </Person:ConsentInfo>
   </Person:Response>
  </Person:GetConsentInfosResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

