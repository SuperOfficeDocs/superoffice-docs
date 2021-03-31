---
title: crmscript_ref_NSLicenseAgent_AddLicenseFromFile
description: ExtendedLicenseInfo AddLicenseFromFile(String fileContent)
intellisense: NSLicenseAgent.AddLicenseFromFile
keywords: NSLicenseAgent,AddLicenseFromFile
so.topic: reference
---

Load and activate a new license from file/string if the new license is valid.

**Parameters:**
 - **fileContent** Content of the license file as XML.

**Returns:** Activated license

```crmscript
NSLicenseAgent agent;
String fileContent;
ExtendedLicenseInfo res = agent.AddLicenseFromFile(fileContent);
```

