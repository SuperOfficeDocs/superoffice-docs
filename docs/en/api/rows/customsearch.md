---
title: CustomSearch queries
description: CustomSearch queries
author: AnthonyYates
so.date: 11.16.2021
keywords: data access, rows, CustomSearch
so.topic: concept
so.envir: cloud, onsite
so.client: win, web
---

# CustomSearch queries

Both entity and row types contain an inner class called **CustomSearch**. CustomSearch queries allow you to go above and beyond that of index queries.

## Simple CustomSearch

For example, the code below demonstrates a simple CustomSearch. The results are predictable: the people object will be a `PersonCollection` containing all of the people in the `Person` table. This means that for each row in the `Person` table, there will be one `Person` in the `PersonCollection`.

```csharp
PersonCollection.CustomSearch peopleSearch = new PersonCollection.CustomSearch();
PersonCollection people = peopleSearch.ToPersonCollection();
```

## Restriction

NetServer provides the ability to append **additional criteria** to a given object or collection search by setting the Restriction property. Even greater query capability is available by including other `TableInfo` objects for join selections on the `JoinRestriction` property.

What if you wanted to see all Person entities who were born after January 1, 1970. The following code demonstrates a search to implement such a query.

```csharp
PersonCollection.CustomSearch peopleSearch = new PersonCollection.CustomSearch();
peopleSearch.Restriction = peopleSearch.TableInfo.DayOfBirth.GreaterThan(S.Parameter(newDateTime(1970, 1, 1)));
PersonCollection people = peopleSearch.ToPersonCollection();
```

Notice that the Restriction property accepts an `Argument` object as a type. Ok, so this is not explicitly shown by looking at the above code, but that is what implicitly gets set in the Restriction.

Encapsulated in the architecture, Restriction inherits from the type `QueryElement`, as does `Argument`. Other types, such as `GreaterThan`, `LessThan`, `Equal`, and `Like`, ultimately end up inheriting from `QueryElement`.

## Multiple criteria

Let's take the custom search one step further and set the criteria to return only the people from the contact with a `contact_id` value of 3, and those who were born after January 1, 1970.

```csharp
PersonCollection.CustomSearch peopleSearch = new PersonCollection.CustomSearch();

peopleSearch.Restriction =
      peopleSearch.TableInfo.ContactId.Equal(S.Parameter(3)).And(
      peopleSearch.TableInfo.DayOfBirth.GreaterThan(S.Parameter(newDateTime(1970, 1, 1))));

PersonCollection people = peopleSearch.ToPersonCollection();
```

Notice how the `Argument` can contain more than one type of Argument to send to the underlying query. In this case, it leverages the Restriction `And` method to append a new Argument to the search query. Restriction also contains an `Or` method, to append OR statements to the query criteria.

Internally, custom search functionality is handled using the **Visitor pattern**, but that is far beyond the scope of this article and will not be discussed here. Luckily, we as developers using NetServer don't need to know exactly how this is implemented. All we need to know is that to define our desired results, all we need to do is stick to using the properties exposed by the `CustomSearch` object `TableInfo` property to establish criteria.

<!-- Referenced links -->
<!-- Referenced images -->
