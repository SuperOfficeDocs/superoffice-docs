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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "RoleId": 499,
  "Name": "Casper, Bergnaum and Grimes",
  "Tooltip": "cumque",
  "RoleType": "Anonymous",
  "Deleted": 47,
  "Rank": 939,
  "Created": "2009-02-18T16:00:48.1959227+01:00",
  "UseCategories": 476,
  "CreatedBy": null,
  "Updated": "2022-10-19T16:00:48.1959227+02:00",
  "UpdatedBy": null,
  "DataRights": null
}
```

## Sample response

```http_
HTTP/1.1 200 RoleEntity updated.
Content-Type: application/json; charset=utf-8

{
  "RoleId": 178,
  "Name": "Bashirian-Lynch",
  "Tooltip": "soluta",
  "RoleType": "Anonymous",
  "Deleted": 177,
  "Rank": 785,
  "Created": "2001-05-01T16:00:48.1959227+02:00",
  "UseCategories": 49,
  "CreatedBy": null,
  "Updated": "2003-04-09T16:00:48.1959227+02:00",
  "UpdatedBy": null,
  "DataRights": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 496
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```