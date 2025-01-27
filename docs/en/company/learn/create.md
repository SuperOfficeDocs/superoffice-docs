---
uid: help-en-company-create
title: Create a new company
description: Create a new company
keywords: create company, add interest, Interests tab, company
author: Bergfrid Dias
date: 11.29.2024
version: 10
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Create a new company

In the **Company screen**, you can create and manage company records, including custom fields and additional data. Watch this [video guide on creating a company][1].

## Steps to create a company

1. Click **New** on the top bar and select **Company**.

1. In the **Company** tab:
    * Enter the **Company name** (mandatory, marked in red).
    * Fill in the **Country** field. This updates the address format for that country automatically. Your home country is preselected by default based on your preferences. You can change this in **Personal settings** > **Preferences** > **System**.
    * Complete any additional fields as required, such as **Zip code**, **Phone**, **Email**, and **Website**.

    ![An empty Company card showing mandatory and optional fields. -screenshot][img1]

1. Select a category and business type in the **Category** and **Business** fields. Both are mandatory to save the record.

1. (Optional) Add more details:
    * Go to the **More** tab to [enter custom fields][12].
    * Go to the **Interests** tab to [specify interests](#interests-tab).
    * Go to the **Note** tab to [add notes][5].

1. Click **Save** to ensure all information is stored.

## <a id="fields"></a>Key fields explained

The following fields are available in the Company card. Some fields are filled automatically, while others require input.

> [!NOTE]
> Fields and layout may vary based on [Screen designer][9] configurations and other UI customizations.

* **Department**: Specify a department if the company has multiple branches or divisions.
* **Address fields**: Adjust automatically based on the selected country.
* **Zip code and city**: If you enter a postal code defined in the SuperOffice database, the city name will fill in automatically if the field is empty. You can also enter a city name manually, and a postal code will be suggested.
* **Phone/Fax/Email/Website**: Enter multiple entries with descriptions, such as *Switchboard*. Click outside the table or press TAB to close the input table.
* **Our Contact**: Automatically assigns your name. Click the arrow to choose someone else from your organization.
* **Main contact**: Select the contact who should be the main contact for this client. Contacts must first be added to the company before they can be selected.
* **Code**: Automatically suggested after saving the company. The code is based on the company name but can be manually edited.
* **Number**: Automatically assigns the next available company number. The default starting number is 10001 and increments by 1. This setting can be adjusted in Settings and maintenance.
* **VAT No.**: Enter the company's VAT or similar identifier.
* **Stop** and **No Mailings** checkboxes:
  * **Stop**: Indicates special handling is required for the company. If you select **Stop**, a stop sign appears on the Company card. You can also add a note explaining why this company is flagged. This option is only available in Edit mode.
  * **No Mailings**: Prevents direct mailings to this company.

[!include[3 udef](../../learn/includes/more-udef.md)]

## Duplicate detection

If you enter a company similar to one already in SuperOffice CRM, the **Duplicates** dialog will appear. This helps prevent [unintentionally registering an existing company][2].

* Review the listed duplicates to maintain data consistency and avoid unnecessary records.
* Choose to continue working with the new record or switch to one of the listed companies.

## <a id="interests-tab"></a>Add interests

Interests can help you create targeted selections. For example, you can define *reference account* as an interest and build a selection for marketing campaigns aimed at those accounts.

1. Go to the **Interests** tab.

1. In edit mode, specify interests by checking the relevant boxes. Available interests are defined in **Settings and maintenance**.

    > [!NOTE]
    > When the tab is in view mode, only the selected interests are displayed. In edit mode, you may see additional options.

1. If you select one or more interests, a dot will appear next to the **Interests** tab name.

    ![The Interests tab with checkboxes for selecting company interests. -screenshot][img2]

1. Click **Save** to store the selected interests.

## Related content

* [Add company as a favorite][4]
* [Preferences dialog][3] - default field values and list values

<!-- Referenced links -->
[1]: https://community.superoffice.com/globalassets/user--admin/learning/user-guide/company--contact/add-company.mp4
[2]: ../../learn/basics/duplicates.md
[3]: ../../learn/getting-started/preferences.md
[4]: ../../learn/basics/fav.md
[5]: ../../learn/basics/notes.md
[9]: ../../ui/screen-designer/learn/index.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/new-company.png
[img2]: ../../../media/loc/en/company/interests.png
