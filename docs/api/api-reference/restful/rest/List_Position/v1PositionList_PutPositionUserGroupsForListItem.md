---
title: PUT List/Position/Items/{id}/UserGroups
id: v1PositionList_PutPositionUserGroupsForListItem
---

# PUT List/Position/Items/{id}/UserGroups

```http
PUT /api/v1/List/Position/Items/{itemId}/UserGroups
```

Saves user groups visible for the Position list's item.

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
PUT /api/v1/List/Position/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 900,
    "Name": "Lemke-Stiedemann",
    "ToolTip": "Rerum incidunt natus beatae velit omnis.",
    "Deleted": false,
    "Rank": 143,
    "Type": "ut",
    "ColorBlock": 974,
    "IconHint": "voluptas",
    "Selected": true,
    "LastChanged": "2015-06-16T18:25:51.9602412+02:00",
    "ChildItems": [
      {
        "Id": 640,
        "Name": "Hessel Inc and Sons",
        "ToolTip": "Ut non.",
        "Deleted": false,
        "Rank": 759,
        "Type": "quidem",
        "ColorBlock": 27,
        "IconHint": "provident",
        "Selected": false,
        "LastChanged": "2003-08-01T18:25:51.9602412+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eum",
        "StyleHint": "reprehenderit",
        "Hidden": false,
        "FullName": "Johnny Trantow"
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "vitae",
    "Hidden": false,
    "FullName": "Mariam Walsh"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 559,
    "Name": "O'Connell, Welch and Jacobson",
    "ToolTip": "Doloribus reprehenderit.",
    "Deleted": false,
    "Rank": 735,
    "Type": "aliquid",
    "ColorBlock": 291,
    "IconHint": "minima",
    "Selected": true,
    "LastChanged": "2000-05-28T18:25:51.9622457+02:00",
    "ChildItems": [
      {
        "Id": 149,
        "Name": "Eichmann, Beatty and Osinski",
        "ToolTip": "Ut aut.",
        "Deleted": false,
        "Rank": 852,
        "Type": "voluptas",
        "ColorBlock": 152,
        "IconHint": "est",
        "Selected": true,
        "LastChanged": "2016-01-15T18:25:51.9622457+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quos",
        "StyleHint": "ullam",
        "Hidden": false,
        "FullName": "Jodie Davis",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 195
          }
        }
      }
    ],
    "ExtraInfo": "commodi",
    "StyleHint": "autem",
    "Hidden": false,
    "FullName": "Triston Stark",
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
        "FieldLength": 433
      }
    }
  }
]
```