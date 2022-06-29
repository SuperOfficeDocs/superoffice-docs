---
uid: help-en-specifying-advanced-import-settings
title: Specifying advanced import settings
description: Specifying advanced import settings
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Windows Client settings
so.topic: help
language: en
---

# Specify advanced import settings

Advanced import settings include date format settings and delimiter characters. They are aimed at ensuring that SuperOffice interprets the import file correctly.

> [!NOTE]
> To be able to correctly map the fields from the import file, you may have to edit the settings for text qualifier, field delimiter and row delimiter.

To specify advanced import settings:

1. Open the **Import** screen.  
    <!-- Fix reuse ID=a1 -->
    Click the **Import** button in the Navigator ( ![icon](../media/Knapp-Import-liten.bmp) ).

2. Click ![icon](../media/Soek.bmp) next to the **Import file** field and select a data file in the dialog which opens.

3. Click the **Advanced** button. The **Advanced options** dialog opens.

4. In the **Date format** list box, choose from the predefined date formats. You cannot use month names, only numbers.

    > [!NOTE]
    > **Native ID** means a SuperOffice date. SuperOffice counts the seconds since 01.01.1970; it is this number which equates to **Native ID**.

5. In the **Number format** list box, choose from the predefined options for decimal separators.

6. In the **Checkbox format** field, type in the character/characters that are used in the import file to specify that a checkbox is selected.

7. In the **Text qualifier** field, type in the character used in the import file to enclose plain text.

    > [!NOTE]
    > Text qualifiers override any field and row delimiters (see below). This means, for example, that if there is a field delimiter between two text qualifiers, it is taken to be plain text. However, you do not need to use text qualifiers if your import files contain field or row delimiters.

8. In the **Field delimiter** list box, choose from the predefined options specifying which characters separate fields from each other.

9. In the **Row delimiter** list box, choose from the predefined options specifying which characters separate rows from each other.

10. In the **Associate format** list box, choose from the predefined formats specifying how names in the import file are to be interpreted, e.g. whether first names come before last names.

    > [!NOTE]
    > **Native ID** means the associate's **associate\-id**, as recorded in the database. If no such ID is found, the contents of the **Default associate** field are used.

11. In the **Default associate** list box, choose which name will be entered by default if the SuperOffice database is unable to interpret the associate format in the import file.

12. In the **Country format** list box, choose from the predefined formats specifying how countries will be interpreted, e.g. whether the country name is local or English.

    > [!NOTE]
    > **Native ID** means **country\-id**, as recorded in the database.

13. In the **Default country name** list box, choose which country will be entered if the SuperOffice database is unable to interpret the country format in the import file.

14. In the **Currency** list box, choose which currency will be entered if the SuperOffice database is unable to interpret the currency format in the import file.

15. Check **Update freetext index** if you want to update the freetext index continuously during the import, so that it is completely updated when the import is finished.

    > [!NOTE]
    > The import speed decreases if you check **Update freetext index**. If you want to import large quantities of data, an alternative is to run the import without checking this option and generate a new freetext index later from the **Options** screen. For more details, see [Regenerate a freetext index](../chap06/Regenerating-a-freetext-index.md).

16. When you have specified the required settings, click **OK**.

> [!NOTE]
> If you have specified an import description file in the **Import description file** field, information will already be entered in the **Advanced Options** dialog. However, you can change this information as described above. Remember that the import description file must be saved before it is updated with any new options.

The field mapping selections you make can be saved, so that the same setup can be reused in future. This is called an import description. See [Import descriptions](Import-descriptions.md).
