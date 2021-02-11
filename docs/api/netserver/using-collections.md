---
# Mandatory fields.
title: collections_best_practices       # (Required) Very important for SEO.
description: Use and misuse of collections # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 11.05.2016
keywords:
so.topic: concept         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Use and misuse of collections

RDB layer consists of collections types, which could be either `EntityCollection` types or `Rows` type that is a collection of Row types.

```csharp
CountryRows newCouRow = CountryRows.GetFromIdxEnglishName();
PersonCollection newPerColl = PersonCollection.CreateNew();
```

Executing statements such as the above instantiates the collection class but nothing else. The purpose of methods such as these is to make it easy to use efficient queries that match the database indexes. Though NetServer introduces collection properties and collection classes, the collection classes only contain data groups based on a particular criterion. Data cannot be added through them as in the database there are no such data as collection types.

## When to use Entity collection

When you need to retrieve properties of simple data types (such as string, int, or DateTime) or of Row property types, it is a good practice to use Entity Collections. However, if we were to use an Entity Collection type to retrieve Entity properties of the Collection item the code would be inefficient since each Entity property would trigger a new SELECT statement.

Let's look at some examples of bad practice of using the Entity collection, and a better solution.

### Example 1

**Bad practice:** causing multiple SELECTs

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;

using(SuperOffice.SoSession mySession = SuperOffice.SoSession.Authenticate("sam", "sam"))
{
  //Retrieving an Entity
  Contact newContact = new Contact.IdxContactId(2);

  //Retrieving Properties of a Row through an Entity
  if (newContact.Persons.Count != 0)
  {
    string conPerName = newContact.Persons[0].Firstname + " " + newContact.Persons[0].Lastname;
    string conPerDOB = newContact.Persons[0].DayOfBirth.ToString();
    string conPerDept = newContact.Persons[0].Department;

    //Row properties within an Entity Collection
    string conPerAdd = newContact.Persons[0].Address.Address1;
    string conPerAddCoun = newContact.Persons[0].Address.County;
    string conCounEng = newContact.Persons[0].Country.EnglishName;
    string conCounName = newContact.Persons[0].Country.Name;

    //Entity properties within an Entity Collection
    string conPerConName = newContact.Persons[0].Contact.Name;
    string conPerConCoun = newContact.Persons[0].Contact.Country.Name;

    //Rows properties within an Entity Collection
    if (newContact.Persons[0].Emails.Count != 0)
    {
      string[] conPerEmailAdd = new string[newContact.Persons[0].Emails.Count];
      string[] conPerEmailDesc = new string[newContact.Persons[0].Emails.Count];
      int i = 0;
      foreach (EmailRow email in newContact.Persons[0].Emails)
      {
        conPerEmailAdd[i] = email.EmailAddress;
        conPerEmailDesc[i] = email.Description;
        i = i + 1;
      }
    }
    //Entity Collection properties within an Entity Collection
    if (newContact.Persons[0].Sales.Count != 0)
    {
      string[] conPerSaleAmt = new string[newContact.Persons[0].Sales.Count];
      string[] conPerSaleConName = new string[newContact.Persons[0].Sales.Count];
      int i = 0;
      foreach (Sale sale in newContact.Persons[0].Sales)
      {
        conPerSaleAmt[i] = sale.Amount.ToString();
        conPerSaleConName[i] = sale.Contact.Name;
        i = i + 1;
      }
    }
  }
}
```

In the `Contact` Entity, the property `Person` is of `PersonCollection` type. Therefore, when we write code like above, a new SELECT is created behind the scene.

```csharp
Contact newContact = new Contact.IdxContactId(2);

//Retrieving Properties of a Row through an Entity
if(newContact.Persons.Count != 0)
{
}
```

This use of the property is not so bad. However, if the property was used within the loop, it would greatly reduce the efficiency of the code. This is because when accessing a collection we use a nested loop behind the scene.

Though this can be easy to program, it can be a slow way to use the database. The better practice would be to make use of the `PersonCollection` as shown below.

**Better:**

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;

using(SuperOffice.SoSession mySession = SuperOffice.SoSession.Authenticate("sam", "sam"))
{
  PersonCollection newPerColl = PersonCollection.GetFromIdxContactId(2);
  foreach (Person newPer in newPerColl)
  {
    string perName = newPer.Firstname + " " + newPer.Lastname;
    string PerDOB = newPer.DayOfBirth.ToString();
    string PerDept = newPer.Department;

    //Row properties within an Entity Collection
    string perAdd = newPer.Address.Address1;
    string perAddCoun = newPer.Address.County;
    string perCounEng = newPer.Country.EnglishName;
    string perCounName = newPer.Country.Name;

    //Entity properties within an Entity Collection
    string perConName = newPer.Contact.Name;
    string perConCoun = newPer.Contact.Country.Name;

    if (newPer.Emails.Count != 0)
    {
      int i = 0;
      foreach (EmailRow email in newPer.Emails)
      {
        string perEmailAdd = email.EmailAddress;
        string perEmailDesc = email.Description;
        i = i + 1;
      }
    }

    //Entity Collection properties within an Entity Collection
    if (newPer.Sales.Count != 0)
    {
      int i = 0;
      foreach (Sale sale in newPer.Sales)
      {
        string perSaleAmt = sale.Amount.ToString();
        string perSaleConName = sale.Contact.Name;
        i = i + 1;
      }
    }
  }
}
```

The above code creates a `PersonCollection` with all person whose contact ID is 2. This would result in the execution of one SELECT statement as the Select is used only to retrieve information on the `PersonCollection`. Once this is done, the properties of the collection are retrieved without any further SELECTs because none of them are properties of Entity or Entity Collection types.

## Example 2

**Bad practice:** using the Entity collection to get data that can be retrieved with the use of a Row collection

```csharp
using SuperOffice.CRM.Entities;

using(SuperOffice.SoSession mySession = SuperOffice.SoSession.Authenticate("JR", "jr"))
{
  //Retrieving a Property of PersonEntity
  PersonCollection personCollection = new PersonCollection.IdxFirstname("Linda");
  string[] perFirstName = new string[personCollection.Count];
  int i = 0;
  foreach (Person getPerson in personCollection)
  {
    //Retrieving First and Last names from the Collection
    perFirstName[i] = getPerson.Firstname + " " + getPerson.Lastname;
    i = i + 1;
  }
}
```

The above is a poor practice since we are using the Entity collection to get data that can be retrieved with the use of a Row collection. In the case of the example, we could use a `PersonRow` instead of the used `PersonCollection`. Its should be said that when an Entity or Entity Collection is been used a big join is executed behind the scene, a since we are not using most of the data exposed by the Entity the database ends up wasting a lot of work.

**Better:**

The above code could be done as follows with the use of `PersonRows`, which is more efficient.

```csharp
singSuperOffice.CRM.Rows;

using(SuperOffice.SoSession mySession = SuperOffice.SoSession.Authenticate("JR", "jr"))
{
  //Retrieving a Property of PersonRow
  PersonRows personRows = PersonRows.GetFromIdxFirstname("Linda");
  string[] perFirstName = new string[personRows.Count];
  int i = 0;
  foreach (PersonRow getPerson in personRows)
  {
    //Retrieving First and Last names from the Collection
    perFirstName[i] = getPerson.Firstname + " " + getPerson.Lastname;
    i = i + 1;
  }
}
```

## Example 3

Entities should be added by themselves.

**Bad practice:** causing unnecessary replication

When this happens the relevant Entities will be updated which will change its last updated time and trigger the relevant replication of the Entity.

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;

using(SuperOffice.SoSession mySession =
SuperOffice.SoSession.Authenticate("sam", "sam"))
{
  //Retrieving a Contact Entity
  Contact newContact = new Contact.GetFromIdxContactId(159);

  //Creating anEntity and adding it to the Collection
  Person newPerson1 = Person.CreateNew();
  newPerson1.Firstname = "Tom";
  newPerson1.Lastname = "Hanks";
  Person newPerson2 = Person.CreateNew();
  newPerson2.Firstname = "Fox";
  newPerson2.Lastname = "Jorja";
  newContact.Persons.Add(newPerson1);
  newContact.Persons.Add(newPerson2);

  EmailRow newEmail = EmailRow.CreateNew();
  newEmail.EmailAddress = "tom@test.com";
  newEmail.Description = "Tom's email address";
  newContact.Persons[0].Emails.Add(newEmail);

  //Modifying the Values Contained in the Entities Collection type properties
  newContact.Persons[0].Lastname = "Cruise";
  newContact.Persons[0].Emails[0].Description = "Email has was modified";

  //Saving the Entity
  newContact.Save();
}
```

```csharp
newContact.Persons.Add(newPerson1);
newContact.Persons.Add(newPerson2);
```

This will cause the Contact to be updated, which will change its last updated time, and trigger replication of the Contact, which is not necessary when adding Persons to a Contact.

**Better:** `Delete()` method

Following example shows how we use the `Delete` method to delete a couple of rows. This can be stated as a good practice when dealing with Collection data types.

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;

using(SuperOffice.SoSession mySession = SuperOffice.SoSession.Authenticate("JR", "jr"))
{
  //Retrieve an entity
  Contact newContact = new Contact.GetFromIdxContactId(25);
  //Deleting an Rows Collection through a Sale
  newContact.Emails.Delete();
}
```

If you wish to delete a particular Row of the collection, the following piece of code may be used:

```csharp
newContact.Emails[0].Delete();
```

> [!NOTE]
> It is possible to retrieve a collection of Entity types or Row types through a Collection class such as ContactRows or PersonCollections and then Delete it the entire collection or by indexing and deleting a particular collection item.
