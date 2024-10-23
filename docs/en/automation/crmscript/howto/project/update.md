---
uid: crmscript-project-update
title: Update project
description: How to update, end, and delete a project with CRMScript
keywords: CRMScript, project, completed, project status
author: Bergfrid Skaara Dias
date: 06.01.2023
version: 9
topic: howto
---

# Update project

```crmscript
NSProjectAgent agent;
NSProjectEntity p = agent.GetProjectEntity(4);

p.SetDescription("Let our advance worrying become advance thinking and planning."); // Winston Churchill

p = agent.SaveProjectEntity(p);
```

## Ending a project

In the end, regardless of whether you followed a [project guide][6] or not, a project is either **completed** or **stopped**. It is time to wrap things up and at the same time make sure the project manager and others can learn from it either way.

| Status | Description |
|---|---|
| 3 | completed |
| 4 | stopped |

### Completed

The date is no longer an estimate, and you can record the actual completion.

```crmscript
NSProjectAgent agent;

NSProjectEntity p = agent.GetProjectEntity(2);

p.SetEndDate(getCurrentDateTime());
p.SetCompleted(true);

NSProjectStatus status;
status.SetValue("3");
p.SetProjectStatus(status);

p = agent.SaveProjectEntity(p);
```

### Stopped

Not all projects are viable, and you might need to stop a current project.

The update is very similar to marking it complete. Simply create an NSProjectStatus with value 4 instead of 3.

> [!NOTE]
> You should cancel all scheduled upcoming activities before marking it as stopped.

## Delete a project

It might be necessary to delete a project if it is no longer appropriate to store it in the database.

```crmscript
NSProjectAgent projectAgent;
agent.DeleteProjectEntity(123);
```

<!-- Referenced links -->
[6]: guides.md
