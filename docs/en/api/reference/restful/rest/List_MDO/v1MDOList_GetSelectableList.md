---
title: GET MDOList/{listname}/selectable
uid: v1MDOList_GetSelectableList
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
GET /api/v1/MDOList/{listname}/selectable?additional=est
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/MDOList/{listname}/selectable
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 567,
    "Name": "Buckridge, Bailey and Fritsch",
    "ToolTip": "Quidem tenetur minus quasi in ipsam architecto.",
    "Deleted": true,
    "Rank": 594,
    "Type": "doloribus",
    "ColorBlock": 371,
    "IconHint": "quo",
    "Selected": false,
    "LastChanged": "2006-05-24T17:37:40.0485001+02:00",
    "ChildItems": [
      {
        "Id": 1001,
        "Name": "Turner-Durgan",
        "ToolTip": "Qui placeat consequuntur nobis sunt.",
        "Deleted": false,
        "Rank": 443,
        "Type": "laboriosam",
        "ColorBlock": 949,
        "IconHint": "laudantium",
        "Selected": false,
        "LastChanged": "2021-04-18T17:37:40.0495008+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "repellat",
        "StyleHint": "ut",
        "Hidden": true,
        "FullName": "June Schultz",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 99
          }
        }
      }
    ],
    "ExtraInfo": "sed",
    "StyleHint": "eius",
    "Hidden": false,
    "FullName": "Sim Batz DDS",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 719
      }
    }
  }
]
```