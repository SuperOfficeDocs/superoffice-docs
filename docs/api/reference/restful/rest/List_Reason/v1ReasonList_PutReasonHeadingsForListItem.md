---
title: PUT List/Reason/Items/{id}/Headings
uid: v1ReasonList_PutReasonHeadingsForListItem
---

# PUT List/Reason/Items/{id}/Headings

```http
PUT /api/v1/List/Reason/Items/{itemId}/Headings
```

Saves headings for the Reason list's item.

Calls the List agent service SaveHeadingsForListItemFromListDefinition.

| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the headings to be saved. **Required** |

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

## Request Body: entities

The headings to be saved.

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
PUT /api/v1/List/Reason/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 827,
    "Name": "Bergstrom LLC",
    "ToolTip": "Aut et omnis unde ullam iste.",
    "Deleted": false,
    "Rank": 261,
    "Type": "qui",
    "ColorBlock": 630,
    "IconHint": "cupiditate",
    "Selected": true,
    "LastChanged": "2004-08-25T11:10:54.5559343+02:00",
    "ChildItems": [
      {
        "Id": 368,
        "Name": "Doyle Group",
        "ToolTip": "Consequuntur fuga ratione magnam autem odit.",
        "Deleted": false,
        "Rank": 261,
        "Type": "minima",
        "ColorBlock": 911,
        "IconHint": "nisi",
        "Selected": true,
        "LastChanged": "2010-04-27T11:10:54.5559343+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quod",
        "StyleHint": "omnis",
        "Hidden": true,
        "FullName": "Mr. Estelle Bauch"
      }
    ],
    "ExtraInfo": "magni",
    "StyleHint": "alias",
    "Hidden": false,
    "FullName": "Mr. Gage Fritsch"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 955,
    "Name": "Simonis, Gutkowski and Romaguera",
    "ToolTip": "Nostrum quibusdam et quo qui minima voluptates.",
    "Deleted": false,
    "Rank": 27,
    "Type": "voluptatem",
    "ColorBlock": 645,
    "IconHint": "minima",
    "Selected": false,
    "LastChanged": "1999-07-20T11:10:54.5569347+02:00",
    "ChildItems": [
      {
        "Id": 169,
        "Name": "Kilback, Kuhic and Cruickshank",
        "ToolTip": "Eveniet dignissimos aut illum perspiciatis quis eos.",
        "Deleted": false,
        "Rank": 231,
        "Type": "iste",
        "ColorBlock": 78,
        "IconHint": "est",
        "Selected": false,
        "LastChanged": "2018-10-09T11:10:54.5579356+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nobis",
        "StyleHint": "libero",
        "Hidden": true,
        "FullName": "Anissa Marjory Littel PhD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 260
          }
        }
      }
    ],
    "ExtraInfo": "quisquam",
    "StyleHint": "aspernatur",
    "Hidden": true,
    "FullName": "Geoffrey Larkin",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 246
      }
    }
  }
]
```
