---
title: PUT List/QuoteApproveReason/Items/{id}/UserGroups
uid: v1QuoteApproveReasonList_PutQuoteApproveReasonUserGroupsForListItem
---

# PUT List/QuoteApproveReason/Items/{id}/UserGroups

```http
PUT /api/v1/List/QuoteApproveReason/Items/{itemId}/UserGroups
```

Saves user groups visible for the QuoteApproveReason list's item.


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
PUT /api/v1/List/QuoteApproveReason/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 383,
    "Name": "Kiehn-Swaniawski",
    "ToolTip": "Corrupti possimus tempora architecto omnis nihil voluptates voluptatem.",
    "Deleted": true,
    "Rank": 691,
    "Type": "magni",
    "ColorBlock": 601,
    "IconHint": "tenetur",
    "Selected": false,
    "LastChanged": "2003-02-22T14:19:11.4149038+01:00",
    "ChildItems": [
      {
        "Id": 321,
        "Name": "Gulgowski, Kub and Grant",
        "ToolTip": "Sit consequuntur voluptates cumque totam.",
        "Deleted": true,
        "Rank": 368,
        "Type": "beatae",
        "ColorBlock": 176,
        "IconHint": "similique",
        "Selected": false,
        "LastChanged": "2012-09-24T14:19:11.4149038+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nostrum",
        "StyleHint": "asperiores",
        "Hidden": true,
        "FullName": "Willy Deonte Rath DDS"
      }
    ],
    "ExtraInfo": "debitis",
    "StyleHint": "perferendis",
    "Hidden": false,
    "FullName": "Meghan Parker"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 706,
    "Name": "Satterfield-Feeney",
    "ToolTip": "Sapiente et enim dicta fugit.",
    "Deleted": false,
    "Rank": 676,
    "Type": "consequatur",
    "ColorBlock": 831,
    "IconHint": "aspernatur",
    "Selected": false,
    "LastChanged": "2022-08-19T14:19:11.430529+02:00",
    "ChildItems": [
      {
        "Id": 98,
        "Name": "Schowalter, McGlynn and Hettinger",
        "ToolTip": "Est ullam unde sequi.",
        "Deleted": false,
        "Rank": 173,
        "Type": "et",
        "ColorBlock": 220,
        "IconHint": "iure",
        "Selected": false,
        "LastChanged": "1996-09-16T14:19:11.430529+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptatibus",
        "StyleHint": "ad",
        "Hidden": true,
        "FullName": "Elinor Beahan",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 47
          }
        }
      }
    ],
    "ExtraInfo": "iure",
    "StyleHint": "ipsa",
    "Hidden": true,
    "FullName": "Daphney Thompson",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 471
      }
    }
  }
]
```