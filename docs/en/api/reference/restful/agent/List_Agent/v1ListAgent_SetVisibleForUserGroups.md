---
title: POST Agents/List/SetVisibleForUserGroups
uid: v1ListAgent_SetVisibleForUserGroups
generated: true
content_type: reference
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionId": 927,
  "ListItemId": 675,
  "UserGroups": [
    {
      "Id": 44,
      "Name": "Pfeffer Group",
      "ToolTip": "Et vel.",
      "Deleted": true,
      "Rank": 373,
      "Type": "pariatur",
      "ColorBlock": 893,
      "IconHint": "consequatur",
      "Selected": true,
      "LastChanged": "2007-08-08T11:24:48.2032781+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "magni",
      "StyleHint": "itaque",
      "Hidden": false,
      "FullName": "Krystel Batz"
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
    "Id": 726,
    "Name": "Huels Inc and Sons",
    "ToolTip": "Atque iure praesentium non eos vel ut.",
    "Deleted": false,
    "Rank": 634,
    "Type": "voluptate",
    "ColorBlock": 314,
    "IconHint": "quia",
    "Selected": true,
    "LastChanged": "2008-04-27T11:24:48.2032781+02:00",
    "ChildItems": [
      {
        "Id": 778,
        "Name": "Borer-Daugherty",
        "ToolTip": "Eaque quod magnam sunt.",
        "Deleted": true,
        "Rank": 579,
        "Type": "velit",
        "ColorBlock": 943,
        "IconHint": "et",
        "Selected": true,
        "LastChanged": "2025-02-27T11:24:48.2032781+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "commodi",
        "StyleHint": "quasi",
        "Hidden": true,
        "FullName": "Parker Batz",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 471
          }
        }
      }
    ],
    "ExtraInfo": "modi",
    "StyleHint": "eius",
    "Hidden": false,
    "FullName": "Alexzander Russel",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 689
      }
    }
  }
]
```