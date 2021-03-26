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
    "Id": 967,
    "Name": "Welch LLC",
    "ToolTip": "Voluptas ex consequuntur sit modi ratione consequatur.",
    "Deleted": true,
    "Rank": 757,
    "Type": "consectetur",
    "ColorBlock": 255,
    "IconHint": "atque",
    "Selected": true,
    "LastChanged": "2014-02-22T09:41:00.7153879+01:00",
    "ChildItems": [
      {
        "Id": 242,
        "Name": "Schneider-Volkman",
        "ToolTip": "Reiciendis laudantium ullam qui.",
        "Deleted": false,
        "Rank": 490,
        "Type": "mollitia",
        "ColorBlock": 762,
        "IconHint": "sint",
        "Selected": true,
        "LastChanged": "1995-05-07T09:41:00.7153879+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolor",
        "StyleHint": "qui",
        "Hidden": false,
        "FullName": "Colleen Beer PhD"
      }
    ],
    "ExtraInfo": "occaecati",
    "StyleHint": "qui",
    "Hidden": false,
    "FullName": "Miss Mohamed Runte"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 299,
    "Name": "Hettinger-Terry",
    "ToolTip": "Consequatur ut repudiandae voluptatibus nam tempora aliquam.",
    "Deleted": false,
    "Rank": 934,
    "Type": "laudantium",
    "ColorBlock": 615,
    "IconHint": "voluptatem",
    "Selected": true,
    "LastChanged": "2004-04-06T09:41:00.7173874+02:00",
    "ChildItems": [
      {
        "Id": 802,
        "Name": "Klein, Flatley and Morar",
        "ToolTip": "Sit ad culpa.",
        "Deleted": true,
        "Rank": 194,
        "Type": "quia",
        "ColorBlock": 550,
        "IconHint": "tempora",
        "Selected": true,
        "LastChanged": "1995-06-14T09:41:00.7173874+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eaque",
        "StyleHint": "deserunt",
        "Hidden": true,
        "FullName": "Haley White",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 389
          }
        }
      }
    ],
    "ExtraInfo": "nam",
    "StyleHint": "similique",
    "Hidden": true,
    "FullName": "Tabitha Nader",
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
        "FieldLength": 609
      }
    }
  }
]
```