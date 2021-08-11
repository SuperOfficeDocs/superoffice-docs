---
uid: crmscript_ref_NSSentiment_GetConfidence
title: Integer GetConfidence()
intellisense: NSSentiment.GetConfidence
keywords: NSSentiment, GetConfidence
so.topic: reference
---

# Integer GetConfidence()

Sentiment analysis confidence, where available. 0 = no idea, 100 = perfectly confident, -1 = no confidence score available

**Returns:** Integer

```crmscript
NSSentiment thing;
Integer confidence  = thing.GetConfidence();
```

