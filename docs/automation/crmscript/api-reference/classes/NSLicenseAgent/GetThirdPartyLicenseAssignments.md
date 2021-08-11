---
uid: crmscript_ref_NSLicenseAgent_GetThirdPartyLicenseAssignments
title: NSModuleLicenseLink[] GetThirdPartyLicenseAssignments(Integer associateId, String moduleOwner)
intellisense: NSLicenseAgent.GetThirdPartyLicenseAssignments
keywords: NSLicenseAgent, GetThirdPartyLicenseAssignments
so.topic: reference
---

# NSModuleLicenseLink[] GetThirdPartyLicenseAssignments(Integer associateId, String moduleOwner)

Get license assignments for an associate for licenses belonging to an other module owner than SuperOffice

**Parameters:**
 - **associateId** User to get third party license assignments for
 - **moduleOwner** Name of the module owner to get license assignments for

**Returns:** NSModuleLicenseLink[]

```crmscript
NSLicenseAgent agent;
Integer associateId;
String moduleOwner;
NSModuleLicenseLink[] res = agent.GetThirdPartyLicenseAssignments(associateId, moduleOwner);
```

