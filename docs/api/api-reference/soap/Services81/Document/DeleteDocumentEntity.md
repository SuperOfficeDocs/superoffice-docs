---
uid: services81-document-deletedocumententity
title: Services81.DocumentAgent.DeleteDocumentEntity SOAP
Generated: true
---

# Services81 Document DeleteDocumentEntity SOAP

SOAP request and response examples **Remote/Services81/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IDocumentAgent.DeleteDocumentEntity">SuperOffice.Services81.IDocumentAgent.DeleteDocumentEntity</see> method.

## DeleteDocumentEntity

Deletes the DocumentEntity

* **documentEntityId:** The identity of the DocumentEntity



[WSDL file for Services81/Document](../Services81-Document.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteDocumentEntity Request

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
   <Document:DeleteDocumentEntity>
    <Document:DocumentEntityId xsi:type="xsd:int">0</Document:DocumentEntityId>
   </Document:DeleteDocumentEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteDocumentEntity Response

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
  <Document:DeleteDocumentEntityResponse>
  </Document:DeleteDocumentEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

