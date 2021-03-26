---
title: GET List/PaymentTerm/Items/{id}/Headings
id: v1PaymentTermsList_GetPaymentTermHeadingsForListItem
---

# GET List/PaymentTerm/Items/{id}/Headings

```http
GET /api/v1/List/PaymentTerm/Items/{itemId}/Headings
```

Gets headings for the PaymentTerm list's item.

Calls the List agent service GetHeadings.




| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the headings to be get. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| showDeleted | bool |  Whether to show deleted items or not. Default false. |

```http
GET /api/v1/List/PaymentTerm/Items/{itemId}/Headings?showDeleted=False
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
GET /api/v1/List/PaymentTerm/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 344,
    "Name": "Kemmer-Konopelski",
    "ToolTip": "Dolor quam ratione quasi aut ut veniam.",
    "Deleted": false,
    "Rank": 707,
    "Type": "dolorem",
    "ColorBlock": 773,
    "IconHint": "amet",
    "Selected": false,
    "LastChanged": "1994-03-15T09:41:00.4813848+01:00",
    "ChildItems": [
      {
        "Id": 200,
        "Name": "Gusikowski, Schmitt and Kilback",
        "ToolTip": "Amet expedita ab ducimus debitis.",
        "Deleted": true,
        "Rank": 286,
        "Type": "doloribus",
        "ColorBlock": 501,
        "IconHint": "eligendi",
        "Selected": true,
        "LastChanged": "1997-06-11T09:41:00.4813848+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ad",
        "StyleHint": "maxime",
        "Hidden": false,
        "FullName": "Gene Gleason",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 181
          }
        }
      }
    ],
    "ExtraInfo": "atque",
    "StyleHint": "dolorum",
    "Hidden": true,
    "FullName": "Jasen Goldner",
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
        "FieldLength": 946
      }
    }
  }
]
```