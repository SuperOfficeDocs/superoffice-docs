---
uid: services88-person-getpersonsummary
title: Services88.PersonAgent.GetPersonSummary SOAP
Generated: true
---

# Services88 Person GetPersonSummary SOAP

SOAP request and response examples **Remote/Services88/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPersonAgent.GetPersonSummary">SuperOffice.Services88.IPersonAgent.GetPersonSummary</see> method.

## GetPersonSummary

Get summary of person and recent activity.

* **personId:** The person id to summarize.
* **limit:** Max number of items to include in summary lists.

**Returns:** Summary of person, with recent requests, sales, follow-ups, chats.


[WSDL file for Services88/Person](../Services88-Person.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPersonSummary Request

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
   <Person:GetPersonSummary>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:Limit xsi:type="xsd:int">0</Person:Limit>
   </Person:GetPersonSummary>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPersonSummary Response

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
  <Person:GetPersonSummaryResponse>
   <Person:Response xsi:type="Person:PersonSummary">
    <Person:Person xsi:type="Person:Person">
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
    </Person:Person>
    <Person:Tickets xsi:type="Person:ArrayOfTicketSummaryItem">
     <Person:TicketSummaryItem xsi:type="Person:TicketSummaryItem">
      <Person:TicketId xsi:type="xsd:int">0</Person:TicketId>
      <Person:TicketStatus xsi:type="xsd:int">0</Person:TicketStatus>
      <Person:Title xsi:type="xsd:string"></Person:Title>
      <Person:Registered xsi:type="xsd:dateTime">2021-03-25T21:37:05Z</Person:Registered>
     </Person:TicketSummaryItem>
    </Person:Tickets>
    <Person:Followups xsi:type="Person:ArrayOfActivitySummaryItem">
     <Person:ActivitySummaryItem xsi:type="Person:ActivitySummaryItem">
      <Person:AppointmentId xsi:type="xsd:int">0</Person:AppointmentId>
      <Person:DocumentId xsi:type="xsd:int">0</Person:DocumentId>
      <Person:Date xsi:type="xsd:dateTime">2021-03-25T21:37:05Z</Person:Date>
      <Person:Description xsi:type="xsd:string"></Person:Description>
      <Person:Completed xsi:type="Person:ActivityStatus">Unknown</Person:Completed>
      <Person:Registered xsi:type="xsd:dateTime">2021-03-25T21:37:05Z</Person:Registered>
     </Person:ActivitySummaryItem>
    </Person:Followups>
    <Person:Documents xsi:type="Person:ArrayOfActivitySummaryItem">
     <Person:ActivitySummaryItem xsi:type="Person:ActivitySummaryItem">
      <Person:AppointmentId xsi:type="xsd:int">0</Person:AppointmentId>
      <Person:DocumentId xsi:type="xsd:int">0</Person:DocumentId>
      <Person:Date xsi:type="xsd:dateTime">2021-03-25T21:37:05Z</Person:Date>
      <Person:Description xsi:type="xsd:string"></Person:Description>
      <Person:Completed xsi:type="Person:ActivityStatus">Unknown</Person:Completed>
      <Person:Registered xsi:type="xsd:dateTime">2021-03-25T21:37:05Z</Person:Registered>
     </Person:ActivitySummaryItem>
    </Person:Documents>
    <Person:Sales xsi:type="Person:ArrayOfSaleSummaryItem">
     <Person:SaleSummaryItem xsi:type="Person:SaleSummaryItem">
      <Person:SaleId xsi:type="xsd:int">0</Person:SaleId>
      <Person:SaleDate xsi:type="xsd:dateTime">2021-03-25T21:37:05Z</Person:SaleDate>
      <Person:Probability xsi:type="xsd:short">0</Person:Probability>
      <Person:Heading xsi:type="xsd:string"></Person:Heading>
      <Person:Amount xsi:type="xsd:double">0.0</Person:Amount>
      <Person:Currency xsi:type="xsd:string"></Person:Currency>
      <Person:AmountInBaseCurrency xsi:type="xsd:double">0.0</Person:AmountInBaseCurrency>
      <Person:Status xsi:type="Person:SaleStatus">Unknown</Person:Status>
      <Person:Completed xsi:type="Person:ActivityStatus">Unknown</Person:Completed>
      <Person:Registered xsi:type="xsd:dateTime">2021-03-25T21:37:05Z</Person:Registered>
     </Person:SaleSummaryItem>
    </Person:Sales>
    <Person:Chats xsi:type="Person:ArrayOfChatSummaryItem">
     <Person:ChatSummaryItem xsi:type="Person:ChatSummaryItem">
      <Person:ChatSessionId xsi:type="xsd:int">0</Person:ChatSessionId>
      <Person:Name xsi:type="xsd:string"></Person:Name>
      <Person:CompanyName xsi:type="xsd:string"></Person:CompanyName>
      <Person:FirstMessage xsi:type="xsd:string"></Person:FirstMessage>
      <Person:LastMessage xsi:type="xsd:string"></Person:LastMessage>
      <Person:WhenRequested xsi:type="xsd:dateTime">2021-03-25T21:37:05Z</Person:WhenRequested>
      <Person:WhenEnded xsi:type="xsd:dateTime">2021-03-25T21:37:05Z</Person:WhenEnded>
     </Person:ChatSummaryItem>
    </Person:Chats>
   </Person:Response>
  </Person:GetPersonSummaryResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

