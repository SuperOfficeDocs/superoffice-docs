---
title: Guides
uid: crmscript_project-guides
SortOrder: 30
---

Some **project types** have an associated project guide. For those types, it's important to understand stages and working with suggested activities.

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

## Stages

Each stage has a set of **suggested activities**. There is also a setting controlling whether the sale will automatically advance to the next stage when the last guided activity in a stage is completed.

The sequence of the stages is determined by the **rank** of each stage.

### NSSelectableMDOListItem[] GetStages()

```crmscript!
NSListAgent listAgent;

NSProjectTypeEntity type = listAgent.GetProjectTypeEntity(2);

NSSelectableMDOListItem[] stages = type.GetStages();

foreach (NSSelectableMDOListItem s in stages) {
  printLine(s.GetId().toString() + " | " + s.GetName() + "\t Rank " + s.GetRank().toString());
}
```

> [!NOTE]
> The ID and rank of a stage are not necessarily identical!

### Bool GetIsAutoAdvance()

```crmscript!
NSListAgent listAgent;

NSProjectTypeEntity type = listAgent.GetProjectTypeEntity(2);

printLine("This sale will auto advance: " + type.GetIsAutoAdvance().toString());
```

## Suggested activities

Suggested activities are just that  - **suggested**. They're blueprints that can be used to create actual [follow-ups](../follow-ups/index.md) and  [documents](../documents/index.md).

The blueprints sit in the intersection between project types and stages. A project type can have many stages, and a stage can apply to multiple project types. The [ProjectTypeStatusLink table](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-ProjectTypeStatusLink.htm) connects them all.

### List available suggestions

```crmscript!
SearchEngine se;
se.addFields("SuggestedAppointment", "SuggestedAppointment_id,name,projectTypeStatusLinkId");
print(se.executeTextTable());
```

### Create follow-up from suggestion

All you need is 3 IDs, and then calling `CreateDefaultAppointmentEntityFromProjectSuggestion()` will do the magic for you!

* ID of the suggested appointment
* ID of the project
* ID of the owner (associate)

```crmscript
NSAppointmentAgent appointmentAgent;
NSAppointmentEntity newAppointment = appointmentAgent.CreateDefaultAppointmentEntityFromProjectSuggestion(3,4,false,5);
newAppointment = appointmentAgent.SaveAppointmentEntity(newAppointment);
```

> [!TIP]
> You can also [create documents from suggestions](../documents/doc-properties.md).


### Create a suggestion and link it to a stage

You can also create your own blueprints and load default values into them.

This example creates a suggestion called *Read project charter* with a duration of 2 hours. It then links it to an **NSProjectTypeStatusLink** with ID 1.

```crmscript!
NSAppointmentAgent appointmentAgent;
NSSuggestedAppointmentEntity myBlueprint = appointmentAgent.CreateDefaultSuggestedAppointmentEntity();

myBlueprint.SetName("Read project charter");

TimeSpan t;
t.set(0, 0, 2, 0, 0);
myBlueprint.SetDuration(t);

NSProjectTypeStatusLink link;
link.SetProjStatusId(1);
link.SetProjTypeId(1);
link.SetProjectTypeStatusLinkId(1);
myBlueprint.SetProjectTypeStatusLink(link);

myBlueprint = appointmentAgent.SaveSuggestedAppointmentEntity(myBlueprint);
```

> [!TIP]
> If you re-run the query for SuggestedAppointment, you'll find the new blueprint and its ID in the result.

## Reference

### ProjectTypeStatusLink

| Field                    | Description       |
|:-------------------------|:------------------|
| ProjectTypeStatusLink_id | ID                |
| projType_id              | Link to  type     |
| projStatus_id            | Link to status    |
| rank                     | sort order        |

### SuggestedAppointment

| Field                   | Description                               |
|:------------------------|:------------------------------------------|
| SuggestedAppointment_id | ID                                        |
| name                    | name of blueprint shown in guide          |
| rank                    | sort order                                |
| projectTypeStatusLinkId | anchor for project guide items            |
| task_id                 | type of the suggested appointment         |
| daysFuture              | when the appointment should be scheduled  |
| duration                | in minutes                                |
| text                    | The suggested text of the new appointment |

For a complete list of fields, see the [database reference](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-SuggestedAppointment.htm).

### SuggestedDocument

| Field                   | Description                               |
|:------------------------|:------------------------------------------|
| SuggestedDocument_id    | ID                                        |
| name                    | name of blueprint shown in guide          |
| rank                    | sort order                                |
| projectTypeStatusLinkId | anchor for sale guide items               |
| doctmpl_id              | type of the suggested document            |

For a complete list of fields, see the [database reference](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-SuggestedDocument.htm).
