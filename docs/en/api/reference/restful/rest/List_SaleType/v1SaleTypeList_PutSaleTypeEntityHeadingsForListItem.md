---
title: PUT List/SaleType/Items/{id}/Headings
uid: v1SaleTypeList_PutSaleTypeEntityHeadingsForListItem
generated: true
---

# PUT List/SaleType/Items/{id}/Headings

```http
PUT /api/v1/List/SaleType/Items/{itemId}/Headings
```

Saves headings for the SaleTypeEntity list's item.


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
PUT /api/v1/List/SaleType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 196,
    "Name": "Tillman Group",
    "ToolTip": "Animi quo non enim maiores modi et nisi.",
    "Deleted": false,
    "Rank": 63,
    "Type": "sunt",
    "ColorBlock": 54,
    "IconHint": "nihil",
    "Selected": false,
    "LastChanged": "2012-02-17T13:28:33.1638597+01:00",
    "ChildItems": [
      {
        "Id": 203,
        "Name": "Skiles-Bosco",
        "ToolTip": "Minus quas animi enim quia.",
        "Deleted": false,
        "Rank": 944,
        "Type": "vitae",
        "ColorBlock": 60,
        "IconHint": "consequatur",
        "Selected": false,
        "LastChanged": "2001-07-13T13:28:33.1638597+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quibusdam",
        "StyleHint": "tenetur",
        "Hidden": false,
        "FullName": "Lysanne O'Hara"
      }
    ],
    "ExtraInfo": "molestiae",
    "StyleHint": "nemo",
    "Hidden": true,
    "FullName": "Yvette Johnston"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 214,
    "Name": "Emmerich-Jacobson",
    "ToolTip": "Debitis praesentium rerum.",
    "Deleted": false,
    "Rank": 415,
    "Type": "reprehenderit",
    "ColorBlock": 58,
    "IconHint": "ut",
    "Selected": false,
    "LastChanged": "2002-05-22T13:28:33.1638597+02:00",
    "ChildItems": [
      {
        "Id": 246,
        "Name": "Jenkins, Hickle and Ryan",
        "ToolTip": "Suscipit iusto et eos eveniet eaque tempore.",
        "Deleted": false,
        "Rank": 864,
        "Type": "atque",
        "ColorBlock": 974,
        "IconHint": "quam",
        "Selected": false,
        "LastChanged": "2021-10-16T13:28:33.1638597+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolorem",
        "StyleHint": "at",
        "Hidden": false,
        "FullName": "Celestine Mann",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 60
          }
        }
      }
    ],
    "ExtraInfo": "blanditiis",
    "StyleHint": "voluptate",
    "Hidden": false,
    "FullName": "Sigmund Thompson",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 897
      }
    }
  }
]
```