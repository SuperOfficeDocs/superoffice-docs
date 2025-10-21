---
uid: help-en-number-allocation-configure
title: Specifying number allocation
description: Specifying number allocation
keywords: number allocation, counter, company number
author: digitaldiina
date: 10.21.2025
version: 11.5
content_type: howto
category: Settings and maintenance
topic: options
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: 
  - /en/admin/options/learn/number-allocation/index
  - /en/admin/options/learn/number-allocation/configure
language: en
---

# Specifying number allocation

The way a counter works is to increase the value of the field by 1 each time a new instance of it is used. For example, if the first company you create in the database is allocated the value 10001 in the **Number** field, then the nineteenth company is allocated the value **10019**.

Counters can apply to the following fields:

* **Number** fields in the Company screen, the Project screen, the Sale screen, and the Contact screen.

* The **Our Ref.** field in the **Document** dialog if it is defined for the relevant template.

* Counters from third party suppliers can also be used.

In the top part of the **Number allocation** tab is a table showing the defined counters.

## Specify number allocation for field

1. Go to Settings and maintenance and select <i class="ph ph-sliders-horizontal" aria-hidden="true"></i> **Options**.

2. Select the **Number allocation** tab.

3. Double-click the required counter in the table. A dialog for the selected counter opens.

4. Check **Unique** if you want the counter values in the **Number**. field to be unique. Useful when SuperOffice CRM users allocate values themselves.

5. Check **Allow blank** to permit empty counter fields. Useful when the counter values must be unique. If **Allow blank** is checked, this means that the requirement for unique values does not apply to empty fields.

6. Check **Read only** if you do not want SuperOffice CRM users to type values into the **Number** field themselves.

7. Check **Allocate** to use the automatic counter function, so that the system enters values in the **Number** field for you.

8. The **Next number** field displays the next number to be used. You can change this value if required.

9. Click **Save**.

## Columns

| Column | Description |
|---|---|
| \[Icon\] | Shows where the counter is used, for example, <i class="ph ph-buildings" aria-label="Company icon"></i> for the Company screen. |
| Counter | Shows the name of the counter, for example, **Company number**, which applies to the **Number** field in the Company screen. |
| Next | Shows the next value for the counter. |
| Allocate | Specifies if the automatic counter function is used, so that the system enters values for you. |
| Unique | Specifies if the counter values must be unique. Useful when users allocate values themselves. |
| Read only | Specifies whether users can type values into the counter fields themselves. |
| Allow blank | Specifies if an empty counter field is a permitted value. Useful when the counter values must be unique. If **Allow blank** is checked, this means that the requirement for unique values does not apply to empty fields. |
| Last used | Shows when the counter field was last used. |
| By - User ID | Shows who last used the counter field. |
| By - Portrait | Shows a thumbnail image of the user who last used the counter field. |

## Results of number allocations

The table below shows the consequences of different combinations of the values **Allocate** (A), **Unique** (U), **Read only** (R), and **Allow empty/blank** (B) in practice:

| A | U | R | B | Result |
|:-:|:-:|:-:|:-:|---|
| | | | | Users can enter what they want. |
| x | | | | A number is allocated which the user can change. |
| x | x | | | A number is allocated which the user can change to a unique value. The database can have only one empty field. |
| x | x | x | | A number is allocated which the user cannot change. |
| x | x | x | x | A number is allocated which the user cannot change. |
| x | x | | x | A number is allocated which the user can change to a unique value or remove. The database can have unlimited empty fields. |
| x | | x | | A number is allocated which the user cannot change. If any external processes change the number, uniqueness is not checked. |
| | x | | | No number is allocated. The user can specify a number, but it must be unique. The database can have only one empty field. |
| | x | | x | No number is allocated. The user can specify a number, but it must be unique. The database can have unlimited empty fields. |
| | | x | x | No number is allocated, nor may the user specify a number. Useful when using counters from third party suppliers. |
| | | x | | No number is allocated, nor may the user specify a number. The database can have only one empty field. (Not recommended.) |

## Related content

* [Specify default values for new document templates][3]

<!-- Referenced links -->
[3]: ../../document/templates/admin/document-template-defaults.md
