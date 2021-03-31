---
title: crmscript_ref_NSContactAgent_GetMyBizCard
description: ContactEntity GetMyBizCard()
intellisense: NSContactAgent.GetMyBizCard
keywords: NSContactAgent,GetMyBizCard
so.topic: reference
---

Returns all data needed to display the logged on person's business card. That is company, person, and company interest data.


**Returns:** The contact object with persons and interests

```crmscript
NSContactAgent agent;
ContactEntity res = agent.GetMyBizCard();
```

