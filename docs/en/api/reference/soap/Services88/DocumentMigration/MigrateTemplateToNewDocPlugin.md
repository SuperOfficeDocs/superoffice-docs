---
title: Services88.DocumentMigrationAgent.MigrateTemplateToNewDocPlugin SOAP
generated: true
uid: Services88-DocumentMigration-MigrateTemplateToNewDocPlugin
content_type: reference
---

# Services88 DocumentMigration MigrateTemplateToNewDocPlugin

SOAP request and response examples **Remote/Services88/DocumentMigration.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDocumentMigrationAgent.MigrateTemplateToNewDocPlugin">SuperOffice.Services88.IDocumentMigrationAgent.MigrateTemplateToNewDocPlugin</see> method.

## MigrateTemplateToNewDocPlugin





[WSDL file for Services88/DocumentMigration](../Services88-DocumentMigration.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## MigrateTemplateToNewDocPlugin Request

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
   <DocumentMigration:MigrateTemplateToNewDocPlugin>
    <DocumentMigration:DocumentTemplateId xsi:type="xsd:int">0</DocumentMigration:DocumentTemplateId>
    <DocumentMigration:TargetDocumentPluginId xsi:type="xsd:int">0</DocumentMigration:TargetDocumentPluginId>
   </DocumentMigration:MigrateTemplateToNewDocPlugin>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## MigrateTemplateToNewDocPlugin Response

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
  <DocumentMigration:MigrateTemplateToNewDocPluginResponse>
  </DocumentMigration:MigrateTemplateToNewDocPluginResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

