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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 513,
  "Name": "Jacobs LLC",
  "ProjectNumber": "848808",
  "ProjectMembers": [
    {
      "ProjectmemberId": 873,
      "ContactId": 953,
      "ProjectId": 63,
      "ContactName": "Yundt Group",
      "ContactDepartment": "",
      "ProjectName": "Robel, Greenfelder and Hettinger",
      "EmailId": 641,
      "EmailAddress": "dina@collins.uk",
      "CountryId": 388,
      "Firstname": "Billy",
      "MiddleName": "Brekke-Gottlieb",
      "Lastname": "McCullough",
      "PersonId": 782,
      "Mrmrs": "repudiandae",
      "ProjectMemberTypeName": "Leffler, Emmerich and Morissette",
      "Phone": "1-547-308-2791 x24271",
      "PhoneId": 974,
      "ProjectMemberTypeId": 238,
      "EmailAddressName": "declan@jacobson.co.uk",
      "Comment": "mollitia",
      "FullName": "Mellie Mueller"
    }
  ],
  "Urls": [
    {
      "Value": "maxime",
      "StrippedValue": "esse",
      "Description": "Synchronised intangible projection"
    },
    {
      "Value": "maxime",
      "StrippedValue": "esse",
      "Description": "Synchronised intangible projection"
    }
  ],
  "CreatedDate": "2002-10-29T11:16:09.5378187+01:00",
  "UpdatedDate": "2010-12-19T11:16:09.5378187+01:00",
  "Description": "Business-focused bottom-line process improvement",
  "Postit": "voluptas",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Centralized systemic synergy",
  "ActiveStatusMonitorId": 285,
  "Links": [
    {
      "EntityName": "Ledner, Nitzsche and Kshlerin",
      "Id": 441,
      "Description": "Customizable logistical archive",
      "ExtraInfo": "autem",
      "LinkId": 93
    },
    {
      "EntityName": "Ledner, Nitzsche and Kshlerin",
      "Id": 441,
      "Description": "Customizable logistical archive",
      "ExtraInfo": "autem",
      "LinkId": 93
    }
  ],
  "ActiveLinks": 582,
  "Completed": false,
  "NextMilestoneDate": "2010-04-20T11:16:09.5378187+02:00",
  "NmdAppointmentId": 504,
  "EndDate": "1998-03-06T11:16:09.5378187+01:00",
  "ActiveErpLinks": 799,
  "UserDefinedFields": {
    "SuperOffice:1": "Zachariah Thiel",
    "SuperOffice:2": "1567740788"
  },
  "ExtraFields": {
    "ExtraFields1": "blanditiis",
    "ExtraFields2": "aspernatur"
  },
  "CustomFields": {
    "CustomFields1": "ad",
    "CustomFields2": "ut"
  },
  "PublishEventDate": "2011-08-16T11:16:09.5378187+02:00",
  "PublishTo": "2010-05-27T11:16:09.5378187+02:00",
  "PublishFrom": "1999-01-28T11:16:09.5378187+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 745,
  "Name": "Larkin, Hintz and Lakin",
  "ProjectNumber": "1520919",
  "ProjectMembers": [
    {
      "ProjectmemberId": 975,
      "ContactId": 460,
      "ProjectId": 950,
      "ContactName": "Thiel, Hessel and Emard",
      "ContactDepartment": "",
      "ProjectName": "Feeney, Murazik and Bednar",
      "EmailId": 418,
      "EmailAddress": "xander@goodwinmcclure.uk",
      "CountryId": 65,
      "Firstname": "Braulio",
      "MiddleName": "Nienow Inc and Sons",
      "Lastname": "Gerlach",
      "PersonId": 428,
      "Mrmrs": "assumenda",
      "ProjectMemberTypeName": "Abbott, Grimes and Metz",
      "Phone": "452-535-7364 x0065",
      "PhoneId": 200,
      "ProjectMemberTypeId": 320,
      "EmailAddressName": "rodrigo_monahan@rice.us",
      "Comment": "eum",
      "FullName": "Christophe Franecki",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 81
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "enim",
      "StrippedValue": "debitis",
      "Description": "Optional transitional focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 342
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "debitis",
      "Description": "Optional transitional focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 342
        }
      }
    }
  ],
  "CreatedDate": "2003-01-01T11:16:09.5378187+01:00",
  "UpdatedDate": "2017-06-20T11:16:09.5378187+02:00",
  "Description": "User-centric impactful forecast",
  "Postit": "ratione",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Upgradable stable portal",
  "ActiveStatusMonitorId": 254,
  "Links": [
    {
      "EntityName": "Bayer-Anderson",
      "Id": 919,
      "Description": "Robust 4th generation open system",
      "ExtraInfo": "eos",
      "LinkId": 851,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 654
        }
      }
    }
  ],
  "ActiveLinks": 872,
  "Completed": true,
  "NextMilestoneDate": "2009-09-17T11:16:09.5378187+02:00",
  "NmdAppointmentId": 152,
  "EndDate": "2006-06-12T11:16:09.5378187+02:00",
  "ActiveErpLinks": 439,
  "UserDefinedFields": {
    "SuperOffice:1": "Stephanie Willms",
    "SuperOffice:2": "Wellington Lockman"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "doloribus"
  },
  "CustomFields": {
    "CustomFields1": "possimus",
    "CustomFields2": "fuga"
  },
  "PublishEventDate": "2013-12-10T11:16:09.5378187+01:00",
  "PublishTo": "2010-03-12T11:16:09.5378187+01:00",
  "PublishFrom": "2001-06-07T11:16:09.5378187+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 655
    }
  }
}
```