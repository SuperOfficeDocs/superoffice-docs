---
title: Services88.TicketAgent.ClearNotify SOAP
generated: 1
uid: Services88-Ticket-ClearNotify
---

# Services88 Ticket ClearNotify

Eksempler på SOAP-forespørsel og svar **Remote/Services88/Ticket.svc**
Implementert av metoden <see cref="M:SuperOffice.Services88.ITicketAgent.ClearNotify">SuperOffice.Services88.ITicketAgent.ClearNotify</see>.

## ClearNotify





[WSDL-fil for Services88/Ticket](../Services88-Ticket.md)

Hent en sak fra [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Programtokener må angis hvis du kaller en Online-installasjon. ApplicationTokens kontrolleres ikke for onsite-installasjoner.

## ClearNotify-forespørsel

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
   <Ticket:ClearNotify>
    <Ticket:Ids xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Ticket:Ids>
   </Ticket:ClearNotify>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ClearNotify-svar

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
  <Ticket:ClearNotifyResponse>
  </Ticket:ClearNotifyResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

