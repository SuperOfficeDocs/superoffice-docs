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
    "Id": 376,
    "Name": "Kuhic-Jacobs",
    "ToolTip": "Consectetur doloremque est et quo.",
    "Deleted": false,
    "Rank": 635,
    "Type": "autem",
    "ColorBlock": 908,
    "IconHint": "ut",
    "Selected": false,
    "LastChanged": "2000-01-02T09:41:00.6573845+01:00",
    "ChildItems": [
      {
        "Id": 348,
        "Name": "Walter-Kessler",
        "ToolTip": "Laboriosam modi.",
        "Deleted": false,
        "Rank": 21,
        "Type": "cumque",
        "ColorBlock": 894,
        "IconHint": "officiis",
        "Selected": false,
        "LastChanged": "2007-04-15T09:41:00.6573845+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nam",
        "StyleHint": "nulla",
        "Hidden": false,
        "FullName": "Issac Grant"
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "veritatis",
    "Hidden": false,
    "FullName": "Mariah Wunsch"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 77,
    "Name": "Keeling Inc and Sons",
    "ToolTip": "Sit est culpa.",
    "Deleted": false,
    "Rank": 719,
    "Type": "sit",
    "ColorBlock": 185,
    "IconHint": "vero",
    "Selected": false,
    "LastChanged": "2006-08-31T09:41:00.6593919+02:00",
    "ChildItems": [
      {
        "Id": 931,
        "Name": "Wunsch Inc and Sons",
        "ToolTip": "Aliquam cumque nostrum eum nisi non.",
        "Deleted": true,
        "Rank": 641,
        "Type": "aliquid",
        "ColorBlock": 33,
        "IconHint": "qui",
        "Selected": true,
        "LastChanged": "2016-09-06T09:41:00.6593919+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "id",
        "StyleHint": "voluptates",
        "Hidden": false,
        "FullName": "Mr. Sid Spinka",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 191
          }
        }
      }
    ],
    "ExtraInfo": "quisquam",
    "StyleHint": "quia",
    "Hidden": false,
    "FullName": "Vivienne Reynolds",
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
        "FieldLength": 220
      }
    }
  }
]
```