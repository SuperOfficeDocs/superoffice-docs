---
title: Services88.TicketAgent.GetRfcAttachmentStream SOAP
generated: true
uid: Services88-Ticket-GetRfcAttachmentStream
---

# Services88 Ticket GetRfcAttachmentStream

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.GetRfcAttachmentStream">SuperOffice.Services88.ITicketAgent.GetRfcAttachmentStream</see> method.

## GetRfcAttachmentStream





[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetRfcAttachmentStream Request

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
   <Ticket:GetRfcAttachmentStream>
    <Ticket:AttachmentId xsi:type="xsd:int">0</Ticket:AttachmentId>
    <Ticket:Position xsi:type="xsd:int">0</Ticket:Position>
   </Ticket:GetRfcAttachmentStream>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetRfcAttachmentStream Response

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
  <Ticket:GetRfcAttachmentStreamResponse>
   <Ticket:Response xsi:type="xsd:base64Binary"></Ticket:Response>
  </Ticket:GetRfcAttachmentStreamResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

