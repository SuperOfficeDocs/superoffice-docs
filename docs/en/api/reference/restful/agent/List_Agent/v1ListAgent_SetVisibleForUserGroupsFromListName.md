---
title: POST Agents/List/SetVisibleForUserGroupsFromListName
uid: v1ListAgent_SetVisibleForUserGroupsFromListName
---

# POST Agents/List/SetVisibleForUserGroupsFromListName

```http
POST /api/v1/Agents/List/SetVisibleForUserGroupsFromListName
```

Update User groups that this list item is visible for







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SetVisibleForUserGroupsFromListName?$select=name,department,category/id
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

UdListDefinitionName, ListItemId, UserGroups 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionName | String |  |
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
POST /api/v1/Agents/List/SetVisibleForUserGroupsFromListName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionName": "Konopelski Group",
  "ListItemId": 961,
  "UserGroups": [
    {
      "Id": 281,
      "Name": "Bernier, Kuhic and Barrows",
      "ToolTip": "Eligendi id ut sed sequi.",
      "Deleted": false,
      "Rank": 378,
      "Type": "accusantium",
      "ColorBlock": 543,
      "IconHint": "quam",
      "Selected": false,
      "LastChanged": "2021-06-26T15:29:22.012272+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "expedita",
      "Hidden": false,
      "FullName": "Mr. Keanu Little"
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
    "Id": 202,
    "Name": "Gislason Inc and Sons",
    "ToolTip": "Voluptates nemo vero suscipit voluptates magni ex odio.",
    "Deleted": false,
    "Rank": 788,
    "Type": "incidunt",
    "ColorBlock": 74,
    "IconHint": "corrupti",
    "Selected": true,
    "LastChanged": "2012-07-02T15:29:22.0132728+02:00",
    "ChildItems": [
      {
        "Id": 267,
        "Name": "Stroman-Buckridge",
        "ToolTip": "Doloribus ipsam labore et adipisci doloribus.",
        "Deleted": false,
        "Rank": 781,
        "Type": "enim",
        "ColorBlock": 64,
        "IconHint": "illo",
        "Selected": false,
        "LastChanged": "2014-12-22T15:29:22.0132728+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aliquam",
        "StyleHint": "sit",
        "Hidden": false,
        "FullName": "Prof. Anibal Randy Stamm",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 598
          }
        }
      }
    ],
    "ExtraInfo": "voluptatem",
    "StyleHint": "doloribus",
    "Hidden": true,
    "FullName": "Vilma Eichmann",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 798
      }
    }
  }
]
```