---
title: osql_like
description: SuperOffice Objectified SQL - LIKE
author: {github-id}             # Your GitHub alias.
so.date: 11.05.2016
keywords:
so.topic: concept
---

# LIKE

A simple like-clause:

```SQL
SELECT TO.associate_id FROM CRM.associate T0 WHERE name LIKE 'ad%';
```

```csharp
SoConnection _con = ConnectionFactory.GetConnection();
SoCommand _cmd = _con.CreateCommand();
_con.Open();
AssociateTableInfo a = TablesInfo.GetAssociateTableInfo();
Select select = S.NewSelect();
select.ReturnFields.Add( a.AssociateId );
select.Restriction = a.Name.Like( S.Parameter( "ad%" ) );
_cmd.SqlCommand = select;
SoDataReader reader = _cmd.ExecuteReader();
bool hasData = reader.Read();
// read data to do something useful here...
reader.Close();
_con.Close();
_con = null;
_cmd = null;
```

See Also: SoConnection SoCommand TablesInfo Select SoDataReader
