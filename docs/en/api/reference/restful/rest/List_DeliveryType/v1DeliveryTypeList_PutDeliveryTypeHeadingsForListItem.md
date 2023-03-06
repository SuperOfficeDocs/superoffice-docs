---
title: PUT List/DeliveryType/Items/{id}/Headings
uid: v1DeliveryTypeList_PutDeliveryTypeHeadingsForListItem
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/DeliveryType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 820,
    "Name": "Tillman, Hackett and Waters",
    "ToolTip": "Ullam et praesentium est architecto quaerat pariatur.",
    "Deleted": false,
    "Rank": 359,
    "Type": "modi",
    "ColorBlock": 418,
    "IconHint": "tempora",
    "Selected": true,
    "LastChanged": "2010-08-19T14:19:11.2418468+02:00",
    "ChildItems": [
      {
        "Id": 529,
        "Name": "Mraz, Stark and Corkery",
        "ToolTip": "Nihil ullam.",
        "Deleted": false,
        "Rank": 96,
        "Type": "aut",
        "ColorBlock": 643,
        "IconHint": "quo",
        "Selected": false,
        "LastChanged": "2016-12-04T14:19:11.2418468+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptatem",
        "StyleHint": "rerum",
        "Hidden": false,
        "FullName": "Phyllis Effertz"
      }
    ],
    "ExtraInfo": "velit",
    "StyleHint": "ut",
    "Hidden": true,
    "FullName": "Miss Zechariah Pansy Haley Jr."
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 513,
    "Name": "Wuckert, Bode and Braun",
    "ToolTip": "Libero officia corrupti sunt.",
    "Deleted": true,
    "Rank": 149,
    "Type": "tempora",
    "ColorBlock": 319,
    "IconHint": "sed",
    "Selected": true,
    "LastChanged": "2016-08-20T14:19:11.2418468+02:00",
    "ChildItems": [
      {
        "Id": 874,
        "Name": "Hettinger, Klocko and Romaguera",
        "ToolTip": "Temporibus ut.",
        "Deleted": true,
        "Rank": 17,
        "Type": "enim",
        "ColorBlock": 740,
        "IconHint": "ut",
        "Selected": false,
        "LastChanged": "1998-06-04T14:19:11.2418468+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "velit",
        "StyleHint": "cumque",
        "Hidden": false,
        "FullName": "Dr. Kyla Lind MD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 176
          }
        }
      }
    ],
    "ExtraInfo": "ipsam",
    "StyleHint": "sit",
    "Hidden": false,
    "FullName": "Miss Daphnee VonRueden III",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 888
      }
    }
  }
]
```