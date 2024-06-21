---
title: Structure method
uid: cdd_structure
description: Continuous database structure method
author: Tony Yates
date: 06.23.2017
keywords: database
topic: concept
# envir:
# client:
---

# Structure method

Changing the database schema is facilitated by 3 methods in the base class:

* CreateTable
* DropTable
* ModifyTable

Each method is a **fluent** interface, and therefore easy-to-read and easy-to-use. This simple example illustrates this point:

[!code-csharp[CS](includes/structure.cs)]

Each fluent method expects a minimal set of required parameters while permitting several named parameters to override field defaults, such as *notNull: false*.

In addition to fluent methods for tables, there are fluent methods that make it easy to add and modify fields of all supported field types.

There are also handy **macro** methods to create common field patterns, such as `AddRegisteredUpdate()`.

`AddRegisteredUpdated` adds 5 fields, all with standard settings:

* `registered`
* `registered_associate_id`
* `updated`
* `updated_associate_id`
* `updatedCount`

## CreateTable methods

Inherits from `ITableBuilderBase` (below).

| Method | Description|
|---|---|
| Legacy | Access methods to set legacy parameters - DON't USE unless you know what you are doing |
| TableProperties | Access methods to set table properties that influence the generated code (rather than the database table itself) |
| CodeGeneration | Set code-generation flags for MDO, HDB (table objects), udef, and Sentry functionality |
| Replication | Set replication/Travel flags |
| HasVisibleFor | Set that records in this table have access control via corresponding records in `VisibleFor` |

> [!NOTE]
> Travel is no longer being actively developed. Do not create new products depending on it.

## ModifyTable methods

Inherits from `ITableBuilderBase` (below).

| Method | Description|
|---|---|
| ModifyField | Modifies the properties of a field definition. |
| DeleteField | Delete a field. Be careful! |
| DeleteIndex | Delete the index that spans the given fields, if it exists. Nothing bad happens if no such index exists. |

> [!CAUTION]
> Deleting a field is a drastic thing to do and breaks backwards compatibility, so you need to be sure no old code is going to run against this database. Any indexes that contain this field will be deleted automatically, both in the database model and in the physical database. Physical indexes will be detected and deleted even if they have been made outside of this product, for instance by DBAs and optimizers.

## ITableBuilderBase methods

| Method | Description|
|---|---|
| AddBool | Add a boolean field<br>generally represented by a 16-bit integer in the database |
| AddBlob | Add a BLOB (Binary Large Object) field, up to 1GB in size |
| AddDateTime | Add a datetime field. An optional parameter is used to indicate UTC |
| AddDouble | Add a double floating-point field. |
| AddEnum |  Add an enum field, represented in the database by a 16-bit integer. The enum reference causes strongly typed properties in `TableInfo` and `Row` objects. See below for declaring enums. |
| AddForeignKey | Add a foreign key field. |
| AddId | Add a 32-bit integer field, that is to be understood as a row ID.<br>Use `AddForeignKey` to add foreign keys<br>Use `AddRecordId`/`AddTableNumber` to set up universal relations |
| AddInt | Add a 32-bit signed integer field. |
| AddRecordId | Add a record number, a foreign key that forms the second half of a universal relation. |
| AddString | Add a string field. See maxLength parameter for important notes. |
| AddTableNumber | Add a table number, represented by a 16-bit integer in the database. The value is understood to be a table number corresponding to a table as defined in the `sequence` table<br>Such numbers are constant over the lifetime of a database **but can vary between databases**. The table number forms one half of a universal relation |
| AddUShort | Add a 16-bit unsigned integer field. |

**Index methods:**

| Method | Description|
|---|---|
| AddIndex | Add an index over one or more columns. A particular column name list (order matters) can only occur once |
| AddFulltextIndex | Add a full-text index over one or more columns. A table can have at most one full-text index. Later calls to this method simply add fields to any existing full-text index. |
| AddUniqueIndex | Add a unique index over one or more columns. A column name list (order matters) can only occur once |

> [!NOTE]
> Full-text indexing only happens on SQL Server with the feature installed. Otherwise, no action is taken.

**Field methods:**

| Method | Description|
|---|---|
| SetHash | Set special hash flags for a field<br>A field can be a member of a row hash, or can be the hash itself |
| SetPrivacy | Set privacy tags, which can be used to ensure compliance with privacy rules |
| SetSearch | Set special search flags on a field |

**Macro methods:**

| Method | Description|
|---|---|
| AddMDO | Add 4 fields that make up the standard start of a list table: name, rank, tooltip, deleted |
| AddRegisteredUpdated | Add five 5: `registered`, `registered_associate_id`, `updated`, `updated_associate_id`, `updatedCount` with all standard options. Used on most tables and populated automatically by NetServer database layer. |

The `ITableRemover` interface only contains one method, `DropTable`, which accepts the table name of the table to be dropped. This permanently removes the table, so **be careful**. This is a drastic action that breaks backwards compatibility and you need to make sure no old code runs against this database.

## Enumerations

Using the `AddEnum` method, a field in the database can be connected to an enumeration type in the code. Here it is important to understand that such an enum will exist in two versions.

To **define the enum** so that it can be used in a dictionary step, it needs to be declared in the same assembly as the dictionary step. The enum itself is decorated using the `DbEnumAttribute`, and each member is decorated with `DbEnumMember`. For example:

```csharp
[DbEnum("Value for field 'private' in table 'appointment'.", Layer.Core)]
public enum AppointmentPrivate : short
{
  [DbEnumMember("This appointment can be read by anyone")]
  Public = 0,
  [DbEnumMember("This appointment can only be read/seen by the owner")]
  PrivateUser = 1,
  [DbEnumMember("This appointment can only be read by members of theowners group")]
  PrivateGroup = 2,
}
```

This enum is what we call the **model enum**.

Once the enum xyz is declared, it can be used in an `AddEnum<xyz>()` method call within the `Structure()` method of a dictionary step. This will cause the creation of a 16-bit integer field in the database, and code generated for the `TableInfo` and the Row object will have strongly-typed references to it.

However, that generated NetServer code does not reference the enum declared in the dictionary step – it references a generated version of the same enum in the NetServer generated code! The reason for this is simple: the enum in NetServer must be known and available to all NetServer code, whether the dictionary step class is present or not.

In a customer installation, the assembly containing the dictionary step is only present in the DevNet Toolbox while the database is being upgraded and is never required to be in the NetServer installations. Thus, a new NetServer-native enum is generated together with the `TableInfo` and `Row` code. This one is the NetServer enum.

While the model-enum lives in the same assembly as the dictionary steps, it is not a member of any particular step and is generally declared directly in the namespace. If it needs to be changed (for instance, adding new values), then just change it, generate new NetServer code from it and release that.

Changing an enum does not need a dictionary step, and is in fact not connected to a step. The only connection between steps and enums happens when an `AddEnum<>` method call declares a new database field to be of an enum kind.

## Structure Implementation

Under the covers, a call to `CreateTable`, `DropTable`, or `ModifyTable` generates a `BuildCommand`, which is an objectified representation of the actions they define. For example:

* `CreateTable` creates a `BuilderAddTableCommand` instance
* `DropTable` creates a BuilderRemoveTableCommand instance
* `ModifyTable` creates a BuilderModifyTableCommand instance

> [!NOTE]
> **BuildCommands** are applied towards the database after the `Structure` method is called.
