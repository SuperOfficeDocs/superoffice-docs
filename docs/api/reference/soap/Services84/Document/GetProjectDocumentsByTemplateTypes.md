---
title: Services84.DocumentAgent.GetProjectDocumentsByTemplateTypes SOAP
generated: 1
uid: Services84-Document-GetProjectDocumentsByTemplateTypes
---

# Services84 Document GetProjectDocumentsByTemplateTypes

SOAP request and response examples **Remote/Services84/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IDocumentAgent.GetProjectDocumentsByTemplateTypes">SuperOffice.Services84.IDocumentAgent.GetProjectDocumentsByTemplateTypes</see> method.

## GetProjectDocumentsByTemplateTypes

Method that returns a specified number of document appointments within a time range, filtered by document template types. The document appointments belong to the project specified.

* **projectId:** The project id
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **documentTemplateIds:** Ids of the document template types to filter on.

**Returns:** Array of Appointments.

[WSDL file for Services84/Document](../Services84-Document.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProjectDocumentsByTemplateTypes Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:GetProjectDocumentsByTemplateTypes>
    <Document:ProjectId xsi:type="xsd:int">0</Document:ProjectId>
    <Document:StartTime xsi:type="xsd:dateTime">2021-11-30T13:22:09Z</Document:StartTime>
    <Document:EndTime xsi:type="xsd:dateTime">2021-11-30T13:22:09Z</Document:EndTime>
    <Document:Count xsi:type="xsd:int">0</Document:Count>
    <Document:DocumentTemplateIds xsi:type="NetServerServices842:ArrayOfint">
     <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
    </Document:DocumentTemplateIds>
   </Document:GetProjectDocumentsByTemplateTypes>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetProjectDocumentsByTemplateTypes Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Document:GetProjectDocumentsByTemplateTypesResponse>
   <Document:Response xsi:type="Document:ArrayOfDocument">
    <Document:Document xsi:type="Document:Document">
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
    </Document:Document>
   </Document:Response>
  </Document:GetProjectDocumentsByTemplateTypesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
