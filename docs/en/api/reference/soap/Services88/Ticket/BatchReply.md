---
title: Services88.TicketAgent.BatchReply SOAP
generated: true
uid: Services88-Ticket-BatchReply
content_type: reference
---

# Services88 Ticket BatchReply

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.BatchReply">SuperOffice.Services88.ITicketAgent.BatchReply</see> method.

## BatchReply





[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## BatchReply Request

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
   <Ticket:BatchReply>
    <Ticket:BatchReplyData xsi:type="Ticket:TicketBatchReplyData">
     <Ticket:TicketIds xsi:type="NetServerServices882:ArrayOfint">
      <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
     </Ticket:TicketIds>
     <Ticket:CloseTickets xsi:type="xsd:boolean">false</Ticket:CloseTickets>
     <Ticket:AttachmentIds xsi:type="NetServerServices882:ArrayOfint">
      <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
     </Ticket:AttachmentIds>
     <Ticket:HtmlBody xsi:type="xsd:string"></Ticket:HtmlBody>
     <Ticket:Slevel xsi:type="Ticket:TicketSecurityLevel">Unknown</Ticket:Slevel>
     <Ticket:TimeSpent xsi:type="xsd:int">0</Ticket:TimeSpent>
     <Ticket:SendCopyToCustomer xsi:type="xsd:boolean">false</Ticket:SendCopyToCustomer>
    </Ticket:BatchReplyData>
   </Ticket:BatchReply>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## BatchReply Response

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
  <Ticket:BatchReplyResponse>
   <Ticket:Response xsi:type="xsd:int">0</Ticket:Response>
  </Ticket:BatchReplyResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

