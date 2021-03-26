---
uid: services87-contact-getcontactsummary
title: Services87.ContactAgent.GetContactSummary SOAP
Generated: true
---

# Services87 Contact GetContactSummary SOAP

SOAP request and response examples **Remote/Services87/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IContactAgent.GetContactSummary">SuperOffice.Services87.IContactAgent.GetContactSummary</see> method.

## GetContactSummary

Get summary of contact and its recent activity.

* **contactId:** The contact id to summarize.
* **limit:** Max number of items to include in summary lists.

**Returns:** Summary of contact, with recent requests, sales, follow-ups, chats.


[WSDL file for Services87/Contact](../Services87-Contact.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetContactSummary Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:GetContactSummary>
    <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
    <Contact:Limit xsi:type="xsd:int">0</Contact:Limit>
   </Contact:GetContactSummary>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetContactSummary Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Contact:GetContactSummaryResponse>
   <Contact:Response xsi:type="Contact:ContactSummary">
    <Contact:Contact xsi:type="Contact:Contact">
     <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
     <Contact:Name xsi:type="xsd:string"></Contact:Name>
     <Contact:OrgNr xsi:type="xsd:string"></Contact:OrgNr>
     <Contact:Department xsi:type="xsd:string"></Contact:Department>
     <Contact:URL xsi:type="xsd:string"></Contact:URL>
     <Contact:City xsi:type="xsd:string"></Contact:City>
     <Contact:DirectPhone xsi:type="xsd:string"></Contact:DirectPhone>
     <Contact:AssociateId xsi:type="xsd:int">0</Contact:AssociateId>
     <Contact:CountryId xsi:type="xsd:int">0</Contact:CountryId>
     <Contact:EmailAddress xsi:type="xsd:string"></Contact:EmailAddress>
     <Contact:Kananame xsi:type="xsd:string"></Contact:Kananame>
     <Contact:EmailAddressName xsi:type="xsd:string"></Contact:EmailAddressName>
     <Contact:URLName xsi:type="xsd:string"></Contact:URLName>
     <Contact:AssociateFullName xsi:type="xsd:string"></Contact:AssociateFullName>
     <Contact:BusinessName xsi:type="xsd:string"></Contact:BusinessName>
     <Contact:CategoryName xsi:type="xsd:string"></Contact:CategoryName>
     <Contact:CountryName xsi:type="xsd:string"></Contact:CountryName>
     <Contact:Address xsi:type="Contact:Address">
      <Contact:Wgs84Latitude xsi:type="xsd:double">0.0</Contact:Wgs84Latitude>
      <Contact:Wgs84Longitude xsi:type="xsd:double">0.0</Contact:Wgs84Longitude>
      <Contact:LocalizedAddress xsi:type="Contact:ArrayOfArrayOfLocalizedField">
       <Contact:ArrayOfLocalizedField xsi:type="Contact:ArrayOfLocalizedField">
        <Contact:LocalizedField xsi:type="Contact:LocalizedField">
         <Contact:Name xsi:type="xsd:string"></Contact:Name>
         <Contact:Value xsi:type="xsd:string"></Contact:Value>
         <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
         <Contact:Label xsi:type="xsd:string"></Contact:Label>
         <Contact:ValueLength xsi:type="xsd:int">0</Contact:ValueLength>
         <Contact:AddressType xsi:type="xsd:string"></Contact:AddressType>
        </Contact:LocalizedField>
       </Contact:ArrayOfLocalizedField>
      </Contact:LocalizedAddress>
      <Contact:Street xsi:type="Contact:StructuredAddress">
       <Contact:AtypeIdx xsi:type="Contact:AddressType">Unknown</Contact:AtypeIdx>
       <Contact:Address1 xsi:type="xsd:string"></Contact:Address1>
       <Contact:Address2 xsi:type="xsd:string"></Contact:Address2>
       <Contact:Address3 xsi:type="xsd:string"></Contact:Address3>
       <Contact:City xsi:type="xsd:string"></Contact:City>
       <Contact:County xsi:type="xsd:string"></Contact:County>
       <Contact:State xsi:type="xsd:string"></Contact:State>
       <Contact:Zipcode xsi:type="xsd:string"></Contact:Zipcode>
       <Contact:Formatted xsi:type="xsd:string"></Contact:Formatted>
      </Contact:Street>
      <Contact:Postal xsi:type="Contact:StructuredAddress">
       <Contact:AtypeIdx xsi:type="Contact:AddressType">Unknown</Contact:AtypeIdx>
       <Contact:Address1 xsi:type="xsd:string"></Contact:Address1>
       <Contact:Address2 xsi:type="xsd:string"></Contact:Address2>
       <Contact:Address3 xsi:type="xsd:string"></Contact:Address3>
       <Contact:City xsi:type="xsd:string"></Contact:City>
       <Contact:County xsi:type="xsd:string"></Contact:County>
       <Contact:State xsi:type="xsd:string"></Contact:State>
       <Contact:Zipcode xsi:type="xsd:string"></Contact:Zipcode>
       <Contact:Formatted xsi:type="xsd:string"></Contact:Formatted>
      </Contact:Postal>
      <Contact:Formatted xsi:type="xsd:string"></Contact:Formatted>
     </Contact:Address>
     <Contact:FormattedAddress xsi:type="xsd:string"></Contact:FormattedAddress>
     <Contact:FullName xsi:type="xsd:string"></Contact:FullName>
     <Contact:IsOwnerContact xsi:type="xsd:boolean">false</Contact:IsOwnerContact>
     <Contact:ActiveErpLinks xsi:type="xsd:int">0</Contact:ActiveErpLinks>
    </Contact:Contact>
    <Contact:Tickets xsi:type="Contact:ArrayOfTicketSummaryItem">
     <Contact:TicketSummaryItem xsi:type="Contact:TicketSummaryItem">
      <Contact:TicketId xsi:type="xsd:int">0</Contact:TicketId>
      <Contact:TicketStatus xsi:type="xsd:int">0</Contact:TicketStatus>
      <Contact:Title xsi:type="xsd:string"></Contact:Title>
      <Contact:Registered xsi:type="xsd:dateTime">2021-03-25T21:36:29Z</Contact:Registered>
     </Contact:TicketSummaryItem>
    </Contact:Tickets>
    <Contact:Followups xsi:type="Contact:ArrayOfActivitySummaryItem">
     <Contact:ActivitySummaryItem xsi:type="Contact:ActivitySummaryItem">
      <Contact:AppointmentId xsi:type="xsd:int">0</Contact:AppointmentId>
      <Contact:DocumentId xsi:type="xsd:int">0</Contact:DocumentId>
      <Contact:Date xsi:type="xsd:dateTime">2021-03-25T21:36:29Z</Contact:Date>
      <Contact:Description xsi:type="xsd:string"></Contact:Description>
      <Contact:Completed xsi:type="Contact:ActivityStatus">Unknown</Contact:Completed>
      <Contact:Registered xsi:type="xsd:dateTime">2021-03-25T21:36:29Z</Contact:Registered>
     </Contact:ActivitySummaryItem>
    </Contact:Followups>
    <Contact:Documents xsi:type="Contact:ArrayOfActivitySummaryItem">
     <Contact:ActivitySummaryItem xsi:type="Contact:ActivitySummaryItem">
      <Contact:AppointmentId xsi:type="xsd:int">0</Contact:AppointmentId>
      <Contact:DocumentId xsi:type="xsd:int">0</Contact:DocumentId>
      <Contact:Date xsi:type="xsd:dateTime">2021-03-25T21:36:29Z</Contact:Date>
      <Contact:Description xsi:type="xsd:string"></Contact:Description>
      <Contact:Completed xsi:type="Contact:ActivityStatus">Unknown</Contact:Completed>
      <Contact:Registered xsi:type="xsd:dateTime">2021-03-25T21:36:29Z</Contact:Registered>
     </Contact:ActivitySummaryItem>
    </Contact:Documents>
    <Contact:Sales xsi:type="Contact:ArrayOfSaleSummaryItem">
     <Contact:SaleSummaryItem xsi:type="Contact:SaleSummaryItem">
      <Contact:SaleId xsi:type="xsd:int">0</Contact:SaleId>
      <Contact:SaleDate xsi:type="xsd:dateTime">2021-03-25T21:36:29Z</Contact:SaleDate>
      <Contact:Probability xsi:type="xsd:short">0</Contact:Probability>
      <Contact:Heading xsi:type="xsd:string"></Contact:Heading>
      <Contact:Amount xsi:type="xsd:double">0.0</Contact:Amount>
      <Contact:Currency xsi:type="xsd:string"></Contact:Currency>
      <Contact:AmountInBaseCurrency xsi:type="xsd:double">0.0</Contact:AmountInBaseCurrency>
      <Contact:Status xsi:type="Contact:SaleStatus">Unknown</Contact:Status>
      <Contact:Completed xsi:type="Contact:ActivityStatus">Unknown</Contact:Completed>
      <Contact:Registered xsi:type="xsd:dateTime">2021-03-25T21:36:29Z</Contact:Registered>
     </Contact:SaleSummaryItem>
    </Contact:Sales>
    <Contact:Chats xsi:type="Contact:ArrayOfChatSummaryItem">
     <Contact:ChatSummaryItem xsi:type="Contact:ChatSummaryItem">
      <Contact:ChatSessionId xsi:type="xsd:int">0</Contact:ChatSessionId>
      <Contact:Name xsi:type="xsd:string"></Contact:Name>
      <Contact:CompanyName xsi:type="xsd:string"></Contact:CompanyName>
      <Contact:FirstMessage xsi:type="xsd:string"></Contact:FirstMessage>
      <Contact:LastMessage xsi:type="xsd:string"></Contact:LastMessage>
      <Contact:WhenRequested xsi:type="xsd:dateTime">2021-03-25T21:36:29Z</Contact:WhenRequested>
      <Contact:WhenEnded xsi:type="xsd:dateTime">2021-03-25T21:36:29Z</Contact:WhenEnded>
     </Contact:ChatSummaryItem>
    </Contact:Chats>
   </Contact:Response>
  </Contact:GetContactSummaryResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

