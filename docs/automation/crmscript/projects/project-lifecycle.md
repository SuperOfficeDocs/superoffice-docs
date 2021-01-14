---
title: crmscript_project_lifecycle
description: Projects from start to end
author:
so.date:
keywords:
so.topic:
---

# Projects from start to end

## Register a project

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

## Get selected projects

> [!TIP]
> You can only retrieve projects for persons that are SuperOffice users ([associates](../persons-and-organizations/employees.md)).<br/>The signed-in user must also have permission to view those projects. Otherwise, an exception is thrown.

### NSProject[] GetProjectList(Integer[] p0)

To call `GetProjectList()`, we need to create the list of **project IDs** first.

In this example, we use [SearchEngine](../searchengine/index.md) to get the ID of all projects headed by a specific associate and not marked as *done*.

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

### NSProject[] GetProjectsFromContact(Integer contactId)

A company is implicitly linked to a project when at least 1 [person](../persons-and-organizations/customer.md) in that [organization](../persons-and-organizations/company.md) is a [member](./project-members.md) of that project.

```crmscript!
Integer contactId = 4;
NSProjectAgent agent;
NSProject[] projectList = agent.GetProjectsFromContact(contactId);

foreach (NSProject p in projectList) {
  printLine(p.GetProjectId().toString() +" | " + p.GetName());
}
```

### NSProject[] GetProjectsFromPerson(Integer personId)

```crmscript
Integer personId = 5;
NSProjectAgent agent;
NSProject[] projectList = agent.GetProjectsFromPerson(personId);
```

## Update a project

```crmscript
NSProjectAgent agent;
NSProjectEntity p = agent.GetProjectEntity(4);

p.SetDescription("Let our advance worrying become advance thinking and planning."); // Winston Churchill

p = agent.SaveProjectEntity(p);
```

## Ending a project

In the end, regardless of whether you followed a [project guide](./project-guides.md) or not, a project is either **completed** or **stopped**. It is time to wrap things up and at the same time make sure the project manager and others can learn from it either way.

| Status | Description |
|:------:|:------------|
| 3      | completed   |
| 4      | stopped     |

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

## Reference

### Frequently used fields

| Field          | Description                                  |
|:---------------|:---------------------------------------------|
| project_id     | ID                                           |
| name           | name of project                              |
| associate_id   | project manager or owner                     |
| type_idx       | type of project                              |
| status_idx     | status                                       |
| done           | 0 = no, 1 = yes                              |

For a complete list of fields, see the [database reference](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-project.htm).

### Timestamp values

| Field             | Description                                               |
|:------------------|:----------------------------------------------------------|
| registered        | UtcDateTime of registration                               |
| updated           | UtcDateTime of last update                                |
| endDate           | expected closing time or when it was completed or stopped (DateTime) |
| nextMilestoneDate | closest non-complete future milestone activity (DateTime) |
