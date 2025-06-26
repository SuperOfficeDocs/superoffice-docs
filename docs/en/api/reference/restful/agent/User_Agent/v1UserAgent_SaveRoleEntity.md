---
title: POST Agents/User/SaveRoleEntity
uid: v1UserAgent_SaveRoleEntity
generated: true
---

# POST Agents/User/SaveRoleEntity

```http
POST /api/v1/Agents/User/SaveRoleEntity
```

Updates the existing RoleEntity or creates a new RoleEntity if the id parameter is empty


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.







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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: RoleEntity

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

## Sample request

```http!
POST /api/v1/Agents/User/SaveRoleEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "RoleId": 349,
  "Name": "Mertz-Simonis",
  "Tooltip": "ducimus",
  "RoleType": "Anonymous",
  "Deleted": 829,
  "Rank": 530,
  "Created": "2009-07-14T03:45:24.1548097+02:00",
  "UseCategories": 541,
  "CreatedBy": null,
  "Updated": "2008-08-09T03:45:24.1548097+02:00",
  "UpdatedBy": null,
  "DataRights": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RoleId": 324,
  "Name": "Cruickshank, Satterfield and Kuhic",
  "Tooltip": "ullam",
  "RoleType": "Anonymous",
  "Deleted": 255,
  "Rank": 470,
  "Created": "2024-10-20T03:45:24.1548097+02:00",
  "UseCategories": 521,
  "CreatedBy": null,
  "Updated": "2010-07-08T03:45:24.1548097+02:00",
  "UpdatedBy": null,
  "DataRights": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 915
    }
  }
}
```