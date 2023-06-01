---
uid: crmscript-project
title: Projects
description: Working with projects in CRMScript
author: Bergfrid Dias
so.date: 05.31.2023
keywords: project, project management, CRMScript
so.topic: howto
---

# Projects

[!include[License requirement](../../../../../common/includes/req-for-project-mgt.md)]

## List available project types

```crmscript!
SearchEngine se;
se.addFields("ProjType", "ProjType_id,name");
print(se.executeTextTable());
```

## Status of a project

| Status | Description |
|:------:|:------------|
| 1      | planned     |
| 2      | in progress |
| 3      | completed   |
| 4      | stopped     |
| 5      | closing     |

**To get an updated list:**

```crmscript!
NSListAgent listAgent;
NSProjectStatus[] statuses = listAgent.GetProjectStatuses();

foreach (NSProjectStatus s in statuses) {
  printLine(s.GetId().toString() + " " + s.GetValue());
}
```

Or:

```crmscript!
SearchEngine se;
se.addFields("ProjStatus", "ProjStatus_id,name");
print(se.executeTextTable());
```

## Frequently used fields

| Field | Description |
|:--|:--|
| project_id | ID |
| name | name of project |
| associate_id | project manager or owner |
| type_idx | type of project |
| status_idx | status |
| done | 0 = no, 1 = yes |

For a complete list of fields, see the [database reference][7].

## Timestamp values

| Field | Description |
|:--|:--|
| registered | UtcDateTime of registration |
| updated | UtcDateTime of last update |
| endDate | expected closing time or when it was completed or stopped (DateTime) |
| nextMilestoneDate | closest non-complete future milestone activity (DateTime) |

<!-- Referenced links -->
[7]: ../../../database/tables/project.md
