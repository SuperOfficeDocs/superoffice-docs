---
title: POST Agents/List/SetVisibleForUserGroups
uid: v1ListAgent_SetVisibleForUserGroups
generated: true
---

# POST Agents/List/SetVisibleForUserGroups

```http
POST /api/v1/Agents/List/SetVisibleForUserGroups
```

Update User groups that this list item is visible for







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SetVisibleForUserGroups?$select=name,department,category/id
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

## Request Body: request 

UdListDefinitionId, ListItemId, UserGroups 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionId | Integer |  |
| ListItemId | Integer |  |
| UserGroups | Array |  |

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
POST /api/v1/Agents/List/SetVisibleForUserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionId": 402,
  "ListItemId": 945,
  "UserGroups": [
    {
      "Id": 379,
      "Name": "Mosciski LLC",
      "ToolTip": "Ex sed magni.",
      "Deleted": false,
      "Rank": 111,
      "Type": "voluptatem",
      "ColorBlock": 249,
      "IconHint": "mollitia",
      "Selected": true,
      "LastChanged": "2013-01-09T12:01:27.9471677+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "asperiores",
      "Hidden": false,
      "FullName": "Prof. Talon Tillman Gislason PhD"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 246,
    "Name": "Kassulke-O'Hara",
    "ToolTip": "Reprehenderit aspernatur suscipit provident sit.",
    "Deleted": false,
    "Rank": 781,
    "Type": "ut",
    "ColorBlock": 653,
    "IconHint": "voluptatum",
    "Selected": false,
    "LastChanged": "2022-12-30T12:01:27.9471677+01:00",
    "ChildItems": [
      {
        "Id": 247,
        "Name": "White LLC",
        "ToolTip": "Explicabo qui eveniet et qui quis natus.",
        "Deleted": false,
        "Rank": 858,
        "Type": "qui",
        "ColorBlock": 68,
        "IconHint": "atque",
        "Selected": true,
        "LastChanged": "2014-12-28T12:01:27.9471677+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "distinctio",
        "StyleHint": "accusantium",
        "Hidden": true,
        "FullName": "Ms. Eldora Champlin",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 144
          }
        }
      }
    ],
    "ExtraInfo": "quod",
    "StyleHint": "libero",
    "Hidden": true,
    "FullName": "Prof. Aileen Harber DVM",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 109
      }
    }
  }
]
```