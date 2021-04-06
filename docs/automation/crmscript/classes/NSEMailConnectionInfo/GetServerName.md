---
uid: crmscript_ref_NSEMailConnectionInfo_GetServerName
title: String GetServerName()
intellisense: NSEMailConnectionInfo.GetServerName
keywords: NSEMailConnectionInfo, GetServerName
so.topic: reference
---

Hostname or ip to server to connect to. Custom ports may be specified by adding ':' and the port number after the name/ip. Ex: '127.0.0.1:6543'

**Returns:** String


```crmscript
NSEMailConnectionInfo thing;
String serverName  = thing.GetServerName();
```


