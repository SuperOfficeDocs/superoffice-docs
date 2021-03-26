---
uid: services88-document-getprojectmemberdocumentsbytemplateheading
title: Services88.DocumentAgent.GetProjectMemberDocumentsByTemplateHeading SOAP
Generated: true
---

# Services88 Document GetProjectMemberDocumentsByTemplateHeading SOAP

SOAP request and response examples **Remote/Services88/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDocumentAgent.GetProjectMemberDocumentsByTemplateHeading">SuperOffice.Services88.IDocumentAgent.GetProjectMemberDocumentsByTemplateHeading</see> method.

## GetProjectMemberDocumentsByTemplateHeading

Method that returns a specified number of document appointments within a time range, filtered by document template heading. The document appointments belong to the project member specified. The heading represents a grouping or filtering of document templates.

* **personId:** The project member's person id
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **templateHeadingId:** The document template heading id. The heading represents a grouping or filtering of document templates.

**Returns:** Array of Appointments.


[WSDL file for Services88/Document](../Services88-Document.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProjectMemberDocumentsByTemplateHeading Request

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
   <Document:GetProjectMemberDocumentsByTemplateHeading>
    <Document:PersonId xsi:type="xsd:int">0</Document:PersonId>
    <Document:StartTime xsi:type="xsd:dateTime">2021-03-25T21:36:56Z</Document:StartTime>
    <Document:EndTime xsi:type="xsd:dateTime">2021-03-25T21:36:56Z</Document:EndTime>
    <Document:Count xsi:type="xsd:int">0</Document:Count>
    <Document:TemplateHeadingId xsi:type="xsd:int">0</Document:TemplateHeadingId>
   </Document:GetProjectMemberDocumentsByTemplateHeading>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetProjectMemberDocumentsByTemplateHeading Response

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
  <Document:GetProjectMemberDocumentsByTemplateHeadingResponse>
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
     <Document:Snum xsi:type="xsd:int">0</Document:Snum>
    </Document:Document>
   </Document:Response>
  </Document:GetProjectMemberDocumentsByTemplateHeadingResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

