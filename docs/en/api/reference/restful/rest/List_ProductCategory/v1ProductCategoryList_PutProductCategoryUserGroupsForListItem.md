---
title: PUT List/ProductCategory/Items/{id}/UserGroups
uid: v1ProductCategoryList_PutProductCategoryUserGroupsForListItem
generated: true
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
PUT /api/v1/List/ProductCategory/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 547,
    "Name": "Bergnaum, Muller and Kovacek",
    "ToolTip": "In ut et aut.",
    "Deleted": false,
    "Rank": 314,
    "Type": "voluptatibus",
    "ColorBlock": 282,
    "IconHint": "beatae",
    "Selected": false,
    "LastChanged": "2001-07-27T11:06:42.9128214+02:00",
    "ChildItems": [
      {
        "Id": 225,
        "Name": "Legros Inc and Sons",
        "ToolTip": "Voluptatem ipsa odio at sit.",
        "Deleted": false,
        "Rank": 233,
        "Type": "quis",
        "ColorBlock": 70,
        "IconHint": "placeat",
        "Selected": false,
        "LastChanged": "2000-11-06T11:06:42.9128214+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ea",
        "StyleHint": "odio",
        "Hidden": true,
        "FullName": "Mr. Madge Eichmann II"
      }
    ],
    "ExtraInfo": "voluptatem",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Dr. Izaiah Bogan DDS"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 129,
    "Name": "Johnston-King",
    "ToolTip": "Neque saepe voluptatem.",
    "Deleted": false,
    "Rank": 271,
    "Type": "inventore",
    "ColorBlock": 165,
    "IconHint": "delectus",
    "Selected": false,
    "LastChanged": "2015-12-30T11:06:42.9128214+01:00",
    "ChildItems": [
      {
        "Id": 779,
        "Name": "Blanda, Hermiston and Welch",
        "ToolTip": "Alias minus et doloribus dolores minima.",
        "Deleted": true,
        "Rank": 954,
        "Type": "explicabo",
        "ColorBlock": 109,
        "IconHint": "vitae",
        "Selected": false,
        "LastChanged": "2019-09-02T11:06:42.9128214+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "magnam",
        "StyleHint": "delectus",
        "Hidden": false,
        "FullName": "Frankie Kerluke",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 351
          }
        }
      }
    ],
    "ExtraInfo": "ipsam",
    "StyleHint": "natus",
    "Hidden": false,
    "FullName": "Darwin Wolff",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 997
      }
    }
  }
]
```