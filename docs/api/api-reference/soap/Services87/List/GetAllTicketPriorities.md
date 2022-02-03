---
title: Services87.ListAgent.GetAllTicketPriorities SOAP
generated: 1
uid: Services87-List-GetAllTicketPriorities
---

# Services87 List GetAllTicketPriorities

SOAP request and response examples **Remote/Services87/List.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IListAgent.GetAllTicketPriorities">SuperOffice.Services87.IListAgent.GetAllTicketPriorities</see> method.

## GetAllTicketPriorities

Returns all available ticket priorities.

* **includeDeleted:** Include deleted items in result?

**Returns:** An array of all available ticket priorities


[WSDL file for Services87/List](../Services87-List.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAllTicketPriorities Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetAllTicketPriorities>
    <List:IncludeDeleted xsi:type="xsd:boolean">false</List:IncludeDeleted>
   </List:GetAllTicketPriorities>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAllTicketPriorities Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <List:GetAllTicketPrioritiesResponse>
   <List:Response xsi:type="List:ArrayOfTicketPriorityEntity">
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
     <List:MonStart xsi:type="xsd:dateTime">2021-11-30T13:23:18Z</List:MonStart>
     <List:MonStop xsi:type="xsd:dateTime">2021-11-30T13:23:18Z</List:MonStop>
     <List:TueStart xsi:type="xsd:dateTime">2021-11-30T13:23:18Z</List:TueStart>
     <List:TueStop xsi:type="xsd:dateTime">2021-11-30T13:23:18Z</List:TueStop>
     <List:WedStart xsi:type="xsd:dateTime">2021-11-30T13:23:18Z</List:WedStart>
     <List:WedStop xsi:type="xsd:dateTime">2021-11-30T13:23:18Z</List:WedStop>
     <List:ThuStart xsi:type="xsd:dateTime">2021-11-30T13:23:18Z</List:ThuStart>
     <List:ThuStop xsi:type="xsd:dateTime">2021-11-30T13:23:18Z</List:ThuStop>
     <List:FriStart xsi:type="xsd:dateTime">2021-11-30T13:23:18Z</List:FriStart>
     <List:FriStop xsi:type="xsd:dateTime">2021-11-30T13:23:18Z</List:FriStop>
     <List:SatStart xsi:type="xsd:dateTime">2021-11-30T13:23:18Z</List:SatStart>
     <List:SatStop xsi:type="xsd:dateTime">2021-11-30T13:23:18Z</List:SatStop>
     <List:SunStart xsi:type="xsd:dateTime">2021-11-30T13:23:18Z</List:SunStart>
     <List:SunStop xsi:type="xsd:dateTime">2021-11-30T13:23:18Z</List:SunStop>
     <List:NonDates xsi:type="NetServerServices872:ArrayOfdateTime">
      <NetServerServices872:dateTime xsi:type="xsd:dateTime">2021-11-30T13:23:18Z</NetServerServices872:dateTime>
     </List:NonDates>
    </List:TicketPriorityEntity>
   </List:Response>
  </List:GetAllTicketPrioritiesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

