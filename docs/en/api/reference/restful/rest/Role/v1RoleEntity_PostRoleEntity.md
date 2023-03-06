---
title: POST Role
uid: v1RoleEntity_PostRoleEntity
---

# POST Role

```http
POST /api/v1/Role
```

Creates a new RoleEntity


Calls the User agent service SaveRoleEntity.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Role?$select=name,department,category/id
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

## Request Body: newEntity 

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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Role
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "RoleId": 342,
  "Name": "Watsica, Schamberger and Yundt",
  "Tooltip": "quaerat",
  "RoleType": "Anonymous",
  "Deleted": 484,
  "Rank": 136,
  "Created": "2004-01-01T14:19:10.6467484+01:00",
  "UseCategories": 919,
  "CreatedBy": null,
  "Updated": "2011-04-10T14:19:10.6467484+02:00",
  "UpdatedBy": null,
  "DataRights": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RoleId": 188,
  "Name": "Heidenreich-Wilkinson",
  "Tooltip": "quo",
  "RoleType": "Anonymous",
  "Deleted": 654,
  "Rank": 80,
  "Created": "2021-03-28T14:19:10.6467484+02:00",
  "UseCategories": 573,
  "CreatedBy": null,
  "Updated": "1997-11-18T14:19:10.6467484+01:00",
  "UpdatedBy": null,
  "DataRights": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 231
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```