---
title: PUT List/MrMrs/Items/{id}/Headings
id: v1MrMrsList_PutMrMrsHeadingsForListItem
---

# PUT List/MrMrs/Items/{id}/Headings

```http
PUT /api/v1/List/MrMrs/Items/{itemId}/Headings
```

Saves headings for the MrMrs list's item.

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
PUT /api/v1/List/MrMrs/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 485,
    "Name": "McLaughlin Group",
    "ToolTip": "Aut quo.",
    "Deleted": false,
    "Rank": 963,
    "Type": "dolores",
    "ColorBlock": 401,
    "IconHint": "earum",
    "Selected": false,
    "LastChanged": "2008-02-12T18:25:51.915245+01:00",
    "ChildItems": [
      {
        "Id": 812,
        "Name": "Raynor, Watsica and Kreiger",
        "ToolTip": "Nulla doloremque.",
        "Deleted": true,
        "Rank": 667,
        "Type": "accusantium",
        "ColorBlock": 397,
        "IconHint": "id",
        "Selected": true,
        "LastChanged": "2006-02-08T18:25:51.915245+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "est",
        "StyleHint": "nulla",
        "Hidden": false,
        "FullName": "Luisa Gibson"
      }
    ],
    "ExtraInfo": "eos",
    "StyleHint": "eaque",
    "Hidden": false,
    "FullName": "Rosemary Cummings"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 44,
    "Name": "Mann-Hyatt",
    "ToolTip": "Nihil a voluptas.",
    "Deleted": false,
    "Rank": 766,
    "Type": "qui",
    "ColorBlock": 419,
    "IconHint": "minus",
    "Selected": true,
    "LastChanged": "2014-10-21T18:25:51.916247+02:00",
    "ChildItems": [
      {
        "Id": 701,
        "Name": "Ernser, Wilderman and Schumm",
        "ToolTip": "Vel atque.",
        "Deleted": true,
        "Rank": 102,
        "Type": "ut",
        "ColorBlock": 71,
        "IconHint": "tempore",
        "Selected": true,
        "LastChanged": "1995-12-03T18:25:51.916247+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sit",
        "StyleHint": "excepturi",
        "Hidden": true,
        "FullName": "Jeramie Kerluke",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "incentivize value-added convergence"
            },
            "FieldType": "System.String",
            "FieldLength": 932
          }
        }
      }
    ],
    "ExtraInfo": "voluptate",
    "StyleHint": "aliquid",
    "Hidden": false,
    "FullName": "Dandre Huels",
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
        "FieldType": "System.String",
        "FieldLength": 795
      }
    }
  }
]
```