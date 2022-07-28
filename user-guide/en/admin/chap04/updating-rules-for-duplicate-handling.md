---
uid: help-en-updating-rules-for-duplicate-handling
title: Updating rules for duplicate handling
description: Updating rules for duplicate handling
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Windows Client settings
so.topic: help
language: en
---

# Update rules for duplicate handling

You always need to specify rules for handling duplicates during importing. You do this as follows:

1. Open the **Import** screen.

    [!include[How to open import](../includes/open-import.md)]

2. Click ![icon][img1] next to the **Import description file** field and select an import description file in the dialog which opens. An import file and previously selected settings are inserted automatically.
    Or:
    Click ![icon][img1] next to the **Import file** field and select a data file in the dialog which opens. Then specify the field mapping (see [Field mapping][1]).

3. The contents of the **Table** column under **Handling of duplicates** are based on the specified field mapping.

4. Under **Handling of duplicates**, select the row to specify a duplicate handling rule for.

    > [!NOTE]
    > Which rows appear under **Handling of duplicates** depend on which fields you have chosen to import into. This cannot be changed and you need to specify duplicate handling rules for all the rows.

5. Click the **Update** button. The **Handle duplicates** dialog for the selected data type opens.

6. All available fields of the required data type for which you have defined field mappings are displayed under **When these fields match**. Check which field(s) must have identical contents in order for the record to be considered a duplicate. This is called an import key.

7. Under **Do the following**, choose what to do if duplicates are detected during the import:

    * **Update existing**: the values in the import file overwrite the values in the database. Choose this option if you consider that the information in the import file is more up-to-date than that already in the database.
    * **Update blanks only**: all new records are added, but for existing records only the empty fields are updated. Choose this option if you consider that the information in the database is more up-to-date than that in the import file.
    * **Skip record**: all new records are added, but those that already exist in the database are retained unchanged.

    > [!NOTE]
    > This is the default option for resetting the database, so that unwanted records are not imported with unfortunate consequences.

    * **Insert anyway**: all the fields in the import file are imported and no check is performed to see whether they already exist. This will be particularly relevant when you import into an empty database. You do not need to specify import keys for this option.

8. Click **OK**.

The field mapping selections you make can be saved, so that the same setup can be reused in future. This is called an import description. See [Import descriptions][2].

## What would you like to do now?

* [Reset rules for duplicate handling][3]

<!-- Referenced links -->
[1]: field-mapping.md
[2]: import-descriptions.md
[3]: resetting-rules-for-duplicate-handling.md

<!-- Referenced images -->
[img1]: ../../../media/icons/admin/soek.bmp
