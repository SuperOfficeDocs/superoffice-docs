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
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 217,
    "Name": "Gislason-Hilll",
    "ToolTip": "Nisi doloremque doloribus sunt in sed.",
    "Deleted": true,
    "Rank": 873,
    "Type": "distinctio",
    "ColorBlock": 355,
    "IconHint": "dolor",
    "Selected": false,
    "LastChanged": "2018-09-03T12:15:28.0616221+02:00",
    "ChildItems": [
      {
        "Id": 688,
        "Name": "Greenfelder, Koch and Kulas",
        "ToolTip": "Quo qui quis.",
        "Deleted": false,
        "Rank": 915,
        "Type": "quasi",
        "ColorBlock": 832,
        "IconHint": "suscipit",
        "Selected": false,
        "LastChanged": "2011-12-20T12:15:28.0616221+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eligendi",
        "StyleHint": "ea",
        "Hidden": true,
        "FullName": "Lenore Wilderman III"
      }
    ],
    "ExtraInfo": "cumque",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Anne Kreiger"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 203,
    "Name": "Blick-Stroman",
    "ToolTip": "Voluptas non excepturi.",
    "Deleted": false,
    "Rank": 105,
    "Type": "vero",
    "ColorBlock": 233,
    "IconHint": "quia",
    "Selected": true,
    "LastChanged": "2018-08-28T12:15:28.0646199+02:00",
    "ChildItems": [
      {
        "Id": 90,
        "Name": "Howe, Lueilwitz and Witting",
        "ToolTip": "Aut molestias reprehenderit maiores aut reiciendis sequi quis.",
        "Deleted": false,
        "Rank": 474,
        "Type": "molestias",
        "ColorBlock": 196,
        "IconHint": "sequi",
        "Selected": false,
        "LastChanged": "2012-05-14T12:15:28.0676195+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "accusamus",
        "StyleHint": "et",
        "Hidden": true,
        "FullName": "Prof. Willis Selmer King Jr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 20
          }
        }
      }
    ],
    "ExtraInfo": "mollitia",
    "StyleHint": "possimus",
    "Hidden": false,
    "FullName": "Sidney Streich",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 638
      }
    }
  }
]
```