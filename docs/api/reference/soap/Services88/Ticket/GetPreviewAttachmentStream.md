---
title: Services88.TicketAgent.GetPreviewAttachmentStream SOAP
generated: 1
uid: Services88-Ticket-GetPreviewAttachmentStream
---

# Services88 Ticket GetPreviewAttachmentStream

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.GetPreviewAttachmentStream">SuperOffice.Services88.ITicketAgent.GetPreviewAttachmentStream</see> method.

## GetPreviewAttachmentStream

Retrieve an attachment from ticket message. The returned data is intended to be used for a preview. The returned data is sanitized.

* **attachmentId:** The id of the attachment to retrieve

**Returns:** Sanitized preview version of the attachment

[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPreviewAttachmentStream Request

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
   <Ticket:GetPreviewAttachmentStream>
    <Ticket:AttachmentId xsi:type="xsd:int">0</Ticket:AttachmentId>
   </Ticket:GetPreviewAttachmentStream>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetPreviewAttachmentStream Response

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
  <Ticket:GetPreviewAttachmentStreamResponse>
   <Ticket:Response xsi:type="Ticket:DocumentPreview">
    <Ticket:Name xsi:type="xsd:string"></Ticket:Name>
    <Ticket:Type xsi:type="xsd:string"></Ticket:Type>
    <Ticket:Size xsi:type="xsd:int">0</Ticket:Size>
    <Ticket:Stream xsi:type="xsd:base64Binary"></Ticket:Stream>
   </Ticket:Response>
  </Ticket:GetPreviewAttachmentStreamResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
