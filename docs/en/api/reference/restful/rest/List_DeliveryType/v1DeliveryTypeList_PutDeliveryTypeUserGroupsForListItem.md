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
    "Id": 836,
    "Name": "Johnston Group",
    "ToolTip": "Quaerat quos laborum et facilis nostrum eligendi nemo.",
    "Deleted": true,
    "Rank": 658,
    "Type": "quasi",
    "ColorBlock": 712,
    "IconHint": "consequatur",
    "Selected": false,
    "LastChanged": "2019-05-03T03:45:29.0296674+02:00",
    "ChildItems": [
      {
        "Id": 985,
        "Name": "Weimann-O'Connell",
        "ToolTip": "Fuga esse nisi quis architecto.",
        "Deleted": false,
        "Rank": 902,
        "Type": "consequatur",
        "ColorBlock": 508,
        "IconHint": "ea",
        "Selected": true,
        "LastChanged": "2020-07-23T03:45:29.0296674+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "in",
        "StyleHint": "delectus",
        "Hidden": true,
        "FullName": "Jessica O'Connell"
      }
    ],
    "ExtraInfo": "aliquid",
    "StyleHint": "autem",
    "Hidden": true,
    "FullName": "Andreane Bins"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 233,
    "Name": "Monahan-Jones",
    "ToolTip": "Eaque nostrum accusantium ipsa.",
    "Deleted": true,
    "Rank": 579,
    "Type": "rem",
    "ColorBlock": 750,
    "IconHint": "dignissimos",
    "Selected": false,
    "LastChanged": "2005-12-17T03:45:29.0296674+01:00",
    "ChildItems": [
      {
        "Id": 328,
        "Name": "McClure-Hudson",
        "ToolTip": "Et blanditiis dolorem delectus ab voluptas et quisquam.",
        "Deleted": true,
        "Rank": 526,
        "Type": "pariatur",
        "ColorBlock": 634,
        "IconHint": "aliquam",
        "Selected": false,
        "LastChanged": "2017-12-23T03:45:29.0296674+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quo",
        "StyleHint": "culpa",
        "Hidden": false,
        "FullName": "Blaise Smitham",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 963
          }
        }
      }
    ],
    "ExtraInfo": "laborum",
    "StyleHint": "quia",
    "Hidden": false,
    "FullName": "Isobel Steuber",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 85
      }
    }
  }
]
```