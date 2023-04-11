---
title: PUT List/PaymentType/Items/{id}/Headings
uid: v1PaymentTypeList_PutPaymentTypeHeadingsForListItem
---

# PUT List/PaymentType/Items/{id}/Headings

```http
PUT /api/v1/List/PaymentType/Items/{itemId}/Headings
```

Saves headings for the PaymentType list's item.


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
PUT /api/v1/List/PaymentType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 701,
    "Name": "Stoltenberg-Rogahn",
    "ToolTip": "Et consectetur et vitae et.",
    "Deleted": false,
    "Rank": 595,
    "Type": "tempore",
    "ColorBlock": 551,
    "IconHint": "quis",
    "Selected": true,
    "LastChanged": "2018-01-04T15:29:31.3459771+01:00",
    "ChildItems": [
      {
        "Id": 595,
        "Name": "Terry, Blanda and Bailey",
        "ToolTip": "Eveniet perferendis laboriosam quos.",
        "Deleted": true,
        "Rank": 417,
        "Type": "quia",
        "ColorBlock": 286,
        "IconHint": "quia",
        "Selected": false,
        "LastChanged": "2005-03-19T15:29:31.3464807+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quaerat",
        "StyleHint": "tempora",
        "Hidden": true,
        "FullName": "Cody Herman"
      }
    ],
    "ExtraInfo": "cupiditate",
    "StyleHint": "non",
    "Hidden": false,
    "FullName": "Khalil Johnson"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 495,
    "Name": "Hayes Group",
    "ToolTip": "Reprehenderit dolor.",
    "Deleted": true,
    "Rank": 312,
    "Type": "sunt",
    "ColorBlock": 215,
    "IconHint": "porro",
    "Selected": true,
    "LastChanged": "2020-02-14T15:29:31.3474803+01:00",
    "ChildItems": [
      {
        "Id": 107,
        "Name": "Wuckert-Beer",
        "ToolTip": "Culpa porro omnis debitis ea atque sit.",
        "Deleted": true,
        "Rank": 987,
        "Type": "labore",
        "ColorBlock": 482,
        "IconHint": "voluptatem",
        "Selected": true,
        "LastChanged": "2010-09-09T15:29:31.3474803+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "blanditiis",
        "StyleHint": "quibusdam",
        "Hidden": false,
        "FullName": "Neha Labadie",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 518
          }
        }
      }
    ],
    "ExtraInfo": "est",
    "StyleHint": "explicabo",
    "Hidden": true,
    "FullName": "Dedrick Gislason",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 819
      }
    }
  }
]
```