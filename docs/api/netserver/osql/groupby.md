---
title: GroupBy
uid: osql_groupby
description: SuperOffice Objectified SQL - GroupBy
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: concept
---

# GroupBy

When retrieving data, it is necessary to group and order the data.

```SQL
SELECT a.AssociateId, a.Name FROM associate a WHERE a.AssociateId > 10 AND a.AssociateId < 100
ORDER BY a.AssociateId asc
GROUP BY a.AssociateId, a.Name
```

```csharp
using SuperOffice.Data;
using SuperOffice.CRM.Data;
using SuperOffice.Data.SQL;
using SuperOffice;
using(SoSession newSession = SoSession.Authenticate ("SAL0", ""))
{
  //Create a new connection
  SoConnection _con = null;
  SoCommand _cmd = null;
  _con = ConnectionFactory.GetConnection ();
  _cmd = _con.CreateCommand ();
  _con.Open ();

  AssociateTableInfo associateInfo = TablesInfo.GetAssociateTableInfo ();

  //Create a Select
  Select select = S.NewSelect ();

  //Setting the fields need to be returned
  select.ReturnFields.Add (associateInfo.AssociateId,associateInfo.Name);

  //setting the restrictions.
  select.Restriction = associateInfo.AssociateId.GreaterThan
      (S.Parameter (10)).And (associateInfo.AssociateId.LessThan
      (S.Parameter (100)));
  select.OrderBy.Add (S.FieldExpression.Count (associateInfo.AssociateId), "asc");
  select.GroupBy.Grouping.Add (associateInfo.AssociateId, associateInfo.Name);
  _cmd.SqlCommand = select;

  //Create a Reader
  SoDataReader reader = _cmd.ExecuteReader ();

  //Read Data
  while(reader.Read ())
  {
    listBox1.Items.Add (reader [0].ToString () + " " + reader[1].ToString ());
  }
  reader.Close ();
  _con.Close ();
}
```
