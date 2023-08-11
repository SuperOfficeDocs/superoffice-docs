---
uid: help-en-sync-configure-field-allocation
title: Configure field mapping
description: Configure field mapping
author: Bergfrid Dias
so.date: 03.29.2023
keywords: quote, sync, connector, ERP, mapping
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Configure field mapping

When synchronizing data between SuperOffice and ERP systems, must specify which SuperOffice field and which ERP field belong together.

> [!NOTE]
> When editing an ERP connection, you must first deactivate it.

1. [!include[Go to sync](../includes/goto-sync.md)]

1. Select the ERP connection, and click the **Mappings** button at the bottom. The **Mappings** dialog displays the tabs for the available actors in the ERP system.

1. Select the tab for the actor for which you want to configure allocations.

1. Check **Sync ERP \[actor\] to SuperOffice \[entity\]**.

1. In the list below, select the synchronization direction and which SuperOffice field each ERP field should be allocated to (synchronized with). You can also choose if the fields should be displayed in searched and the **ERP** tab.
    The list consists of the following columns:

    * **Show in Search**: Check here if this field should be displayed in search results.
    * **ERP Field**: Shows the name of the field in the ERP system.
    * **Direction**: Here you select the direction(s) for the synchronization. See table of icons below.

    * **SuperOffice Field**: here you choose which SuperOffice field you want to synchronize. Some fields (such as customer and contact IDs) cannot be synchronized and the list will then be empty.
    * **Show In ERP Tab**: check here if you want this field to be displayed in the **ERP** tab in SuperOffice CRM (Company, Contact, and Project screen).

        > [!NOTE]
        > If you have chosen to synchronize this field with a SuperOffice field, there is no point in displaying the field in the **ERP** tab.

1. Repeat steps 4 to 6 to configure field allocations for other actors.

1. Click **Done** to finish. Below the **ERP connections** list, all the fields that are synchronized for the different actors are shown.

1. Check **Active** for the ERP connection you edited.

## What does the icons mean?

| Icon | Explanation |
|---|---|
| ![icon][img1] | No synchronization (SuperOffice field is selected). If the field is mandatory, you MUST choose a direction. |
| ![icon][img2] | Sync both ways. |
| ![icon][img3] | Sync from SuperOffice to the ERP system. |
| ![icon][img4] | Sync from the ERP system to SuperOffice. |
| ![icon][img5] | No synchronization (SuperOffice field is NOT selected), or the field cannot be synchronized (for example, customer name). This can also be due to read-only fields. Mouse-over the icon to view details. |

> [!NOTE]
> The arrows are disabled until you select a SuperOffice field.

## Troubleshooting

If you defined incorrect settings for the field allocations, you will receive a descriptive error message. This would apply for instance to a mandatory field without a synchronization direction. You must correct the error before you can activate the ERP connection.

## How to map/allocate list items

If you mapped any lists (for example category), you must also [map the individual items on each list][1].

<!-- Referenced links -->
[1]: sync-configure-list-mapping.md

<!-- Referenced images -->
[img1]: ../../../../../media/icons/admin/sync-none.png
[img2]: ../../../../../media/icons/admin/sync-2-way.png
[img3]: ../../../../../media/icons/admin/sync-to-erp.png
[img4]: ../../../../../media/icons/admin/sync-to-so.png
[img5]: ../../../../../media/icons/admin/sync-deactivated.png
