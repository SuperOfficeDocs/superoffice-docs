---
uid: services88-ticket-deleteticketmessageentity
title: Services88.TicketAgent.DeleteTicketMessageEntity SOAP
Generated: true
---

# Services88 Ticket DeleteTicketMessageEntity SOAP

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.DeleteTicketMessageEntity">SuperOffice.Services88.ITicketAgent.DeleteTicketMessageEntity</see> method.

## DeleteTicketMessageEntity

Delete a ticket message

* **ticketMessageEntityId:** The ticket message to delete

**Returns:** returns void


[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteTicketMessageEntity Request

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
   <Ticket:DeleteTicketMessageEntity>
    <Ticket:TicketMessageEntityId xsi:type="xsd:int">0</Ticket:TicketMessageEntityId>
   </Ticket:DeleteTicketMessageEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteTicketMessageEntity Response

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
  <Ticket:DeleteTicketMessageEntityResponse>
  </Ticket:DeleteTicketMessageEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

