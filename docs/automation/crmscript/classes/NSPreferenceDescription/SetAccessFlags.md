---
uid: crmscript_ref_NSPreferenceDescription_SetAccessFlags
title: SetAccessFlags(Integer accessFlags)
intellisense: NSPreferenceDescription.SetAccessFlags
keywords: NSPreferenceDescription, GetAccessFlags
so.topic: reference
---

1=wizard mode, 2=level 0, 4=admin gui, 8=crm gui

**Parameter:** 
 - **accessFlags** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = WizardMode 
     - Enum: 2 = Level0 
     - Enum: 4 = adminGUI 
     - Enum: 8 = CRMGUI 

```crmscript
NSPreferenceDescription thing;
Integer accessFlags;
thing.SetAccessFlags(accessFlags);
```

