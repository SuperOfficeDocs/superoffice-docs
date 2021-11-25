---
title: GET Role/{id}/FunctionRight
id: v1RoleEntity_GetFunctionalRights
---

# GET Role/{id}/FunctionRight

```http
GET /api/v1/Role/{roleId}/FunctionRight
```

Get all functional rights for the given role.

Functional rights not set on the role are not included. MDO List name = 'FunctionRights', extra='role=123'


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.




| Path Part | Type | Description |
|-----------|------|-------------|
| roleId | int32 | The role id to get the functional rights for. **Required** |



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
| Id | int32 | The Id of the ListItem |
| Name | string | The name of the ListItem |
| ToolTip | string | The tooltip of the ListItem |
| Deleted | bool | The deleted status of the ListItem |
| Rank | int32 | The rank of the ListItem |
| Type | string | The type of the ListItem. Custom field. |
| ColorBlock | int32 | The color indicator of the ListItem color block |
| IconHint | string | The Icon hint of the ListItem. Custom field. |
| Selected | bool | True if the ListItem is selected |
| LastChanged | date-time | Time of last change. |
| ChildItems | array | The child items of the SelectableMDOListItem |
| ExtraInfo | string | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | string | Style hint indicating, information such as background color etc. Custom field. |
| Hidden | bool | True if the ListItem is hidden |
| FullName | string | The name of the ListItem in its context |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/Role/{roleId}/FunctionRight
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 218,
    "Name": "Lind-Corkery",
    "ToolTip": "Architecto facilis sed mollitia consequatur aut consequatur.",
    "Deleted": false,
    "Rank": 980,
    "Type": "cupiditate",
    "ColorBlock": 364,
    "IconHint": "quis",
    "Selected": true,
    "LastChanged": "2015-04-26T18:25:50.8778837+02:00",
    "ChildItems": [
      {
        "Id": 440,
        "Name": "Abshire Inc and Sons",
        "ToolTip": "Expedita blanditiis officia ut dicta voluptatem.",
        "Deleted": false,
        "Rank": 785,
        "Type": "aliquid",
        "ColorBlock": 584,
        "IconHint": "qui",
        "Selected": true,
        "LastChanged": "2007-10-28T18:25:50.8778837+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "praesentium",
        "StyleHint": "optio",
        "Hidden": false,
        "FullName": "Ebba Conroy",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 306
          }
        }
      }
    ],
    "ExtraInfo": "odit",
    "StyleHint": "sit",
    "Hidden": false,
    "FullName": "Dexter Jewess I",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 793
      }
    }
  }
]
```