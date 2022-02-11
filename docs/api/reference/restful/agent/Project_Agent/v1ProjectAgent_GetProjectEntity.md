---
title: POST Agents/Project/GetProjectEntity
id: v1ProjectAgent_GetProjectEntity
---

# POST Agents/Project/GetProjectEntity

```http
POST /api/v1/Agents/Project/GetProjectEntity
```

Gets a ProjectEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| projectEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/GetProjectEntity?projectEntityId=307
POST /api/v1/Agents/Project/GetProjectEntity?$select=name,department,category/id
```


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


## Response: object

The Project Service. The service implements all services working with the Project object



Carrier object for ProjectEntity.
Services for the ProjectEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IProjectAgent">Project Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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

## Sample Request

```http!
POST /api/v1/Agents/Project/GetProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 409,
  "Name": "Mayert Group",
  "ProjectNumber": "1169396",
  "ProjectMembers": [
    {
      "ProjectmemberId": 577,
      "ContactId": 504,
      "ProjectId": 459,
      "ContactName": "Brekke Group",
      "ContactDepartment": "",
      "ProjectName": "Hagenes, Cole and Sawayn",
      "EmailId": 248,
      "EmailAddress": "darrick@towneconsidine.ca",
      "CountryId": 788,
      "Firstname": "Fritz",
      "MiddleName": "Buckridge-Sipes",
      "Lastname": "Hammes",
      "PersonId": 794,
      "Mrmrs": "recusandae",
      "ProjectMemberTypeName": "Keeling Inc and Sons",
      "Phone": "678.238.6626 x16831",
      "PhoneId": 388,
      "ProjectMemberTypeId": 398,
      "EmailAddressName": "josefa_balistreri@ward.uk",
      "Comment": "dolores",
      "FullName": "Otho Volkman",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 140
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quam",
      "StrippedValue": "non",
      "Description": "Enhanced zero administration Graphical User Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 363
        }
      }
    },
    {
      "Value": "quam",
      "StrippedValue": "non",
      "Description": "Enhanced zero administration Graphical User Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 363
        }
      }
    }
  ],
  "CreatedDate": "2010-09-13T18:28:49.8921371+02:00",
  "UpdatedDate": "1998-01-22T18:28:49.8921371+01:00",
  "Description": "Virtual local task-force",
  "Postit": "sequi",
  "CreatedBy": {
    "AssociateId": 918,
    "Name": "Wintheiser-Nitzsche",
    "PersonId": 897,
    "Rank": 547,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 245,
    "FullName": "Geoffrey Friesen",
    "FormalName": "Reilly, Senger and Friesen",
    "Deleted": false,
    "EjUserId": 100,
    "UserName": "Pollich-Lindgren",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 270
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 990,
    "Name": "Schmidt Inc and Sons",
    "PersonId": 914,
    "Rank": 844,
    "Tooltip": "corporis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 586,
    "FullName": "Jacynthe Ledner DDS",
    "FormalName": "Lesch Inc and Sons",
    "Deleted": true,
    "EjUserId": 849,
    "UserName": "Jast LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 774
      }
    }
  },
  "Associate": {
    "AssociateId": 844,
    "Name": "Koelpin LLC",
    "PersonId": 884,
    "Rank": 748,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 794,
    "FullName": "Lia Harber",
    "FormalName": "Abernathy Group",
    "Deleted": true,
    "EjUserId": 141,
    "UserName": "Schiller-Goldner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 353
      }
    }
  },
  "ProjectStatus": {
    "Id": 342,
    "Value": "odio",
    "Tooltip": "reprehenderit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 141
      }
    }
  },
  "ProjectType": {
    "Id": 2,
    "Value": "quo",
    "Tooltip": "cumque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 186
      }
    }
  },
  "HasImage": true,
  "ImageDescription": "Profit-focused logistical software",
  "ActiveStatusMonitorId": 730,
  "Links": [
    {
      "EntityName": "Koepp Inc and Sons",
      "Id": 547,
      "Description": "Integrated upward-trending initiative",
      "ExtraInfo": "eligendi",
      "LinkId": 311,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 655
        }
      }
    }
  ],
  "ActiveLinks": 772,
  "Completed": true,
  "NextMilestoneDate": "2010-03-23T18:28:49.8931413+01:00",
  "NmdAppointmentId": 137,
  "EndDate": "2017-01-25T18:28:49.8931413+01:00",
  "ActiveErpLinks": 193,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Humberto Fadel",
    "SuperOffice:2": "803397738"
  },
  "ExtraFields": {
    "ExtraFields1": "dicta",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "facilis",
    "CustomFields2": "reprehenderit"
  },
  "PublishEventDate": "2019-07-07T18:28:49.8931413+02:00",
  "PublishTo": "1999-06-03T18:28:49.8931413+02:00",
  "PublishFrom": "2012-03-04T18:28:49.8931413+01:00",
  "IsPublished": false,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 161
    }
  }
}
```