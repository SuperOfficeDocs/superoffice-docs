---
title: PUT List/ReasonSold/Items/{id}/Headings
id: v1ReasonSoldList_PutReasonSoldHeadingsForListItem
---

# PUT List/ReasonSold/Items/{id}/Headings

```http
PUT /api/v1/List/ReasonSold/Items/{itemId}/Headings
```

Saves headings for the ReasonSold list's item.

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
PUT /api/v1/List/ReasonSold/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 773,
    "Name": "Buckridge, Olson and Dicki",
    "ToolTip": "Temporibus nemo.",
    "Deleted": true,
    "Rank": 679,
    "Type": "quis",
    "ColorBlock": 558,
    "IconHint": "eius",
    "Selected": false,
    "LastChanged": "2002-04-05T18:25:52.1549849+02:00",
    "ChildItems": [
      {
        "Id": 578,
        "Name": "Monahan-Nicolas",
        "ToolTip": "Ut occaecati quasi in.",
        "Deleted": true,
        "Rank": 359,
        "Type": "quis",
        "ColorBlock": 102,
        "IconHint": "id",
        "Selected": false,
        "LastChanged": "2018-04-16T18:25:52.1549849+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "est",
        "StyleHint": "nesciunt",
        "Hidden": true,
        "FullName": "Dee Jacobi"
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Kathryne Prohaska Jr."
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 548,
    "Name": "Lemke LLC",
    "ToolTip": "Dolores ullam asperiores ab.",
    "Deleted": false,
    "Rank": 961,
    "Type": "ad",
    "ColorBlock": 841,
    "IconHint": "labore",
    "Selected": false,
    "LastChanged": "2000-10-26T18:25:52.1570191+02:00",
    "ChildItems": [
      {
        "Id": 924,
        "Name": "Bartoletti LLC",
        "ToolTip": "Ex nam sit expedita.",
        "Deleted": true,
        "Rank": 857,
        "Type": "eveniet",
        "ColorBlock": 803,
        "IconHint": "est",
        "Selected": true,
        "LastChanged": "1999-10-08T18:25:52.1570191+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "suscipit",
        "StyleHint": "cumque",
        "Hidden": false,
        "FullName": "Layla Hartmann",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 41
          }
        }
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "omnis",
    "Hidden": true,
    "FullName": "Xavier Cummings",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "generate transparent platforms"
        },
        "FieldType": "System.String",
        "FieldLength": 680
      }
    }
  }
]
```