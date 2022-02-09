---
title: GET Role/{id}/DataRight/{tableName}/{relationToOwner}
id: v1RoleEntity_GetDataRight
---

# GET Role/{id}/DataRight/{tableName}/{relationToOwner}

```http
GET /api/v1/Role/{roleId}/DataRight/{tableName}/{relationToOwner}
```

Read one specific data right at the given position.

An exception will be thrown if non existing position is specified.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.




| Path Part | Type | Description |
|-----------|------|-------------|
| roleId | int32 | The role id to set the data right for **Required** |
| tableName | string | The name of the entity/table **Required** |
| relationToOwner | Enum: MyOwn, PrimaryGroup, OtherAssociates, OtherGroups, ExternalUser, Anonymous, MyCompany, SameProject | The id of the relation to owner **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: string



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: string


## Sample Request

```http!
GET /api/v1/Role/{roleId}/DataRight/{tableName}/{relationToOwner}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

"autem"
```