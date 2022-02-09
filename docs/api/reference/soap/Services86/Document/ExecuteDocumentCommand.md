---
title: Services86.DocumentAgent.ExecuteDocumentCommand SOAP
generated: 1
uid: Services86-Document-ExecuteDocumentCommand
---

# Services86 Document ExecuteDocumentCommand

SOAP request and response examples **Remote/Services86/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IDocumentAgent.ExecuteDocumentCommand">SuperOffice.Services86.IDocumentAgent.ExecuteDocumentCommand</see> method.

## ExecuteDocumentCommand

Execute a custom command on a particular document, optionally a particular version

* **documentId:** SuperOffice document ID
* **versionId:** Version ID if applicable/desired; a blank value implies "latest" version and is always acceptable.
* **allowedReturnTypes:** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.&lt;br/&gt;Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.&lt;br/&gt;An empty array implies that the client places no restriction on possible return action requests.
* **command:** Command name, generally matching one of those returned from the GetDocumentCommands service. However, it is legal for document plugins to support commands that are not declared through GetDocumentCommands, for instance if a custom GUI needs to access plugin functionality.
* **additionalData:** Any additional data that the document command needs. This parameter can be used as a tunnel between a custom-programmed GUI and its plugin.&lt;br/&gt;It is suggested that the format is name=value, with one such pair per array item.

**Returns:** Return information, including possible requests for further processing ("Return Action"). Return actions are constrained by the allowedReturnTypes parameter.


[WSDL file for Services86/Document](../Services86-Document.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ExecuteDocumentCommand Request

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
   <Document:ExecuteDocumentCommand>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
    <Document:VersionId xsi:type="xsd:string"></Document:VersionId>
    <Document:AllowedReturnTypes xsi:type="NetServerServices862:ArrayOfstring">
     <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
    </Document:AllowedReturnTypes>
    <Document:Command xsi:type="xsd:string"></Document:Command>
    <Document:AdditionalData xsi:type="NetServerServices862:ArrayOfstring">
     <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
    </Document:AdditionalData>
   </Document:ExecuteDocumentCommand>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ExecuteDocumentCommand Response

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
  <Document:ExecuteDocumentCommandResponse>
   <Document:Response xsi:type="Document:ReturnInfo">
    <Document:ExternalReference xsi:type="xsd:string"></Document:ExternalReference>
    <Document:VersionId xsi:type="xsd:string"></Document:VersionId>
    <Document:Success xsi:type="xsd:boolean">false</Document:Success>
    <Document:Type xsi:type="Document:ReturnType">None</Document:Type>
    <Document:Value xsi:type="xsd:string"></Document:Value>
    <Document:AdditionalInfo xsi:type="xsd:string"></Document:AdditionalInfo>
   </Document:Response>
  </Document:ExecuteDocumentCommandResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

