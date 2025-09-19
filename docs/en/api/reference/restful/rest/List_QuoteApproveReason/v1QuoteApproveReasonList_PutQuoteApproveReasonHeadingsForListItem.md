---
title: PUT List/QuoteApproveReason/Items/{id}/Headings
uid: v1QuoteApproveReasonList_PutQuoteApproveReasonHeadingsForListItem
generated: true
content_type: reference
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 399,
    "Name": "Altenwerth, Stoltenberg and Smith",
    "ToolTip": "Eius consequatur adipisci sapiente repudiandae.",
    "Deleted": false,
    "Rank": 111,
    "Type": "non",
    "ColorBlock": 391,
    "IconHint": "nisi",
    "Selected": false,
    "LastChanged": "2010-11-06T03:41:59.558612+01:00",
    "ChildItems": [
      {
        "Id": 881,
        "Name": "Cummerata-Lindgren",
        "ToolTip": "Voluptas quae quia.",
        "Deleted": false,
        "Rank": 895,
        "Type": "reprehenderit",
        "ColorBlock": 438,
        "IconHint": "mollitia",
        "Selected": false,
        "LastChanged": "2000-10-19T03:41:59.558612+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sit",
        "StyleHint": "dolorum",
        "Hidden": false,
        "FullName": "Ms. Wilburn Lourdes Wehner DDS"
      }
    ],
    "ExtraInfo": "quis",
    "StyleHint": "aperiam",
    "Hidden": true,
    "FullName": "Mrs. Aron Corkery DDS"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 584,
    "Name": "Kohler-Carroll",
    "ToolTip": "Ut laudantium est.",
    "Deleted": false,
    "Rank": 528,
    "Type": "sed",
    "ColorBlock": 507,
    "IconHint": "magnam",
    "Selected": false,
    "LastChanged": "2009-06-19T03:41:59.558612+02:00",
    "ChildItems": [
      {
        "Id": 75,
        "Name": "Blick, Sipes and Larkin",
        "ToolTip": "Nemo et quia quaerat odio totam.",
        "Deleted": true,
        "Rank": 557,
        "Type": "iste",
        "ColorBlock": 22,
        "IconHint": "non",
        "Selected": false,
        "LastChanged": "2017-12-30T03:41:59.558612+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "excepturi",
        "StyleHint": "aut",
        "Hidden": false,
        "FullName": "Citlalli Grady MD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 506
          }
        }
      }
    ],
    "ExtraInfo": "eaque",
    "StyleHint": "iste",
    "Hidden": false,
    "FullName": "Annabelle Thiel V",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 273
      }
    }
  }
]
```