---
uid: services88-list-getticketstatuslist
title: Services88.ListAgent.GetTicketStatusList SOAP
Generated: true
---

# Services88 List GetTicketStatusList SOAP

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.GetTicketStatusList">SuperOffice.Services88.IListAgent.GetTicketStatusList</see> method.

## GetTicketStatusList

Gets an array of TicketStatusEntity objects.

* **ticketStatusEntityIds:** The identifiers of the TicketStatusEntity object

**Returns:** Array of TicketStatusEntity objects


[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTicketStatusList Request

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
   <List:GetTicketStatusList>
    <List:TicketStatusEntityIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </List:TicketStatusEntityIds>
   </List:GetTicketStatusList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTicketStatusList Response

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
  <List:GetTicketStatusListResponse>
   <List:Response xsi:type="List:ArrayOfTicketStatusEntity">
    <List:TicketStatusEntity xsi:type="List:TicketStatusEntity">
     <List:TicketStatusId xsi:type="xsd:int">0</List:TicketStatusId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:Status xsi:type="List:TicketBaseStatus">Unknown</List:Status>
     <List:TimeCounter xsi:type="List:TicketStatusTimeCounter">None</List:TimeCounter>
     <List:NoEmailReopen xsi:type="xsd:boolean">false</List:NoEmailReopen>
    </List:TicketStatusEntity>
   </List:Response>
  </List:GetTicketStatusListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

