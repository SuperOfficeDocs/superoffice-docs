---
title: Services88.DiagnosticsAgent.GetSystemMessages SOAP
generated: true
uid: Services88-Diagnostics-GetSystemMessages
---

# Services88 Diagnostics GetSystemMessages

SOAP request and response examples **Remote/Services88/Diagnostics.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDiagnosticsAgent.GetSystemMessages">SuperOffice.Services88.IDiagnosticsAgent.GetSystemMessages</see> method.

## GetSystemMessages





[WSDL file for Services88/Diagnostics](../Services88-Diagnostics.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSystemMessages Request

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
   <Diagnostics:GetSystemMessages>
    <Diagnostics:AssociateId xsi:type="xsd:int">0</Diagnostics:AssociateId>
   </Diagnostics:GetSystemMessages>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSystemMessages Response

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
  <Diagnostics:GetSystemMessagesResponse>
   <Diagnostics:Response xsi:type="Diagnostics:ArrayOfSystemMessage">
    <Diagnostics:SystemMessage xsi:type="Diagnostics:SystemMessage">
     <Diagnostics:MessageId xsi:type="xsd:int">0</Diagnostics:MessageId>
     <Diagnostics:AssociateId xsi:type="xsd:int">0</Diagnostics:AssociateId>
     <Diagnostics:OnlineappId xsi:type="xsd:int">0</Diagnostics:OnlineappId>
     <Diagnostics:SystemMessageId xsi:type="xsd:string"></Diagnostics:SystemMessageId>
     <Diagnostics:MarkdownMessage xsi:type="xsd:string"></Diagnostics:MarkdownMessage>
     <Diagnostics:Expire xsi:type="xsd:dateTime">2024-10-09T01:43:09Z</Diagnostics:Expire>
     <Diagnostics:Type xsi:type="Diagnostics:SystemMessageType">Info</Diagnostics:Type>
    </Diagnostics:SystemMessage>
   </Diagnostics:Response>
  </Diagnostics:GetSystemMessagesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

