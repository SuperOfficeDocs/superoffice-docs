---
title: PUT List/ConsentPurpose/Items/{id}/UserGroups
uid: v1ConsentPurposeList_PutConsentPurposeUserGroupsForListItem
---

# PUT List/ConsentPurpose/Items/{id}/UserGroups

```http
PUT /api/v1/List/ConsentPurpose/Items/{itemId}/UserGroups
```

Saves user groups visible for the ConsentPurpose list's item.


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
PUT /api/v1/List/ConsentPurpose/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 564,
    "Name": "Quitzon, Treutel and Yost",
    "ToolTip": "Corrupti qui et deserunt praesentium tempore vel.",
    "Deleted": false,
    "Rank": 939,
    "Type": "eaque",
    "ColorBlock": 802,
    "IconHint": "nulla",
    "Selected": false,
    "LastChanged": "1998-11-04T02:49:51.9378192+01:00",
    "ChildItems": [
      {
        "Id": 814,
        "Name": "Bernier, Wolf and Ortiz",
        "ToolTip": "Iste similique.",
        "Deleted": true,
        "Rank": 854,
        "Type": "quo",
        "ColorBlock": 59,
        "IconHint": "adipisci",
        "Selected": true,
        "LastChanged": "1998-06-07T02:49:51.9378192+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "nobis",
        "Hidden": false,
        "FullName": "Prof. Nasir Felicia Breitenberg"
      }
    ],
    "ExtraInfo": "dolorum",
    "StyleHint": "eaque",
    "Hidden": false,
    "FullName": "Mr. Krista Torp II"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 924,
    "Name": "Grant-Gleason",
    "ToolTip": "Quam at quisquam nihil rem beatae ratione.",
    "Deleted": true,
    "Rank": 547,
    "Type": "adipisci",
    "ColorBlock": 293,
    "IconHint": "quia",
    "Selected": false,
    "LastChanged": "2018-10-19T02:49:51.9378192+02:00",
    "ChildItems": [
      {
        "Id": 275,
        "Name": "Ward LLC",
        "ToolTip": "Harum quidem et ipsum alias facere.",
        "Deleted": false,
        "Rank": 607,
        "Type": "ipsa",
        "ColorBlock": 566,
        "IconHint": "voluptatem",
        "Selected": true,
        "LastChanged": "2011-02-24T02:49:51.9378192+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "praesentium",
        "StyleHint": "veritatis",
        "Hidden": true,
        "FullName": "Ms. Albert Katelyn Willms",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 379
          }
        }
      }
    ],
    "ExtraInfo": "ducimus",
    "StyleHint": "odit",
    "Hidden": true,
    "FullName": "Miss Alysha Price V",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 112
      }
    }
  }
]
```