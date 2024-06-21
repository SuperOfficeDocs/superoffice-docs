---
uid: help-en-importing-files
title: Importing files
description: Importing files
author: SuperOffice RnD
date: 06.29.2022
keywords: Windows Client settings
topic: help
language: en
client: win
envir: onsite
---

# Import a data file to the SuperOffice database

After you have backed up the database file, found the right data file and placed it in a folder where you can easily find it again (see [Import routines][1]), you can start the import itself.

> [!NOTE]
> Some programs "lock" files they open so that other programs cannot access them. Before you begin the import, make sure that neither the import description file, nor the data file are open in any other program (such as Excel).

**Steps:**

<!-- markdownlint-disable-file MD029 -->
1. [!include[How to open import](includes/open-import.md)]

[!include[Import description](includes/step-import-description.md)]
<!-- Include covers steps 2-3. Next line MUST be 4. -->
4. After you choose an import description and the import file is found, the other fields are filled in automatically. Optionally, [edit any of the details in the import description][3].

5. It may be useful to check that the contents of the fields correctly match the fields you selected. The **Field in file** column under **Field mapping** shows the contents of the first record in the data file you are importing, while the **Field in SuperOffice CRM** column shows the fields in the SuperOffice database the data will be imported to. Click the **Next** button a few times to check the contents of some of the following records as well.

    > [!NOTE]
    > If the fields do not display as required, you must either amend the [field mapping][4] or make the necessary changes in the import file.

6. Click **Start** to start the import. A progress indicator is displayed at the bottom of the screen.

> [!NOTE]
> The time required to import the data from the import file into the SuperOffice database depends on the size of the database and the data connection (slow or fast connection to the database server). However, you can cancel the import at any time by clicking the **Stop** button on the right of the progress indicator.

<!-- Referenced links -->
[1]: import-routines.md
[3]: editing-import-descriptions.md
[4]: field-mapping.md

<!-- Referenced images -->
