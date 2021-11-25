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
    "Id": 589,
    "Name": "Kirlin-Hegmann",
    "ToolTip": "Quis voluptatem aut perferendis et.",
    "Deleted": true,
    "Rank": 427,
    "Type": "eum",
    "ColorBlock": 138,
    "IconHint": "voluptatem",
    "Selected": true,
    "LastChanged": "2017-04-13T18:25:52.0880184+02:00",
    "ChildItems": [
      {
        "Id": 446,
        "Name": "Swift-Bahringer",
        "ToolTip": "Quos consequatur inventore eligendi temporibus.",
        "Deleted": true,
        "Rank": 937,
        "Type": "voluptas",
        "ColorBlock": 978,
        "IconHint": "minus",
        "Selected": false,
        "LastChanged": "2009-02-08T18:25:52.0880184+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptatem",
        "StyleHint": "repudiandae",
        "Hidden": true,
        "FullName": "Percy Schuppe"
      }
    ],
    "ExtraInfo": "expedita",
    "StyleHint": "beatae",
    "Hidden": true,
    "FullName": "Maya Kris PhD"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 196,
    "Name": "Pollich, Schuster and Bailey",
    "ToolTip": "Et excepturi natus veniam est vel accusantium.",
    "Deleted": true,
    "Rank": 205,
    "Type": "repellat",
    "ColorBlock": 980,
    "IconHint": "laborum",
    "Selected": true,
    "LastChanged": "2004-04-09T18:25:52.0890195+02:00",
    "ChildItems": [
      {
        "Id": 38,
        "Name": "McDermott-Morissette",
        "ToolTip": "Impedit repellendus ut nihil quaerat.",
        "Deleted": true,
        "Rank": 887,
        "Type": "nulla",
        "ColorBlock": 9,
        "IconHint": "magni",
        "Selected": true,
        "LastChanged": "2004-02-18T18:25:52.0890195+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "doloremque",
        "StyleHint": "tenetur",
        "Hidden": false,
        "FullName": "Alvah Hauck",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 606
          }
        }
      }
    ],
    "ExtraInfo": "occaecati",
    "StyleHint": "sint",
    "Hidden": true,
    "FullName": "Gwendolyn Gislason DDS",
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
        "FieldLength": 144
      }
    }
  }
]
```