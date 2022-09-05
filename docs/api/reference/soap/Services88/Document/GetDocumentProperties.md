---
title: Services88.DocumentAgent.GetDocumentProperties SOAP
generated: 1
uid: Services88-Document-GetDocumentProperties
---

# Services88 Document GetDocumentProperties

SOAP request and response examples **Remote/Services88/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDocumentAgent.GetDocumentProperties">SuperOffice.Services88.IDocumentAgent.GetDocumentProperties</see> method.

## GetDocumentProperties

Get plugin-dependent properties for the document. A number of standard properties that should be supported by all plugins are defined in SuperOffice.CRM.Documents.Constants.Properties.

* **documentId:** SuperOffice document ID
* **requestedProperties:** Array of property names whose values are being requested.

**Returns:** Dictionary of name=value pairs, corresponding to the requested properties.


[WSDL file for Services88/Document](../Services88-Document.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDocumentProperties Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:GetDocumentProperties>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
    <Document:RequestedProperties xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services88">
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

