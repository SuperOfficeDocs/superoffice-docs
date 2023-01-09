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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/Project/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 27 Aug 2016 17:37:38 G8T

{
  "ProjectId": 777,
  "Name": "Cartwright, Rempel and Wisoky",
  "ProjectNumber": "1390529",
  "ProjectMembers": [
    {
      "ProjectmemberId": 826,
      "ContactId": 179,
      "ProjectId": 268,
      "ContactName": "Grant, Goyette and Ledner",
      "ContactDepartment": "",
      "ProjectName": "Aufderhar Inc and Sons",
      "EmailId": 590,
      "EmailAddress": "carmel_orn@gibson.com",
      "CountryId": 19,
      "Firstname": "Hyman",
      "MiddleName": "Wilderman, Rosenbaum and Becker",
      "Lastname": "Langworth",
      "PersonId": 803,
      "Mrmrs": "labore",
      "ProjectMemberTypeName": "Zboncak-Friesen",
      "Phone": "1-239-492-3502",
      "PhoneId": 965,
      "ProjectMemberTypeId": 104,
      "EmailAddressName": "warren_schmeler@beerreynolds.com",
      "Comment": "magni",
      "FullName": "Dr. Elinore Labadie",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 192
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sunt",
      "StrippedValue": "dolor",
      "Description": "Compatible composite capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 854
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "dolor",
      "Description": "Compatible composite capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 854
        }
      }
    }
  ],
  "CreatedDate": "2011-07-05T17:37:38.972274+02:00",
  "UpdatedDate": "2016-08-27T17:37:38.972274+02:00",
  "Description": "Reactive non-volatile interface",
  "Postit": "ratione",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Compatible didactic matrices",
  "ActiveStatusMonitorId": 586,
  "Links": [
    {
      "EntityName": "Becker, Zieme and Bogisich",
      "Id": 666,
      "Description": "Future-proofed maximized instruction set",
      "ExtraInfo": "eaque",
      "LinkId": 757,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 450
        }
      }
    }
  ],
  "ActiveLinks": 228,
  "Completed": false,
  "NextMilestoneDate": "2015-10-16T17:37:38.9743033+02:00",
  "NmdAppointmentId": 882,
  "EndDate": "2021-01-16T17:37:38.9743033+01:00",
  "ActiveErpLinks": 537,
  "UserDefinedFields": {
    "SuperOffice:1": "Sammy Kunze",
    "SuperOffice:2": "Ms. Miracle Caitlyn Halvorson I"
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "explicabo",
    "CustomFields2": "ad"
  },
  "PublishEventDate": "2006-10-18T17:37:38.9753032+02:00",
  "PublishTo": "2008-01-30T17:37:38.9753032+01:00",
  "PublishFrom": "2001-10-18T17:37:38.9753032+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 32
    }
  }
}
```