---
title: cs_soap_ports_ticket_queryextratable
description: Services SOAP interface ticket reference queryExtraTable
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# queryExtraTable

## Description

Requests information from an extra table. This is done by setting one or more criteria based on the columns in the extra table. For instance, retrieve every row where the second column is larger than the value 5.

You input a list of columns you wish to retrieve. If any of these columns are references to other tables (extra tables or ordinary tables) two columns are returned. One with the value of the column (the foreign reference number), and one with the value of the destination row. The latter is indicated by a trailing "(value)" in the returned column name.

If you want to use the ID of the extra table in any of the parameters, use -1 as the column number.

> [!NOTE]
> Since the criteria are connected by a logical operator, but stored in a one-dimensional structure (without parentheses) the result might be surprising if the criteria are complex.

The logical operator is of course ignored if you apply only one criterion. The criteria operator can be one of:

* OperatorContains
* OperatorBeginsWith
* OperatorEquals
* OperatorGt
* OperatorLt
* OperatorGte
* OperatorLte
* OperatorNotEquals
* OperatorIn

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| tableId | The ID of the extra table |
| fields | A list of returned columns (extra field ID). -1 indicates the ID of the row. |
| criterias | A list of criteria structs |
| orderByField | Which field the result set should be sorted by (extra field ID) |
| maxEntries | Number of maximum returned entries |
| ascending | True if you wish the returned set to be ordered ascending, false if you require descending. |

| Criteria strutct member | Description |
|---|---|
| columnId | The extra field ID |
| op | The operator (see above) |
| value | The value |
| logicalOp | A logical operator. Can be "and" or "or" |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| rows | A two-dimensional array of columns<br>columnId (An increasing number from 0 to the number of columns)<br>extraFieldId (The id of the extra field stored in this column)<br>name (The name of this column/extra field)<br>value |

## Example

```csharp
ticket.ticketService ticketService = new ticket.ticketService();
string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0")
{
  string[] extraTableFields = new string[2];

  extraTableFields[0] = "4";
  extraTableFields[1] = "5";

  ticket.ExtraTableCriteriaStruct[] criterias = new ticket.ExtraTableCriteriaStruct[1];

  criterias[0] = new ticket.ExtraTableCriteriaStruct();
  criterias[0].columnId = "8"; // extra field with id 8
  criterias[0].op = "OperatorEquals";
  criterias[0].value = "100";  //return all rows with x\_8 = 100
  criterias[0].maxEntries = "1000"; //truncate rows after 1000
  criterias[0].logicalOp = "and" //not needed, but set anyway

  ticket.ExtraTableRowStruct[] result;

  ticket.queryExtraTable(sessionKey,"1",extraTableFields,
    criterias,
    "4",    //order by x_4
    "true", //ascending
    out result);

  foreach(i ticket.ExtraTableRowStruct in result)
  {
    foreach(i2 ticket.ExtraTableColumnStruct in i.columns)
    {
      cout << "name:" << i2.name << " value:" << i2.value << endl;
    }
  }
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
