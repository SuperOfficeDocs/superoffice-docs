---
title: PUT List/SaleType/Items/{id}/Headings
uid: v1SaleTypeList_PutSaleTypeEntityHeadingsForListItem
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

OK

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

## Sample request

```http!
PUT /api/v1/List/SaleType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 867,
    "Name": "Keeling-Hammes",
    "ToolTip": "Fugit hic quia rerum suscipit ut.",
    "Deleted": false,
    "Rank": 954,
    "Type": "est",
    "ColorBlock": 951,
    "IconHint": "dolor",
    "Selected": false,
    "LastChanged": "1996-11-19T02:49:52.5159497+01:00",
    "ChildItems": [
      {
        "Id": 599,
        "Name": "Kemmer Inc and Sons",
        "ToolTip": "A veritatis iusto impedit quos quo vel qui.",
        "Deleted": true,
        "Rank": 604,
        "Type": "corrupti",
        "ColorBlock": 915,
        "IconHint": "sint",
        "Selected": true,
        "LastChanged": "2019-02-23T02:49:52.5159497+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ex",
        "StyleHint": "consequatur",
        "Hidden": true,
        "FullName": "Ms. Darwin Ashton Monahan"
      }
    ],
    "ExtraInfo": "impedit",
    "StyleHint": "fuga",
    "Hidden": false,
    "FullName": "Betsy Gianni Reilly Jr."
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 100,
    "Name": "Jakubowski LLC",
    "ToolTip": "Id est ad.",
    "Deleted": false,
    "Rank": 543,
    "Type": "sit",
    "ColorBlock": 729,
    "IconHint": "esse",
    "Selected": true,
    "LastChanged": "2015-05-25T02:49:52.5159497+02:00",
    "ChildItems": [
      {
        "Id": 496,
        "Name": "Schroeder-Klein",
        "ToolTip": "Id quos amet laudantium unde et.",
        "Deleted": true,
        "Rank": 684,
        "Type": "id",
        "ColorBlock": 245,
        "IconHint": "reprehenderit",
        "Selected": false,
        "LastChanged": "2022-03-17T02:49:52.5159497+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quia",
        "StyleHint": "beatae",
        "Hidden": false,
        "FullName": "Stephen Steuber",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 654
          }
        }
      }
    ],
    "ExtraInfo": "nulla",
    "StyleHint": "et",
    "Hidden": true,
    "FullName": "Cali Dach",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 351
      }
    }
  }
]
```