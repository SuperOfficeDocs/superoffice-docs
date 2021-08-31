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
    "Id": 96,
    "Name": "Auer Inc and Sons",
    "ToolTip": "Aliquid et cum.",
    "Deleted": true,
    "Rank": 401,
    "Type": "cupiditate",
    "ColorBlock": 105,
    "IconHint": "maiores",
    "Selected": false,
    "LastChanged": "2012-01-04T15:05:43.5300798+01:00",
    "ChildItems": [
      {
        "Id": 610,
        "Name": "Dickens, D'Amore and Thompson",
        "ToolTip": "Ipsa quam.",
        "Deleted": true,
        "Rank": 917,
        "Type": "consequatur",
        "ColorBlock": 170,
        "IconHint": "laborum",
        "Selected": true,
        "LastChanged": "1998-03-29T15:05:43.5300798+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nobis",
        "StyleHint": "architecto",
        "Hidden": false,
        "FullName": "Trevor Mann"
      }
    ],
    "ExtraInfo": "quibusdam",
    "StyleHint": "possimus",
    "Hidden": false,
    "FullName": "Marco Ondricka"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 19,
    "Name": "Medhurst, Schoen and Ferry",
    "ToolTip": "Magni cumque eum repellat.",
    "Deleted": true,
    "Rank": 469,
    "Type": "velit",
    "ColorBlock": 905,
    "IconHint": "hic",
    "Selected": true,
    "LastChanged": "2019-07-24T15:05:43.5310795+02:00",
    "ChildItems": [
      {
        "Id": 728,
        "Name": "Kutch-Halvorson",
        "ToolTip": "Rem maxime suscipit voluptatibus et quas.",
        "Deleted": false,
        "Rank": 48,
        "Type": "culpa",
        "ColorBlock": 33,
        "IconHint": "delectus",
        "Selected": true,
        "LastChanged": "2010-02-07T15:05:43.5320793+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "sed",
        "Hidden": false,
        "FullName": "Nichole Runolfsdottir",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 18
          }
        }
      }
    ],
    "ExtraInfo": "odit",
    "StyleHint": "ullam",
    "Hidden": false,
    "FullName": "Rubye Hartmann",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "enable proactive e-services"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 70
      }
    }
  }
]
```