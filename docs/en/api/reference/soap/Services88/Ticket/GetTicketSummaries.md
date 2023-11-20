---
title: Services88.TicketAgent.GetTicketSummaries SOAP
generated: true
uid: Services88-Ticket-GetTicketSummaries
---

# Services88 Ticket GetTicketSummaries

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.GetTicketSummaries">SuperOffice.Services88.ITicketAgent.GetTicketSummaries</see> method.

## GetTicketSummaries





[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTicketSummaries Request

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
   <Ticket:GetTicketSummaries>
    <Ticket:TicketIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Ticket:TicketIds>
   </Ticket:GetTicketSummaries>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTicketSummaries Response

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
  <Ticket:GetTicketSummariesResponse>
   <Ticket:Response xsi:type="Ticket:ArrayOfTicketSummaryItem">
    <Ticket:TicketSummaryItem xsi:type="Ticket:TicketSummaryItem">
     <Ticket:TicketId xsi:type="xsd:int">0</Ticket:TicketId>
     <Ticket:TicketStatus xsi:type="xsd:int">0</Ticket:TicketStatus>
     <Ticket:Title xsi:type="xsd:string"></Ticket:Title>
     <Ticket:Registered xsi:type="xsd:dateTime">2023-11-10T12:37:53Z</Ticket:Registered>
     <Ticket:IconHint xsi:type="xsd:string"></Ticket:IconHint>
    </Ticket:TicketSummaryItem>
   </Ticket:Response>
  </Ticket:GetTicketSummariesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

