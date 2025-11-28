```http_
HTTP/1.1 200 AppointmentEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 07 May 2022 14:34:01 G5T

{
  "Associate": null,
  "Contact": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "2003-12-22T14:34:01.4402841+01:00",
  "AppointmentId": 182,
  "Description": "Quarterly Business Review with Acme Corporation to discuss Q4 performance, upcoming initiatives, and contract renewal.",
  "Title": "Q4 Business Review - Acme Corp",
  "Agenda": "1. Review Q4 metrics\n2. Discuss new feature requests\n3. Contract renewal terms\n4. Q&A",
  "InternalNotes": "Bring updated pricing proposal. Customer mentioned budget concerns last meeting.",
  "StartDate": "2024-12-05T14:00:00+01:00",
  "EndDate": "2024-12-05T15:30:00+01:00",
  "InvitedPerson": null,
  "Person": null,
  "MotherId": 150,
  "Priority": null,
  "Private": "PrivateGroup",
  "Project": null,
  "Type": "BookingForChecklist",
  "UpdatedDate": "2022-05-07T14:34:01.4402841+02:00",
  "Completed": "Completed",
  "ActiveLinks": 1002,
  "Links": [
    {
      "EntityName": "Reynolds LLC",
      "Id": 310,
      "Description": "Link to contract documentation",
      "ExtraInfo": "eius",
      "LinkId": 107,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 32
        }
      }
    }
  ],
  "AlarmLeadTime": "PT30M",
  "HasAlarm": true,
  "ColorIndex": 983,
  "IsFree": false,
  "IsAlldayEvent": false,
  "LagTime": "PT0M",
  "LeadTime": "PT15M",
  "Location": "Conference Room A, Oslo Office",
  "RejectCounter": 0,
  "RejectReason": "",
  "Recurrence": null,
  "Participants": [
    {
      "AssociateId": 356,
      "PersonId": 8,
      "ContactId": 293,
      "EmailId": 169,
      "SendEmail": true,
      "InvitationStatus": "Accepted",
      "EmailAddress": "sarah.johnson@acmecorp.com",
      "Description": "Marketing Director at Acme Corporation"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2019-06-16T14:34:01.4402841+02:00",
  "HasConflict": true,
  "AssignedBy": null,
  "MotherAssociate": null,
  "Task": null,
  "PreferredTZLocation": 862,
  "PreferredTZLocationData": null,
  "Sale": null,
  "SuggestedAppointmentId": 588,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "OwnedExternally": "Google",
  "JoinVideomeetUrl": "https://meet.superoffice.com/meeting/abc123xyz",
  "CentralserviceVideomeetId": "abc123xyz",
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "Priority customer",
    "ExtraFields2": "Renewal pending"
  },
  "CustomFields": {
    "CustomFields1": "Enterprise",
    "CustomFields2": "2024"
  },
  "PublishEventDate": "2015-07-18T14:34:01.4402841+02:00",
  "PublishTo": "2008-07-29T14:34:01.4402841+02:00",
  "PublishFrom": "2003-08-18T14:34:01.4402841+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 945,
      "Visibility": "All",
      "DisplayValue": "All users",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 398
        }
      }
    },
    {
      "VisibleId": 945,
      "Visibility": "All",
      "DisplayValue": "All users",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 398
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 296
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```