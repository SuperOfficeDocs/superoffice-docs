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
  "ProjectId": 179,
  "Name": "Shields-Howe",
  "ProjectNumber": "611732",
  "ProjectMembers": [
    {
      "ProjectmemberId": 30,
      "ContactId": 522,
      "ProjectId": 904,
      "ContactName": "Ondricka-Kohler",
      "ContactDepartment": "",
      "ProjectName": "Beahan, Walker and Gulgowski",
      "EmailId": 693,
      "EmailAddress": "felix_veum@auer.name",
      "CountryId": 604,
      "Firstname": "Greyson",
      "MiddleName": "Robel Group",
      "Lastname": "Spencer",
      "PersonId": 325,
      "Mrmrs": "aliquam",
      "ProjectMemberTypeName": "Johnson Group",
      "Phone": "1-385-381-4837",
      "PhoneId": 550,
      "ProjectMemberTypeId": 607,
      "EmailAddressName": "jerel_kiehn@rooblegros.co.uk",
      "Comment": "quia",
      "FullName": "Archibald Borer"
    }
  ],
  "Urls": [
    {
      "Value": "odit",
      "StrippedValue": "voluptas",
      "Description": "Decentralized exuding initiative"
    },
    {
      "Value": "odit",
      "StrippedValue": "voluptas",
      "Description": "Decentralized exuding initiative"
    }
  ],
  "CreatedDate": "1999-08-18T03:45:23.7641958+02:00",
  "UpdatedDate": "2016-07-31T03:45:23.7641958+02:00",
  "Description": "Up-sized discrete synergy",
  "Postit": "dignissimos",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Diverse object-oriented utilisation",
  "ActiveStatusMonitorId": 806,
  "Links": [
    {
      "EntityName": "Considine, Schumm and Weimann",
      "Id": 439,
      "Description": "Secured intangible capability",
      "ExtraInfo": "nihil",
      "LinkId": 161
    },
    {
      "EntityName": "Considine, Schumm and Weimann",
      "Id": 439,
      "Description": "Secured intangible capability",
      "ExtraInfo": "nihil",
      "LinkId": 161
    }
  ],
  "ActiveLinks": 90,
  "Completed": false,
  "NextMilestoneDate": "2012-02-06T03:45:23.7641958+01:00",
  "NmdAppointmentId": 143,
  "EndDate": "2005-03-28T03:45:23.7641958+02:00",
  "ActiveErpLinks": 494,
  "UserDefinedFields": {
    "SuperOffice:1": "936370133",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "porro"
  },
  "PublishEventDate": "2014-05-03T03:45:23.7641958+02:00",
  "PublishTo": "2017-10-13T03:45:23.7641958+02:00",
  "PublishFrom": "1999-04-20T03:45:23.7641958+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 670,
  "Name": "Hilpert-Monahan",
  "ProjectNumber": "1886157",
  "ProjectMembers": [
    {
      "ProjectmemberId": 602,
      "ContactId": 868,
      "ProjectId": 714,
      "ContactName": "Weimann-Yundt",
      "ContactDepartment": "",
      "ProjectName": "Collins, Klocko and Keebler",
      "EmailId": 684,
      "EmailAddress": "luigi@hickletremblay.co.uk",
      "CountryId": 496,
      "Firstname": "Hubert",
      "MiddleName": "Haley, Smith and Durgan",
      "Lastname": "Price",
      "PersonId": 895,
      "Mrmrs": "omnis",
      "ProjectMemberTypeName": "Hodkiewicz, Bailey and Wuckert",
      "Phone": "305-589-3733 x43082",
      "PhoneId": 731,
      "ProjectMemberTypeId": 58,
      "EmailAddressName": "daren.wisoky@lindgren.us",
      "Comment": "nihil",
      "FullName": "Adrienne Reichel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 942
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "totam",
      "StrippedValue": "eum",
      "Description": "Synergistic real-time productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 738
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "eum",
      "Description": "Synergistic real-time productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 738
        }
      }
    }
  ],
  "CreatedDate": "1998-02-23T03:45:23.7641958+01:00",
  "UpdatedDate": "2017-08-26T03:45:23.7641958+02:00",
  "Description": "Inverse eco-centric support",
  "Postit": "earum",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Inverse intermediate task-force",
  "ActiveStatusMonitorId": 791,
  "Links": [
    {
      "EntityName": "White Inc and Sons",
      "Id": 13,
      "Description": "Optional next generation core",
      "ExtraInfo": "animi",
      "LinkId": 130,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 896
        }
      }
    }
  ],
  "ActiveLinks": 313,
  "Completed": true,
  "NextMilestoneDate": "2011-11-06T03:45:23.7641958+01:00",
  "NmdAppointmentId": 822,
  "EndDate": "2010-07-02T03:45:23.7641958+02:00",
  "ActiveErpLinks": 868,
  "UserDefinedFields": {
    "SuperOffice:1": "1301841334",
    "SuperOffice:2": "Mrs. Gavin Botsford IV"
  },
  "ExtraFields": {
    "ExtraFields1": "nemo",
    "ExtraFields2": "ipsa"
  },
  "CustomFields": {
    "CustomFields1": "libero",
    "CustomFields2": "corporis"
  },
  "PublishEventDate": "2025-06-22T03:45:23.7641958+02:00",
  "PublishTo": "2024-09-19T03:45:23.7641958+02:00",
  "PublishFrom": "1998-12-01T03:45:23.7641958+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 135
    }
  }
}
```