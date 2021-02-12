---
title: row_sample_collection
description: SuperOffice database Collection
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: sample
---

# Collection

## Example 1

```csharp
using SuperOffice;
using SuperOffice.CRM.Rows;

PersonRows personRows = PersonRows.GetFromIdxFirstname("Donald");
Assert.IsTrue( personRows.Count > 0, "There are persons with first name Donald" );

foreach (PersonRow personRow in personRows)
{
  Assert.AreEqual( "Donald", personRow.Firstname, "The first name is Donald" );
}
```

## Example 2

```csharp
using SuperOffice;
using SuperOffice.CRM.Rows;

PersonRows personRows = new PersonRows.IdxContactId(10);
Assert.IsTrue( personRows != null, "A collection of persons where returned" );
Assert.IsTrue( personRows.Count == 2, "There are persons 2 with contact #10" );

foreach (PersonRow personRow in personRows)
{
  Assert.AreEqual( 10, personRow.ContactId, "Contact ID for the person is 10" );
}
```

## Example 3

Custom search allows you to specify a general query and get a row collection back.

```csharp
using SuperOffice;
using SuperOffice.Data;
using SuperOffice.CRM.Rows;

PersonRows.CustomSearch queryPersons = new PersonRows.CustomSearch();
queryPersons.Restriction = queryPersons.TableInfo.Lastname.Like(S.Parameter("a%"));

PersonRows somePersons = PersonRows.GetFromCustomSearch( queryPersons );

foreach (PersonRow person in somePersons)
{
  long id = person.ContactId;
  string firstname = person.Firstname;
  string lastname = person.Lastname;
}
```

See Also: PersonRows PersonRow
