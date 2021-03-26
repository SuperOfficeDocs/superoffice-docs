---
uid: services88-person-getperson
title: Services88.PersonAgent.GetPerson SOAP
Generated: true
---

# Services88 Person GetPerson SOAP

SOAP request and response examples **Remote/Services88/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPersonAgent.GetPerson">SuperOffice.Services88.IPersonAgent.GetPerson</see> method.

## GetPerson

Gets a Person object.

* **personId:** The identifier of the Person object

**Returns:** Person


[WSDL file for Services88/Person](../Services88-Person.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPerson Request

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
   <Person:GetPerson>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
   </Person:GetPerson>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPerson Response

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
  <Person:GetPersonResponse>
   <Person:Response xsi:type="Person:Person">
    <Person:Position xsi:type="xsd:string"></Person:Position>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:Mrmrs xsi:type="xsd:string"></Person:Mrmrs>
    <Person:Firstname xsi:type="xsd:string"></Person:Firstname>
    <Person:Lastname xsi:type="xsd:string"></Person:Lastname>
    <Person:MiddleName xsi:type="xsd:string"></Person:MiddleName>
    <Person:Title xsi:type="xsd:string"></Person:Title>
    <Person:Description xsi:type="xsd:string"></Person:Description>
    <Person:Email xsi:type="xsd:string"></Person:Email>
    <Person:FullName xsi:type="xsd:string"></Person:FullName>
    <Person:DirectPhone xsi:type="xsd:string"></Person:DirectPhone>
    <Person:FormalName xsi:type="xsd:string"></Person:FormalName>
    <Person:CountryId xsi:type="xsd:int">0</Person:CountryId>
    <Person:ContactId xsi:type="xsd:int">0</Person:ContactId>
    <Person:ContactName xsi:type="xsd:string"></Person:ContactName>
    <Person:Retired xsi:type="xsd:short">0</Person:Retired>
    <Person:Rank xsi:type="xsd:short">0</Person:Rank>
    <Person:ActiveInterests xsi:type="xsd:short">0</Person:ActiveInterests>
    <Person:ContactDepartment xsi:type="xsd:string"></Person:ContactDepartment>
    <Person:ContactCountryId xsi:type="xsd:int">0</Person:ContactCountryId>
    <Person:ContactOrgNr xsi:type="xsd:string"></Person:ContactOrgNr>
    <Person:FaxPhone xsi:type="xsd:string"></Person:FaxPhone>
    <Person:MobilePhone xsi:type="xsd:string"></Person:MobilePhone>
    <Person:ContactPhone xsi:type="xsd:string"></Person:ContactPhone>
    <Person:AssociateName xsi:type="xsd:string"></Person:AssociateName>
    <Person:AssociateId xsi:type="xsd:int">0</Person:AssociateId>
    <Person:UsePersonAddress xsi:type="xsd:boolean">false</Person:UsePersonAddress>
    <Person:ContactFax xsi:type="xsd:string"></Person:ContactFax>
    <Person:Kanafname xsi:type="xsd:string"></Person:Kanafname>
    <Person:Kanalname xsi:type="xsd:string"></Person:Kanalname>
    <Person:Post1 xsi:type="xsd:string"></Person:Post1>
    <Person:Post2 xsi:type="xsd:string"></Person:Post2>
    <Person:Post3 xsi:type="xsd:string"></Person:Post3>
    <Person:EmailName xsi:type="xsd:string"></Person:EmailName>
    <Person:ContactFullName xsi:type="xsd:string"></Person:ContactFullName>
    <Person:ActiveErpLinks xsi:type="xsd:int">0</Person:ActiveErpLinks>
    <Person:TicketPriorityId xsi:type="xsd:int">0</Person:TicketPriorityId>
    <Person:SupportLanguageId xsi:type="xsd:int">0</Person:SupportLanguageId>
    <Person:SupportAssociateId xsi:type="xsd:int">0</Person:SupportAssociateId>
    <Person:CategoryName xsi:type="xsd:string"></Person:CategoryName>
   </Person:Response>
  </Person:GetPersonResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

