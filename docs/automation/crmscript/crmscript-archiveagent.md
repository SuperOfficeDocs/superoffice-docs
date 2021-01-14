---
title: crmscript_archiveagent
description: Archive agent
author:
so.date:
keywords:
so.topic:
---

# Archive agent

## Get NSArchiveListItem

This example uses the **ContactActivity** archive provider to retrieve [appointments][1].

```crmscript!
String[] columns;
columns.pushBack("text");

NSArchiveOrderByInfo[] sortOrder;

NSArchiveRestrictionInfo[] restrictions;
NSArchiveRestrictionInfo selectAll;
selectAll.SetName("getAllRows");
restrictions.pushBack(selectAll);

String[] entities;
entities.pushBack("appointment");

NSArchiveAgent agent;
NSArchiveListItem[] result = agent.GetArchiveListByColumns("ContactActivity", columns, sortOrder, restrictions, entities, 0, 100);

foreach (NSArchiveListItem i in result) {
  Map col = i.GetColumnData();
  col.first();
  while (!col.eof()) {
    print(col.getKey() + ": " + col.getVal() + "\n");
    col.next();
  }
}
```

<!-- Referenced links -->
[1]: follow-ups/appointment.md
