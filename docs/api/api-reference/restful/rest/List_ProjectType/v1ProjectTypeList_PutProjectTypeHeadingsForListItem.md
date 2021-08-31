---
title: PUT List/ProjectType/Items/{id}/Headings
id: v1ProjectTypeList_PutProjectTypeHeadingsForListItem
---

# PUT List/ProjectType/Items/{id}/Headings

```http
PUT /api/v1/List/ProjectType/Items/{itemId}/Headings
```

Saves headings for the ProjectType list's item.

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
PUT /api/v1/List/ProjectType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 313,
    "Name": "Nienow, Parker and Stark",
    "ToolTip": "Natus voluptate libero inventore debitis doloribus ut.",
    "Deleted": false,
    "Rank": 425,
    "Type": "amet",
    "ColorBlock": 477,
    "IconHint": "magni",
    "Selected": false,
    "LastChanged": "2001-11-24T15:05:43.7171131+01:00",
    "ChildItems": [
      {
        "Id": 424,
        "Name": "Bailey, Cummings and Haag",
        "ToolTip": "Vel et nihil.",
        "Deleted": false,
        "Rank": 281,
        "Type": "non",
        "ColorBlock": 173,
        "IconHint": "molestias",
        "Selected": false,
        "LastChanged": "2000-12-17T15:05:43.7171131+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "laborum",
        "StyleHint": "iure",
        "Hidden": false,
        "FullName": "Cleve Reichert Sr."
      }
    ],
    "ExtraInfo": "enim",
    "StyleHint": "aut",
    "Hidden": false,
    "FullName": "Lamar Koelpin"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 242,
    "Name": "Huel LLC",
    "ToolTip": "Eum cumque rerum qui blanditiis et.",
    "Deleted": true,
    "Rank": 766,
    "Type": "ducimus",
    "ColorBlock": 194,
    "IconHint": "expedita",
    "Selected": false,
    "LastChanged": "2015-08-25T15:05:43.7191229+02:00",
    "ChildItems": [
      {
        "Id": 456,
        "Name": "Zemlak, Labadie and Gottlieb",
        "ToolTip": "Delectus sit sapiente corrupti.",
        "Deleted": false,
        "Rank": 911,
        "Type": "maxime",
        "ColorBlock": 298,
        "IconHint": "repellat",
        "Selected": true,
        "LastChanged": "2004-02-29T15:05:43.7191229+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ipsum",
        "StyleHint": "corporis",
        "Hidden": false,
        "FullName": "Hilario Watsica",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 36
          }
        }
      }
    ],
    "ExtraInfo": "nulla",
    "StyleHint": "velit",
    "Hidden": true,
    "FullName": "Sheila Gislason",
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
        "FieldLength": 813
      }
    }
  }
]
```