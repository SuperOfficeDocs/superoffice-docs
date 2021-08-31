---
title: PUT List/Country/Items/{id}/Headings
id: v1CountryList_PutCountryHeadingsForListItem
---

# PUT List/Country/Items/{id}/Headings

```http
PUT /api/v1/List/Country/Items/{itemId}/Headings
```

Saves headings for the Country list's item.

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

## Sample Request

```http!
PUT /api/v1/List/Country/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 538,
    "Name": "Denesik Inc and Sons",
    "ToolTip": "Sit consequatur perspiciatis.",
    "Deleted": false,
    "Rank": 774,
    "Type": "incidunt",
    "ColorBlock": 339,
    "IconHint": "repudiandae",
    "Selected": true,
    "LastChanged": "2018-06-25T15:05:43.3765102+02:00",
    "ChildItems": [
      {
        "Id": 811,
        "Name": "Dibbert, Moore and Dooley",
        "ToolTip": "Dolor maxime exercitationem quam ab odit suscipit.",
        "Deleted": false,
        "Rank": 494,
        "Type": "voluptate",
        "ColorBlock": 906,
        "IconHint": "ratione",
        "Selected": false,
        "LastChanged": "2017-09-01T15:05:43.3765102+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sit",
        "StyleHint": "iste",
        "Hidden": true,
        "FullName": "Destiney Gorczany"
      }
    ],
    "ExtraInfo": "velit",
    "StyleHint": "ratione",
    "Hidden": true,
    "FullName": "Sigurd King"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 256,
    "Name": "Kemmer-Stamm",
    "ToolTip": "Autem facilis aut et.",
    "Deleted": false,
    "Rank": 672,
    "Type": "eaque",
    "ColorBlock": 185,
    "IconHint": "qui",
    "Selected": false,
    "LastChanged": "1998-07-21T15:05:43.3775101+02:00",
    "ChildItems": [
      {
        "Id": 993,
        "Name": "Goodwin, McLaughlin and Hackett",
        "ToolTip": "Unde ut ea.",
        "Deleted": false,
        "Rank": 801,
        "Type": "minima",
        "ColorBlock": 377,
        "IconHint": "mollitia",
        "Selected": false,
        "LastChanged": "2018-01-19T15:05:43.3785099+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "laboriosam",
        "StyleHint": "ipsum",
        "Hidden": true,
        "FullName": "Fermin Stracke",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 108
          }
        }
      }
    ],
    "ExtraInfo": "quam",
    "StyleHint": "commodi",
    "Hidden": false,
    "FullName": "Trudie Ondricka",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "empower 24/7 niches"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 721
      }
    }
  }
]
```