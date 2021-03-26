---
title: POST Agents/EMail/GetEmailAppointment
id: v1EMailAgent_GetEmailAppointment
---

# POST Agents/EMail/GetEmailAppointment

```http
POST /api/v1/Agents/EMail/GetEmailAppointment
```

Get appointment data contained in the emails iCal attachment



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEmailAppointment?$select=name,department,category/id
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

MailItemId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MailItemId | int32 |  |


## Response: object

Information about an email appointment received as iCal data



Carrier object for EMailAppointment.
Services for the EMailAppointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment |  | Appointment information |
| CalMethod | string | Method field stored in ICS file. |
| Participants | array | List of participants in the iCal file - first one being the organizer |
| Comment | string | Comment attached to the calendar event (accept / reject reason etc.) |
| Sequence | int32 | Sequence number in ICS file. |
| DtStart | date-time | Start date/time in ICS file. |
| DtEnd | date-time | End date/time in ICS file. |
| Superseded | bool | A newer invitation exists |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/EMail/GetEmailAppointment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "MailItemId": 704
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 25,
    "StartDate": "2009-08-10T16:48:29.5439246+02:00",
    "EndDate": "1995-12-08T16:48:29.5439246+01:00",
    "Type": "BookingForChecklist",
    "Task": "quam",
    "AssociateFullName": "Marco Murray",
    "ContactName": "Schinner Group",
    "Description": "Progressive impactful moratorium",
    "PersonFullName": "Luigi Altenwerth",
    "PersonId": 788,
    "ContactId": 388,
    "ProjectId": 982,
    "ProjectName": "Cummings, Rowe and Murazik",
    "IsPublished": false,
    "AssociateId": 811,
    "ColorIndex": 274,
    "IsFree": false,
    "HasAlarm": true,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 942,
    "PriorityName": "O'Connell LLC",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": false,
    "IsBooking": false,
    "ActiveDate": "2005-09-15T16:48:29.5439246+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "1996-09-26T16:48:29.5439246+02:00",
    "RecurringEndDate": "2015-09-07T16:48:29.5439246+02:00",
    "MotherId": 520,
    "AssignedBy": 913,
    "AssignedByFullName": "Dasia Glover",
    "RejectReason": "",
    "Location": "ab",
    "AlarmLeadTime": "neque",
    "SaleId": 650,
    "SaleName": "Monahan LLC",
    "AssociateName": "DuBuque LLC",
    "CreatedDate": "1997-07-01T16:48:29.5449251+02:00",
    "CreatedBy": "autem",
    "CreatedByFullName": "Dock Beier",
    "CreatedByAssociateId": 454,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 305
      }
    }
  },
  "CalMethod": "Add",
  "Participants": [
    "facilis",
    "est"
  ],
  "Comment": "tempore",
  "Sequence": 757,
  "DtStart": "2013-04-26T16:48:29.5449251+02:00",
  "DtEnd": "2003-03-25T16:48:29.5449251+01:00",
  "Superseded": false,
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
      "FieldType": "System.String",
      "FieldLength": 357
    }
  }
}
```