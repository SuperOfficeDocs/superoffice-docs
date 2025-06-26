---
title: GET MDOList/{listname}/selectable
uid: v1MDOList_GetSelectableList
generated: true
---

# GET MDOList/{listname}/selectable

```http
GET /api/v1/MDOList/{listname}/selectable
```

Return the selectable list items






| Path Part | Type | Description |
|-----------|------|-------------|
| listname | string | "category", "business" etc **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| additional | string |  List-specific additional info. |
| flat | bool |  true/false |

```http
GET /api/v1/MDOList/{listname}/selectable?additional=officia
GET /api/v1/MDOList/{listname}/selectable?flat=False
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
GET /api/v1/MDOList/{listname}/selectable
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 109,
    "Name": "Torp-Gottlieb",
    "ToolTip": "Odit veritatis a eum pariatur ducimus.",
    "Deleted": false,
    "Rank": 936,
    "Type": "consequatur",
    "ColorBlock": 1002,
    "IconHint": "possimus",
    "Selected": false,
    "LastChanged": "2013-07-14T03:45:29.060917+02:00",
    "ChildItems": [
      {
        "Id": 196,
        "Name": "Macejkovic, Turner and Harber",
        "ToolTip": "Provident voluptas sed qui voluptatem temporibus.",
        "Deleted": false,
        "Rank": 564,
        "Type": "ullam",
        "ColorBlock": 687,
        "IconHint": "magni",
        "Selected": false,
        "LastChanged": "2002-08-04T03:45:29.060917+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "occaecati",
        "StyleHint": "atque",
        "Hidden": false,
        "FullName": "Mr. Kaia Jalyn Bernhard PhD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 149
          }
        }
      }
    ],
    "ExtraInfo": "aut",
    "StyleHint": "voluptatem",
    "Hidden": false,
    "FullName": "Mable Adams",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 899
      }
    }
  }
]
```