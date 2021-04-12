---
# Mandatory fields.
title: joiners       # (Required) Very important for SEO.
description: Joiners # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
keywords: reuse,IArchiveProvider
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Joiners

If one draws a graph that represents a query as a hierarchy, where tables (either as return fields or restrictions) are nodes and joins are edges, then an `ExtenderBase` class will represent a node, and a `Joiner` class will be an edge. Since joiners inherit from extender bases, an instance of a joiner is equivalent to a node plus its (single) upward-pointing edge.

For example, suppose we wish to fetch information about sales plus connected contacts and persons. The SQL query might look like this:

```SQL
SELECT s.heading, s.probability, c.name, c.department, p.firstname, p.lastname, pt.text
FROM sale s
LEFT OUTER JOIN contact c on s.contact_id = c.contact_id
LEFT OUTER JOIN person p on s.person_id = p.person_id
LEFT OUTER JOIN text pt on p.text_id = pt.text_id
```

The corresponding query graph is:

![ALT][img1]

The structure of the [extenders][1] involved corresponds exactly to this graph. The code handling each node is an `ExtenderBase`, while the code that provides the edges (the joins) is in Joiners. An instance of a `Joiner` inherits from the extender base and thus corresponds to the node and the edge going up to the parent node. As a result, joiners are typically very small classes with a standardized structure, that simply take a query and a parent table reference as input. They create a new `TableInfo` representing "this" and join it to the parent in the proper way (INNER, LEFT OUTER). They then return the newly created `TableInfo` instance up to the base class. Since the base class is an `ExtenderBase`, it now has a concrete table to work against and can run its logic (that requests `ReturnFields`, sets up restrictions, and picks values from the result set).

Joiners are usually **strongly typed objects**, so there is one for each combination of tables that occurs. In the graph above, there would be one for `SaleContact`, one for `SalePerson`, and one for `PersonText`. Similarly, we would find an `AppointmentContact` joiner for the case where we have an appointment row and want to add contact information. Both `SaleContact` and `AppointmentContact` inherit from `ContactExtenderBase`, and just add the correct join logic by implementing the abstract method `SetJoin`, like this:

```csharp
protected override ContactTableInfo SetJoin()
{
  ContactTableInfo ourContactTable = TablesInfo.GetContactTableInfo();
  SaleTableInfo parentSaleTable = (SaleTableInfo)Parent.TableToExtend;
  SetLeftOuterOrInnerJoin( parentSaleTable.ContactId.Equal( ourContactTable.ContactId ) );
    return ourContactTable;
}
```

There are about 30 `ExtenderBase` classes, that each cover one particular table. There are about 60 joiners, each representing one combination of 2 extender bases. Together they cover all combinations currently needed for the archive providers for SuperOffice web.

**Continue reading:** [Base and helper classes][2]

<!-- Referenced links -->
[1]: extenders.md
[2]: base-and-helper-classes.md

<!-- Referenced images -->
[img1]: media/image004.gif
