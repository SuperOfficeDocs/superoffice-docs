---
uid: crmscript-project-samples
title: Samples
description: Sample code for working with projects in CRMScript.
keywords: project, CRMScript
author: Bergfrid Dias
date: 06.01.2023
version: 9
topic: howto
---

# Samples

## List available project types

```crmscript!
SearchEngine se;
se.addFields("ProjType", "ProjType_id,name");
print(se.executeTextTable());
```

## Get an updated list of statuses

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

## Check if project is connected to a guide

```crmscript!
NSProjectAgent agent;
NSListAgent listAgent;

NSProjectEntity p = agent.GetProjectEntity(4);
NSProjectTypeEntity type = listAgent.GetProjectTypeEntity(p.GetProjectType().GetId());

if (type.GetHasGuide()) {
  printLine("This project has a guide!");
}
else {
  printLine("This project does not have a guide.");
}
```

> [!NOTE]
> `GetProjectType()` returns an NSProjectType object, while you need an NSProjectTypeEntity object to call `GetHasGuide()`. You can use the list agent to do the "conversion".

<!-- Referenced links -->
