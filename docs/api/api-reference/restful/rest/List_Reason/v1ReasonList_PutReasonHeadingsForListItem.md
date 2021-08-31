---
title: PUT List/Reason/Items/{id}/Headings
id: v1ReasonList_PutReasonHeadingsForListItem
---

# PUT List/Reason/Items/{id}/Headings

```http
PUT /api/v1/List/Reason/Items/{itemId}/Headings
```

Saves headings for the Reason list's item.

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
PUT /api/v1/List/Reason/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 638,
    "Name": "Pollich Inc and Sons",
    "ToolTip": "Nam debitis quia tenetur.",
    "Deleted": false,
    "Rank": 754,
    "Type": "incidunt",
    "ColorBlock": 981,
    "IconHint": "autem",
    "Selected": false,
    "LastChanged": "2018-12-04T15:05:43.7511221+01:00",
    "ChildItems": [
      {
        "Id": 232,
        "Name": "Wisozk-Johnston",
        "ToolTip": "Numquam perferendis.",
        "Deleted": false,
        "Rank": 933,
        "Type": "illum",
        "ColorBlock": 894,
        "IconHint": "numquam",
        "Selected": false,
        "LastChanged": "2002-10-19T15:05:43.7511221+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "laboriosam",
        "StyleHint": "voluptatum",
        "Hidden": false,
        "FullName": "Lauretta Ullrich"
      }
    ],
    "ExtraInfo": "perspiciatis",
    "StyleHint": "laudantium",
    "Hidden": false,
    "FullName": "Jana Mertz"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 438,
    "Name": "O'Kon, Bernhard and McClure",
    "ToolTip": "Eos praesentium rerum excepturi.",
    "Deleted": true,
    "Rank": 446,
    "Type": "id",
    "ColorBlock": 976,
    "IconHint": "magni",
    "Selected": true,
    "LastChanged": "2012-06-14T15:05:43.7521215+02:00",
    "ChildItems": [
      {
        "Id": 514,
        "Name": "Gusikowski, Steuber and Maggio",
        "ToolTip": "Consequatur explicabo veritatis est et nesciunt.",
        "Deleted": false,
        "Rank": 572,
        "Type": "vero",
        "ColorBlock": 756,
        "IconHint": "hic",
        "Selected": false,
        "LastChanged": "2011-07-26T15:05:43.7521215+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "accusamus",
        "StyleHint": "in",
        "Hidden": false,
        "FullName": "Kelly Price",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 721
          }
        }
      }
    ],
    "ExtraInfo": "perferendis",
    "StyleHint": "eos",
    "Hidden": false,
    "FullName": "Mrs. Crawford Gaylord",
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
        "FieldLength": 876
      }
    }
  }
]
```