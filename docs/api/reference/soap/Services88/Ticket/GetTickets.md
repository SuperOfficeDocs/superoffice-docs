---
title: Services88.TicketAgent.GetTickets SOAP
generated: 1
uid: Services88-Ticket-GetTickets
---

# Services88 Ticket GetTickets

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.GetTickets">SuperOffice.Services88.ITicketAgent.GetTickets</see> method.

## GetTickets

Get multiple tickets

* **ticketIds:** The ids of tickets to get

**Returns:** Returns array of tickets in same order as input ids


[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTickets Request

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
   <Ticket:GetTickets>
    <Ticket:TicketIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Ticket:TicketIds>
   </Ticket:GetTickets>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTickets Response

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
  <Ticket:GetTicketsResponse>
   <Ticket:Response xsi:type="Ticket:ArrayOfTicket">
    <Ticket:Ticket xsi:type="Ticket:Ticket">
     <Ticket:TicketId xsi:type="xsd:int">0</Ticket:TicketId>
     <Ticket:Title xsi:type="xsd:string"></Ticket:Title>
     <Ticket:CreatedAt xsi:type="xsd:dateTime">2021-11-30T13:23:53Z</Ticket:CreatedAt>
     <Ticket:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:23:53Z</Ticket:LastChanged>
     <Ticket:ReadByOwner xsi:type="xsd:dateTime">2021-11-30T13:23:53Z</Ticket:ReadByOwner>
     <Ticket:ReadByCustomer xsi:type="xsd:dateTime">2021-11-30T13:23:53Z</Ticket:ReadByCustomer>
     <Ticket:FirstReadByUser xsi:type="xsd:dateTime">2021-11-30T13:23:53Z</Ticket:FirstReadByUser>
     <Ticket:Activate xsi:type="xsd:dateTime">2021-11-30T13:23:53Z</Ticket:Activate>
     <Ticket:ClosedAt xsi:type="xsd:dateTime">2021-11-30T13:23:53Z</Ticket:ClosedAt>
     <Ticket:RepliedAt xsi:type="xsd:dateTime">2021-11-30T13:23:53Z</Ticket:RepliedAt>
     <Ticket:AlertTimeout xsi:type="xsd:dateTime">2021-11-30T13:23:53Z</Ticket:AlertTimeout>
     <Ticket:Deadline xsi:type="xsd:dateTime">2021-11-30T13:23:53Z</Ticket:Deadline>
     <Ticket:CreatedBy xsi:type="xsd:int">0</Ticket:CreatedBy>
     <Ticket:CreatedByName xsi:type="xsd:string"></Ticket:CreatedByName>
     <Ticket:Author xsi:type="xsd:string"></Ticket:Author>
     <Ticket:OwnedBy xsi:type="xsd:int">0</Ticket:OwnedBy>
     <Ticket:OwnedByName xsi:type="xsd:string"></Ticket:OwnedByName>
     <Ticket:Category xsi:type="xsd:int">0</Ticket:Category>
     <Ticket:CategoryName xsi:type="xsd:string"></Ticket:CategoryName>
     <Ticket:CategoryFullname xsi:type="xsd:string"></Ticket:CategoryFullname>
     <Ticket:Slevel xsi:type="Ticket:TicketSecurityLevel">Unknown</Ticket:Slevel>
     <Ticket:Priority xsi:type="xsd:int">0</Ticket:Priority>
     <Ticket:PriorityName xsi:type="xsd:string"></Ticket:PriorityName>
     <Ticket:BaseStatus xsi:type="Ticket:TicketBaseStatus">Unknown</Ticket:BaseStatus>
     <Ticket:TicketStatus xsi:type="xsd:int">0</Ticket:TicketStatus>
     <Ticket:TicketStatusDisplayValue xsi:type="xsd:string"></Ticket:TicketStatusDisplayValue>
     <Ticket:Origin xsi:type="Ticket:TicketOrigin">Unknown</Ticket:Origin>
     <Ticket:CustId xsi:type="xsd:int">0</Ticket:CustId>
     <Ticket:PersonFirstname xsi:type="xsd:string"></Ticket:PersonFirstname>
     <Ticket:PersonMiddleName xsi:type="xsd:string"></Ticket:PersonMiddleName>
     <Ticket:PersonLastname xsi:type="xsd:string"></Ticket:PersonLastname>
     <Ticket:PersonFullname xsi:type="xsd:string"></Ticket:PersonFullname>
     <Ticket:AlertLevel xsi:type="xsd:short">0</Ticket:AlertLevel>
     <Ticket:ConnectId xsi:type="xsd:int">0</Ticket:ConnectId>
     <Ticket:ReadStatus xsi:type="Ticket:TicketReadStatus">Unknown</Ticket:ReadStatus>
     <Ticket:TimeToReply xsi:type="xsd:int">0</Ticket:TimeToReply>
     <Ticket:RealTimeToReply xsi:type="xsd:int">0</Ticket:RealTimeToReply>
     <Ticket:TimeToClose xsi:type="xsd:int">0</Ticket:TimeToClose>
     <Ticket:RealTimeToClose xsi:type="xsd:int">0</Ticket:RealTimeToClose>
     <Ticket:TimeSpentInternally xsi:type="xsd:int">0</Ticket:TimeSpentInternally>
     <Ticket:TimeSpentExternally xsi:type="xsd:int">0</Ticket:TimeSpentExternally>
     <Ticket:TimeSpentQueue xsi:type="xsd:int">0</Ticket:TimeSpentQueue>
     <Ticket:RealTimeSpentInternally xsi:type="xsd:int">0</Ticket:RealTimeSpentInternally>
     <Ticket:RealTimeSpentExternally xsi:type="xsd:int">0</Ticket:RealTimeSpentExternally>
     <Ticket:RealTimeSpentQueue xsi:type="xsd:int">0</Ticket:RealTimeSpentQueue>
     <Ticket:HasAttachment xsi:type="xsd:boolean">false</Ticket:HasAttachment>
     <Ticket:NumReplies xsi:type="xsd:int">0</Ticket:NumReplies>
     <Ticket:NumMessages xsi:type="xsd:int">0</Ticket:NumMessages>
     <Ticket:FromAddress xsi:type="xsd:string"></Ticket:FromAddress>
     <Ticket:ContactId xsi:type="xsd:int">0</Ticket:ContactId>
     <Ticket:ContactName xsi:type="xsd:string"></Ticket:ContactName>
     <Ticket:OwnedByAssociateId xsi:type="xsd:int">0</Ticket:OwnedByAssociateId>
    </Ticket:Ticket>
   </Ticket:Response>
  </Ticket:GetTicketsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

