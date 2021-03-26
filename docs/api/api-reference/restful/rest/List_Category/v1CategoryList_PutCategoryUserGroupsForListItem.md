---
title: PUT List/Category/Items/{id}/UserGroups
id: v1CategoryList_PutCategoryUserGroupsForListItem
---

# PUT List/Category/Items/{id}/UserGroups

```http
PUT /api/v1/List/Category/Items/{itemId}/UserGroups
```

Saves user groups visible for the Category list's item.

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
PUT /api/v1/List/Category/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 477,
    "Name": "Kuhn, Quigley and Hettinger",
    "ToolTip": "Aliquam nobis.",
    "Deleted": true,
    "Rank": 123,
    "Type": "reiciendis",
    "ColorBlock": 47,
    "IconHint": "rerum",
    "Selected": false,
    "LastChanged": "2004-03-31T09:41:00.1903671+02:00",
    "ChildItems": [
      {
        "Id": 431,
        "Name": "Daniel, Kohler and Tillman",
        "ToolTip": "Ipsa iste delectus dolorem libero.",
        "Deleted": true,
        "Rank": 758,
        "Type": "accusamus",
        "ColorBlock": 237,
        "IconHint": "et",
        "Selected": false,
        "LastChanged": "2013-07-10T09:41:00.1903671+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptas",
        "StyleHint": "ipsam",
        "Hidden": false,
        "FullName": "Adele Lind"
      }
    ],
    "ExtraInfo": "aut",
    "StyleHint": "at",
    "Hidden": true,
    "FullName": "Adrianna Thompson"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 382,
    "Name": "Hodkiewicz-Haley",
    "ToolTip": "Sed sit.",
    "Deleted": true,
    "Rank": 880,
    "Type": "ullam",
    "ColorBlock": 963,
    "IconHint": "reiciendis",
    "Selected": true,
    "LastChanged": "1998-10-14T09:41:00.1913674+02:00",
    "ChildItems": [
      {
        "Id": 268,
        "Name": "Osinski Group",
        "ToolTip": "Perspiciatis vero sint magni officiis amet.",
        "Deleted": false,
        "Rank": 951,
        "Type": "adipisci",
        "ColorBlock": 962,
        "IconHint": "tenetur",
        "Selected": true,
        "LastChanged": "2009-04-06T09:41:00.1913674+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "velit",
        "Hidden": true,
        "FullName": "Lindsey Hilpert",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 372
          }
        }
      }
    ],
    "ExtraInfo": "aut",
    "StyleHint": "deleniti",
    "Hidden": false,
    "FullName": "Vella Smith",
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
        "FieldLength": 381
      }
    }
  }
]
```