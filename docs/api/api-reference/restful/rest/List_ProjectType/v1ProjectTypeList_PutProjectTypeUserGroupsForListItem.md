---
title: PUT List/ProjectType/Items/{id}/UserGroups
id: v1ProjectTypeList_PutProjectTypeUserGroupsForListItem
---

# PUT List/ProjectType/Items/{id}/UserGroups

```http
PUT /api/v1/List/ProjectType/Items/{itemId}/UserGroups
```

Saves user groups visible for the ProjectType list's item.

Calls the List agent service SaveHeadingsForListItemFromListDefinition.




| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the item to save. **Required** |



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
PUT /api/v1/List/ProjectType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 218,
    "Name": "Crist-Stanton",
    "ToolTip": "Totam nihil cumque consectetur repellat.",
    "Deleted": true,
    "Rank": 871,
    "Type": "quasi",
    "ColorBlock": 281,
    "IconHint": "qui",
    "Selected": true,
    "LastChanged": "2012-08-21T18:25:52.1040218+02:00",
    "ChildItems": [
      {
        "Id": 948,
        "Name": "Kuhn Group",
        "ToolTip": "Autem esse sunt laudantium est nulla.",
        "Deleted": false,
        "Rank": 450,
        "Type": "veritatis",
        "ColorBlock": 880,
        "IconHint": "est",
        "Selected": true,
        "LastChanged": "2000-12-13T18:25:52.1040218+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dignissimos",
        "StyleHint": "nesciunt",
        "Hidden": true,
        "FullName": "Cordie Ledner"
      }
    ],
    "ExtraInfo": "sapiente",
    "StyleHint": "iusto",
    "Hidden": false,
    "FullName": "Deondre Gerhold"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 362,
    "Name": "Lindgren Group",
    "ToolTip": "Voluptatem beatae.",
    "Deleted": false,
    "Rank": 462,
    "Type": "aliquid",
    "ColorBlock": 24,
    "IconHint": "earum",
    "Selected": false,
    "LastChanged": "2004-08-30T18:25:52.1060209+02:00",
    "ChildItems": [
      {
        "Id": 38,
        "Name": "Towne-Paucek",
        "ToolTip": "Placeat ad rerum rem maxime accusantium.",
        "Deleted": false,
        "Rank": 876,
        "Type": "nesciunt",
        "ColorBlock": 897,
        "IconHint": "commodi",
        "Selected": true,
        "LastChanged": "2006-05-06T18:25:52.1060209+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "esse",
        "StyleHint": "qui",
        "Hidden": true,
        "FullName": "Reynold Ankunding",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 517
          }
        }
      }
    ],
    "ExtraInfo": "nemo",
    "StyleHint": "facere",
    "Hidden": true,
    "FullName": "Donato Monahan PhD",
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
        "FieldLength": 653
      }
    }
  }
]
```