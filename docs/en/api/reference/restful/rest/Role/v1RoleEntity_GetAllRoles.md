---
title: GET Role/{roleType}
uid: v1RoleEntity_GetAllRoles
generated: true
content_type: reference
---

# GET Role/{roleType}

```http
GET /api/v1/Role/{roleType}
```

Get a list of all roles for the given type of role.


MDO List name = 'Roles', extra='0' (roleType) 


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
GET /api/v1/Role/{roleType}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 119,
    "Name": "Treutel LLC",
    "ToolTip": "Ut praesentium corrupti.",
    "Deleted": false,
    "Rank": 643,
    "Type": "aperiam",
    "ColorBlock": 353,
    "IconHint": "necessitatibus",
    "Selected": false,
    "LastChanged": "2012-11-12T03:47:00.2224384+01:00",
    "ChildItems": [
      {
        "Id": 577,
        "Name": "Jenkins-Stracke",
        "ToolTip": "Delectus ex nemo cumque dolores.",
        "Deleted": true,
        "Rank": 419,
        "Type": "sed",
        "ColorBlock": 938,
        "IconHint": "et",
        "Selected": false,
        "LastChanged": "2014-10-25T03:47:00.2224384+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "qui",
        "StyleHint": "alias",
        "Hidden": false,
        "FullName": "Ofelia Gregory Heaney DVM",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 542
          }
        }
      }
    ],
    "ExtraInfo": "consequuntur",
    "StyleHint": "necessitatibus",
    "Hidden": true,
    "FullName": "Mr. Edd Keanu Orn",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 528
      }
    }
  }
]
```