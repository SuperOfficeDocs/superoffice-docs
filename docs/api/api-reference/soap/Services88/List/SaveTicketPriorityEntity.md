---
uid: services88-list-saveticketpriorityentity
title: Services88.ListAgent.SaveTicketPriorityEntity SOAP
Generated: true
---

# Services88 List SaveTicketPriorityEntity SOAP

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.SaveTicketPriorityEntity">SuperOffice.Services88.IListAgent.SaveTicketPriorityEntity</see> method.

## SaveTicketPriorityEntity

Updates the existing TicketPriorityEntity or creates a new TicketPriorityEntity if the id parameter is 0.

* **ticketPriorityEntity:** The TicketPriorityEntity that is saved.

**Returns:** New or updated TicketPriorityEntity


[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveTicketPriorityEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:SaveTicketPriorityEntity>
    <List:TicketPriorityEntity xsi:type="List:TicketPriorityEntity">
     <List:TicketPriorityId xsi:type="xsd:int">0</List:TicketPriorityId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:Status xsi:type="List:TicketPriorityStatus">Unknown</List:Status>
     <List:Flags xsi:type="List:TicketPriorityFlags">External</List:Flags>
     <List:SortOrder xsi:type="xsd:int">0</List:SortOrder>
     <List:TicketRead xsi:type="List:TicketPriorityEscalateEvent">None</List:TicketRead>
     <List:ChangedOwner xsi:type="List:TicketPriorityEscalateEvent">None</List:ChangedOwner>
     <List:TicketNewinfo xsi:type="List:TicketPriorityEscalateEvent">None</List:TicketNewinfo>
     <List:TicketClosed xsi:type="List:TicketPriorityEscalateEvent">None</List:TicketClosed>
     <List:TicketChangedPriority xsi:type="List:TicketPriorityEscalateEvent">None</List:TicketChangedPriority>
     <List:TicketNew xsi:type="List:TicketPriorityEscalateEvent">None</List:TicketNew>
     <List:Deadline xsi:type="xsd:int">0</List:Deadline>
     <List:MonStart xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:MonStart>
     <List:MonStop xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:MonStop>
     <List:TueStart xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:TueStart>
     <List:TueStop xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:TueStop>
     <List:WedStart xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:WedStart>
     <List:WedStop xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:WedStop>
     <List:ThuStart xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:ThuStart>
     <List:ThuStop xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:ThuStop>
     <List:FriStart xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:FriStart>
     <List:FriStop xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:FriStop>
     <List:SatStart xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:SatStart>
     <List:SatStop xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:SatStop>
     <List:SunStart xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:SunStart>
     <List:SunStop xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:SunStop>
     <List:NonDates xsi:type="NetServerServices882:ArrayOfdateTime">
      <NetServerServices882:dateTime xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</NetServerServices882:dateTime>
     </List:NonDates>
    </List:TicketPriorityEntity>
   </List:SaveTicketPriorityEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveTicketPriorityEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <List:SaveTicketPriorityEntityResponse>
   <List:Response xsi:type="List:TicketPriorityEntity">
    <List:TicketPriorityId xsi:type="xsd:int">0</List:TicketPriorityId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Status xsi:type="List:TicketPriorityStatus">Unknown</List:Status>
    <List:Flags xsi:type="List:TicketPriorityFlags">External</List:Flags>
    <List:SortOrder xsi:type="xsd:int">0</List:SortOrder>
    <List:TicketRead xsi:type="List:TicketPriorityEscalateEvent">None</List:TicketRead>
    <List:ChangedOwner xsi:type="List:TicketPriorityEscalateEvent">None</List:ChangedOwner>
    <List:TicketNewinfo xsi:type="List:TicketPriorityEscalateEvent">None</List:TicketNewinfo>
    <List:TicketClosed xsi:type="List:TicketPriorityEscalateEvent">None</List:TicketClosed>
    <List:TicketChangedPriority xsi:type="List:TicketPriorityEscalateEvent">None</List:TicketChangedPriority>
    <List:TicketNew xsi:type="List:TicketPriorityEscalateEvent">None</List:TicketNew>
    <List:Deadline xsi:type="xsd:int">0</List:Deadline>
    <List:MonStart xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:MonStart>
    <List:MonStop xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:MonStop>
    <List:TueStart xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:TueStart>
    <List:TueStop xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:TueStop>
    <List:WedStart xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:WedStart>
    <List:WedStop xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:WedStop>
    <List:ThuStart xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:ThuStart>
    <List:ThuStop xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:ThuStop>
    <List:FriStart xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:FriStart>
    <List:FriStop xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:FriStop>
    <List:SatStart xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:SatStart>
    <List:SatStop xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:SatStop>
    <List:SunStart xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:SunStart>
    <List:SunStop xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</List:SunStop>
    <List:NonDates xsi:type="NetServerServices882:ArrayOfdateTime">
     <NetServerServices882:dateTime xsi:type="xsd:dateTime">2021-03-25T21:37:02Z</NetServerServices882:dateTime>
    </List:NonDates>
   </List:Response>
  </List:SaveTicketPriorityEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

