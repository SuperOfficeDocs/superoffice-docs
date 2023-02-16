---
title: PUT List/PaymentType/Items/{id}/UserGroups
uid: v1PaymentTypeList_PutPaymentTypeUserGroupsForListItem
---

# PUT List/PaymentType/Items/{id}/UserGroups

```http
PUT /api/v1/List/PaymentType/Items/{itemId}/UserGroups
```

Saves user groups visible for the PaymentType list's item.


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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/PaymentType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 557,
    "Name": "O'Kon LLC",
    "ToolTip": "Tempora nobis autem expedita adipisci et ut.",
    "Deleted": true,
    "Rank": 936,
    "Type": "facilis",
    "ColorBlock": 458,
    "IconHint": "maiores",
    "Selected": false,
    "LastChanged": "2017-09-11T14:19:11.3211603+02:00",
    "ChildItems": [
      {
        "Id": 227,
        "Name": "Cummings LLC",
        "ToolTip": "Possimus temporibus perspiciatis minus.",
        "Deleted": false,
        "Rank": 644,
        "Type": "ut",
        "ColorBlock": 138,
        "IconHint": "aliquid",
        "Selected": false,
        "LastChanged": "2008-08-26T14:19:11.3211603+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "quibusdam",
        "Hidden": false,
        "FullName": "Franz Okuneva"
      }
    ],
    "ExtraInfo": "nisi",
    "StyleHint": "quisquam",
    "Hidden": false,
    "FullName": "Brent Windler"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 715,
    "Name": "Wunsch-Kemmer",
    "ToolTip": "Adipisci labore in tenetur consequuntur sed.",
    "Deleted": false,
    "Rank": 311,
    "Type": "possimus",
    "ColorBlock": 828,
    "IconHint": "omnis",
    "Selected": true,
    "LastChanged": "2005-05-24T14:19:11.3211603+02:00",
    "ChildItems": [
      {
        "Id": 805,
        "Name": "Gorczany, Hilll and DuBuque",
        "ToolTip": "Accusamus assumenda ullam est libero.",
        "Deleted": false,
        "Rank": 129,
        "Type": "ut",
        "ColorBlock": 370,
        "IconHint": "tempore",
        "Selected": true,
        "LastChanged": "2006-01-16T14:19:11.3211603+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "odio",
        "StyleHint": "et",
        "Hidden": false,
        "FullName": "Dr. Paula Jaskolski MD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 926
          }
        }
      }
    ],
    "ExtraInfo": "officia",
    "StyleHint": "quam",
    "Hidden": false,
    "FullName": "Mrs. Hilbert Haleigh Lesch PhD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 442
      }
    }
  }
]
```