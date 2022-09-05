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
PUT /api/v1/List/Credited/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 637,
    "Name": "Brown, Howe and Kozey",
    "ToolTip": "Quia aut.",
    "Deleted": true,
    "Rank": 930,
    "Type": "aut",
    "ColorBlock": 820,
    "IconHint": "eos",
    "Selected": true,
    "LastChanged": "2011-08-13T11:10:54.0392192+02:00",
    "ChildItems": [
      {
        "Id": 32,
        "Name": "Strosin Inc and Sons",
        "ToolTip": "Qui ab voluptates.",
        "Deleted": false,
        "Rank": 561,
        "Type": "sint",
        "ColorBlock": 453,
        "IconHint": "dolor",
        "Selected": false,
        "LastChanged": "2005-07-21T11:10:54.0392192+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quaerat",
        "StyleHint": "ut",
        "Hidden": false,
        "FullName": "Mrs. Brandi Haleigh Huel"
      }
    ],
    "ExtraInfo": "nihil",
    "StyleHint": "voluptas",
    "Hidden": true,
    "FullName": "Barry Tremblay"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 400,
    "Name": "Sipes-Reichert",
    "ToolTip": "Nihil odit sed eveniet fugiat iusto quisquam aut.",
    "Deleted": true,
    "Rank": 694,
    "Type": "debitis",
    "ColorBlock": 366,
    "IconHint": "asperiores",
    "Selected": false,
    "LastChanged": "2002-02-04T11:10:54.2238665+01:00",
    "ChildItems": [
      {
        "Id": 108,
        "Name": "Murphy LLC",
        "ToolTip": "Accusamus beatae delectus est distinctio.",
        "Deleted": false,
        "Rank": 48,
        "Type": "possimus",
        "ColorBlock": 597,
        "IconHint": "sint",
        "Selected": true,
        "LastChanged": "2004-02-05T11:10:54.2238665+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "corrupti",
        "StyleHint": "sed",
        "Hidden": false,
        "FullName": "Mrs. Frida Leffler",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 511
          }
        }
      }
    ],
    "ExtraInfo": "quis",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Prof. Jaunita Darlene Upton DDS",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 856
      }
    }
  }
]
```