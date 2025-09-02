---
title: Services88.DiagnosticsAgent.RemoveSystemMessage SOAP
generated: true
uid: Services88-Diagnostics-RemoveSystemMessage
content_type: reference
---

# Services88 Diagnostics RemoveSystemMessage

SOAP request and response examples **Remote/Services88/Diagnostics.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDiagnosticsAgent.RemoveSystemMessage">SuperOffice.Services88.IDiagnosticsAgent.RemoveSystemMessage</see> method.

## RemoveSystemMessage





[WSDL file for Services88/Diagnostics](../Services88-Diagnostics.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveSystemMessage Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Diagnostics:ApplicationToken>1234567-1234-9876</Diagnostics:ApplicationToken>
  <Diagnostics:Credentials>
    <Diagnostics:Ticket>7T:1234abcxyzExample==</Diagnostics:Ticket>
  </Diagnostics:Credentials>
 <SOAP-ENV:Body>
   <Diagnostics:RemoveSystemMessage>
    <Diagnostics:OnlineappId xsi:type="xsd:int">0</Diagnostics:OnlineappId>
    <Diagnostics:SystemMessageId xsi:type="xsd:string"></Diagnostics:SystemMessageId>
   </Diagnostics:RemoveSystemMessage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RemoveSystemMessage Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Diagnostics:RemoveSystemMessageResponse>
  </Diagnostics:RemoveSystemMessageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

