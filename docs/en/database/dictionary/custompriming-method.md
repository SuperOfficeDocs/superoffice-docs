---
title: CustomPriming method
uid: custompriming_method
description: CustomPriming method
author: Tony Yates
date: 06.23.2017
keywords: database
topic: concept
# Optional fields. Don't forget to remove # if you need a field.
# envir:
# client:
---

# CustomPriming method

`CustomPriming` is the third and final method executed during the DictionaryStep pipeline, and is used to make data transformations that are not otherwise supported. To support complex data transformation, the base class exposes two helper methods to perform SQL actions towards the database: `ExecuteSql` and `ExecuteSelect`.

## ExecuteSql method

While you really should use Imp files for the bulk of priming data, `CustomPriming` is used for circumstances when you need to perform raw SQL towards existing tables. In those cases, `ExecuteSql` is there to help execute non-select SQL statements.

Let’s begin with a simple Insert statement example.

In the following code, two datetime variables are declared for use as parameters to the `Insert` statement. Then the `ExecuteSql` method is invoked with two parameters: the SQL statement performing the INSERT, and then the anonymous type containing the parameter values.

[!code-csharp[CS](includes/custom-priming.cs)]

There are three representations of curly braces used to define the table, fields and values:

* {abc} means "table abc";
* {abc.xyz} means "field xyz of table abc",
* {@foobar} means "parameterized value foobar", and named the same as the property in the anonymous parameter class.

Continuous Database will look up the table and field names, do quoting and case conversion, and anything else that might be needed to make valid SQL, and then properly encode the parameters.

> [!WARNING]
> **Please always use parameterized values**. Doing so avoids two major hazards: formatting problems (particularly dates!) and the possibility of SQL injection. As a rule, a dictionary step should never depend on externally supplied values, but even an update from one field to another that does not use parameterization could still expose us to SQL injection from values latent in the database. **There is no excuse for SQL injection caused by lack of parameterization**.

### GetNextId

A handy helper method `GetNextId`('tableName') is useful when you want to get a table's next ID value from the `sequence` table.

[!code-csharp[CS](includes/cp-getnextid.cs)]

### Get next ID from sequence table automatically

Another useful trick is to use **$nextId** to automatically obtain the next ID value from the `sequence` table.

[!code-csharp[CS](includes/cp-getnextid-auto.cs)]

### Use explicit types as parameters

The following example demonstrates how to use **explicit types** as parameters. This is a convenient way to bundle all the parameters in a predefined way that can be used by multiple DictionarySteps.

The explicit type can use public or private fields or properties that map to parameters. The casing of the fields or properties **is case-sensitive**.

`ExplicitParameters` is a class that contains 5 fields:

[!code-csharp[CS](includes/cp-explicitparams.cs?range=1-8)]

All fields in this example are pre-populated except ID. In that case, the field is populated in the constructor of the class as seen in the following example.

[!code-csharp[CS](includes/cp-explicitparams.cs?range=10-34)]

> [!NOTE]
> Remember that a **DictionaryStep assembly should be self-contained**, with no external referenced dependencies. Therefore, do not place explicit type for SQL parameters in external libraries.

One more common scenario is when new columns are introduced and the pre-existing data must be migrated or transformed in some way.

### Transfer data from old to new field

The following code snippet is an example of a new field added to an existing table. Then the CustomPriming method executes an UPDATE statement that transfers the data from the old field into the new field and sets the updated field.

[!code-csharp[CS](includes/cp-transfer.cs)]

`ExecuteSql` is a great way to migrate data when the data is known. However, for scenarios when you don’t know the data or the needed data is in the database, you use `ExecuteSelect`.

## ExecuteSelect method

When there is data in the database that needs to be obtained during the DictionaryStep pipeline, `ExecuteSelect` is there to execute a query and return the result in a DataTable. `ExecuteSelect` accepts two parameters: the SQL statement to execute, and optional parameters. It returns a standard `DataTable` object that is disconnected from the database.

A useful place for `ExecuteSelect` is in the `ImpFileName` method, to first check if priming data exists, and potentially only set it by returning the name of the imp file if the tables don’t contain any data.

[!code-csharp[CS](includes/cp-executeselect.cs)]

The formatting of the SQL statements must use the same structure as the `ExecuteSql` method. When query criteria parameters are needed, use the second parameter to pass in an explicit or anonymous type with the fields or properties that contain the values.

```csharp
var sql = @"SELECT {abc.abc_id} FROM {abc} WHERE {abc.abc_id} = {@criteria}";
var abcData = ExecuteSelect(sql, new { criteria = 123 });
```
