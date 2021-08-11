---
uid: crmscript_ref_NSQuoteVersionStatusInformation_GetDisplayMessage
title: String GetDisplayMessage()
intellisense: NSQuoteVersionStatusInformation.GetDisplayMessage
keywords: NSQuoteVersionStatusInformation, GetDisplayMessage
so.topic: reference
---

# String GetDisplayMessage()

Generated error message for the Quote Version. Will check for errors on quote lines, alternatives and the version itself.

**Returns:** String

```crmscript
NSQuoteVersionStatusInformation thing;
String displayMessage  = thing.GetDisplayMessage();
```

