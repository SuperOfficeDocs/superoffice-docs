---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: sentry_scenarios       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: NetServer scenarios # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: access control
so.topic: concept            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite            # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# NetServer scenarios

In NetServer the results of improper data access can be different from scenario to scenario. Let's look at a few examples of sentry and discuss what will happen in a case of unauthorized data access and lets how we can avoid them.

## Scenario 1

First, let’s take a case of a user trying to access data that the user does not have any rights to.

In the code below, the logged-in user is accessing data that the particular user does have any rights.

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using(SoSession newSession = SoSession.Authenticate("PB", "pb"))
{
  //get a sale entity
  Sale mySale = Sale.GetFromIdxSaleId(9);
  //try to retrieve the heading of the sale
  string saleHeading = mySale.Heading;
}
```

Here, the authenticating user *PB* belongs to a role that does not have rights to this sale record since it belongs to another user group and the PB user does not have any rights to other user groups' sale data. In the role that he belongs to, the data right on Sale is set to None on Sales of other associates. So now if you run this code since you are not trying to change any data NetSever will not throw an exception but it will not return you any data.

It is always good practice to avoid situations like this without disturbing the intended cause of your code. To avoid situations like this, we have to check whether the logged in user has proper access to data to do the intended operation in your code using the NetServer provided methods to check data access rights. Below is the same code snippet with the proper checking incorporated.

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice.Data;
using SuperOffice.CRM.Data;
using SuperOffice.CRM.Security;

using(SoSession newSession = SoSession.Authenticate("PB", "pb"))
{
  //get the sale table info
  SaleTableInfo saleTabInfo = TablesInfo.GetSaleTableInfo();
  Sale mySale = Sale.GetFromIdxSaleId(9);

  //get the field rights of the heading field using the
  //saletableinfo object we created
  FieldRight headingRight = mySale.Row.Sentries.FieldRight(saleTabInfo.Heading);

  //check to determine that the user has a fieldright other than
  //None. Any other right will ensure that the user has rights to read
  if (headingRight.IsActive)
  {
    string saleHeading = mySale.Heading;
  }
  else
  {
    //show the user why he can not perform this operation
    MessageBox.Show("You don’t have access rights to perform this operation");
  }
}
```

Here, we properly avoid getting a blank value as the return for the heading of the sale. We use NetServer provided mechanisms to check if the user has the rights, and only if the user has the rights we execute the code line that will retrieve the sale heading.

## Scenario 2

Now let’s discuss what happens when you **try to modify data that you don’t have access rights to**. Let’s take the same code snippet as earlier and try to modify the hading of the sale.

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using(SoSession newSession = SoSession.Authenticate("PB", "pb"))
{
  //get the sale id 9
  Sale mySale = Sale.GetFromIdxSaleId(9);
  //retrieve the heading
  string saleHeading = mySale.Heading;
  //change the heading
  mySale.Heading = "This is a very good sale";
  //save the sale
  mySale.Save();
}
```

Here, the authenticated user *PB* belongs to a role that does not have access rights sales of other user groups. So here when the user tries to retrieve the information, it will not give any errors, but NetServer will not retrieve the data. However, when the user tries to change the heading NetServer will throw a Sentry exception error. The exception will give you a message saying "Sentry denies access".

To avoid a situation like this, the developer is left with 2 options:

* Catch the error in a try-catch block and show the user the reason using a message box
* Prevent the error from happening by checking the user's access right (like in this scenario).

In the above code, the developer did not have a choice since NetServer did not throw an error so he is left with one option that is to check the user's access rights. In the next examples, both these options are illustrated.

## Catch the error

Catch the error in a try-catch block and show the user the reason using a message box.

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using(SoSession newSession = SoSession.Authenticate("PB", "pb"))
{
  try
  {
    //get the sale id 9
    Sale mySale = Sale.GetFromIdxSaleId(9);

    //retrieve the heading
    string saleHeading = mySale.Heading;

    //change the heading
    mySale.Heading = "This is a very good sale";

    //save the sale
    mySale.Save();
  }
  catch (Exception ex)
  {
    //show the user why he can not perform this operation
    MessageBox.Show("You canot perform this operation due to " + ex.Message);
  }
}
```

Here, we catch the error and show the user why the operation was not successful.

## Check for access right and avoid the NetServer thrown error

Prevent the error from happening by checking the user's access right.

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice.Data;
using SuperOffice.CRM.Data;
using SuperOffice.CRM.Security;
using(SoSession newSession = SoSession.Authenticate("PB", "pb"))
{
  //get the sale table info
  SaleTableInfo saleTabInfo = TablesInfo.GetSaleTableInfo();
  Sale mySale = Sale.GetFromIdxSaleId(9);

  //get the field rights of the heading field using the saletableinfo object
  //we created
  FieldRight headingRight = mySale.Row.Sentries.FieldRight(saleTabInfo.Heading);

  //check to determine that the user has a fieldright other than None. Any other
  //right will ensure that the user has rights to read
  if (headingRight.IsActive)
  {
    string saleHeading = mySale.Heading;
    mySale.Heading = "This is a very good sale";
  }
  else
  {
    //show the user why he can not perform this operation
    MessageBox.Show("You don't have access rights to perform this operation");
  }
}
```

The above example illustrates checking for access right and avoiding the NetServer thrown error.

In a scenario like this, it is up to the developer to determine the best option. But it is always good practice to handle errors using a try-catch block. It is also a very good practice always to check for the access-rights. Here, the try-catch block is intentionally left out to make the point clear on access rights.
