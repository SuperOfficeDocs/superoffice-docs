---
title: POST Agents/Sale/SaveSaleEntity
id: v1SaleAgent_SaveSaleEntity
---

# POST Agents/Sale/SaveSaleEntity

```http
POST /api/v1/Agents/Sale/SaveSaleEntity
```

Updates the existing SaleEntity or creates a new SaleEntity if the id parameter is empty








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

The SaleEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment |  | Simple read-only appointment data. <para /> Carrier object for Appointment. Services for the Appointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>. |
| Associate |  | The sale owner  <para>Use MDO List name "associate" to get list items.</para> |
| UpdatedBy |  | Who updated the sale |
| CreatedBy |  | Who created to sale |
| Contact |  | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  <para>Use MDO List name "contact" to get list items.</para> |
| Project |  | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| SaleText | string | Text describing the sale |
| Person |  | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Currency |  | The currency the sale object was sold in  <para>Use MDO List name "currency" to get list items.</para> |
| Competitor |  | List of all possible competitors.   <para>Use MDO List name "comptr" to get list items.</para> |
| Credited |  | List of who is to be credited for the sale.  <para>Use MDO List name "credited" to get list items.</para> |
| Rating |  | The sale rating  <para>Use MDO List name "prob" to get list items.</para> |
| Reason |  | The sale reason  <para>Use MDO List name "reason" to get list items.</para> |
| Source |  | The sale source  <para>Use MDO List name "source" to get list items.</para> |
| Status | string | The state of the Sale: Open / Sold / Lost / Stalled |
| Saledate | date-time | (expected / lost / won) sales date |
| Amount | double | Total sale amount |
| SaleId | int32 | Primary key |
| Earning | double | Earning on sale |
| EarningPercent | double | Earning as percent of total |
| Heading | string | Sale heading (short description?) |
| Number | string | Alphanumeric user field |
| Probability | int32 | Actual probability, may differ from the one in the list |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated  in UTC. |
| Completed | string | The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field. |
| ActiveLinks | int32 | Number of active links to sale, document, appointment. |
| Links | array | List of all elements linked to the sale. |
| NextDueDate | date-time | Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching. |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| SaleType |  | <para>Use MDO List name "saletype" to get list items.</para> |
| ReasonSold |  | <para>Use MDO List name "reasonsold" to get list items.</para> |
| ReasonStalled |  | <para>Use MDO List name "reasonstalled" to get list items.</para> |
| ReopenDate | date-time | Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate. |
| SaleStakeholders | array |  |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.SaleEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.SaleEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| VisibleFor | array | The set of users or groups the record is visible for |


## Response: object

Partial SaleEntity class associating the generated SaleEntity with an interface.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment |  | Simple read-only appointment data. <para /> Carrier object for Appointment. Services for the Appointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>. |
| Associate |  | The sale owner  <para>Use MDO List name "associate" to get list items.</para> |
| UpdatedBy |  | Who updated the sale |
| CreatedBy |  | Who created to sale |
| Contact |  | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  <para>Use MDO List name "contact" to get list items.</para> |
| Project |  | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| SaleText | string | Text describing the sale |
| Person |  | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Currency |  | The currency the sale object was sold in  <para>Use MDO List name "currency" to get list items.</para> |
| Competitor |  | List of all possible competitors.   <para>Use MDO List name "comptr" to get list items.</para> |
| Credited |  | List of who is to be credited for the sale.  <para>Use MDO List name "credited" to get list items.</para> |
| Rating |  | The sale rating  <para>Use MDO List name "prob" to get list items.</para> |
| Reason |  | The sale reason  <para>Use MDO List name "reason" to get list items.</para> |
| Source |  | The sale source  <para>Use MDO List name "source" to get list items.</para> |
| Status | string | The state of the Sale: Open / Sold / Lost / Stalled |
| Saledate | date-time | (expected / lost / won) sales date |
| Amount | double | Total sale amount |
| SaleId | int32 | Primary key |
| Earning | double | Earning on sale |
| EarningPercent | double | Earning as percent of total |
| Heading | string | Sale heading (short description?) |
| Number | string | Alphanumeric user field |
| Probability | int32 | Actual probability, may differ from the one in the list |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated  in UTC. |
| Completed | string | The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field. |
| ActiveLinks | int32 | Number of active links to sale, document, appointment. |
| Links | array | List of all elements linked to the sale. |
| NextDueDate | date-time | Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching. |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| SaleType |  | <para>Use MDO List name "saletype" to get list items.</para> |
| ReasonSold |  | <para>Use MDO List name "reasonsold" to get list items.</para> |
| ReasonStalled |  | <para>Use MDO List name "reasonstalled" to get list items.</para> |
| ReopenDate | date-time | Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate. |
| SaleStakeholders | array |  |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.SaleEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.SaleEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Sale/SaveSaleEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 699,
    "StartDate": "2009-06-14T16:48:30.5719252+02:00",
    "EndDate": "2017-12-02T16:48:30.5719252+01:00",
    "Type": "BookingForChecklist",
    "Task": "quia",
    "AssociateFullName": "Mr. Turner Boyle",
    "ContactName": "Schulist Inc and Sons",
    "Description": "Synergized systemic concept",
    "PersonFullName": "Kenya McGlynn",
    "PersonId": 173,
    "ContactId": 933,
    "ProjectId": 849,
    "ProjectName": "Lemke Inc and Sons",
    "IsPublished": true,
    "AssociateId": 573,
    "ColorIndex": 198,
    "IsFree": true,
    "HasAlarm": false,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 393,
    "PriorityName": "Jacobi Group",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": false,
    "IsBooking": true,
    "ActiveDate": "2010-01-11T16:48:30.5729356+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "1995-02-23T16:48:30.5729356+01:00",
    "RecurringEndDate": "1998-02-28T16:48:30.5729356+01:00",
    "MotherId": 294,
    "AssignedBy": 276,
    "AssignedByFullName": "Lance Torphy I",
    "RejectReason": "",
    "Location": "sit",
    "AlarmLeadTime": "nihil",
    "SaleId": 161,
    "SaleName": "Schneider, Volkman and Bode",
    "AssociateName": "Armstrong, Johnston and Bechtelar",
    "CreatedDate": "2008-03-12T16:48:30.5739332+01:00",
    "CreatedBy": "vel",
    "CreatedByFullName": "Odie Green",
    "CreatedByAssociateId": 764,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/"
  },
  "Associate": {
    "AssociateId": 883,
    "Name": "Cole LLC",
    "PersonId": 473,
    "Rank": 730,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 724,
    "FullName": "Blanche Blick V",
    "FormalName": "Flatley-Spencer",
    "Deleted": false,
    "EjUserId": 545,
    "UserName": "Bahringer-Torp"
  },
  "UpdatedBy": {
    "AssociateId": 123,
    "Name": "Kshlerin-Turcotte",
    "PersonId": 368,
    "Rank": 361,
    "Tooltip": "reprehenderit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 598,
    "FullName": "Willis Wisozk",
    "FormalName": "Klein Inc and Sons",
    "Deleted": false,
    "EjUserId": 25,
    "UserName": "Bartell, Heller and Berge"
  },
  "CreatedBy": {
    "AssociateId": 809,
    "Name": "Wiza Group",
    "PersonId": 336,
    "Rank": 137,
    "Tooltip": "magni",
    "Type": "AnonymousAssociate",
    "GroupIdx": 160,
    "FullName": "Zelma Bernhard",
    "FormalName": "Upton, Marks and Hessel",
    "Deleted": false,
    "EjUserId": 990,
    "UserName": "Turcotte-Moore"
  },
  "Contact": {
    "ContactId": 614,
    "Name": "Mayert LLC",
    "OrgNr": "1317962",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "cumque",
    "DirectPhone": "405.183.0646 x73080",
    "AssociateId": 712,
    "CountryId": 405,
    "EmailAddress": "maia@baumbachanderson.com",
    "Kananame": "est",
    "EmailAddressName": "faustino_hegmann@davisfahey.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Jake Altenwerth",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "est",
    "FullName": "Theresia Larson",
    "IsOwnerContact": true,
    "ActiveErpLinks": 844
  },
  "Project": {
    "ProjectId": 212,
    "Name": "Gibson, Bogan and Moen",
    "Description": "Innovative analyzing benchmark",
    "URL": "http://www.example.com/",
    "Type": "vero",
    "AssociateId": 348,
    "AssociateFullName": "Joy Tromp",
    "TypeId": 385,
    "Updated": "2007-09-30T16:48:30.5759336+02:00",
    "StatusId": 49,
    "Status": "ratione",
    "TextId": 415,
    "PublishTo": "2017-09-07T16:48:30.5759336+02:00",
    "PublishFrom": "2007-04-06T16:48:30.5759336+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "918473",
    "ActiveErpLinks": 513
  },
  "SaleText": "perspiciatis",
  "Person": {
    "Position": "voluptatum",
    "PersonId": 739,
    "Mrmrs": "vel",
    "Firstname": "Cecelia",
    "Lastname": "Wiegand",
    "MiddleName": "Kassulke-Schimmel",
    "Title": "dolores",
    "Description": "Expanded content-based forecast",
    "Email": "bernie@weimann.info",
    "FullName": "Laurence Sipes III",
    "DirectPhone": "661-300-2443 x14138",
    "FormalName": "Bergnaum, Funk and Hegmann",
    "CountryId": 651,
    "ContactId": 147,
    "ContactName": "Cruickshank, Gaylord and Sawayn",
    "Retired": 992,
    "Rank": 573,
    "ActiveInterests": 955,
    "ContactDepartment": "",
    "ContactCountryId": 445,
    "ContactOrgNr": "1786394",
    "FaxPhone": "(842)206-5167 x825",
    "MobilePhone": "1-517-134-6674 x75043",
    "ContactPhone": "041.018.6504 x6430",
    "AssociateName": "Altenwerth Inc and Sons",
    "AssociateId": 90,
    "UsePersonAddress": false,
    "ContactFax": "non",
    "Kanafname": "ut",
    "Kanalname": "minus",
    "Post1": "harum",
    "Post2": "velit",
    "Post3": "distinctio",
    "EmailName": "raina@sawayn.ca",
    "ContactFullName": "Mason Koch",
    "ActiveErpLinks": 177,
    "TicketPriorityId": 163,
    "SupportLanguageId": 821,
    "SupportAssociateId": 786,
    "CategoryName": "VIP Customer"
  },
  "Currency": {
    "Id": 253,
    "Value": "est",
    "Tooltip": "officiis"
  },
  "Competitor": {
    "Id": 405,
    "Value": "ut",
    "Tooltip": "voluptas"
  },
  "Credited": {
    "Id": 733,
    "Value": "autem",
    "Tooltip": "et"
  },
  "Rating": {
    "Id": 264,
    "Value": "et",
    "Tooltip": "vero"
  },
  "Reason": {
    "Id": 577,
    "Value": "qui",
    "Tooltip": "expedita"
  },
  "Source": {
    "Id": 979,
    "Value": "quia",
    "Tooltip": "sit"
  },
  "Status": "Lost",
  "Saledate": "2018-02-21T16:48:30.5779382+01:00",
  "Amount": 22599.273999999998,
  "SaleId": 638,
  "Earning": 15134.086,
  "EarningPercent": 2325.428,
  "Heading": "ut",
  "Number": "605360",
  "Probability": 682,
  "CreatedDate": "2005-03-02T16:48:30.5779382+01:00",
  "UpdatedDate": "2014-10-20T16:48:30.5779382+02:00",
  "Completed": "Completed",
  "ActiveLinks": 55,
  "Links": [
    {
      "EntityName": "Feil-Feest",
      "Id": 965,
      "Description": "Managed holistic system engine",
      "ExtraInfo": "sapiente",
      "LinkId": 211
    },
    {
      "EntityName": "Feil-Feest",
      "Id": 965,
      "Description": "Managed holistic system engine",
      "ExtraInfo": "sapiente",
      "LinkId": 211
    }
  ],
  "NextDueDate": "2005-02-24T16:48:30.5779382+01:00",
  "Postit": "velit",
  "SaleType": {
    "Id": 709,
    "Value": "assumenda",
    "Tooltip": "et"
  },
  "ReasonSold": {
    "Id": 244,
    "Value": "dolorum",
    "Tooltip": "nesciunt"
  },
  "ReasonStalled": {
    "Id": 834,
    "Value": "ex",
    "Tooltip": "nihil"
  },
  "ReopenDate": "2008-06-06T16:48:30.5779382+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Yundt LLC",
      "Comment": "quaerat",
      "StakeholderRoleId": 80,
      "CountryId": 743,
      "PersonId": 400,
      "EmailDescription": "samanta@senger.uk",
      "EmailId": 897,
      "EmailAddress": "jerrold@nikolausgrimes.co.uk",
      "PhoneId": 344,
      "ContactName": "Bartell, Keeling and Hickle",
      "ContactId": 79,
      "SaleId": 404,
      "Mrmrs": "architecto",
      "Firstname": "Reyna",
      "MiddleName": "Cronin Group",
      "Lastname": "Erdman",
      "SaleStakeholderId": 159,
      "Rank": 473,
      "Phone": "513.233.2146"
    }
  ],
  "ActiveErpLinks": 938,
  "UserDefinedFields": {
    "SuperOffice:1": "1839879651",
    "SuperOffice:2": "Carlie Oberbrunner III"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "nam"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "aperiam"
  },
  "PublishEventDate": "2004-10-31T16:48:30.5789337+01:00",
  "PublishTo": "2012-04-08T16:48:30.5789337+02:00",
  "PublishFrom": "1994-07-01T16:48:30.5789337+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 739,
      "Visibility": "All",
      "DisplayValue": "aut"
    },
    {
      "VisibleId": 739,
      "Visibility": "All",
      "DisplayValue": "aut"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 718,
    "StartDate": "2016-07-19T16:48:30.584935+02:00",
    "EndDate": "2003-11-25T16:48:30.584935+01:00",
    "Type": "BookingForChecklist",
    "Task": "eum",
    "AssociateFullName": "Brigitte Volkman",
    "ContactName": "Donnelly Inc and Sons",
    "Description": "Profit-focused static complexity",
    "PersonFullName": "Faye Ebert",
    "PersonId": 75,
    "ContactId": 997,
    "ProjectId": 391,
    "ProjectName": "Haag Inc and Sons",
    "IsPublished": false,
    "AssociateId": 535,
    "ColorIndex": 976,
    "IsFree": true,
    "HasAlarm": false,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 96,
    "PriorityName": "Mayer, Koelpin and Will",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": false,
    "IsBooking": false,
    "ActiveDate": "1997-12-20T16:48:30.5859334+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2012-09-05T16:48:30.5859334+02:00",
    "RecurringEndDate": "2012-06-22T16:48:30.5859334+02:00",
    "MotherId": 929,
    "AssignedBy": 563,
    "AssignedByFullName": "Camila Jenkins PhD",
    "RejectReason": "",
    "Location": "et",
    "AlarmLeadTime": "facilis",
    "SaleId": 745,
    "SaleName": "Walsh-Denesik",
    "AssociateName": "Orn-Braun",
    "CreatedDate": "2018-11-16T16:48:30.5859334+01:00",
    "CreatedBy": "iure",
    "CreatedByFullName": "Elroy Pollich II",
    "CreatedByAssociateId": 150,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 539
      }
    }
  },
  "Associate": {
    "AssociateId": 194,
    "Name": "O'Keefe LLC",
    "PersonId": 393,
    "Rank": 290,
    "Tooltip": "soluta",
    "Type": "AnonymousAssociate",
    "GroupIdx": 751,
    "FullName": "Mr. Crawford Anderson",
    "FormalName": "Langworth Group",
    "Deleted": true,
    "EjUserId": 485,
    "UserName": "Ondricka LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 254
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 495,
    "Name": "Gislason, Prosacco and Stokes",
    "PersonId": 49,
    "Rank": 467,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 755,
    "FullName": "Paxton Corwin",
    "FormalName": "Johnston-Wyman",
    "Deleted": true,
    "EjUserId": 346,
    "UserName": "Boyer Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 734
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 891,
    "Name": "Swift Group",
    "PersonId": 974,
    "Rank": 723,
    "Tooltip": "eos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 422,
    "FullName": "Graham Towne",
    "FormalName": "Muller, Jones and Lynch",
    "Deleted": false,
    "EjUserId": 764,
    "UserName": "Kiehn-Harris",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 935
      }
    }
  },
  "Contact": {
    "ContactId": 591,
    "Name": "Crona-Schulist",
    "OrgNr": "1311178",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "nesciunt",
    "DirectPhone": "1-864-065-3805",
    "AssociateId": 427,
    "CountryId": 351,
    "EmailAddress": "marcus.leffler@ryan.us",
    "Kananame": "minima",
    "EmailAddressName": "brenna@wunsch.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Terence Ruecker",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "voluptatem",
    "FullName": "Roslyn Bode",
    "IsOwnerContact": false,
    "ActiveErpLinks": 734,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 237
      }
    }
  },
  "Project": {
    "ProjectId": 880,
    "Name": "Ferry-Armstrong",
    "Description": "Multi-tiered needs-based capability",
    "URL": "http://www.example.com/",
    "Type": "impedit",
    "AssociateId": 842,
    "AssociateFullName": "Werner Grady",
    "TypeId": 433,
    "Updated": "2007-04-06T16:48:30.5889223+02:00",
    "StatusId": 902,
    "Status": "libero",
    "TextId": 376,
    "PublishTo": "2014-06-27T16:48:30.5889223+02:00",
    "PublishFrom": "2015-02-11T16:48:30.5889223+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1177040",
    "ActiveErpLinks": 205,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 140
      }
    }
  },
  "SaleText": "dolores",
  "Person": {
    "Position": "quos",
    "PersonId": 397,
    "Mrmrs": "provident",
    "Firstname": "Sister",
    "Lastname": "DuBuque",
    "MiddleName": "Green-Medhurst",
    "Title": "non",
    "Description": "Up-sized contextually-based focus group",
    "Email": "haylie@simonisferry.co.uk",
    "FullName": "Laura Anderson",
    "DirectPhone": "767-236-5530",
    "FormalName": "Torphy-Bartoletti",
    "CountryId": 980,
    "ContactId": 9,
    "ContactName": "Daniel Inc and Sons",
    "Retired": 654,
    "Rank": 207,
    "ActiveInterests": 462,
    "ContactDepartment": "",
    "ContactCountryId": 279,
    "ContactOrgNr": "1798119",
    "FaxPhone": "(727)388-3161 x31783",
    "MobilePhone": "1-517-335-7884 x876",
    "ContactPhone": "1-483-572-7805",
    "AssociateName": "Spinka-Green",
    "AssociateId": 842,
    "UsePersonAddress": false,
    "ContactFax": "numquam",
    "Kanafname": "vel",
    "Kanalname": "dolorem",
    "Post1": "alias",
    "Post2": "totam",
    "Post3": "atque",
    "EmailName": "henry.will@kesslermcdermott.biz",
    "ContactFullName": "Pasquale Gutkowski",
    "ActiveErpLinks": 69,
    "TicketPriorityId": 74,
    "SupportLanguageId": 682,
    "SupportAssociateId": 606,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 545
      }
    }
  },
  "Currency": {
    "Id": 304,
    "Value": "veritatis",
    "Tooltip": "corporis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 939
      }
    }
  },
  "Competitor": {
    "Id": 391,
    "Value": "repellendus",
    "Tooltip": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 572
      }
    }
  },
  "Credited": {
    "Id": 634,
    "Value": "in",
    "Tooltip": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 695
      }
    }
  },
  "Rating": {
    "Id": 744,
    "Value": "natus",
    "Tooltip": "minus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 504
      }
    }
  },
  "Reason": {
    "Id": 788,
    "Value": "neque",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 494
      }
    }
  },
  "Source": {
    "Id": 5,
    "Value": "non",
    "Tooltip": "nam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 907
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2004-11-20T16:48:30.5909392+01:00",
  "Amount": 27008.811999999998,
  "SaleId": 611,
  "Earning": 23172.796,
  "EarningPercent": 12297.815999999999,
  "Heading": "magnam",
  "Number": "975687",
  "Probability": 515,
  "CreatedDate": "2015-04-27T16:48:30.5909392+02:00",
  "UpdatedDate": "2020-10-06T16:48:30.5909392+02:00",
  "Completed": "Completed",
  "ActiveLinks": 560,
  "Links": [
    {
      "EntityName": "Fay Inc and Sons",
      "Id": 411,
      "Description": "Synchronised encompassing project",
      "ExtraInfo": "temporibus",
      "LinkId": 960,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 506
        }
      }
    }
  ],
  "NextDueDate": "2005-08-02T16:48:30.5909392+02:00",
  "Postit": "voluptatem",
  "SaleType": {
    "Id": 98,
    "Value": "dolor",
    "Tooltip": "rerum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 289
      }
    }
  },
  "ReasonSold": {
    "Id": 338,
    "Value": "enim",
    "Tooltip": "ad",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 909
      }
    }
  },
  "ReasonStalled": {
    "Id": 435,
    "Value": "sed",
    "Tooltip": "error",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 652
      }
    }
  },
  "ReopenDate": "2006-08-23T16:48:30.5909392+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Hammes, Rodriguez and Balistreri",
      "Comment": "magnam",
      "StakeholderRoleId": 121,
      "CountryId": 157,
      "PersonId": 391,
      "EmailDescription": "maryam@hauck.ca",
      "EmailId": 7,
      "EmailAddress": "pasquale_parker@pacocha.ca",
      "PhoneId": 140,
      "ContactName": "Beier-Halvorson",
      "ContactId": 299,
      "SaleId": 433,
      "Mrmrs": "similique",
      "Firstname": "Julianne",
      "MiddleName": "Bode Group",
      "Lastname": "McLaughlin",
      "SaleStakeholderId": 986,
      "Rank": 396,
      "Phone": "175.713.5515 x560",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 124
        }
      }
    }
  ],
  "ActiveErpLinks": 150,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Ericka Cartwright"
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "quibusdam",
    "CustomFields2": "voluptate"
  },
  "PublishEventDate": "2006-11-05T16:48:30.5919386+01:00",
  "PublishTo": "2010-08-07T16:48:30.5919386+02:00",
  "PublishFrom": "2020-05-22T16:48:30.5919386+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 381,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 97
        }
      }
    },
    {
      "VisibleId": 381,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 97
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
      "FieldType": "System.String",
      "FieldLength": 445
    }
  }
}
```