---
uid: crmscript_archiveagent
title: Archive agent
author:
date:
keywords:
topic:
---

# Archive agent

## Get NSArchiveListItem

These examples uses the **ContactActivity** archive provider to retrieve [appointments][1].

```crmscript!

/*
Using archive provider with using ArchiveRestrictionInfo to represent search terms
*/

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

```crmscript!
/*
Using archive provider with using String to represent search terms
*/

NSArchiveAgent agent;
NSArchiveListItem[] result = agent.GetArchiveListByColumns2("ContactActivity", "text", "", "getAllRows=1", "appointment", 0, 100);

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
[1]: ../howto/diary/get-appointment.md
