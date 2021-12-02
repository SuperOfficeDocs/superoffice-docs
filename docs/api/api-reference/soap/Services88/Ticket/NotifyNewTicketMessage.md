---
title: Services88.TicketAgent.NotifyNewTicketMessage SOAP
generated: 1
uid: Services88-Ticket-NotifyNewTicketMessage
---

# Services88 Ticket NotifyNewTicketMessage

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.NotifyNewTicketMessage">SuperOffice.Services88.ITicketAgent.NotifyNewTicketMessage</see> method.

## NotifyNewTicketMessage

Notify user agents about the creation of a new message on a ticket

* **ticketEntityId:** The id of the ticket to notify about

**Returns:** This method has no return value


[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## NotifyNewTicketMessage Request

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
   <Ticket:NotifyNewTicketMessage>
    <Ticket:TicketEntityId xsi:type="xsd:int">0</Ticket:TicketEntityId>
   </Ticket:NotifyNewTicketMessage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## NotifyNewTicketMessage Response

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
  <Ticket:NotifyNewTicketMessageResponse>
  </Ticket:NotifyNewTicketMessageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

