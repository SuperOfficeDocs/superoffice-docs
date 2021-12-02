---
title: Services86.TicketAgent.GetTicket SOAP
generated: 1
uid: Services86-Ticket-GetTicket
---

# Services86 Ticket GetTicket

SOAP request and response examples **Remote/Services86/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ITicketAgent.GetTicket">SuperOffice.Services86.ITicketAgent.GetTicket</see> method.

## GetTicket

Gets a Ticket object.

* **ticketId:** The identifier of the Ticket object

**Returns:** Ticket


[WSDL file for Services86/Ticket](../Services86-Ticket.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTicket Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Ticket="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Ticket:ApplicationToken>1234567-1234-9876</Ticket:ApplicationToken>
  <Ticket:Credentials>
    <Ticket:Ticket>7T:1234abcxyzExample==</Ticket:Ticket>
  </Ticket:Credentials>
 <SOAP-ENV:Body>
   <Ticket:GetTicket>
    <Ticket:TicketId xsi:type="xsd:int">0</Ticket:TicketId>
   </Ticket:GetTicket>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTicket Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Ticket="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Ticket:GetTicketResponse>
   <Ticket:Response xsi:type="Ticket:Ticket">
    <Ticket:TicketId xsi:type="xsd:int">0</Ticket:TicketId>
    <Ticket:Title xsi:type="xsd:string"></Ticket:Title>
    <Ticket:CreatedAt xsi:type="xsd:dateTime">2021-11-30T13:23:05Z</Ticket:CreatedAt>
    <Ticket:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:23:05Z</Ticket:LastChanged>
    <Ticket:ReadByOwner xsi:type="xsd:dateTime">2021-11-30T13:23:05Z</Ticket:ReadByOwner>
    <Ticket:ReadByCustomer xsi:type="xsd:dateTime">2021-11-30T13:23:05Z</Ticket:ReadByCustomer>
    <Ticket:FirstReadByUser xsi:type="xsd:dateTime">2021-11-30T13:23:05Z</Ticket:FirstReadByUser>
    <Ticket:Activate xsi:type="xsd:dateTime">2021-11-30T13:23:05Z</Ticket:Activate>
    <Ticket:ClosedAt xsi:type="xsd:dateTime">2021-11-30T13:23:05Z</Ticket:ClosedAt>
    <Ticket:RepliedAt xsi:type="xsd:dateTime">2021-11-30T13:23:05Z</Ticket:RepliedAt>
    <Ticket:AlertTimeout xsi:type="xsd:dateTime">2021-11-30T13:23:05Z</Ticket:AlertTimeout>
    <Ticket:Deadline xsi:type="xsd:dateTime">2021-11-30T13:23:05Z</Ticket:Deadline>
    <Ticket:CreatedBy xsi:type="xsd:int">0</Ticket:CreatedBy>
    <Ticket:Author xsi:type="xsd:string"></Ticket:Author>
    <Ticket:OwnedBy xsi:type="xsd:int">0</Ticket:OwnedBy>
    <Ticket:Category xsi:type="xsd:int">0</Ticket:Category>
    <Ticket:Slevel xsi:type="Ticket:TicketSecurityLevel">Unknown</Ticket:Slevel>
    <Ticket:Priority xsi:type="xsd:int">0</Ticket:Priority>
    <Ticket:BaseStatus xsi:type="Ticket:TicketBaseStatus">Unknown</Ticket:BaseStatus>
    <Ticket:TicketStatus xsi:type="xsd:int">0</Ticket:TicketStatus>
    <Ticket:Origin xsi:type="Ticket:TicketOrigin">Unknown</Ticket:Origin>
    <Ticket:CustId xsi:type="xsd:int">0</Ticket:CustId>
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
   </Ticket:Response>
  </Ticket:GetTicketResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

