---
title: Services88.ListAgent.DeleteTicketCategoryEntity SOAP
generated: 1
uid: Services88-List-DeleteTicketCategoryEntity
---

# Services88 List DeleteTicketCategoryEntity

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.DeleteTicketCategoryEntity">SuperOffice.Services88.IListAgent.DeleteTicketCategoryEntity</see> method.

## DeleteTicketCategoryEntity

Deletes the TicketCategoryEntity

* **ticketCategoryEntityId:** The identity of the TicketCategoryEntity



[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteTicketCategoryEntity Request

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
   <List:DeleteTicketCategoryEntity>
    <List:TicketCategoryEntityId xsi:type="xsd:int">0</List:TicketCategoryEntityId>
   </List:DeleteTicketCategoryEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteTicketCategoryEntity Response

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
  <List:DeleteTicketCategoryEntityResponse>
  </List:DeleteTicketCategoryEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

