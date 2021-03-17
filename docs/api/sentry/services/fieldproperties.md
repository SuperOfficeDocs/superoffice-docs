---
title: sentry_fieldproperties
description: Sentry in services - FieldProperties property
author: {github-id}             # Your GitHub alias.
so.date:
keywords: sentry
so.topic: concept
so.area: api-services
---

# FieldProperties (services)

The `FieldProperties` is the mechanism that is provided by NetServer to **check the individual field access rights** of the logged-in user. All the entities of the service layer will have this property.

A typical use of this property is to check the data rights of the user before making a change or before reading a value. We can use this property for many other purposes like to check the data rights and disable a certain button or a read-only field.

## FieldRight

We can use several properties provided by the `FieldRight` property (of a field) to check for rights. The most commonly used once are listed below.

| Property | Description
|---|---|
| IsActive | whether this field is active for the logged in user: Does the user have the right to this field? |
| HasAll | whether the user has all the rights to the field |
| HasNone | returns true is the user does have any rights to the field |
| IsMandatory | if this field is mandatory in the database |
| IsUiMandatory | if this field is mandatory in the UI |
| Mask | whether a certain field right is available for the user |
| Reason | lets us retrieve the reason why a given user can not access the field |

The `Reason` property will have a reason if the user does not have the full permission (Read, Create, Update, and Delete) however if the user has full permission the reason property will be blank.

The examples below demonstrate typical scenarios of the use of `FieldProperties`.

## Example 1

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

using (SoSession mySession = SoSession.Authenticate("sal0", ""))
{
  //get the contact agent
  using(ContactAgent contactAgent = new ContactAgent())
  {
    //retrieve the entity you want
    ContactEntity myEntity = contactAgent.GetContactEntity(4);

    //check to see the logged in user have rights to the fields in the
    // form and if not disable the Save button
    if ((!myEntity.FieldProperties["Department"].FieldRight.IsActive) & 
        (!myEntity.FieldProperties["Name"].FieldRight.IsActive))
  {
    cmdSave.Enabled = false;

    //we make the fields disable as well using the FieldRight property of the field
    txtDepartment.Enabled = myEntity.FieldProperties["department"].FieldRight.IsActive;
    txtName.Enabled = myEntity.FieldProperties["Name"].FieldRight.IsActive;
  }
  }
}
```

The above code uses the FieldProperties indirectly. Here it has been used to check the data rights and if the data rights are not sufficient we have disabled the **Save** button.

## Example 2

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

using (SoSession mySession = SoSession.Authenticate("sal0", ""))
{
  //get the contact agent
  using(ContactAgent contactAgent = new ContactAgent())
  {
    //retrieve the entity you want
    ContactEntity myEntity = contactAgent.GetContactEntity(4);

    //check to see the logged in user have rights to the field that you
    //are about to modify
    if (myEntity.FieldProperties["Department"].FieldRight.IsActive)
    {
      //change the department
      myEntity.Department = "Sales";

      //save the entity
      contactAgent.SaveContactEntity(myEntity);
    }
    else
    {
      MessageBox.Show("you don't have the rights to perform this task. The reason is " + 
          myEntity.FieldProperties["Department"].FieldRight.Reason);
    }
  }
}
```

Here we have used `FieldProperties` for a more conventional purpose that is to check the data right. If it is not sufficient, we do not let the user do the modifications but we show him an error message describing why he cannot do so.

We have used the Reason property of the `FieldRight` property to give the user a more descriptive error.

```csharp
//check whether the user has the rights
if (myEntity.FieldProperties["Name"].FieldRight.HasAll)
{
  //some code here
}
else
{
 //some code here
}
```
