---
title: PUT List/ProductType/Items/{id}/UserGroups
uid: v1ProductTypeList_PutProductTypeUserGroupsForListItem
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/ProductType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 566,
    "Name": "Hartmann Inc and Sons",
    "ToolTip": "Animi libero consequatur error corporis asperiores natus.",
    "Deleted": true,
    "Rank": 125,
    "Type": "aut",
    "ColorBlock": 15,
    "IconHint": "vel",
    "Selected": true,
    "LastChanged": "1999-01-25T15:29:31.430976+01:00",
    "ChildItems": [
      {
        "Id": 377,
        "Name": "Jones, Schumm and Effertz",
        "ToolTip": "Aspernatur nemo.",
        "Deleted": true,
        "Rank": 914,
        "Type": "quia",
        "ColorBlock": 789,
        "IconHint": "molestias",
        "Selected": false,
        "LastChanged": "2002-11-28T15:29:31.4314766+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vitae",
        "StyleHint": "et",
        "Hidden": false,
        "FullName": "Silas Lebsack"
      }
    ],
    "ExtraInfo": "debitis",
    "StyleHint": "aperiam",
    "Hidden": true,
    "FullName": "Mr. Sonya Herman MD"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 726,
    "Name": "Sanford Inc and Sons",
    "ToolTip": "Repellat deserunt sequi corrupti rerum.",
    "Deleted": false,
    "Rank": 476,
    "Type": "eius",
    "ColorBlock": 215,
    "IconHint": "accusamus",
    "Selected": true,
    "LastChanged": "2018-08-16T15:29:31.4324782+02:00",
    "ChildItems": [
      {
        "Id": 808,
        "Name": "Franecki LLC",
        "ToolTip": "Deserunt dolor eum eum molestiae.",
        "Deleted": false,
        "Rank": 617,
        "Type": "id",
        "ColorBlock": 937,
        "IconHint": "atque",
        "Selected": true,
        "LastChanged": "2010-06-03T15:29:31.4324782+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "molestiae",
        "StyleHint": "qui",
        "Hidden": false,
        "FullName": "Esperanza Arvid Wolff II",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 513
          }
        }
      }
    ],
    "ExtraInfo": "fugiat",
    "StyleHint": "officiis",
    "Hidden": true,
    "FullName": "Dr. Ethelyn Shawn Cummerata DDS",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 266
      }
    }
  }
]
```