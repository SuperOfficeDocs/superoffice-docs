---
title: Services88.TicketAgent.GetDefaultMessageContentWithOptions SOAP
generated: true
uid: Services88-Ticket-GetDefaultMessageContentWithOptions
content_type: reference
---

# Services88 Ticket GetDefaultMessageContentWithOptions

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.GetDefaultMessageContentWithOptions">SuperOffice.Services88.ITicketAgent.GetDefaultMessageContentWithOptions</see> method.

## GetDefaultMessageContentWithOptions





[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDefaultMessageContentWithOptions Request

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
   <Ticket:GetDefaultMessageContentWithOptions>
    <Ticket:TicketId xsi:type="xsd:int">0</Ticket:TicketId>
    <Ticket:MessageActionType xsi:type="Ticket:MessageActionType">None</Ticket:MessageActionType>
    <Ticket:TicketMessageId xsi:type="xsd:int">0</Ticket:TicketMessageId>
    <Ticket:TicketTypeId xsi:type="xsd:int">0</Ticket:TicketTypeId>
    <Ticket:ExcludeSignature xsi:type="xsd:boolean">false</Ticket:ExcludeSignature>
   </Ticket:GetDefaultMessageContentWithOptions>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDefaultMessageContentWithOptions Response

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
  <Ticket:GetDefaultMessageContentWithOptionsResponse>
   <Ticket:Response xsi:type="Ticket:TicketMessageContent">
    <Ticket:Body xsi:type="xsd:string"></Ticket:Body>
    <Ticket:AttachmentsInfo xsi:type="Ticket:ArrayOfAttachmentEntity">
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
    </Ticket:AttachmentsInfo>
   </Ticket:Response>
  </Ticket:GetDefaultMessageContentWithOptionsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

