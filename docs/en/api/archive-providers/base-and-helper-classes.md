---
title: Base and helper classes
uid: base_and_helper_classes
description: Base and helper classes
author: {github-id}
keywords: IArchiveProvider
so.topic: concept
# so.envir:
# so.client:
---

# Base and helper classes

While it is quite possible to implement the `IArchiveProvider` interface *ab initio*, this is seldom optimal. There exists a lot of code applicable to almost any kind of provider or extender, either as a publicly available base class or as a helper:

* Functionality that is applicable in many contexts, such as the collection and management of column definitions (feeding `GetAvailableColumns`, and keeping track of what was requested in `SetDesiredColumns`) is available as a helper class.

* Functionality that is more strictly tied to particular subjects, such as extenders (where we know we are dealing with NetServer access to a database) is designed as a base class.

![ALT][img1]

This figure shows the main relationships. Concrete archive providers usually inherit from either `MultiQueryProviderBase` or `QueryProviderBase` depending on whether they are aggregate or single-query providers. Extenders inherit from `TableExtenderBase`. The base classes contain references to helper classes that handle columns, entities, and extensions, and also provide facades that map the helper class methods and properties on to the interfaces. The final result is that derived classes are provided with an environment where **boilerplate code** (code that can be more or less mindlessly copied) is absent.

To illustrate actual usage, the bottom of the diagram shows examples of concrete classes that derive from the base classes:

| Class | Description |
|---|---|
| `RelationProvider` | a many-channel provider that feeds the relation archive on the company card |
| `PersonProvider`| a single query provider that is used in the Person archive on the company card
| `TextExtenderBase` | an Extender that handles records from the text table |
| `ContactInfoTextExtender` | a joiner that adds the text info field to a contact extender, by doing two things - it generates the proper join, and restricts the type member of the text record to exclude other kinds of text than the Info (paperclip note). |

The base classes generally follow the **Template Method** pattern. See [Wikipedia]][1], and [C\# definition][2]. This means that the base class implements the methods of the interface, while derived classes fill in the blanks by implementing specific abstract methods defined by the base class to handle specific tasks.

As an example, the `ExtenderBase` class defines the abstract methods `InnerModifyQuery`, `InnerPopulateRowFromReade`, and `SetJoin`. A class such as `AddressExtenderBase` above will implement `InnerModifyQuery` to map its columns to actual table fields, and possibly do other query processing (add some extra fields it needs). It may also put logic into `InnerPopulateRowFromReader` to handle column population that is not handled by the base class. However, it does not implement `SetJoin()`, since that is the province of a joiner. And for that reason, `AddressExtenderBase` is still an abstract class.

A derived `Joiner` will implement `SetJoin` and complete the derivation, leading to a concrete class that can be instantiated. During execution, the base class code will first call `SetJoin` to obtain a `TableInfo` object. Then call the `InnerModifyQuery` so that the query can be prepared. And then run code that looks at mappings and does any query modification. This will be done for all extenders in the query graph. When that is finished, the provider base class (which controls the process) will execute the query (all extenders have now had a chance to add their bits to it), and then for each row, the base class will populate the fields it has knowledge about (through the `MapSimpleField` calls). Having done that, the extender base class will call `InnerPopulateRowFromReader` to allow custom population logic to run. Again, this process is repeated for each node of the query graph. Finally, the result row (where all extenders have contributed columns according to `SetDesiredColumns`) is returned to the client and the cycle repeats.

Important base classes are:

* `TableExtenderBase` - base class for extenders that handle one table, and indirectly their derived joiners

* `QueryProviderBase` - base class for providers that implement `IArchiveQueryProvider`

* `MultiQueryProviderBase` - base class for providers that implement `IArchiveMultiQueryProvider`, and aggregate multiple sub-providers

* `ExtensibleColumnsBase` - common base of `ExtenderBase` and `QueryProviderBase`

There are also two specialized provider bases called `InMemoryProviderBase` and `BufferedQueryProviderBase`, for those cases where the logic is so complex that it needs to have all rows available (buffered) or where the row source is such that it is easier to get everything and then just filter, sort and choose columns in memory. The details of the base class hierarchy are slightly more complex and are summarized in the following figure:

![ALT][img2]

For most purposes, inheriting from `QueryProviderBase` or `TypedQueryProviderBase` for providers and `TableExtenderBase` for extenders will cover all standard functionality, leaving only field mappings and truly custom logic for the derived classes. The rest of the base classes are useful in more specialized scenarios, where it is better to look at actual examples in the code.

## Archive row types

The basic return type from an archive provider is an `ArchiveRow`, and this is a fully generic object. That means that it can represent any kind of row with any number of columns. However, there are cases where it would be more convenient to have a more typed version of the row - one that guarantees the presence of certain columns and has properties that will access these columns. The theory is that this is easier to understand for developers who are not experts on the system who don't know the exact name and meaning of all the columns offered by the different providers.

The service layer interfaces in NetServer only exist in the generic, untyped version. If you are working directly with NetServer and programming against the provider interfaces, then it is possible to create and/or use the typed interfaces, where they exist. This possibility is the reason for the `<RowType>` template parameter that is present in several of the base classes. To use the standard, generic row type simply refers to `ArchiveRow`.

When creating a typed provider, consider:

* What columns should be present in the typed interface? The generic interface will still be there.

* What does it cost to fetch these columns (because they will have to be fetched always)?

* How to ensure that the provider knows it must populate the columns

By using the right combination of base classes and derivation, such a typed variant can be created fairly easily. As an example we can look at the `FindProject` provider, which can be used in a typed version to return an `ArchiveProjectRow`. The first part is the definition of `ArchiveProjectRow`, which inherits from `ArchiveRow`, defines a set of public string constants that map the desired always-present columns to the actual column names of the underlying provider, and also defines properties that get the corresponding values from the generic row data.

The string constants have to follow the naming convention that they start with "Column", and that the rest of their name corresponds to a value property of the row class. The reason is the use of reflection elsewhere in the system.

Second, a method is added to the `ArchiveProviderFactory` to return the specific provider type, instead of the generic `IArchiveProvider`. This method calls the generic, standard `Create` method, but uses templating and casting to give back a typed result.

Next, derive the concrete provider class from `TypedQueryProviderBase` instead of `QueryProviderBase`. This will bring in logic that binds to a helper class and reflects over the row class, to determine the names of must-have columns. This also brings in a new interface, `IArchiveTypedProvider`, which has the additional method `SetAdditionalColumns`.

`SetAdditionalColumns` is how one orders desired columns from a typed provider, instead of `SetDesiredColumns`. `SetAdditionalColumns` will automatically add the standard columns declared as string constants in the row type class to the provider's desired column list.

Only a few of the existing providers have typed interfaces, and it is by no means certain that the additional cost and complexity are justified. As long as the Service layer interfaces only expose the generic interface, usage of the typed interfaces is probably quite small.

<!-- Referenced links -->
[1]: http://en.wikipedia.org/wiki/Template_method_pattern
[2]: http://www.dofactory.com/Patterns/PatternTemplate.aspx

<!-- Referenced img -->
[img1]: media/image005.jpg
[img2]: media/image006.jpg
