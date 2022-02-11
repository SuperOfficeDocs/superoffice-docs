---
title: Services86.ListAgent.MoveAllTickets SOAP
generated: 1
uid: Services86-List-MoveAllTickets
---

# Services86 List MoveAllTickets

SOAP request and response examples **Remote/Services86/List.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IListAgent.MoveAllTickets">SuperOffice.Services86.IListAgent.MoveAllTickets</see> method.

## MoveAllTickets

Move all tickets from one ticket category to another

* **fromTicketCategoryId:** The id of the category we want to move tickets from
* **toTicketCategoryId:** The id of the category we want to move the tickets to

**Returns:** This method has no return value


[WSDL file for Services86/List](../Services86-List.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## MoveAllTickets Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:MoveAllTickets>
    <List:FromTicketCategoryId xsi:type="xsd:int">0</List:FromTicketCategoryId>
    <List:ToTicketCategoryId xsi:type="xsd:int">0</List:ToTicketCategoryId>
   </List:MoveAllTickets>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## MoveAllTickets Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <List:MoveAllTicketsResponse>
  </List:MoveAllTicketsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

