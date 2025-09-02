---
title: Services88.ListAgent.GlobalChangeTicketStatus SOAP
generated: true
uid: Services88-List-GlobalChangeTicketStatus
content_type: reference
---

# Services88 List GlobalChangeTicketStatus

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.GlobalChangeTicketStatus">SuperOffice.Services88.IListAgent.GlobalChangeTicketStatus</see> method.

## GlobalChangeTicketStatus





[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GlobalChangeTicketStatus Request

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
   <List:GlobalChangeTicketStatus>
    <List:FromTicketStatusId xsi:type="xsd:int">0</List:FromTicketStatusId>
    <List:ToTicketStatusId xsi:type="xsd:int">0</List:ToTicketStatusId>
   </List:GlobalChangeTicketStatus>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GlobalChangeTicketStatus Response

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
  <List:GlobalChangeTicketStatusResponse>
  </List:GlobalChangeTicketStatusResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

