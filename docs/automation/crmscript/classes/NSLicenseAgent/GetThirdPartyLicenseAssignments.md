---
title: crmscript_ref_NSLicenseAgent_GetThirdPartyLicenseAssignments
description: ModuleLicenseLinkArray GetThirdPartyLicenseAssignments(Integer associateId, String moduleOwner)
intellisense: NSLicenseAgent.GetThirdPartyLicenseAssignments
keywords: NSLicenseAgent,GetThirdPartyLicenseAssignments
so.topic: reference
---

Get license assignments for an associate for licenses belonging to an other module owner than SuperOffice

**Parameters:**
 - **associateId** User to get third party license assignments for
 - **moduleOwner** Name of the module owner to get license assignments for

**Returns:** Module license names

```crmscript
NSLicenseAgent agent;
Integer associateId;
String moduleOwner;
ModuleLicenseLinkArray res = agent.GetThirdPartyLicenseAssignments(associateId, moduleOwner);
```

