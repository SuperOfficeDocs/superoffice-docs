---
title: POST Agents/Person/GetPersonSummary
uid: v1PersonAgent_GetPersonSummary
generated: true
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
| PersonId | Integer |  |
| Limit | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| Person | Person | Simple Person data. |
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 115,
  "Limit": 339
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
      "TicketId": 201,
      "TicketStatus": 679,
      "Title": "autem",
      "Registered": "2014-10-07T03:24:48.0176214+02:00",
      "IconHint": "sed"
    },
    {
      "TicketId": 201,
      "TicketStatus": 679,
      "Title": "autem",
      "Registered": "2014-10-07T03:24:48.0176214+02:00",
      "IconHint": "sed"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 767,
      "DocumentId": 479,
      "Date": "1997-01-31T03:24:48.0176214+01:00",
      "Description": "Integrated zero defect help-desk",
      "Completed": "Completed",
      "Registered": "2019-07-18T03:24:48.0176214+02:00"
    },
    {
      "AppointmentId": 767,
      "DocumentId": 479,
      "Date": "1997-01-31T03:24:48.0176214+01:00",
      "Description": "Integrated zero defect help-desk",
      "Completed": "Completed",
      "Registered": "2019-07-18T03:24:48.0176214+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 145,
      "DocumentId": 92,
      "Date": "2009-07-18T03:24:48.0176214+02:00",
      "Description": "Face to face homogeneous Graphic Interface",
      "Completed": "Completed",
      "Registered": "2007-11-06T03:24:48.0176214+01:00"
    },
    {
      "AppointmentId": 145,
      "DocumentId": 92,
      "Date": "2009-07-18T03:24:48.0176214+02:00",
      "Description": "Face to face homogeneous Graphic Interface",
      "Completed": "Completed",
      "Registered": "2007-11-06T03:24:48.0176214+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 841,
      "SaleDate": "2003-02-22T03:24:48.0176214+01:00",
      "Probability": 312,
      "Heading": "consequatur",
      "Amount": 27250.129999999997,
      "Currency": "dignissimos",
      "AmountInBaseCurrency": 14253.431999999999,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2008-11-13T03:24:48.0176214+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 362,
      "Name": "Bernier LLC",
      "CompanyName": "Bruen-Beahan",
      "FirstMessage": "ad",
      "LastMessage": "aliquam",
      "WhenRequested": "2018-02-23T03:24:48.0176214+01:00",
      "WhenEnded": "2016-08-31T03:24:48.0176214+02:00"
    }
  ]
}
```