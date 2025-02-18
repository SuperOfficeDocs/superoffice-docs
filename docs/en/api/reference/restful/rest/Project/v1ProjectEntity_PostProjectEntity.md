---
title: POST Project
uid: v1ProjectEntity_PostProjectEntity
generated: true
---

# POST Project

```http
POST /api/v1/Project
```

Creates a new ProjectEntity


Calls the Project agent service SaveProjectEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Project?$select=name,department,category/id
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

### Response body: ProjectEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Project
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 866,
  "Name": "Waters Group",
  "ProjectNumber": "136380",
  "ProjectMembers": [
    {
      "ProjectmemberId": 680,
      "ContactId": 688,
      "ProjectId": 617,
      "ContactName": "Collins, Stark and Daugherty",
      "ContactDepartment": "",
      "ProjectName": "Smith Inc and Sons",
      "EmailId": 418,
      "EmailAddress": "nathen@marvin.info",
      "CountryId": 976,
      "Firstname": "Julien",
      "MiddleName": "Walsh, Effertz and Jerde",
      "Lastname": "Kub",
      "PersonId": 394,
      "Mrmrs": "sequi",
      "ProjectMemberTypeName": "Goyette Inc and Sons",
      "Phone": "296-754-6984 x6586",
      "PhoneId": 331,
      "ProjectMemberTypeId": 484,
      "EmailAddressName": "lionel_buckridge@conroy.name",
      "Comment": "provident",
      "FullName": "Bernardo Hintz"
    }
  ],
  "Urls": [
    {
      "Value": "deleniti",
      "StrippedValue": "alias",
      "Description": "Front-line encompassing approach"
    },
    {
      "Value": "deleniti",
      "StrippedValue": "alias",
      "Description": "Front-line encompassing approach"
    }
  ],
  "CreatedDate": "2024-12-25T14:32:11.6616628+01:00",
  "UpdatedDate": "2024-07-22T14:32:11.6616628+02:00",
  "Description": "Customer-focused web-enabled archive",
  "Postit": "voluptatum",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Customizable modular adapter",
  "ActiveStatusMonitorId": 653,
  "Links": [
    {
      "EntityName": "Feeney-Gulgowski",
      "Id": 464,
      "Description": "Synergistic fresh-thinking forecast",
      "ExtraInfo": "accusamus",
      "LinkId": 577
    },
    {
      "EntityName": "Feeney-Gulgowski",
      "Id": 464,
      "Description": "Synergistic fresh-thinking forecast",
      "ExtraInfo": "accusamus",
      "LinkId": 577
    }
  ],
  "ActiveLinks": 499,
  "Completed": false,
  "NextMilestoneDate": "2014-05-25T14:32:11.6616628+02:00",
  "NmdAppointmentId": 642,
  "EndDate": "2015-08-15T14:32:11.6616628+02:00",
  "ActiveErpLinks": 865,
  "UserDefinedFields": {
    "SuperOffice:1": "Kayla Herzog II",
    "SuperOffice:2": "Helen Ritchie"
  },
  "ExtraFields": {
    "ExtraFields1": "at",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "repudiandae"
  },
  "PublishEventDate": "2012-09-01T14:32:11.6616628+02:00",
  "PublishTo": "2010-09-10T14:32:11.6616628+02:00",
  "PublishFrom": "2007-08-05T14:32:11.6616628+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 251,
  "Name": "Schmeler, Hagenes and Johnson",
  "ProjectNumber": "915167",
  "ProjectMembers": [
    {
      "ProjectmemberId": 482,
      "ContactId": 775,
      "ProjectId": 179,
      "ContactName": "Keebler-Hilll",
      "ContactDepartment": "unleash synergistic synergies",
      "ProjectName": "Boyle, Boyer and Ratke",
      "EmailId": 433,
      "EmailAddress": "zelda_trantow@mclaughlingutmann.name",
      "CountryId": 174,
      "Firstname": "Manuela",
      "MiddleName": "McGlynn, Boyle and Harris",
      "Lastname": "Christiansen",
      "PersonId": 251,
      "Mrmrs": "quasi",
      "ProjectMemberTypeName": "Mann-Wisozk",
      "Phone": "627.444.9320",
      "PhoneId": 288,
      "ProjectMemberTypeId": 907,
      "EmailAddressName": "vern@wintheiser.info",
      "Comment": "perspiciatis",
      "FullName": "Ms. Aric Gerlach Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 297
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "odio",
      "StrippedValue": "numquam",
      "Description": "Re-contextualized actuating strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 900
        }
      }
    },
    {
      "Value": "odio",
      "StrippedValue": "numquam",
      "Description": "Re-contextualized actuating strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 900
        }
      }
    }
  ],
  "CreatedDate": "2022-08-18T14:32:11.6616628+02:00",
  "UpdatedDate": "2020-08-21T14:32:11.6616628+02:00",
  "Description": "Fundamental 4th generation groupware",
  "Postit": "fuga",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Down-sized 4th generation function",
  "ActiveStatusMonitorId": 143,
  "Links": [
    {
      "EntityName": "Bernier LLC",
      "Id": 940,
      "Description": "Intuitive interactive standardization",
      "ExtraInfo": "voluptas",
      "LinkId": 931,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 905
        }
      }
    }
  ],
  "ActiveLinks": 663,
  "Completed": false,
  "NextMilestoneDate": "2005-04-08T14:32:11.6772827+02:00",
  "NmdAppointmentId": 845,
  "EndDate": "2005-04-03T14:32:11.6772827+02:00",
  "ActiveErpLinks": 724,
  "UserDefinedFields": {
    "SuperOffice:1": "Taya Cremin",
    "SuperOffice:2": "Baylee Franecki"
  },
  "ExtraFields": {
    "ExtraFields1": "harum",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "voluptate",
    "CustomFields2": "corrupti"
  },
  "PublishEventDate": "2019-10-06T14:32:11.6772827+02:00",
  "PublishTo": "2005-09-03T14:32:11.6772827+02:00",
  "PublishFrom": "2010-12-06T14:32:11.6772827+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 301
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```