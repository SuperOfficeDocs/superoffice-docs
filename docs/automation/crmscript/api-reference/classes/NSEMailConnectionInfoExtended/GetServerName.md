---
uid: crmscript_ref_NSEMailConnectionInfoExtended_GetServerName
title: String GetServerName()
intellisense: NSEMailConnectionInfoExtended.GetServerName
keywords: NSEMailConnectionInfoExtended, GetServerName
so.topic: reference
---

# String GetServerName()

Hostname or ip to server to connect to. Custom ports may be specified by adding ':' and the port number after the name/ip. Ex: '127.0.0.1:6543'

**Returns:** String

```crmscript
NSEMailConnectionInfoExtended thing;
String serverName  = thing.GetServerName();
```

