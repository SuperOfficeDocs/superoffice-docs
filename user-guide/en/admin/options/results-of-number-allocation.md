---
uid: help-en-results-of-number-allocation
title: Results of number allocation
description: Results of number allocation
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Results of number allocations

The table below shows the consequences of different combinations of the values **Allocate** (A), **Unique** (U), **Read only** (R) and **Allow empty/blank** (B) in practice:

| A | U | R | B | Result |
|:-:|:-:|:-:|:-:|---|
|  | | | | Users can enter what they want. |
| x | | | | A number is allocated which the user can change. |
| x | x | | | A number is allocated which the user can change to a unique value. The database can only have one empty field. |
| x | x | x | | A number is allocated which the user cannot change. |
| x | x | x | x | A number is allocated which the user cannot change. |
| x | x | | x | A number is allocated which the user can change to a unique value or remove. The database can have unlimited empty fields. |
| x | | x | | A number is allocated which the user cannot change. If any external processes change the number, no check is performed as to whether the new number is unique. |
| | x | | | No number is allocated. The user can specify a number, but it must be unique. The database can only have one empty field. |
| | x | | x | No number is allocated. The user can specify a number, but it must be unique. The database can have unlimited empty fields. |
| | | x | x | No number is allocated, nor may the user specify a number. Useful when using counters from third party suppliers. |
| | | x | | No number is allocated, nor may the user specify a number. The database can only have one empty field. (Not recommended.) |
