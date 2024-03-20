---
title: PUT List/ProductType/Items/{id}/Headings
uid: v1ProductTypeList_PutProductTypeHeadingsForListItem
generated: true
---

# PUT List/ProductType/Items/{id}/Headings

```http
PUT /api/v1/List/ProductType/Items/{itemId}/Headings
```

Saves headings for the ProductType list's item.


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
PUT /api/v1/List/ProductType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 387,
    "Name": "Aufderhar Group",
    "ToolTip": "Omnis consectetur dolore minima.",
    "Deleted": false,
    "Rank": 192,
    "Type": "assumenda",
    "ColorBlock": 785,
    "IconHint": "expedita",
    "Selected": true,
    "LastChanged": "2012-03-01T12:19:54.7271106+01:00",
    "ChildItems": [
      {
        "Id": 699,
        "Name": "Gottlieb, Swaniawski and Ritchie",
        "ToolTip": "Et sit.",
        "Deleted": false,
        "Rank": 418,
        "Type": "voluptates",
        "ColorBlock": 463,
        "IconHint": "earum",
        "Selected": true,
        "LastChanged": "1999-01-11T12:19:54.7271106+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolorum",
        "StyleHint": "sint",
        "Hidden": false,
        "FullName": "Emmanuelle Harvey"
      }
    ],
    "ExtraInfo": "officia",
    "StyleHint": "atque",
    "Hidden": true,
    "FullName": "Rafael Schmidt"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 404,
    "Name": "Bradtke Group",
    "ToolTip": "Expedita tempora.",
    "Deleted": false,
    "Rank": 281,
    "Type": "labore",
    "ColorBlock": 895,
    "IconHint": "itaque",
    "Selected": false,
    "LastChanged": "2009-02-19T12:19:54.7271106+01:00",
    "ChildItems": [
      {
        "Id": 482,
        "Name": "Altenwerth, Shields and Kiehn",
        "ToolTip": "Voluptatibus id adipisci voluptas iure aut nisi voluptatum.",
        "Deleted": true,
        "Rank": 457,
        "Type": "debitis",
        "ColorBlock": 429,
        "IconHint": "aut",
        "Selected": true,
        "LastChanged": "2000-12-25T12:19:54.7271106+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "perspiciatis",
        "StyleHint": "magni",
        "Hidden": true,
        "FullName": "Liliane Ahmad Schmeler PhD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 150
          }
        }
      }
    ],
    "ExtraInfo": "amet",
    "StyleHint": "ea",
    "Hidden": false,
    "FullName": "Zackery Alexie Ziemann Sr.",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 416
      }
    }
  }
]
```