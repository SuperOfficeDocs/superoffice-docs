---
title: Services88.TicketAgent.GetTicketMessage SOAP
generated: 1
uid: Services88-Ticket-GetTicketMessage
---

# Services88 Ticket GetTicketMessage

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.GetTicketMessage">SuperOffice.Services88.ITicketAgent.GetTicketMessage</see> method.

## GetTicketMessage

Gets a TicketMessage object.

* **ticketMessageId:** The identifier of the TicketMessage object

**Returns:** TicketMessage


[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTicketMessage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Ticket="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Ticket:ApplicationToken>1234567-1234-9876</Ticket:ApplicationToken>
  <Ticket:Credentials>
    <Ticket:Ticket>7T:1234abcxyzExample==</Ticket:Ticket>
  </Ticket:Credentials>
 <SOAP-ENV:Body>
   <Ticket:GetTicketMessage>
    <Ticket:TicketMessageId xsi:type="xsd:int">0</Ticket:TicketMessageId>
   </Ticket:GetTicketMessage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTicketMessage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Ticket="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Ticket:GetTicketMessageResponse>
   <Ticket:Response xsi:type="Ticket:TicketMessage">
    <Ticket:TicketMessageId xsi:type="xsd:int">0</Ticket:TicketMessageId>
    <Ticket:CreatedAt xsi:type="xsd:dateTime">2022-08-26T09:00:43Z</Ticket:CreatedAt>
    <Ticket:Slevel xsi:type="Ticket:TicketSecurityLevel">Unknown</Ticket:Slevel>
    <Ticket:Important xsi:type="xsd:boolean">false</Ticket:Important>
    <Ticket:Author xsi:type="xsd:string"></Ticket:Author>
    <Ticket:PersonId xsi:type="xsd:int">0</Ticket:PersonId>
    <Ticket:PersonFullName xsi:type="xsd:string"></Ticket:PersonFullName>
    <Ticket:ContactId xsi:type="xsd:int">0</Ticket:ContactId>
    <Ticket:ContactName xsi:type="xsd:string"></Ticket:ContactName>
    <Ticket:ContactDepartment xsi:type="xsd:string"></Ticket:ContactDepartment>
    <Ticket:NumAttachments xsi:type="xsd:int">0</Ticket:NumAttachments>
    <Ticket:EmailHeader xsi:type="xsd:string"></Ticket:EmailHeader>
    <Ticket:MessageHeaders xsi:type="Ticket:ArrayOfTicketMessageHeader">
     <Ticket:TicketMessageHeader xsi:type="Ticket:TicketMessageHeader">
      <Ticket:Name xsi:type="xsd:string"></Ticket:Name>
      <Ticket:Value xsi:type="xsd:string"></Ticket:Value>
      <Ticket:StdItem xsi:type="Ticket:MessageHeaderStdItem">None</Ticket:StdItem>
      <Ticket:StdItemCol xsi:type="Ticket:MessageHeaderStdItemCol">None</Ticket:StdItemCol>
     </Ticket:TicketMessageHeader>
    </Ticket:MessageHeaders>
    <Ticket:Language xsi:type="xsd:string"></Ticket:Language>
    <Ticket:Sentiment xsi:type="xsd:int">0</Ticket:Sentiment>
    <Ticket:SentimentConfidence xsi:type="xsd:int">0</Ticket:SentimentConfidence>
    <Ticket:CreatedBy xsi:type="xsd:int">0</Ticket:CreatedBy>
   </Ticket:Response>
  </Ticket:GetTicketMessageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

