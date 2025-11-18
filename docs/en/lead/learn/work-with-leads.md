---
uid: help-en-work-with-leads
title: Work with leads in SuperOffice
description: Learn how to view, update, and follow up leads in SuperOffice CRM.
keywords: lead
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
category: sale
topic: lead
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Work with leads in SuperOffice

Leads represent people who have shown interest but are not yet part of an active sales process. SuperOffice helps you track where each lead is in the qualification process and follow up with the right activity at the right time.

This page shows how to view, update, and use lead information in your daily work.

## See lead information on a contact

> [!NOTE]
> The **Lead status** field appears only when the company belongs to a category in the **Potential customer** group with **Enable lead status** selected.

1. Open a contact.

1. Check the **Category** field to see whether the person belongs to a potential customer category.

1. If lead status is enabled for the company category, the **Lead status** field appears directly below the **Category** field.

1. Hover over the status value to view its description.

    ![Lead status shown on the Contact screen, with a tooltip describing the selected status. -screenshot][img1]

## Update the lead status

1. Click <i class="ph ph-pencil-simple" aria-label="Edit"></i> in the upper-right corner of the contact card.

1. Select the **Lead status** dropdown.

1. Choose the status that best reflects the current stage of the lead.

    * **Contacting:** You are trying to reach the lead.
    * **Qualified:** The lead has the right fit and interest.
    * **Disqualified:** The lead is not relevant.
    * **Re-nurture:** Follow up later.

1. Click **Save** to store your changes.

## View leads in the Contacts section tab

1. Go to a company and open the [**Contacts** section tab][7].

1. Select <i class="ph ph-gear" aria-label="Settings (cogwheel)"></i> to customize columns.

1. Add **Category**, **Category group**, and **Lead status**.

1. Optionally, [filter or group the list][8] to focus on specific lead stages.

    ![Adding Category and Category group columns to the contact section tab. -screenshot][img2]

## Create selections

You can use categories and lead status to find and segment contacts and companies in SuperOffice CRM.

In the **Find** screen, add criteria such as:

* **Contact** > **Lead status** – Is one of / Is not one of.

* **Company** > **Category group** – Is one of / Is not one of.

    Use this to answer questions such as "List all my potential customers" or "List all my customers" (instead of adding multiple individual categories as criteria).

* **Company** > **Lead** or **Contact** > **Lead** based on [UTM data][5] (requires Marketing Premium).

![Filtering contacts by Lead status and Category group in the Find Contact criteria panel. -screenshot][img3]

You can save your search results as a **selection**, which can later be used for targeted marketing activities or reports.

![Viewing lead information in the Find Contact results, including Category, Lead status, and Lead creation source. -screenshot][img4]

Dynamic selections of companies or contacts can also be opened in [Board view][6] to visualize lead progression. Each column represents a lead status.

![Viewing leads by status in a board view, grouped into stages such as Open, Contacting, Disqualified, Re-nurture, and Qualified. -screenshot][img5]

## Tips and troubleshooting

* **I do not see the Lead status field.**

    Lead status is shown only on contacts. It appears only when the company belongs to a category in the **Potential customer** group with **Enable lead status** selected.

* **I cannot choose Lead or Marketing Qualified Lead as a category.**

    These categories are included only in new databases. Ask your administrator to add the categories or update your existing list.

* **The Lead status field disappeared after I changed the company category.**

    Lead status is hidden when the company is moved to a category outside the **Potential customer** group. The value is kept in the database and remains searchable, but it cannot be edited.

* **Different people in the same company show different lead statuses.**

    Lead status is stored at contact level. One person may be disqualified while another is qualified or still in an early stage.

* **A contact always gets Lead status = Open when moved into a potential customer category.**

    This is expected. New leads always start with the *Open* status.

* **I cannot change the category on a contact.**

    Contacts inherit the category from their company. To change it, update the category on the company record.

## Related content

* [Lead management overview][1]
* [Use dashboards to monitor leads][4]
* [Bulk update contact information][9]

<!-- Referenced links -->
[1]: index.md
[4]: ../../dashboard/learn/show-leads.md
[5]: ../../marketing/utm/learn/index.md
[6]: ../../search-options/selection/learn/board-view.md
[7]: ../../learn/section-tabs/contacts-tab.md
[8]: ../../learn/section-tabs/filter.md
[9]: ../../learn/basics/bulk-update.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/contact-card-open-lead.png
[img2]: ../../../media/loc/en/lead/contact-section-tab-with-lead-info.png
[img3]: ../../../media/loc/en/lead/find-leads.png
[img4]: ../../../media/loc/en/lead/save-leads-as-selection.png
[img5]: ../../../media/loc/en/lead/filtered-lead-board.png
