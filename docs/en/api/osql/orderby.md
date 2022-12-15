---
title: OrderBy
uid: osql_orderby
description: SuperOffice Objectified SQL - OrderBy
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: concept
---

# OrderBy

When retrieving data, it is necessary to order the data.

```SQL
SELECT a.Associate_id, a.Name FROM CRM.Associate a
WHERE a.Associate_id <=10 AND a.Associate_id >=20
ORDER BY a.Associate_id DESC
```

```csharp
SoConnection _con = ConnectionFactory.GetConnection();
SoCommand _cmd = _con.CreateCommand();
_con.Open();
AssociateTableInfo a = TablesInfo.GetAssociateTableInfo();
Select select = S.NewSelect();
select.ReturnFields.Add( a.AssociateId, a.Name );
select.Restriction = a.AssociateId.Between( S.Parameter( 10), S.Parameter( 20 ) );
select.OrderBy.Add( a.AssociateId, OrderBySortType.DESC );
_cmd.SqlCommand = select;
SoDataReader reader = _cmd.ExecuteReader();
int i = 0;
while( reader.Read() )
{
  // do something with the data here...
  ++i;
}
reader.Close();
_con.Close();
_con = null;
_cmd = null;
```
