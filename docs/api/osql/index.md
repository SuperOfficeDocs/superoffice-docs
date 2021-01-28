---
title: osql       
description: SuperOffice Objectified SQL
author: {github-id}             # Your GitHub alias.
so.date: 11.05.2016
keywords: data-access
---

# SuperOffice Objectified SQL

SuperOffice introduces its own language to write queries so that it is independent of the underlying database. Therefore with the use of SuperOffice Objectified SQL (OSQL), you can write queries without worrying about the database anymore.

NetServer exposes many layers of its API to do the same functionality. OSQL is the lowest layer of the NetServer API. You can think of it as the SuperOffice Database Interface (SODBIF).

In the [syntax][1] section, we will be comparing SuperOffice Objectified SQL with SQL while explaining how SuperOffice Objectified SQL is used.

## Target audience

Those who have previously worked with T-SQL, Stored Procedures, and those who don't find it intimidating to get close to the database, would enjoy using OSQL rather than using Service, Row, and Entities. However, there are many things to consider, and be aware of, when you are getting closer to the core since there’s a whole number of different ways that you may be trapped or buried when creating your own inserts, updates, and deletes outside of the business objects within the NetServer.

The advantage is that when using the OSQL to create code, the code would be more responsive and efficient than when using the Services, RDB, or the HDB layers.

## Why use OSQL?

Any calls that are made through the higher layers of the architecture would go through the OSQL layer. Therefore, anything that can be done through the Service, RDB, and HDB layer can also be done through this layer. The examples aim to show how you could achieve the same results as achieved through the higher layer of NetServer.

One of the main advantages compared to the HDB layer is that when using the HDB layer, you would have to use several different HDB rows for most of the results whereas when using OSQL you may create your own customized rows.

A better way of getting the required information with the least amount of calls to the database is to construct a SELECT statement using OSQL.

For us to use OSQL, the following three namespaces are necessary.

* SuperOffice.CRM.Data
* SuperOffice.Data
* SuperOffice.Data.SQL

Additional namespaces may be required based on your requirements.

## How to create a new connection

Before you write queries, first you must create a new connection. This is the basic of SuperOffice Objectified SQL.

The following example demonstrates how this is done. This is used in all other OSQL examples.

```csharp
using SuperOffice.Data;
using SuperOffice.CRM.Data;
using SuperOffice.Data.SQL;
using SuperOffice;

using(SoSession newSession = SoSession.Authenticate ("SAL0", ""))
{
  //Create a new connection
  SoConnection con = ConnectionFactory.GetConnection ();
  if(con.Equals (null))
  {
    MessageBox.Show ("Connection is not created");
  }
  else
  {
    MessageBox.Show ("Connection is successfully created");
  }

  con.Open ();
  //Here you can have all your database queries
  //Once all the queries are made you can close the connection
  con.Close ();
}
```

To use OSQL, we need to import the namespaces `SuperOffice.CRM.Data`, `SuperOffice.Data`, and `SuperOffice.Data.SQL`. This has been done with the use of the `using` keyword.

Next, a session is created and authenticated.

Initially, we create a connection through the `GetConnection` method of the `ConnectionFactory`. If the connection is successfully created, the new `SoConnection` instance will be returned.

* Once a new connection is created, you must first open the connection before writing any queries.
* When you finish with querying, you must close the connection just as you do when writing SQL queries.

<!-- Referenced links -->
[1]: syntax/and-clause.md
