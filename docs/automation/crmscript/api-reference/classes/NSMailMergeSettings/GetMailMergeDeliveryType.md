---
uid: crmscript_ref_NSMailMergeSettings_GetMailMergeDeliveryType
title: Integer GetMailMergeDeliveryType()
intellisense: NSMailMergeSettings.GetMailMergeDeliveryType
keywords: NSMailMergeSettings, GetMailMergeDeliveryType
so.topic: reference
---

# Integer GetMailMergeDeliveryType()

How the merged document is delivered to the recipients.

**Returns:** Integer

     - Enum: 0 = BestFit 
     - Enum: 1 = Electronic 
     - Enum: 2 = Mail 
     - Enum: 3 = Fax 
     - Enum: 4 = Printer 
     - Enum: 5 = Xml 
     - Enum: 6 = XmlFax 

```crmscript
NSMailMergeSettings thing;
Integer mailMergeDeliveryType  = thing.GetMailMergeDeliveryType();
```

