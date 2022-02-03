---
title: PUT List/Position/Items/{id}/Headings
id: v1PositionList_PutPositionHeadingsForListItem
---

# PUT List/Position/Items/{id}/Headings

```http
PUT /api/v1/List/Position/Items/{itemId}/Headings
```

Saves headings for the Position list's item.

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
PUT /api/v1/List/Position/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 117,
    "Name": "Corkery, Douglas and Bernier",
    "ToolTip": "Distinctio dolore consequatur sapiente eius dolor.",
    "Deleted": false,
    "Rank": 594,
    "Type": "et",
    "ColorBlock": 849,
    "IconHint": "voluptas",
    "Selected": false,
    "LastChanged": "2008-03-10T18:25:51.9642454+01:00",
    "ChildItems": [
      {
        "Id": 8,
        "Name": "Bednar, Hahn and Robel",
        "ToolTip": "Expedita voluptatem deserunt odio voluptas fugit minus.",
        "Deleted": true,
        "Rank": 375,
        "Type": "accusamus",
        "ColorBlock": 394,
        "IconHint": "consequatur",
        "Selected": false,
        "LastChanged": "2018-08-26T18:25:51.9652449+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "tenetur",
        "StyleHint": "et",
        "Hidden": true,
        "FullName": "Ronaldo Schneider"
      }
    ],
    "ExtraInfo": "enim",
    "StyleHint": "officiis",
    "Hidden": true,
    "FullName": "Asia Towne"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 999,
    "Name": "Heidenreich Group",
    "ToolTip": "Sit placeat quae est reprehenderit.",
    "Deleted": true,
    "Rank": 43,
    "Type": "a",
    "ColorBlock": 561,
    "IconHint": "perferendis",
    "Selected": false,
    "LastChanged": "2017-08-18T18:25:51.9662455+02:00",
    "ChildItems": [
      {
        "Id": 360,
        "Name": "Ryan LLC",
        "ToolTip": "Delectus nihil architecto architecto tempora.",
        "Deleted": true,
        "Rank": 361,
        "Type": "eos",
        "ColorBlock": 33,
        "IconHint": "nam",
        "Selected": false,
        "LastChanged": "2015-12-15T18:25:51.9662455+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eaque",
        "StyleHint": "itaque",
        "Hidden": true,
        "FullName": "Cesar Schmeler",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 879
          }
        }
      }
    ],
    "ExtraInfo": "voluptate",
    "StyleHint": "fuga",
    "Hidden": true,
    "FullName": "Nicola Schuppe DVM",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "whiteboard transparent communities"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 6
      }
    }
  }
]
```