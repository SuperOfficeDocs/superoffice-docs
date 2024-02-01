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
  "UdListDefinitionId": 154,
  "ListItemId": 347,
  "UserGroups": [
    {
      "Id": 576,
      "Name": "Hane LLC",
      "ToolTip": "Sequi ipsum quidem.",
      "Deleted": true,
      "Rank": 419,
      "Type": "cupiditate",
      "ColorBlock": 173,
      "IconHint": "consequatur",
      "Selected": true,
      "LastChanged": "2014-06-01T23:03:56.209126+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sapiente",
      "StyleHint": "enim",
      "Hidden": true,
      "FullName": "Miss Ozella Turcotte"
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
    "Id": 381,
    "Name": "Mohr LLC",
    "ToolTip": "Et provident.",
    "Deleted": true,
    "Rank": 408,
    "Type": "repellat",
    "ColorBlock": 42,
    "IconHint": "quia",
    "Selected": true,
    "LastChanged": "2004-12-22T23:03:56.2101257+01:00",
    "ChildItems": [
      {
        "Id": 47,
        "Name": "Wolf Group",
        "ToolTip": "Voluptatem quidem mollitia dolores iure neque.",
        "Deleted": false,
        "Rank": 596,
        "Type": "odio",
        "ColorBlock": 962,
        "IconHint": "officia",
        "Selected": false,
        "LastChanged": "2023-07-16T23:03:56.2101257+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "facere",
        "StyleHint": "illo",
        "Hidden": true,
        "FullName": "Dr. Lesley Lueilwitz Jr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 605
          }
        }
      }
    ],
    "ExtraInfo": "omnis",
    "StyleHint": "modi",
    "Hidden": true,
    "FullName": "Miss Jackson Upton Sr.",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 910
      }
    }
  }
]
```