---
title: Services88.TicketAgent.GetDefaultMessageContentFull SOAP
generated: true
uid: Services88-Ticket-GetDefaultMessageContentFull
---

# Services88 Ticket GetDefaultMessageContentFull

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.GetDefaultMessageContentFull">SuperOffice.Services88.ITicketAgent.GetDefaultMessageContentFull</see> method.

## GetDefaultMessageContentFull





[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDefaultMessageContentFull Request

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
   <Ticket:GetDefaultMessageContentFull>
    <Ticket:TicketId xsi:type="xsd:int">0</Ticket:TicketId>
    <Ticket:MessageActionType xsi:type="Ticket:MessageActionType">None</Ticket:MessageActionType>
    <Ticket:TicketMessageId xsi:type="xsd:int">0</Ticket:TicketMessageId>
    <Ticket:TicketTypeId xsi:type="xsd:int">0</Ticket:TicketTypeId>
   </Ticket:GetDefaultMessageContentFull>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDefaultMessageContentFull Response

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
  <Ticket:GetDefaultMessageContentFullResponse>
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
     </Ticket:AttachmentEntity>
    </Ticket:AttachmentsInfo>
   </Ticket:Response>
  </Ticket:GetDefaultMessageContentFullResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

