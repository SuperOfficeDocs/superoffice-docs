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
    "Id": 662,
    "Name": "Hane, Keeling and Thompson",
    "ToolTip": "Vel nostrum rerum quae.",
    "Deleted": true,
    "Rank": 258,
    "Type": "explicabo",
    "ColorBlock": 331,
    "IconHint": "tempora",
    "Selected": false,
    "LastChanged": "2001-04-25T15:05:43.7661219+02:00",
    "ChildItems": [
      {
        "Id": 569,
        "Name": "Funk-Mayert",
        "ToolTip": "Natus velit culpa.",
        "Deleted": true,
        "Rank": 499,
        "Type": "unde",
        "ColorBlock": 205,
        "IconHint": "voluptate",
        "Selected": false,
        "LastChanged": "2017-07-15T15:05:43.7661219+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "tenetur",
        "StyleHint": "quia",
        "Hidden": false,
        "FullName": "Collin Schinner"
      }
    ],
    "ExtraInfo": "asperiores",
    "StyleHint": "minus",
    "Hidden": true,
    "FullName": "Ms. Murray Tromp"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 847,
    "Name": "O'Kon-Armstrong",
    "ToolTip": "Omnis adipisci esse et.",
    "Deleted": false,
    "Rank": 462,
    "Type": "atque",
    "ColorBlock": 450,
    "IconHint": "enim",
    "Selected": true,
    "LastChanged": "2021-06-10T15:05:43.7671169+02:00",
    "ChildItems": [
      {
        "Id": 797,
        "Name": "Schuster, Senger and Weber",
        "ToolTip": "Voluptatibus dolore architecto omnis pariatur excepturi.",
        "Deleted": true,
        "Rank": 330,
        "Type": "et",
        "ColorBlock": 1001,
        "IconHint": "veritatis",
        "Selected": true,
        "LastChanged": "2005-08-04T15:05:43.7671169+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "maiores",
        "StyleHint": "iste",
        "Hidden": true,
        "FullName": "Amanda Blanda",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 516
          }
        }
      }
    ],
    "ExtraInfo": "sed",
    "StyleHint": "eos",
    "Hidden": true,
    "FullName": "Samara Barton",
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
        "FieldLength": 596
      }
    }
  }
]
```