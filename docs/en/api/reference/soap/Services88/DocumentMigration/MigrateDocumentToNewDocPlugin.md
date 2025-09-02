---
title: Services88.DocumentMigrationAgent.MigrateDocumentToNewDocPlugin SOAP
generated: true
uid: Services88-DocumentMigration-MigrateDocumentToNewDocPlugin
content_type: reference
---

# Services88 DocumentMigration MigrateDocumentToNewDocPlugin

SOAP request and response examples **Remote/Services88/DocumentMigration.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDocumentMigrationAgent.MigrateDocumentToNewDocPlugin">SuperOffice.Services88.IDocumentMigrationAgent.MigrateDocumentToNewDocPlugin</see> method.

## MigrateDocumentToNewDocPlugin





[WSDL file for Services88/DocumentMigration](../Services88-DocumentMigration.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## MigrateDocumentToNewDocPlugin Request

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
   <DocumentMigration:MigrateDocumentToNewDocPlugin>
    <DocumentMigration:DocumentId xsi:type="xsd:int">0</DocumentMigration:DocumentId>
    <DocumentMigration:DocumentPluginId xsi:type="xsd:int">0</DocumentMigration:DocumentPluginId>
   </DocumentMigration:MigrateDocumentToNewDocPlugin>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## MigrateDocumentToNewDocPlugin Response

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
  <DocumentMigration:MigrateDocumentToNewDocPluginResponse>
  </DocumentMigration:MigrateDocumentToNewDocPluginResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

