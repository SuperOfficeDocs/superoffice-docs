---
title: PUT List/DeliveryType/Items/{id}/Headings
uid: v1DeliveryTypeList_PutDeliveryTypeHeadingsForListItem
generated: true
---

# PUT List/DeliveryType/Items/{id}/Headings

```http
PUT /api/v1/List/DeliveryType/Items/{itemId}/Headings
```

Saves headings for the DeliveryType list's item.


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
PUT /api/v1/List/DeliveryType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 34,
    "Name": "Doyle Inc and Sons",
    "ToolTip": "Velit et corrupti et expedita.",
    "Deleted": false,
    "Rank": 621,
    "Type": "qui",
    "ColorBlock": 188,
    "IconHint": "accusantium",
    "Selected": true,
    "LastChanged": "2020-09-19T11:44:43.0700205+02:00",
    "ChildItems": [
      {
        "Id": 459,
        "Name": "Crooks Inc and Sons",
        "ToolTip": "Soluta eos odio.",
        "Deleted": true,
        "Rank": 185,
        "Type": "deserunt",
        "ColorBlock": 990,
        "IconHint": "distinctio",
        "Selected": false,
        "LastChanged": "2005-08-16T11:44:43.0700205+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aliquam",
        "StyleHint": "voluptatem",
        "Hidden": false,
        "FullName": "Josephine Heidenreich"
      }
    ],
    "ExtraInfo": "minus",
    "StyleHint": "accusantium",
    "Hidden": false,
    "FullName": "Mrs. Joy Elisabeth Hirthe V"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 702,
    "Name": "Marquardt, Nader and Upton",
    "ToolTip": "Suscipit et maxime provident illo aut quisquam numquam.",
    "Deleted": false,
    "Rank": 8,
    "Type": "neque",
    "ColorBlock": 988,
    "IconHint": "dolorem",
    "Selected": false,
    "LastChanged": "2019-10-25T11:44:43.0700205+02:00",
    "ChildItems": [
      {
        "Id": 56,
        "Name": "Ryan-Hilll",
        "ToolTip": "Error illum laborum.",
        "Deleted": true,
        "Rank": 393,
        "Type": "repudiandae",
        "ColorBlock": 456,
        "IconHint": "vel",
        "Selected": false,
        "LastChanged": "1999-08-13T11:44:43.0700205+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sed",
        "StyleHint": "esse",
        "Hidden": false,
        "FullName": "Otha Nathan Jones PhD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 639
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "temporibus",
    "Hidden": false,
    "FullName": "Mrs. Bartholome Meagan Zulauf",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 406
      }
    }
  }
]
```