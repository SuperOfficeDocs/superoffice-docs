---
uid: help-en-udef-add
title: Add user-defined field
description: How to add a user-defined field in Settings and maintenance
author: SuperOffice RnD
so.date: 02.23.2023
keywords: udef, user-defined, custom field
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Add user-defined field

Watch this video to find out how you can create your own extra fields in SuperOffice CRM (video length - 2:51):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/SpeZVxpxeMM]

## Steps

1. [!include[Go to fields and select tab](includes/goto-fields.md)]

1. Click the **Add** button below the **Fields** list.

1. Type the required name into the **Name** field.

1. In the **Type** list box, select the [type of field][6] you wish to add (for example number, text, or date).

1. In the **Default value** field, enter the value to be inserted by default in this field.

1. In the **Tooltip** field, type in a brief description to pop up when the mouse pointer is held over the field. This could be a description with information for the users who will use this field.

1. The **Prog ID** field contains a default ID for this field. The prog ID can be overridden by our partners, for better connection with partner applications. Instead of changing their code, they can write in a more logical name or a specific ID for a user-defined fields (UDEF).

1. Check **Mandatory** if you want it to be mandatory to fill in this field.

    > [!NOTE]
    > This does not apply to the **Checkbox** field type.

1. Check **Hide label** if you do not want the name of the field to be displayed.

1. Check **Read only** if you do not want it to be possible to amend the field.

    > [!NOTE]
    > You cannot check **Read only** if you checked **Mandatory**. These options are mutually exclusive.

1. Check **Indexed** if you want it to be possible to search by this field.

1. When you have specified the required settings, click **Save**. The dialog will close and the new field is displayed in the **Fields** list and in the grid.

    > [!TIP]
    > In the lower right of the **Fields** dialog is the **Template variable name** followed by a code (ID), which can be used to reuse the information you enter in this field, for example, as [template variables][2] in documents and emails.

1. [Adjust the position of the field][3].

1. Click **Publish** if you want the field to be available to SuperOffice CRM users. Unpublished fields ![icon][img1] and fields with unpublished changes ![icon][img2] are displayed in bold text in the **Fields** list.

## Why is it a good idea to index?

Choosing **Indexed** makes it quicker to search on these fields using **Find**. Non-indexed fields are also searchable, but the search takes longer. You should only index fields that are frequently searched and contain frequently used data.

## Troubleshooting

### I cannot create a new field

If you find you are not allowed to create a new field, this may be because you have already reached the [maximum number of permitted fields][1] of this type. You must then delete an existing field before you can insert a new one.

Four of each type of field (Short text, Long text, Number, Decimal) are searchable. For example, if you do not mark any fields searchable, you can specify only six Decimal fields.

## Related topics

* [Place fields][3]
* [Edit fields][4]
* [Edit the TAB order of fields][5]
* [Maximum number of fields][1]
* [Screen designer][7]

<!-- Referenced links -->
[1]: limitations.md
[2]: ../../document/learn/template-variables.md
[3]: move.md
[4]: edit.md
[5]: change-tab-order.md
[6]: index.md#field-types
[7]: ../../ui/screen-designer/learn/index.md

<!-- Referenced links -->
[img1]: ../../../media/icons/admin/fields-unpublish-new.png
[img2]: ../../../media/icons/admin/fields-unpublish-changed.png
