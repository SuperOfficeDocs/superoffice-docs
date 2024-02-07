---
title: PUT List/ProductCategory/Items/{id}/Headings
uid: v1ProductCategoryList_PutProductCategoryHeadingsForListItem
generated: true
---

# PUT List/ProductCategory/Items/{id}/Headings

```http
PUT /api/v1/List/ProductCategory/Items/{itemId}/Headings
```

Saves headings for the ProductCategory list's item.


Calls the List agent service SaveHeadingsForListItemFromListDefinition.





| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the headings to be saved. **Required** |



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
PUT /api/v1/List/ProductCategory/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 870,
    "Name": "Windler, Fadel and Leannon",
    "ToolTip": "Quam accusantium magnam voluptatem sed eos labore delectus.",
    "Deleted": false,
    "Rank": 701,
    "Type": "voluptatum",
    "ColorBlock": 478,
    "IconHint": "ut",
    "Selected": false,
    "LastChanged": "2008-01-06T16:55:30.8007354+01:00",
    "ChildItems": [
      {
        "Id": 353,
        "Name": "Jacobson-Bruen",
        "ToolTip": "Nostrum corporis voluptates dolore perferendis cum et.",
        "Deleted": true,
        "Rank": 264,
        "Type": "vel",
        "ColorBlock": 49,
        "IconHint": "ullam",
        "Selected": true,
        "LastChanged": "2007-11-28T16:55:30.8007354+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dicta",
        "StyleHint": "numquam",
        "Hidden": false,
        "FullName": "Mr. Nelson O'Kon"
      }
    ],
    "ExtraInfo": "numquam",
    "StyleHint": "culpa",
    "Hidden": false,
    "FullName": "Nola Durgan V"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 194,
    "Name": "Hodkiewicz, Rogahn and Kuvalis",
    "ToolTip": "Mollitia ea voluptatibus.",
    "Deleted": false,
    "Rank": 324,
    "Type": "alias",
    "ColorBlock": 715,
    "IconHint": "facere",
    "Selected": false,
    "LastChanged": "2020-03-08T16:55:30.8017171+01:00",
    "ChildItems": [
      {
        "Id": 14,
        "Name": "Vandervort, Leffler and DuBuque",
        "ToolTip": "Asperiores maiores velit vel esse architecto non exercitationem.",
        "Deleted": true,
        "Rank": 668,
        "Type": "saepe",
        "ColorBlock": 173,
        "IconHint": "ducimus",
        "Selected": false,
        "LastChanged": "2016-04-26T16:55:30.8017171+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "omnis",
        "StyleHint": "voluptas",
        "Hidden": true,
        "FullName": "Fannie Becker",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 833
          }
        }
      }
    ],
    "ExtraInfo": "voluptatum",
    "StyleHint": "ut",
    "Hidden": false,
    "FullName": "Murray Dandre Gislason III",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 198
      }
    }
  }
]
```