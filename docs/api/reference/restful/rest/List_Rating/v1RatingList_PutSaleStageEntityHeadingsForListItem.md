---
title: PUT List/Rating/Items/{id}/Headings
uid: v1RatingList_PutSaleStageEntityHeadingsForListItem
---

# PUT List/Rating/Items/{id}/Headings

```http
PUT /api/v1/List/Rating/Items/{itemId}/Headings
```

Saves headings for the SaleStageEntity list's item.

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
PUT /api/v1/List/Rating/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 911,
    "Name": "Zboncak-Waters",
    "ToolTip": "Deleniti et rerum.",
    "Deleted": true,
    "Rank": 200,
    "Type": "velit",
    "ColorBlock": 970,
    "IconHint": "ullam",
    "Selected": true,
    "LastChanged": "2011-01-25T11:10:54.538932+01:00",
    "ChildItems": [
      {
        "Id": 743,
        "Name": "Walker Inc and Sons",
        "ToolTip": "Sint et qui qui iste nostrum sit aut.",
        "Deleted": true,
        "Rank": 893,
        "Type": "voluptatem",
        "ColorBlock": 440,
        "IconHint": "at",
        "Selected": false,
        "LastChanged": "2015-09-27T11:10:54.538932+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "placeat",
        "StyleHint": "cumque",
        "Hidden": true,
        "FullName": "Mac Blick Sr."
      }
    ],
    "ExtraInfo": "quia",
    "StyleHint": "sunt",
    "Hidden": true,
    "FullName": "Mr. Perry Rowe"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 46,
    "Name": "VonRueden, Keebler and Bode",
    "ToolTip": "Dolorem eaque.",
    "Deleted": false,
    "Rank": 39,
    "Type": "quis",
    "ColorBlock": 98,
    "IconHint": "veritatis",
    "Selected": false,
    "LastChanged": "2017-09-05T11:10:54.5409296+02:00",
    "ChildItems": [
      {
        "Id": 955,
        "Name": "Carroll LLC",
        "ToolTip": "Voluptatem ab non qui necessitatibus velit.",
        "Deleted": false,
        "Rank": 532,
        "Type": "sint",
        "ColorBlock": 488,
        "IconHint": "et",
        "Selected": false,
        "LastChanged": "2015-10-21T11:10:54.5409296+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "expedita",
        "StyleHint": "consequatur",
        "Hidden": true,
        "FullName": "Torrey Trantow",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 453
          }
        }
      }
    ],
    "ExtraInfo": "maiores",
    "StyleHint": "sed",
    "Hidden": true,
    "FullName": "Joseph Wiza I",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 911
      }
    }
  }
]
```
