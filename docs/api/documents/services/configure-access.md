---
title: Configuring document access
uid: config_document_services
description: How to configure document access
author: Tony Yates
so.date: 12.08.2021
keywords: document, API, services, document agent, SO_ARC, ArchivePath, TemporaryPath, ImpersonateUser
so.topic: howto
so.category: document
so.area: api-services
---

# Configuring document access

For the application to run properly, some modifications are required in the application configuration file.

```XML
<Documents>
  <add key="ArchivePath" value="C:\\SO_ARC" />
  <add key="TemporaryPath" value="C:\\temp" />
  <add key="ImpersonateUser" value="false" />
</Documents>
```

In this example, we have set the impersonation false because this is a Windows application and the client runs the NetServer code in the same process, and the application inherits the user's identity.

Read more about these settings in the [NetServer configuration][1].

<!-- Referenced links -->
[1]: ../../netserver/config/documents.md

<!-- Referenced images -->
