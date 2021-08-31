---
title: PUT Role/{id}/DataRight/{tableName}/{relationToOwner}
id: v1RoleEntity_SetDataRight
---

# PUT Role/{id}/DataRight/{tableName}/{relationToOwner}

```http
PUT /api/v1/Role/{roleId}/DataRight/{tableName}/{relationToOwner}
```

Set one specific data right at the given position.

An exception will be thrown if non existing position is specified.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.




| Path Part | Type | Description |
|-----------|------|-------------|
| roleId | int32 | The role id to set the data right for **Required** |
| tableName | string | The name of the entity/table **Required** |
| relationToOwner | Enum: MyOwn, PrimaryGroup, OtherAssociates, OtherGroups, ExternalUser, Anonymous, MyCompany, SameProject | The id of the relation to owner **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| dataRightValue | string | **Required** The data right value to set at the specified position (CRUD) |

```http
PUT /api/v1/Role/{roleId}/DataRight/{tableName}/{relationToOwner}?dataRightValue=deleniti
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |