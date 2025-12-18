---
title: Services88.TicketAgent.SaveTicketRelationEntity SOAP
generated: true
uid: Services88-Ticket-SaveTicketRelationEntity
content_type: reference
---

# Services88 Ticket SaveTicketRelationEntity

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.SaveTicketRelationEntity">SuperOffice.Services88.ITicketAgent.SaveTicketRelationEntity</see> method.

## SaveTicketRelationEntity





[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveTicketRelationEntity Request

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
   <Ticket:SaveTicketRelationEntity>
    <Ticket:TicketRelationEntity xsi:type="Ticket:TicketRelationEntity">
     <Ticket:TicketRelationId xsi:type="xsd:int">0</Ticket:TicketRelationId>
     <Ticket:SourceTicketId xsi:type="xsd:int">0</Ticket:SourceTicketId>
     <Ticket:DestinationTicketId xsi:type="xsd:int">0</Ticket:DestinationTicketId>
     <Ticket:RelationType xsi:type="Ticket:TicketRelationType">Related</Ticket:RelationType>
     <Ticket:Comment xsi:type="xsd:string"></Ticket:Comment>
    </Ticket:TicketRelationEntity>
   </Ticket:SaveTicketRelationEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveTicketRelationEntity Response

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
  <Ticket:SaveTicketRelationEntityResponse>
   <Ticket:Response xsi:type="Ticket:TicketRelationEntity">
    <Ticket:TicketRelationId xsi:type="xsd:int">0</Ticket:TicketRelationId>
    <Ticket:SourceTicketId xsi:type="xsd:int">0</Ticket:SourceTicketId>
    <Ticket:DestinationTicketId xsi:type="xsd:int">0</Ticket:DestinationTicketId>
    <Ticket:RelationType xsi:type="Ticket:TicketRelationType">Related</Ticket:RelationType>
    <Ticket:Comment xsi:type="xsd:string"></Ticket:Comment>
   </Ticket:Response>
  </Ticket:SaveTicketRelationEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

