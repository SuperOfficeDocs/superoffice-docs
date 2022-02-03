---
title: PUT List/{id}/Items/{id}/Headings
id: v1ListItemEntity_SaveHeadingsForListItemFromListDefinition
---

# PUT List/{id}/Items/{id}/Headings

```http
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/Headings
```

Saves the active headings for the list item.






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionId | int32 | The id of the list definition, indicating which list to delete the items from. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category. **Required** |
| listItemId | int32 | The identity of the list item to delete **Required** |



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

## Request Body: headings  

The headings to save. 

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
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 250,
    "Name": "Greenfelder, Franecki and Heathcote",
    "ToolTip": "Et ut exercitationem sint rerum perspiciatis.",
    "Deleted": true,
    "Rank": 796,
    "Type": "voluptatem",
    "ColorBlock": 784,
    "IconHint": "quisquam",
    "Selected": true,
    "LastChanged": "2000-03-15T18:25:51.5872944+01:00",
    "ChildItems": [
      {
        "Id": 943,
        "Name": "Morar, Bechtelar and Dickens",
        "ToolTip": "Rerum iste molestias amet quidem minima.",
        "Deleted": true,
        "Rank": 524,
        "Type": "repudiandae",
        "ColorBlock": 597,
        "IconHint": "libero",
        "Selected": true,
        "LastChanged": "2010-04-04T18:25:51.5872944+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quibusdam",
        "StyleHint": "ipsa",
        "Hidden": true,
        "FullName": "Harmon Heidenreich"
      }
    ],
    "ExtraInfo": "fugiat",
    "StyleHint": "est",
    "Hidden": true,
    "FullName": "Xander Padberg"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 596,
    "Name": "Bednar, Rodriguez and Buckridge",
    "ToolTip": "Ad tempora voluptatem nostrum eos eligendi.",
    "Deleted": true,
    "Rank": 233,
    "Type": "corrupti",
    "ColorBlock": 730,
    "IconHint": "suscipit",
    "Selected": false,
    "LastChanged": "2004-12-13T18:25:51.5892943+01:00",
    "ChildItems": [
      {
        "Id": 768,
        "Name": "VonRueden-Hayes",
        "ToolTip": "Non facilis aut.",
        "Deleted": false,
        "Rank": 936,
        "Type": "dolores",
        "ColorBlock": 489,
        "IconHint": "iste",
        "Selected": true,
        "LastChanged": "2001-03-31T18:25:51.5892943+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quia",
        "StyleHint": "aliquam",
        "Hidden": false,
        "FullName": "Hosea Cole",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 332
          }
        }
      }
    ],
    "ExtraInfo": "recusandae",
    "StyleHint": "quia",
    "Hidden": false,
    "FullName": "Damien Conn",
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
        "FieldLength": 682
      }
    }
  }
]
```