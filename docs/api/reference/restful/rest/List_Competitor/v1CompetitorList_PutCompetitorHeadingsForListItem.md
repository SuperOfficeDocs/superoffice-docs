---
title: PUT List/Competitor/Items/{id}/Headings
id: v1CompetitorList_PutCompetitorHeadingsForListItem
---

# PUT List/Competitor/Items/{id}/Headings

```http
PUT /api/v1/List/Competitor/Items/{itemId}/Headings
```

Saves headings for the Competitor list's item.

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
PUT /api/v1/List/Competitor/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 576,
    "Name": "Mertz, Hirthe and Boyle",
    "ToolTip": "Aut id.",
    "Deleted": false,
    "Rank": 954,
    "Type": "id",
    "ColorBlock": 446,
    "IconHint": "sed",
    "Selected": false,
    "LastChanged": "2012-11-01T18:25:51.6552946+01:00",
    "ChildItems": [
      {
        "Id": 614,
        "Name": "Zemlak, Armstrong and Windler",
        "ToolTip": "Minus nesciunt omnis praesentium quidem eum.",
        "Deleted": true,
        "Rank": 167,
        "Type": "eveniet",
        "ColorBlock": 373,
        "IconHint": "molestiae",
        "Selected": false,
        "LastChanged": "2000-02-03T18:25:51.6562946+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "inventore",
        "StyleHint": "non",
        "Hidden": false,
        "FullName": "Daisy Ondricka"
      }
    ],
    "ExtraInfo": "optio",
    "StyleHint": "laboriosam",
    "Hidden": true,
    "FullName": "Jerad Little"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 696,
    "Name": "King Inc and Sons",
    "ToolTip": "Quos aut ducimus.",
    "Deleted": false,
    "Rank": 261,
    "Type": "mollitia",
    "ColorBlock": 407,
    "IconHint": "hic",
    "Selected": true,
    "LastChanged": "2008-05-23T18:25:51.6572948+02:00",
    "ChildItems": [
      {
        "Id": 298,
        "Name": "Lemke, Emard and Walker",
        "ToolTip": "Nostrum fugit aperiam et qui provident.",
        "Deleted": false,
        "Rank": 447,
        "Type": "voluptatem",
        "ColorBlock": 446,
        "IconHint": "perspiciatis",
        "Selected": false,
        "LastChanged": "2005-07-24T18:25:51.6572948+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sit",
        "StyleHint": "aut",
        "Hidden": true,
        "FullName": "Dr. Vena Haley",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 568
          }
        }
      }
    ],
    "ExtraInfo": "ab",
    "StyleHint": "nihil",
    "Hidden": false,
    "FullName": "Carlotta Abshire",
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
        "FieldLength": 815
      }
    }
  }
]
```