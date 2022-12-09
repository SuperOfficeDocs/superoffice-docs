---
uid: help-en-sync-configure-field-allocation
title: sync configure field allocation
description: sync configure field allocation
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Configure field mapping

When synchronising data between SuperOffice and ERP systems, must specify which SuperOffice field and which ERP field belong together.

> [!NOTE]
> When editing an ERP connection, you must first deactivate it.

[!include[Go to sync](../includes/goto-sync.md)]

1. Select the ERP connection, and click the **Mappings** button at the bottom. The **Mappings** dialog displays the tabs for the available actors in the ERP system.

1. Select the tab for the actor for which you want to configure allocations.

1. Check **Sync ERP \[actor\] to SuperOffice \[entity\]**.

1. In the list below, select the synchronisation direction and which SuperOffice field each ERP field should be allocated to (synchronised with). You can also choose if the fields should be displayed in searched and the **ERP** tab.
    The list consists of the following columns:

    * **Show in Search**: Check here if this field should be displayed in search results.
    * **ERP Field**: Shows the name of the field in the ERP system.
    * **Direction**: Here you select the direction(s) for the synchronisation.

        <details><summary>What does the icons mean?</summary>

        | Icon | Explanation |
        |---|---|
        | ![icon][img1] | No synchronisation (SuperOffice field is selected). If the field is mandatory, you MUST choose a direction. |
        | ![icon][img2] | Sync both ways. |
        | ![icon][img3] | Sync from SuperOffice to the ERP system. |
        | ![icon][img4] | Sync from the ERP system to SuperOffice. |
        | ![icon][img5] | No synchronisation (SuperOffice field is NOT selected), or the field cannot be synchronised (for example, customer name). This can also be due to read-only fields. Mouse-over the icon to view details. |

        > [!NOTE]
        > The arrows are disabled until you select a SuperOffice field.
        </details>

    * **SuperOffice Field**: here you choose which SuperOffice field you want to synchronise. Some fields (such as customer and contact IDs) cannot be synchronised and the list will then be empty.
    * **Show In ERP Tab**: check here if you want this field to be displayed in the **ERP** tab in SuperOffice CRM.
        > [!NOTE]
        > If you have chosen to synchronise this field with a SuperOffice field, there is no point in displaying the field in the **ERP** tab.

        <details><summary>Where is the ERP tab displayed?</summary>

        * The **Company** screen
        * The **Project** screen
        * The **Contact** screen
        </details>

1. Repeat steps 4 to 6 to configure field allocations for other actors.

1. Click **Done** to finish. Underneath the **ERP connections** list, all the fields which are synchronised for the different actors are shown.

1. Check **Active** for the ERP connection you edited.

## Troubleshooting

If you defined incorrect settings for the field allocations, you will receive a descriptive error message. This would apply for instance to a mandatory field without a synchronisation direction. You must correct the error before you can activate the ERP connection.

## How to map/allocate list items

If you mapped any lists (for example category), you must also [map the individual items on each list][1].

<!-- Referenced links -->
[1]: sync-configure-list-mapping.md

<!-- Referenced images -->
[img1]: ../../../../../media/icons/admin/sync-direction-none.bmp
[img2]: ../../../../../media/icons/admin/sync-direction-2way.bmp
[img3]: ../../../../../media/icons/admin/sync-direction-toerp.bmp
[img4]: ../../../../../media/icons/admin/sync-direction-toso.bmp
[img5]: ../../../../../media/icons/admin/sync-direction-deactivated.bmp
