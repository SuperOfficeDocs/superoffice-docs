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
    "Id": 417,
    "Name": "Mayer, Upton and Kuvalis",
    "ToolTip": "Ipsa temporibus dignissimos.",
    "Deleted": false,
    "Rank": 432,
    "Type": "impedit",
    "ColorBlock": 157,
    "IconHint": "suscipit",
    "Selected": false,
    "LastChanged": "2010-05-04T17:37:40.1325068+02:00",
    "ChildItems": [
      {
        "Id": 908,
        "Name": "Howell, Dietrich and Price",
        "ToolTip": "Sunt dolor reiciendis amet qui enim natus sint.",
        "Deleted": false,
        "Rank": 436,
        "Type": "occaecati",
        "ColorBlock": 189,
        "IconHint": "alias",
        "Selected": false,
        "LastChanged": "2006-04-14T17:37:40.1325068+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sint",
        "StyleHint": "et",
        "Hidden": true,
        "FullName": "Miss Gillian Reynolds"
      }
    ],
    "ExtraInfo": "odio",
    "StyleHint": "asperiores",
    "Hidden": true,
    "FullName": "Kiana Wiza"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 450,
    "Name": "Gerlach LLC",
    "ToolTip": "Ipsum quia nam quo quo fugit.",
    "Deleted": true,
    "Rank": 331,
    "Type": "quaerat",
    "ColorBlock": 452,
    "IconHint": "debitis",
    "Selected": false,
    "LastChanged": "2015-01-09T17:37:40.1345001+01:00",
    "ChildItems": [
      {
        "Id": 845,
        "Name": "Kerluke-Gutmann",
        "ToolTip": "Nihil ea magnam esse sunt pariatur ipsa voluptatem.",
        "Deleted": false,
        "Rank": 543,
        "Type": "eaque",
        "ColorBlock": 129,
        "IconHint": "mollitia",
        "Selected": true,
        "LastChanged": "1997-09-11T17:37:40.1345001+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "assumenda",
        "StyleHint": "dolorem",
        "Hidden": false,
        "FullName": "Casimir Matilda Feeney Jr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 929
          }
        }
      }
    ],
    "ExtraInfo": "totam",
    "StyleHint": "consectetur",
    "Hidden": true,
    "FullName": "Ms. Lane Hobart Hagenes DDS",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 896
      }
    }
  }
]
```