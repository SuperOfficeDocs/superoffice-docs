---
title: PUT List/MrMrs/Items/{id}/Headings
id: v1MrMrsList_PutMrMrsHeadingsForListItem
---

# PUT List/MrMrs/Items/{id}/Headings

```http
PUT /api/v1/List/MrMrs/Items/{itemId}/Headings
```

Saves headings for the MrMrs list's item.

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
PUT /api/v1/List/MrMrs/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 57,
    "Name": "Reichel, Wolff and Huel",
    "ToolTip": "Est est beatae ab.",
    "Deleted": false,
    "Rank": 504,
    "Type": "optio",
    "ColorBlock": 900,
    "IconHint": "aliquam",
    "Selected": false,
    "LastChanged": "1994-07-21T09:41:00.4663817+02:00",
    "ChildItems": [
      {
        "Id": 780,
        "Name": "Pacocha-Weber",
        "ToolTip": "Sint omnis recusandae cum.",
        "Deleted": true,
        "Rank": 114,
        "Type": "sunt",
        "ColorBlock": 553,
        "IconHint": "quia",
        "Selected": true,
        "LastChanged": "1995-10-19T09:41:00.4663817+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "omnis",
        "StyleHint": "quidem",
        "Hidden": false,
        "FullName": "Eleonore Dach"
      }
    ],
    "ExtraInfo": "nobis",
    "StyleHint": "sunt",
    "Hidden": false,
    "FullName": "Mrs. Ismael Beahan"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 855,
    "Name": "Strosin Group",
    "ToolTip": "Voluptatum dolores illo tempore expedita dolor.",
    "Deleted": false,
    "Rank": 467,
    "Type": "esse",
    "ColorBlock": 292,
    "IconHint": "eos",
    "Selected": false,
    "LastChanged": "2014-09-24T09:41:00.4683814+02:00",
    "ChildItems": [
      {
        "Id": 440,
        "Name": "Konopelski, Pagac and Murphy",
        "ToolTip": "Veniam accusamus saepe voluptatem.",
        "Deleted": false,
        "Rank": 447,
        "Type": "aut",
        "ColorBlock": 352,
        "IconHint": "officiis",
        "Selected": false,
        "LastChanged": "1994-02-23T09:41:00.4683814+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nesciunt",
        "StyleHint": "tempore",
        "Hidden": true,
        "FullName": "Dr. Uriel Zieme",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 111
          }
        }
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "dolorem",
    "Hidden": false,
    "FullName": "Brooks Hane I",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "reintermediate robust e-services"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 365
      }
    }
  }
]
```