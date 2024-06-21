---
title: Update values before save
uid: update_value_trigger
description: Update values before save trigger
author: Simen Mostuen Iversen
date: 06.06.2019
keywords: automation,before save
topic: howto
---

# Update values

If you want to update some values in the **Before save** function, you can use the `setOutputValue` function:

```crmscript
ed.setOutputValue("ContactEntity.OrgNr", newOrgNr);
```

Where "newOrgNr" is a String value. No extra code is required to update a field.

An example here is to summarize all sales connected to a project, then update a user-defined field on the current project.

```crmscript
EventData ed = getEventData();

// Fetch the current Project ID
String projectId = ed.getInputValue("ProjectEntity.ProjectId");

/*
  Use the SearchEngine class to summarize all the sales connected to the current project

  If you expect a larger amount of rows in return, please add a limit so that you won't stress the application/database too much. Doing several queries where you return 50 000 rows would lower the performance of your solution.

  An example is to set a limit to 1000 rows:
  se.setLimit(1000);
*/

SearchEngine se;
se.bypassNetServer(true);
se.addField("sale.amount", "sum");
se.addCriteria("sale.project_id", "Equals", projectId);
if(se.select() > 0)
{
  // In this case, the "Total Sum" field has Prog ID: SuperOffice:1
  ed.setOutputValue("ProjectEntity.UserDefinedFields.SuperOffice:1", "[F:" + se.getField(0) + "]");
}
```

In this scenario, the script will update the current project with the amount of all sales connected to it. It will not disregard lost sales, so maybe adding a few criteria is a wise choice.

You might also want to create a trigger on "After saving Sale" to update the project.

> [!NOTE]
> Also, it might be smart to trace the values to see what SuperOffice expects in return, here I have created a user-defined field of the type Decimal, which then expects `[F:value]` while fields of the type Integers expects `[I:value]`. You might save yourself some frustrating debugging hours by learning the correct formats.
