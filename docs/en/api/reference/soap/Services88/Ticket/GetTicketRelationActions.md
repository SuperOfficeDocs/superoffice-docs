---
title: Services88.TicketAgent.GetTicketRelationActions SOAP
generated: true
uid: Services88-Ticket-GetTicketRelationActions
content_type: reference
---

# Services88 Ticket GetTicketRelationActions

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.GetTicketRelationActions">SuperOffice.Services88.ITicketAgent.GetTicketRelationActions</see> method.

## GetTicketRelationActions





[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTicketRelationActions Request

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
   <Ticket:GetTicketRelationActions>
    <Ticket:TicketId xsi:type="xsd:int">0</Ticket:TicketId>
    <Ticket:ParentTicketId xsi:type="xsd:int">0</Ticket:ParentTicketId>
    <Ticket:TicketTypeId xsi:type="xsd:int">0</Ticket:TicketTypeId>
   </Ticket:GetTicketRelationActions>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTicketRelationActions Response

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
  <Ticket:GetTicketRelationActionsResponse>
   <Ticket:Response xsi:type="Ticket:TicketRelationAction">
    <Ticket:TicketIdToClose xsi:type="xsd:int">0</Ticket:TicketIdToClose>
    <Ticket:IsParentRequired xsi:type="xsd:boolean">false</Ticket:IsParentRequired>
    <Ticket:CanCloseCurrentTicket xsi:type="xsd:boolean">false</Ticket:CanCloseCurrentTicket>
    <Ticket:Children xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Ticket:Children>
   </Ticket:Response>
  </Ticket:GetTicketRelationActionsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

