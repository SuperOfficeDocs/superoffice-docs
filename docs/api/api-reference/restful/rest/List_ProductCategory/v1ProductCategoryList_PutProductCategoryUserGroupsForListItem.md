---
title: PUT List/ProductCategory/Items/{id}/UserGroups
id: v1ProductCategoryList_PutProductCategoryUserGroupsForListItem
---

# PUT List/ProductCategory/Items/{id}/UserGroups

```http
PUT /api/v1/List/ProductCategory/Items/{itemId}/UserGroups
```

Saves user groups visible for the ProductCategory list's item.

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
PUT /api/v1/List/ProductCategory/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 707,
    "Name": "Bartoletti-Morar",
    "ToolTip": "Velit placeat et.",
    "Deleted": true,
    "Rank": 813,
    "Type": "eum",
    "ColorBlock": 433,
    "IconHint": "itaque",
    "Selected": false,
    "LastChanged": "2011-04-07T15:05:43.6130794+02:00",
    "ChildItems": [
      {
        "Id": 416,
        "Name": "Upton, Hermiston and Schmitt",
        "ToolTip": "Aliquam quas quo.",
        "Deleted": false,
        "Rank": 150,
        "Type": "est",
        "ColorBlock": 236,
        "IconHint": "eos",
        "Selected": false,
        "LastChanged": "2002-05-21T15:05:43.6130794+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptas",
        "StyleHint": "non",
        "Hidden": true,
        "FullName": "Dion Rohan"
      }
    ],
    "ExtraInfo": "soluta",
    "StyleHint": "illo",
    "Hidden": false,
    "FullName": "Dr. Lila Schulist"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 798,
    "Name": "Crona-Johns",
    "ToolTip": "Inventore debitis eum.",
    "Deleted": true,
    "Rank": 634,
    "Type": "officia",
    "ColorBlock": 608,
    "IconHint": "ut",
    "Selected": true,
    "LastChanged": "2011-04-11T15:05:43.6140796+02:00",
    "ChildItems": [
      {
        "Id": 680,
        "Name": "Lubowitz Inc and Sons",
        "ToolTip": "Maiores quos repudiandae non sequi.",
        "Deleted": false,
        "Rank": 490,
        "Type": "quia",
        "ColorBlock": 574,
        "IconHint": "enim",
        "Selected": true,
        "LastChanged": "2005-12-30T15:05:43.6140796+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "est",
        "StyleHint": "praesentium",
        "Hidden": true,
        "FullName": "Dr. Kailyn Douglas",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "leverage visionary schemas"
            },
            "FieldType": "System.String",
            "FieldLength": 968
          }
        }
      }
    ],
    "ExtraInfo": "autem",
    "StyleHint": "ratione",
    "Hidden": false,
    "FullName": "Joel Borer",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "brand intuitive bandwidth"
        },
        "FieldType": "System.Int32",
        "FieldLength": 9
      }
    }
  }
]
```