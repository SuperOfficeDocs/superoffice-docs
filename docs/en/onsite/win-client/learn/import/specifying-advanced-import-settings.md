---
uid: help-en-specifying-advanced-import-settings
title: Specifying advanced import settings
description: Specifying advanced import settings
author: SuperOffice RnD
date: 06.29.2022
keywords: Windows Client settings
topic: help
language: en
client: win
envir: onsite
---

# Specify advanced import settings

Advanced import settings include date format settings and delimiter characters. They are aimed at ensuring that SuperOffice interprets the import file correctly.

> [!NOTE]
> To correctly map the fields from the import file, you may have to edit the settings for text qualifier, field delimiter and row delimiter.

1. [!include[How to open import](includes/open-import.md)]

1. [!include[Select file](includes/step-select-file.md)]

1. Click the **Advanced** button.

1. In the **Advanced options** dialog, choose a predefined format from the **Date format** list box. You cannot use month names, only numbers.

    > [!NOTE]
    > **Native ID** means a SuperOffice date. SuperOffice counts the seconds since 01.01.1970; it is this number which equates to **Native ID**.

1. In the **Number format** list box, choose from the predefined options for decimal separators.

1. In the **Checkbox format** field, type in the character/characters that are used in the import file to specify that a checkbox is selected.

1. In the **Text qualifier** field, type in the character used in the import file to enclose plain text.

    > [!NOTE]
    > Text qualifiers override any field and row delimiters (see below). For example, if there is a field delimiter between two text qualifiers, it is interpreted as plain text. However, you do not need to use text qualifiers if your import files contain field or row delimiters.

1. In the **Field delimiter** list box, choose from the predefined options specifying which characters separate fields from each other.

1. In the **Row delimiter** list box, choose from the predefined options specifying which characters separate rows from each other.

1. In the **Associate format** list box, choose from the predefined formats specifying how names in the import file are to be interpreted, for example, if first names come before last names.

    > [!NOTE]
    > **Native ID** means the associate's **associate_id**, as recorded in the database. If no such ID is found, the contents of the **Default associate** field are used.

1. In the **Default associate** list box, choose which name to enter by default if the SuperOffice database is unable to interpret the associate format in the import file.

1. In the **Country format** list box, choose from the predefined formats specifying how countries should be interpreted, for example, if the country name is local or English.

    > [!NOTE]
    > **Native ID** means **country_id**, as recorded in the database.

1. In the **Default country name** list box, choose which country to enter if the SuperOffice database is unable to interpret the country format in the import file.

1. In the **Currency** list box, choose which currency to enter if the SuperOffice database is unable to interpret the currency format in the import file.

1. Check **Update freetext index** to update the freetext index continuously during the import, so that it is completely updated when the import is finished.

    > [!NOTE]
    > The import speed decreases if you check **Update freetext index**. To import large quantities of data, an alternative is to run the import without checking this option and [generate a new freetext index][2] later from the **Options** screen.

1. After specifying the required settings, click **OK**.

    [!include[Save mapping](includes/tip-save-mapping.md)]

> [!NOTE]
> If you specified an import description file in the **Import description file** field, information will already be entered in the **Advanced Options** dialog. However, you can change this information as described above. Remember that the import description file must be saved before it is updated with any new options.

<!-- Referenced links -->
[2]: ../../../../admin/options/learn/freetext-search/regenerate-index.md

<!-- Referenced images -->
