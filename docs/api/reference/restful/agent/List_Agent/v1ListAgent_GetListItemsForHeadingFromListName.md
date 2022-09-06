---
title: POST Agents/List/GetListItemsForHeadingFromListName
uid: v1ListAgent_GetListItemsForHeadingFromListName
---

# POST Agents/List/GetListItemsForHeadingFromListName

```http
POST /api/v1/Agents/List/GetListItemsForHeadingFromListName
```

List of list items that is selected if under this heading

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetListItemsForHeadingFromListName?$select=name,department,category/id
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

UdListDefinitionName, HeadingId

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionName | string |  |
| HeadingId | int32 |  |

## Response: array

OK

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

## Sample request

```http!
POST /api/v1/Agents/List/GetListItemsForHeadingFromListName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionName": "Weimann Group",
  "HeadingId": 240
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 234,
    "Name": "Tillman-Upton",
    "ToolTip": "Vero in quidem ex repellat nisi.",
    "Deleted": false,
    "Rank": 254,
    "Type": "delectus",
    "ColorBlock": 898,
    "IconHint": "quod",
    "Selected": false,
    "LastChanged": "2001-03-28T11:10:27.1864525+02:00",
    "ChildItems": [
      {
        "Id": 499,
        "Name": "Sanford, Rosenbaum and Dickinson",
        "ToolTip": "Facere cumque.",
        "Deleted": true,
        "Rank": 664,
        "Type": "nostrum",
        "ColorBlock": 543,
        "IconHint": "eius",
        "Selected": false,
        "LastChanged": "2017-04-19T11:10:27.1864525+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ipsum",
        "StyleHint": "totam",
        "Hidden": false,
        "FullName": "Eryn Zulauf V",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 863
          }
        }
      }
    ],
    "ExtraInfo": "itaque",
    "StyleHint": "neque",
    "Hidden": false,
    "FullName": "Serenity Howe",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 838
      }
    }
  }
]
```
