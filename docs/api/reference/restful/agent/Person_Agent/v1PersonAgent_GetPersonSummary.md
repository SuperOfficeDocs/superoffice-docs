---
title: POST Agents/Person/GetPersonSummary
uid: v1PersonAgent_GetPersonSummary
---

# POST Agents/Person/GetPersonSummary

```http
POST /api/v1/Agents/Person/GetPersonSummary
```

Get summary of person and recent activity.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonSummary?$select=name,department,category/id
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

PersonId, Limit

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 |  |
| Limit | int32 |  |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| Person |  | Simple Person data. |
| Tickets | array | Recent tickets on person |
| Followups | array | Recent follow-ups on person |
| Documents | array | Recent documents on person |
| Sales | array | Recent sales on person |
| Chats | array | Recent chats with person |

## Sample request

```http!
POST /api/v1/Agents/Person/GetPersonSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 991,
  "Limit": 753
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 143,
      "TicketStatus": 119,
      "Title": "nesciunt",
      "Registered": "1996-01-27T11:10:27.4904582+01:00",
      "IconHint": "eum"
    },
    {
      "TicketId": 143,
      "TicketStatus": 119,
      "Title": "nesciunt",
      "Registered": "1996-01-27T11:10:27.4904582+01:00",
      "IconHint": "eum"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 873,
      "DocumentId": 830,
      "Date": "2018-09-18T11:10:27.4914574+02:00",
      "Description": "Multi-lateral multi-state standardization",
      "Completed": "Completed",
      "Registered": "2009-06-17T11:10:27.4914574+02:00"
    },
    {
      "AppointmentId": 873,
      "DocumentId": 830,
      "Date": "2018-09-18T11:10:27.4914574+02:00",
      "Description": "Multi-lateral multi-state standardization",
      "Completed": "Completed",
      "Registered": "2009-06-17T11:10:27.4914574+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 514,
      "DocumentId": 650,
      "Date": "1998-04-16T11:10:27.4914574+02:00",
      "Description": "Digitized didactic flexibility",
      "Completed": "Completed",
      "Registered": "2000-08-03T11:10:27.4914574+02:00"
    },
    {
      "AppointmentId": 514,
      "DocumentId": 650,
      "Date": "1998-04-16T11:10:27.4914574+02:00",
      "Description": "Digitized didactic flexibility",
      "Completed": "Completed",
      "Registered": "2000-08-03T11:10:27.4914574+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 92,
      "SaleDate": "2000-10-14T11:10:27.4914574+02:00",
      "Probability": 164,
      "Heading": "et",
      "Amount": 28754.45,
      "Currency": "animi",
      "AmountInBaseCurrency": 3394.122,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2020-03-10T11:10:27.4914574+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 88,
      "Name": "Altenwerth Group",
      "CompanyName": "Schiller LLC",
      "FirstMessage": "cumque",
      "LastMessage": "sed",
      "WhenRequested": "2016-05-29T11:10:27.4914574+02:00",
      "WhenEnded": "2012-06-17T11:10:27.4914574+02:00"
    }
  ]
}
```
