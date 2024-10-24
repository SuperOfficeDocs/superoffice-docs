---
uid: crmscript-project-create
title: Register a project
description: How to register a project with CRMScript.
keywords: CRMScript, project, ProjectAgent
author: Bergfrid Skaara Dias
date: 06.01.2023
version: 9
topic: howto
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
