---
title: GET List/PaymentTerm/MDOItems
uid: v1PaymentTermsList_GetMDOList
generated: true
---

# GET List/PaymentTerm/MDOItems

```http
GET /api/v1/List/PaymentTerm/MDOItems
```

Get the MDO list items for "PaymentTerms" - with headings and filtering by user group.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| flat | bool |  Flatten the list? Default false. |
| query | string |  Search terms (implies flat=true) |

```http
GET /api/v1/List/PaymentTerm/MDOItems?flat=True
GET /api/v1/List/PaymentTerm/MDOItems?query=rerum
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
GET /api/v1/List/PaymentTerm/MDOItems
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 352,
    "Name": "Marvin, Erdman and Hansen",
    "ToolTip": "Sapiente nihil doloribus dolor quidem.",
    "Deleted": false,
    "Rank": 394,
    "Type": "ducimus",
    "ChildItems": [
      {
        "Id": 151,
        "Name": "Rempel, Frami and Gislason",
        "ToolTip": "Et et porro.",
        "Deleted": false,
        "Rank": 929,
        "Type": "ipsa",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "laborum",
        "ColorBlock": 653,
        "ExtraInfo": "animi",
        "StyleHint": "explicabo",
        "FullName": "Miss Yazmin Garry O'Conner",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 925
          }
        }
      }
    ],
    "IconHint": "est",
    "ColorBlock": 884,
    "ExtraInfo": "quas",
    "StyleHint": "harum",
    "FullName": "Dayna Hettinger",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 238
      }
    }
  }
]
```