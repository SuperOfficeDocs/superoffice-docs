---
title: crmscript_projects
description: Projects
author:
so.date:
keywords:
so.topic:
---

# Projects

A project typically consists of different stages. For each stage, you have certain activities and perhaps documents that need to be completed. With every activity and every stage completed, you will get closer to completing the project.

## Key info

* a unique ID
* a name
* a project manager or owner
* project members
* the type of project
* a status
* milestones
* an (expected) end date

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

Using a [guide][1] will simplify and structure the process for the project manager with suggestions for which [follow-ups][3] to do and which [documents][2] to create at each stage.

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

## Projects vs. other entities

When working with projects, data will often intersect with the following entities:

* [company][4] (contact table)
* [contact][5] (person table)
* [documents][2]
* [follow-ups][3] (appointment table)
* [sales][6]

## In this section

1. autolist

<!-- Referenced links -->
[1]: project-guides.md
[2]: ../documents/index.md
[3]: ../follow-ups/index.md
[4]: ../persons-and-organizations/company.md
[5]: ../persons-and-organizations/customer.md
[6]: ../sales/index.md
