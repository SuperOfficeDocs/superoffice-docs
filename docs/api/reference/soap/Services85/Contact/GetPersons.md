---
title: Services85.ContactAgent.GetPersons SOAP
generated: 1
uid: Services85-Contact-GetPersons
---

# Services85 Contact GetPersons

SOAP request and response examples **Remote/Services85/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IContactAgent.GetPersons">SuperOffice.Services85.IContactAgent.GetPersons</see> method.

## GetPersons

Returns an array of all the contact persons for the company card.

* **contactId:** 

**Returns:** Array of Persons


[WSDL file for Services85/Contact](../Services85-Contact.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPersons Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:GetPersons>
    <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
   </Contact:GetPersons>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPersons Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Contact:GetPersonsResponse>
   <Contact:Response xsi:type="Contact:ArrayOfPerson">
    <Contact:Person xsi:type="Contact:Person">
     <Contact:Position xsi:type="xsd:string"></Contact:Position>
     <Contact:PersonId xsi:type="xsd:int">0</Contact:PersonId>
     <Contact:Mrmrs xsi:type="xsd:string"></Contact:Mrmrs>
     <Contact:Firstname xsi:type="xsd:string"></Contact:Firstname>
     <Contact:Lastname xsi:type="xsd:string"></Contact:Lastname>
     <Contact:MiddleName xsi:type="xsd:string"></Contact:MiddleName>
     <Contact:Title xsi:type="xsd:string"></Contact:Title>
     <Contact:Description xsi:type="xsd:string"></Contact:Description>
     <Contact:Email xsi:type="xsd:string"></Contact:Email>
     <Contact:FullName xsi:type="xsd:string"></Contact:FullName>
     <Contact:DirectPhone xsi:type="xsd:string"></Contact:DirectPhone>
     <Contact:FormalName xsi:type="xsd:string"></Contact:FormalName>
     <Contact:CountryId xsi:type="xsd:int">0</Contact:CountryId>
     <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
     <Contact:ContactName xsi:type="xsd:string"></Contact:ContactName>
     <Contact:Retired xsi:type="xsd:short">0</Contact:Retired>
     <Contact:Rank xsi:type="xsd:short">0</Contact:Rank>
     <Contact:ActiveInterests xsi:type="xsd:short">0</Contact:ActiveInterests>
     <Contact:ContactDepartment xsi:type="xsd:string"></Contact:ContactDepartment>
     <Contact:ContactCountryId xsi:type="xsd:int">0</Contact:ContactCountryId>
     <Contact:ContactOrgNr xsi:type="xsd:string"></Contact:ContactOrgNr>
     <Contact:FaxPhone xsi:type="xsd:string"></Contact:FaxPhone>
     <Contact:MobilePhone xsi:type="xsd:string"></Contact:MobilePhone>
     <Contact:ContactPhone xsi:type="xsd:string"></Contact:ContactPhone>
     <Contact:AssociateName xsi:type="xsd:string"></Contact:AssociateName>
     <Contact:AssociateId xsi:type="xsd:int">0</Contact:AssociateId>
     <Contact:UsePersonAddress xsi:type="xsd:boolean">false</Contact:UsePersonAddress>
     <Contact:ContactFax xsi:type="xsd:string"></Contact:ContactFax>
     <Contact:Kanafname xsi:type="xsd:string"></Contact:Kanafname>
     <Contact:Kanalname xsi:type="xsd:string"></Contact:Kanalname>
     <Contact:Post1 xsi:type="xsd:string"></Contact:Post1>
     <Contact:Post2 xsi:type="xsd:string"></Contact:Post2>
     <Contact:Post3 xsi:type="xsd:string"></Contact:Post3>
     <Contact:EmailName xsi:type="xsd:string"></Contact:EmailName>
     <Contact:ContactFullName xsi:type="xsd:string"></Contact:ContactFullName>
     <Contact:ActiveErpLinks xsi:type="xsd:int">0</Contact:ActiveErpLinks>
     <Contact:TicketPriorityId xsi:type="xsd:int">0</Contact:TicketPriorityId>
     <Contact:SupportLanguageId xsi:type="xsd:int">0</Contact:SupportLanguageId>
     <Contact:SupportAssociateId xsi:type="xsd:int">0</Contact:SupportAssociateId>
    </Contact:Person>
   </Contact:Response>
  </Contact:GetPersonsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

