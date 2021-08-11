---
uid: crmscript_ref_NSConfigurationAgent_GetCsProgramUrl
title: String GetCsProgramUrl(String language, String programName, String action, String extraParameters)
intellisense: NSConfigurationAgent.GetCsProgramUrl
keywords: NSConfigurationAgent, GetCsProgramUrl
so.topic: reference
---

# String GetCsProgramUrl(String language, String programName, String action, String extraParameters)

This method will convert a module name into a CS URL.

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
String res = agent.GetCsProgramUrl(language, programName, action, extraParameters);
```

