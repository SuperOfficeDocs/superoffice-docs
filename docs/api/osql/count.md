---
title: COUNT
uid: osql_count
description: SuperOffice Objectified SQL - Count
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: concept
---

# COUNT

```SQL
SELECT Count(T0.associate_id), T0.Name FROM CRM.associate T0
WHERE (T0.associate_id >= 20 AND T0.associate_id <= 30 )
GROUP BY T0.associate_id, T0.Name
```

```csharp
SoConnection _con = null;
SoCommand _cmd = null;
_con = ConnectionFactory.GetConnection();
_cmd = _con.CreateCommand();
_con.Open();
AssociateTableInfo a = TablesInfo.GetAssociateTableInfo();
Select select = S.NewSelect();
select.ReturnFields.Add( S.FieldExpression.Count( a.AssociateId ), a.Name );
select.Restriction = a.AssociateId.Between( S.Parameter( 20 ), S.Parameter( 30 ) );
select.GroupBy.Grouping.Add( a.AssociateId, a.Name );
_cmd.SqlCommand = select;
SoDataReader reader = _cmd.ExecuteReader();
int i = 0;
while( reader.Read() )
  ++i;
reader.Close();
_con.Close();
_con = null;
_cmd = null;
```

## Example 2

This example uses an alias on one of the fields:

```csharp
SoConnection _con = ConnectionFactory.GetConnection();
SoCommand _cmd = _con.CreateCommand();
_con.Open();
AssociateTableInfo a = TablesInfo.GetAssociateTableInfo();
Select select = S.NewSelect();
a.AssociateId.Alias = S.FieldExpression.NewAlias( "Test" );
select.ReturnFields.Add( S.FieldExpression.Count( a.AssociateId ), a.Name );
select.Restriction = a.AssociateId.Between( S.Parameter( 25 ), S.Parameter( 43 ) );
select.GroupBy.Grouping.Add( a.AssociateId, a.Name );
select.OrderBy.Add( a.AssociateId );
_cmd.SqlCommand = select;
SoDataReader reader = _cmd.ExecuteReader();
int i = 0;
while( reader.Read() )
  ++i;
reader.Close();
_con.Close();
_con = null;
_cmd = null;
```

See Also: SoConnection SoCommand TablesInfo Select SoDataReader
