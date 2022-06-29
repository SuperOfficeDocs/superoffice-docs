---
uid: help-en-specifying-field-mapping
title: Specifying field mapping
description: Specifying field mapping
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Windows Client settings
so.topic: help
language: en
---

# Specify field mapping

To specify field mapping:

1. Open the **Import** screen.  
    <!-- Fix reuse ID=a1 -->
    Click the **Import** button in the Navigator ( ![icon](../media/Knapp_Import_liten.bmp) ).

2. Click ![icon](../media/Soek.bmp) next to the **Import file** field and select a file in the dialog which opens.

3. The contents of the first record in the import file are displayed in the **Field in file** column under **Field mapping**. Select a field you want to import into the database.

4. Click the **Map** button below **Field mapping**.

    > [!NOTE]
    > Alternatively double-click the field you want to import.

5. The name of the current field in the import file is displayed in **Field in import file** in the **Map field** dialog. In the **Select field from table** list box, choose the type of data you want to import into the SuperOffice database, e.g. companies.

6. In the **Name** table, all available fields for the data type you selected in the **Select field from table** list box are displayed, except those you have already mapped. Select a field to map.

7. Click **OK**. The information under **Field mapping** in the **Import** screen is updated.

8. Repeat the procedure to map additional fields. You can import several different data types. Remember that fields not mapped with a record in the SuperOffice database will not be imported at all.

> [!NOTE]
> If you have specified an import description file in the **Import description file** field, there may already be information in the **Field in SuperOffice CRM** column under **Field mapping**. If required, you can change this field mapping by deleting it (see [Delete field mapping](Deleting_field_mapping.md)) and then entering a new field mapping as described above.

The field mapping selections you make can be saved, so that the same configuration can be reused in future. This is what constitutes [Import descriptions](Import_descriptions.md).
