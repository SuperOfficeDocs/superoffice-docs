---
title: Services88.TicketAgent.SendTicketMessage SOAP
generated: 1
uid: Services88-Ticket-SendTicketMessage
---

# Services88 Ticket SendTicketMessage

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.SendTicketMessage">SuperOffice.Services88.ITicketAgent.SendTicketMessage</see> method.

## SendTicketMessage

Send a message to recipients, e.g. by email or sms

* **ticketMessageEntityId:** The id of the ticket message to send
* **to:** The To-recipients. Each recipient must be in correct format: e-mail address or phone number
* **cc:** The Cc-recipients. Each recipient must be in correct format
* **bcc:** The Bcc-recipients. Each recipient must be in correct format
* **subject:** The subject
* **replyTemplateId:** Optional ID of reply template to merge message with. &lt;= 0 to skip.
* **gdprSource:** Obsolete

**Returns:** This method has no return value


[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SendTicketMessage Request

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
   <Ticket:SendTicketMessage>
    <Ticket:TicketMessageEntityId xsi:type="xsd:int">0</Ticket:TicketMessageEntityId>
    <Ticket:To xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </Ticket:To>
    <Ticket:Cc xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </Ticket:Cc>
    <Ticket:Bcc xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </Ticket:Bcc>
    <Ticket:Subject xsi:type="xsd:string"></Ticket:Subject>
    <Ticket:ReplyTemplateId xsi:type="xsd:int">0</Ticket:ReplyTemplateId>
    <Ticket:GdprSource xsi:type="xsd:string"></Ticket:GdprSource>
   </Ticket:SendTicketMessage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SendTicketMessage Response

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
  <Ticket:SendTicketMessageResponse>
  </Ticket:SendTicketMessageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

