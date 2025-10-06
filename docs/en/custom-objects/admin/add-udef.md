---
uid: help-en-udef-add
title: Add user-defined field
description: How to add a user-defined field in Settings and maintenance
keywords: udef, user-defined field, custom field, field properties
author: Bergfrid Dias
date: 11.29.2024
version: 10
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
redirect_from: /en/custom-objects/learn/udef/add
index: true
---

# Add user-defined field

Watch this video to find out how you can create your own extra fields in SuperOffice CRM (video length - 2:51):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/SpeZVxpxeMM]

## Steps

1. [!include[Go to fields and select tab](includes/goto-fields.md)]

1. Click the **Add** button below the **Fields** list.

1. Enter a **Name** and select a [**Type**][2] (for example number, text, or date).

    Use a [language prefix](#language) to specify the name in multiple languages like this: `US:"Language";NO:"Språk"`

    ![UDEF field name in multiple languages -screenshot][img3]

1. Optionally set other [field properties](#properties), such as whether the field is mandatory or should be indexed.

1. When you are done, click **Save**. The dialog closes and the new field is displayed in the **Fields** list and in the grid.

1. [Optionally, adjust the position of the field][3]. This requires the Development Tools license!

1. Continue adding fields. Click **Publish** when you are done to make the field available to SuperOffice users. Unpublished fields and fields with unpublished changes are displayed in bold text in the **Fields** list.

## <a id="properties"></a>Field properties

| Property | Description |
|---|---|
| Default value | The value to be inserted by default in this field. |
| Tooltip | A brief description appearing when hovering over the field. For example, usage information. |
| Prog ID | A default ID for this field. The format is **text:number**. Keep the text portion to letters a-z or their uppercase equivalents. Can be overridden by SuperOffice partners. |
| Mandatory | Makes it mandatory to fill in this field. Does not apply to the *Checkbox* field type. |
| Hide label | If selected, the name of the field is not displayed. |
| Read only | If selected, it is not possible to amend the field. |
| Indexed | If selected, this field becomes searchable, speeding up **Find**. Non-indexed fields can also be searched, but it is slower. Index only fields that are often searched and hold commonly used data. |

> [!NOTE]
> You cannot check **Read only** if you checked **Mandatory**. These options are mutually exclusive.

## <a id="language"></a>Language codes

[!include[Language codes](../../globalization-and-localization/includes/table-legacy-language-codes.md)]

## Where will the fields I create be displayed?

User-defined fields you create will appear in the [More tab][5] for Companies, Contacts, Sales, and Projects, as well as in the Follow-up and Document dialogs.

In the lower right of the **Fields** dialog is the **Template variable name** followed by a code (ID), which can be used to reuse the information you enter in this field, for example, as [template variables][12] in documents and emails.

## Troubleshooting

### I cannot create a new field

If you find you are not allowed to create a new field, this may be because you have already reached the [maximum number of permitted fields][1] of this type. You must then delete an existing field before you can insert a new one.

Four of each type of field (Short text, Long text, Number, Decimal) are searchable. For example, if you do not mark any fields searchable, you can specify only six Decimal fields.

## Related topics

* [Place fields][3]
* [Edit field properties][4]
* [Screen designer][11]

<!-- Referenced links -->
[1]: ../learn/udef.md#limit
[2]: ../learn/udef.md#field-types
[3]: edit-udef-layout.md
[4]: edit-udef.md
[5]: ../learn/more-tab.md
[11]: ../../customization/screen-designer/admin/index.md
[12]: ../../document/templates/learn/template-variables.md

<!-- Referenced links -->
[img3]: ../../../media/loc/en/custom-objects/add-udef-multi-languages.png
