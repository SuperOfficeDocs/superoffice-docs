---
title: Services88.TicketAgent.GetAttachmentPreview SOAP
generated: true
uid: Services88-Ticket-GetAttachmentPreview
content_type: reference
---

# Services88 Ticket GetAttachmentPreview

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.GetAttachmentPreview">SuperOffice.Services88.ITicketAgent.GetAttachmentPreview</see> method.

## GetAttachmentPreview





[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAttachmentPreview Request

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
   <Ticket:GetAttachmentPreview>
    <Ticket:AttachmentId xsi:type="xsd:int">0</Ticket:AttachmentId>
   </Ticket:GetAttachmentPreview>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAttachmentPreview Response

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
  <Ticket:GetAttachmentPreviewResponse>
   <Ticket:Response xsi:type="Ticket:AttachmentPreview">
    <Ticket:Name xsi:type="xsd:string"></Ticket:Name>
    <Ticket:MimeType xsi:type="xsd:string"></Ticket:MimeType>
    <Ticket:Size xsi:type="xsd:int">0</Ticket:Size>
    <Ticket:Content xsi:type="xsd:base64Binary"></Ticket:Content>
    <Ticket:EmailSubject xsi:type="xsd:string"></Ticket:EmailSubject>
    <Ticket:EmailFrom xsi:type="xsd:string"></Ticket:EmailFrom>
    <Ticket:EmailTo xsi:type="xsd:string"></Ticket:EmailTo>
    <Ticket:EmailCc xsi:type="xsd:string"></Ticket:EmailCc>
    <Ticket:EmailDate xsi:type="xsd:dateTime">2025-09-19T09:24:26Z</Ticket:EmailDate>
    <Ticket:EmailAttachmentsInfo xsi:type="Ticket:ArrayOfAttachmentEntity">
     <Ticket:AttachmentEntity xsi:type="Ticket:AttachmentEntity">
      <Ticket:AttachmentId xsi:type="xsd:int">0</Ticket:AttachmentId>
      <Ticket:Name xsi:type="xsd:string"></Ticket:Name>
      <Ticket:ContentType xsi:type="xsd:string"></Ticket:ContentType>
      <Ticket:AttSize xsi:type="xsd:int">0</Ticket:AttSize>
      <Ticket:InlineImage xsi:type="xsd:boolean">false</Ticket:InlineImage>
      <Ticket:ContentId xsi:type="xsd:string"></Ticket:ContentId>
      <Ticket:AuthKey xsi:type="xsd:string"></Ticket:AuthKey>
      <Ticket:IsSafeFileExtension xsi:type="xsd:boolean">false</Ticket:IsSafeFileExtension>
     </Ticket:AttachmentEntity>
    </Ticket:EmailAttachmentsInfo>
   </Ticket:Response>
  </Ticket:GetAttachmentPreviewResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

