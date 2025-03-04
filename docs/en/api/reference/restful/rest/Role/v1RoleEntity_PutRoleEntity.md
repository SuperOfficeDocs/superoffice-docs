---
title: PUT Role/{id}
uid: v1RoleEntity_PutRoleEntity
generated: true
---

# PUT Role/{id}

```http
PUT /api/v1/Role/{id}
```

Updates the existing RoleEntity


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The RoleEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Role/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity 

The RoleEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| RoleId | Integer | Primary key |
| Name | String | Visible role name |
| Tooltip | String | Description of the role. |
| RoleType | String | The role type. Note that changing this field has no effect, so treat this as a read-only field. |
| Deleted | Integer | 1 if role has been deleted (we do not actually delete) |
| Rank | Integer | Sorting rank of this role in lists |
| Created | String | Registered when  in UTC. |
| UseCategories | Integer | Apply role category membership to users |
| CreatedBy | Associate | Created by user |
| Updated | String | Last updated when  in UTC. |
| UpdatedBy | Associate | Last updated by user |
| DataRights | DataRights | Data rights matrix - defines role's access to data owned by current user, users in same group, and other users. |

## Response:

RoleEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | RoleEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: RoleEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| RoleId | int32 | Primary key |
| Name | string | Visible role name |
| Tooltip | string | Description of the role. |
| RoleType | string | The role type. Note that changing this field has no effect, so treat this as a read-only field. |
| Deleted | int32 | 1 if role has been deleted (we do not actually delete) |
| Rank | int32 | Sorting rank of this role in lists |
| Created | date-time | Registered when  in UTC. |
| UseCategories | int32 | Apply role category membership to users |
| CreatedBy | Associate | Created by user |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedBy | Associate | Last updated by user |
| DataRights | DataRights | Data rights matrix - defines role's access to data owned by current user, users in same group, and other users. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Role/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "RoleId": 999,
  "Name": "Metz, Gutmann and Weimann",
  "Tooltip": "fugit",
  "RoleType": "Anonymous",
  "Deleted": 827,
  "Rank": 366,
  "Created": "2020-10-23T14:13:49.1025081+02:00",
  "UseCategories": 884,
  "CreatedBy": null,
  "Updated": "1999-04-15T14:13:49.1025081+02:00",
  "UpdatedBy": null,
  "DataRights": null
}
```

## Sample response

```http_
HTTP/1.1 200 RoleEntity updated.
Content-Type: application/json; charset=utf-8

{
  "RoleId": 500,
  "Name": "Dicki Group",
  "Tooltip": "maiores",
  "RoleType": "Anonymous",
  "Deleted": 543,
  "Rank": 453,
  "Created": "1998-05-28T14:13:49.1025081+02:00",
  "UseCategories": 670,
  "CreatedBy": null,
  "Updated": "2001-03-06T14:13:49.1025081+01:00",
  "UpdatedBy": null,
  "DataRights": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 828
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```