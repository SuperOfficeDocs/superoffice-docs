---
title: Logging
uid: mah_logging
description: MailArchiveHelper logging
author: Tony Yates
so.date: 06.24.2016
keywords: log
so.topic: concept
so.client: web
so.envir: onsite
---

# Logging

Logging is done using the `Util.LogDebugInfo` method.

```csharp
using SuperOffice.Mail;

Util.LogDebugInfo("Setting something up");
// work work work
Util.LogDebugInfo("finished...");
```

This method checks the **EnableDebugInfo** preference in the registry. The key is determined by the `RegKeyName` property. This is usually set for you, but you may need to manually set it if you are not using the `MailArchiveHelper`.

The log file is always named *SuperOffice.Mail.ArchiveHelper.log* and it is always placed in the folder *user-profile\AppData\SuperOffice*. The location of *AppData* varies depending on the Windows version.
