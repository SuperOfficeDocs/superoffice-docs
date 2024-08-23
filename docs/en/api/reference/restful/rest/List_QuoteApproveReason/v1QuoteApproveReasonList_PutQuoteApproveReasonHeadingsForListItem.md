---
title: PUT List/QuoteApproveReason/Items/{id}/Headings
uid: v1QuoteApproveReasonList_PutQuoteApproveReasonHeadingsForListItem
generated: true
---

# PUT List/QuoteApproveReason/Items/{id}/Headings

```http
PUT /api/v1/List/QuoteApproveReason/Items/{itemId}/Headings
```

Saves headings for the QuoteApproveReason list's item.


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
PUT /api/v1/List/QuoteApproveReason/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 241,
    "Name": "Adams-Lehner",
    "ToolTip": "Ullam et voluptatem doloremque et.",
    "Deleted": false,
    "Rank": 963,
    "Type": "qui",
    "ColorBlock": 796,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "2005-01-05T13:28:33.0384399+01:00",
    "ChildItems": [
      {
        "Id": 882,
        "Name": "Reichel, Von and Schmitt",
        "ToolTip": "Quas sint non sunt.",
        "Deleted": true,
        "Rank": 921,
        "Type": "blanditiis",
        "ColorBlock": 430,
        "IconHint": "eos",
        "Selected": true,
        "LastChanged": "2000-11-09T13:28:33.0384399+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "in",
        "StyleHint": "alias",
        "Hidden": true,
        "FullName": "Veronica Kertzmann"
      }
    ],
    "ExtraInfo": "culpa",
    "StyleHint": "qui",
    "Hidden": false,
    "FullName": "Mr. Conner Mae Wunsch PhD"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 116,
    "Name": "Bode-Turner",
    "ToolTip": "Dolorum hic est et.",
    "Deleted": false,
    "Rank": 792,
    "Type": "soluta",
    "ColorBlock": 623,
    "IconHint": "et",
    "Selected": true,
    "LastChanged": "1997-10-18T13:28:33.0540628+02:00",
    "ChildItems": [
      {
        "Id": 392,
        "Name": "Reynolds LLC",
        "ToolTip": "Quod delectus aut excepturi illo nostrum.",
        "Deleted": false,
        "Rank": 620,
        "Type": "cum",
        "ColorBlock": 639,
        "IconHint": "velit",
        "Selected": true,
        "LastChanged": "2024-04-17T13:28:33.0540628+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "error",
        "StyleHint": "laborum",
        "Hidden": false,
        "FullName": "Sabrina Hodkiewicz DVM",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 705
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "ex",
    "Hidden": true,
    "FullName": "Jeramy Dach MD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 713
      }
    }
  }
]
```