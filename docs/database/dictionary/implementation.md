---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: cdd_implementation       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Continuous database implementation # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:           # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Implementation overview

***Structure*** is where all database table, field, and index changes must be made. There are several intuitive methods in the base class to make such actions easy and are explored more thoroughly in the next section.

Once a table is created, and populating the table with priming data is desired, the class need only implement `ImpFieldNames`. ImpFieldNames returns a list of IMP file names to the Continuous Database library which iterates over the list and begins to import data.

When more flexibility is required, such as calculated fields or transforming data from existing tables, the dictionary step should override the `CustomPriming` method.

Methods declared in the base class, `ExecuteSelect` and `ExecuteSql`, can issue SQL statements to the database to performing queries or perform actions, respectively. However, these methods should be used sparingly. Issuing SQL statements using these methods is covered in a later section.

Finally, it’s important to understand that all schema changes should be done in a small, compact and isolated manner. Changes should be done in such a way that make it easy to understand and manage. Evolutionary database design benefits from small incremental changes.

Once a dictionary step is committed to the database, it is final. It cannot be undone. The only way to change the last dictionary step is to create a new dictionary step that makes yet another change to the database!

## Structure method

Changing the database schema is facilitated by three methods in the base class:

* CreateTable
* DropTable
* ModifyTable

Each method is a fluent interface, and therefore easy-to-read and easy-to-use. This simple example illustrates this point:

[!code-csharp[CS](includes/structure.cs)]

Each fluent method expects a minimal set of required parameters while permitting several named parameters to override field defaults, such as *notNull: false*.

In addition to fluent methods for tables, there are fluent methods that make it easy to add and modify fields of all supported field types. There are also handy **macro** methods to create common field patterns, such as `AddRegisteredUpdate()`.

`AddRegisteredUpdated` adds five fields, all with standard settings.

* `registered`
* `registered_associate_id`
* `updated`
* `updated_associate_id`
* `updatedCount`

## ImpFileNames method

IMP files are a means to populate a table with priming data once the DictionaryStep has completed performing any schema changes defined the `Structure` method. The sole purpose of `ImpFileNames()` is to return a list of filenames containing data that Continuous Database will discover and import.

**CDD ImpFileNames:**

```csharp
public override List<string> ImpFileNames()
{
  // these are the .IMP files
  return new List<string>
  {
    @"I_ChatRoom.imp",
  };
}
```

Dictionary steps can provide IMP files is one of two ways:

* As a physical file located in the same location as the executing assembly.
* As an embedded resource in the same assembly as the DictionaryStep.

## CustomPriming method

`CustomPriming` is the third and final method executed during the DictionaryStep pipeline, and is used to make data transformations that are not otherwise supported. To support complex data transformation, the base class exposes two helper methods to perform SQL actions towards the database: `ExecuteSql` and `ExecuteSelect`.

### ExecuteSql method

While you really should use Imp files for the bulk of priming data, `CustomPriming` is used for circumstances when you need to perform raw SQL towards existing tables. In those cases, `ExecuteSql` is there to help execute non-select SQL statements.

[!code-csharp[CS](includes/custom-priming.cs)]

There are three representations of curly braces used to define the table, fields and values:

* {abc} means "table abc";
* {abc.xyz} means "field xyz of table abc",
* {@foobar} means "parameterized value foobar", and named the same as the property in the anonymous parameter class.

Continuous Database will look up the table and field names, do quoting and case conversion, and anything else that might be needed to make valid SQL, and then properly encode the parameters.

> [!WARNING]
> **Please always use parameterized values**. Doing so avoids two major hazards: formatting problems (particularly dates!) and the possibility of SQL injection. As a rule, a dictionary step should never depend on externally supplied values, but even an update from one field to another that does not use parameterization could still expose us to SQL injection from values latent in the database. **There is no excuse for SQL injection caused by lack of parameterization**.

### ExecuteSelect method

When there is data in the database that needs to be obtained during the DictionaryStep pipeline, `ExecuteSelect` is there to execute a query and return the result in a DataTable. `ExecuteSelect` accepts two parameters: the SQL statement to execute, and optional parameters. It returns a standard `DataTable` object that is disconnected from the database.

A useful place for `ExecuteSelect` is in the `ImpFileName` method, to first check if priming data exists, and potentially only set it by returning the name of the imp file if the tables doesn’t contain any data.

**CDD ExecuteSelect:**

```cs
public override List<string> ImpFileNames()
{
  var abcData = ExecuteSelect(@"SELECT {abc.abc_id} FROM {abc}");
  if (abcData.Rows.Count == 0)
  {
    return new List<string>
    {
       @"abc.imp"
    };
  }
  else
    return new List<string>();
}
```

[Read the full article on DevNet][1] - it has more details than this overview.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/content/content/database/continuous-database/
