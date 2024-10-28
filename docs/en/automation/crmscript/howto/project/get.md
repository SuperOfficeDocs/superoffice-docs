---
uid: crmscript-project-get
title: Get selected projects
description: How to get selected projects with CRMScript
keywords: CRMScript, project, ProjectAgent, GetProjectList
author: Bergfrid Skaara Dias
date: 06.01.2023
version: 9
topic: howto
---

# Get selected projects

> [!TIP]
> You can only retrieve projects for persons that are SuperOffice users ([associates][3]).
>
> The signed-in user must also have permission to view those projects. Otherwise, an exception is thrown.

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

## NSProject[] GetProjectList(Integer[] p0)

To call `GetProjectList()`, we need to create the list of **project IDs** first.

In this example, we use [SearchEngine][1] to get the ID of all projects headed by a specific associate and not marked as *done*.

```crmscript
String associateId = "5";
Integer[] projectIds;

SearchEngine se;
se.addFields("project","project_id");
se.addCriteria("project.associate_id", "OperatorEquals", associateId,"OperatorAnd", 1);
se.addCriteria("project.done", "OperatorEquals", "=","OperatorAnd", 1);
se.execute();

while (!se.eof()) {
  projectIds.pushBack(se.getField(0).toInteger());
  se.next();
}

NSProjectAgent agent;
NSProject[] projectList = agent.GetProjectList(projectIds);
```

## NSProject[] GetProjectsFromContact(Integer contactId)

A company is implicitly linked to a project when at least 1 person in that [organization][2] is a [member][5] of that project.

```crmscript!
Integer contactId = 4;
NSProjectAgent agent;
NSProject[] projectList = agent.GetProjectsFromContact(contactId);

foreach (NSProject p in projectList) {
  printLine(p.GetProjectId().toString() +" | " + p.GetName());
}
```

## NSProject[] GetProjectsFromPerson(Integer personId)

```crmscript
Integer personId = 5;
NSProjectAgent agent;
NSProject[] projectList = agent.GetProjectsFromPerson(personId);
```

<!-- Referenced links -->
[1]: ../../searchengine/index.md
[2]: ../company/index.md
[3]: ../../../../contact/reference/index.md#associate
[5]: members.md
