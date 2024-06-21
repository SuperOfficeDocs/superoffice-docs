---
title: IMP file format
uid: imp_file_format
description: IMP file format
author: Tony Yates
date: 06.23.2017
keywords: database
topic: reference
---

# IMP file format

Imp files are **tab-delimited** data files used to populate tables with priming data. There are several configuration options that partners can leverage to control priming data in their applications. These files are conceptually broken into two components: a header section and a data section.

```text
Line 1:  ;This is a comment line, describe your table, intentions, etc.
Line 2:  [UnoRoom]
Line 3:  Truncate_Table
Line 4:  ;room_id nam creatr Registered regby updated updatedby updated count
Line 5:  0      Room1   0         0       0      0         0       0      0
Line 6:  0      Room2   0         0       0      0         0       0      0
Line 7:  0      Room3
Line 8:  0      Room4   0         0       0      0         0       0      0
Line 9:  0      Room5
```

## Header section

The header section contains the table element and optional functions that perform operations such as truncate a table or field. Header elements you are likely to see in IMP files are:

| Header item | Function description |
|---|---|
| `[TABLENAME]` | Table declaration before all functions and data lines. |
| `TRUNCATE_TABLE` | Removes all rows from a table. |
| `TRUNCATE_FIELD` | Removes specific rows from a table. |
| `SET_AUTODATEUPDATE_OFF` | Turns off setting date-time to fields named `registered`. |
| `SET_BUILTIN` | Turns on setting fields named `builtin` to 1. |

Except for a comment line, which is a line that begins with a semi-colon, the table name must always be declared first.

Header elements you are likely to use in your IMP files are:

* `[TABLENAME]`
* `TRUNCATE_TABLE`
* `TRUNCATE_FIELD`

Other functions in the table above are primarily reserved for default priming data used during SuperOffice installations and upgrades.

## Truncate functions

In cases where you need to truncate an entire table or just certain rows, IMP files support:

* `TRUNCATE_TABLE`
* `TRUNCATE_FIELD`

Both functions will apply to the previously declared table. For example:

```text
[abc]
Truncate_Table
```

`Truncate_Table` will delete all rows in the table named **abc**. This directly translates into the SQL statement:

```SQL
TRUNCATE TABLE 'abc';
```

When `Truncate_Field` is used, it only deletes the row where the criteria match. The format is a tab-delimited line in the IMP file that defines the table on a line followed by the function and then the parameters.

```text
[Table]
Truncate_Field \t columnName \t ColumnValue
```

A demonstration of how that looks is seen in this example:

```text
[abc]
truncate_field  xyz  2
```

This translates into the following SQL statement:

```SQL
DELETE FROM abc WHERE abc.xyz = 2;
```

Multiple calls to the same function must be specified on a new line.

```text
[Table]
truncate_field  columnName  2
truncate_field  columnName  10
truncate_field  columnName  12
```

### Other truncate functions used exclusively used by SuperOffice

TRUNCATE\_BUILTIN

```SQL
DELETE FROM TableName WHERE TableName.isBuiltIn = 1
```

TRUNCATE\_BUILTIN\_FIELD

```SQL
DELETE FROM TableName
WHERE TableName.FieldName = ColumnValue AND TableName.isBuiltIn = 1
```

## Data section

Below is a simple IMP file that contains a table named `UnoRoom`.

* The first line is a comment, followed by the table declaration in square brackets.
* The `truncate_table` function on Line 3 is an instruction to the priming engine to truncate the existing table before importing the following data.
* Line 4 is another comment line that describes the table structure.
* Lines 5 through 9 are the actual row data that is imported into the `UnoRoom` table.

The first column of row data lines beginning with 0 instruct the priming engine to automatically generate the sequence id values and insert them.

Columns called *registered* are by default auto-populated with the current datetime, however, this can be switched off with the `SET_AUTODATEUPDATE_OFF` function.

```text
Line 1:  ;This is a comment line, describe your table, intentions, etc.
Line 2:  [UnoRoom]
Line 3:  Truncate_Table
Line 4:  ;room_id nam creatr Registered regby updated updatedby updated count
Line 5:  0      Room1   0         0       0      0         0       0      0
Line 6:  0      Room2   0         0       0      0         0       0      0
Line 7:  0      Room3
Line 8:  0      Room4   0         0       0      0         0       0      0
Line 9:  0      Room5
```

While you can let the priming engine automatically assign ID values, there may be cases where it’s preferred to hard-code the ID values instead. In that case, you could simply type the desired ID values directly inline. The ID values do not have to be in an ordered sequence.

Also, notice how lines 7 and 9 contain tab-delimited null values. This is completely legal and the priming engine will insert default values based on the field data type.

```text
Line 1:  ;This is a comment line, describe your table, intentions, etc.
Line 2:  [UnoRoom]
Line 3:  ;room_id nm creatr Registered regby updated updatedby updated count
Line 4:  0      Room1   0         0       0      0         0       0      0
Line 5:  0      Room2   0         0       0      0         0       0      0
Line 6:  0      Room3   0         0       0      0         0       0      0
Line 7:  0      Room4   0         0       0      0         0       0      0
Line 8:  0      Room5   0         0       0      0         0       0      0
```

In the simple example above, the column data will be imported into the `UnoRoom` table, and the rows are assigned the ID values defined inline.

This is useful when you need to reference these rows by ID in other IMP files. Below is an example that does just that – it hard codes the ID values defined in the room IMP file above.

```text
Line 1:  [UnoGroup]
Line 2:  ;group_id nm rm_id Registered regby updated updatedby updated count
Line 3:  0        Grp1   1       0       0       0        0        0     0
Line 4:  0        Grp2   1       0       0       0        0        0     0
Line 5:  0        Grp3   2       0       0       0        0        0     0
Line 6:  0        Grp4   2       0       0       0        0        0     0
Line 7:  0        Grp5   3       0       0       0        0        0     0
```

## Variables

There are additional options for handling ID referencing cases using variables declared with the pound symbol (#).

The following IMP files declare three tables: `unogroup`, `unoroom` and a relations table called `unogrouprooms`. Both the group and room table use variables in place of assigned id values, and then the grouprooms table uses the variables to populate the table with their actual values.

```text
Line 1:  [UnoGroup]
Line 2:  ;group_id name Registered regby  updated updatedby updated count
Line 3:  #GRP1     Grp1      0       0        0       0        0      0
Line 4:  #GRP2     Grp2      0       0        0       0        0      0
Line 5:  #GRP3     Grp3      0       0        0       0        0      0
Line 6:  #GRP4     Grp4      0       0        0       0        0      0
Line 7:  #GRP5     Grp5      0       0        0       0        0      0

Line 1:  [UnoRoom]
Line 2:  ;rm_id nm  creatr Registered regby updated  updatedby updated count
Line 3:  #RM1   Room1  0        0       0      0         0         0     0
Line 4:  #RM2   Room2  0        0       0      0         0         0     0
Line 5:  #RM3   Room3  0        0       0      0         0         0     0
Line 6:  #RM4   Room4  0        0       0      0         0         0     0
Line 7:  #RM5   Room5  0        0       0      0         0         0     0

Line 1:  [UnoGroupRooms]
Line 2:  ;grouproom_id group_id room_id
Line 3:  0               #GRP1    #RM1
Line 4:  0               #GRP2    #RM2
Line 5:  0               #GRP3    #RM3
Line 6:  0               #GRP4    #RM4
Line 7:  0               #GRP5    #RM5
```

It’s important to note that variables must be declared and resolved before they can be referenced. While primarily for referencing primary keys, they can also be used to reference foreign key columns of type int, short, and long.
