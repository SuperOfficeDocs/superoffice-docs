---
title: objectified_sql
description: Evolution of NetServer Objectified SQL
author: Tony Yates
so.date: 09.06.2016
keywords:
so.topic: concept     # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Evolution of NetServer Objectified SQL

Objectified SQL (OSQL) is the heart of NetServer, intercepting and processing all higher-level data layer APIs, and is responsible for interfacing with various versions of each supported SQL dialect.

## The early years

There was a time when OSQL required several lines of verbose coding to execute the simplest query. Take the following example that selects all companies that from the United Kingdom, where the UK country ID is 826).

```SQL
SELECT * FROM Contact
WHERE country_Id = 826;
```

To execute that statement as OSQL required:

1. instantiating a new instance of a `Select` object
2. instantiating a new instance of the `ContactTableInfo`
3. adding the return fields
4. and then establishing the criteria as a `Restriction`.

```csharp
Select selectStatement = S.NewSelect();
ContactTableInfo contactInfo = TablesInfo.GetContactTableInfo();
selectStatement.ReturnFields.Add(contactInfo.All);
selectStatement.Restriction = contactInfo.CountryId.Equal(S.Parameter(826));
```

This code doesn’t even execute the query. To do that requires more lines of code that would get the connection, open the connection, set the command, and then execute the reader and read iteratively over any results.

```csharp
using (SoConnection con = ConnectionFactory.GetConnection())
{
  con.Open();
  using (SoCommand cmd = con.CreateCommand())
  {
    cmd.SqlCommand = selectStatement;
    using (SoDataReader reader = cmd.ExecuteReader())
    {
      while (reader.Read())
      {
        int contactId = reader.GetInt32(0);
        string name = reader.GetString(1);
        Console.WriteLine(string.Format("{0} {1}", contactId, name));
      }
    }
  }
}
```

That is what writing OSQL code life was like before version 3.0. **When version 3.0 arrived**, it brought with it a nice little helper called the `QueryExecutionEngine`. This new class encapsulated the Connection and Command code above and marginally reduced the required number of lines of code. Instead of requiring the whole Connection and Command orchestration, we could pass in the OSQL Select instance as a parameter into the constructor of the `QueryExecutionEngine`.

```csharp
using (QueryExecutionHelper qeh = new QueryExecutionHelper(selectStatement))
{
  while (qeh.Reader.Read())
  {
    int contactId = qeh.Reader.GetInt32(contactInfo.ContactId);
    string name = qeh.Reader.GetString(contactInfo.Name);
    Console.WriteLine(string.Format("{0} {1}", contactId, name));
  }
}
```

While this wasn’t a huge win, in terms of reducing code, this was a big win after several years of writing it the old way!

There were additional improvements that came in later versions as well, more related to the Argument and Math functions. Let's focus on recent advancements that will help you write less code for executing OSL Queries today.

## The recent years

As version 3 turned into version 7, the OSQL API became better and better with more targeted queries with the introduction of a generic Select called `TargetedSelect`.

### TargetedSelect

Introducing generics to Select, with the creation of `TargetedSelect<TableInfo>` class, reduced the necessity of getting an instance of the target `TableInfo`. A `TargetedSelect<TableInfo>` instance accepts a TableInfo target argument and exposes all of the table fields via the `TargetedSelect<TableInfo>.Table property`. The following example instantiates a new `TargetedSelect` with the `ContactTableInfo` class as the Generic argument. The rest of the code is the same but doesn’t have to be. It does get better!

```csharp
var selectStatement = S.NewSelect<ContactTableInfo>();
selectStatement.ReturnFields.Add(selectStatement.Table.All);
selectStatement.Restriction = contactInfo.CountryId.Equal(S.Parameter(826));
```

### Restrictions in TargetedSelect constructor

Restrictions are now accepted as a parameter into the `TargetedSelect` constructor directly, eliminating yet another line of code.

```csharp
var selectStatement = S.NewSelect<ContactTableInfo>(cti => cti.CountryId.Equal(S.Parameter(826)));
selectStatement.ReturnFields.Add(selectStatement.Table.All);
```

The restrictions can be as complex and elaborate as needed.

### Index queries

Index queries, which are popular when querying at the `SuperOffice.CRM.Rows` level APIs, are now accepted as `TargetedSelect` constructor parameters. This comes in two forms:

* the ID value of the record, or int array of more than one ID
* or Index-lookup methods have the same name and syntax as found in the Row objects

```csharp
var selectStatement = S.NewSelect<ContactTableInfo>(3,4,5);
var selectStatement = S.NewSelect<ContactTableInfo>(cti => cti.IdxName("SuperOffice AS"));
```

This makes it very easy to query a specific record.

### New Query Execution Syntactical-Sugar

It’s completely legal to mix the old with the new syntax, for example using the `QueryExecutionHelper` to access the returned data.

```csharp
var selectStatement = S.NewSelect<ContactTableInfo>(cti => cti.IdxName("SuperOffice AS"));
using (QueryExecutionHelper qeh = new QueryExecutionHelper(selectStatement))
{
    while (qeh.Reader.Read())
    {
        int contactId = qeh.Reader.GetInt32(selectStatement.Table.ContactId);
        string name = qeh.Reader.GetString(selectStatement.Table.Name);
        Console.WriteLine(string.Format("{0} {1}", contactId, name));
    }
}
```

However, there is a new syntactical-sugar to help make this query even easier. The `TargetedSelect` object contains a Records method that accepts return field parameters. As a side note, you do not have to supply the return fields this way. Just remember that if you do not, then you must set the desired return fields using the alternative approach, i.e. `hinSelectStatement.ReturnFields.Add`.

```csharp
var thinSelectStatement = S.NewSelect<ContactTableInfo>(cti => cti.IdxName("SuperOffice AS"));
var result = thinSelectStatement.Records(
    thinSelectStatement.Table.ContactId, thinSelectStatement.Table.Name, thinSelectStatement.Table.Department)
    .Select(r => new
    {
        ContactId = r.GetInt(r.Table.ContactId),
        Name = r.GetString(r.Table.Name),
        Department = r.GetString(r.Table.Department)
    });

foreach (var contact in result)
{
    Debug.WriteLine("{0}: {1}", contact.Name, contact.Department);
}
```

Notice how the code is formed above. It’s important to understand there are two ways to get the data from a `TargetedDataRecord`. Each field has an indexer which returns the field in the correct type as well. In the revised version below, notice how the `ContactId` is returned to the Id property as an int data type. This is great too!

```csharp
var selectStatement = S.NewSelect<ContactTableInfo>(cti => cti.IdxName("SuperOffice AS"));
var queryResults = selectStatement
    .Records(selectStatement.Table.ContactId, selectStatement.Table.Name, selectStatement.Table.Department)
    .Select(r => new
    {
        Id = r.Table.ContactId[r],
        Name = r.Table.Name[r],
        Department = r.Table.Department[r]
    });
```

There is also one more trick up the `TargetedSelect` sleeve: the returned `TargetDataRecord`. It’s entirely possible to convert the results to a complete record. Using a new example, with a slightly more complex restriction, you can construct a complex query in just two lines of code. The only caveat is that the `FromRecord` method is hidden in the `SuperOffice.CRM.Rows` namespace, so make sure that is included at the top of your file, or else you will observe a compile-time error stating that `FromRecord` does not exist.

```csharp
var s = S.NewSelect<ContactTableInfo>(cti => cti.Name.Like("A%").And(cti.Department.NotLike("")));
var contactResult = s.Records(s.Table.All).Select(r => new { ContactRecord = r.FromRecord() });

foreach (var contacts in contactResult)
{
    Debug.WriteLine("{0}: {1}", contacts.ContactRecord.Name, contacts.ContactRecord.Department);
}
```

### Inner Joins

Even though the old way of joining two tables together is still valid, it makes sense to present the new Inner Join capabilities. Here is an example of the older form of constructing inner joins.

```csharp
Select sqlSelect = S.NewSelect();
ContactTableInfo contact = TablesInfo.GetContactTableInfo();
PersonTableInfo person = TablesInfo.GetPersonTableInfo();
sqlSelect.ReturnFields.Add(contact.Name, person.Firstname, person.Lastname);
sqlSelect.JoinRestriction.InnerJoin(person.ContactId.Equal(contact.ContactId));
sqlSelect.Restriction = contact.Name.Like("A%").And(contact.Department.NotLike(""));
```

Today, there is the new `TargetedInnerJoin` type that allows you to construct inner queries in another manner. The following example joins together the person and contact table using the `JoinRestriction.AddJoin` method. This method returns a strongly typed instance of the right-hand `TableInfo` object, which you can then use to include in the return fields and access the results.

```csharp
var selectStatement = S.NewSelect<PersonTableInfo>();
var contactTableInfo = selectStatement.JoinRestriction.AddJoin(selectStatement.Table.ContactId_InnerJoin_Contact);
selectStatement.RestrictionAnd(contactTableInfo.Name.Like("A%"));
var queryResults = selectStatement
.Records(contactTableInfo.Name, selectStatement.Table.Firstname, selectStatement.Table.Lastname)
.Select(r => new
{
    CompanyName = r.GetString(contactTableInfo.Name),
    PersonFirstName = r.GetString(selectStatement.Table.Firstname),
    PersonLastName = r.GetString(selectStatement.Table.Lastname)
});

foreach (var company in queryResults)
{
    Debug.WriteLine("{0}: {1} {2}", company.CompanyName, company.PersonFirstName,
    company.PersonLastName);
}
```

## Conclusion

There is a lot of functionality that NetServer OSQL has to support, and sometimes the SuperOffice API adapts to new ways of doing things to help make that job easier. Just as in the early years, OSQL continues to be the fastest way to do that and now provides better time-saving syntactical-sugar to construct and execute your queries.

I hope this has helped you learn more about these interesting techniques and saves you time in constructing your OSQL in the future.
