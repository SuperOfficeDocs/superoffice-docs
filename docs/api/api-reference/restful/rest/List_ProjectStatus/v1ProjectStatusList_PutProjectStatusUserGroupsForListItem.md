---
title: PUT List/ProjectStatus/Items/{id}/UserGroups
id: v1ProjectStatusList_PutProjectStatusUserGroupsForListItem
---

# PUT List/ProjectStatus/Items/{id}/UserGroups

```http
PUT /api/v1/List/ProjectStatus/Items/{itemId}/UserGroups
```

Saves user groups visible for the ProjectStatus list's item.

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
PUT /api/v1/List/ProjectStatus/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 242,
    "Name": "Strosin LLC",
    "ToolTip": "Repudiandae fugiat fugit laborum.",
    "Deleted": false,
    "Rank": 954,
    "Type": "expedita",
    "ColorBlock": 228,
    "IconHint": "nulla",
    "Selected": false,
    "LastChanged": "2019-12-04T09:41:00.6363894+01:00",
    "ChildItems": [
      {
        "Id": 398,
        "Name": "Quigley, Haley and Runte",
        "ToolTip": "Quo doloremque consequatur itaque et et.",
        "Deleted": false,
        "Rank": 403,
        "Type": "mollitia",
        "ColorBlock": 412,
        "IconHint": "nam",
        "Selected": false,
        "LastChanged": "2009-08-09T09:41:00.6363894+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sed",
        "StyleHint": "sit",
        "Hidden": false,
        "FullName": "Lolita Beahan"
      }
    ],
    "ExtraInfo": "tempore",
    "StyleHint": "quasi",
    "Hidden": false,
    "FullName": "Garrison Rowe"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 994,
    "Name": "Fahey-Harber",
    "ToolTip": "Fuga accusamus nam qui est illum velit.",
    "Deleted": false,
    "Rank": 667,
    "Type": "repellat",
    "ColorBlock": 39,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "2017-07-12T09:41:00.638387+02:00",
    "ChildItems": [
      {
        "Id": 326,
        "Name": "Botsford, Littel and Pfeffer",
        "ToolTip": "Et rem dicta mollitia distinctio incidunt nulla.",
        "Deleted": false,
        "Rank": 526,
        "Type": "maxime",
        "ColorBlock": 805,
        "IconHint": "ratione",
        "Selected": true,
        "LastChanged": "2007-06-04T09:41:00.638387+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "molestiae",
        "StyleHint": "blanditiis",
        "Hidden": false,
        "FullName": "Jedediah Rosenbaum",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "incubate strategic bandwidth"
            },
            "FieldType": "System.Int32",
            "FieldLength": 135
          }
        }
      }
    ],
    "ExtraInfo": "sed",
    "StyleHint": "labore",
    "Hidden": true,
    "FullName": "Adrianna Crona",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "e-enable cross-platform communities"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 837
      }
    }
  }
]
```