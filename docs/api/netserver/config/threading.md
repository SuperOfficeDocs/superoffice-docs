---
title: Threading element
uid: ns_config_Threading
description: NetServer Threading element
so.date: 06.06.2018
author: {github-id}
keywords: config
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

| Name | Description |
|---|---|
| MaxParellalThreads | Max parallel operations that are permitted to be run in parallel. -1 is infinite.<br>Default: 30 |
| DisableMultithreading | Determines whether NetServer should run in single-threaded mode.<br>Default: false |
| ForceMultithreading | Determines whether NetServer should force multi-threaded mode.<br>Default: false |
