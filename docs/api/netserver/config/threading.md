---
title: Threading element
uid: ns_config_Threading
description: NetServer configuration values related to threading.
so.date: 12.07.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, Threading, DisableMultithreading, ForceMultithreading, MaxParellalThreads, single-threaded, multi-threaded, parallel
so.topic: reference
so.envir: onsite
---

# NetServer Threading element

Configuration values related to threading.

```XML
<Threading>
  <add key="MaxParellalThreads" value="30" />
  <add key="DisableMultithreading" value="false" />
  <add key="ForceMultithreading" value="false" />
</Threading>
```

| Name | Description | Default |
|---|---|---|
| DisableMultithreading | Determines whether NetServer should run in single-threaded mode. | false |
| ForceMultithreading | Determines whether NetServer should force multi-threaded mode. | false |
| MaxParellalThreads | Max parallel operations that are permitted to be run in parallel. -1 is infinite. | 30 |

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.Threading>
