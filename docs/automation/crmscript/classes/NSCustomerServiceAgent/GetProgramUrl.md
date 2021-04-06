---
uid: crmscript_ref_NSCustomerServiceAgent_GetProgramUrl
title: String GetProgramUrl(String programName, Bool external)
intellisense: NSCustomerServiceAgent.GetProgramUrl
keywords: NSCustomerServiceAgent, GetProgramUrl
so.topic: reference
---

This method will convert a module name into a Service URL.

**Parameters:**
 - **programName** In this parameter you must specify which CS program you want to create an URL for. Valid examples are "ticket", "rms", "spm" etc.
 - **external** If set to true, this will generate URLs that are accesible from the outside (for example Internet)

**Returns:** Returns a valid Service URL composed of the give parameters.

```crmscript
NSCustomerServiceAgent agent;
String programName;
Bool external;
String res = agent.GetProgramUrl(programName, external);
```

