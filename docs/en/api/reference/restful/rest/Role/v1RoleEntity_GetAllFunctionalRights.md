---
title: GET Role/{roleType}/FunctionRight
uid: v1RoleEntity_GetAllFunctionalRights
generated: true
---

# GET Role/{roleType}/FunctionRight

```http
GET /api/v1/Role/{roleType}/FunctionRight
```

Get a list of all functional rights for the given type of role.


MDO List name = 'FunctionRights', extra='roleType=0' 


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





| Path Part | Type | Description |
|-----------|------|-------------|
| roleType | Enum: Employee, ExternalUser, Anonymous, System | Type of role (Employee/External/Anonymous/System) **Required** |



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


## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/Role/{roleType}/FunctionRight
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 776,
    "Name": "Fahey Group",
    "ToolTip": "Qui est et sint voluptatem earum.",
    "Deleted": false,
    "Rank": 313,
    "Type": "nisi",
    "ColorBlock": 677,
    "IconHint": "quam",
    "Selected": true,
    "LastChanged": "2003-02-28T13:57:19.1403101+01:00",
    "ChildItems": [
      {
        "Id": 643,
        "Name": "Yost Inc and Sons",
        "ToolTip": "Voluptatibus ad reiciendis sit et.",
        "Deleted": false,
        "Rank": 827,
        "Type": "qui",
        "ColorBlock": 787,
        "IconHint": "aut",
        "Selected": false,
        "LastChanged": "2003-02-05T13:57:19.1403101+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolorem",
        "StyleHint": "porro",
        "Hidden": true,
        "FullName": "Deja Erick Schmitt DDS",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 311
          }
        }
      }
    ],
    "ExtraInfo": "suscipit",
    "StyleHint": "molestiae",
    "Hidden": false,
    "FullName": "Dr. Lyda Goldner",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 90
      }
    }
  }
]
```