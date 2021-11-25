---
title: PUT List/Priority/Items/{id}/Headings
id: v1PriorityList_PutPriorityHeadingsForListItem
---

# PUT List/Priority/Items/{id}/Headings

```http
PUT /api/v1/List/Priority/Items/{itemId}/Headings
```

Saves headings for the Priority list's item.

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
PUT /api/v1/List/Priority/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 321,
    "Name": "Jewess, Fisher and Towne",
    "ToolTip": "Perferendis et.",
    "Deleted": false,
    "Rank": 482,
    "Type": "commodi",
    "ColorBlock": 472,
    "IconHint": "ut",
    "Selected": true,
    "LastChanged": "2017-11-06T18:25:51.9872449+01:00",
    "ChildItems": [
      {
        "Id": 350,
        "Name": "Fisher-Glover",
        "ToolTip": "Optio consectetur.",
        "Deleted": true,
        "Rank": 739,
        "Type": "sunt",
        "ColorBlock": 262,
        "IconHint": "molestias",
        "Selected": false,
        "LastChanged": "2010-10-29T18:25:51.9872449+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "rerum",
        "StyleHint": "dolores",
        "Hidden": true,
        "FullName": "Laurine Sawayn IV"
      }
    ],
    "ExtraInfo": "in",
    "StyleHint": "quo",
    "Hidden": true,
    "FullName": "Lorena Schinner"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 434,
    "Name": "Labadie-Turner",
    "ToolTip": "Sit ut.",
    "Deleted": true,
    "Rank": 252,
    "Type": "est",
    "ColorBlock": 409,
    "IconHint": "consequatur",
    "Selected": true,
    "LastChanged": "2018-09-20T18:25:51.9882488+02:00",
    "ChildItems": [
      {
        "Id": 582,
        "Name": "Swift Group",
        "ToolTip": "Cum sequi iure ut voluptatem aut.",
        "Deleted": true,
        "Rank": 71,
        "Type": "et",
        "ColorBlock": 476,
        "IconHint": "odit",
        "Selected": false,
        "LastChanged": "2020-10-31T18:25:51.9892126+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aliquam",
        "StyleHint": "explicabo",
        "Hidden": true,
        "FullName": "Pearline Kautzer",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 759
          }
        }
      }
    ],
    "ExtraInfo": "quia",
    "StyleHint": "vel",
    "Hidden": false,
    "FullName": "Kattie Rosenbaum",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "mesh innovative content"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 406
      }
    }
  }
]
```