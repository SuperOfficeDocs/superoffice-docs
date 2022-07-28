---
uid: help-en-adding-fields
title: Adding fields web
description: Adding fields web
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Add fields

To add a new user-defined field:

1. Open the **Fields** screen.

2. Go to the required tab: **Company**, **Contact**, **Project,** **Sale**, **Follow-up** or **Document**.

3. Click the **Add** button below the **Fields** list.

4. Type the required name into the **Name** field.

5. In the **Type** list box, select the type of field you wish to add (e.g. number, text or date).

    [!include[List of field types](../includes/field-types.md)]

6. In the **Default value** field, enter the value to be inserted by default in this field.

7. In the **Tooltip** field, type in a brief description to pop up when the mouse pointer is held over the field. This could be a description with information for the users who will use this field.

8. The **Prog ID** field contains a default ID for this field. The prog ID can be overridden by our partners, for better connection with partner applications. Instead of changing their code, they can write in a more logical name or a specific ID for a user-defined fields (UDEF).

9. Check **Mandatory** if you want it to be mandatory to fill in this field.

    > [!NOTE]
    > This does not apply to the **Checkbox** field type.

10. Check **Hide label** if you do not want the name of the field to be displayed.

11. Check **Read only** if you do not want it to be possible to amend the field.

    > [!NOTE]
    > You cannot check **Read only** if you have checked **Mandatory**. These options are mutually exclusive.

12. Check **Indexed** if you want it to be possible to search by this field. <!-- Fix reuse ID=a1 -->
    The benefit of choosing **Indexed** is that it will be quicker to search on these fields using **Find**, for example. Non-indexed fields are also searchable, but the search takes longer. You should only index fields which are frequently searched and contain frequently used data.

13. When you have specified the required settings, click **Save**. The dialog box will close and the new field will be displayed in the **Fields** list and in the grid.

> [!TIP]
> In the bottom right of the **Fields** dialog is the **Template variable name** followed by a code. This is the "ID" of the field you are creating and can be used to reuse the information you enter in this field, e.g. in documents and e-mails. For more information, see [Template variables][2].

1. Adjust the position of the field as described in [Place fields][3].
2. Click **Publish** if you want the field to be available to SuperOffice CRM users. Unpublished fields ( ![icon][img1] ) and fields with unpublished changes ( ![icon][img2] ) are displayed in bold text in the **Fields** list.

If you find you are not allowed to create a new field, this may be because you have already reached the maximum number of permitted fields of this type (see [Maximum number of fields][1]). You must then delete an existing field before you can insert a new one. Note also that four of each type of field (Short text, Long text, Number, Decimal) are searchable. This means that if you do not specify that some of the fields are to be searchable, you will only be able to specify for example six Decimal fields.

## Related topics

* [Place fields][3]
* [Edit fields][4]
* [Edit the TAB order of fields][5]
* [Maximum number of fields][1]

<!-- Referenced links -->
[1]: ../chap09/maximum-number-of-fields.md
[2]: ../../user/diary/template-variables.md
[3]: moving-fields.md
[4]: editing-fields.md
[5]: editing-tab-order-of-fields.md

<!-- Referenced links -->
[img1]: ../../../media/icons/admin/fields-unpubl-new.png
[img2]: ../../../media/icons/admin/fields-unpubl-changed.png
