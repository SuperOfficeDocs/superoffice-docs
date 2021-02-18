---
# Mandatory fields.
title: listagent_example_1
description: Show list data in UI combo box using a ListAgent
author: {github-id}             # Your GitHub alias.
keywords: 
so.topic: howto                # article, howto, reference, concept, guide
so.date:
so.category: list
so.area: api-services

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Show list data in UI combo box

The below example demonstrates how we can show the data in a combo box using the NetServer provided lists.  

```csharp
using SuperOffice.CRM.Services;
using SuperOffice;

using (SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //create a IListAgent agent
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
