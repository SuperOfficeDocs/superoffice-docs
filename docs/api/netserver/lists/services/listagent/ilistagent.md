---
title: ilistagent
description: IListAgent
author: {github-id}
keywords: list,agent
so.topic: concept                # article, howto, reference, concept, guide
so.date:
so.category: list
so.area: api-services

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# IListAgent

As the name implies, the `ListAgent` is the agent that provides us with **all the named lists**. This agent API consists of methods that are named the same as the list that is returned by the method.

## Get the complete list

The advantage of using this agent is that it is very straightforward to use since all we have to do is choosing the correct method, and then the method will return us the list with no added work. Below are some of the methods that this API provides.

* GetCountries
* GetBusinesses
* GetCategories
* GetCrediteds
* GetCurrencies
* GetDepartments
* GetProjectTypes
* GetReasons

```csharp
using(SoSession.Authenticate("SAL1" , ""))
{
  using(ListAgent agent = new ListAgent())
  {
    Category[] carrier = agent.GetCategories();
    Assert.AreEqual( 10, carrier.Length, "Returns the wrong number of list items." );
  }
}
```

## Get a specific list item

The above list is an example of one type of method that this API provides. There is another type of method that this API provides and they are methods that we can use to retrieve a single entry of a given list by providing the unique identifier of the list as a parameter. For example, we can get a specific country by using the method `GetCountry` and providing the country ID as the parameter. Below is a list of such methods that correspond to the above list of methods.

* GetCountry
* GetBusiness
* GetCategory
* GetCredited
* GetCurrency
* GetDepartment
* GetProjectType
* GetReason

```csharp
SoSession.Authenticate("SAL1" , "");
using(ListAgent agent = new ListAgent())
{
  Business business = agent.GetBusiness(2);

  Assert.AreEqual( 2, business.Id, "Business.Id has wrong value" );
  Assert.AreEqual( "Bank/Finans", business.Value, "Business.Value has wrong value" );
  Assert.AreEqual( "", business.Tooltip, "Business.Tooltip has wrong value" );
 }
```

## Example

All of the above methods accept the unique identifier of each as the parameter. We can put these methods to good use when we want a single entry as a selectable item. Below is an example that uses both kind of methods that exists in the API.

```csharp
using SuperOffice.CRM.Services;
using SuperOffice;

using (SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //create a ListAgent agent
  using(ListAgent listAgent = new ListAgent())
  {
    //retrieve the list you want using the specific method
    Reason[] reasonList = listAgent.GetReasons();

    //add the display column you want to the control
    foreach (Reason reasonRow in reasonList)
    {
      cmbReason.Items.Add(reasonRow.Value);
    }

    //retrieve a single reason
    Reason reasonSingel = listAgent.GetReason(1);

    //show the value of the reason entry in a text box
    txtReason.Text = reasonSingel.Value;
  }
}
```
