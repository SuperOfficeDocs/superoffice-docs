---
title: POST Agents/Project/SaveProjectEntity
uid: v1ProjectAgent_SaveProjectEntity
generated: true
---

# POST Agents/Project/SaveProjectEntity

```http
POST /api/v1/Agents/Project/SaveProjectEntity
```

Updates the existing ProjectEntity or creates a new ProjectEntity if the id parameter is empty








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

The ProjectEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | Integer | Primary key |
| Name | String | Project name |
| ProjectNumber | String | Automatically generated number |
| ProjectMembers | Array | The persons which are members of the project |
| Urls | Array | The project's internet adresses |
| CreatedDate | String | Registered date  in UTC. |
| UpdatedDate | String | Last updated date  in UTC. |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
| HasImage | Boolean | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | String | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for project |
| Links | Array | List of all elements linked to the project |
| ActiveLinks | Integer | Number of active links to documents, other appointments, and such |
| Completed | Boolean | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | String | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | Integer | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | String | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | Integer | The number of active erp links |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | String | Publish event date |
| PublishTo | String | Publication valid to (inclusive) |
| PublishFrom | String | Publication valid from (inclusive) |
| IsPublished | Boolean | Publication is published |

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
POST /api/v1/Agents/Project/SaveProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 93,
  "Name": "Carter, Harris and Graham",
  "ProjectNumber": "981469",
  "ProjectMembers": [
    {
      "ProjectmemberId": 734,
      "ContactId": 43,
      "ProjectId": 590,
      "ContactName": "Streich Inc and Sons",
      "ContactDepartment": "syndicate extensible deliverables",
      "ProjectName": "McKenzie-Jacobi",
      "EmailId": 267,
      "EmailAddress": "annabell@schowaltergerlach.biz",
      "CountryId": 248,
      "Firstname": "Jazmyn",
      "MiddleName": "Hane Inc and Sons",
      "Lastname": "Bins",
      "PersonId": 761,
      "Mrmrs": "quia",
      "ProjectMemberTypeName": "Swift, Metz and Marquardt",
      "Phone": "(134)847-6025",
      "PhoneId": 858,
      "ProjectMemberTypeId": 417,
      "EmailAddressName": "telly@murazik.co.uk",
      "Comment": "ducimus",
      "FullName": "Rachel Welch Sr."
    }
  ],
  "Urls": [
    {
      "Value": "beatae",
      "StrippedValue": "ut",
      "Description": "Versatile 24 hour throughput"
    },
    {
      "Value": "beatae",
      "StrippedValue": "ut",
      "Description": "Versatile 24 hour throughput"
    }
  ],
  "CreatedDate": "2005-10-12T14:13:40.9845983+02:00",
  "UpdatedDate": "2000-02-27T14:13:40.9845983+01:00",
  "Description": "Re-engineered 24 hour neural-net",
  "Postit": "maxime",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Reverse-engineered motivating architecture",
  "ActiveStatusMonitorId": 352,
  "Links": [
    {
      "EntityName": "Wyman-Gutmann",
      "Id": 660,
      "Description": "Fundamental methodical process improvement",
      "ExtraInfo": "perferendis",
      "LinkId": 49
    },
    {
      "EntityName": "Wyman-Gutmann",
      "Id": 660,
      "Description": "Fundamental methodical process improvement",
      "ExtraInfo": "perferendis",
      "LinkId": 49
    }
  ],
  "ActiveLinks": 658,
  "Completed": true,
  "NextMilestoneDate": "2008-01-03T14:13:40.9845983+01:00",
  "NmdAppointmentId": 601,
  "EndDate": "2022-09-28T14:13:40.9845983+02:00",
  "ActiveErpLinks": 694,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Virginie Wendell Raynor",
    "SuperOffice:2": "303615373"
  },
  "ExtraFields": {
    "ExtraFields1": "dicta",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "perspiciatis",
    "CustomFields2": "laboriosam"
  },
  "PublishEventDate": "2004-03-03T14:13:40.9845983+01:00",
  "PublishTo": "2005-06-07T14:13:40.9845983+02:00",
  "PublishFrom": "2018-06-29T14:13:40.9845983+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 20,
  "Name": "Kuhlman-Thiel",
  "ProjectNumber": "882692",
  "ProjectMembers": [
    {
      "ProjectmemberId": 159,
      "ContactId": 275,
      "ProjectId": 872,
      "ContactName": "Orn LLC",
      "ContactDepartment": "",
      "ProjectName": "Brakus-Hayes",
      "EmailId": 632,
      "EmailAddress": "annetta@harveybogisich.us",
      "CountryId": 447,
      "Firstname": "Vivianne",
      "MiddleName": "Funk, Hagenes and Koch",
      "Lastname": "Kertzmann",
      "PersonId": 56,
      "Mrmrs": "quaerat",
      "ProjectMemberTypeName": "Considine LLC",
      "Phone": "605.061.6738 x64120",
      "PhoneId": 486,
      "ProjectMemberTypeId": 648,
      "EmailAddressName": "katelyn@tremblaygerhold.name",
      "Comment": "doloremque",
      "FullName": "Meredith Runte MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 841
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "autem",
      "StrippedValue": "est",
      "Description": "Programmable clear-thinking data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 606
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "est",
      "Description": "Programmable clear-thinking data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 606
        }
      }
    }
  ],
  "CreatedDate": "2002-02-07T14:13:40.9845983+01:00",
  "UpdatedDate": "2023-01-29T14:13:40.9845983+01:00",
  "Description": "Synergized exuding customer loyalty",
  "Postit": "aliquam",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Distributed grid-enabled interface",
  "ActiveStatusMonitorId": 367,
  "Links": [
    {
      "EntityName": "Mann Group",
      "Id": 150,
      "Description": "Multi-tiered human-resource solution",
      "ExtraInfo": "aut",
      "LinkId": 679,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 463
        }
      }
    }
  ],
  "ActiveLinks": 937,
  "Completed": true,
  "NextMilestoneDate": "2016-09-27T14:13:41.0002198+02:00",
  "NmdAppointmentId": 348,
  "EndDate": "2008-09-25T14:13:41.0002198+02:00",
  "ActiveErpLinks": 920,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Dr. Garnet Kozey"
  },
  "ExtraFields": {
    "ExtraFields1": "sint",
    "ExtraFields2": "fugiat"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "omnis"
  },
  "PublishEventDate": "2021-09-30T14:13:41.0002198+02:00",
  "PublishTo": "2022-01-07T14:13:41.0002198+01:00",
  "PublishFrom": "2000-10-28T14:13:41.0002198+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 951
    }
  }
}
```