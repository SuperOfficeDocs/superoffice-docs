---
title: Update an Entity through an Entity
uid: update_entity_in_entity
description: How to update an Entity
author: SuperOffice Product and Engineering
date: 11.05.2016
keywords:
content_type: howto
redirect_from: /en/api/netserver/entities/update-entity-in-entity
---

# Update an Entity through an Entity

There can be more than one way to update an Entity property that is exposed by another Entity.

## Update an Entity through a property exposed by another Entity

This example retrieves a Sale Entity by calling the `GetFromIdxSaleId` method. Then it accesses and modifies some basic properties of the Contact Entity through the Sale Entity.

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieving a Sale using the index of a Sale
  Sale newSale = Sale.GetFromIdxSaleId(2);

  //Updating a Contact Entity property through a Sale Entity
  newSale.Contact.Name = "Name Changed 2";
  newSale.Contact.OrgNr = "SA-5454545";

  //Creating a Row and assigning it to the Sale Entity and modifying its values
  BusinessRow newBusinessRw = BusinessRow.GetFromIdxBusinessId(10);
  newSale.Contact.Business = newBusinessRw;
  newSale.Contact.Business.Name = "New Business 2";
  newSale.Contact.Business.Tooltip = "New Tool tip";

  //Creating a Row Collection and assigning it the Sale Entity and modifying its values
  PhoneRow newPhoRow = PhoneRow.CreateNew();
  newPhoRow.PhoneNumber = "987654321";
  newPhoRow.Description = "Testing Method 2";
  int posPhoRow = newSale.Contact.Phones.Add(newPhoRow);
  newSale.Contact.Phones[posPhoRow].PhoneNumber = "5555555555";
  newSale.Contact.Phones[posPhoRow].Description = "Testing methods 2B";

  //Creating an Entity and assigning it to the Sale Entity and modifying its values
  Person newPers = Person.CreateNew();
  int posPersonRow = newSale.Contact.Persons.Add(newPers);
  newSale.Contact.Persons[posPersonRow].Firstname = "Will";
  newSale.Contact.Persons[posPersonRow].Lastname = "Turner";

  URLRow newUrl = URLRow.CreateNew();
  int posURLRow = newSale.Contact.Persons[posPersonRow].Urls.Add(newUrl);
  newSale.Contact.Persons[posPersonRow].Urls[posURLRow].UrlAddress1 = "www.testSuperOffice.com";

  if (newSale.IsDirty == true)
  {
    //Saving the Sale Entity
    newSale.Save();
  }
}
```

### Business

The business property on the `Contact` of the `Sale` Entity is Row type. This means that it represents a row in the `Business` table.

In the example, a Business row is retrieved and assigned to the contact after which its properties are modified through the `Sale` Entity.

If the Sale Entity’s Contact has a `Business` already assigned, there is no need to create a new Business Row and assign it.

### Phones

The Sale Entity’s Contact has a property called `Phones`, which consists of multiple phone rows of type `PhoneRow`.

The example shows how to create a phone row and assign it to a Contact’s `Phones` property using the `Add` method.

The added values are modified through the `Sale` Entity by indexing the `Phones` property of the `Contact`.

### Persons

The `Persons` property is similar to the Phones property. However, it differs in that Persons consists of Entities of persons as opposed to Rows.

Using the `CreateNew` method, a new Person entity is created and assigned to the Sale Entity’s Contact’s Persons property. These statements can be avoided if the Contact’s Persons property already consists of data.

The next few statements relate to changing different types of properties contained in the `Persons` Entity through the Sale Entity.

> [!NOTE]
> The Sale entity is saved by calling `Save()` method. Any modifications made to properties such as Contact Entity and Person Entity above will also be saved.

## Update an Entity and assign it as a property of an Entity

This example creates a Business Row and modifies its values. It is then assigned to the Person Entity’s Business property.

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SuperOffice.SoSession mySession =
SuperOffice.SoSession.Authenticate("SAL0", ""))
{
  //Retrieving a Sale using the index of a Sale
  Sale newSale = Sale.GetFromIdxSaleId(2);

  //Retrieving a Person Entity
  Person newPerson = Person.GetFromIdxPersonId(25);

  //Updating Person Entity Basic properties
  newPerson.Firstname = "Jessica";
  newPerson.Lastname = "Alba";

  //Updating Person Entity properties which are of Row type
  BusinessRow newBusiness = BusinessRow.GetFromIdxBusinessId(9);
  newBusiness.Name = "New Business";
  newPerson.Business = newBusiness;

  //Updating Person Entity properties which are Entities itself
  Contact newContact = Contact.CreateNew();
  newContact.Name = "John Stevens";
  URLRow newUrls = URLRow.CreateNew();
  newUrls.UrlAddress1 = "www.SuperOffice.com/test";
  newContact.Urls.Add(newUrls);
  newContact.Row.Number1 = "SA-147258";
  if (newContact.IsDirty == true)
  {
    //Assigning the Contact to the Person
    newPerson.Contact = newContact;
  }

  //Updating Person Entity porperty which is of Rows type
  EmailRow newEmails = EmailRow.CreateNew();
  newEmails.EmailAddress = "jessica@stars.com";
  newEmails.Description = "Jessica's Email";
  newPerson.Emails.Add(newEmails);

  //Assigning the Person property to the Sale
  newSale.Person = newPerson;
  if (newSale.IsDirty == true)
  {
    //Saving the Sale Entity
    newSale.Save();
  }
}
```

### IsDirty

The `IsDirty` property of the modified contact is used to check whether any modifications happened, and only if so, to assign it to the Person Entity’s Contact property.

### Emails

The `Emails` property of the `Person` Entity may consist of any amount of email addresses that the person possesses. The data is of EmailRow type, thus we have to create an instance of EmailRow, assign values to it, and then assigned it to the Emails Property of the Person Entity.

## See also

* [Update a basic property of an Entity][1]
* [Update a Row through an Entity][2]

<!-- Referenced links -->
[1]: update-entity.md
[2]: ../rows/update-row-in-entity.md
