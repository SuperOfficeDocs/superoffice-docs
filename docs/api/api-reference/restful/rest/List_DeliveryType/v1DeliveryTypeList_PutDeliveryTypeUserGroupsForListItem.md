---
title: PUT List/DeliveryType/Items/{id}/UserGroups
id: v1DeliveryTypeList_PutDeliveryTypeUserGroupsForListItem
---

# PUT List/DeliveryType/Items/{id}/UserGroups

```http
PUT /api/v1/List/DeliveryType/Items/{itemId}/UserGroups
```

Saves user groups visible for the DeliveryType list's item.

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
PUT /api/v1/List/DeliveryType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 393,
    "Name": "Gulgowski-Stiedemann",
    "ToolTip": "Rem nemo culpa at exercitationem.",
    "Deleted": false,
    "Rank": 846,
    "Type": "placeat",
    "ColorBlock": 561,
    "IconHint": "ipsam",
    "Selected": false,
    "LastChanged": "2010-09-08T18:25:51.8153291+02:00",
    "ChildItems": [
      {
        "Id": 908,
        "Name": "Heaney-Denesik",
        "ToolTip": "Voluptate nulla soluta deserunt ab pariatur sapiente.",
        "Deleted": false,
        "Rank": 697,
        "Type": "et",
        "ColorBlock": 420,
        "IconHint": "esse",
        "Selected": false,
        "LastChanged": "2008-10-17T18:25:51.8153291+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quia",
        "StyleHint": "maxime",
        "Hidden": true,
        "FullName": "Luis Jenkins"
      }
    ],
    "ExtraInfo": "nesciunt",
    "StyleHint": "occaecati",
    "Hidden": true,
    "FullName": "Della Beahan"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 871,
    "Name": "Weissnat, Zboncak and Armstrong",
    "ToolTip": "Recusandae laborum et deserunt temporibus repellendus doloremque.",
    "Deleted": false,
    "Rank": 888,
    "Type": "nihil",
    "ColorBlock": 657,
    "IconHint": "delectus",
    "Selected": true,
    "LastChanged": "2005-05-01T18:25:51.8173256+02:00",
    "ChildItems": [
      {
        "Id": 927,
        "Name": "Strosin-Glover",
        "ToolTip": "Officia aspernatur.",
        "Deleted": true,
        "Rank": 640,
        "Type": "incidunt",
        "ColorBlock": 517,
        "IconHint": "ea",
        "Selected": true,
        "LastChanged": "2006-02-21T18:25:51.8173256+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sint",
        "StyleHint": "officia",
        "Hidden": false,
        "FullName": "Alaina Dooley",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 790
          }
        }
      }
    ],
    "ExtraInfo": "consequatur",
    "StyleHint": "vitae",
    "Hidden": false,
    "FullName": "Rylan Kautzer",
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
        "FieldLength": 72
      }
    }
  }
]
```