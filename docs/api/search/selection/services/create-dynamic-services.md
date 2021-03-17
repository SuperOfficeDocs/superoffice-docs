---
# Mandatory fields.
title: create_dynamic_selection_services      # (Required) Very important for SEO.
description: Creating a dynamic selection using NetServer services # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 06.24.2016
keywords: search
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Creating a dynamic selection (services)

As the word implies, a dynamic selection is **a selection that is bound to change dynamically** and it’s **based on search criteria** and not just static members.

A typical criterion would be "Add all contacts with a specific business type". This would cause the member count of this selection to increase each time a new contact is added to the database that matches the business type specified as a search criterion for this selection. You may have as many search criteria as you want.

## Add restrictions to the selection

[!code-csharp[CS](includes/create-dynamic-services.cs)]

### Initialize and declare the variables

The first few lines of the codes initialize and declare the variables that we plan to use in the code.

> [!TIP]
> If you are new to selections, check out [how to use criteria in selection searches][1].

* **storageType** – we use the *Criteria* type since this is a selection

* **providerName** – we use `ContactDynamicSelection` since we plan to create a dynamic selection

* **storageKey** – we use `selection=61` since this will allow us to create a restriction for that particular selection ID. In the statement, `selection` is the name of the table and 61 is the primary key ID (selection\_id).

* **staticColumns** – we use `name` and `contactId`

* **handledColumns** – retrieved based on `storageType` and `providerName`

[!code-csharp[CS](includes/create-dynamic-services.cs?range=22)]

### GetSpecifiedCriteriaInformationWithDefaults

[!code-csharp[CS](includes/create-dynamic-services.cs?range=26)]

With the execution of the above code we have retrieved criteria information from a set of saved criteria, for specific set columns. In the case of the example this would be empty.

### Create variable to store restrictions

The next step is to create a variable that could be used to store the restrictions.

[!code-csharp[CS](includes/create-dynamic-services.cs?range=29)]

The `Dictionary` class from the `System.Collection.Generic` namespace is used to store the restriction as a key-value pair. The key is the name of the field the restriction is on, and the value is the `ArchiveRestrictionInfo` object that describes the restriction itself.

Once this is done we may add the necessary restrictions as shown below.

[!code-csharp[CS](includes/create-dynamic-services.cs?range=35-36,39-41)]

### Save

Once all the required restrictions have being added the created restriction can be saved by executing the following statement.

[!code-csharp[CS](includes/create-dynamic-services.cs?range=44)]

> [!NOTE]
> Though we have added only 2 restrictions explicitly, it can be seen that there are many conditions. This is because we have got the criteria with the `GetSpecifiedCriteriaInformationWithDefaults` method, which returns all criteria with default values. However, this would not be affecting the outcome of the selection since the other criteria are not active – they have no values to search for.

## View the result with ISelectionAgent or IArchiveAgent

We may also be able to view the results of the restriction with the `ISelectionAgent` or the `IArchiveAgent`.

The following code shows how we can use the `ISelectionAgent` to retrieve information about the particular selection.

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

using(SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  using(SelectionAgent newSelAgt = new SelectionAgent())
  {
    SelectionEntity newSelEnt = newSelAgt.GetSelectionEntity(56);

    string entName = newSelEnt.Name;
    uint entMemCnt = newSelEnt.MemberCount;
  }
}
```

If we wish to retrieve the details of the members in the selection we need to use the `IArchiveAgent`. After authenticating, set the parameters like below.

[!code-csharp[CS](includes/get-members-services-3.cs?range=10,13,16-17,20-21,24,27,30)]

Then call `GetArchiveListByColumns()` and follow the patten for [getting selection members][2].

**Output:**

```text
contactId   name        selectionId
125 Tester 1        61
126 Tester 2        61
127 Tester 3        61
128 Tester 4        61
129 Tester 5        61
```

<!-- Referenced links -->
[1]: ../../ifindagent/using-criteria.md
[2]: get-selection-members-services.md
