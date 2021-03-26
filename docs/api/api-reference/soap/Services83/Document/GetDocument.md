---
uid: services83-document-getdocument
title: Services83.DocumentAgent.GetDocument SOAP
Generated: true
---

# Services83 Document GetDocument SOAP

SOAP request and response examples **Remote/Services83/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IDocumentAgent.GetDocument">SuperOffice.Services83.IDocumentAgent.GetDocument</see> method.

## GetDocument

Gets a Document object.

* **documentId:** The identifier of the Document object

**Returns:** Document


[WSDL file for Services83/Document](../Services83-Document.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDocument Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:GetDocument>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
   </Document:GetDocument>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDocument Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Document:GetDocumentResponse>
   <Document:Response xsi:type="Document:Document">
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
    <Document:Attention xsi:type="xsd:string"></Document:Attention>
    <Document:Header xsi:type="xsd:string"></Document:Header>
    <Document:Name xsi:type="xsd:string"></Document:Name>
    <Document:OurRef xsi:type="xsd:string"></Document:OurRef>
    <Document:YourRef xsi:type="xsd:string"></Document:YourRef>
    <Document:Description xsi:type="xsd:string"></Document:Description>
    <Document:DocumentTemplate xsi:type="xsd:string"></Document:DocumentTemplate>
    <Document:IsPublished xsi:type="xsd:boolean">false</Document:IsPublished>
    <Document:PersonId xsi:type="xsd:int">0</Document:PersonId>
    <Document:PersonFullName xsi:type="xsd:string"></Document:PersonFullName>
    <Document:AssociateFullName xsi:type="xsd:string"></Document:AssociateFullName>
    <Document:ContactId xsi:type="xsd:int">0</Document:ContactId>
    <Document:ContactName xsi:type="xsd:string"></Document:ContactName>
    <Document:ProjectId xsi:type="xsd:int">0</Document:ProjectId>
    <Document:ProjectName xsi:type="xsd:string"></Document:ProjectName>
    <Document:AssociateId xsi:type="xsd:int">0</Document:AssociateId>
   </Document:Response>
  </Document:GetDocumentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

