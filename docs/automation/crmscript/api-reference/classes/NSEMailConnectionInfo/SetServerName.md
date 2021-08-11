---
uid: crmscript_ref_NSEMailConnectionInfo_SetServerName
title: SetServerName(String serverName)
intellisense: NSEMailConnectionInfo.SetServerName
keywords: NSEMailConnectionInfo, GetServerName
so.topic: reference
---

# SetServerName(String serverName)

Hostname or ip to server to connect to. Custom ports may be specified by adding ':' and the port number after the name/ip. Ex: '127.0.0.1:6543'

**Parameter:** 
 - **serverName** String

```crmscript
NSEMailConnectionInfo thing;
String serverName;
thing.SetServerName(serverName);
```

