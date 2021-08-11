---
uid: crmscript_ref_NSTicketMessageEntity_SetMailSorter
title: SetMailSorter(String mailSorter)
intellisense: NSTicketMessageEntity.SetMailSorter
keywords: NSTicketMessageEntity, GetMailSorter
so.topic: reference
---

# SetMailSorter(String mailSorter)

The name of the mail sorter used when the email was imported. Note: We must use name instead of id since the id&apos;s change every time one changes the mail sorter. :-0

**Parameter:** 
 - **mailSorter** String

```crmscript
NSTicketMessageEntity thing;
String mailSorter;
thing.SetMailSorter(mailSorter);
```

