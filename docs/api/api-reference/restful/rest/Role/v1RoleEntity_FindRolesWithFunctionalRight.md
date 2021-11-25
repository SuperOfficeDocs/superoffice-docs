---
title: GET Role/WithFunctionRight/{functionalRightName}
id: v1RoleEntity_FindRolesWithFunctionalRight
---

# GET Role/WithFunctionRight/{functionalRightName}

```http
GET /api/v1/Role/WithFunctionRight/{functionalRightName}
```

Find all roles with a given functional right.

The roles matched must contain the specified functional right. 


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.




| Path Part | Type | Description |
|-----------|------|-------------|
| functionalRightName | string | Functional right name to search for **Required** |



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
| ChildItems | array | The child items of the MDOListItem |
| IconHint | string | The Icon hint of the ListItem. Custom field. |
| ColorBlock | int32 | The color indicator of the ListItem color block |
| ExtraInfo | string | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | string | Style hint indicating, information such as background color etc. Custom field. |
| FullName | string | The name of the ListItem in its context |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/Role/WithFunctionRight/{functionalRightName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 26,
    "Name": "Stroman, Paucek and Bechtelar",
    "ToolTip": "Perspiciatis consectetur cumque deserunt ratione natus.",
    "Deleted": true,
    "Rank": 713,
    "Type": "in",
    "ChildItems": [
      {
        "Id": 652,
        "Name": "Bartoletti LLC",
        "ToolTip": "Cum itaque fugiat molestiae suscipit.",
        "Deleted": true,
        "Rank": 602,
        "Type": "consequatur",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "quia",
        "ColorBlock": 259,
        "ExtraInfo": "aliquam",
        "StyleHint": "nulla",
        "FullName": "Felipa Little",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "transition bricks-and-clicks metrics"
            },
            "FieldType": "System.Int32",
            "FieldLength": 93
          }
        }
      }
    ],
    "IconHint": "culpa",
    "ColorBlock": 354,
    "ExtraInfo": "perferendis",
    "StyleHint": "iste",
    "FullName": "Fae Swaniawski Jr.",
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
        "FieldLength": 699
      }
    }
  }
]
```