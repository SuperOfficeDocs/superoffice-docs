---
uid: services82-document-undocheckoutdocument
title: Services82.DocumentAgent.UndoCheckoutDocument SOAP
Generated: true
---

# Services82 Document UndoCheckoutDocument SOAP

SOAP request and response examples **Remote/Services82/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IDocumentAgent.UndoCheckoutDocument">SuperOffice.Services82.IDocumentAgent.UndoCheckoutDocument</see> method.

## UndoCheckoutDocument

Undo (abandon) a checkout

* **documentId:** SuperOffice document ID
* **allowedReturnTypes:** List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.<br />Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.<br />An empty array implies that the client places no restriction on possible return action requests.

**Returns:** Return information, including possible requests for further processing ("Return Action"). Return actions are constrained by the allowedReturnTypes parameter.


[WSDL file for Services82/Document](../Services82-Document.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## UndoCheckoutDocument Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:UndoCheckoutDocument>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
    <Document:AllowedReturnTypes xsi:type="NetServerServices822:ArrayOfstring">
     <NetServerServices822:string xsi:type="xsd:string"></NetServerServices822:string>
    </Document:AllowedReturnTypes>
   </Document:UndoCheckoutDocument>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## UndoCheckoutDocument Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <Document:UndoCheckoutDocumentResponse>
   <Document:Response xsi:type="Document:ReturnInfo">
    <Document:ExternalReference xsi:type="xsd:string"></Document:ExternalReference>
    <Document:VersionId xsi:type="xsd:string"></Document:VersionId>
    <Document:Success xsi:type="xsd:boolean">false</Document:Success>
    <Document:Type xsi:type="Document:ReturnType">None</Document:Type>
    <Document:Value xsi:type="xsd:string"></Document:Value>
    <Document:AdditionalInfo xsi:type="xsd:string"></Document:AdditionalInfo>
   </Document:Response>
  </Document:UndoCheckoutDocumentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

