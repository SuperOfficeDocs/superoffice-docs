---
title: Onsite debugging
uid: onsite_debug
description: Debugging onsite
so.date: 12.08.2021
author: Bergfrid Dias
keywords: config, web.config, diagnostics, log
so.topic: concept
so.envir: onsite
---

# Debug

## NetServer diagnostics

You can turn on and off logging for NetServer directly in [Diagnostics section][3] of the *Web.config* file.

When you use SuperOffice Win, the Scaffolding option is not in the *SuperOffice.config* file at all.

If asked for even more extended logging, you may turn this on by adding:

```xml
<add key="EnableScaffolding" value="true" />
```

> [!NOTE]
> Remember to turn the logging off when it is not needed, as extended logging in NetServer will reduce performance.

<!-- Referenced links -->
[3]: ../config/web-config.md
