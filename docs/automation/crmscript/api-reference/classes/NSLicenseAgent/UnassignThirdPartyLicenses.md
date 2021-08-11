---
uid: crmscript_ref_NSLicenseAgent_UnassignThirdPartyLicenses
title: NSModuleLicenseLink[] UnassignThirdPartyLicenses(Integer associateId, String moduleOwner, String[] moduleLicenseNames)
intellisense: NSLicenseAgent.UnassignThirdPartyLicenses
keywords: NSLicenseAgent, UnassignThirdPartyLicenses
so.topic: reference
---

# NSModuleLicenseLink[] UnassignThirdPartyLicenses(Integer associateId, String moduleOwner, String[] moduleLicenseNames)

Unassign (remove) third party licenses

**Parameters:**
 - **associateId** User to unassign third party licenses for
 - **moduleOwner** Name of the module owner to unassign license for
 - **moduleLicenseNames** Name of module licenses to unassign (remove)

**Returns:** NSModuleLicenseLink[]

```crmscript
NSLicenseAgent agent;
Integer associateId;
String moduleOwner;
String[] moduleLicenseNames;
NSModuleLicenseLink[] res = agent.UnassignThirdPartyLicenses(associateId, moduleOwner, moduleLicenseNames);
```

