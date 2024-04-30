---
title: PUT List/SaleType/Items/{id}/Headings
uid: v1SaleTypeList_PutSaleTypeEntityHeadingsForListItem
generated: true
---

# PUT List/SaleType/Items/{id}/Headings

```http
PUT /api/v1/List/SaleType/Items/{itemId}/Headings
```

Saves headings for the SaleTypeEntity list's item.


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
PUT /api/v1/List/SaleType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 592,
    "Name": "Gulgowski-Hirthe",
    "ToolTip": "Enim officiis.",
    "Deleted": true,
    "Rank": 165,
    "Type": "rerum",
    "ColorBlock": 400,
    "IconHint": "aliquid",
    "Selected": false,
    "LastChanged": "2015-05-14T11:16:14.7307772+02:00",
    "ChildItems": [
      {
        "Id": 313,
        "Name": "Larson, Hyatt and Metz",
        "ToolTip": "Voluptas vero quasi et hic.",
        "Deleted": false,
        "Rank": 71,
        "Type": "laboriosam",
        "ColorBlock": 857,
        "IconHint": "delectus",
        "Selected": true,
        "LastChanged": "2021-12-19T11:16:14.7307772+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "id",
        "StyleHint": "consequatur",
        "Hidden": false,
        "FullName": "Hester Douglas"
      }
    ],
    "ExtraInfo": "aliquam",
    "StyleHint": "suscipit",
    "Hidden": true,
    "FullName": "Leanna Robel"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 502,
    "Name": "Schimmel, Raynor and Pfeffer",
    "ToolTip": "Non corporis qui odio sint.",
    "Deleted": false,
    "Rank": 819,
    "Type": "autem",
    "ColorBlock": 95,
    "IconHint": "autem",
    "Selected": true,
    "LastChanged": "2013-01-12T11:16:14.7620242+01:00",
    "ChildItems": [
      {
        "Id": 875,
        "Name": "Klocko-Lind",
        "ToolTip": "Rerum aut atque.",
        "Deleted": false,
        "Rank": 678,
        "Type": "aut",
        "ColorBlock": 124,
        "IconHint": "veniam",
        "Selected": false,
        "LastChanged": "2017-05-15T11:16:14.7620242+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quidem",
        "StyleHint": "asperiores",
        "Hidden": false,
        "FullName": "Emerald Huels",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 353
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "adipisci",
    "Hidden": false,
    "FullName": "Mozelle Jones",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 168
      }
    }
  }
]
```