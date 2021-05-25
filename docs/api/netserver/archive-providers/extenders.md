---
title: extenders
description: Extenders
author: {github-id}
keywords: reuse,IArchiveProvider
so.topic: concept
# so.envir:
# so.client:
---

# Extenders

If a provider has a more or less fixed query and fetches data from a table that no-one else is interested in, then it would make sense for it to declare columns, set up the query, and perform all the processing directly. However, this is a fairly rare situation for providers made by SuperOffice, since we usually work against general tables like contact, person, or appointment. Partners making single-use solutions are more likely to be in this situation.

In any case, if there is reason to believe that the formatting, restriction, and query logic related to one table will be used in more than one provider, then it is important to write it in a reusable way. This is where the concept of **Extender** comes in, defined by the `IArchiveExtender` interface.

An archive extender is a class that:

* Has columns, implementing `GetAvailableColumns`, `SetDesiredColumns`, `SetOrderBy`, and `SetRestriction`
* Is itself extensible, through `AddExtensionProvider` and some helper properties
* Extends something else (that is extensible)
* Supports name prefixing for column names

> [!NOTE]
> An extender generally does **not** have any relationship to **entities**, since extenders operate on fragments of rows (the columns from one table only), and are meant to be reusable between different providers. For example, the person extender is used for persons in appointments, project members, selection members... and all of these are different entities, but still, the person logic is the same.

As with providers, there is a base class that contains most of the functionality needed to implement all these methods and properties; the individual extender only needs to declare its columns and (at the least) override one method to map the columns to the correct fields in its table. Thus individual extenders can be down to a few dozen lines long for trivial cases. Of course, if there is a lot of logic associate with columns, then the extender grows, because that is where you write the code that populates columns with values and processes any non-standard restrictions and orderbys.

In many cases, small subtrees (bushes?) of extenders form a logical unit. For example, **person** takes along **phone**, **address**, and **text** to make a combination that reflects the wider person entity, corresponding to what the user sees in the person dialog. There are several ways this *could* have been done, but the current design is that the Person extender itself creates and connects those sub-extenders it wants. This has proved to work reasonably well and means that top-level providers do not have to know about the details of the person substructure - if you want to include person functionality in your provider, you add the person extender and the rest comes automatically.

The drawback of this approach is that there may be cases where you do **not** want to include subtrees. As long as the client does not select any columns from an extender, the base class mechanics will ensure that the extender is excluded from the query and none of its code is run. However, there are cases where you also do not want columns from a subtree to be added to the available columns of the provider. To handle that, some extenders have flag enums that can be used (through the constructor) to select what functionality should be activated.

The classes that implement extenders come in two variants, bases, and joiners. Joiners are described in the next section. An extender **base** is a class the contains the declaration of columns, population, restrictions, and orderby - but **not** any code that will create a `TableInfo` object nor join it to any other part of the provider's root query. ExtenderBase classes are abstract and atomic, and very reusable. In NetServer there is exactly one `ExtenderBase` class per table involved in any provider (so there is one `PersonExtenderBase`, and no other extenders deal with the person table directly).

A very simple ExtenderBase can look like this:

[!code-csharp[CS](includes/extenderbase.cs)]

**Continue reading:** [Joiners][1]

<!-- Referenced links -->
[1]: joiners.md
