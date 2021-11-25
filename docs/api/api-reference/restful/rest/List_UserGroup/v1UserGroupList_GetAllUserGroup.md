---
title: GET List/UserGroup/Items
id: v1UserGroupList_GetAllUserGroup
---

# GET List/UserGroup/Items

```http
GET /api/v1/List/UserGroup/Items
```

Gets a list of all UserGroup list items.

Calls the User agent service GetAllUserGroup.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| includeDeleted | bool |   |

```http
GET /api/v1/List/UserGroup/Items?includeDeleted=False
```


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


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Value | string | UserGroup name |
| Tooltip | string | Tooltip or other description |
| Id | int32 | Primary key |
| Rank | int32 | Rank order |
| Deleted | bool | Deleted equal to true means that this is a user group that no longer can be selected by the user.  It is not permitted to delete a UserGroup. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/List/UserGroup/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Value": "harum",
    "Tooltip": "corrupti",
    "Id": 867,
    "Rank": 608,
    "Deleted": true,
    "TableRight": {
      "Mask": "Delete",
      "Reason": "empower customized e-services"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 333
      }
    }
  }
]
```