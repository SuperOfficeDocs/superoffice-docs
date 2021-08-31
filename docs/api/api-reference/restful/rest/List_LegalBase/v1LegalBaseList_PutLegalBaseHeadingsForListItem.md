---
title: PUT List/LegalBase/Items/{id}/Headings
id: v1LegalBaseList_PutLegalBaseHeadingsForListItem
---

# PUT List/LegalBase/Items/{id}/Headings

```http
PUT /api/v1/List/LegalBase/Items/{itemId}/Headings
```

Saves headings for the LegalBase list's item.

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
PUT /api/v1/List/LegalBase/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 433,
    "Name": "Farrell-Murray",
    "ToolTip": "Animi fugiat fugiat.",
    "Deleted": false,
    "Rank": 120,
    "Type": "molestiae",
    "ColorBlock": 326,
    "IconHint": "praesentium",
    "Selected": false,
    "LastChanged": "2020-10-13T15:05:43.5110793+02:00",
    "ChildItems": [
      {
        "Id": 917,
        "Name": "Reichert-Hartmann",
        "ToolTip": "Facere exercitationem veritatis veniam blanditiis.",
        "Deleted": false,
        "Rank": 917,
        "Type": "doloribus",
        "ColorBlock": 248,
        "IconHint": "voluptatem",
        "Selected": false,
        "LastChanged": "1994-08-06T15:05:43.5110793+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "harum",
        "StyleHint": "et",
        "Hidden": true,
        "FullName": "Bria Mayert"
      }
    ],
    "ExtraInfo": "repellendus",
    "StyleHint": "labore",
    "Hidden": true,
    "FullName": "Terrell Crist"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 877,
    "Name": "Breitenberg, Langworth and Hayes",
    "ToolTip": "Aliquid dolores voluptas illum est id.",
    "Deleted": false,
    "Rank": 66,
    "Type": "possimus",
    "ColorBlock": 887,
    "IconHint": "quos",
    "Selected": true,
    "LastChanged": "2008-08-09T15:05:43.5130796+02:00",
    "ChildItems": [
      {
        "Id": 317,
        "Name": "Veum-Heaney",
        "ToolTip": "Corporis in fugit atque praesentium sequi.",
        "Deleted": false,
        "Rank": 777,
        "Type": "in",
        "ColorBlock": 559,
        "IconHint": "quia",
        "Selected": false,
        "LastChanged": "2000-10-22T15:05:43.5130796+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "corrupti",
        "StyleHint": "qui",
        "Hidden": false,
        "FullName": "Nelson Dooley",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 806
          }
        }
      }
    ],
    "ExtraInfo": "ipsa",
    "StyleHint": "quam",
    "Hidden": true,
    "FullName": "Khalil Hudson DDS",
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
        "FieldLength": 210
      }
    }
  }
]
```