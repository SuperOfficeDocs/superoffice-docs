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
    "Id": 698,
    "Name": "Abbott-Sipes",
    "ToolTip": "Nulla quo repellendus iusto officia eum quos.",
    "Deleted": false,
    "Rank": 379,
    "Type": "dignissimos",
    "ColorBlock": 946,
    "IconHint": "quia",
    "Selected": true,
    "LastChanged": "2002-03-02T09:41:00.5123822+01:00",
    "ChildItems": [
      {
        "Id": 755,
        "Name": "Cremin, Tillman and Bogisich",
        "ToolTip": "Architecto aut minus at.",
        "Deleted": false,
        "Rank": 97,
        "Type": "et",
        "ColorBlock": 222,
        "IconHint": "quos",
        "Selected": false,
        "LastChanged": "2004-09-12T09:41:00.5133818+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "facere",
        "StyleHint": "quod",
        "Hidden": true,
        "FullName": "Lyda Swaniawski"
      }
    ],
    "ExtraInfo": "placeat",
    "StyleHint": "rerum",
    "Hidden": false,
    "FullName": "Xzavier Weissnat PhD"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 384,
    "Name": "Bernier LLC",
    "ToolTip": "Vitae ut quo ipsum qui sit alias.",
    "Deleted": true,
    "Rank": 382,
    "Type": "quos",
    "ColorBlock": 824,
    "IconHint": "consectetur",
    "Selected": true,
    "LastChanged": "2006-03-13T09:41:00.5143824+01:00",
    "ChildItems": [
      {
        "Id": 164,
        "Name": "Kuphal-Dicki",
        "ToolTip": "Impedit minima nihil pariatur sint dolore voluptatum.",
        "Deleted": false,
        "Rank": 678,
        "Type": "perferendis",
        "ColorBlock": 810,
        "IconHint": "optio",
        "Selected": false,
        "LastChanged": "2005-08-17T09:41:00.5143824+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "perspiciatis",
        "StyleHint": "necessitatibus",
        "Hidden": false,
        "FullName": "Jaida Predovic",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 4
          }
        }
      }
    ],
    "ExtraInfo": "eius",
    "StyleHint": "similique",
    "Hidden": true,
    "FullName": "Mrs. Anna Collier",
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
        "FieldLength": 705
      }
    }
  }
]
```