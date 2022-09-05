---
title: Services88.DocumentMigrationAgent.CreateDefaultDocumentTemplateMigrationList SOAP
generated: 1
uid: Services88-DocumentMigration-CreateDefaultDocumentTemplateMigrationList
---

# Services88 DocumentMigration CreateDefaultDocumentTemplateMigrationList

SOAP request and response examples **Remote/Services88/DocumentMigration.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDocumentMigrationAgent.CreateDefaultDocumentTemplateMigrationList">SuperOffice.Services88.IDocumentMigrationAgent.CreateDefaultDocumentTemplateMigrationList</see> method.

## CreateDefaultDocumentTemplateMigrationList

Loading default values into a new DocumentTemplateMigrationList.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
<para /><b>Online Restricted:</b> The DocumentMigration agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for SuperOffice-internal apps.


**Returns:** New DocumentTemplateMigrationList with default values


[WSDL file for Services88/DocumentMigration](../Services88-DocumentMigration.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultDocumentTemplateMigrationList Request

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
   <DocumentMigration:CreateDefaultDocumentTemplateMigrationList>
   </DocumentMigration:CreateDefaultDocumentTemplateMigrationList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultDocumentTemplateMigrationList Response

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
  <DocumentMigration:CreateDefaultDocumentTemplateMigrationListResponse>
   <DocumentMigration:Response xsi:type="DocumentMigration:DocumentTemplateMigrationList">
    <DocumentMigration:NumTemplatesOmitted xsi:type="xsd:int">0</DocumentMigration:NumTemplatesOmitted>
    <DocumentMigration:NumTemplatesAlreadyMigrated xsi:type="xsd:int">0</DocumentMigration:NumTemplatesAlreadyMigrated>
    <DocumentMigration:TemplateIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </DocumentMigration:TemplateIds>
   </DocumentMigration:Response>
  </DocumentMigration:CreateDefaultDocumentTemplateMigrationListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

