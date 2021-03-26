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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 721,
    "Name": "Mueller-Bernier",
    "ToolTip": "Harum architecto nihil.",
    "Deleted": true,
    "Rank": 722,
    "Type": "quasi",
    "ColorBlock": 199,
    "IconHint": "neque",
    "Selected": false,
    "LastChanged": "1996-06-15T09:41:00.5433789+02:00",
    "ChildItems": [
      {
        "Id": 475,
        "Name": "Walter, Pagac and Carroll",
        "ToolTip": "Dolores quis.",
        "Deleted": false,
        "Rank": 938,
        "Type": "est",
        "ColorBlock": 103,
        "IconHint": "illum",
        "Selected": false,
        "LastChanged": "1998-02-22T09:41:00.5443819+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dignissimos",
        "StyleHint": "enim",
        "Hidden": false,
        "FullName": "Margie Frami DVM"
      }
    ],
    "ExtraInfo": "accusamus",
    "StyleHint": "rerum",
    "Hidden": false,
    "FullName": "Ken Pouros DVM"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 319,
    "Name": "Kertzmann Group",
    "ToolTip": "Ipsa voluptates dolorem quam voluptas.",
    "Deleted": false,
    "Rank": 66,
    "Type": "fugit",
    "ColorBlock": 557,
    "IconHint": "magnam",
    "Selected": true,
    "LastChanged": "2011-10-03T09:41:00.5463818+02:00",
    "ChildItems": [
      {
        "Id": 357,
        "Name": "Littel-Lebsack",
        "ToolTip": "Nemo sed quo incidunt est eum natus.",
        "Deleted": false,
        "Rank": 420,
        "Type": "magni",
        "ColorBlock": 679,
        "IconHint": "neque",
        "Selected": true,
        "LastChanged": "2014-08-26T09:41:00.5463818+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "laudantium",
        "StyleHint": "nam",
        "Hidden": false,
        "FullName": "Mrs. Laurel Medhurst",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 156
          }
        }
      }
    ],
    "ExtraInfo": "ipsum",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Juvenal Douglas",
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
        "FieldLength": 648
      }
    }
  }
]
```