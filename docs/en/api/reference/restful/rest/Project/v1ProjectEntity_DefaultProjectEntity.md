---
title: GET Project/default
uid: v1ProjectEntity_DefaultProjectEntity
generated: true
---

# GET Project/default

```http
GET /api/v1/Project/default
```

Set default values into a new ProjectEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Project agent service CreateDefaultProjectEntity.







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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ProjectEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| ProjectNumber | string | Automatically generated number |
| ProjectMembers | array | The persons which are members of the project |
| Urls | array | The project's internet adresses |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated date  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  Use MDO List name "associate" to get list items. |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  Use MDO List name "projectstatus" to get list items. |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  Use MDO List name "projecttype" to get list items. |
| HasImage | bool | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | string | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for project |
| Links | array | List of all elements linked to the project |
| ActiveLinks | int32 | Number of active links to documents, other appointments, and such |
| Completed | bool | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | date-time | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | int32 | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | date-time | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/Project/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 06 Oct 1999 16:55:29 G10T

{
  "ProjectId": 219,
  "Name": "Aufderhar, Yundt and Kuphal",
  "ProjectNumber": "1428291",
  "ProjectMembers": [
    {
      "ProjectmemberId": 310,
      "ContactId": 719,
      "ProjectId": 193,
      "ContactName": "Satterfield-Dooley",
      "ContactDepartment": "",
      "ProjectName": "White Inc and Sons",
      "EmailId": 177,
      "EmailAddress": "kellie_windler@haleytorp.biz",
      "CountryId": 499,
      "Firstname": "Marisa",
      "MiddleName": "Spencer-Spinka",
      "Lastname": "Carter",
      "PersonId": 454,
      "Mrmrs": "perferendis",
      "ProjectMemberTypeName": "Dicki, Fay and Mertz",
      "Phone": "555.291.0773 x82623",
      "PhoneId": 601,
      "ProjectMemberTypeId": 924,
      "EmailAddressName": "frankie.funk@davishahn.com",
      "Comment": "iure",
      "FullName": "Wava Mohr",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 680
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "praesentium",
      "Description": "Universal leading edge migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 950
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "praesentium",
      "Description": "Universal leading edge migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 950
        }
      }
    }
  ],
  "CreatedDate": "2003-11-15T16:55:29.9236289+01:00",
  "UpdatedDate": "1999-10-06T16:55:29.9236289+02:00",
  "Description": "Pre-emptive multi-tasking Graphic Interface",
  "Postit": "eligendi",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Open-source zero tolerance data-warehouse",
  "ActiveStatusMonitorId": 488,
  "Links": [
    {
      "EntityName": "Treutel Inc and Sons",
      "Id": 605,
      "Description": "Reactive discrete model",
      "ExtraInfo": "accusantium",
      "LinkId": 843,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 823
        }
      }
    }
  ],
  "ActiveLinks": 257,
  "Completed": true,
  "NextMilestoneDate": "2014-08-06T16:55:29.9245185+02:00",
  "NmdAppointmentId": 207,
  "EndDate": "2021-11-16T16:55:29.9245185+01:00",
  "ActiveErpLinks": 707,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Courtney Nitzsche"
  },
  "ExtraFields": {
    "ExtraFields1": "vero",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "dolor",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2006-02-02T16:55:29.9245185+01:00",
  "PublishTo": "2015-02-09T16:55:29.9245185+01:00",
  "PublishFrom": "2007-10-30T16:55:29.9245185+01:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 419
    }
  }
}
```