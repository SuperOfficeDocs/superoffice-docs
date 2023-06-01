---
uid: crmscript-project-create
title: Register a project
description: How to register a project with CRMScript.
author: Bergfrid Skaara Dias
so.date: 06.01.2023
keywords: CRMScript, project, ProjectAgent
so.topic: howto
---

# Register a project

```crmscript!
NSProjectAgent agent;
NSProjectEntity newProject = agent.CreateDefaultProjectEntity();

newProject.SetName("Back to school campaign");

NSListAgent listAgent;
newProject.SetProjectType(listAgent.GetProjectType(1));

NSAssociateAgent associateAgent;
newProject.SetAssociate(associateAgent.GetAssociate(5));

DateTime dt;
dt.addMonth(2);
newProject.SetEndDate(dt);

newProject = agent.SaveProjectEntity(newProject);

print(newProject.GetProjectId().toString());
```

<!-- Referenced links -->
