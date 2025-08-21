---
uid: get-set-category-mdoagent
title: How to get the category list and set category on a contact
description: How to get the category list and set Contact.Category from combo box
keywords: MDOAgent
author: Bergfrid Dias
date: 02.22.2022
content_type: howto
redirect_from:
  - /en/company/howto/services/get-set-category-mdoagent
  - /en/api/netserver/web-services/howto/company/get-set-category-mdoagent
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
    //Get the MDO agent
    using(MDOAgent mdoAgent = new MDOAgent())
    {
      SelectableMDOListItem[] categoryList =
       mdoAgent.GetSelectableList("category", false  , "", false);

      //Set the datasource of the control
      cmbCategory.DataSource = categoryList;

      //Set the display member
      cmbCategory.DisplayMember = "Name";

      //Set the value member
      cmbCategory.ValueMember = "Id";
    }
  }
}

private void button4_Click(object sender, EventArgs e)
{
  using (SoSession mySession = SoSession.Authenticate("SAL0", ""))
  {
    //Retrieve a contact agent
    using(ContactAgent contactAgent = new ContactAgent())
    {
      //Retrieve the contact entity you want through the contact agent
      ContactEntity myContact = contactAgent.GetContactEntity(4);

      //Set the category ID of the contact using selected value of the combo box control
      myContact.Category.Id = System.Convert.ToInt32(cmbCategory.SelectedValue);

      //Finally save contact entity
      contactAgent.SaveContactEntity(myContact);
    }
  }
}
```

Below is a screenshot of the application that we have developed.

![01 -screenshot][img1]

<!-- Referenced images -->
[img1]: media/image001.jpg
