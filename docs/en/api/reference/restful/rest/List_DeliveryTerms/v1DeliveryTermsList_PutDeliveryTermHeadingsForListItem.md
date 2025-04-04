---
title: PUT List/DeliveryTerm/Items/{id}/Headings
uid: v1DeliveryTermsList_PutDeliveryTermHeadingsForListItem
generated: true
---

# PUT List/DeliveryTerm/Items/{id}/Headings

```http
PUT /api/v1/List/DeliveryTerm/Items/{itemId}/Headings
```

Saves headings for the DeliveryTerm list's item.


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
PUT /api/v1/List/DeliveryTerm/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 677,
    "Name": "Cronin LLC",
    "ToolTip": "Nemo omnis officia id quasi beatae.",
    "Deleted": false,
    "Rank": 460,
    "Type": "unde",
    "ColorBlock": 787,
    "IconHint": "qui",
    "Selected": false,
    "LastChanged": "2011-03-21T13:14:09.7441386+01:00",
    "ChildItems": [
      {
        "Id": 660,
        "Name": "Cartwright, McDermott and Kohler",
        "ToolTip": "Enim similique iste ex est dolore voluptas quia.",
        "Deleted": false,
        "Rank": 458,
        "Type": "qui",
        "ColorBlock": 126,
        "IconHint": "itaque",
        "Selected": false,
        "LastChanged": "2018-05-09T13:14:09.7441386+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aut",
        "StyleHint": "dolores",
        "Hidden": true,
        "FullName": "Mr. Tamara Hudson PhD"
      }
    ],
    "ExtraInfo": "voluptas",
    "StyleHint": "veniam",
    "Hidden": false,
    "FullName": "Gianni Turcotte PhD"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 785,
    "Name": "Koepp-Conn",
    "ToolTip": "Non amet enim.",
    "Deleted": false,
    "Rank": 555,
    "Type": "qui",
    "ColorBlock": 906,
    "IconHint": "quisquam",
    "Selected": true,
    "LastChanged": "2023-08-21T13:14:09.7441386+02:00",
    "ChildItems": [
      {
        "Id": 609,
        "Name": "Quitzon LLC",
        "ToolTip": "Quia asperiores corporis possimus cupiditate.",
        "Deleted": false,
        "Rank": 12,
        "Type": "consequatur",
        "ColorBlock": 515,
        "IconHint": "reiciendis",
        "Selected": false,
        "LastChanged": "2007-08-08T13:14:09.7441386+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "accusantium",
        "StyleHint": "quia",
        "Hidden": false,
        "FullName": "Maybelle Hane",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 356
          }
        }
      }
    ],
    "ExtraInfo": "velit",
    "StyleHint": "voluptas",
    "Hidden": false,
    "FullName": "Alva Treutel",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 991
      }
    }
  }
]
```