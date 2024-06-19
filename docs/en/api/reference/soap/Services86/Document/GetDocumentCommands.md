---
title: Services86.DocumentAgent.GetDocumentCommands SOAP
generated: 1
uid: Services86-Document-GetDocumentCommands
---

# Services86 Document GetDocumentCommands

SOAP request and response examples **Remote/Services86/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IDocumentAgent.GetDocumentCommands">SuperOffice.Services86.IDocumentAgent.GetDocumentCommands</see> method.

## GetDocumentCommands

[WSDL file for Services86/Document](../Services86-Document.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDocumentCommands Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:GetDocumentCommands>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
    <Document:AllowedReturnTypes xsi:type="NetServerServices862:ArrayOfstring">
     <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
    </Document:AllowedReturnTypes>
   </Document:GetDocumentCommands>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetDocumentCommands Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Document:GetDocumentCommandsResponse>
   <Document:Response xsi:type="Document:ArrayOfCommandInfo">
    <Document:CommandInfo xsi:type="Document:CommandInfo">
     <Document:Name xsi:type="xsd:string"></Document:Name>
     <Document:DisplayName xsi:type="xsd:string"></Document:DisplayName>
     <Document:DisplayTooltip xsi:type="xsd:string"></Document:DisplayTooltip>
     <Document:IconHint xsi:type="xsd:string"></Document:IconHint>
     <Document:ReturnType xsi:type="Document:ReturnType">None</Document:ReturnType>
    </Document:CommandInfo>
   </Document:Response>
  </Document:GetDocumentCommandsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
