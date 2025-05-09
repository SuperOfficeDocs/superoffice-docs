---
title: PUT List/Currency/Items/{id}/Headings
uid: v1CurrencyList_PutCurrencyEntityHeadingsForListItem
generated: true
---

# PUT List/Currency/Items/{id}/Headings

```http
PUT /api/v1/List/Currency/Items/{itemId}/Headings
```

Saves headings for the CurrencyEntity list's item.


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
PUT /api/v1/List/Currency/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 559,
    "Name": "Herzog, Heller and Rosenbaum",
    "ToolTip": "Voluptate sunt neque dolores est.",
    "Deleted": true,
    "Rank": 60,
    "Type": "molestias",
    "ColorBlock": 767,
    "IconHint": "officiis",
    "Selected": false,
    "LastChanged": "2007-01-14T16:32:48.6339153+01:00",
    "ChildItems": [
      {
        "Id": 623,
        "Name": "Schultz LLC",
        "ToolTip": "Veritatis animi necessitatibus iusto non et.",
        "Deleted": false,
        "Rank": 127,
        "Type": "ut",
        "ColorBlock": 149,
        "IconHint": "nam",
        "Selected": false,
        "LastChanged": "2020-09-17T16:32:48.6339153+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "delectus",
        "StyleHint": "sunt",
        "Hidden": false,
        "FullName": "Peggie West"
      }
    ],
    "ExtraInfo": "facilis",
    "StyleHint": "facilis",
    "Hidden": false,
    "FullName": "Diamond Altenwerth"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 695,
    "Name": "Lubowitz LLC",
    "ToolTip": "Est minus quia illum quia eligendi et vero.",
    "Deleted": false,
    "Rank": 504,
    "Type": "aperiam",
    "ColorBlock": 259,
    "IconHint": "voluptatem",
    "Selected": false,
    "LastChanged": "2005-12-04T16:32:48.6339153+01:00",
    "ChildItems": [
      {
        "Id": 398,
        "Name": "Baumbach LLC",
        "ToolTip": "Nemo ipsum omnis quaerat magni.",
        "Deleted": true,
        "Rank": 273,
        "Type": "dolorem",
        "ColorBlock": 762,
        "IconHint": "praesentium",
        "Selected": false,
        "LastChanged": "2023-02-24T16:32:48.6339153+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vero",
        "StyleHint": "minus",
        "Hidden": false,
        "FullName": "Regan Ruecker",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 383
          }
        }
      }
    ],
    "ExtraInfo": "incidunt",
    "StyleHint": "laborum",
    "Hidden": false,
    "FullName": "Prof. Kiarra Gerardo Cummings MD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 269
      }
    }
  }
]
```