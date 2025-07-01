---
title: Update an extra table
uid: update-extra-table
description: Update an extra table from the Customer Center
author: SuperOffice Product and Engineering
date: 03.16.2023
keywords: Customer Center, CEP
content_type: howto
audience: settings
deployment: onsite
---

# Update an extra table from the Customer Center

Writing to extra tables from the Customer center is done by using the parser functions extraTableUpdate and extraTableInsert. The functions take the table ID and the values to write as parameters. In addition `extraTableUpdate` takes the ID of the row that is to be updated.

## Example extraTableUpdate

`%extraTableUpdate("7").id("1").field("y_7.x_1=test").field("y_7.x_2=aValue")%`

This call will update the entry with ID 1 in extra-table 7. The field `x_1` will be set to "test", and `x_2` will be set to "aValue".

## Example extraTableInsert

`%extraTableInsert("1").field("y_1.x_3=10").field("y_1.x_4=2002-01-01")%`

This insert will add a new row in extra table 1. The field `x_3` will be set to 10 and the field `x_4` will get the value 2002-01-01.

To facilitate input from a form it will be appropriate to use a variable starting with an underscore (\_). Form values starting with an underscore will be forwarded to the next form.

The file *subscribe.html* can then handle the writing to the extra table: `%extraTableInsert("1").field("y_1.x_2=" + _email)%`. This will result in adding a new table to extra table 1, where the field `x_2` will be set to the value specified in the form.
