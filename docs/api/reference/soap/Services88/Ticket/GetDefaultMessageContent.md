---
title: Services88.TicketAgent.GetDefaultMessageContent SOAP
generated: 1
uid: Services88-Ticket-GetDefaultMessageContent
---

# Services88 Ticket GetDefaultMessageContent

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.GetDefaultMessageContent">SuperOffice.Services88.ITicketAgent.GetDefaultMessageContent</see> method.

## GetDefaultMessageContent

Generate a default message body (possibly including user signature, quoted message content) as sanitized HTML

* **ticketId:** The id of the ticket
* **messageActionType:** Message action type: None/Reply/ReplyAll/Forward
* **ticketMessageId:** The id of the message to quote in the returned content. 0 to skip/ignore

**Returns:** Sanitized HTML content including possibly user signature and quoted message


[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDefaultMessageContent Request

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
   <Ticket:GetDefaultMessageContent>
    <Ticket:TicketId xsi:type="xsd:int">0</Ticket:TicketId>
    <Ticket:MessageActionType xsi:type="Ticket:MessageActionType">None</Ticket:MessageActionType>
    <Ticket:TicketMessageId xsi:type="xsd:int">0</Ticket:TicketMessageId>
   </Ticket:GetDefaultMessageContent>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDefaultMessageContent Response

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
  <Ticket:GetDefaultMessageContentResponse>
   <Ticket:Response xsi:type="xsd:string"></Ticket:Response>
  </Ticket:GetDefaultMessageContentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

