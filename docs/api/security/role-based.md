---
uid: RoleBasedSecurity
title: Role-Based Security
description: Role-based security
author: Tony Yates
so.date: 11.05.2021
keywords: security, roles, DataRight, TableId, RelationshipToOwner, FunctionRight, FunctionRightToRoleLink
so.topic: concept
---

# Role-based security

This API corresponds to the Role panel in the Admin client:

![Admin Role panel -screenshot][img1]

* The grid shown above corresponds to the `DataRight` rows for the role.

* Each cell equals one row in the `DataRight` table. The "data-owned-by" values are stored in the `RelationshipToOwner` field.

* The rights for the different data objects are stored by varying the table ID stored in the `TableId`.

* The drop-down value in each cell is stored as a CRUD value. Delete = CRUD, while Create = CR.

```SQL
SELECT * FROM dataright WHERE roleid = 4
```

| DataRight_id | roleId | tableId | fieldId | relationToOwner | CRUD | encryptedCheck |
|---|---|---|---|---|---|---|
|905 |4 |5 |0 |0 |CRU |7H:UOlVueRgafCxieVTaP4px6InBK4=|
|906 |4 |6 |0 |0 |CRUD |7H:aMbWjFAVzdEc2xGuPbr3JOnLfaM=|
|908 |4 |9 |0 |0 |CRUD |7H:nIdttOSoKMQ2rVjC0L4Vu2lumTk=|
|909 |4 |10 |0 |0 |CRUD |7H:vp+MAd5MFusbcfmtuOs0Wcxep6g=|
|917 |4 |5 |0 |1 |CRU |7H:oSCLnmCjpeby+2lWX9z8gADkhik=|
|918 |4 |6 |0 |1 |CRUD |7H:UxoDEAvPL0a7j4tV3cmBDb4g2ck=|
|919 |4 |9 |0 |1 |R |7H:JuHX/ZqpL01mzxUj8l636nu4AEY=|
|920 |4 |10 |0 |1 |R |7H:jSgdZ1oqyB9FYQBl/E33Tv+ZMg0=|
|921 |4 |11 |0 |1 |CRU |7H:HbvJ6WYC4DaUbtz0D6ejJ7GpoHw=|
|922 |4 |12 |0 |1 |CRU |7H:sXaCJPw5BfK5Q5+pI4cPyUzGhCo=|
|923 |4 |13 |0 |1 |R |7H:xIsngNKBviz/1nv/3StgZ2FkkdI=|
|924 |4 |121 |0 |1 |CRU |7H:8EiFxTK2QjRvYYsV+U9Ri0aP2ic=|
|925 |4 |23 |0 |1 |CR |7H:zDPim8LiEodN08n3lP72abzhdzo=|
|926 |4 |52 |0 |1 |R |7H:dQYRaFLYpCTgEz0f0Zk40VHmLyI=|
|927 |4 |205 |0 |1 |R |7H:RVRMoV1GUBwa3gXKCN5XqLibZpM=|
|928 |4 |5 |0 |2 |R |7H:zy+Xtn+aZnt+dbZ73trypNOFpZA=|
|929 |4 |6 |0 |2 |R |7H:0i+rhE226BZeIfGzmBsh8DwS5Xg=|

* Each user has one and only one role.

* Each role has a set of function rights and a set of data rights.

* Function rights are stored in the `FunctionRight` table.

* Function right to role assignments are stored in the `FunctionRightToRoleLink` table.

![x][img3]

## See also

* [dataright table][1]
* [functionright table][2]
* [role table][3]

<!-- Referenced links -->
[1]: ../../../database/docs/tables/dataright.md
[2]: ../../../database/docs/tables/functionright.md
[3]: ../../../database/docs/tables/role.md

<!-- Referenced images -->
[img1]: media/admin-role.png
[img3]: media/role-diagram.png
