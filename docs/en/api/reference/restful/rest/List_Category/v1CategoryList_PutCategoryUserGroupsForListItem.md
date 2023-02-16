---
title: PUT List/Category/Items/{id}/UserGroups
uid: v1CategoryList_PutCategoryUserGroupsForListItem
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
| Id | Integer | The Id of the ListItem |
| Name | String | The name of the ListItem |
| ToolTip | String | The tooltip of the ListItem |
| Deleted | Boolean | The deleted status of the ListItem |
| Rank | Integer | The rank of the ListItem |
| Type | String | The type of the ListItem. Custom field. |
| ColorBlock | Integer | The color indicator of the ListItem color block |
| IconHint | String | The Icon hint of the ListItem. Custom field. |
| Selected | Boolean | True if the ListItem is selected |
| LastChanged | String | Time of last change. |
| ChildItems | Array | The child items of the SelectableMDOListItem |
| ExtraInfo | String | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | String | Style hint indicating, information such as background color etc. Custom field. |
| Hidden | Boolean | True if the ListItem is hidden |
| FullName | String | The name of the ListItem in its context |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/Category/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 403,
    "Name": "Kohler-Renner",
    "ToolTip": "In hic tenetur quis rerum laudantium reprehenderit quia.",
    "Deleted": false,
    "Rank": 342,
    "Type": "sunt",
    "ColorBlock": 598,
    "IconHint": "molestiae",
    "Selected": true,
    "LastChanged": "2004-08-06T14:19:11.1324679+02:00",
    "ChildItems": [
      {
        "Id": 977,
        "Name": "Kling LLC",
        "ToolTip": "Commodi ut magnam.",
        "Deleted": false,
        "Rank": 423,
        "Type": "accusamus",
        "ColorBlock": 651,
        "IconHint": "quisquam",
        "Selected": true,
        "LastChanged": "2012-09-08T14:19:11.1324679+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "recusandae",
        "StyleHint": "praesentium",
        "Hidden": true,
        "FullName": "Lesly Kautzer"
      }
    ],
    "ExtraInfo": "minus",
    "StyleHint": "culpa",
    "Hidden": false,
    "FullName": "Yesenia Halvorson"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 525,
    "Name": "Leffler-Hane",
    "ToolTip": "Cum laudantium aut.",
    "Deleted": false,
    "Rank": 209,
    "Type": "repudiandae",
    "ColorBlock": 1002,
    "IconHint": "porro",
    "Selected": true,
    "LastChanged": "2020-03-19T14:19:11.1324679+01:00",
    "ChildItems": [
      {
        "Id": 516,
        "Name": "Pfeffer, Orn and Gulgowski",
        "ToolTip": "Est quasi sapiente incidunt consequatur.",
        "Deleted": true,
        "Rank": 35,
        "Type": "sequi",
        "ColorBlock": 736,
        "IconHint": "perferendis",
        "Selected": false,
        "LastChanged": "2004-07-09T14:19:11.1324679+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quisquam",
        "StyleHint": "debitis",
        "Hidden": false,
        "FullName": "Annabelle Gulgowski",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 116
          }
        }
      }
    ],
    "ExtraInfo": "reprehenderit",
    "StyleHint": "molestias",
    "Hidden": true,
    "FullName": "Florence Hansen",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 320
      }
    }
  }
]
```