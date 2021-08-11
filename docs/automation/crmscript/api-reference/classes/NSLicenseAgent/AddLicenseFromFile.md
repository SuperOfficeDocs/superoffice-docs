---
uid: crmscript_ref_NSLicenseAgent_AddLicenseFromFile
title: NSExtendedLicenseInfo AddLicenseFromFile(String fileContent)
intellisense: NSLicenseAgent.AddLicenseFromFile
keywords: NSLicenseAgent, AddLicenseFromFile
so.topic: reference
---

# NSExtendedLicenseInfo AddLicenseFromFile(String fileContent)

Load and activate a new license from file/string if the new license is valid.

**Parameters:**
 - **fileContent** Content of the license file as XML.

**Returns:** NSExtendedLicenseInfo

```crmscript
NSLicenseAgent agent;
String fileContent;
NSExtendedLicenseInfo res = agent.AddLicenseFromFile(fileContent);
```

