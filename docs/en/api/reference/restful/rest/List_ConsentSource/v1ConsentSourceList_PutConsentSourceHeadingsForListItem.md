---
title: PUT List/ConsentSource/Items/{id}/Headings
uid: v1ConsentSourceList_PutConsentSourceHeadingsForListItem
---

# PUT List/ConsentSource/Items/{id}/Headings

```http
PUT /api/v1/List/ConsentSource/Items/{itemId}/Headings
```

Saves headings for the ConsentSource list's item.


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
PUT /api/v1/List/ConsentSource/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 660,
    "Name": "Carroll Group",
    "ToolTip": "Officia ut aut.",
    "Deleted": false,
    "Rank": 692,
    "Type": "iure",
    "ColorBlock": 214,
    "IconHint": "cupiditate",
    "Selected": true,
    "LastChanged": "1999-07-15T17:37:39.9164721+02:00",
    "ChildItems": [
      {
        "Id": 917,
        "Name": "Hyatt, Lesch and Carter",
        "ToolTip": "Perferendis asperiores voluptatibus asperiores ut et labore.",
        "Deleted": false,
        "Rank": 817,
        "Type": "iure",
        "ColorBlock": 22,
        "IconHint": "quisquam",
        "Selected": false,
        "LastChanged": "2022-12-24T17:37:39.9164721+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "ut",
        "Hidden": false,
        "FullName": "Prof. Evans Keebler"
      }
    ],
    "ExtraInfo": "quo",
    "StyleHint": "nobis",
    "Hidden": false,
    "FullName": "Demetris Brooks Cole I"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 553,
    "Name": "Schamberger Group",
    "ToolTip": "Explicabo eius qui ipsam suscipit aliquam et.",
    "Deleted": false,
    "Rank": 156,
    "Type": "in",
    "ColorBlock": 922,
    "IconHint": "ut",
    "Selected": false,
    "LastChanged": "1996-04-16T17:37:39.9174714+02:00",
    "ChildItems": [
      {
        "Id": 974,
        "Name": "Oberbrunner, Kris and Howe",
        "ToolTip": "Voluptate et.",
        "Deleted": false,
        "Rank": 287,
        "Type": "ea",
        "ColorBlock": 847,
        "IconHint": "dolores",
        "Selected": true,
        "LastChanged": "2009-11-27T17:37:39.9185065+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "mollitia",
        "StyleHint": "dignissimos",
        "Hidden": false,
        "FullName": "Adele Balistreri Jr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 333
          }
        }
      }
    ],
    "ExtraInfo": "laborum",
    "StyleHint": "dolores",
    "Hidden": true,
    "FullName": "Edwin Dicki",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 46
      }
    }
  }
]
```