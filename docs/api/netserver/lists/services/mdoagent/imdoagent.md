---
title: imdoagent
description: IMDOAgent
author: {github-id}
keywords: list,MDO
so.topic: concept
so.date:
so.category: list
so.area: api-services
# so.envir:
# so.client:
---

# IMDOAgent

The `MDOAgent` provides a very different API than that of the [ListAgent][1]. This API provides us with a set of methods that can be used to build the list that we want. The methods in this API do not focus on one particular list but can be used to **retrieve any list**.

> [!NOTE]
> MDOAgent also returns the list grouped and filtered according to how they are defined in SOAdmin (MDO mode).

## Methods

Below are some of the methods in the API.

* GetSelectableList
* GetList
* GetListWithHistory
* GetListWithRestriction
* GetSelectableListWithHistory
* GetSelectableListWithRestriction

As we can see from the above list, the methods don’t point to one single list. They are general methods that can be used to retrieve any list that we want and the advantage here is that we don't have to depend on the NetServer way of retrieving the list but we can decide on how the list should look like.

## Example 1 - GetSelectableList

Below is an example that shows how we may use the `GetSelectableList` method.

```csharp
using SuperOffice.CRM.Services;
using SuperOffice;

using (SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //get the MDO agent
  using(MDOAgent mdoAgent = new MDOAgent())
  {
    //retrieve a list you wish and you can use the parameter to specify
    //how the list should look like
    SelectableMDOListItem[] countryList = mdoAgent.GetSelectableList("country", false, "", false);

    //add the display column you want to the control
    foreach (SelectableMDOListItem selectableItem in countryList)
    {
      cmbCountry.Items.Add(selectableItem.Name);
    }
  }
}
```

Here we can see that the returned object is not a specific entity like that of in the `ListAgent` methods.

By using the other parameters we can specify how we want the list to appear and whether we want any other extra information.

* The second parameter can be used to force a fat list without the groupings.
* The third parameter can be used to specify any additional information that we may want and get the returned list based on the additional information. You can also use it to get only the history items.

For example, the below line will return a list of persons for the given contact ID.

```csharp
SelectableMDOListItem[] personList = mdoAgent.GetSelectableList("person", false, "contact_id=4" , false);
```

## Example 2

This example uses a few of the MDOAgent's methods.

```csharp
using SuperOffice.CRM.Services;
using SuperOffice;

using (SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //get the MDO agent
  using(MDOAgent mdoAgent = new MDOAgent())
  {
    //retrieve a selectable list with a restriction
    SelectableMDOListItem[] countryList = mdoAgent.GetSelectableListWithRestriction("country", "", "A");

    //add the display column you want to the control
    foreach (SelectableMDOListItem selectableItem in countryList)
    {
      cmbCountry.Items.Add(selectableItem.Name);
    }
  }
}
```

Here we retrieve the country list according to a restriction that we have set. We have told NetServer to give us all the countries that start with the letter A.

<!-- Referenced links -->
[1]: ../listagent/ilistagent.md
