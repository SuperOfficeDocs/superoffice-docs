---
title: PUT List/Business/Items/{id}/Headings
uid: v1BusinessList_PutBusinessHeadingsForListItem
generated: true
content_type: reference
---

# PUT List/Business/Items/{id}/Headings

```http
PUT /api/v1/List/Business/Items/{itemId}/Headings
```

Saves headings for the Business list's item.


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
| Id | Integer | The Id of the ListItem |
| Name | String | The name of the ListItem |
| ToolTip | String | The tooltip of the ListItem |
| Deleted | Boolean | The deleted status of the ListItem |
| Rank | Integer | The rank of the ListItem |
| Type | String | The type of the ListItem. Custom field. |
| ColorBlock | Integer | The color indicator of the ListItem color block |
| IconHint | String | The Icon hint of the ListItem. Custom field. |
| Selected | Boolean | True if the ListItem is selected |
| LastChanged | String | Time of last change. |
| ChildItems | Array | The child items of the SelectableMDOListItem |
| ExtraInfo | String | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | String | Style hint indicating, information such as background color etc. Custom field. |
| Hidden | Boolean | True if the ListItem is hidden |
| FullName | String | The name of the ListItem in its context |

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
PUT /api/v1/List/Business/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 226,
    "Name": "Rutherford-Bergstrom",
    "ToolTip": "A id suscipit repudiandae.",
    "Deleted": true,
    "Rank": 648,
    "Type": "dignissimos",
    "ColorBlock": 557,
    "IconHint": "ut",
    "Selected": false,
    "LastChanged": "2011-01-27T03:41:59.339865+01:00",
    "ChildItems": [
      {
        "Id": 721,
        "Name": "Bode-Walker",
        "ToolTip": "Cumque suscipit est.",
        "Deleted": true,
        "Rank": 433,
        "Type": "veniam",
        "ColorBlock": 866,
        "IconHint": "iure",
        "Selected": true,
        "LastChanged": "2011-09-07T03:41:59.339865+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aspernatur",
        "StyleHint": "error",
        "Hidden": false,
        "FullName": "Bridie Larry Zieme I"
      }
    ],
    "ExtraInfo": "molestias",
    "StyleHint": "ipsam",
    "Hidden": false,
    "FullName": "Justen Fritsch"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 66,
    "Name": "Aufderhar-Brown",
    "ToolTip": "Dicta fuga eius praesentium dolorem.",
    "Deleted": false,
    "Rank": 410,
    "Type": "vero",
    "ColorBlock": 4,
    "IconHint": "exercitationem",
    "Selected": true,
    "LastChanged": "1998-07-08T03:41:59.339865+02:00",
    "ChildItems": [
      {
        "Id": 86,
        "Name": "Hoeger, Bartoletti and Gusikowski",
        "ToolTip": "Natus similique deleniti consectetur.",
        "Deleted": true,
        "Rank": 756,
        "Type": "placeat",
        "ColorBlock": 158,
        "IconHint": "ut",
        "Selected": true,
        "LastChanged": "1998-12-26T03:41:59.339865+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vero",
        "StyleHint": "amet",
        "Hidden": true,
        "FullName": "Joy Hamill",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 785
          }
        }
      }
    ],
    "ExtraInfo": "quis",
    "StyleHint": "iusto",
    "Hidden": true,
    "FullName": "Kaleigh Boehm",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 278
      }
    }
  }
]
```