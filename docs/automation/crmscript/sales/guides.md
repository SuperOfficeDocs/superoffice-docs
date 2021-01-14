---
title: crmscript_sale-guide
description: Guides
author:
so.date:
keywords:
so.topic:
---

# Guides

Some sale types have an associated sales guide. For those types, it's important to understand stages and working with suggested activities.

## Check if sale is connected to a guide

```crmscript!
NSListAgent listAgent;
NSSaleAgent saleAgent;

NSSaleEntity sale = saleAgent.GetSaleEntity(4);

Integer saleTypeId = sale.GetSaleType().GetId();
NSSaleTypeEntity type = listAgent.GetSaleTypeEntity(saleTypeId);

if (type.GetHasGuide()) {
  printLine("This sale has a guide!");
}
else {
  printLine("This sale does not have a guide.");
}
```

## Stages

Each stage has a set of **suggested activities**. There is also a setting controlling whether the sale will automatically advance to the next stage when the last guided activity in a stage is completed.

The sequence of the stages is determined by the **rank** of each stage.

**Example process:**

1. Lead
2. First meeting
3. Proposal
4. Second meeting
5. Short-list
6. Verbal acceptance

### NSSelectableMDOListItem[] GetStages()

```crmscript!
NSListAgent listAgent;
NSSaleTypeEntity type = listAgent.GetSaleTypeEntity(1);
NSSelectableMDOListItem[] stages = type.GetStages();

for(Integer i = 0; i < stages.length(); i++) {
  printLine(stages[i].GetId().toString() + " | " + stages[i].GetName() + "\t Rank " + stages[i].GetRank().toString());
}
```

> [!NOTE]
> The ID and rank of a stage are not necessarily identical!

### Get stages without using the sale type

```crmscript
NSMDOAgent a;

NSMDOListItem[] saleprob = a.GetList("saleprobability",false,"",false);

for(Integer i = 0; i < saleprob.length(); i++) {
  printLine(saleprob[i].GetId().toString() + "\t" + saleprob[i].GetName());
}
```

### Bool GetIsAutoAdvance()

```crmscript!
NSListAgent listAgent;
NSSaleTypeEntity type = listAgent.GetSaleTypeEntity(1);

printLine("This sale will auto advance: " + type.GetIsAutoAdvance().toString());
```

## Suggested activities

Suggested activities are just that  - **suggested**. They're blueprints that can be used to create actual follow-ups and documents.

The blueprints sit in the intersection between sale types and stages. A sale type can have many stages, and a stage can apply to multiple sale types. The [SaleTypeStageLink table](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-SaleTypeStageLink.htm) connects them all.

### List available suggestions

```crmscript!
SearchEngine se;
se.addFields("SuggestedAppointment", "SuggestedAppointment_id,name,saleTypeStageLinkId");
print(se.executeTextTable());
```

### Create follow-up from suggestion

All you need is 3 IDs, and then calling `CreateDefaultAppointmentEntityFromSaleSuggestion()` will do the magic for you!

* ID of the suggested appointment
* ID of the sale
* ID of the owner (associate)

```crmscript
NSAppointmentAgent appointmentAgent;
NSAppointmentEntity newAppointment = appointmentAgent.CreateDefaultAppointmentEntityFromSaleSuggestion(3,4,false,5);
newAppointment = appointmentAgent.SaveAppointmentEntity(newAppointment);
```

> [!TIP]
> You can also [create documents from suggestions](../documents/doc-properties.md).

### Create a suggestion and link it to a stage

You can also create your own blueprints and load default values into them.

This example creates a suggestion called *Read specification* with a duration of 2 hours. It then links it to an **NSSaleTypeStageLink** with ID 1.

```crmscript!
NSAppointmentAgent appointmentAgent;
NSSuggestedAppointmentEntity myBlueprint = appointmentAgent.CreateDefaultSuggestedAppointmentEntity();

myBlueprint.SetName("Read specification");

TimeSpan t;
t.set(0, 0, 2, 0, 0);
myBlueprint.SetDuration(t);

NSSaleTypeStageLink link;
link.SetProbId(1);
link.SetSaleTypeId(1);
link.SetSaleTypeStageLinkId(1);
myBlueprint.SetSaleTypeStageLink(link);

myBlueprint = appointmentAgent.SaveSuggestedAppointmentEntity(myBlueprint);
```

> [!TIP]
> If you re-run the query for SuggestedAppointment, you'll find the new blueprint and its ID in the result.

## Reference

### SaleTypeStageLink

| Field                | Description       |
|:---------------------|:------------------|
| SaleTypeStageLink_id | ID                |
| saleType_id          | Link to sale type |
| stageId              | Link to stage     |
| rank                 | sort order        |

### SuggestedAppointment

| Field                   | Description                               |
|:------------------------|:------------------------------------------|
| SuggestedAppointment_id | ID                                        |
| name                    | name of blueprint shown in guide          |
| rank                    | sort order                                |
| saleTypeStageLinkId     | anchor for sale guide items               |
| task_id                 | type of the suggested appointment         |
| daysFuture              | when the appointment should be scheduled  |
| duration                | in minutes                                |
| text                    | The suggested text of the new appointment |

For a complete list of fields, see the [database reference](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-SuggestedAppointment.htm).
