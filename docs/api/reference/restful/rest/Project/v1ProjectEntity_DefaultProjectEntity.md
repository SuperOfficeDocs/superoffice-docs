---
title: GET Project/default
uid: v1ProjectEntity_DefaultProjectEntity
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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

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
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/Project/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 30 Apr 1999 11:10:53 G4T

{
  "ProjectId": 373,
  "Name": "Vandervort, Eichmann and Mayer",
  "ProjectNumber": "1009379",
  "ProjectMembers": [
    {
      "ProjectmemberId": 28,
      "ContactId": 980,
      "ProjectId": 263,
      "ContactName": "Schimmel LLC",
      "ContactDepartment": "optimize seamless web services",
      "ProjectName": "Klein Inc and Sons",
      "EmailId": 736,
      "EmailAddress": "vilma@stanton.uk",
      "CountryId": 855,
      "Firstname": "Jaylan",
      "MiddleName": "Greenfelder-Purdy",
      "Lastname": "Gutmann",
      "PersonId": 55,
      "Mrmrs": "quas",
      "ProjectMemberTypeName": "Feil, Lebsack and Harris",
      "Phone": "(374)650-3808",
      "PhoneId": 800,
      "ProjectMemberTypeId": 388,
      "EmailAddressName": "katlyn.durgan@thompsonhowell.us",
      "Comment": "et",
      "FullName": "Jannie Smitham",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 250
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "voluptas",
      "Description": "Up-sized holistic archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 125
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "voluptas",
      "Description": "Up-sized holistic archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 125
        }
      }
    }
  ],
  "CreatedDate": "2020-11-04T11:10:53.2681637+01:00",
  "UpdatedDate": "1999-04-30T11:10:53.2681637+02:00",
  "Description": "Monitored dedicated attitude",
  "Postit": "delectus",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Synergistic dynamic help-desk",
  "ActiveStatusMonitorId": 718,
  "Links": [
    {
      "EntityName": "Durgan, Rogahn and Kshlerin",
      "Id": 880,
      "Description": "Advanced directional service-desk",
      "ExtraInfo": "impedit",
      "LinkId": 936,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 420
        }
      }
    }
  ],
  "ActiveLinks": 266,
  "Completed": true,
  "NextMilestoneDate": "1999-09-01T11:10:53.27018+02:00",
  "NmdAppointmentId": 501,
  "EndDate": "2013-11-23T11:10:53.27018+01:00",
  "ActiveErpLinks": 684,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Kane Neal Schuster I",
    "SuperOffice:2": "Deja Gerhold"
  },
  "ExtraFields": {
    "ExtraFields1": "eligendi",
    "ExtraFields2": "nisi"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "provident"
  },
  "PublishEventDate": "1997-08-17T11:10:53.27018+02:00",
  "PublishTo": "2005-10-25T11:10:53.27018+02:00",
  "PublishFrom": "2016-06-06T11:10:53.27018+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 620
    }
  }
}
```
