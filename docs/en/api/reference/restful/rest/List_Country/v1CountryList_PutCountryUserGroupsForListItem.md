---
title: PUT List/Country/Items/{id}/UserGroups
uid: v1CountryList_PutCountryUserGroupsForListItem
generated: true
---

# PUT List/Country/Items/{id}/UserGroups

```http
PUT /api/v1/List/Country/Items/{itemId}/UserGroups
```

Saves user groups visible for the Country list's item.


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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/Country/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 591,
    "Name": "Halvorson, Kuvalis and Glover",
    "ToolTip": "Quis sit.",
    "Deleted": false,
    "Rank": 974,
    "Type": "id",
    "ColorBlock": 370,
    "IconHint": "officia",
    "Selected": true,
    "LastChanged": "2021-03-01T13:28:32.7572536+01:00",
    "ChildItems": [
      {
        "Id": 737,
        "Name": "D'Amore-Gulgowski",
        "ToolTip": "Nesciunt dolor mollitia repellendus corrupti est voluptatem est.",
        "Deleted": true,
        "Rank": 977,
        "Type": "repellat",
        "ColorBlock": 366,
        "IconHint": "provident",
        "Selected": true,
        "LastChanged": "2003-04-13T13:28:32.7572536+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "illum",
        "StyleHint": "aliquam",
        "Hidden": true,
        "FullName": "Nora Sylvia Satterfield DVM"
      }
    ],
    "ExtraInfo": "laborum",
    "StyleHint": "ipsum",
    "Hidden": false,
    "FullName": "Prof. Lenore Vandervort PhD"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 974,
    "Name": "Jenkins Group",
    "ToolTip": "Et fuga nesciunt.",
    "Deleted": true,
    "Rank": 841,
    "Type": "suscipit",
    "ColorBlock": 3,
    "IconHint": "itaque",
    "Selected": true,
    "LastChanged": "2013-04-29T13:28:32.7728753+02:00",
    "ChildItems": [
      {
        "Id": 233,
        "Name": "Rippin-Bosco",
        "ToolTip": "Provident consequatur.",
        "Deleted": true,
        "Rank": 223,
        "Type": "veritatis",
        "ColorBlock": 652,
        "IconHint": "vitae",
        "Selected": false,
        "LastChanged": "2018-11-03T13:28:32.7728753+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "facilis",
        "StyleHint": "dolorem",
        "Hidden": false,
        "FullName": "Adolf Zieme Sr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 668
          }
        }
      }
    ],
    "ExtraInfo": "veniam",
    "StyleHint": "nisi",
    "Hidden": false,
    "FullName": "Ruben Leffler",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 252
      }
    }
  }
]
```