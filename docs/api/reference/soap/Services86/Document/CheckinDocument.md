---
title: Services86.DocumentAgent.CheckinDocument SOAP
generated: 1
uid: Services86-Document-CheckinDocument
---

# Services86 Document CheckinDocument

SOAP request and response examples **Remote/Services86/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IDocumentAgent.CheckinDocument">SuperOffice.Services86.IDocumentAgent.CheckinDocument</see> method.

## CheckinDocument

Check in a currently checked-out document

* **documentId:** SuperOffice document Id
* **allowedReturnTypes:** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.&lt;br/&gt;Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.&lt;br/&gt;An empty array implies that the client places no restriction on possible return action requests.
* **versionDescription:** Optional textual description related to this version of the document; may be blank, and is discarded if the document/plugin do not support versioning.
* **versionExtraFields:** Optional extra metadata related to the new version (as opposed to metadata related to the document as a whole). Discarded if the document/plugin do not support versioning.

**Returns:** Return information, including possible requests for further processing ("Return Action"). Return actions are constrained by the allowedReturnTypes parameter.


[WSDL file for Services86/Document](../Services86-Document.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CheckinDocument Request

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
   <Document:CheckinDocument>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
    <Document:AllowedReturnTypes xsi:type="NetServerServices862:ArrayOfstring">
     <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
    </Document:AllowedReturnTypes>
    <Document:VersionDescription xsi:type="xsd:string"></Document:VersionDescription>
    <Document:VersionExtraFields xsi:type="NetServerServices862:ArrayOfstring">
     <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
    </Document:VersionExtraFields>
   </Document:CheckinDocument>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CheckinDocument Response

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
  <Document:CheckinDocumentResponse>
   <Document:Response xsi:type="Document:ReturnInfo">
    <Document:ExternalReference xsi:type="xsd:string"></Document:ExternalReference>
    <Document:VersionId xsi:type="xsd:string"></Document:VersionId>
    <Document:Success xsi:type="xsd:boolean">false</Document:Success>
    <Document:Type xsi:type="Document:ReturnType">None</Document:Type>
    <Document:Value xsi:type="xsd:string"></Document:Value>
    <Document:AdditionalInfo xsi:type="xsd:string"></Document:AdditionalInfo>
   </Document:Response>
  </Document:CheckinDocumentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

