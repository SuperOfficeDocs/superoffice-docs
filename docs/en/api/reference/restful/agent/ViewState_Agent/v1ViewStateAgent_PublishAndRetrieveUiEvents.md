---
title: POST Agents/ViewState/PublishAndRetrieveUiEvents
uid: v1ViewStateAgent_PublishAndRetrieveUiEvents
generated: true
content_type: reference
---

# POST Agents/ViewState/PublishAndRetrieveUiEvents

```http
POST /api/v1/Agents/ViewState/PublishAndRetrieveUiEvents
```

Publish zero or more events, and return any new events since the given event id.


The initial implementation is in-memory only; applies solely to the front-end web server; and anything older than 20 minutes is discarded
NsApiSlow threshold: 5000 ms.






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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "LatestKnownEventId": 96,
  "PublishEvents": [
    {
      "EventId": 995,
      "EventName": "Armstrong Inc and Sons",
      "EntityType": "suscipit",
      "EntityKey": 911,
      "AssociateId": 420,
      "AssociateName": "Weimann, Braun and Abbott",
      "EventDateTime": "2000-10-03T03:40:48.2817514+02:00"
    }
  ],
  "Metrics": [
    {
      "Name": "Gislason Inc and Sons",
      "Value": 810
    },
    {
      "Name": "Gislason Inc and Sons",
      "Value": 810
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
    "EventId": 116,
    "EventName": "Kreiger, Herzog and Bahringer",
    "EntityType": "illo",
    "EntityKey": 381,
    "AssociateId": 386,
    "AssociateName": "Hammes, Kertzmann and Vandervort",
    "EventDateTime": "2008-10-04T03:40:48.2817514+02:00",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 622
      }
    }
  }
]
```