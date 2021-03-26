---
title: PUT List/PaymentTerm/Items/{id}/UserGroups
id: v1PaymentTermsList_PutPaymentTermUserGroupsForListItem
---

# PUT List/PaymentTerm/Items/{id}/UserGroups

```http
PUT /api/v1/List/PaymentTerm/Items/{itemId}/UserGroups
```

Saves user groups visible for the PaymentTerm list's item.

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
PUT /api/v1/List/PaymentTerm/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 980,
    "Name": "Mante-Kuphal",
    "ToolTip": "Et vel.",
    "Deleted": true,
    "Rank": 41,
    "Type": "et",
    "ColorBlock": 920,
    "IconHint": "dolorem",
    "Selected": true,
    "LastChanged": "1999-09-07T09:41:00.4773825+02:00",
    "ChildItems": [
      {
        "Id": 175,
        "Name": "Corkery LLC",
        "ToolTip": "Quia esse esse quae aut et.",
        "Deleted": false,
        "Rank": 608,
        "Type": "asperiores",
        "ColorBlock": 713,
        "IconHint": "eius",
        "Selected": false,
        "LastChanged": "2020-01-13T09:41:00.4773825+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vitae",
        "StyleHint": "quos",
        "Hidden": false,
        "FullName": "Rey Spencer Jr."
      }
    ],
    "ExtraInfo": "repellendus",
    "StyleHint": "veritatis",
    "Hidden": true,
    "FullName": "Jayme Schroeder"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 79,
    "Name": "Glover Inc and Sons",
    "ToolTip": "Corporis accusantium aut ut laudantium.",
    "Deleted": true,
    "Rank": 710,
    "Type": "qui",
    "ColorBlock": 69,
    "IconHint": "incidunt",
    "Selected": true,
    "LastChanged": "1997-08-25T09:41:00.4803815+02:00",
    "ChildItems": [
      {
        "Id": 400,
        "Name": "Glover-Conn",
        "ToolTip": "Quod voluptatum cum repudiandae et.",
        "Deleted": true,
        "Rank": 586,
        "Type": "beatae",
        "ColorBlock": 990,
        "IconHint": "vel",
        "Selected": false,
        "LastChanged": "2019-01-21T09:41:00.4803815+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "inventore",
        "StyleHint": "et",
        "Hidden": true,
        "FullName": "Rodolfo King",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 6
          }
        }
      }
    ],
    "ExtraInfo": "libero",
    "StyleHint": "totam",
    "Hidden": true,
    "FullName": "Tamara Paucek",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "whiteboard next-generation metrics"
        },
        "FieldType": "System.String",
        "FieldLength": 631
      }
    }
  }
]
```