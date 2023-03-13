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
PUT /api/v1/List/SaleType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 490,
    "Name": "Kub Group",
    "ToolTip": "Qui blanditiis quo quos dolore et eveniet.",
    "Deleted": true,
    "Rank": 264,
    "Type": "molestiae",
    "ColorBlock": 50,
    "IconHint": "corrupti",
    "Selected": true,
    "LastChanged": "2013-02-20T12:15:28.4876135+01:00",
    "ChildItems": [
      {
        "Id": 195,
        "Name": "Oberbrunner, Runte and Rempel",
        "ToolTip": "Eos ut voluptas tempora consequatur laborum aperiam veritatis.",
        "Deleted": false,
        "Rank": 114,
        "Type": "consectetur",
        "ColorBlock": 100,
        "IconHint": "nobis",
        "Selected": false,
        "LastChanged": "2016-09-15T12:15:28.4876135+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sit",
        "StyleHint": "possimus",
        "Hidden": false,
        "FullName": "Dr. Shad Augustine Zboncak"
      }
    ],
    "ExtraInfo": "deleniti",
    "StyleHint": "velit",
    "Hidden": false,
    "FullName": "Miss Charlotte Mertz MD"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 821,
    "Name": "Schaefer Group",
    "ToolTip": "Qui amet necessitatibus aut labore sunt sed at.",
    "Deleted": false,
    "Rank": 521,
    "Type": "minima",
    "ColorBlock": 596,
    "IconHint": "alias",
    "Selected": false,
    "LastChanged": "1999-12-28T12:15:28.4896146+01:00",
    "ChildItems": [
      {
        "Id": 910,
        "Name": "Emard Inc and Sons",
        "ToolTip": "Blanditiis natus doloribus consectetur.",
        "Deleted": false,
        "Rank": 993,
        "Type": "minus",
        "ColorBlock": 379,
        "IconHint": "asperiores",
        "Selected": true,
        "LastChanged": "2003-07-13T12:15:28.4896146+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "possimus",
        "StyleHint": "temporibus",
        "Hidden": true,
        "FullName": "Ryleigh Anibal Treutel Sr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 456
          }
        }
      }
    ],
    "ExtraInfo": "nesciunt",
    "StyleHint": "veritatis",
    "Hidden": false,
    "FullName": "Prof. Margot Feeney",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 458
      }
    }
  }
]
```