---
title: osql_add_numbers
description: SuperOffice Objectified SQL - Add numbers
author: {github-id}             # Your GitHub alias.
so.date: 11.05.2016
keywords:
so.topic: howto
---

# Adding numbers

```SQL
SELECT s.Sale_id + s.Associate_id + s.Group_idx + s.contact_id + s.person_id
FROM CRM.sale s
WHERE (s.sale_id = 32)
```

```csharp
SoConnection _con = ConnectionFactory.GetConnection();
SoCommand _cmd = _con.CreateCommand();
_con.Open();
SaleTableInfo s = TablesInfo.GetSaleTableInfo();
Select query = S.NewSelect();
query.ReturnFields.Add( S.Math.NewAdd( s.SaleId, s.AssociateId, s.GroupIdx, s.ContactId, s.PersonId ) );
query.Restriction = s.SaleId.Equal( S.Parameter( 32 ) );
_cmd.SqlCommand = query;
SoDataReader reader = _cmd.ExecuteReader();
reader.Read();
long l = Convert.ToInt32( reader[0] );
reader.Close();
_con.Close();
_con = null;
_cmd = null;
```

See Also: SoConnection SoCommand TablesInfo Select SoDataReader
