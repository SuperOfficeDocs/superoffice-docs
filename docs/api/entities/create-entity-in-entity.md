---
title: create_entity_in_entity
description: Create an Entity through an Entity
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: howto
---

# Create an Entity through an Entity

One of the more complex properties that are exposed in a typical NetServer Entity is itself an Entity. An Entity will expose another Entity when the need arises to expose more data than what you can hold in a single field.

There can be more than one way to assign a new Entity to a property that is exposed by an Entity.

## Create a new Entity through a property exposed by another Entity

In this example, the `Person` property of the `Sale` Entity has been exposed as an Entity.

[!code-csharp[CS](includes/create-entity-1.cs)]

You can access all the properties of the `Person` Entity through the `Sale` entity as shown in the example.

The `MobilePhones` property of the `Person` Entity is exposed as a `PhoneRows` type. Here, we create 2 new `PhoneRows` and add them to the `PhonesRows` collection.

> [!NOTE]
> We save only the `Sale` Entity. NetServer will look for other newly created Entities and save them to the appropriate tables in the database. This mechanism in NetServer is called **NestedPersist**.

Here, NetServer will create a new record in the `person` table and assign the person ID to the person ID field in the `sale` table so now it has the link between those tables. NetServer will also create a new row in the `phone` table and add the phone ID to the phone ID field of the `person` table. This way the NetServer maintains all the database links properly.

## Create an Entity as a property of another Entity

Above, we used a property exposed by another Entity when creating a new Entity. Here, we will create the new Entity separately and then assign it to a property of another Entity.

[!code-csharp[CS](includes/create-entity-2.cs)]

Since this example is a bit long and complex, it will be explained step by step.

First, we create a `Contact` Entity that we will assign to the `Sale` Entity later. We give it a name.

### Contact URLs

Next, we assign the 2 URLs this particular company has.

You may notice that the URL property of the contact is given as a collection of URL rows, not as a single URL row. This is because one company may have many URLs, so to facilitate that, this particular property is exposed as a collection of URL rows.

We are going to add 2 URLs to this company so that we create 2 blank elements in the URL rows collection using the `AddNew` method provided.

After you have added 2 blank elements to the `Rows` collection, you can start filling its properties with data like we have done above using the index number of each element to access the properties.

This same task can be achieved slightly differently by creating a URL row first and then adding it to the URL rows collection using the `Add` method.

```csharp
URLRow urlOne = URLRow.CreateNew();
urlOne.SetDefaults();
urlOne.UrlAddress1 = "ABCCompany.com";
urlOne.Rank = 1;
URLRow urlTwo = URLRow.CreateNew();
urlTwo.UrlAddress1 = "ABCCompanyServices.com";
myContact.Urls.Add(urlOne);
myContact.Urls.Add(urlTwo);
```

This is how you create a new URL and add it to the Entity.

If you want to retrieve a URL that is already in the database and assign that to the `Contact`, here's how:

```csharp
myContact.Urls.Add(URLRow.GetFromIdxUrlId(2));
myContact.Urls.Add(URLRow.GetFromIdxUrlId(3));
```

### Address property

The next property that we are going to populate with data is the `Address`.

The `Address` property is also exposed as an `Address` row, but in the example, we have directly accessed the properties of the row to populate them with data.

The method we have used to access the properties of the `Address` property, and the method we have used to access the properties of the URL property, shows the difference between how we access the properties of a Row and a Row collection.

Instead of assigning data directly to the `Address` row, you can create an `Address` row and assign it to the address property.

```csharp
//create a new AddressRow
AddressRow postalAddress = AddressRow.CreateNew();
postalAddress.SetDefaults();

//Assign values to its properties
postalAddress.Address1 = "P.O.Box 345";
postalAddress.Address2 = "Kalbakken";
postalAddress.Zipcode = "0901";
postalAddress.City = "OSLO";

//assign the new address to the PostalAddress property of Contact Entity
myContact.PostalAddress = postalAddress;
```

### Project Entity

So far, we have created a `Contact` Entity and filled some of its interesting properties with data. Let’s create another Entity of type `Project Entity`.

After filling some basic Entities, let's try to add a couple of project members to the project we just created.

In the example, we have created 2 new project member instances and assigned 2 `Persons` from the `person` table.

Alternatively, you can create a new `Person`, add that Entity to the `Project Member` instances, and then add the instance to the `Project`:

```csharp
Project myProject = Project.CreateNew();
Person projPerson = Person.CreateNew();
projPerson.SetDefaults();
projPerson.Firstname = "Mel";
projPerson.Lastname = "Gibson";
ProjectMember memberOne = ProjectMember.CreateNew();
memberOne.Person = projPerson;
myProject.Members.Add(memberOne);
```

If you want to add a `Project Member` that is already assigned to another `Project`, here's how:

```csharp
myProject.Members.Add( ProjectMember.GetFromIdxProjectmemberId(45));
myProject.Members.Add( ProjectMember.GetFromIdxProjectmemberId(69));
```

### Final notes

We have created the 2 Entities that we intended to create and we have populated some of the properties of those Entities with data.

Now, all we got to do is assign them to the respective properties of the `Sale` Entity and then save the `Sale` Entity back to the database.

As in the first example, we save only the `Sale` Entity and let NetServer's NestedPersist handle the rest.

## See also

* [How to create an Entity][1]
* [Create a Row as a property of an Entity][2]

<!-- Referenced links -->
[1]: create-entity.md
[2]: ../rows/create-row-in-entity.md