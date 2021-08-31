---
title: PUT List/ReasonStalled/Items/{id}/UserGroups
id: v1ReasonStalledList_PutReasonStalledUserGroupsForListItem
---

# PUT List/ReasonStalled/Items/{id}/UserGroups

```http
PUT /api/v1/List/ReasonStalled/Items/{itemId}/UserGroups
```

Saves user groups visible for the ReasonStalled list's item.

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
PUT /api/v1/List/ReasonStalled/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 496,
    "Name": "Dietrich-Thompson",
    "ToolTip": "Quo fugit.",
    "Deleted": true,
    "Rank": 452,
    "Type": "rerum",
    "ColorBlock": 239,
    "IconHint": "sed",
    "Selected": true,
    "LastChanged": "2015-10-21T15:05:43.7771183+02:00",
    "ChildItems": [
      {
        "Id": 425,
        "Name": "Cremin LLC",
        "ToolTip": "Ipsa eius veritatis possimus nihil eum.",
        "Deleted": false,
        "Rank": 156,
        "Type": "distinctio",
        "ColorBlock": 293,
        "IconHint": "corrupti",
        "Selected": false,
        "LastChanged": "2011-09-15T15:05:43.7771183+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vel",
        "StyleHint": "ipsam",
        "Hidden": false,
        "FullName": "Melyna Cummerata"
      }
    ],
    "ExtraInfo": "rerum",
    "StyleHint": "sunt",
    "Hidden": false,
    "FullName": "Zackery Welch"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 250,
    "Name": "Berge, Wisozk and O'Kon",
    "ToolTip": "Sint enim explicabo in et hic aut.",
    "Deleted": false,
    "Rank": 169,
    "Type": "in",
    "ColorBlock": 640,
    "IconHint": "cum",
    "Selected": false,
    "LastChanged": "2016-05-18T15:05:43.7781217+02:00",
    "ChildItems": [
      {
        "Id": 186,
        "Name": "Predovic Group",
        "ToolTip": "Tenetur beatae nobis.",
        "Deleted": true,
        "Rank": 379,
        "Type": "tempora",
        "ColorBlock": 440,
        "IconHint": "necessitatibus",
        "Selected": false,
        "LastChanged": "1997-08-14T15:05:43.7781217+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "tempora",
        "StyleHint": "cumque",
        "Hidden": true,
        "FullName": "Antonetta Schaefer",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 740
          }
        }
      }
    ],
    "ExtraInfo": "amet",
    "StyleHint": "non",
    "Hidden": true,
    "FullName": "Nayeli Glover",
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
        "FieldLength": 285
      }
    }
  }
]
```