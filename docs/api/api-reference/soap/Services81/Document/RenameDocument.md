---
uid: services81-document-renamedocument
title: Services81.DocumentAgent.RenameDocument SOAP
Generated: true
---

# Services81 Document RenameDocument SOAP

SOAP request and response examples **Remote/Services81/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IDocumentAgent.RenameDocument">SuperOffice.Services81.IDocumentAgent.RenameDocument</see> method.

## RenameDocument

Rename the physical document, i.e., change the file name or equivalent concept in the document archive.

* **documentId:** SuperOffice document ID
* **newFilename:** Suggested new file name. The document archive may amend this to conform to uniqueness constraints, character range limitations etc.

**Returns:** The actual, new "file" name. This will generally be derived from the suggested name, but may be amended.


[WSDL file for Services81/Document](../Services81-Document.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RenameDocument Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:RenameDocument>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
    <Document:NewFilename xsi:type="xsd:string"></Document:NewFilename>
   </Document:RenameDocument>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RenameDocument Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Document:RenameDocumentResponse>
   <Document:Response xsi:type="xsd:string"></Document:Response>
  </Document:RenameDocumentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

