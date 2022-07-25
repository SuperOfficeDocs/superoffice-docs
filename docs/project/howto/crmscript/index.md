---
uid: crmscript_projects
title: Projects
description: Working with projects in CRMScript
author: Bergfrid Dias
so.date: 10.27.2021
keywords: project, project management, CRMScript
so.topic: howto
---

# Projects

[!include[License requirement](../../../includes/req-for-project-mgt.md)]

## Retrieve a project

**To view basic info, use NSProject:**

```crmscript
NSProjectAgent projectAgent;
NSProject p = projectAgent.GetProject(1);
printLine(p.GetType());
```

**To view (and possibly update) complex info, use NSProjectEntity:**

```crmscript!
NSProjectAgent projectAgent;
NSProjectEntity p = projectAgent.GetProjectEntity(1);
printLine(p.GetProjectType().GetValue());
```

## Project type

A *project type* is a named set of reuseable info that will help you standardize the process. Aside from the name and ID, you'll find info such as:

* the expected duration
* whether a [project guide][1] is available
* stages

**List available types:**

```crmscript!
SearchEngine se;
se.addFields("ProjType", "ProjType_id,name");
print(se.executeTextTable());
```

## Project guides

Using a [guide][1] will simplify and structure the process for the project manager with suggestions for which follow-ups to do and which documents to create at each stage.

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

<!-- Referenced links -->
[1]: project-guides.md
