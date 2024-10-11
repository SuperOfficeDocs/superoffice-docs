---
title: POST Agents/ViewState/PublishAndRetrieveUiEvents
uid: v1ViewStateAgent_PublishAndRetrieveUiEvents
generated: true
---

# POST Agents/ViewState/PublishAndRetrieveUiEvents

```http
POST /api/v1/Agents/ViewState/PublishAndRetrieveUiEvents
```

Publish zero or more events, and return any new events since the given event id.


The initial implementation is in-memory only; applies solely to the front-end web server; and anything older than 20 minutes is discarded






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ViewState/PublishAndRetrieveUiEvents?$select=name,department,category/id
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

LatestKnownEventId, PublishEvents, Metrics 

| Property Name | Type |  Description |
|----------------|------|--------------|
| LatestKnownEventId | Integer |  |
| PublishEvents | Array |  |
| Metrics | Array |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| EventId | int32 | Id of event, increasing in chronological order, assigned by server |
| EventName | string | Name of event, for instance 'change' or 'edit' |
| EntityType | string | Name of entity, for instance 'ticket' |
| EntityKey | int32 | Primary key of entity the event concerns |
| AssociateId | int32 | The ID of the associate causing the event |
| AssociateName | string | The full person name of the associate causing the event |
| EventDateTime | date-time | When did the event happen |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/ViewState/PublishAndRetrieveUiEvents
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "LatestKnownEventId": 216,
  "PublishEvents": [
    {
      "EventId": 883,
      "EventName": "Block-Koepp",
      "EntityType": "quaerat",
      "EntityKey": 139,
      "AssociateId": 276,
      "AssociateName": "Pfannerstill-Bode",
      "EventDateTime": "2000-01-10T03:44:53.4498657+01:00"
    }
  ],
  "Metrics": [
    {
      "Name": "Wolf Inc and Sons",
      "Value": 746
    },
    {
      "Name": "Wolf Inc and Sons",
      "Value": 746
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "EventId": 927,
    "EventName": "Carter-Schneider",
    "EntityType": "quam",
    "EntityKey": 369,
    "AssociateId": 167,
    "AssociateName": "Osinski-Robel",
    "EventDateTime": "2013-12-08T03:44:53.4498657+01:00",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 232
      }
    }
  }
]
```