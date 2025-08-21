---
uid: api-services-document-access
title: Configuring document access
description: How to configure document access
keywords: document, API, services, document agent, SO_ARC, ArchivePath, TemporaryPath, ImpersonateUser
author: Tony Yates
date: 12.08.2021
version: 10
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
category: document
area: api-services
redirect_from:
  - /en/document/howto/services/configure-access
  - /en/api/netserver/web-services/howto/document/services-configure-access
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
[1]: ../../../config/documents.md

<!-- Referenced images -->
