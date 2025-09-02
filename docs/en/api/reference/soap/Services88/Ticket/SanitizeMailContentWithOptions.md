---
title: Services88.TicketAgent.SanitizeMailContentWithOptions SOAP
generated: true
uid: Services88-Ticket-SanitizeMailContentWithOptions
content_type: reference
---

# Services88 Ticket SanitizeMailContentWithOptions

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.SanitizeMailContentWithOptions">SuperOffice.Services88.ITicketAgent.SanitizeMailContentWithOptions</see> method.

## SanitizeMailContentWithOptions





[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SanitizeMailContentWithOptions Request

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
   <Ticket:SanitizeMailContentWithOptions>
    <Ticket:Content xsi:type="xsd:string"></Ticket:Content>
    <Ticket:Options xsi:type="Ticket:HtmlSanitizerOptions">RemoveComment</Ticket:Options>
   </Ticket:SanitizeMailContentWithOptions>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SanitizeMailContentWithOptions Response

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
  <Ticket:SanitizeMailContentWithOptionsResponse>
   <Ticket:Response xsi:type="xsd:string"></Ticket:Response>
  </Ticket:SanitizeMailContentWithOptionsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

