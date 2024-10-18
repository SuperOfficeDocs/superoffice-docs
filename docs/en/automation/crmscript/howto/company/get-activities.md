---
uid: crmscript-get-company-activities
title: Activities
description: How to work with activities in CRMScript.
keywords: CRMScript, company, NSContactAgent
author: Bergfrid Skaara Dias
date: 02.21.2022
version: 10
topic: howto
---

# Activities

You can also use [NSContactAgent][4] to check what's going on.

## GetMyActiveContacts

Here we get all activities that happened the last week for companies tied to the currently signed-in user.

You can filter by category and action type.

> [!TIP]
> Set the start time to a future date to get all activities since the last sign-in.

```crmscript!
NSContactAgent contactAgent;

DateTime start;
Integer[] categories; // ignore filter

NSContactActivity[] activities = contactAgent.GetMyActiveContacts(start.addDay(-7), categories, 63);

for (Integer i = 0; i < activities.length(); i++) {
  NSContactActivity a = activities[i];
  printLine("At " + a.GetActionTime().toString() + ", " + a.GetActivityPersonName() + " did something to " + a.GetName());
}
```

## NSContactSummary GetContactSummary(Integer contactId, Integer limit)

Get a summary of a company's recent activity.

```crmscript!
Integer contactId = 2;
NSContactAgent agent;

NSContactSummary summary = agent.GetContactSummary(contactId, -1);

NSActivitySummaryItem[] followups = summary.GetFollowups();

for (Integer i = 0; i < followups.length(); i++) {
  printLine(followups[i].GetDate().toString());
}
```

> [!TIP]
> You can explore other collections in the activity summary too.

## Action types

| Value | Description |
|:---:|:---|
| 1  | created |
| 2  | updated |
| 4  | new activity |
| 8  | activity completed |
| 16 | person added |
| 32 | person updated |

> [!TIP]
> To request more than one action type, summarize the values. **63** means **include all**.

<!-- Referenced links -->
[4]: ../../netserver/ns-agents-and-carriers.md
