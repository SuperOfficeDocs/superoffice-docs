---
title: get_entity_from_entity
description: Retrieve an Entity property through an Entity
author: {github-id}
so.date: 11.05.2016
keywords: 
so.topic: howto
---

# Retrieve an Entity property through an Entity

The `Sale` Entity contains a property that in itself is an Entity. Examples of such include Contact and Person properties. These properties consist of different properties which could be of different data types such as String, Double, Integer, Row, and DateTime.

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;

using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieving an Entity
  Sale newSale = Sale.GetFromIdxSaleId(2);

  //Retrieving Properties of an Entity through an Entity
  //Basic Properties
  string salePerName = newSale.Person.Firstname + " " + newSale.Person.Lastname;
  string salePerDOB = newSale.Person.DayOfBirth.ToString();
  string salePerDept = newSale.Person.Department;
  //Row properties
  string salePerAdd = newSale.Person.Address.Address1;
  string salePerAddCoun = newSale.Person.Address.County;
  string saleCounEng = newSale.Person.Country.EnglishName;
  string saleCounName = newSale.Person.Country.Name;

  //Entity properties
  string salePerConName = newSale.Person.Contact.Name;
  string salePerConCoun =newSale.Person.Contact.Country.Name;

  //Rows property
  if (newSale.Person.Emails.Count != 0)
  {
    string[] saleEMAddress = new string[newSale.Person.Emails.Count];
    string[] saleEMDesc = new string[newSale.Person.Emails.Count];
    int i = 0;
    foreach (EmailRow email in newSale.Person.Emails)
    {
      saleEMAddress[i] = email.EmailAddress;
      saleEMDesc[i] = email.Description;
      i = i + 1;
    }
  }

  //Entity Collection properties
  if (newSale.Person.Sales.Count != 0)
  {
    string[] salPerSalAmt = new string[newSale.Person.Sales.Count];
    string[] salPerSalConNm = new string[newSale.Person.Sales.Count];
    int i = 0;
    foreach (Sale sale in newSale.Person.Sales)
    {
      salPerSalAmt[i] = sale.Amount.ToString();
      salPerSalConNm[i] = sale.Contact.Name;
      i = i + 1;
    }
  }
}
```

Here a `Sale` Entity is retrieved using the `IdxSaleId` class and some basic properties of the `Contact` Entity are retrieved through the `Sale` Entity.

The `Address` property (in the Contact of the Sale Entity) is of `Row` type. This means that it represents a row in the `Address` table. In this example, an Address row is retrieved.

The Sale Entity’s `Person` has a property called `Emails`. It consists of multiple Email Rows of type `EmailRow`. The example shows how to retrieve each EmailRow of the Emails property of the Person through Sale Entity.

The Person property contains properties of `SaleCollection` type.

## See also

* [How to retrieve an Entity][1]
* [Retrieve a row through an Entity][2]

<!-- Referenced links -->
[1]: get-entity.md
[2]: ../rows/get-row-from-entity.md
