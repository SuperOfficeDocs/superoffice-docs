---
title: How to get the category list and set category on a contact
uid: get_set_category_mdoagent
description: How to get the category list and set Contact.Category from combo box
author: {github-id}
keywords: 
so.topic: howto
so.date:
so.category: list
so.area: api-services
# so.envir:
# so.client:
---

# How to get the category list and set category on a contact

Here we have used 2 events to get the job done. We have used one event to populate the control with categories from the list that we have retrieved and the second one for setting the category of the contact and saving the entity.

```csharp
using SuperOffice.CRM.Services;
using SuperOffice;

private void button3_Click(object sender, EventArgs e)
{
  using (SoSession mySession = SoSession.Authenticate("SAL0", ""))
  {
    //get the MDO agent
    using(MDOAgent mdoAgent = new MDOAgent())
    {
      SelectableMDOListItem[] categoryList =
       mdoAgent.GetSelectableList("category", false  , "", false);

      //set the datasource of the control
      cmbCategory.DataSource = categoryList;

      //set the display member
      cmbCategory.DisplayMember = "Name";

      //set the value member
      cmbCategory.ValueMember = "Id";
    }
  }
}

private void button4_Click(object sender, EventArgs e)
{
  using (SoSession mySession = SoSession.Authenticate("SAL0", ""))
  {
    //retrieve a contact agent
    using(ContactAgent contactAgent = new ContactAgent())
    {
      //retrieve the contact entity you want through the contact agent
      ContactEntity myContact = contactAgent.GetContactEntity(4);

      //set the category id of the contact using selected value of the combo box control
      myContact.Category.Id = System.Convert.ToInt32(cmbCategory.SelectedValue);

      //finally save contact entity
      contactAgent.SaveContactEntity(myContact);
    }
  }
}
```

Below is a screenshot of the application that we have developed.

![01 -screenshot][img1]

<!-- Referenced images -->
[img1]: media/image001.jpg
