---
uid: help-en-number-allocation
title: Number allocation
description: Number allocation
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Number allocation

You can define settings for counters in the **Number allocation** tab. In SuperOffice CRM, counters can apply to the following fields:

* **Number** fields in the Company screen, the Project screen, the Sale screen and the Contact screen.

* The **Our Ref.** field in the Document screen if it is defined for the relevant template.

* Counters from third party suppliers can also be used.

The way a counter works is to increase the value of the field by 1 each time a new instance of it is used. For example, if the first company you create in the database is allocated the value 10001 in the **Number** field, then the nineteenth company is allocated the value **10019**.

## Results of number allocations

The table below shows the consequences of different combinations of the values **Allocate** (A), **Unique** (U), **Read only** (R) and **Allow empty/blank** (B) in practice:

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

## What would you like to do now?

* [View number allocation][1]
* [Specify number allocation][2]
* [Specify default values for new document templates][3]

<!-- Referenced links -->
[1]: viewing-number-allocation.md
[2]: specifying-number-allocation.md
[3]: document-template-defaults.md

<!-- Referenced images -->
