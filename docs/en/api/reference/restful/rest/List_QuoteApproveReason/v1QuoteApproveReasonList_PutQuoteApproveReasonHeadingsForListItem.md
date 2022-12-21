---
title: PUT List/QuoteApproveReason/Items/{id}/Headings
uid: v1QuoteApproveReasonList_PutQuoteApproveReasonHeadingsForListItem
---

# PUT List/QuoteApproveReason/Items/{id}/Headings

```http
PUT /api/v1/List/QuoteApproveReason/Items/{itemId}/Headings
```

Saves headings for the QuoteApproveReason list's item.


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

OK

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

## Sample request

```http!
PUT /api/v1/List/QuoteApproveReason/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 865,
    "Name": "Streich-Dietrich",
    "ToolTip": "Cupiditate quis id iusto magnam nemo rerum.",
    "Deleted": false,
    "Rank": 133,
    "Type": "perferendis",
    "ColorBlock": 464,
    "IconHint": "et",
    "Selected": true,
    "LastChanged": "2016-05-20T02:49:52.422202+02:00",
    "ChildItems": [
      {
        "Id": 931,
        "Name": "Ebert Group",
        "ToolTip": "Mollitia magni corrupti commodi corrupti.",
        "Deleted": false,
        "Rank": 627,
        "Type": "sit",
        "ColorBlock": 662,
        "IconHint": "earum",
        "Selected": false,
        "LastChanged": "2011-11-21T02:49:52.422202+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "asperiores",
        "StyleHint": "quo",
        "Hidden": false,
        "FullName": "Dr. Mollie Briana Thompson"
      }
    ],
    "ExtraInfo": "quo",
    "StyleHint": "sunt",
    "Hidden": false,
    "FullName": "Simone Medhurst"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 933,
    "Name": "Schinner-Yost",
    "ToolTip": "Aliquam iste ab laboriosam vel quia quod dignissimos.",
    "Deleted": false,
    "Rank": 255,
    "Type": "facere",
    "ColorBlock": 679,
    "IconHint": "expedita",
    "Selected": false,
    "LastChanged": "2010-11-27T02:49:52.422202+01:00",
    "ChildItems": [
      {
        "Id": 1001,
        "Name": "Legros-Gleichner",
        "ToolTip": "Nulla odio ut vero.",
        "Deleted": true,
        "Rank": 106,
        "Type": "consectetur",
        "ColorBlock": 307,
        "IconHint": "id",
        "Selected": false,
        "LastChanged": "2013-05-14T02:49:52.422202+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aut",
        "StyleHint": "laborum",
        "Hidden": false,
        "FullName": "Mr. Darius Winnifred Koss",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 434
          }
        }
      }
    ],
    "ExtraInfo": "maxime",
    "StyleHint": "nisi",
    "Hidden": false,
    "FullName": "Drake Orn",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 105
      }
    }
  }
]
```