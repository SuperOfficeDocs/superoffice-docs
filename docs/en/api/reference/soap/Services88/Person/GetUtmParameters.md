---
title: Services88.PersonAgent.GetUtmParameters SOAP
generated: true
uid: Services88-Person-GetUtmParameters
content_type: reference
---

# Services88 Person GetUtmParameters

SOAP request and response examples **Remote/Services88/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPersonAgent.GetUtmParameters">SuperOffice.Services88.IPersonAgent.GetUtmParameters</see> method.

## GetUtmParameters





[WSDL file for Services88/Person](../Services88-Person.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUtmParameters Request

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
   <Person:GetUtmParameters>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
   </Person:GetUtmParameters>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetUtmParameters Response

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
  <Person:GetUtmParametersResponse>
   <Person:Response xsi:type="Person:UtmParameters">
    <Person:UtmParametersId xsi:type="xsd:int">0</Person:UtmParametersId>
    <Person:CreatedContactId xsi:type="xsd:int">0</Person:CreatedContactId>
    <Person:CreatedPersonId xsi:type="xsd:int">0</Person:CreatedPersonId>
    <Person:FormSubmissionId xsi:type="xsd:int">0</Person:FormSubmissionId>
    <Person:FirstTouchSource xsi:type="xsd:string"></Person:FirstTouchSource>
    <Person:FirstTouchMedium xsi:type="xsd:string"></Person:FirstTouchMedium>
    <Person:FirstTouchCampaign xsi:type="xsd:string"></Person:FirstTouchCampaign>
    <Person:FirstTouchTerm xsi:type="xsd:string"></Person:FirstTouchTerm>
    <Person:FirstTouchContent xsi:type="xsd:string"></Person:FirstTouchContent>
    <Person:FirstTouchReferrerDomain xsi:type="xsd:string"></Person:FirstTouchReferrerDomain>
    <Person:FirstTouchWhen xsi:type="xsd:dateTime">2025-11-05T01:29:48Z</Person:FirstTouchWhen>
    <Person:Source xsi:type="xsd:string"></Person:Source>
    <Person:Medium xsi:type="xsd:string"></Person:Medium>
    <Person:Campaign xsi:type="xsd:string"></Person:Campaign>
    <Person:Term xsi:type="xsd:string"></Person:Term>
    <Person:Content xsi:type="xsd:string"></Person:Content>
    <Person:ReferrerDomain xsi:type="xsd:string"></Person:ReferrerDomain>
    <Person:When xsi:type="xsd:dateTime">2025-11-05T01:29:48Z</Person:When>
    <Person:Registered xsi:type="xsd:dateTime">2025-11-05T01:29:48Z</Person:Registered>
    <Person:RegisteredAssociateId xsi:type="xsd:int">0</Person:RegisteredAssociateId>
    <Person:Updated xsi:type="xsd:dateTime">2025-11-05T01:29:48Z</Person:Updated>
    <Person:UpdatedAssociateId xsi:type="xsd:int">0</Person:UpdatedAssociateId>
    <Person:UpdatedCount xsi:type="xsd:short">0</Person:UpdatedCount>
   </Person:Response>
  </Person:GetUtmParametersResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

