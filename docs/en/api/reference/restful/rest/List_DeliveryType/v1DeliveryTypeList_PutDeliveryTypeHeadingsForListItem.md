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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 237,
    "Name": "Beier, Hane and Hyatt",
    "ToolTip": "Sint consequatur id omnis aut voluptas.",
    "Deleted": true,
    "Rank": 139,
    "Type": "dolore",
    "ColorBlock": 164,
    "IconHint": "aut",
    "Selected": false,
    "LastChanged": "1996-09-17T12:15:28.1346207+02:00",
    "ChildItems": [
      {
        "Id": 251,
        "Name": "Paucek Group",
        "ToolTip": "Qui qui nulla iure assumenda libero deserunt.",
        "Deleted": true,
        "Rank": 388,
        "Type": "eum",
        "ColorBlock": 216,
        "IconHint": "assumenda",
        "Selected": false,
        "LastChanged": "2002-03-23T12:15:28.1346207+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "commodi",
        "StyleHint": "ab",
        "Hidden": true,
        "FullName": "Bert Hyman Stokes I"
      }
    ],
    "ExtraInfo": "laboriosam",
    "StyleHint": "quod",
    "Hidden": false,
    "FullName": "Reanna West"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 149,
    "Name": "Durgan, Langosh and Dare",
    "ToolTip": "Eveniet enim omnis eos.",
    "Deleted": false,
    "Rank": 778,
    "Type": "dolor",
    "ColorBlock": 785,
    "IconHint": "excepturi",
    "Selected": true,
    "LastChanged": "2004-03-07T12:15:28.1356187+01:00",
    "ChildItems": [
      {
        "Id": 235,
        "Name": "Nitzsche LLC",
        "ToolTip": "Quia est earum cum.",
        "Deleted": true,
        "Rank": 758,
        "Type": "tempore",
        "ColorBlock": 946,
        "IconHint": "sint",
        "Selected": false,
        "LastChanged": "2004-12-24T12:15:28.1356187+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "consequatur",
        "StyleHint": "sed",
        "Hidden": false,
        "FullName": "Wilhelmine Stanton V",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 999
          }
        }
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "quia",
    "Hidden": false,
    "FullName": "Markus Pollich V",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 221
      }
    }
  }
]
```