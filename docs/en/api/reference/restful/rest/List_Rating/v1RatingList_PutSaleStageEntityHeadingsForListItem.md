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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 928,
    "Name": "Yundt Inc and Sons",
    "ToolTip": "Saepe maxime explicabo quae.",
    "Deleted": false,
    "Rank": 721,
    "Type": "et",
    "ColorBlock": 606,
    "IconHint": "et",
    "Selected": true,
    "LastChanged": "2008-07-13T02:49:52.4534506+02:00",
    "ChildItems": [
      {
        "Id": 298,
        "Name": "Koepp Group",
        "ToolTip": "Illum cupiditate unde quia velit velit.",
        "Deleted": false,
        "Rank": 636,
        "Type": "ipsam",
        "ColorBlock": 761,
        "IconHint": "odit",
        "Selected": false,
        "LastChanged": "2001-05-09T02:49:52.4534506+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "itaque",
        "StyleHint": "minima",
        "Hidden": true,
        "FullName": "Maye Carol Maggio PhD"
      }
    ],
    "ExtraInfo": "odio",
    "StyleHint": "aut",
    "Hidden": true,
    "FullName": "Joany Gislason"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 102,
    "Name": "Schneider, Yost and Rolfson",
    "ToolTip": "Ullam officiis rem error.",
    "Deleted": true,
    "Rank": 509,
    "Type": "impedit",
    "ColorBlock": 809,
    "IconHint": "eligendi",
    "Selected": false,
    "LastChanged": "1998-05-15T02:49:52.4534506+02:00",
    "ChildItems": [
      {
        "Id": 652,
        "Name": "Dietrich-Wilkinson",
        "ToolTip": "Voluptatem ipsam laborum quia magni ipsa.",
        "Deleted": true,
        "Rank": 804,
        "Type": "voluptatem",
        "ColorBlock": 210,
        "IconHint": "est",
        "Selected": false,
        "LastChanged": "1995-10-17T02:49:52.4534506+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "veritatis",
        "StyleHint": "officia",
        "Hidden": true,
        "FullName": "Gabriella Ortiz",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 485
          }
        }
      }
    ],
    "ExtraInfo": "odit",
    "StyleHint": "soluta",
    "Hidden": true,
    "FullName": "Vada Stiedemann",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 783
      }
    }
  }
]
```