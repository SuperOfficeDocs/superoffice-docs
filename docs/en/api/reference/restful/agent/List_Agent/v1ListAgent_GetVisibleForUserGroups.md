---
title: POST Agents/List/GetVisibleForUserGroups
uid: v1ListAgent_GetVisibleForUserGroups
generated: true
---

# POST Agents/List/GetVisibleForUserGroups

```http
POST /api/v1/Agents/List/GetVisibleForUserGroups
```

List of User groups that this list item is visible for







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetVisibleForUserGroups?$select=name,department,category/id
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

UdListDefinitionId, ListItemId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionId | Integer |  |
| ListItemId | Integer |  |

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
POST /api/v1/Agents/List/GetVisibleForUserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionId": 31,
  "ListItemId": 887
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 111,
    "Name": "Sporer Group",
    "ToolTip": "Vel et voluptate voluptatem quae reprehenderit.",
    "Deleted": false,
    "Rank": 405,
    "Type": "necessitatibus",
    "ColorBlock": 94,
    "IconHint": "saepe",
    "Selected": false,
    "LastChanged": "2011-07-26T16:00:41.1487084+02:00",
    "ChildItems": [
      {
        "Id": 835,
        "Name": "Gleason-Rohan",
        "ToolTip": "Explicabo explicabo porro.",
        "Deleted": false,
        "Rank": 827,
        "Type": "velit",
        "ColorBlock": 670,
        "IconHint": "est",
        "Selected": false,
        "LastChanged": "2014-05-27T16:00:41.1487084+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eaque",
        "StyleHint": "et",
        "Hidden": true,
        "FullName": "Kelvin Maggio",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 639
          }
        }
      }
    ],
    "ExtraInfo": "ullam",
    "StyleHint": "sit",
    "Hidden": false,
    "FullName": "Rodger Lueilwitz",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 93
      }
    }
  }
]
```