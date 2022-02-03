---
title: POST Agents/List/SaveTicketPriorityEntity
id: v1ListAgent_SaveTicketPriorityEntity
---

# POST Agents/List/SaveTicketPriorityEntity

```http
POST /api/v1/Agents/List/SaveTicketPriorityEntity
```

Updates the existing TicketPriorityEntity or creates a new TicketPriorityEntity if the id parameter is empty








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

## Request Body: entity  

The TicketPriorityEntity to be saved. 

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


## Response: object

Entity for a ticket priority. This entity describes the meta data for a ticket priority, and provides special operations on it.



Carrier object for TicketPriorityEntity.
Services for the TicketPriorityEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

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
POST /api/v1/Agents/List/SaveTicketPriorityEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 625,
  "Name": "Mayer Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 318,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 926,
  "MonStart": "2000-09-25T18:28:49.3631226+02:00",
  "MonStop": "2017-03-25T18:28:49.3631226+01:00",
  "TueStart": "2020-03-09T18:28:49.3631226+01:00",
  "TueStop": "2004-01-09T18:28:49.3631226+01:00",
  "WedStart": "2014-04-02T18:28:49.3631226+02:00",
  "WedStop": "1998-03-26T18:28:49.3631226+01:00",
  "ThuStart": "2003-12-18T18:28:49.3631226+01:00",
  "ThuStop": "2004-04-21T18:28:49.3631226+02:00",
  "FriStart": "2020-08-03T18:28:49.3631226+02:00",
  "FriStop": "1996-04-22T18:28:49.3631226+02:00",
  "SatStart": "2019-08-06T18:28:49.3631226+02:00",
  "SatStop": "2014-10-25T18:28:49.3631226+02:00",
  "SunStart": "2016-03-20T18:28:49.3631226+01:00",
  "SunStop": "1997-11-19T18:28:49.3631226+01:00",
  "NonDates": [
    "rerum",
    "est"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 142,
      "AlertLevel": 858,
      "AlertTimeout": 318,
      "Action": 944,
      "DelegateTo": 842,
      "ScriptId": 612,
      "EmailTo": "jason@turner.biz",
      "SmsTo": "officia",
      "ReplyTemplateIdCustomer": 248,
      "ReplyTemplateIdUser": 709,
      "ReplyTemplateIdCatmast": 707,
      "ReplyTemplateIdEmail": 669,
      "RtiCustomerSms": 358,
      "ReplyTemplateIdUserSms": 138,
      "ReplyTemplateIdCatmastSms": 535,
      "ReplyTemplateIdSms": 563
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 553,
  "Name": "Ankunding Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 754,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 526,
  "MonStart": "2010-11-27T18:28:49.3641241+01:00",
  "MonStop": "2013-10-20T18:28:49.3641241+02:00",
  "TueStart": "2001-09-09T18:28:49.3641241+02:00",
  "TueStop": "2003-02-14T18:28:49.3641241+01:00",
  "WedStart": "2011-11-29T18:28:49.3641241+01:00",
  "WedStop": "2009-04-06T18:28:49.3641241+02:00",
  "ThuStart": "1999-12-14T18:28:49.3641241+01:00",
  "ThuStop": "2013-05-30T18:28:49.3641241+02:00",
  "FriStart": "2015-09-02T18:28:49.3641241+02:00",
  "FriStop": "2021-09-03T18:28:49.3641241+02:00",
  "SatStart": "2010-12-28T18:28:49.3641241+01:00",
  "SatStop": "1997-11-03T18:28:49.3641241+01:00",
  "SunStart": "2013-08-27T18:28:49.3641241+02:00",
  "SunStop": "2018-08-02T18:28:49.3641241+02:00",
  "NonDates": [
    "delectus",
    "repellat"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 999,
      "AlertLevel": 377,
      "AlertTimeout": 937,
      "Action": 827,
      "DelegateTo": 864,
      "ScriptId": 208,
      "EmailTo": "jackeline_nicolas@damore.uk",
      "SmsTo": "perferendis",
      "ReplyTemplateIdCustomer": 528,
      "ReplyTemplateIdUser": 974,
      "ReplyTemplateIdCatmast": 194,
      "ReplyTemplateIdEmail": 558,
      "RtiCustomerSms": 383,
      "ReplyTemplateIdUserSms": 990,
      "ReplyTemplateIdCatmastSms": 516,
      "ReplyTemplateIdSms": 243,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 78
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
      "FieldLength": 572
    }
  }
}
```