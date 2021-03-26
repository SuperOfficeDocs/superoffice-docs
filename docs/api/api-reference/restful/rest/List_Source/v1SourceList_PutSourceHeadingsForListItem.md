---
title: PUT List/Source/Items/{id}/Headings
id: v1SourceList_PutSourceHeadingsForListItem
---

# PUT List/Source/Items/{id}/Headings

```http
PUT /api/v1/List/Source/Items/{itemId}/Headings
```

Saves headings for the Source list's item.

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
PUT /api/v1/List/Source/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 591,
    "Name": "Bartoletti LLC",
    "ToolTip": "Minus dolorem omnis rerum pariatur eaque.",
    "Deleted": true,
    "Rank": 793,
    "Type": "voluptas",
    "ColorBlock": 601,
    "IconHint": "est",
    "Selected": true,
    "LastChanged": "2005-01-07T09:41:00.8173873+01:00",
    "ChildItems": [
      {
        "Id": 161,
        "Name": "Olson-Labadie",
        "ToolTip": "Quaerat blanditiis perspiciatis totam mollitia.",
        "Deleted": false,
        "Rank": 264,
        "Type": "amet",
        "ColorBlock": 769,
        "IconHint": "quis",
        "Selected": true,
        "LastChanged": "2000-10-01T09:41:00.8173873+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "officia",
        "StyleHint": "in",
        "Hidden": true,
        "FullName": "Callie McLaughlin"
      }
    ],
    "ExtraInfo": "vel",
    "StyleHint": "sint",
    "Hidden": true,
    "FullName": "Graham Schulist"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 964,
    "Name": "Cummerata LLC",
    "ToolTip": "Eligendi vel omnis.",
    "Deleted": false,
    "Rank": 599,
    "Type": "optio",
    "ColorBlock": 865,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "2007-11-02T09:41:00.8193872+01:00",
    "ChildItems": [
      {
        "Id": 680,
        "Name": "Effertz LLC",
        "ToolTip": "Consectetur praesentium.",
        "Deleted": true,
        "Rank": 426,
        "Type": "provident",
        "ColorBlock": 873,
        "IconHint": "odio",
        "Selected": false,
        "LastChanged": "2000-08-02T09:41:00.8193872+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "qui",
        "StyleHint": "recusandae",
        "Hidden": true,
        "FullName": "Shannon Prosacco",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 101
          }
        }
      }
    ],
    "ExtraInfo": "dicta",
    "StyleHint": "sint",
    "Hidden": true,
    "FullName": "Bryce Orn",
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
        "FieldLength": 383
      }
    }
  }
]
```