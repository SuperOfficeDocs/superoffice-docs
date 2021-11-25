---
title: PUT List/ConsentSource/Items/{id}/Headings
id: v1ConsentSourceList_PutConsentSourceHeadingsForListItem
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
PUT /api/v1/List/ConsentSource/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 809,
    "Name": "Cartwright-Hammes",
    "ToolTip": "Repudiandae ducimus numquam ad similique ut.",
    "Deleted": true,
    "Rank": 487,
    "Type": "quibusdam",
    "ColorBlock": 888,
    "IconHint": "asperiores",
    "Selected": false,
    "LastChanged": "2009-12-05T18:25:51.7383205+01:00",
    "ChildItems": [
      {
        "Id": 739,
        "Name": "Bayer LLC",
        "ToolTip": "Nemo neque.",
        "Deleted": false,
        "Rank": 750,
        "Type": "ut",
        "ColorBlock": 392,
        "IconHint": "dignissimos",
        "Selected": true,
        "LastChanged": "2019-07-31T18:25:51.7383205+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ratione",
        "StyleHint": "corrupti",
        "Hidden": false,
        "FullName": "Miss Ivory Abernathy"
      }
    ],
    "ExtraInfo": "voluptate",
    "StyleHint": "doloribus",
    "Hidden": false,
    "FullName": "Earline Legros"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 318,
    "Name": "Heaney, Baumbach and Pfannerstill",
    "ToolTip": "Qui sit.",
    "Deleted": true,
    "Rank": 619,
    "Type": "vitae",
    "ColorBlock": 433,
    "IconHint": "aliquam",
    "Selected": false,
    "LastChanged": "2007-05-28T18:25:51.740325+02:00",
    "ChildItems": [
      {
        "Id": 232,
        "Name": "Bauch Group",
        "ToolTip": "Nobis omnis incidunt molestiae placeat.",
        "Deleted": true,
        "Rank": 529,
        "Type": "deleniti",
        "ColorBlock": 431,
        "IconHint": "cum",
        "Selected": false,
        "LastChanged": "2017-01-03T18:25:51.740325+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptas",
        "StyleHint": "consectetur",
        "Hidden": true,
        "FullName": "Mrs. Kayli Bruen",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 29
          }
        }
      }
    ],
    "ExtraInfo": "illo",
    "StyleHint": "magni",
    "Hidden": true,
    "FullName": "Otto Grimes",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 657
      }
    }
  }
]
```