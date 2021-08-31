---
title: PUT List/ProjectStatus/Items/{id}/Headings
id: v1ProjectStatusList_PutProjectStatusHeadingsForListItem
---

# PUT List/ProjectStatus/Items/{id}/Headings

```http
PUT /api/v1/List/ProjectStatus/Items/{itemId}/Headings
```

Saves headings for the ProjectStatus list's item.

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
PUT /api/v1/List/ProjectStatus/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 916,
    "Name": "Bode-Mills",
    "ToolTip": "Quod optio quidem ea dolorum ut beatae.",
    "Deleted": false,
    "Rank": 359,
    "Type": "autem",
    "ColorBlock": 941,
    "IconHint": "qui",
    "Selected": true,
    "LastChanged": "1994-08-11T15:05:43.700127+02:00",
    "ChildItems": [
      {
        "Id": 76,
        "Name": "Hegmann Inc and Sons",
        "ToolTip": "Nihil necessitatibus cum quia voluptas.",
        "Deleted": true,
        "Rank": 727,
        "Type": "corrupti",
        "ColorBlock": 844,
        "IconHint": "aperiam",
        "Selected": false,
        "LastChanged": "1999-03-09T15:05:43.700127+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "qui",
        "StyleHint": "omnis",
        "Hidden": true,
        "FullName": "Cordelia Mueller"
      }
    ],
    "ExtraInfo": "quisquam",
    "StyleHint": "distinctio",
    "Hidden": false,
    "FullName": "Felipe Spencer"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 756,
    "Name": "Zulauf-Boyer",
    "ToolTip": "Vero sed rem.",
    "Deleted": false,
    "Rank": 215,
    "Type": "sequi",
    "ColorBlock": 161,
    "IconHint": "sequi",
    "Selected": true,
    "LastChanged": "2020-04-30T15:05:43.7010795+02:00",
    "ChildItems": [
      {
        "Id": 333,
        "Name": "Shields-Jacobs",
        "ToolTip": "Repellat et sit sit est.",
        "Deleted": false,
        "Rank": 379,
        "Type": "quo",
        "ColorBlock": 215,
        "IconHint": "sit",
        "Selected": true,
        "LastChanged": "2000-09-12T15:05:43.7010795+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "labore",
        "StyleHint": "magni",
        "Hidden": false,
        "FullName": "Paige Kautzer",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 315
          }
        }
      }
    ],
    "ExtraInfo": "laborum",
    "StyleHint": "dolorum",
    "Hidden": false,
    "FullName": "Tyson Buckridge II",
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
        "FieldLength": 96
      }
    }
  }
]
```