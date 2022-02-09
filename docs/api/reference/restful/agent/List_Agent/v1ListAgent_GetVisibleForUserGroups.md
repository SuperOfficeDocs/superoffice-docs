---
title: POST Agents/List/GetVisibleForUserGroups
id: v1ListAgent_GetVisibleForUserGroups
---

# POST Agents/List/GetVisibleForUserGroups

```http
POST /api/v1/Agents/List/GetVisibleForUserGroups
```

List of User groups that this list item is visible for







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetVisibleForUserGroups?$select=name,department,category/id
```


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

## Request Body: request  

UdListDefinitionId, ListItemId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionId | int32 |  |
| ListItemId | int32 |  |


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
POST /api/v1/Agents/List/GetVisibleForUserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionId": 659,
  "ListItemId": 218
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 819,
    "Name": "King-Smith",
    "ToolTip": "Et voluptas accusamus totam consequatur maxime possimus.",
    "Deleted": false,
    "Rank": 506,
    "Type": "eos",
    "ColorBlock": 57,
    "IconHint": "et",
    "Selected": true,
    "LastChanged": "2008-05-15T18:28:49.3061179+02:00",
    "ChildItems": [
      {
        "Id": 200,
        "Name": "Weimann, Fahey and Herzog",
        "ToolTip": "Atque error voluptatem incidunt et et nemo.",
        "Deleted": false,
        "Rank": 938,
        "Type": "dolores",
        "ColorBlock": 514,
        "IconHint": "nostrum",
        "Selected": true,
        "LastChanged": "1998-11-01T18:28:49.3061179+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "omnis",
        "StyleHint": "iste",
        "Hidden": false,
        "FullName": "Jerrod Sanford",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 613
          }
        }
      }
    ],
    "ExtraInfo": "sed",
    "StyleHint": "laborum",
    "Hidden": false,
    "FullName": "Florence Haag",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "mesh ubiquitous methodologies"
        },
        "FieldType": "System.String",
        "FieldLength": 924
      }
    }
  }
]
```