---
title: PUT List/DeliveryType/Items/{id}/UserGroups
uid: v1DeliveryTypeList_PutDeliveryTypeUserGroupsForListItem
generated: true
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
PUT /api/v1/List/DeliveryType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 932,
    "Name": "Keebler, Marvin and Crist",
    "ToolTip": "Sint labore ea harum.",
    "Deleted": false,
    "Rank": 417,
    "Type": "harum",
    "ColorBlock": 463,
    "IconHint": "sed",
    "Selected": true,
    "LastChanged": "2014-10-07T16:55:30.6679001+02:00",
    "ChildItems": [
      {
        "Id": 481,
        "Name": "Balistreri-Hammes",
        "ToolTip": "Sit amet quam voluptates quia facilis.",
        "Deleted": true,
        "Rank": 860,
        "Type": "tempore",
        "ColorBlock": 408,
        "IconHint": "officiis",
        "Selected": false,
        "LastChanged": "2003-06-29T16:55:30.6679001+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sed",
        "StyleHint": "doloribus",
        "Hidden": false,
        "FullName": "Wilber Ryan PhD"
      }
    ],
    "ExtraInfo": "sed",
    "StyleHint": "rerum",
    "Hidden": false,
    "FullName": "Candelario Oberbrunner"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 23,
    "Name": "Braun, Jaskolski and Weissnat",
    "ToolTip": "Ut recusandae et similique.",
    "Deleted": false,
    "Rank": 986,
    "Type": "cumque",
    "ColorBlock": 133,
    "IconHint": "autem",
    "Selected": true,
    "LastChanged": "2018-01-16T16:55:30.6699851+01:00",
    "ChildItems": [
      {
        "Id": 372,
        "Name": "Ledner Inc and Sons",
        "ToolTip": "Velit nisi.",
        "Deleted": false,
        "Rank": 775,
        "Type": "repellendus",
        "ColorBlock": 605,
        "IconHint": "quaerat",
        "Selected": false,
        "LastChanged": "2017-10-21T16:55:30.6699851+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "corrupti",
        "StyleHint": "distinctio",
        "Hidden": false,
        "FullName": "Yasmeen Kemmer",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 620
          }
        }
      }
    ],
    "ExtraInfo": "nihil",
    "StyleHint": "nulla",
    "Hidden": false,
    "FullName": "Robyn Emard",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 573
      }
    }
  }
]
```