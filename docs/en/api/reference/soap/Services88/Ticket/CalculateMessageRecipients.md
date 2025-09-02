---
title: Services88.TicketAgent.CalculateMessageRecipients SOAP
generated: true
uid: Services88-Ticket-CalculateMessageRecipients
content_type: reference
---

# Services88 Ticket CalculateMessageRecipients

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.CalculateMessageRecipients">SuperOffice.Services88.ITicketAgent.CalculateMessageRecipients</see> method.

## CalculateMessageRecipients





[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CalculateMessageRecipients Request

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
   <Ticket:CalculateMessageRecipients>
    <Ticket:TicketId xsi:type="xsd:int">0</Ticket:TicketId>
    <Ticket:ActionType xsi:type="Ticket:MessageActionType">None</Ticket:ActionType>
    <Ticket:MessageId xsi:type="xsd:int">0</Ticket:MessageId>
   </Ticket:CalculateMessageRecipients>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CalculateMessageRecipients Response

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
  <Ticket:CalculateMessageRecipientsResponse>
   <Ticket:Response xsi:type="Ticket:ArrayOfRecipient">
    <Ticket:Recipient xsi:type="Ticket:Recipient">
     <Ticket:Type xsi:type="Ticket:RecipientType">To</Ticket:Type>
     <Ticket:Value xsi:type="xsd:string"></Ticket:Value>
     <Ticket:DisplayValue xsi:type="xsd:string"></Ticket:DisplayValue>
    </Ticket:Recipient>
   </Ticket:Response>
  </Ticket:CalculateMessageRecipientsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

