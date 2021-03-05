---
title: com_interop_dotnet
description: COM interop and .net
author: Tony Yates
so.date: 06.24.2016
keywords: COM
so.topic: concept
so.client: web
so.envir: onsite
---

# COM interop and .Net

There are thick books written about COM interop from .Net. The most important tip when working with COM objects is that **the COM object lives until the .Net wrapper object is destroyed**. The .Net wrapper objects are garbage collected when the .Net runtime is not busy doing other things. In other words, you may be finished with an object, but the wrapper is not finalized yet, so the COM object is still alive, invisible but still alive.

This is usually not a big deal until the object in question represents a running application that is locking a file you want to open. That's when the cursing starts. The trick is to force the garbage collector to run:

```vb
Dim outlook As Object
outlook = GetOutlook()
' do stuff with outlook
outlook = Nothing
' force Garbage to collect and clean up COM object
' otherwise, the OUTLOOK.EXE process hangs around for 2 minutes
GC.Collect()
GC.WaitForPendingFinalizers()
```
