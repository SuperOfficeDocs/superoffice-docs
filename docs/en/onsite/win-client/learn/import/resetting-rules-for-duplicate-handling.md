---
uid: help-en-resetting-rules-for-duplicate-handling
title: Resetting rules for duplicate handling
description: Resetting rules for duplicate handling
author: SuperOffice RnD
date: 06.29.2022
keywords: Windows Client settings
topic: help
language: en
client: win
envir: onsite
---

# Reset one or all rules for duplicate handling

1. [!include[How to open import](includes/open-import.md)]

2. Do one of the following:

    * Click ![icon][img1] next to the **Import description file** field and select an import description file in the dialog that opens. An import file and previously selected settings are inserted automatically.

    * [!include[Select file](includes/step-select-file.md)]
        Then specify the [field mapping][1]. The contents of the **Table** column under **Handling of duplicates** are based on the specified field mapping.

3. Choose one of the following:

    * Remove a single rule:

        1. Select the required row under **Handling of duplicates**.
        2. Click the **Reset** button. The selected row will then have nothing in the **Key** column, and the **Action** column will be changed to **Skip record**.

    * Remove all rules:

        1. Click the **Reset all** button below **Handling of duplicates**. All rows will then have nothing in the **Key** column and the **Action** column for each row will be changed to **Skip record**.

> [!NOTE]
> Unless you choose **Insert anyway** under **Do the following** in the **Handle Duplicates** dialog, you cannot import data without specifying rules for duplicate handling for all data types. This means that if you have reset rules, you must enter new ones before you start the import.

## What would you like to do now?

* [Update rules for duplicate handling][2]

<!-- Referenced links -->
[1]: field-mapping.md
[2]: updating-rules-for-duplicate-handling.md

<!-- Referenced images -->
[img1]: ../../../../../../common/icons/nav-admin-import-active.png
