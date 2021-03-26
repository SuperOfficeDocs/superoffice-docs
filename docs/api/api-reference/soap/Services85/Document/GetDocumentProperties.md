---
uid: services85-document-getdocumentproperties
title: Services85.DocumentAgent.GetDocumentProperties SOAP
Generated: true
---

# Services85 Document GetDocumentProperties SOAP

SOAP request and response examples **Remote/Services85/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IDocumentAgent.GetDocumentProperties">SuperOffice.Services85.IDocumentAgent.GetDocumentProperties</see> method.

## GetDocumentProperties

Get plugin-dependent properties for the document. A number of standard properties that should be supported by all plugins are defined in SuperOffice.CRM.Documents.Constants.Properties.

* **documentId:** SuperOffice document ID
* **requestedProperties:** Array of property names whose values are being requested.

**Returns:** Dictionary of name=value pairs, corresponding to the requested properties.


[WSDL file for Services85/Document](../Services85-Document.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDocumentProperties Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:GetDocumentProperties>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
    <Document:RequestedProperties xsi:type="NetServerServices852:ArrayOfstring">
     <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
    </Document:RequestedProperties>
   </Document:GetDocumentProperties>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDocumentProperties Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Document:GetDocumentPropertiesResponse>
   <Document:Response xsi:type="Document:StringDictionary">
    <Document:StringKeyValuePair>
     <Document:Key xsi:type="xsd:string"></Document:Key>
     <Document:Value xsi:type="xsd:string"></Document:Value>
    </Document:StringKeyValuePair>
   </Document:Response>
  </Document:GetDocumentPropertiesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

