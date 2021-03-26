---
title: PUT List/ConsentSource/Items/{id}/Headings
id: v1ConsentSourceList_PutConsentSourceHeadingsForListItem
---

# PUT List/ConsentSource/Items/{id}/Headings

```http
PUT /api/v1/List/ConsentSource/Items/{itemId}/Headings
```

Saves headings for the ConsentSource list's item.

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
PUT /api/v1/List/ConsentSource/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 705,
    "Name": "Okuneva Group",
    "ToolTip": "Qui eligendi error earum.",
    "Deleted": true,
    "Rank": 149,
    "Type": "minima",
    "ColorBlock": 176,
    "IconHint": "et",
    "Selected": true,
    "LastChanged": "2017-03-31T09:41:00.2863708+02:00",
    "ChildItems": [
      {
        "Id": 470,
        "Name": "Konopelski-Bradtke",
        "ToolTip": "Quae atque dolorem harum qui.",
        "Deleted": true,
        "Rank": 931,
        "Type": "corrupti",
        "ColorBlock": 175,
        "IconHint": "hic",
        "Selected": true,
        "LastChanged": "1994-03-03T09:41:00.2863708+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quod",
        "StyleHint": "doloribus",
        "Hidden": true,
        "FullName": "Devonte Kunze II"
      }
    ],
    "ExtraInfo": "dolore",
    "StyleHint": "aliquam",
    "Hidden": true,
    "FullName": "Merl Powlowski"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 882,
    "Name": "Funk Inc and Sons",
    "ToolTip": "Et tempore voluptatum et consequuntur nihil quia.",
    "Deleted": true,
    "Rank": 364,
    "Type": "dolores",
    "ColorBlock": 400,
    "IconHint": "et",
    "Selected": true,
    "LastChanged": "2018-04-25T09:41:00.2883674+02:00",
    "ChildItems": [
      {
        "Id": 596,
        "Name": "Gutkowski Inc and Sons",
        "ToolTip": "Ea temporibus itaque odit quidem a neque.",
        "Deleted": true,
        "Rank": 144,
        "Type": "quis",
        "ColorBlock": 342,
        "IconHint": "quis",
        "Selected": false,
        "LastChanged": "1998-07-13T09:41:00.2883674+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "rerum",
        "Hidden": true,
        "FullName": "Robyn O'Connell",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "disintermediate cross-platform applications"
            },
            "FieldType": "System.Int32",
            "FieldLength": 243
          }
        }
      }
    ],
    "ExtraInfo": "officiis",
    "StyleHint": "quas",
    "Hidden": false,
    "FullName": "Joelle Kuhic",
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
        "FieldLength": 765
      }
    }
  }
]
```