---
title: Documents element
uid: ns_config_documents
description: NetServer configuration used to access the SuperOffice documents.
so.date: 12.07.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, Documents, ArchiveDomain, ArchivePath, ArchivePassword, ArchiveUser, BufferSize, CanCreateDocumentTemplates, ImpersonateUser, TemplatePath, TemporaryPath, SO_ARC
so.topic: reference
so.envir: onsite
---

# NetServer Documents element

This configuration is used to access the SuperOffice documents. It is used by NetServer to identify which document archive and temporary directory are used.

To restrict access to the document archive, specify domain credentials with read and write access to the archive for NetServer to impersonate.

```XML
<Documents>
  <add key="ArchivePath" value="c:\so_arc\" />
  <add key="TemporaryPath" value="c:\temp\" />
  <add key="ImpersonateUser" value="false" />
  <add key="ArchiveUser" value="" />
  <add key="ArchivePassword" value="" />
  <add key="ArchiveDomain" value="" />
  <add key="BufferSize" value="1024" />
</Documents>
```

| Name | Description | Default |
|---|---|---|
| ArchiveDomain | Domain of the user to impersonate. | |
| ArchivePath | Path of SO_ARC. Even if SO_ARC is not used, the default path for the document template folder is calculated from this folder. | |
| ArchivePath1 - ArchivePath10 | Alternative/additional archive path to search for documents | |
| ArchivePassword | Password of the user to impersonate. | |
| ArchiveUser | Username of the user to impersonate. | |
| BufferSize | Size in kilobytes of the internal buffer used for file handling. | 1024 |
| CanCreateDocumentTemplates | New document templates can be stored in SoArc. | |
| ImpersonateUser | Impersonate the user to access the document archive? If SO_ARC is located on a different server in the domain, you need to turn this on. Will also be used to write file streams to the temp area. See section ArchiveUser for further reference. | |
| TemplatePath | The UNC path to document templates. If this value is not specified, the "Template" folder under ArchivePath is assumed. | |
| TemporaryPath | Temporary folder for working with documents. If this value does not exist, the environment variable "TEMP" is used to find the temporary folder. Must resolve to the same location for farms/clusters. | |

## ArchivePath

The `ArchivePath` specifies the physical location of the archive folder. This applies to the services/server-side.

You can have more than one ArchivePath in your Web installation.

```xml
<Documents>
  <add key="ArchivePath" value="E:\SuperOffice\SO_ARC" />
  <add key="ArchivePath2" value="E:\SuperOffice\SO_ARC2" />
```

You can add more alternative archive paths, like ArchivePath3, ArchivePath4,...

## TemporaryPath

The `TemporaryPath` key should have the physical location for temporary files on the server. The service implementation will stream documents to this location before moving them to the archive-path for storage. Temporary files are created on the server at this path.

This path is not client-specific. It has nothing to do with the temporary path on the temp file on the client.

## ImpersonateUser

Impersonation is for server-side file access and should be set to true in a scenario where SO_ARC is located on a remote server because the web-server user runs as a restricted local account that has no rights to access a file-share on a different server.

If the impersonation is set to true, the domain, user, and password values for a user that has access to SO_ARC and the temporary folder have to be provided.

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.Documents>
