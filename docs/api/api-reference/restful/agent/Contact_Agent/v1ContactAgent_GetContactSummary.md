---
title: GetContactSummary
id: v1ContactAgent_GetContactSummary
---

# GetContactSummary

```http
POST /api/v1/Agents/Contact/GetContactSummary
```

Get summary of contact and its recent activity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactSummary?$select=name,department,category/id
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

ContactId, Limit 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |
| Limit | int32 |  |


## Response: object

Summary of contact with recent activities, chats, and requests included.



Carrier object for ContactSummary.
Services for the ContactSummary Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Contact |  | Simple Contact data. |
| Tickets | array | Recent tickets on contact |
| Followups | array | Recent follow-ups on contact |
| Documents | array | Recent documents on contact |
| Sales | array | Recent sales on contact |
| Chats | array | Recent chats with contact |

## Sample Request

```http!
POST /api/v1/Agents/Contact/GetContactSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 668,
  "Limit": 727
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": {
    "ContactId": 258,
    "Name": "Sanford Group",
    "OrgNr": "1022229",
    "Department": "facilitate integrated experiences",
    "URL": "http://www.example.com/",
    "City": "veritatis",
    "DirectPhone": "605-573-1108",
    "AssociateId": 252,
    "CountryId": 760,
    "EmailAddress": "emmy@gleasonkoepp.co.uk",
    "Kananame": "dolores",
    "EmailAddressName": "bert.osinski@dickiwalsh.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Elvera Shanahan II",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ullam",
    "FullName": "Evert Harber",
    "IsOwnerContact": true,
    "ActiveErpLinks": 208,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 191
      }
    }
  },
  "Tickets": [
    {
      "TicketId": 152,
      "TicketStatus": 530,
      "Title": "non",
      "Registered": "2008-03-14T14:58:03.72446+01:00"
    },
    {
      "TicketId": 152,
      "TicketStatus": 530,
      "Title": "non",
      "Registered": "2008-03-14T14:58:03.72446+01:00"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 811,
      "DocumentId": 90,
      "Date": "2012-12-23T14:58:03.72446+01:00",
      "Description": "Streamlined content-based system engine",
      "Completed": "Completed",
      "Registered": "2003-08-02T14:58:03.72446+02:00"
    },
    {
      "AppointmentId": 811,
      "DocumentId": 90,
      "Date": "2012-12-23T14:58:03.72446+01:00",
      "Description": "Streamlined content-based system engine",
      "Completed": "Completed",
      "Registered": "2003-08-02T14:58:03.72446+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 731,
      "DocumentId": 913,
      "Date": "2015-03-30T14:58:03.72446+02:00",
      "Description": "Profit-focused holistic implementation",
      "Completed": "Completed",
      "Registered": "2000-12-21T14:58:03.72446+01:00"
    },
    {
      "AppointmentId": 731,
      "DocumentId": 913,
      "Date": "2015-03-30T14:58:03.72446+02:00",
      "Description": "Profit-focused holistic implementation",
      "Completed": "Completed",
      "Registered": "2000-12-21T14:58:03.72446+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 104,
      "SaleDate": "1995-01-15T14:58:03.72446+01:00",
      "Probability": 892,
      "Heading": "vel",
      "Amount": 31189.568,
      "Currency": "vitae",
      "AmountInBaseCurrency": 27911.404,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2014-04-06T14:58:03.72446+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 923,
      "Name": "Considine Inc and Sons",
      "CompanyName": "Keeling Group",
      "FirstMessage": "asperiores",
      "LastMessage": "aperiam",
      "WhenRequested": "1995-12-04T14:58:03.7254597+01:00",
      "WhenEnded": "2000-05-07T14:58:03.7254597+02:00"
    }
  ]
}
```