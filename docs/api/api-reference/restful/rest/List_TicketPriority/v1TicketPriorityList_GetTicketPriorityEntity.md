---
title: GET List/TicketPriority/Items/{id}
id: v1TicketPriorityList_GetTicketPriorityEntity
---

# GET List/TicketPriority/Items/{id}

```http
GET /api/v1/List/TicketPriority/Items/{id}
```

Gets a TicketPriorityEntity list item.

Calls the List agent service GetTicketPriorityEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the TicketPriority to return. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

Entity for a ticket priority. This entity describes the meta data for a ticket priority, and provides special operations on it.



Carrier object for TicketPriorityEntity.
Services for the TicketPriorityEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 404 | Not Found. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketPriorityId | int32 | The primary key (auto-incremented) |
| Name | string | The name of the priority. |
| Status | string | The status (normal/deleted) of the priority. |
| Flags | string | A bitmask of flags. |
| SortOrder | int32 | Indicates the sort order for this priority. 1 is first, 100 is last |
| TicketRead | string | This field indicates what to do with the escalation chain when the request is read |
| ChangedOwner | string | This field indicates what to do with the escalation chain when the request changes owner (manually) |
| TicketNewinfo | string | This field indicates what to do with the escalation chain when the request gets new info |
| TicketClosed | string | This field indicates what to do with the escalation chain when the request is closed |
| TicketChangedPriority | string | This field indicates what to do with the escalation chain when the request is changed into this priority |
| TicketNew | string | This field indicates what to do with the escalation chain when a new request is registered |
| Deadline | int32 | Deadline to add if escalated (minutes) |
| MonStart | date-time | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| MonStop | date-time | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| TueStart | date-time | The work hour start for Tuesdays. Note that only the time part of the DateTime is used |
| TueStop | date-time | The work hour stop for Tuesdays. Note that only the time part of the DateTime is used |
| WedStart | date-time | The work hour start for Wednesdays. Note that only the time part of the DateTime is used |
| WedStop | date-time | The work hour stop for Wednesdays. Note that only the time part of the DateTime is used |
| ThuStart | date-time | The work hour start for Thursdays. Note that only the time part of the DateTime is used |
| ThuStop | date-time | The work hour stop for Thursdays. Note that only the time part of the DateTime is used |
| FriStart | date-time | The work hour start for Fridays. Note that only the time part of the DateTime is used |
| FriStop | date-time | The work hour stop for Fridays. Note that only the time part of the DateTime is used |
| SatStart | date-time | The work hour start for Saturdays. Note that only the time part of the DateTime is used |
| SatStop | date-time | The work hour stop for Saturdays. Note that only the time part of the DateTime is used |
| SunStart | date-time | The work hour start for Sundays. Note that only the time part of the DateTime is used |
| SunStop | date-time | The work hour stop for Sundays. Note that only the time part of the DateTime is used |
| NonDates | array | Dates which the escalation time should not be running. Note that only the day of the year (day and month) is used. So the year and time part is not used even if this is a DateTime |
| EscalationLevels | array | Escalation levels bound to the parent priority |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/List/TicketPriority/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 360,
  "Name": "Beier-Borer",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 95,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 67,
  "MonStart": "2016-11-30T18:25:52.3106728+01:00",
  "MonStop": "2017-04-06T18:25:52.3106728+02:00",
  "TueStart": "2000-07-04T18:25:52.3106728+02:00",
  "TueStop": "1994-12-30T18:25:52.3106728+01:00",
  "WedStart": "2002-07-03T18:25:52.3106728+02:00",
  "WedStop": "2002-01-26T18:25:52.3106728+01:00",
  "ThuStart": "2015-06-15T18:25:52.3106728+02:00",
  "ThuStop": "2008-06-20T18:25:52.3106728+02:00",
  "FriStart": "2004-10-20T18:25:52.3106728+02:00",
  "FriStop": "2021-06-17T18:25:52.3106728+02:00",
  "SatStart": "2005-12-19T18:25:52.3106728+01:00",
  "SatStop": "2006-10-21T18:25:52.3106728+02:00",
  "SunStart": "1999-04-28T18:25:52.3106728+02:00",
  "SunStop": "2003-11-19T18:25:52.3106728+01:00",
  "NonDates": [
    "quia",
    "quia"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 911,
      "AlertLevel": 624,
      "AlertTimeout": 963,
      "Action": 702,
      "DelegateTo": 623,
      "ScriptId": 466,
      "EmailTo": "kayley_auer@barrows.biz",
      "SmsTo": "aut",
      "ReplyTemplateIdCustomer": 18,
      "ReplyTemplateIdUser": 588,
      "ReplyTemplateIdCatmast": 518,
      "ReplyTemplateIdEmail": 565,
      "RtiCustomerSms": 652,
      "ReplyTemplateIdUserSms": 970,
      "ReplyTemplateIdCatmastSms": 344,
      "ReplyTemplateIdSms": 870,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 101
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 760
    }
  }
}
```