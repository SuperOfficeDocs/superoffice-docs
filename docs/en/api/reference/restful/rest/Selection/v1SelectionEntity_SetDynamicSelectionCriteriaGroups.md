---
title: PUT Selection/{id}/CriteriaGroups
uid: v1SelectionEntity_SetDynamicSelectionCriteriaGroups
---

# PUT Selection/{id}/CriteriaGroups

```http
PUT /api/v1/Selection/{selectionId}/CriteriaGroups
```

Update the criteria for this dynamic selection.


Replaces existing criteria with the new values. This call supports multiple criteria groups.





| Path Part | Type | Description |
|-----------|------|-------------|
| selectionId | int32 | The id of the selection to add members **Required** |



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

## Request Body: criteria  

Criteria groups defining the selection result. Empty array is legal, simply means no criteria have been set 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string |  |
| Description | string |  |
| Rank | int32 |  |
| Restrictions | array |  |


## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string |  |
| Description | string |  |
| Rank | int32 |  |
| Restrictions | array |  |

## Sample request

```http!
PUT /api/v1/Selection/{selectionId}/CriteriaGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Russel, Mann and Farrell",
    "Description": "Cloned encompassing forecast",
    "Rank": 290,
    "Restrictions": [
      {
        "Name": "Gleason-Hills",
        "Operator": "at",
        "Values": [
          "dolor",
          "possimus"
        ],
        "DisplayValues": [
          "magnam",
          "odio"
        ],
        "ColumnInfo": null,
        "IsActive": true,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 723,
        "InterOperator": "And",
        "UniqueHash": 869
      }
    ]
  },
  {
    "Name": "Russel, Mann and Farrell",
    "Description": "Cloned encompassing forecast",
    "Rank": 290,
    "Restrictions": [
      {
        "Name": "Gleason-Hills",
        "Operator": "at",
        "Values": [
          "dolor",
          "possimus"
        ],
        "DisplayValues": [
          "magnam",
          "odio"
        ],
        "ColumnInfo": null,
        "IsActive": true,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 723,
        "InterOperator": "And",
        "UniqueHash": 869
      }
    ]
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Corwin, Goodwin and Wisozk",
    "Description": "Stand-alone transitional throughput",
    "Rank": 543,
    "Restrictions": [
      {
        "Name": "Pacocha, Jenkins and Harvey",
        "Operator": "vitae",
        "Values": [
          "sint",
          "qui"
        ],
        "DisplayValues": [
          "voluptatem",
          "qui"
        ],
        "ColumnInfo": null,
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 381,
        "InterOperator": "And",
        "UniqueHash": 687
      }
    ]
  },
  {
    "Name": "Corwin, Goodwin and Wisozk",
    "Description": "Stand-alone transitional throughput",
    "Rank": 543,
    "Restrictions": [
      {
        "Name": "Pacocha, Jenkins and Harvey",
        "Operator": "vitae",
        "Values": [
          "sint",
          "qui"
        ],
        "DisplayValues": [
          "voluptatem",
          "qui"
        ],
        "ColumnInfo": null,
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 381,
        "InterOperator": "And",
        "UniqueHash": 687
      }
    ]
  }
]
```