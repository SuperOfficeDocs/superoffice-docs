---
title: PUT List/Credited/Items/{id}/UserGroups
uid: v1CreditedList_PutCreditedUserGroupsForListItem
---

# PUT List/Credited/Items/{id}/UserGroups

```http
PUT /api/v1/List/Credited/Items/{itemId}/UserGroups
```

Saves user groups visible for the Credited list's item.


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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/Credited/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 689,
    "Name": "Rippin LLC",
    "ToolTip": "Assumenda omnis ea sequi.",
    "Deleted": false,
    "Rank": 98,
    "Type": "non",
    "ColorBlock": 568,
    "IconHint": "earum",
    "Selected": true,
    "LastChanged": "2016-11-09T14:19:11.2105958+01:00",
    "ChildItems": [
      {
        "Id": 83,
        "Name": "Sawayn-Cummings",
        "ToolTip": "Omnis debitis eveniet nulla.",
        "Deleted": true,
        "Rank": 733,
        "Type": "reiciendis",
        "ColorBlock": 906,
        "IconHint": "perferendis",
        "Selected": false,
        "LastChanged": "2002-07-07T14:19:11.2105958+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "explicabo",
        "StyleHint": "nostrum",
        "Hidden": true,
        "FullName": "Paolo Abbott PhD"
      }
    ],
    "ExtraInfo": "eaque",
    "StyleHint": "pariatur",
    "Hidden": true,
    "FullName": "Hollie Franecki"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 781,
    "Name": "Tremblay Group",
    "ToolTip": "Similique enim blanditiis eum autem.",
    "Deleted": false,
    "Rank": 336,
    "Type": "labore",
    "ColorBlock": 279,
    "IconHint": "nisi",
    "Selected": false,
    "LastChanged": "1996-04-10T14:19:11.2105958+02:00",
    "ChildItems": [
      {
        "Id": 194,
        "Name": "Denesik, Daugherty and Rodriguez",
        "ToolTip": "Quas quasi optio omnis quod voluptatem.",
        "Deleted": false,
        "Rank": 344,
        "Type": "dolorum",
        "ColorBlock": 778,
        "IconHint": "nostrum",
        "Selected": false,
        "LastChanged": "2015-04-21T14:19:11.2105958+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dignissimos",
        "StyleHint": "iusto",
        "Hidden": true,
        "FullName": "Brandt Raynor PhD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 390
          }
        }
      }
    ],
    "ExtraInfo": "velit",
    "StyleHint": "corrupti",
    "Hidden": false,
    "FullName": "Ryley Huel",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 412
      }
    }
  }
]
```