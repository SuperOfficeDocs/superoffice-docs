---
title: Enum values with IN
uid: osql_in
description: SuperOffice Objectified SQL - Enum values with IN
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: concept
---

# Enum values with IN

The following example shows how to add enum-values with IN. The following SQL query is converted to SuperOffice Objectified SQL.

```SQL
SELECT s.SaleId, s.Status, s.SaleDate FROM sale s WHERE s.Status IN (1,2)
```

```csharp
using SuperOffice.Data;
using SuperOffice.CRM.Data;
using SuperOffice.Data.SQL;
using SuperOffice;
using(SoSession newSession = SoSession.Authenticate ("SAL0", ""))
{
  //Create a new connection
  SoConnection connection = ConnectionFactory.GetConnection ();
  SoCommand command = connection.CreateCommand ();
  connection.Open ();
  SaleTableInfo salesInfo = TablesInfo.GetSaleTableInfo ();

  //Write the query
  Select query = S.NewSelect ();

  //Add the return fields
  query.ReturnFields.Add (salesInfo.SaleId, salesInfo.Status,salesInfo.Saledate);

  //Add enum-values with IN
  Argument [] args = new Argument [2];
  args [0] = S.Parameter (SaleStatus.Open);
  args [1] = S.Parameter(SaleStatus.Sold);
  query.Restriction = salesInfo.Status.In (args);
  command.SqlCommand = query;

  //Execute the query
  SoDataReader reader = command.ExecuteReader ();
  while(reader.Read ())
    listBox1.Items.Add (reader [0].ToString () + " " + reader
        [1].ToString () + " " + reader [2].ToString ());
  reader.Close ();
  connection.Close ();
}
```

In this example, we have added an array of argument objects to the `Restrictions` of the query.

The `Argument` class is inherited from the `QueryElement` class.
