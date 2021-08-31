---
title: PUT List/DeliveryTerm/Items/{id}/UserGroups
id: v1DeliveryTermsList_PutDeliveryTermUserGroupsForListItem
---

# PUT List/DeliveryTerm/Items/{id}/UserGroups

```http
PUT /api/v1/List/DeliveryTerm/Items/{itemId}/UserGroups
```

Saves user groups visible for the DeliveryTerm list's item.

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
PUT /api/v1/List/DeliveryTerm/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 332,
    "Name": "Kuhic-Haag",
    "ToolTip": "Nam nam.",
    "Deleted": false,
    "Rank": 162,
    "Type": "voluptates",
    "ColorBlock": 902,
    "IconHint": "voluptatem",
    "Selected": false,
    "LastChanged": "2001-10-30T15:05:43.41851+01:00",
    "ChildItems": [
      {
        "Id": 513,
        "Name": "Hauck, Weber and DuBuque",
        "ToolTip": "Aut iure excepturi.",
        "Deleted": false,
        "Rank": 271,
        "Type": "sapiente",
        "ColorBlock": 709,
        "IconHint": "veritatis",
        "Selected": true,
        "LastChanged": "2003-03-01T15:05:43.41851+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "unde",
        "StyleHint": "sed",
        "Hidden": false,
        "FullName": "Lela Franecki"
      }
    ],
    "ExtraInfo": "illo",
    "StyleHint": "repudiandae",
    "Hidden": true,
    "FullName": "Mr. Lyda Legros"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 199,
    "Name": "Collins-Hilll",
    "ToolTip": "Ad ex sint earum.",
    "Deleted": false,
    "Rank": 301,
    "Type": "quo",
    "ColorBlock": 75,
    "IconHint": "vel",
    "Selected": false,
    "LastChanged": "2011-05-30T15:05:43.4195101+02:00",
    "ChildItems": [
      {
        "Id": 363,
        "Name": "Fay, Koepp and Heidenreich",
        "ToolTip": "Maiores sit ipsa eos maiores saepe adipisci.",
        "Deleted": false,
        "Rank": 749,
        "Type": "consequuntur",
        "ColorBlock": 794,
        "IconHint": "modi",
        "Selected": true,
        "LastChanged": "1996-12-22T15:05:43.4195101+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolores",
        "StyleHint": "maiores",
        "Hidden": true,
        "FullName": "Domingo Berge",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 389
          }
        }
      }
    ],
    "ExtraInfo": "mollitia",
    "StyleHint": "minus",
    "Hidden": true,
    "FullName": "Gerald Aufderhar I",
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
        "FieldType": "System.String",
        "FieldLength": 478
      }
    }
  }
]
```