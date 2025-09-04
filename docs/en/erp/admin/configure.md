---
uid: help-en-erp-configure
title: Configure ERP connection
description: Configure synchronization between SuperOffice CRM and your ERP system by mapping fields, setting defaults, and prioritizing ERP connections.
keywords: ERP connection, configure sync, field mapping, list mapping, default values, rank ERP fields, set sync priority, edit ERP connection, SuperOffice ERP integration, ERP tab, sync connector
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
redirect_from:
  - /en/quote/learn/admin/sync/sync-configure-default-values
  - /en/quote/learn/admin/sync/sync-configure-field-allocation
  - /en/quote/learn/admin/sync/sync-configure-list-mapping
  - /en/quote/learn/admin/sync/sync-rank-fields-shown-in-erp-tab
  - /en/quote/learn/admin/sync/sync-set-sync-priority
---

# Configure ERP connection

After adding an ERP connection, you must configure how data is synchronized between SuperOffice and the ERP system. You do this using the buttons at the bottom of the **Sync** tab in the Quote/Sync screen.

![ERP connections list with options below -screenshot][img1]

## Field mapping

Field mappings define how ERP fields correspond to SuperOffice fields and how data flows between the systems. The available ERP actors and ERP fields are provided by the sync connector and may vary depending on your ERP system. In addition to setting the synchronization direction, you can also choose which fields should appear in the search window and in the **ERP** tab in SuperOffice CRM.

1. Select the ERP connection and click **Mappings** in the lower-left corner.

    The **Mappings** dialog opens, showing tabs for the available ERP actors (such as Customer, Supplier, Contact, or Project).

1. Select the tab for the actor you want to configure.

1. Check **Sync ERP "\[actor\]" to SuperOffice "\[entity\]"** to enable synchronization.

1. For each ERP field in the list, specify:

    * **SuperOffice field:** Select which field in SuperOffice the ERP field should be mapped to.
    * **Direction:** Set the sync direction. Use **&gt;** for ERP to SuperOffice, **&lt;** for SuperOffice to ERP, or **&lt; &gt;** for bidirectional sync.

        Direction buttons have three states:
        * **Gray:** Disabled. You must select a SuperOffice field first.
        * **White:** Enabled, not selected.
        * **Blue:** Selected.

    * **Show in Search:** Check to display this field in search results.
    * **Show in ERP tab:** Check to display this field in the ERP tab in SuperOffice CRM (Company, Contact, and Project screen).

        If a field is synchronized, it is usually not necessary to show it in the **ERP** tab.

    ![Configure ERP field mapping -screenshot][img2]

1. Repeat these steps for other actors as needed.

1. Click **Done** when finished.

You can now continue with list mapping, default values, or ranking fields *or* activate the connection if no further configuration is needed.

## <a id="list-mapping"></a>List mapping

If you mapped any list fields, such as category or status, you must also map the individual list items between the ERP system and SuperOffice.

1. Select the ERP connection and click **List mapping** in the lower-left corner.

1. In the dialog, select a list. The corresponding ERP and CRM items are displayed.

    If no lists are available, check that the related fields were mapped in the **Field mapping** dialog.

1. For each ERP item, select the matching CRM item.

    Each ERP item can only be mapped to one CRM item. Duplicate mappings are shown in red. To leave an ERP item unmapped, select **(No Selection)**.

1. Repeat for all relevant lists.

1. Click **Save**, then activate the ERP connection if no further configuration is needed.

## <a id="defaults"></a>Default values for synchronization

Default values help reduce manual data entry for fields that typically have a fixed or predictable value. This is especially useful when importing large volumes of data or when users should not have to fill in the same value repeatedly or check a box that should always be checked.

1. Select the ERP connection and click **Defaults** in the lower-left corner.

1. In the dialog, select the tab for the actor you want to configure.

    ![Configure sync default values -screenshot][img3]

1. Click **Add** to define a new default. The **Add sync default value** dialog opens.

1. In the dialog:

    * **ERP field:** Select the field you want to define a default for.

    Then choose how this field should behave:

    * **Set default value:** Automatically apply a specific value during synchronization. This option requires you to enter a value.
    * **Ask user for value:** Allow the user to enter a value manually.
    * **Mandatory – User must fill in value:** Require that a value is provided. If this is selected, you must also choose one of the two options above.

    ![Add sync default value -screenshot][img4]

1. Click **OK** to save.

1. Repeat as needed to define more default values.

## <a id="rank"></a>Rank fields shown in the ERP tab

Set the order of fields shown in the **ERP** tab of the Company, Contact, and Project screens. All available fields are listed here, but only those marked for display will appear in the tab.

1. Select the ERP connection and click **Rank Fields** in the lower-left corner.

1. In the dialog, select the tab for the actor you want to configure.

    All available fields are listed, including those not shown in the **ERP** tab.

    ![Rank fields shown in the ERP tab -screenshot][img5]

1. Select a field and use <i class="ph ph-arrow-circle-up" aria-label="Arrow up"></i> <i class="ph ph-arrow-circle-down" aria-label="Arrow down"></i> to change its position in the list.

1. Repeat as needed for other actors.

1. Click **Done** to save your changes.

## <a id="priority"></a>Set sync priority

If multiple ERP connections are active at the same time, you can define which connection should take priority in case of heavy data traffic.

1. Click **Set Sync Priority** below the **ERP connections** list.

1. In the dialog, select a connection.

1. Use <i class="ph ph-arrow-circle-up" aria-label="Arrow up"></i> and <i class="ph ph-arrow-circle-down" aria-label="Arrow down"></i> to move the selected connection up or down in the list.

1. Click **Done** to save your changes.

## Troubleshooting

### Cannot activate ERP connection

If the ERP connection cannot be activated, check the field mapping:

* Mandatory fields must have a synchronization direction.
* Any configuration errors will trigger a descriptive error message.
* You must correct the issues before activating the connection.

### Sync direction buttons are not available

If the direction arrows remain dimmed even after selecting a SuperOffice field, it may be due to one of the following:

* The field cannot be synchronized (for example, an ID field or read-only data).
* The field is not valid for the selected ERP actor.

Hover over the arrow to see a tooltip explaining why it is unavailable.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../media/loc/en/erp/erp-connection-settings.png
[img2]: ../../../media/loc/en/erp/configure-field-mapping.png
[img3]: ../../../media/loc/en/erp/list-of-default-values.png
[img4]: ../../../media/loc/en/erp/add-sync-default-value.png
[img5]: ../../../media/loc/en/erp/rank-fields.png
