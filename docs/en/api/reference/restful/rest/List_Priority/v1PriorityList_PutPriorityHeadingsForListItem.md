---
title: PUT List/Priority/Items/{id}/Headings
uid: v1PriorityList_PutPriorityHeadingsForListItem
---

# PUT List/Priority/Items/{id}/Headings

```http
PUT /api/v1/List/Priority/Items/{itemId}/Headings
```

Saves headings for the Priority list's item.


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
PUT /api/v1/List/Priority/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 614,
    "Name": "Dach Inc and Sons",
    "ToolTip": "Deleniti quidem voluptas sed voluptas doloribus exercitationem assumenda.",
    "Deleted": false,
    "Rank": 792,
    "Type": "soluta",
    "ColorBlock": 54,
    "IconHint": "aspernatur",
    "Selected": false,
    "LastChanged": "2010-08-17T14:19:11.3524087+02:00",
    "ChildItems": [
      {
        "Id": 184,
        "Name": "Hahn, McDermott and Lueilwitz",
        "ToolTip": "Atque laborum unde similique est autem architecto qui.",
        "Deleted": false,
        "Rank": 969,
        "Type": "est",
        "ColorBlock": 586,
        "IconHint": "neque",
        "Selected": true,
        "LastChanged": "2022-12-15T14:19:11.3524087+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vitae",
        "StyleHint": "aspernatur",
        "Hidden": false,
        "FullName": "Lilly Auer V"
      }
    ],
    "ExtraInfo": "quaerat",
    "StyleHint": "quas",
    "Hidden": false,
    "FullName": "Mrs. Alford Katelin Veum"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 611,
    "Name": "Stoltenberg, Kulas and Legros",
    "ToolTip": "Optio sed blanditiis sunt saepe quo consequuntur.",
    "Deleted": false,
    "Rank": 931,
    "Type": "et",
    "ColorBlock": 28,
    "IconHint": "est",
    "Selected": true,
    "LastChanged": "1996-05-07T14:19:11.3524087+02:00",
    "ChildItems": [
      {
        "Id": 94,
        "Name": "Wolf-Kohler",
        "ToolTip": "Quis sit facilis voluptatibus occaecati illo magni aut.",
        "Deleted": false,
        "Rank": 6,
        "Type": "repellendus",
        "ColorBlock": 868,
        "IconHint": "fugiat",
        "Selected": true,
        "LastChanged": "2021-11-12T14:19:11.3524087+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eveniet",
        "StyleHint": "quia",
        "Hidden": false,
        "FullName": "Kelvin Devin Beatty IV",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 911
          }
        }
      }
    ],
    "ExtraInfo": "iusto",
    "StyleHint": "dolorem",
    "Hidden": false,
    "FullName": "Miss Nat Berge",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 527
      }
    }
  }
]
```