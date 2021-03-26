---
uid: services80-document-getpublisheddocument
title: Services80.DocumentAgent.GetPublishedDocument SOAP
Generated: true
---

# Services80 Document GetPublishedDocument SOAP

SOAP request and response examples **Remote/Services80/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IDocumentAgent.GetPublishedDocument">SuperOffice.Services80.IDocumentAgent.GetPublishedDocument</see> method.

## GetPublishedDocument

Get the document if it's published

* **documentId:** The document id

**Returns:** Document


[WSDL file for Services80/Document](../Services80-Document.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPublishedDocument Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:GetPublishedDocument>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
   </Document:GetPublishedDocument>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPublishedDocument Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Document:GetPublishedDocumentResponse>
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
  </Document:GetPublishedDocumentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

