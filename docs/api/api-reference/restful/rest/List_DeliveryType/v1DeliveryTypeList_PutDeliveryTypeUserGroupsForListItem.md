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
    "Id": 619,
    "Name": "Reichert, Kris and Beier",
    "ToolTip": "Asperiores nihil dolores.",
    "Deleted": false,
    "Rank": 267,
    "Type": "deleniti",
    "ColorBlock": 18,
    "IconHint": "quis",
    "Selected": true,
    "LastChanged": "2011-11-03T09:41:00.3623895+01:00",
    "ChildItems": [
      {
        "Id": 69,
        "Name": "Stark-Jones",
        "ToolTip": "Autem quibusdam molestiae.",
        "Deleted": true,
        "Rank": 159,
        "Type": "ipsum",
        "ColorBlock": 559,
        "IconHint": "dolorum",
        "Selected": false,
        "LastChanged": "2016-06-14T09:41:00.3623895+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "repellendus",
        "StyleHint": "et",
        "Hidden": false,
        "FullName": "Kurtis Brown Sr."
      }
    ],
    "ExtraInfo": "suscipit",
    "StyleHint": "iure",
    "Hidden": false,
    "FullName": "Mario King"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 610,
    "Name": "Hickle, Stokes and Reinger",
    "ToolTip": "Nisi neque.",
    "Deleted": true,
    "Rank": 89,
    "Type": "non",
    "ColorBlock": 941,
    "IconHint": "repudiandae",
    "Selected": true,
    "LastChanged": "2014-04-16T09:41:00.364382+02:00",
    "ChildItems": [
      {
        "Id": 483,
        "Name": "Shanahan, Boyer and Breitenberg",
        "ToolTip": "Error odit adipisci et.",
        "Deleted": true,
        "Rank": 734,
        "Type": "nam",
        "ColorBlock": 16,
        "IconHint": "nisi",
        "Selected": false,
        "LastChanged": "2004-10-15T09:41:00.3653838+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "est",
        "StyleHint": "rerum",
        "Hidden": true,
        "FullName": "Triston Gusikowski",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 143
          }
        }
      }
    ],
    "ExtraInfo": "veniam",
    "StyleHint": "ipsum",
    "Hidden": false,
    "FullName": "Miss Jimmie Kutch",
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
        "FieldLength": 433
      }
    }
  }
]
```