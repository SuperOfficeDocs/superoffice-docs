---
title: PUT List/ProductType/Items/{id}/UserGroups
id: v1ProductTypeList_PutProductTypeUserGroupsForListItem
---

# PUT List/ProductType/Items/{id}/UserGroups

```http
PUT /api/v1/List/ProductType/Items/{itemId}/UserGroups
```

Saves user groups visible for the ProductType list's item.

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
PUT /api/v1/List/ProductType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 876,
    "Name": "Sipes-Schimmel",
    "ToolTip": "Illo mollitia excepturi aspernatur voluptas autem velit.",
    "Deleted": false,
    "Rank": 345,
    "Type": "rerum",
    "ColorBlock": 935,
    "IconHint": "ipsa",
    "Selected": true,
    "LastChanged": "1995-07-12T15:05:43.646077+02:00",
    "ChildItems": [
      {
        "Id": 713,
        "Name": "Hills-Monahan",
        "ToolTip": "Veritatis commodi quibusdam.",
        "Deleted": false,
        "Rank": 749,
        "Type": "quaerat",
        "ColorBlock": 779,
        "IconHint": "reprehenderit",
        "Selected": false,
        "LastChanged": "1996-12-03T15:05:43.646077+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quia",
        "StyleHint": "quis",
        "Hidden": true,
        "FullName": "Talon Medhurst"
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "delectus",
    "Hidden": true,
    "FullName": "Jany Ratke"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 493,
    "Name": "Bauch-Reilly",
    "ToolTip": "Et iure possimus.",
    "Deleted": true,
    "Rank": 442,
    "Type": "laudantium",
    "ColorBlock": 578,
    "IconHint": "facere",
    "Selected": false,
    "LastChanged": "1999-03-20T15:05:43.6511141+01:00",
    "ChildItems": [
      {
        "Id": 816,
        "Name": "Feeney-Pagac",
        "ToolTip": "Nam esse tempora omnis non.",
        "Deleted": false,
        "Rank": 662,
        "Type": "repellendus",
        "ColorBlock": 331,
        "IconHint": "fugiat",
        "Selected": false,
        "LastChanged": "2016-03-02T15:05:43.6521152+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quis",
        "StyleHint": "quis",
        "Hidden": true,
        "FullName": "Miss Dakota West",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 759
          }
        }
      }
    ],
    "ExtraInfo": "veritatis",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Tad Stoltenberg",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "mesh scalable technologies"
        },
        "FieldType": "System.String",
        "FieldLength": 831
      }
    }
  }
]
```