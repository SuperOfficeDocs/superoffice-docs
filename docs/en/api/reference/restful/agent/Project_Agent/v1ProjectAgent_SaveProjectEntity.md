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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 589,
  "Name": "Schuster-Farrell",
  "ProjectNumber": "388966",
  "ProjectMembers": [
    {
      "ProjectmemberId": 989,
      "ContactId": 26,
      "ProjectId": 664,
      "ContactName": "Little-Gerhold",
      "ContactDepartment": "envisioneer clicks-and-mortar users",
      "ProjectName": "Jaskolski, Beahan and Zemlak",
      "EmailId": 247,
      "EmailAddress": "ashley.batz@bauch.biz",
      "CountryId": 164,
      "Firstname": "Pedro",
      "MiddleName": "Metz, Johnson and Hodkiewicz",
      "Lastname": "Schuppe",
      "PersonId": 144,
      "Mrmrs": "perferendis",
      "ProjectMemberTypeName": "Ruecker-Goyette",
      "Phone": "203.020.0596 x922",
      "PhoneId": 42,
      "ProjectMemberTypeId": 203,
      "EmailAddressName": "curtis@littel.us",
      "Comment": "vel",
      "FullName": "Dr. Royce Schmitt Jr."
    }
  ],
  "Urls": [
    {
      "Value": "sapiente",
      "StrippedValue": "est",
      "Description": "Expanded interactive structure"
    },
    {
      "Value": "sapiente",
      "StrippedValue": "est",
      "Description": "Expanded interactive structure"
    }
  ],
  "CreatedDate": "1999-12-18T12:19:45.8046423+01:00",
  "UpdatedDate": "1999-09-06T12:19:45.8046423+02:00",
  "Description": "Profound regional standardization",
  "Postit": "non",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Business-focused zero tolerance migration",
  "ActiveStatusMonitorId": 130,
  "Links": [
    {
      "EntityName": "Nicolas Group",
      "Id": 22,
      "Description": "Profound context-sensitive frame",
      "ExtraInfo": "aut",
      "LinkId": 537
    },
    {
      "EntityName": "Nicolas Group",
      "Id": 22,
      "Description": "Profound context-sensitive frame",
      "ExtraInfo": "aut",
      "LinkId": 537
    }
  ],
  "ActiveLinks": 535,
  "Completed": true,
  "NextMilestoneDate": "2015-03-14T12:19:45.8046423+01:00",
  "NmdAppointmentId": 275,
  "EndDate": "2008-09-12T12:19:45.8046423+02:00",
  "ActiveErpLinks": 658,
  "UserDefinedFields": {
    "SuperOffice:1": "Paris Frances Legros I",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "modi",
    "ExtraFields2": "deleniti"
  },
  "CustomFields": {
    "CustomFields1": "quae",
    "CustomFields2": "ratione"
  },
  "PublishEventDate": "2019-05-01T12:19:45.8046423+02:00",
  "PublishTo": "2012-01-10T12:19:45.8046423+01:00",
  "PublishFrom": "2022-07-30T12:19:45.8046423+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 882,
  "Name": "Swift, Jerde and Thompson",
  "ProjectNumber": "1136687",
  "ProjectMembers": [
    {
      "ProjectmemberId": 444,
      "ContactId": 118,
      "ProjectId": 952,
      "ContactName": "Sanford-Kilback",
      "ContactDepartment": "",
      "ProjectName": "Windler, Wolf and White",
      "EmailId": 951,
      "EmailAddress": "bennie@langoshwest.info",
      "CountryId": 388,
      "Firstname": "Martine",
      "MiddleName": "O'Kon Group",
      "Lastname": "Kuhlman",
      "PersonId": 964,
      "Mrmrs": "aliquam",
      "ProjectMemberTypeName": "Bartoletti, Grimes and O'Keefe",
      "Phone": "284.687.1251 x09786",
      "PhoneId": 8,
      "ProjectMemberTypeId": 761,
      "EmailAddressName": "everette.howell@purdy.info",
      "Comment": "cum",
      "FullName": "Mrs. Roma Kian Emmerich I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 87
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quo",
      "StrippedValue": "ut",
      "Description": "Reduced hybrid Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 730
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "ut",
      "Description": "Reduced hybrid Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 730
        }
      }
    }
  ],
  "CreatedDate": "1999-06-08T12:19:45.9608584+02:00",
  "UpdatedDate": "2017-11-14T12:19:45.9608584+01:00",
  "Description": "User-friendly heuristic intranet",
  "Postit": "inventore",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Adaptive even-keeled forecast",
  "ActiveStatusMonitorId": 527,
  "Links": [
    {
      "EntityName": "Mayer, Collier and Cruickshank",
      "Id": 980,
      "Description": "Multi-tiered dedicated implementation",
      "ExtraInfo": "laboriosam",
      "LinkId": 165,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 888
        }
      }
    }
  ],
  "ActiveLinks": 956,
  "Completed": false,
  "NextMilestoneDate": "2001-05-11T12:19:45.9764798+02:00",
  "NmdAppointmentId": 566,
  "EndDate": "2007-08-29T12:19:45.9764798+02:00",
  "ActiveErpLinks": 237,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "551141677"
  },
  "ExtraFields": {
    "ExtraFields1": "esse",
    "ExtraFields2": "fuga"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "maiores"
  },
  "PublishEventDate": "2011-05-29T12:19:45.9764798+02:00",
  "PublishTo": "2006-08-15T12:19:45.9764798+02:00",
  "PublishFrom": "2011-01-07T12:19:45.9764798+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 222
    }
  }
}
```