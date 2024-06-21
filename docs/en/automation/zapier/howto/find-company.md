---
uid: zapier-action-search
title: Search actions
description: How to guide for creating and using search actions with Zapier.
author: Philip Yates
date: 08.09.2023
keywords: Zapier, company, duplicate, search, action, Zap
topic: howto
language: en
client: Zapier
---

# Search actions

## Find company

1. Create a step in the Zap for **Search** and select **SuperOffice CRM** as **Action App**.

1. Select **Find Company** and click on **Continue**.

    ![Zapier: Find Company -screenshot][img1]

1. Select the **SuperOffice CRM Account** you want to connect and click **Save + Continue**.

1. Map search fields.

    ![Zapier: Search for SuperOffice CRM Company -screenshot][img2]

    * For **Search criteria**, choose the most unique SuperOffice field.

        In our example, enter "Company name".

        ![Zapier: Search Criteria -screenshot][img3]

    * For **Search value**, select a value from the Zap's trigger. (Options depend on the type.)

        In our example, select "Company name".

        ![Zapier: Search for SuperOffice CRM company -screenshot][img4]

1. Optionally mark the checkbox to create the entity (company, contact, sale, appointment, or document) if it isn't found.

    * **OFF:** The entity you want to add in the Action step will **not** be added.

    * **ON:** Map data from your trigger to the SuperOffice fields. This is done in the section: Set up SuperOffice CRM Company.

    ![Zapier: Create SuperOffice CRM company if it doesn't exist -screenshot][img5]

1. **Continue**.

## Use the Find result in the Action

1. Go to your **Action** step and the **Edit template** section.

1. In the **Company name** field, select the step **Find or Create Company**.

    ![Zapier: Set up SuperOffice CRM Company -screenshot][img6]

1. Select **Company name** in the drop-down menu.

    ![Zapier: Find or Create Company -screenshot][img7]

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/find-company.png
[img2]: media/search-company.png
[img3]: media/search-criteria.png
[img4]: media/company-search.png
[img5]: media/create-company.png
[img6]: media/edit-template.png
[img7]: media/company-name.png
