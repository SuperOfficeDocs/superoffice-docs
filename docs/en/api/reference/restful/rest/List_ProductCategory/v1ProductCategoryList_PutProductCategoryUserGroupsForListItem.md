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
    "Id": 23,
    "Name": "Pollich, Schneider and Kuhn",
    "ToolTip": "Est ut nisi temporibus corporis earum.",
    "Deleted": true,
    "Rank": 456,
    "Type": "beatae",
    "ColorBlock": 889,
    "IconHint": "ut",
    "Selected": true,
    "LastChanged": "2021-04-01T16:32:48.7901236+02:00",
    "ChildItems": [
      {
        "Id": 61,
        "Name": "Shanahan-Conroy",
        "ToolTip": "Ut consequatur id ex possimus eos pariatur.",
        "Deleted": true,
        "Rank": 619,
        "Type": "quae",
        "ColorBlock": 684,
        "IconHint": "omnis",
        "Selected": true,
        "LastChanged": "2015-05-02T16:32:48.7901236+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "beatae",
        "StyleHint": "sapiente",
        "Hidden": false,
        "FullName": "Bryon Christiansen"
      }
    ],
    "ExtraInfo": "enim",
    "StyleHint": "iusto",
    "Hidden": false,
    "FullName": "Nettie Durgan"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 410,
    "Name": "Toy-Larkin",
    "ToolTip": "Aut iusto exercitationem vero dolor voluptatem.",
    "Deleted": true,
    "Rank": 741,
    "Type": "illo",
    "ColorBlock": 856,
    "IconHint": "eos",
    "Selected": true,
    "LastChanged": "2022-02-14T16:32:48.7901236+01:00",
    "ChildItems": [
      {
        "Id": 763,
        "Name": "Nader-Walter",
        "ToolTip": "Eos molestiae et ea tempora minus et sequi.",
        "Deleted": false,
        "Rank": 333,
        "Type": "eius",
        "ColorBlock": 381,
        "IconHint": "veniam",
        "Selected": false,
        "LastChanged": "2011-05-16T16:32:48.7901236+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eligendi",
        "StyleHint": "exercitationem",
        "Hidden": false,
        "FullName": "Verlie Kerluke I",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 193
          }
        }
      }
    ],
    "ExtraInfo": "alias",
    "StyleHint": "incidunt",
    "Hidden": false,
    "FullName": "Randal Zboncak",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 550
      }
    }
  }
]
```