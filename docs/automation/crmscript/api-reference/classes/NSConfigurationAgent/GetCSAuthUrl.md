---
uid: crmscript_ref_NSConfigurationAgent_GetCSAuthUrl
title: String GetCSAuthUrl(String language, String programName, String action, String extraParameters)
intellisense: NSConfigurationAgent.GetCSAuthUrl
keywords: NSConfigurationAgent, GetCSAuthUrl
so.topic: reference
---

Will generate an url to the emarketing module

**Parameters:**
 - **language** By setting this parameter, you can change the CS language for the current user.
 - **programName** In this parameter you must specify which CS program you want to create an URL for. Valid examples are "ticket", "rms", "spm" etc.
 - **action** Here you can optionally specify the action for the current program. This will enable you to go to a specific screen.
 - **extraParameters** If an action is specified, you can specify extra parameters here. This can be used to set specific behaviour for the chosen screen/action. If an empty action is supplied, this parameter will be ignored.

**Returns:** String

```crmscript
NSConfigurationAgent agent;
String language;
String programName;
String action;
String extraParameters;
String res = agent.GetCSAuthUrl(language, programName, action, extraParameters);
```

