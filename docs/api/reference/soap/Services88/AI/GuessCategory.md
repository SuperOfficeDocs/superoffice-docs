---
title: Services88.AIAgent.GuessCategory SOAP
generated: 1
uid: Services88-AI-GuessCategory
---

# Services88 AI GuessCategory

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.GuessCategory">SuperOffice.Services88.IAIAgent.GuessCategory</see> method.

## GuessCategory

Given a ticket's id, guess the ticket category it should be placed in. Currently this is based on the first message in the ticket

* **ticketId:** Id of ticket to guess category for

**Returns:** Suggested ticket category ID


[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GuessCategory Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:AI="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <AI:ApplicationToken>1234567-1234-9876</AI:ApplicationToken>
  <AI:Credentials>
    <AI:Ticket>7T:1234abcxyzExample==</AI:Ticket>
  </AI:Credentials>
 <SOAP-ENV:Body>
   <AI:GuessCategory>
    <AI:TicketId xsi:type="xsd:int">0</AI:TicketId>
   </AI:GuessCategory>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GuessCategory Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:AI="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <AI:GuessCategoryResponse>
   <AI:Response xsi:type="xsd:int">0</AI:Response>
  </AI:GuessCategoryResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

