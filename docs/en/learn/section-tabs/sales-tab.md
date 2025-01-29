---
uid: help-en-section-tab-sales
title: Sales tab
description: Learn how to manage and view sales information in the Sales section tab of SuperOffice CRM, including adding sales, filtering, and tracking sales activities across companies, contacts, and projects.
keywords: sales tab, section tab, sales archive
author: Bergfrid Skaara Dias
date: 01.29.2025
version: 10.5
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Sales tab

The **Sales** section tab in SuperOffice CRM allows users to view and manage [sales information][1] related to specific entities, such as companies, contacts, projects, and diaries. It displays a list of all sales connected to an entity, making it easy to track activities in context and gain deeper insight into sales performance and pending actions.

![Sales tab -screenshot][img1]

## Availability of the Sales section tab

The **Sales** section tab is available for:

| Entity | Description of the Sales section tab |
|---|---|
| [Company][9] | Displays all sales linked to the company. |
| [Contact][10] | Shows sales associated with the contact, including details such as status, amount, and next steps. |
| [Diary][11] | Presents an overview of sales, emphasizing scheduled activities and sales progress. |
| [Project][13] | Lists sales tied to the project, highlighting related activities and upcoming follow-ups. |

## <a id="columns"></a>Sales tab columns overview

The **Sales** section tab contains the following columns to display key information about each sale:

| Column | Description |
|---|---|
| Completed | Checkbox indicating if the sale is completed. A ticked checkbox (<i class="ph ph-check" aria-hidden="true"></i>) means completed, while an empty box means it is ongoing. |
| Status icon | Shows the current [status of the sale][4], such as sold, lost, or stalled. |
| Sale date | The date related to the sale, which could be the estimated, sold, or lost date. |
| Amount | The financial value of the sale. |
| Stage | The current stage of the sales process. |
| Next activity | Date of the next planned follow-up or sales activity. The date shown here represents the oldest follow-up that has not yet been completed. To view more details or identify what the next follow-up is, double-click on the sale to open the **Sale** screen. The follow-up can be seen in the **Activities** section tab of the sale. |
| Name | Name of the sale. |
| Contact | The contact associated with the sale. |
| Company | The company to which the sale is linked. |
| User ID | The user who recorded the sale. |
| ERP discount | Displays discount information if SuperOffice CRM is connected to an ERP system. |

[!include[Conf. columns](../includes/tip-configure-columns.md)]

## View sales in the Sales section tab

1. Go to the relevant screen, such as Company, Contact, Project, or Diary.

1. Click on the **Sales** tab to see all sales linked to the entity.

1. Double-click a sale in the list to open the Sale screen and view detailed information.

### Filter sales

You can filter the list of sales by date, user, or group by clicking the **Filter** button (<i class="ph ph-funnel" aria-hidden="true"></i>). This helps focus on specific sales activities that need attention.

### Include stakeholders

To include sales where the current company or contact is involved as a [stakeholder][3], check the **Include stakeholders** box at the bottom of the section tab. This provides a broader view of all sales activities related to the entity.

## Sales task assistant

The **Sales** section tab acts as a **Sales task assistant** to help you maintain an overview of ongoing sales activities. It functions as a sales-oriented task list, providing a summary of:

* **Uncompleted sales:** All ongoing sales where the sale date falls within the defined display range.

* **Planned sales activities:** All sales with scheduled activities for a specific number of days ahead.

    > [!NOTE]
    > The number of days ahead is user-defined. To change this preference, go to **Personal settings** > **Preferences** > **Functions** > **Show days ahead**.

* **Overdue activities:** All sales that have overdue activities (end dates earlier than today). These sales are highlighted in red for easy identification.

* **Stalled sales:** If a sale is marked as [stalled][4] and has a Reopen date, that date will overwrite the one in the Next activity field and will be displayed in the Next activity column.

This view helps users stay on top of pending actions, making sure that nothing slips through the cracks, ultimately improving sales management.

## Add sale

To add a new sale directly from the **Sales section** tab:

1. Select **Add** to open the sale creation dialog.

1. Enter sale details: Complete the required fields and click **Save**.

## Additional tips

* **Quick navigation:** Use the [Navigator][7] to quickly switch between different entities and their corresponding **Sales** tabs.

## Related content

* [How to add a sale][2]
* [Managing stakeholders in sales][3]
* [Filter activities and sales][8]
* [Group columns and summarize amounts][5]

<!-- Referenced links -->
[1]: ../../sale/learn/index.md
[2]: ../../sale/learn/create.md
[3]: ../../sale/learn/stakeholders/index.md
[4]: ../../sale/learn/update.md#stalled
[5]: configure-columns.md#calculate
[7]: ../getting-started/main-screen/navigator.md
[8]: filter.md
[9]: ../../company/learn/index.md#section-tabs
[10]: ../../contact/learn/index.md#section-tabs
[11]: ../../diary/learn/index.md#section-tabs
[13]: ../../project/learn/index.md#section-tabs

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/sale-detail.png
