---
title: PUT List/ConsentPurpose/Items/{id}/Headings
id: v1ConsentPurposeList_PutConsentPurposeHeadingsForListItem
---

# PUT List/ConsentPurpose/Items/{id}/Headings

```http
PUT /api/v1/List/ConsentPurpose/Items/{itemId}/Headings
```

Saves headings for the ConsentPurpose list's item.

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
PUT /api/v1/List/ConsentPurpose/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 654,
    "Name": "Block, Zulauf and Sanford",
    "ToolTip": "Commodi voluptate sint.",
    "Deleted": false,
    "Rank": 911,
    "Type": "sit",
    "ColorBlock": 138,
    "IconHint": "rerum",
    "Selected": true,
    "LastChanged": "2013-09-27T15:05:43.3435135+02:00",
    "ChildItems": [
      {
        "Id": 272,
        "Name": "Simonis-Rempel",
        "ToolTip": "Repellendus modi eos dolorem.",
        "Deleted": true,
        "Rank": 902,
        "Type": "vel",
        "ColorBlock": 838,
        "IconHint": "tenetur",
        "Selected": true,
        "LastChanged": "1997-09-15T15:05:43.3435135+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "beatae",
        "StyleHint": "quis",
        "Hidden": true,
        "FullName": "Lyda Ondricka II"
      }
    ],
    "ExtraInfo": "in",
    "StyleHint": "molestiae",
    "Hidden": true,
    "FullName": "Antoinette Leffler"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 766,
    "Name": "Jakubowski Inc and Sons",
    "ToolTip": "Laudantium nobis.",
    "Deleted": false,
    "Rank": 848,
    "Type": "illo",
    "ColorBlock": 765,
    "IconHint": "quia",
    "Selected": false,
    "LastChanged": "1996-01-13T15:05:43.3445131+01:00",
    "ChildItems": [
      {
        "Id": 468,
        "Name": "Koss, Muller and Roob",
        "ToolTip": "Placeat iure dolore tempore maxime reprehenderit.",
        "Deleted": true,
        "Rank": 243,
        "Type": "repellendus",
        "ColorBlock": 100,
        "IconHint": "quas",
        "Selected": true,
        "LastChanged": "1995-12-07T15:05:43.3445131+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dignissimos",
        "StyleHint": "et",
        "Hidden": false,
        "FullName": "Fidel Hoppe",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 265
          }
        }
      }
    ],
    "ExtraInfo": "molestiae",
    "StyleHint": "vel",
    "Hidden": false,
    "FullName": "Abby Jewess Jr.",
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
        "FieldLength": 606
      }
    }
  }
]
```