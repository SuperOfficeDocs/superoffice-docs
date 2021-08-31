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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 76,
    "Name": "Green-Sawayn",
    "ToolTip": "Voluptas quidem dolorum iure quos.",
    "Deleted": true,
    "Rank": 911,
    "Type": "deserunt",
    "ColorBlock": 765,
    "IconHint": "adipisci",
    "Selected": true,
    "LastChanged": "2012-07-03T15:05:43.6020797+02:00",
    "ChildItems": [
      {
        "Id": 802,
        "Name": "Lind LLC",
        "ToolTip": "Consequatur tempora voluptatem laborum et et fugit.",
        "Deleted": true,
        "Rank": 976,
        "Type": "distinctio",
        "ColorBlock": 194,
        "IconHint": "quis",
        "Selected": true,
        "LastChanged": "2012-12-05T15:05:43.6020797+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ut",
        "StyleHint": "dignissimos",
        "Hidden": false,
        "FullName": "Otto Roob"
      }
    ],
    "ExtraInfo": "quas",
    "StyleHint": "et",
    "Hidden": true,
    "FullName": "Margie Lemke"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 501,
    "Name": "Cremin, Schmitt and McLaughlin",
    "ToolTip": "Omnis iusto quia.",
    "Deleted": true,
    "Rank": 134,
    "Type": "similique",
    "ColorBlock": 529,
    "IconHint": "iure",
    "Selected": true,
    "LastChanged": "1995-10-14T15:05:43.6030796+02:00",
    "ChildItems": [
      {
        "Id": 579,
        "Name": "Fritsch LLC",
        "ToolTip": "Voluptas debitis natus maiores eligendi at.",
        "Deleted": false,
        "Rank": 194,
        "Type": "est",
        "ColorBlock": 280,
        "IconHint": "perferendis",
        "Selected": false,
        "LastChanged": "2004-09-26T15:05:43.6030796+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolores",
        "StyleHint": "officiis",
        "Hidden": false,
        "FullName": "Immanuel Ledner I",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 852
          }
        }
      }
    ],
    "ExtraInfo": "atque",
    "StyleHint": "quia",
    "Hidden": false,
    "FullName": "Elton Walsh Jr.",
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
        "FieldLength": 130
      }
    }
  }
]
```