---
uid: zapier-crm-company-search
title: Find Company
description: How to guide for finding companies
author: Philip Yates
so.date: 8.9.2023
keywords: Zapier
so.topic: howto
language: en
so.client: Zapier
---

# Find Company

1. Create a step in the Zap for **Search** and select **SuperOffice CRM** as **Action App**.

    ![Find Company][img1]

1. Select **Find Company** and click on **Continue**.

1. Select the **SuperOffice CRM Account** you want to connect to and click **Save + Continue**.

    ![Search for SuperOffice CRM Company][img2]

1. To set up the **Search criteria** you have from your trigger, you need to choose the field that is most unique.

    ![Search Criteria][img3]

    The fields to select from are:

    * Company id
    * Company name
    * VAT No
    * Number
    * Code
    * E-mail
    * Telephone
    * Web site

1. You need to select the most unique field you have in your trigger, and that is not hard, especially when you only can select one criterion, and not several.

1. In this example, let’s enter “Company name” as SuperOffice CRM and then the Company name from the trigger information. It depends on what possibilities you get from the trigger information.

    ![Search for SuperOffice CRM Company][img4]

1. In the search for **Find Company** you can also select “Yes” on the “**Create SuperOffice CRM company if it doesn’t exist yet**”. This means that the company will be created if it’s not found.

    * **OFF** – If you choose to select the check box to be **OFF**, the entity you want (like create company, contact, sale, appointment or document) to add in the Action step will not be added.

    * **ON** – If you choose to select the check box to be **ON**, you have to fill out the data you have for a company from your trigger information. This is done in the section: Set up SuperOffice CRM Company.

    ![Create SuperOffice CRM Company if it doesn't exist yet][img5]

1. The check box is set to **ON** and all the fields for Company appear in the list below.

## Use the Find result in the Action

1. Go to your **Action** step and the **Edit template** section

    ![Set up SuperOffice CRM Company][img6]

1. In the **Company name** field, select the step **Find or Create Company**.

    ![Find or Create Company][img7]

1. Select **Company name** in the drop down menu.

This way you know that if the company exists in your SuperOffice Online installation, the action will **not duplicate** the company, but create an entity linked to an existing company.

[img1]: media/find-company.png
[img2]: media/search-company.png
[img3]: media/search-criteria.png
[img4]: media/company-search.png
[img5]: media/create-company.png
[img6]: media/edit-template.png
[img7]: media/company-name.png
