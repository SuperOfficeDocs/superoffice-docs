---
title: GET List/DeliveryType/Items/{id}/Headings
uid: v1DeliveryTypeList_GetDeliveryTypeHeadingsForListItem
generated: true
---

# GET List/DeliveryType/Items/{id}/Headings

```http
GET /api/v1/List/DeliveryType/Items/{itemId}/Headings
```

Gets headings for the DeliveryType list's item.


Calls the List agent service GetHeadings.





| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the headings to be get. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| showDeleted | bool |  Whether to show deleted items or not. Default false. |

```http
GET /api/v1/List/DeliveryType/Items/{itemId}/Headings?showDeleted=False
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
GET /api/v1/List/DeliveryType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 999,
    "Name": "Strosin, Luettgen and Goldner",
    "ToolTip": "Soluta eligendi eveniet.",
    "Deleted": true,
    "Rank": 906,
    "Type": "harum",
    "ColorBlock": 678,
    "IconHint": "rerum",
    "Selected": false,
    "LastChanged": "2014-10-14T11:06:42.8034416+02:00",
    "ChildItems": [
      {
        "Id": 303,
        "Name": "Boehm-Kerluke",
        "ToolTip": "Omnis ea labore numquam dolore ut quos unde.",
        "Deleted": false,
        "Rank": 998,
        "Type": "corporis",
        "ColorBlock": 949,
        "IconHint": "nam",
        "Selected": false,
        "LastChanged": "2001-01-25T11:06:42.8034416+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quasi",
        "StyleHint": "sunt",
        "Hidden": false,
        "FullName": "Hayden Schuster",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 82
          }
        }
      }
    ],
    "ExtraInfo": "quo",
    "StyleHint": "quia",
    "Hidden": true,
    "FullName": "Cleta Toy",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 665
      }
    }
  }
]
```