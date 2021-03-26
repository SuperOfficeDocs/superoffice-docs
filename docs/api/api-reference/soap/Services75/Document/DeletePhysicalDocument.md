---
uid: services75-document-deletephysicaldocument
title: Services75.DocumentAgent.DeletePhysicalDocument SOAP
Generated: true
---

# Services75 Document DeletePhysicalDocument SOAP

SOAP request and response examples **Remote/Services75/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IDocumentAgent.DeletePhysicalDocument">SuperOffice.Services75.IDocumentAgent.DeletePhysicalDocument</see> method.

## DeletePhysicalDocument



* **documentId:** 
* **allowedReturnType:** 



[WSDL file for Services75/Document](../Services75-Document.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeletePhysicalDocument Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:DeletePhysicalDocument>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
    <Document:AllowedReturnType xsi:type="NetServerServices752:ArrayOfstring">
     <NetServerServices752:string xsi:type="xsd:string"></NetServerServices752:string>
    </Document:AllowedReturnType>
   </Document:DeletePhysicalDocument>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeletePhysicalDocument Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Document:DeletePhysicalDocumentResponse>
   <Document:Response xsi:type="Document:ReturnInfo">
    <Document:ExternalReference xsi:type="xsd:string"></Document:ExternalReference>
    <Document:VersionId xsi:type="xsd:string"></Document:VersionId>
    <Document:Success xsi:type="xsd:boolean">false</Document:Success>
    <Document:Type xsi:type="Document:ReturnType">None</Document:Type>
    <Document:Value xsi:type="xsd:string"></Document:Value>
    <Document:AdditionalInfo xsi:type="xsd:string"></Document:AdditionalInfo>
   </Document:Response>
  </Document:DeletePhysicalDocumentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

