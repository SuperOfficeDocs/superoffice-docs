---
title: POST Sale
id: v1SaleEntity_PostSaleEntity
---

# POST Sale

```http
POST /api/v1/Sale
```

Creates a new SaleEntity

Calls the Sale agent service SaveSaleEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Sale?$select=name,department,category/id
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

## Request Body: newEntity  

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

The Sale Entity contains the sale amount, currency, and sale members. Sales are linked to contacts, persons, and/or projects.



SaleEntity entity with API _Links added.

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
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/Sale
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 977,
    "StartDate": "2010-10-08T09:40:59.5456923+02:00",
    "EndDate": "2016-12-14T09:40:59.5456923+01:00",
    "Type": "BookingForChecklist",
    "Task": "et",
    "AssociateFullName": "Ardella Lang",
    "ContactName": "Hilpert Inc and Sons",
    "Description": "Ergonomic next generation migration",
    "PersonFullName": "Jewell Dicki",
    "PersonId": 7,
    "ContactId": 643,
    "ProjectId": 526,
    "ProjectName": "Stiedemann Group",
    "IsPublished": false,
    "AssociateId": 148,
    "ColorIndex": 982,
    "IsFree": false,
    "HasAlarm": false,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 598,
    "PriorityName": "Reinger Inc and Sons",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": true,
    "IsBooking": false,
    "ActiveDate": "2015-01-22T09:40:59.5456923+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "1998-04-08T09:40:59.5456923+02:00",
    "RecurringEndDate": "2002-01-27T09:40:59.5456923+01:00",
    "MotherId": 878,
    "AssignedBy": 943,
    "AssignedByFullName": "Justen Nitzsche",
    "RejectReason": "",
    "Location": "rerum",
    "AlarmLeadTime": "cupiditate",
    "SaleId": 219,
    "SaleName": "Wilderman Inc and Sons",
    "AssociateName": "Feeney-Heathcote",
    "CreatedDate": "2013-02-03T09:40:59.5456923+01:00",
    "CreatedBy": "quasi",
    "CreatedByFullName": "Helene Zulauf",
    "CreatedByAssociateId": 492,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/"
  },
  "Associate": {
    "AssociateId": 196,
    "Name": "Gleason, Larson and Hyatt",
    "PersonId": 261,
    "Rank": 202,
    "Tooltip": "ducimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 888,
    "FullName": "Lourdes Haag",
    "FormalName": "Dickinson Group",
    "Deleted": true,
    "EjUserId": 105,
    "UserName": "Corkery-Baumbach"
  },
  "UpdatedBy": {
    "AssociateId": 967,
    "Name": "Russel, Johnson and Gusikowski",
    "PersonId": 963,
    "Rank": 771,
    "Tooltip": "blanditiis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 963,
    "FullName": "Isabelle Paucek V",
    "FormalName": "Jerde-Gislason",
    "Deleted": true,
    "EjUserId": 167,
    "UserName": "Crona-Rohan"
  },
  "CreatedBy": {
    "AssociateId": 843,
    "Name": "Zboncak, Nitzsche and Terry",
    "PersonId": 675,
    "Rank": 943,
    "Tooltip": "pariatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 153,
    "FullName": "Juston Rogahn",
    "FormalName": "Williamson, Ferry and Bradtke",
    "Deleted": true,
    "EjUserId": 650,
    "UserName": "Kautzer, Jones and Stokes"
  },
  "Contact": {
    "ContactId": 450,
    "Name": "Krajcik-Bergstrom",
    "OrgNr": "1461831",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "consequatur",
    "DirectPhone": "862.284.4010 x27053",
    "AssociateId": 308,
    "CountryId": 779,
    "EmailAddress": "dedric@schoenjenkins.us",
    "Kananame": "adipisci",
    "EmailAddressName": "cleora@bednar.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ms. Rebeka Gibson",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "et",
    "FullName": "Newton Collier PhD",
    "IsOwnerContact": true,
    "ActiveErpLinks": 388
  },
  "Project": {
    "ProjectId": 567,
    "Name": "Medhurst-Stoltenberg",
    "Description": "Pre-emptive intangible software",
    "URL": "http://www.example.com/",
    "Type": "exercitationem",
    "AssociateId": 302,
    "AssociateFullName": "Josephine Keebler I",
    "TypeId": 124,
    "Updated": "2003-08-14T09:40:59.5496911+02:00",
    "StatusId": 317,
    "Status": "asperiores",
    "TextId": 885,
    "PublishTo": "1997-12-31T09:40:59.5496911+01:00",
    "PublishFrom": "2002-07-30T09:40:59.5496911+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1285758",
    "ActiveErpLinks": 177
  },
  "SaleText": "vero",
  "Person": {
    "Position": "quos",
    "PersonId": 375,
    "Mrmrs": "explicabo",
    "Firstname": "Sonny",
    "Lastname": "Maggio",
    "MiddleName": "O'Keefe-Harris",
    "Title": "cupiditate",
    "Description": "Innovative didactic firmware",
    "Email": "freda.simonis@schmelermaggio.uk",
    "FullName": "Stephen Kemmer",
    "DirectPhone": "1-760-047-8078 x234",
    "FormalName": "Kuvalis-Yundt",
    "CountryId": 984,
    "ContactId": 391,
    "ContactName": "Kuphal-Marquardt",
    "Retired": 363,
    "Rank": 159,
    "ActiveInterests": 125,
    "ContactDepartment": "",
    "ContactCountryId": 347,
    "ContactOrgNr": "249074",
    "FaxPhone": "(070)536-8427",
    "MobilePhone": "314-707-2725 x4038",
    "ContactPhone": "458.506.8660 x26185",
    "AssociateName": "Ratke-Medhurst",
    "AssociateId": 826,
    "UsePersonAddress": true,
    "ContactFax": "nulla",
    "Kanafname": "accusantium",
    "Kanalname": "illo",
    "Post1": "omnis",
    "Post2": "animi",
    "Post3": "culpa",
    "EmailName": "glenda.hegmann@pricepfeffer.name",
    "ContactFullName": "Ivah Runte",
    "ActiveErpLinks": 731,
    "TicketPriorityId": 839,
    "SupportLanguageId": 112,
    "SupportAssociateId": 116,
    "CategoryName": "VIP Customer"
  },
  "Currency": {
    "Id": 911,
    "Value": "eos",
    "Tooltip": "excepturi"
  },
  "Competitor": {
    "Id": 608,
    "Value": "est",
    "Tooltip": "dolor"
  },
  "Credited": {
    "Id": 956,
    "Value": "illo",
    "Tooltip": "ipsum"
  },
  "Rating": {
    "Id": 52,
    "Value": "minima",
    "Tooltip": "ipsa"
  },
  "Reason": {
    "Id": 786,
    "Value": "aliquam",
    "Tooltip": "perferendis"
  },
  "Source": {
    "Id": 907,
    "Value": "est",
    "Tooltip": "beatae"
  },
  "Status": "Lost",
  "Saledate": "2016-01-07T09:40:59.5506914+01:00",
  "Amount": 15980.266,
  "SaleId": 939,
  "Earning": 13623.498,
  "EarningPercent": 2234.542,
  "Heading": "eos",
  "Number": "1229943",
  "Probability": 899,
  "CreatedDate": "1999-10-01T09:40:59.5506914+02:00",
  "UpdatedDate": "2008-02-04T09:40:59.5506914+01:00",
  "Completed": "Completed",
  "ActiveLinks": 615,
  "Links": [
    {
      "EntityName": "Nader, Murazik and Green",
      "Id": 403,
      "Description": "Pre-emptive heuristic capacity",
      "ExtraInfo": "sit",
      "LinkId": 130
    },
    {
      "EntityName": "Nader, Murazik and Green",
      "Id": 403,
      "Description": "Pre-emptive heuristic capacity",
      "ExtraInfo": "sit",
      "LinkId": 130
    }
  ],
  "NextDueDate": "2009-04-22T09:40:59.5506914+02:00",
  "Postit": "quisquam",
  "SaleType": {
    "Id": 609,
    "Value": "dolor",
    "Tooltip": "animi"
  },
  "ReasonSold": {
    "Id": 532,
    "Value": "odio",
    "Tooltip": "ut"
  },
  "ReasonStalled": {
    "Id": 100,
    "Value": "veniam",
    "Tooltip": "nihil"
  },
  "ReopenDate": "2017-04-16T09:40:59.5516913+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Gusikowski Inc and Sons",
      "Comment": "voluptatem",
      "StakeholderRoleId": 273,
      "CountryId": 234,
      "PersonId": 358,
      "EmailDescription": "jacklyn.bartoletti@moengutmann.biz",
      "EmailId": 310,
      "EmailAddress": "lysanne@raynor.name",
      "PhoneId": 639,
      "ContactName": "Hahn, Larkin and Reichert",
      "ContactId": 194,
      "SaleId": 930,
      "Mrmrs": "molestiae",
      "Firstname": "Issac",
      "MiddleName": "Harber, Shields and Hegmann",
      "Lastname": "Anderson",
      "SaleStakeholderId": 459,
      "Rank": 337,
      "Phone": "1-711-268-4541 x134"
    }
  ],
  "ActiveErpLinks": 427,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "2045355469"
  },
  "ExtraFields": {
    "ExtraFields1": "molestias",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "sint"
  },
  "PublishEventDate": "2013-08-27T09:40:59.5516913+02:00",
  "PublishTo": "2008-02-24T09:40:59.5516913+01:00",
  "PublishFrom": "2013-04-30T09:40:59.5516913+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 684,
      "Visibility": "All",
      "DisplayValue": "eveniet"
    },
    {
      "VisibleId": 684,
      "Visibility": "All",
      "DisplayValue": "eveniet"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 243,
    "StartDate": "2020-07-11T09:40:59.5936911+02:00",
    "EndDate": "2012-01-07T09:40:59.5936911+01:00",
    "Type": "BookingForChecklist",
    "Task": "doloremque",
    "AssociateFullName": "Dr. Zackary Mayer",
    "ContactName": "Kirlin, Schimmel and Feest",
    "Description": "Synergized bandwidth-monitored complexity",
    "PersonFullName": "Rhett Torphy",
    "PersonId": 837,
    "ContactId": 956,
    "ProjectId": 398,
    "ProjectName": "Waelchi, Schulist and Emmerich",
    "IsPublished": false,
    "AssociateId": 182,
    "ColorIndex": 125,
    "IsFree": false,
    "HasAlarm": true,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 151,
    "PriorityName": "Hettinger-Casper",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": true,
    "IsBooking": false,
    "ActiveDate": "1998-07-05T09:40:59.594692+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2010-02-18T09:40:59.594692+01:00",
    "RecurringEndDate": "1995-06-02T09:40:59.594692+02:00",
    "MotherId": 316,
    "AssignedBy": 50,
    "AssignedByFullName": "Raoul Hand",
    "RejectReason": "",
    "Location": "nam",
    "AlarmLeadTime": "numquam",
    "SaleId": 814,
    "SaleName": "Osinski-Strosin",
    "AssociateName": "Kulas, Gulgowski and Rutherford",
    "CreatedDate": "2018-11-13T09:40:59.594692+01:00",
    "CreatedBy": "possimus",
    "CreatedByFullName": "Mr. Rene Morissette",
    "CreatedByAssociateId": 120,
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
        "FieldLength": 16
      }
    }
  },
  "Associate": {
    "AssociateId": 230,
    "Name": "Feil Group",
    "PersonId": 680,
    "Rank": 81,
    "Tooltip": "optio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 823,
    "FullName": "Osborne Ankunding",
    "FormalName": "Paucek Inc and Sons",
    "Deleted": false,
    "EjUserId": 548,
    "UserName": "Schinner-Bailey",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 242
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 874,
    "Name": "Dietrich-DuBuque",
    "PersonId": 164,
    "Rank": 631,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 585,
    "FullName": "Howell Beier",
    "FormalName": "Jerde Group",
    "Deleted": true,
    "EjUserId": 226,
    "UserName": "Beer-Greenfelder",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 76
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 165,
    "Name": "Bruen-Barrows",
    "PersonId": 991,
    "Rank": 327,
    "Tooltip": "ab",
    "Type": "AnonymousAssociate",
    "GroupIdx": 808,
    "FullName": "Burley Kuhlman",
    "FormalName": "Dicki, Parisian and Gibson",
    "Deleted": false,
    "EjUserId": 611,
    "UserName": "Mohr Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "generate collaborative bandwidth"
        },
        "FieldType": "System.Int32",
        "FieldLength": 131
      }
    }
  },
  "Contact": {
    "ContactId": 949,
    "Name": "Swift, Gibson and Christiansen",
    "OrgNr": "1174282",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "non",
    "DirectPhone": "(234)377-5433",
    "AssociateId": 31,
    "CountryId": 351,
    "EmailAddress": "maymie@gibsonblock.name",
    "Kananame": "ipsa",
    "EmailAddressName": "olga_mraz@prohaska.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Aglae Rutherford",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "animi",
    "FullName": "Thurman Fadel",
    "IsOwnerContact": true,
    "ActiveErpLinks": 11,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 155
      }
    }
  },
  "Project": {
    "ProjectId": 968,
    "Name": "VonRueden, Herzog and Stehr",
    "Description": "Organic multi-tasking policy",
    "URL": "http://www.example.com/",
    "Type": "repudiandae",
    "AssociateId": 300,
    "AssociateFullName": "Leone Lehner IV",
    "TypeId": 872,
    "Updated": "2013-11-17T09:40:59.5966952+01:00",
    "StatusId": 139,
    "Status": "tempora",
    "TextId": 826,
    "PublishTo": "2010-05-31T09:40:59.5966952+02:00",
    "PublishFrom": "2004-09-12T09:40:59.5966952+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1417798",
    "ActiveErpLinks": 779,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 716
      }
    }
  },
  "SaleText": "soluta",
  "Person": {
    "Position": "aut",
    "PersonId": 171,
    "Mrmrs": "id",
    "Firstname": "Rosetta",
    "Lastname": "Hammes",
    "MiddleName": "Wintheiser, Waelchi and Stokes",
    "Title": "et",
    "Description": "Reduced fault-tolerant process improvement",
    "Email": "nakia.boyle@harber.com",
    "FullName": "Leonora Denesik",
    "DirectPhone": "370.114.1621 x4254",
    "FormalName": "Kozey, Roberts and Ryan",
    "CountryId": 319,
    "ContactId": 929,
    "ContactName": "Kris-Halvorson",
    "Retired": 331,
    "Rank": 575,
    "ActiveInterests": 64,
    "ContactDepartment": "",
    "ContactCountryId": 165,
    "ContactOrgNr": "255478",
    "FaxPhone": "154-208-5385",
    "MobilePhone": "(431)745-4037 x2238",
    "ContactPhone": "650.884.2135 x026",
    "AssociateName": "Boehm-Kemmer",
    "AssociateId": 374,
    "UsePersonAddress": true,
    "ContactFax": "perferendis",
    "Kanafname": "quia",
    "Kanalname": "sunt",
    "Post1": "eligendi",
    "Post2": "et",
    "Post3": "eum",
    "EmailName": "brooklyn@leannondooley.co.uk",
    "ContactFullName": "Abe Osinski",
    "ActiveErpLinks": 173,
    "TicketPriorityId": 197,
    "SupportLanguageId": 243,
    "SupportAssociateId": 803,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 699
      }
    }
  },
  "Currency": {
    "Id": 518,
    "Value": "qui",
    "Tooltip": "tenetur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 575
      }
    }
  },
  "Competitor": {
    "Id": 905,
    "Value": "alias",
    "Tooltip": "ex",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 219
      }
    }
  },
  "Credited": {
    "Id": 932,
    "Value": "magnam",
    "Tooltip": "quae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 552
      }
    }
  },
  "Rating": {
    "Id": 820,
    "Value": "voluptatem",
    "Tooltip": "sequi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 296
      }
    }
  },
  "Reason": {
    "Id": 699,
    "Value": "qui",
    "Tooltip": "velit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 767
      }
    }
  },
  "Source": {
    "Id": 3,
    "Value": "illum",
    "Tooltip": "voluptatem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 444
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2017-07-07T09:40:59.5986921+02:00",
  "Amount": 8584.026,
  "SaleId": 286,
  "Earning": 17309.082,
  "EarningPercent": 10194.902,
  "Heading": "odit",
  "Number": "1164192",
  "Probability": 411,
  "CreatedDate": "2011-09-29T09:40:59.5986921+02:00",
  "UpdatedDate": "2009-10-01T09:40:59.5986921+02:00",
  "Completed": "Completed",
  "ActiveLinks": 733,
  "Links": [
    {
      "EntityName": "Gottlieb-O'Reilly",
      "Id": 766,
      "Description": "Multi-lateral hybrid focus group",
      "ExtraInfo": "repudiandae",
      "LinkId": 405,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 282
        }
      }
    }
  ],
  "NextDueDate": "2009-02-12T09:40:59.5986921+01:00",
  "Postit": "atque",
  "SaleType": {
    "Id": 669,
    "Value": "unde",
    "Tooltip": "voluptatem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 343
      }
    }
  },
  "ReasonSold": {
    "Id": 306,
    "Value": "quis",
    "Tooltip": "quam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "evolve e-business methodologies"
        },
        "FieldType": "System.String",
        "FieldLength": 248
      }
    }
  },
  "ReasonStalled": {
    "Id": 24,
    "Value": "aut",
    "Tooltip": "ea",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 393
      }
    }
  },
  "ReopenDate": "1998-08-05T09:40:59.5986921+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Cronin-Walsh",
      "Comment": "minima",
      "StakeholderRoleId": 717,
      "CountryId": 246,
      "PersonId": 343,
      "EmailDescription": "else_casper@heidenreich.com",
      "EmailId": 986,
      "EmailAddress": "anne_braun@lemkefeil.biz",
      "PhoneId": 202,
      "ContactName": "Breitenberg-Olson",
      "ContactId": 534,
      "SaleId": 174,
      "Mrmrs": "hic",
      "Firstname": "Jasper",
      "MiddleName": "Effertz-Schinner",
      "Lastname": "Ritchie",
      "SaleStakeholderId": 305,
      "Rank": 434,
      "Phone": "712-586-6818 x30660",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 79
        }
      }
    }
  ],
  "ActiveErpLinks": 270,
  "UserDefinedFields": {
    "SuperOffice:1": "Brielle Morissette",
    "SuperOffice:2": "Cesar Huels"
  },
  "ExtraFields": {
    "ExtraFields1": "atque",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "nisi",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2000-10-22T09:40:59.6006625+02:00",
  "PublishTo": "2008-09-11T09:40:59.6006625+02:00",
  "PublishFrom": "2002-03-19T09:40:59.6006625+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 498,
      "Visibility": "All",
      "DisplayValue": "reiciendis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 587
        }
      }
    },
    {
      "VisibleId": 498,
      "Visibility": "All",
      "DisplayValue": "reiciendis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 587
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
        "Reason": "repurpose strategic users"
      },
      "FieldType": "System.Int32",
      "FieldLength": 993
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```