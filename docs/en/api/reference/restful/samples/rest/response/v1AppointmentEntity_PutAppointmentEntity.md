```http_
HTTP/1.1 200 AppointmentEntity updated.
Content-Type: application/json; charset=utf-8

{
  "Associate": null,
  "Contact": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "2010-02-23T14:34:01.4560497+01:00",
  "AppointmentId": 401,
  "Description": "Product training session for the new CRM features. Focus on dashboard customization and reporting tools.",
  "Title": "CRM Training Session - Advanced Features",
  "Agenda": "1. Dashboard overview\n2. Custom report creation\n3. Automation features\n4. Hands-on exercises\n5. Q&A",
  "InternalNotes": "Participants should have completed basic training. Prepare demo environment.",
  "StartDate": "2024-12-15T13:00:00+01:00",
  "EndDate": "2024-12-15T15:00:00+01:00",
  "InvitedPerson": null,
  "Person": null,
  "MotherId": 418,
  "Priority": null,
  "Private": "PrivateGroup",
  "Project": null,
  "Type": "BookingForChecklist",
  "UpdatedDate": "2018-02-16T14:34:01.4560497+01:00",
  "Completed": "Completed",
  "ActiveLinks": 424,
  "Links": [
    {
      "EntityName": "Crist-Stehr",
      "Id": 534,
      "Description": "Link to training materials",
      "ExtraInfo": "ut",
      "LinkId": 921,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 42
        }
      }
    }
  ],
  "AlarmLeadTime": "PT15M",
  "HasAlarm": true,
  "ColorIndex": 444,
  "IsFree": false,
  "IsAlldayEvent": false,
  "LagTime": "PT0M",
  "LeadTime": "PT10M",
  "Location": "Training Room 2, Floor 3",
  "RejectCounter": 0,
  "RejectReason": "",
  "Recurrence": null,
  "Participants": [
    {
      "AssociateId": 23,
      "PersonId": 129,
      "ContactId": 676,
      "EmailId": 495,
      "SendEmail": true,
      "InvitationStatus": "Accepted",
      "EmailAddress": "anna.larsen@company.no",
      "Description": "Sales Representative"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2023-09-18T14:34:01.4713669+02:00",
  "HasConflict": false,
  "AssignedBy": null,
  "MotherAssociate": null,
  "Task": null,
  "PreferredTZLocation": 853,
  "PreferredTZLocationData": null,
  "Sale": null,
  "SuggestedAppointmentId": 531,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "OwnedExternally": "Google",
  "JoinVideomeetUrl": "https://meet.superoffice.com/training/xyz789",
  "CentralserviceVideomeetId": "xyz789",
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "Internal training",
    "ExtraFields2": "Q4 2024"
  },
  "CustomFields": {
    "CustomFields1": "Training",
    "CustomFields2": "CRM"
  },
  "PublishEventDate": "2013-07-16T14:34:01.4733726+02:00",
  "PublishTo": "2004-02-14T14:34:01.4733726+01:00",
  "PublishFrom": "2012-01-20T14:34:01.4733726+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 617,
      "Visibility": "All",
      "DisplayValue": "All users",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 516
        }
      }
    },
    {
      "VisibleId": 617,
      "Visibility": "All",
      "DisplayValue": "All users",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 516
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 797
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```