---
uid: services87-list-getticketpriority
title: Services87.ListAgent.GetTicketPriority SOAP
Generated: true
---

# Services87 List GetTicketPriority SOAP

SOAP request and response examples **Remote/Services87/List.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IListAgent.GetTicketPriority">SuperOffice.Services87.IListAgent.GetTicketPriority</see> method.

## GetTicketPriority

Gets a TicketPriority object.

* **ticketPriorityId:** The identifier of the TicketPriority object

**Returns:** TicketPriority


[WSDL file for Services87/List](../Services87-List.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTicketPriority Request

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
   <List:GetTicketPriority>
    <List:TicketPriorityId xsi:type="xsd:int">0</List:TicketPriorityId>
   </List:GetTicketPriority>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTicketPriority Response

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
  <List:GetTicketPriorityResponse>
   <List:Response xsi:type="List:TicketPriority">
    <List:Id xsi:type="xsd:int">0</List:Id>
    <List:Value xsi:type="xsd:string"></List:Value>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
   </List:Response>
  </List:GetTicketPriorityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

