---
title: PUT List/Task/Items/{id}/Headings
id: v1TaskList_PutTaskListItemHeadingsForListItem
---

# PUT List/Task/Items/{id}/Headings

```http
PUT /api/v1/List/Task/Items/{itemId}/Headings
```

Saves headings for the TaskListItem list's item.

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
PUT /api/v1/List/Task/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 26,
    "Name": "Champlin-Kessler",
    "ToolTip": "Expedita molestiae cum ut reprehenderit et.",
    "Deleted": false,
    "Rank": 423,
    "Type": "illum",
    "ColorBlock": 54,
    "IconHint": "voluptatem",
    "Selected": false,
    "LastChanged": "2002-02-25T15:05:43.8961227+01:00",
    "ChildItems": [
      {
        "Id": 58,
        "Name": "Gerlach, Nolan and Hand",
        "ToolTip": "Rerum perspiciatis ut officia eum reiciendis.",
        "Deleted": true,
        "Rank": 828,
        "Type": "ut",
        "ColorBlock": 785,
        "IconHint": "commodi",
        "Selected": true,
        "LastChanged": "1994-12-13T15:05:43.897122+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ea",
        "StyleHint": "officiis",
        "Hidden": true,
        "FullName": "Miss Malika Wehner"
      }
    ],
    "ExtraInfo": "harum",
    "StyleHint": "modi",
    "Hidden": false,
    "FullName": "Mr. Jayson Carter"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 646,
    "Name": "Schuster LLC",
    "ToolTip": "Quia veniam voluptatem veritatis commodi vel occaecati.",
    "Deleted": false,
    "Rank": 706,
    "Type": "assumenda",
    "ColorBlock": 495,
    "IconHint": "dolores",
    "Selected": false,
    "LastChanged": "1997-10-17T15:05:43.8981228+02:00",
    "ChildItems": [
      {
        "Id": 89,
        "Name": "Murazik, O'Hara and Schinner",
        "ToolTip": "Aut voluptatem eos cumque est tenetur.",
        "Deleted": false,
        "Rank": 842,
        "Type": "cumque",
        "ColorBlock": 738,
        "IconHint": "at",
        "Selected": true,
        "LastChanged": "2013-12-19T15:05:43.8981228+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "enim",
        "StyleHint": "pariatur",
        "Hidden": true,
        "FullName": "Ozella Schulist",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 946
          }
        }
      }
    ],
    "ExtraInfo": "iste",
    "StyleHint": "adipisci",
    "Hidden": true,
    "FullName": "Geoffrey Dach DVM",
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
        "FieldLength": 866
      }
    }
  }
]
```