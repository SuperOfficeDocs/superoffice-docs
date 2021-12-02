---
title: Services86.TicketAgent.GetTicketMessage SOAP
generated: 1
uid: Services86-Ticket-GetTicketMessage
---

# Services86 Ticket GetTicketMessage

SOAP request and response examples **Remote/Services86/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ITicketAgent.GetTicketMessage">SuperOffice.Services86.ITicketAgent.GetTicketMessage</see> method.

## GetTicketMessage

Gets a TicketMessage object.

* **ticketMessageId:** The identifier of the TicketMessage object

**Returns:** TicketMessage


[WSDL file for Services86/Ticket](../Services86-Ticket.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTicketMessage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Ticket="http://www.superoffice.net/ws/crm/NetServer/Services86">
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
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Ticket="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Ticket:GetTicketMessageResponse>
   <Ticket:Response xsi:type="Ticket:TicketMessage">
    <Ticket:TicketMessageId xsi:type="xsd:int">0</Ticket:TicketMessageId>
    <Ticket:CreatedAt xsi:type="xsd:dateTime">2021-11-30T13:23:05Z</Ticket:CreatedAt>
    <Ticket:Slevel xsi:type="Ticket:TicketSecurityLevel">Unknown</Ticket:Slevel>
    <Ticket:Important xsi:type="xsd:boolean">false</Ticket:Important>
   </Ticket:Response>
  </Ticket:GetTicketMessageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

