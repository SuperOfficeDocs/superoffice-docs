---
title: Services88.TicketAgent.GetTicketRelations SOAP
generated: true
uid: Services88-Ticket-GetTicketRelations
content_type: reference
---

# Services88 Ticket GetTicketRelations

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.GetTicketRelations">SuperOffice.Services88.ITicketAgent.GetTicketRelations</see> method.

## GetTicketRelations





[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTicketRelations Request

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
   <Ticket:GetTicketRelations>
    <Ticket:TicketId xsi:type="xsd:int">0</Ticket:TicketId>
   </Ticket:GetTicketRelations>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTicketRelations Response

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
  <Ticket:GetTicketRelationsResponse>
   <Ticket:Response xsi:type="Ticket:ArrayOfTicketRelationItem">
    <Ticket:TicketRelationItem xsi:type="Ticket:TicketRelationItem">
     <Ticket:TicketRelationId xsi:type="xsd:int">0</Ticket:TicketRelationId>
     <Ticket:RelationType xsi:type="Ticket:TicketRelationType">Related</Ticket:RelationType>
     <Ticket:RelationComment xsi:type="xsd:string"></Ticket:RelationComment>
     <Ticket:HasParent xsi:type="xsd:boolean">false</Ticket:HasParent>
     <Ticket:ChildCount xsi:type="xsd:int">0</Ticket:ChildCount>
     <Ticket:RelatedCount xsi:type="xsd:int">0</Ticket:RelatedCount>
     <Ticket:RelationCreatedAt xsi:type="xsd:dateTime">2026-05-27T01:25:26Z</Ticket:RelationCreatedAt>
     <Ticket:TicketId xsi:type="xsd:int">0</Ticket:TicketId>
     <Ticket:Title xsi:type="xsd:string"></Ticket:Title>
     <Ticket:IconHint xsi:type="xsd:string"></Ticket:IconHint>
     <Ticket:CustId xsi:type="xsd:int">0</Ticket:CustId>
     <Ticket:PersonFullname xsi:type="xsd:string"></Ticket:PersonFullname>
     <Ticket:ContactId xsi:type="xsd:int">0</Ticket:ContactId>
     <Ticket:ContactName xsi:type="xsd:string"></Ticket:ContactName>
     <Ticket:BaseStatus xsi:type="Ticket:TicketBaseStatus">Unknown</Ticket:BaseStatus>
     <Ticket:TicketStatus xsi:type="xsd:int">0</Ticket:TicketStatus>
     <Ticket:TicketStatusDisplayValue xsi:type="xsd:string"></Ticket:TicketStatusDisplayValue>
     <Ticket:TicketCreatedAt xsi:type="xsd:dateTime">2026-05-27T01:25:26Z</Ticket:TicketCreatedAt>
    </Ticket:TicketRelationItem>
   </Ticket:Response>
  </Ticket:GetTicketRelationsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

