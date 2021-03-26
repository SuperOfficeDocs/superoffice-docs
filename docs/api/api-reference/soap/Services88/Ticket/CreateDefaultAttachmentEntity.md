---
uid: services88-ticket-createdefaultattachmententity
title: Services88.TicketAgent.CreateDefaultAttachmentEntity SOAP
Generated: true
---

# Services88 Ticket CreateDefaultAttachmentEntity SOAP

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.CreateDefaultAttachmentEntity">SuperOffice.Services88.ITicketAgent.CreateDefaultAttachmentEntity</see> method.

## CreateDefaultAttachmentEntity

Loading default values into a new AttachmentEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New AttachmentEntity with default values


[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultAttachmentEntity Request

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
   <Ticket:CreateDefaultAttachmentEntity>
   </Ticket:CreateDefaultAttachmentEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultAttachmentEntity Response

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
  <Ticket:CreateDefaultAttachmentEntityResponse>
   <Ticket:Response xsi:type="Ticket:AttachmentEntity">
    <Ticket:AttachmentId xsi:type="xsd:int">0</Ticket:AttachmentId>
    <Ticket:Name xsi:type="xsd:string"></Ticket:Name>
    <Ticket:ContentType xsi:type="xsd:string"></Ticket:ContentType>
    <Ticket:AttSize xsi:type="xsd:int">0</Ticket:AttSize>
   </Ticket:Response>
  </Ticket:CreateDefaultAttachmentEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

