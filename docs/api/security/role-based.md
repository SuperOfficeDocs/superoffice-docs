---
uid: RoleBasedSecurity
title: Role-Based Security
---

# Role-based security

This API corresponds to the Role panel in the Admin client:

![Admin Role panel][img1]

* The grid shown above corresponds to the `DataRight` rows for the role.

* Each cell equals one row in the `DataRight` table. The "data-owned-by" values are stored in the `DataRight.RelationshipToOwner` field.

* The rights for the different data objects are stored by varying the table ID stored in the `DataRight.TableId`.

* The dropdown value in each cell is stored as a CRUD value. Delete = CRUD, while Create = CR.

```SQL
SELECT * FROM dataright WHERE roleid = 4
```

![x][img2]

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
[1]: https://github.com/SuperOfficeDocs/database/blob/main/docs/tables/dataright.md
[2]: https://github.com/SuperOfficeDocs/database/blob/main/docs/tables/functionright.md
[3]: https://github.com/SuperOfficeDocs/database/blob/main/docs/tables/role.md

<!-- Referenced images -->
[img1]: media/admin-role.gif
[img2]: media/dataright-crud.png
[img3]: media/role-diagram.png
