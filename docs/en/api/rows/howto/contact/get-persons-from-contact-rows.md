---
uid: get-person-from-contact-row
title: Retrieve a list of people using rows
description: How to retrieve a list of people using rows.
keywords: person, contact, API, rows, PersonRows
author: Tony Yates
date: 05.11.2016
content_type: howto
redirect_from: /en/contact/howto/row/get-persons-from-contact-rows
---

# Retrieve a list of people using rows

Let’s explore how to retrieve a list of persons using rows.

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //get the person rows of the persons we want using the contact id that they belong to
  PersonRows myPersonRows = PersonRows.GetFromIdxContactId(21);
  //iterate through the row collection and access its properties
  if (myPersonRows.Count > 0)
  {
    foreach (PersonRow myPersonRow in myPersonRows)
    {
      cmbPersonName.Items.Add(myPersonRow.Firstname + " " + myPersonRow.Lastname);
    }
  }
}
```

The code in the above example is similar to [retrieving a list of persons using entities][1]. The only difference is that we have used rows to do the operation for us.

Here, we retrieve the list of persons as a person rows collection to a `PersonRows` object using the contact ID of the contact that the people we want belong to.

Once we have the person row collection, it is a matter of iterating through the collection to access the individual properties of a `PersonRow` like we have done above in the example.

<!-- Referenced links -->
[1]: ../../../entities/howto/contact/get-persons-from-contact-entities.md
