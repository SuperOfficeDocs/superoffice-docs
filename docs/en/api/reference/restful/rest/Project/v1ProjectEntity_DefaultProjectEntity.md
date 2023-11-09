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
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/Project/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sun, 16 Jan 2022 11:06:42 G1T

{
  "ProjectId": 298,
  "Name": "Hirthe, West and Armstrong",
  "ProjectNumber": "1075511",
  "ProjectMembers": [
    {
      "ProjectmemberId": 454,
      "ContactId": 466,
      "ProjectId": 760,
      "ContactName": "Nikolaus-Hackett",
      "ContactDepartment": "",
      "ProjectName": "Waters-Homenick",
      "EmailId": 533,
      "EmailAddress": "alfreda@kilbackdach.com",
      "CountryId": 207,
      "Firstname": "Dorothy",
      "MiddleName": "Prohaska, Macejkovic and Kozey",
      "Lastname": "Schaden",
      "PersonId": 184,
      "Mrmrs": "recusandae",
      "ProjectMemberTypeName": "Streich, Weimann and Wehner",
      "Phone": "(276)299-9864 x11403",
      "PhoneId": 320,
      "ProjectMemberTypeId": 195,
      "EmailAddressName": "augusta.bernier@connelly.name",
      "Comment": "hic",
      "FullName": "Emilie Cummings IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 196
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "accusantium",
      "StrippedValue": "magni",
      "Description": "Organized clear-thinking adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 416
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "magni",
      "Description": "Organized clear-thinking adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 416
        }
      }
    }
  ],
  "CreatedDate": "2009-12-23T11:06:42.0197245+01:00",
  "UpdatedDate": "2022-01-16T11:06:42.0197245+01:00",
  "Description": "Distributed intangible contingency",
  "Postit": "consequatur",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Cross-group fault-tolerant contingency",
  "ActiveStatusMonitorId": 702,
  "Links": [
    {
      "EntityName": "Maggio-Batz",
      "Id": 436,
      "Description": "De-engineered needs-based leverage",
      "ExtraInfo": "nam",
      "LinkId": 766,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 850
        }
      }
    }
  ],
  "ActiveLinks": 967,
  "Completed": true,
  "NextMilestoneDate": "2007-06-11T11:06:42.0197245+02:00",
  "NmdAppointmentId": 425,
  "EndDate": "2007-10-30T11:06:42.0197245+01:00",
  "ActiveErpLinks": 165,
  "UserDefinedFields": {
    "SuperOffice:1": "Marvin Keebler",
    "SuperOffice:2": "Coby Kuvalis"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "dolorum"
  },
  "CustomFields": {
    "CustomFields1": "soluta",
    "CustomFields2": "alias"
  },
  "PublishEventDate": "2001-08-29T11:06:42.0197245+02:00",
  "PublishTo": "2000-02-05T11:06:42.0197245+01:00",
  "PublishFrom": "2020-11-29T11:06:42.0197245+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 922
    }
  }
}
```