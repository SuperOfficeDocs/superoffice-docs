---
title: Services88.DocumentMigrationAgent.GetForTemplates SOAP
generated: true
uid: Services88-DocumentMigration-GetForTemplates
content_type: reference
---

# Services88 DocumentMigration GetForTemplates

SOAP request and response examples **Remote/Services88/DocumentMigration.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDocumentMigrationAgent.GetForTemplates">SuperOffice.Services88.IDocumentMigrationAgent.GetForTemplates</see> method.

## GetForTemplates





[WSDL file for Services88/DocumentMigration](../Services88-DocumentMigration.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetForTemplates Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:DocumentMigration="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <DocumentMigration:ApplicationToken>1234567-1234-9876</DocumentMigration:ApplicationToken>
  <DocumentMigration:Credentials>
    <DocumentMigration:Ticket>7T:1234abcxyzExample==</DocumentMigration:Ticket>
  </DocumentMigration:Credentials>
 <SOAP-ENV:Body>
   <DocumentMigration:GetForTemplates>
    <DocumentMigration:TargetDocumentPluginId xsi:type="xsd:int">0</DocumentMigration:TargetDocumentPluginId>
    <DocumentMigration:IncludeEmails xsi:type="xsd:boolean">false</DocumentMigration:IncludeEmails>
   </DocumentMigration:GetForTemplates>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetForTemplates Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:DocumentMigration="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <DocumentMigration:GetForTemplatesResponse>
   <DocumentMigration:Response xsi:type="DocumentMigration:DocumentTemplateMigrationList">
    <DocumentMigration:NumTemplatesOmitted xsi:type="xsd:int">0</DocumentMigration:NumTemplatesOmitted>
    <DocumentMigration:NumTemplatesAlreadyMigrated xsi:type="xsd:int">0</DocumentMigration:NumTemplatesAlreadyMigrated>
    <DocumentMigration:TemplateIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </DocumentMigration:TemplateIds>
   </DocumentMigration:Response>
  </DocumentMigration:GetForTemplatesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

