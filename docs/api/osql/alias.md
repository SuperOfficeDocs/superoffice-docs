---
title: osql_alias
description: SuperOffice Objectified SQL - Alias
author: {github-id}             # Your GitHub alias.
so.date: 11.05.2016
keywords:
so.topic: concept
---

# Alias

```SQL
SELECT COUNT(T0.associate_id) as Test
FROM CRM5.associate T0 
WHERE T0.associate_id BETWEEN 10 AND 20 
GROUP BY T0.associate_id 
ORDER BY Test ASC
```

```csharp
SoConnection _con = ConnectionFactory.GetConnection();
SoCommand _cmd = _con.CreateCommand();
_con.Open();

AssociateTableInfo a = TablesInfo.GetAssociateTableInfo();

Select select = S.NewSelect();
Count count = S.FieldExpression.Count( a.AssociateId );
count.Alias.Name = "Test";
select.ReturnFields.Add( count );
select.Restriction = a.AssociateId.Between( S.Parameter( 10 ), S.Parameter( 20 ) );
select.GroupBy.Grouping.Add( a.AssociateId );
select.OrderBy.Add( S.Parameter( "Test" ) );
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
