---
title: How to create tables
uid: create_cdd_tables
description: How to create tables in the SuperOffice database for version 8.1 and higher
author: Tony Yates
date: 06.23.2017, 11.02.2017
keywords:
topic: guide
# envir:
# client:
---

# How to create tables in the SuperOffice database (CDD)

Evolutionary database design is the way forward. The implementation development, tested and used by SuperOffice in its’ own environment has proven to be very useful and a powerful tool for ensuring database integrity, flexibility, and longevity.

We believe that once you begin to leverage it, you will be impressed and assured that SuperOffice Continuous Database is the correct decision and direction for living in an agile world.

This article will teach how to use your DictionarySteps to make database changes.

First, read the [intro][1] and [DictionarySteps][2].

## Overview

***Structure*** is where all database table, field, and index changes must be made. There are several intuitive methods in the base class to make such actions easy and are explored more thoroughly in the next section.

Once a table is created, and populating the table with priming data is desired, the class need only implement `ImpFieldNames`. This returns a list of IMP file names to the Continuous Database library which iterates over the list and begins to import data.

When more flexibility is required, such as calculated fields or transforming data from existing tables, the dictionary step should override the `CustomPriming` method.

Methods declared in the base class, `ExecuteSelect` and `ExecuteSql`, can issue SQL statements to the database to performing queries or perform actions, respectively. However, these methods should be used sparingly. Issuing SQL statements using these methods is covered in a later section.

Finally, it’s important to understand that all schema changes should be done in a small, compact, and isolated manner. Changes should be done in such a way that makes it easy to understand and manage. Evolutionary database design benefits from small incremental changes.

Once a dictionary step is committed to the database, it is final. It cannot be undone. The only way to change the last dictionary step is to create a new dictionary step that makes yet another change to the database!

## Methods

* [Structure][3]
* [ImpFileNames][4]
* [CustomPriming][5]

## Tooling

SuperOffice DevNet provides tooling to help create a DictionaryStep from an existing third-party table. Please refer to the [DevNet Toolbox][6] for more information.

## How it works

In the example below, `MovieStep1` implements the `Structure` method where two new tables are defined. Using the create method to begin the process, a fluent interface makes it easy to add table properties and fields to the table all in one statement.

Each method in the `Structure` method will be translated into a command. `CreateTable`, for instance, is transformed into a create table command, and each of the Add methods is transformed into an **add field** command.

![x][img1]

Individually, each command is known as a **BuilderCommand**. Even the `Dictionary` attribute and any defined indexes are transformed into respective commands.

![x][img2]

There are several types of command builders, where each builder knows how to access and build a list of commands from each unique resource.

For example, a `CommandFromStepBuilder` knows how to build a command list from a `DictionaryStep`, such as in the `MovieStep1` class. Another command builder called `CommandFromEjExtraBuilder`, knows how to build a command list from all SuperOffice Customer Service `Extra_Table` and `Extra_Field` tables.

**Applicators** then use the command lists to perform various tasks. For example, the `DatabaseModelApplicator` is responsible for both command validation and transforming the command list into database model types – such as `TableModel`, `FieldModel`, `IndexMode`, `RelationModel`.

![x][img3]

Once the in-memory database model has been checked and validated, the physical applicators perform all physical changes to the database.

## Typical workflow

![x][img5]

As a third-party developer, the typical workflow begins when you have an integration idea that needs to either extend or create a table in the SuperOffice database. Detailed in the [Continuous Database article][1], this begins with the creation of a new Dictionary Step.

Make sure that the assembly created is done so without any unnecessary assembly references. The only external references your `DictionaryStep` assembly should have are to the assemblies included in the `SuperOffice.ContinuousDatabase` NuGet package.

## DictionaryStep life-cycle

Before presenting how a DictionaryStep is applied to a physical database, this section defines two classes that represent the different stages of a `DictionaryStep` life. The lifecycle of a `DictionaryStep` is determined by its `StepNumber`, and is normally given a name that aligns with the feature. The `DictionaryStep` in this section is called **DemoFeature**, and like all DictionarySteps, must begin with a `StepNumber` set to 1.

`DemoClass1` class creates one new table called `Demo`, sets table properties for replication, and finally defines 9 add field methods. More than nine fields will be created, however. Can you spot the reason why?

**Example DictionaryStep - DemoFeature, StepNumber 1:**

[!code-csharp[CS](includes/democlass1.cs)]

With the assumption that you are a partner building a product integration, which probably contains an uninstall routine, a new class with the same `Dictionary` attribute is required to remove all changes. The `DemoClassUninstall` class is written to remove changes created by all previous **DemoFeature** DictionarySteps.

The way this `DictionaryStep` is distinguished from all other DemoFeature DictionarySteps is the **StepNumber** in the Dictionary Attribute. The `StepNumber` must be set to 2147483647, or in C# `int.MaxValue`.

When a `DictionaryStep` with `StepNumber` equal to `int.MaxValue` is applied, not only will the framework perform the commands in the `Structure` method to undo all changes, it will remove the `DictionaryStepInfo` from the `DatabaseModel`, ensuring no conflicts occur if or when the DictionaryStep StepNumber 1 is applied again in the future.

If you are still wondering why more than nine fields are created, `AddRegisteredUpdated` method is a macro method that adds several fields in one go! You can read more about these methods in the introductory article, [Continuous Database][1].

**Example DictionaryStep - DemoFeature, StepNumber int.MaxValue:**

[!code-csharp[CS](includes/democlassuninstall.cs)]

The only requirements to apply the DemoFeature StepNumber 1, and add the new table to the database, is:

1. Create a connection to the database,
2. Create an instance of the `DatabaseManagement` class,
3. Pass the `DictionaryStep` into the `DatabaseManagement.ApplyDictionarySteps` method.

The following code example resides in a new project - a console application, with the following assembly references:

* the DictionaryStep assembly containing DemoClass1 and DemoClassUninstall - *ExampleDictionaryStep.dll*
* *SuperOffice.CD.DSL.dll*
* *SuperOffice.CD.DSL.Implementation.dll*

[!code-csharp[CS](includes/apply-steps.cs)]

It’s that easy!

To remove the table, execute the same code but instantiate the `DemoClassUninstall` class and pass that into the `LinkedList` constructor instead.

## Inside DatabaseManagement ApplyDictionarySteps

While it's not necessary to know how `ApplyDictionarySteps` works, it’s interesting to know what's going on under the hood to gain a better understanding of the architecture.

The diagram below lists - in sequence - the actions that occur when a `DictionaryStep` is applied to a database.

![x][img6]

This shows how a `DictionaryStep` is transformed into a command list by the `CommandBuilder`, and how the applicators use the command list to apply changes to the database. The diagram also details when priming actions occur, when and where changes are logged to the database and the database model is persisted.

## Conclusion

There are several things to think about when abstracting the evolutionary database concepts into an object-oriented methodology. It can easily become quite complex, without knowing how all the parts work together, but SuperOffice has made it simple and easy to make changes to the SuperOffice database. In fact, it's the same technology R&D teams uses for each SuperOffice iteration.

I hope this article has helped you learn how to apply your DictionarySteps and change the SuperOffice database to suit your needs.

To try this out for yourself, we have provided [an example on GitHub][7].

<!-- Referenced links -->
[1]: index.md
[2]: dictionary-steps.md
[3]: structure-method.md
[4]: impfilenames-method.md
[5]: custompriming-method.md
[6]: https://github.com/Superoffice
[7]: https://github.com/SuperOffice/DevNet/tree/master/ContinuousDatabase

<!-- Referenced images -->
[img1]: media/moviestep1.png
[img2]: media/buildercommands.jpg
[img3]: media/commandbuilders.png
[img5]: media/cdd-workflow.jpg
[img6]: media/apply-dictionarysteps-workflow.png
