---
title: osql_create_connection
description: SuperOffice Objectified SQL - create a connection to the database
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: howto
---

# How to create a new connection

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

1. To use OSQL, we need to import the namespaces `SuperOffice.CRM.Data`, `SuperOffice.Data`, and `SuperOffice.Data.SQL`. This is done with the `using` keyword.

2. Create and authenticate a session.

3. Create a connection through the `GetConnection` method of the `ConnectionFactory`.

    If the connection is successfully created, the new `SoConnection` instance will be returned.

4. Once a new connection is created, you must first open the connection before writing any queries.

5. After querying, you must close the connection just as you do when writing SQL queries.
