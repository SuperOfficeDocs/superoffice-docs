---
title: GET List/PaymentType/MDOItems
uid: v1PaymentTypeList_GetMDOList
---

# GET List/PaymentType/MDOItems

```http
GET /api/v1/List/PaymentType/MDOItems
```

Get the MDO list items for "PaymentType" - with headings and filtering by user group.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| flat | bool |  Flatten the list? Default false. |
| query | string |  Search terms (implies flat=true) |

```http
GET /api/v1/List/PaymentType/MDOItems?flat=True
GET /api/v1/List/PaymentType/MDOItems?query=est
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/List/PaymentType/MDOItems
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
    "Id": 493,
    "Name": "Bashirian, Lubowitz and Schuster",
    "ToolTip": "Quia ut.",
    "Deleted": false,
    "Rank": 167,
    "Type": "quia",
    "ChildItems": [
      {
        "Id": 532,
        "Name": "Bosco-Oberbrunner",
        "ToolTip": "Voluptatibus sed inventore rerum fugit qui saepe.",
        "Deleted": false,
        "Rank": 369,
        "Type": "est",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "molestiae",
        "ColorBlock": 252,
        "ExtraInfo": "quidem",
        "StyleHint": "qui",
        "FullName": "Earl Lehner I",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 478
          }
        }
      }
    ],
    "IconHint": "aliquam",
    "ColorBlock": 50,
    "ExtraInfo": "temporibus",
    "StyleHint": "occaecati",
    "FullName": "Cassandra Parisian",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 171
      }
    }
  }
]
```