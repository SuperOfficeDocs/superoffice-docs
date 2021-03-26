---
uid: services82-document-getversionlist
title: Services82.DocumentAgent.GetVersionList SOAP
Generated: true
---

# Services82 Document GetVersionList SOAP

SOAP request and response examples **Remote/Services82/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IDocumentAgent.GetVersionList">SuperOffice.Services82.IDocumentAgent.GetVersionList</see> method.

## GetVersionList

Get a list of existing, committed  versions for a given document

* **documentId:** SuperOffice document Id

**Returns:** Array of objects describing the existing, committed versions for this document


[WSDL file for Services82/Document](../Services82-Document.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetVersionList Request

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
   <Document:GetVersionList>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
   </Document:GetVersionList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetVersionList Response

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
  <Document:GetVersionListResponse>
   <Document:Response xsi:type="Document:ArrayOfVersionInfo">
    <Document:VersionInfo xsi:type="Document:VersionInfo">
     <Document:ExternalReference xsi:type="xsd:string"></Document:ExternalReference>
     <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
     <Document:VersionId xsi:type="xsd:string"></Document:VersionId>
     <Document:CheckedInDate xsi:type="xsd:dateTime">2021-03-25T21:34:45Z</Document:CheckedInDate>
     <Document:CheckedInByName xsi:type="xsd:string"></Document:CheckedInByName>
     <Document:CheckedInByAssociateId xsi:type="xsd:int">0</Document:CheckedInByAssociateId>
     <Document:Description xsi:type="xsd:string"></Document:Description>
     <Document:DisplayText xsi:type="xsd:string"></Document:DisplayText>
     <Document:ExtraFields xsi:type="NetServerServices822:ArrayOfstring">
      <NetServerServices822:string xsi:type="xsd:string"></NetServerServices822:string>
     </Document:ExtraFields>
    </Document:VersionInfo>
   </Document:Response>
  </Document:GetVersionListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

