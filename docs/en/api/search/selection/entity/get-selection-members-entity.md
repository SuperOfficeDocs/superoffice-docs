---
title: retrieve members of a specific selection
uid: get_selection_members_entity
description: How to retrieve members of a specific selection using entities
author: SuperOffice Product and Engineering
date: 05.11.2016
keywords: search,selectionmembers
content_type: howto
redirect_from: /en/api/netserver/search/selection/entity/get-selection-members-entity
---

# How to retrieve members of a specific selection using entities

This example shows how to retrieve a Members Collection using an instance of the `Selection` class.

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using(SuperOffice.SoSession mySession =
SuperOffice.SoSession.Authenticate("sam", "sam"))
{
  //Create an Instance of the Selection Entity
  Selection newSelection = Selection.GetFromIdxSelectionId(58);

  // Looping through the Selection Member property to retrieve the Selected members
  foreach (SelectionMemberRow selMem in newSelection.SelectionMembers)
  {
    //retrieve the Contact information for a given Contact_id
    ContactRow newConRow = ContactRow.GetFromIdxContactId(selMem.ContactId);
    int selMemSelId = selMem.SelectionId;
    int selMemConId = selMem.ContactId;
    string selMemName = newConRow.Name;
    string selMemNameDept = newConRow.NameDepartment;

    //Creating the output
    Console.Write("SelectionId" + "\t" + "ContactId" + "\t" + "Name" + "\t" + "NameDepartment");
    Console.WriteLine();
    Console.Write(selMemSelId + "\t");
    Console.Write(selMemConId + "\t");
    Console.Write(selMemName + "\t");
    Console.Write(selMemNameDept + "\t");
    Console.WriteLine();
  }
}
```

An instance of the `Selection` class is created from `selection_id` 58. It is an entity object for the `selection` table in the database and the objects represent full entities with both the base table objects and all related objects. Using `GetFromIdxSelectionId()`, it creates a new instance of the `Selection` object by querying the database table via the index `IDXSelId`. The intention is to make it easy to use efficient queries that match the database index.

Once we have created the instance, we may access the `SelectionMembers` property of the `Selection` entity, which is of Rows data type, and manipulate its content. The output produced by the above code is as follows.

| SelectionId | ContactId | Name | NameDepartment |
|---|---|---|---|
|58 | 2   | StateZeroDatabase  | StateZeroDatabase |
|58 | 43  | Uniformeffekter AS | Uniformeffekter AS, UAvdeling |
|58 | 123 | Japanese Company   | Japanese Company, Tokyo |
