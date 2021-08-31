---
title: PUT List/PaymentTerm/Items/{id}/Headings
id: v1PaymentTermsList_PutPaymentTermHeadingsForListItem
---

# PUT List/PaymentTerm/Items/{id}/Headings

```http
PUT /api/v1/List/PaymentTerm/Items/{itemId}/Headings
```

Saves headings for the PaymentTerm list's item.

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
PUT /api/v1/List/PaymentTerm/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 399,
    "Name": "Hamill-Treutel",
    "ToolTip": "Et harum.",
    "Deleted": false,
    "Rank": 148,
    "Type": "voluptas",
    "ColorBlock": 733,
    "IconHint": "incidunt",
    "Selected": true,
    "LastChanged": "2007-04-25T15:05:43.5470794+02:00",
    "ChildItems": [
      {
        "Id": 256,
        "Name": "Fahey-Kohler",
        "ToolTip": "Fugit et deserunt commodi voluptas cumque quisquam.",
        "Deleted": false,
        "Rank": 521,
        "Type": "voluptatibus",
        "ColorBlock": 891,
        "IconHint": "quia",
        "Selected": true,
        "LastChanged": "2004-07-15T15:05:43.5470794+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "suscipit",
        "StyleHint": "deserunt",
        "Hidden": true,
        "FullName": "Maria Fahey"
      }
    ],
    "ExtraInfo": "est",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Cade O'Conner"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 593,
    "Name": "Glover, Treutel and Abernathy",
    "ToolTip": "Est laboriosam adipisci at illum.",
    "Deleted": false,
    "Rank": 486,
    "Type": "et",
    "ColorBlock": 210,
    "IconHint": "praesentium",
    "Selected": false,
    "LastChanged": "2018-04-04T15:05:43.5490794+02:00",
    "ChildItems": [
      {
        "Id": 62,
        "Name": "Stark-DuBuque",
        "ToolTip": "Provident alias excepturi.",
        "Deleted": true,
        "Rank": 583,
        "Type": "aut",
        "ColorBlock": 39,
        "IconHint": "quas",
        "Selected": true,
        "LastChanged": "2010-02-18T15:05:43.5490794+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "autem",
        "StyleHint": "quia",
        "Hidden": false,
        "FullName": "Sienna Schultz",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 553
          }
        }
      }
    ],
    "ExtraInfo": "minima",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Belle Welch",
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
        "FieldLength": 193
      }
    }
  }
]
```