---
title: Show list data in UI combo box
uid: listagent_example_1
description: Show list data in UI combo box using a ListAgent
author: SuperOffice Product and Engineering
keywords: 
content_type: howto
date:
category: list
area: api-services
redirect_from: /en/api/netserver/lists/services/listagent/show-countrylist-in-combobox
---

# Show list data in UI combo box

The below example demonstrates how we can show the data in a combo box using the NetServer provided lists.

```csharp
using SuperOffice.CRM.Services;
using SuperOffice;

using (SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //create a ListAgent
  using(ListAgent listAgent = new ListAgent())
  {
    //retrieve the list you want using the specific method
    Country[] countryList = listAgent.GetCountries();

    //add the display column you want to the control
    foreach (Country countryRow in countryList)
    {
      cmbCountry.Items.Add(countryRow.EnglishName);
    }
  }
}
```
