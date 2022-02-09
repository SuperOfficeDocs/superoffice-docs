---
title: PUT List/Rating/Items/{id}/Headings
id: v1RatingList_PutSaleStageEntityHeadingsForListItem
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

## Sample Request

```http!
PUT /api/v1/List/Rating/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 529,
    "Name": "Lynch Inc and Sons",
    "ToolTip": "Sint sed sed.",
    "Deleted": true,
    "Rank": 835,
    "Type": "voluptas",
    "ColorBlock": 928,
    "IconHint": "velit",
    "Selected": false,
    "LastChanged": "2010-07-03T18:25:52.1220215+02:00",
    "ChildItems": [
      {
        "Id": 151,
        "Name": "Dietrich Inc and Sons",
        "ToolTip": "Et corrupti id excepturi minus aut ea.",
        "Deleted": false,
        "Rank": 140,
        "Type": "est",
        "ColorBlock": 492,
        "IconHint": "debitis",
        "Selected": true,
        "LastChanged": "2015-03-25T18:25:52.1220215+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ducimus",
        "StyleHint": "mollitia",
        "Hidden": false,
        "FullName": "Lexi Murray"
      }
    ],
    "ExtraInfo": "praesentium",
    "StyleHint": "non",
    "Hidden": false,
    "FullName": "Dax Stoltenberg I"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 185,
    "Name": "Wiza-Kemmer",
    "ToolTip": "Eum iusto molestiae aut.",
    "Deleted": true,
    "Rank": 159,
    "Type": "eum",
    "ColorBlock": 164,
    "IconHint": "qui",
    "Selected": true,
    "LastChanged": "1998-04-11T18:25:52.1230202+02:00",
    "ChildItems": [
      {
        "Id": 975,
        "Name": "Wisoky LLC",
        "ToolTip": "Quam officiis magni.",
        "Deleted": true,
        "Rank": 353,
        "Type": "occaecati",
        "ColorBlock": 783,
        "IconHint": "quos",
        "Selected": true,
        "LastChanged": "2014-06-06T18:25:52.1240194+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "rem",
        "StyleHint": "minima",
        "Hidden": true,
        "FullName": "Dr. Kiarra Ernser",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 875
          }
        }
      }
    ],
    "ExtraInfo": "in",
    "StyleHint": "ut",
    "Hidden": false,
    "FullName": "Mrs. Leilani Heidenreich",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 52
      }
    }
  }
]
```