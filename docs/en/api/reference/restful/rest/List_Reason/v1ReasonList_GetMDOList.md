---
title: GET List/Reason/MDOItems
uid: v1ReasonList_GetMDOList
generated: true
content_type: reference
---

# GET List/Reason/MDOItems

```http
GET /api/v1/List/Reason/MDOItems
```

Get the MDO list items for "Reason" - with headings and filtering by user group.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| flat | bool |  Flatten the list? Default false. |
| query | string |  Search terms (implies flat=true) |

```http
GET /api/v1/List/Reason/MDOItems?flat=False
GET /api/v1/List/Reason/MDOItems?query=dolorum
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
| ChildItems | array | The child items of the MDOListItem |
| IconHint | string | The Icon hint of the ListItem. Custom field. |
| ColorBlock | int32 | The color indicator of the ListItem color block |
| ExtraInfo | string | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | string | Style hint indicating, information such as background color etc. Custom field. |
| FullName | string | The name of the ListItem in its context |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/List/Reason/MDOItems
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
    "Id": 956,
    "Name": "Ankunding-Koss",
    "ToolTip": "Ipsa nam quo assumenda velit.",
    "Deleted": false,
    "Rank": 672,
    "Type": "animi",
    "ChildItems": [
      {
        "Id": 971,
        "Name": "Gerlach-Parisian",
        "ToolTip": "Consectetur optio tempore fuga.",
        "Deleted": false,
        "Rank": 264,
        "Type": "nesciunt",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "et",
        "ColorBlock": 474,
        "ExtraInfo": "maxime",
        "StyleHint": "officia",
        "FullName": "Korbin Blanca Dicki II",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 609
          }
        }
      }
    ],
    "IconHint": "dolores",
    "ColorBlock": 938,
    "ExtraInfo": "expedita",
    "StyleHint": "nam",
    "FullName": "Koby Rempel",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 265
      }
    }
  }
]
```