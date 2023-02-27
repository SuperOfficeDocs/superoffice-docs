---
title: PUT List/Credited/Items/{id}/Headings
uid: v1CreditedList_PutCreditedHeadingsForListItem
---

# PUT List/Credited/Items/{id}/Headings

```http
PUT /api/v1/List/Credited/Items/{itemId}/Headings
```

Saves headings for the Credited list's item.


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
PUT /api/v1/List/Credited/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 897,
    "Name": "Lind Inc and Sons",
    "ToolTip": "A et labore maiores ut similique vel.",
    "Deleted": false,
    "Rank": 3,
    "Type": "atque",
    "ColorBlock": 419,
    "IconHint": "quis",
    "Selected": true,
    "LastChanged": "2021-04-23T14:19:11.2105958+02:00",
    "ChildItems": [
      {
        "Id": 15,
        "Name": "Cassin, Wilderman and Pfeffer",
        "ToolTip": "Dicta autem facere quia explicabo ut quo.",
        "Deleted": false,
        "Rank": 642,
        "Type": "asperiores",
        "ColorBlock": 804,
        "IconHint": "voluptates",
        "Selected": true,
        "LastChanged": "2011-01-14T14:19:11.2105958+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "error",
        "StyleHint": "saepe",
        "Hidden": false,
        "FullName": "Dewayne Conn"
      }
    ],
    "ExtraInfo": "veniam",
    "StyleHint": "expedita",
    "Hidden": false,
    "FullName": "Dallin Towne"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 685,
    "Name": "Monahan Group",
    "ToolTip": "Architecto aut nemo exercitationem dolorem dicta.",
    "Deleted": false,
    "Rank": 626,
    "Type": "nobis",
    "ColorBlock": 639,
    "IconHint": "laborum",
    "Selected": false,
    "LastChanged": "2012-12-28T14:19:11.2105958+01:00",
    "ChildItems": [
      {
        "Id": 991,
        "Name": "Mann, Ryan and Spencer",
        "ToolTip": "Sit aspernatur qui libero perspiciatis soluta.",
        "Deleted": false,
        "Rank": 230,
        "Type": "porro",
        "ColorBlock": 969,
        "IconHint": "molestiae",
        "Selected": false,
        "LastChanged": "2005-08-21T14:19:11.2105958+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ipsam",
        "StyleHint": "est",
        "Hidden": false,
        "FullName": "Adrien Pollich II",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 547
          }
        }
      }
    ],
    "ExtraInfo": "placeat",
    "StyleHint": "autem",
    "Hidden": false,
    "FullName": "Mr. Mose Gwen Davis",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 197
      }
    }
  }
]
```