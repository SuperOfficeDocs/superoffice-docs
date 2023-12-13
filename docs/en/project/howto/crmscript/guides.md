---
uid: crmscript-project-guide
title: Project guides
description: How to work with project guides in CRMScript.
author: Bergfrid Skaara Dias
so.date: 05.31.2023
keywords: CRMScript, project, project guide, project type, stage, ProjectAgent
so.topic: howto
---

# Project guides

## Stages

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

### List available suggestions

```crmscript!
SearchEngine se;
se.addFields("SuggestedAppointment", "SuggestedAppointment_id,name,projectTypeStatusLinkId");
print(se.executeTextTable());
```

### Create follow-up from suggestion

All you need is 3 IDs, and then calling `CreateDefaultAppointmentEntityFromProjectSuggestion()` will do the magic for you!

* ID of the suggested follow-up (appointment)
* ID of the project
* ID of the owner (associate)

```crmscript
NSAppointmentAgent appointmentAgent;
NSAppointmentEntity newAppointment = appointmentAgent.CreateDefaultAppointmentEntityFromProjectSuggestion(3,4,false,5);
newAppointment = appointmentAgent.SaveAppointmentEntity(newAppointment);
```

> [!TIP]
> You can also [create documents from suggestions][3].

### Create a suggestion and link it to a stage

You can also create your own blueprints and load default values into them. This example creates a suggestion called *Read project charter* with a duration of 2 hours. It then links it to an **NSProjectTypeStatusLink** with ID 1.

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

| Field | Description |
|:--|:--|
| ProjectTypeStatusLink_id | ID |
| projType_id | Link to  type |
| projStatus_id | Link to status |
| rank | sort order |

### SuggestedAppointment

| Field | Description |
|:--|:--|
| SuggestedAppointment_id | ID |
| name | name of blueprint shown in guide |
| rank | sort order |
| projectTypeStatusLinkId | anchor for project guide items |
| task_id | type of the suggested follow-up |
| daysFuture | when the follow-up should be scheduled |
| duration | in minutes |
| text | The suggested text of the new follow-up |

For a complete list of fields, see the [database reference][5].

### SuggestedDocument

| Field | Description |
|:--|:--|
| SuggestedDocument_id | ID |
| name | name of blueprint shown in guide |
| rank | sort order |
| projectTypeStatusLinkId | anchor for sale guide items |
| doctmpl_id | type of the suggested document |

For a complete list of fields, see the [database reference][6].

<!-- Referenced links -->
[3]: ../../../document/howto/crmscript/doc-properties.md
[5]: ../../../database/tables/suggestedappointment.md
[6]: ../../../database/tables/suggesteddocument.md
