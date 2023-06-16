---
title: PUT List/DeliveryType/Items/{id}/UserGroups
uid: v1DeliveryTypeList_PutDeliveryTypeUserGroupsForListItem
generated: true
---

# PUT List/DeliveryType/Items/{id}/UserGroups

```http
PUT /api/v1/List/DeliveryType/Items/{itemId}/UserGroups
```

Saves user groups visible for the DeliveryType list's item.


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
PUT /api/v1/List/DeliveryType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 763,
    "Name": "Grant, Harber and Bailey",
    "ToolTip": "Voluptas id hic aut veniam.",
    "Deleted": true,
    "Rank": 351,
    "Type": "laudantium",
    "ColorBlock": 358,
    "IconHint": "aut",
    "Selected": false,
    "LastChanged": "1996-06-05T16:00:49.0083336+02:00",
    "ChildItems": [
      {
        "Id": 474,
        "Name": "Leffler, Tromp and Adams",
        "ToolTip": "Facere est et aspernatur dicta unde sint sed.",
        "Deleted": false,
        "Rank": 588,
        "Type": "veniam",
        "ColorBlock": 319,
        "IconHint": "odio",
        "Selected": false,
        "LastChanged": "2019-12-11T16:00:49.0083336+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aut",
        "StyleHint": "magnam",
        "Hidden": false,
        "FullName": "Milford Treutel"
      }
    ],
    "ExtraInfo": "eius",
    "StyleHint": "consequatur",
    "Hidden": false,
    "FullName": "Miss Providenci Niko Krajcik DVM"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 473,
    "Name": "Kautzer, Moen and Kunze",
    "ToolTip": "Culpa omnis accusantium quas quam ut sunt dolor.",
    "Deleted": true,
    "Rank": 599,
    "Type": "omnis",
    "ColorBlock": 516,
    "IconHint": "totam",
    "Selected": true,
    "LastChanged": "2012-11-03T16:00:49.0083336+01:00",
    "ChildItems": [
      {
        "Id": 95,
        "Name": "Streich, Renner and Cormier",
        "ToolTip": "Iure qui atque veritatis nostrum quo.",
        "Deleted": true,
        "Rank": 608,
        "Type": "numquam",
        "ColorBlock": 580,
        "IconHint": "error",
        "Selected": false,
        "LastChanged": "2007-07-30T16:00:49.0083336+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "laboriosam",
        "StyleHint": "laborum",
        "Hidden": false,
        "FullName": "Prof. Cathryn Jacobs",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 455
          }
        }
      }
    ],
    "ExtraInfo": "nulla",
    "StyleHint": "eius",
    "Hidden": false,
    "FullName": "Prof. Christiana Kilback",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 639
      }
    }
  }
]
```