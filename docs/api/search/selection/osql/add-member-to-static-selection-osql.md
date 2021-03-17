---
# Mandatory fields.
title: add_members_static_selection_osql      # (Required) Very important for SEO.
description: How to add members to a static selection using OSQL # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: search,osql,selectionmember
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to add members to a static selection using OSQL

[!include[import OSQL namespaces](../../../includes/using-osql.md)]

At this level of the NetServer, you need to have a very good understanding of the SuperOffice database so you create the correct table info objects to insert or update the database table.

## Example 1

[!code-csharp[CS](includes/add-to-static-osql-1.cs)]

In this example, we are only adding members to a static selection so we have created a `SelectionMemberTableInfo` object since we know that the data gets inserted into the `SelectionMember` table.

If you analyze the above code carefully, you can observe that we have used a class called `Sequence` to get the next sequence of the `SelectionMember` table. This class will help you to get the next sequence number of any table if you provide the correct table info.

## Example 2

In example 1, you may have noticed that we have only added one member to the static selection. If we want to add more than one member, we cannot do it with only the above mechanisms you will have to use some other ways to do it.

[!code-csharp[CS](includes/add-to-static-osql-2.cs)]

If you analyze this example, you can observe that we have made 2 additional changes:

* We created a new insert object and added the second member through that
* We created a new object calling the batch save

This new **batch save object** holds the secret to adding more than one member to a static selection. A batch save object can hold many SQL statements for us. It acts as an array of SQL statements. In this case, it holds 2 insert statements for us. So when we add our SQL statements to the batch save object and then assign the batch save object as our SQL command in the SO command object. Now when we execute our query the NetServer will do the rest for us. It will add the 2 records to the `SelectionMember` table with the correct selection member ID.

[!include[ALT](../includes/note-hardcoding-id.md)]
