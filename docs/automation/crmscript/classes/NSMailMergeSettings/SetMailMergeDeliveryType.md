---
uid: crmscript_ref_NSMailMergeSettings_SetMailMergeDeliveryType
title: SetMailMergeDeliveryType(Integer mailMergeDeliveryType)
intellisense: NSMailMergeSettings.SetMailMergeDeliveryType
keywords: NSMailMergeSettings, GetMailMergeDeliveryType
so.topic: reference
---

How the merged document is delivered to the recipients.

**Parameter:** 
 - **mailMergeDeliveryType** Integer
     - Enum: 0 = BestFit 
     - Enum: 1 = Electronic 
     - Enum: 2 = Mail 
     - Enum: 3 = Fax 
     - Enum: 4 = Printer 
     - Enum: 5 = Xml 
     - Enum: 6 = XmlFax 

```crmscript
NSMailMergeSettings thing;
Integer mailMergeDeliveryType;
thing.SetMailMergeDeliveryType(mailMergeDeliveryType);
```

