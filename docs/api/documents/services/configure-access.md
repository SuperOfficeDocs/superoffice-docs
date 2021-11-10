---
title: Configuring document access
uid: config_document_services
description: How to configure document access
author: Tony Yates
so.date: 06.11.2008
keywords: document, API, services, document agent, SO_ARC, ArchivePath, TemporaryPath, ImpersonateUser
so.topic: howto
so.category: document
so.area: api-services
---

# Configuring document access

For the application to run properly, some modifications are required in the application configuration file.

```XML
<Documents>
  <!-- Location of SO_ARC -->
  <add key="ArchivePath" value="C:\\SO_ARC" />

  <!-- Location of the temporary folder for streaming files. 
    This path must resolve to the same location for farms/clusters. -->
  <add key="TemporaryPath" value="C:\\temp" />

  <!-- Impersonate user when accessing the document archive or the temporary folder -->
  <add key="ImpersonateUser" value="false" />
</Documents>
```

## ArchivePath

The `ArchivePath` specifies the physical location of the archive folder. This applies to the services/server-side.

## TemporaryPath

The `TemporaryPath` key should have the physical location for temporary files on the server. The service implementation will stream documents to this location before moving them to the archive-path for storage. Temporary files are created on the server at this path. This path is not client-specific. It has nothing to do with the temporary path on the temp file on the client.

## ImpersonateUser

Finally, specify the value of the `ImpersonateUser` key. Impersonation is for server-side file access and should be set to true in a scenario where SO_ARC is located on a remote server because the web-server user runs as a restricted local account that has no rights to access a file-share on a different server.

If the impersonation is set to true, the domain, user, and password values for a user that has access to SO_ARC and the temporary folder have to be provided.

In this example, we have set the impersonation false because this is a Windows application and the client runs the NetServer code in the same process, and the application inherits the user's identity.
