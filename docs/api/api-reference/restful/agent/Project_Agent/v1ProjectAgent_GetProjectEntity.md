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
POST /api/v1/Agents/Project/GetProjectEntity?projectEntityId=269
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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 142,
  "Name": "Ferry Group",
  "ProjectNumber": "842814",
  "ProjectMembers": [
    {
      "ProjectmemberId": 741,
      "ContactId": 307,
      "ProjectId": 48,
      "ContactName": "Fisher, Spencer and Wolff",
      "ContactDepartment": "",
      "ProjectName": "Schuster Inc and Sons",
      "EmailId": 348,
      "EmailAddress": "velva_morissette@altenwerth.com",
      "CountryId": 856,
      "Firstname": "Ansley",
      "MiddleName": "Davis-Beahan",
      "Lastname": "Little",
      "PersonId": 759,
      "Mrmrs": "ratione",
      "ProjectMemberTypeName": "Bradtke-Gulgowski",
      "Phone": "274.431.7726",
      "PhoneId": 562,
      "ProjectMemberTypeId": 765,
      "EmailAddressName": "wilmer_leannon@fayabshire.com",
      "Comment": "rerum",
      "FullName": "Jerrold Pollich I",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 976
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "in",
      "Description": "Profit-focused real-time capacity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 415
        }
      }
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "in",
      "Description": "Profit-focused real-time capacity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 415
        }
      }
    }
  ],
  "CreatedDate": "2012-07-10T16:48:30.347935+02:00",
  "UpdatedDate": "2003-12-01T16:48:30.347935+01:00",
  "Description": "Horizontal zero defect Graphical User Interface",
  "Postit": "error",
  "CreatedBy": {
    "AssociateId": 947,
    "Name": "Monahan, Cruickshank and Boyer",
    "PersonId": 148,
    "Rank": 858,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 824,
    "FullName": "Rosalyn Mueller Sr.",
    "FormalName": "Gorczany LLC",
    "Deleted": false,
    "EjUserId": 124,
    "UserName": "Beahan-Hessel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 739
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 989,
    "Name": "Strosin LLC",
    "PersonId": 275,
    "Rank": 668,
    "Tooltip": "ad",
    "Type": "AnonymousAssociate",
    "GroupIdx": 366,
    "FullName": "Shyann Turcotte",
    "FormalName": "Farrell-Bruen",
    "Deleted": true,
    "EjUserId": 424,
    "UserName": "Rau-Schamberger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 413
      }
    }
  },
  "Associate": {
    "AssociateId": 704,
    "Name": "Farrell-Treutel",
    "PersonId": 418,
    "Rank": 321,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 870,
    "FullName": "Oswald Kirlin V",
    "FormalName": "Buckridge-Heidenreich",
    "Deleted": true,
    "EjUserId": 885,
    "UserName": "Pfeffer Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "cultivate strategic metrics"
        },
        "FieldType": "System.Int32",
        "FieldLength": 731
      }
    }
  },
  "ProjectStatus": {
    "Id": 949,
    "Value": "et",
    "Tooltip": "explicabo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 379
      }
    }
  },
  "ProjectType": {
    "Id": 486,
    "Value": "qui",
    "Tooltip": "quos",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 750
      }
    }
  },
  "HasImage": false,
  "ImageDescription": "Streamlined methodical help-desk",
  "ActiveStatusMonitorId": 962,
  "Links": [
    {
      "EntityName": "Bernier-Reichert",
      "Id": 891,
      "Description": "Stand-alone bandwidth-monitored toolset",
      "ExtraInfo": "qui",
      "LinkId": 290,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 303
        }
      }
    }
  ],
  "ActiveLinks": 999,
  "Completed": true,
  "NextMilestoneDate": "1994-06-22T16:48:30.3499334+02:00",
  "NmdAppointmentId": 287,
  "EndDate": "2004-06-06T16:48:30.3499334+02:00",
  "ActiveErpLinks": 972,
  "UserDefinedFields": {
    "SuperOffice:1": "Ivory Hamill",
    "SuperOffice:2": "Harrison Ziemann"
  },
  "ExtraFields": {
    "ExtraFields1": "magni",
    "ExtraFields2": "quo"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "soluta"
  },
  "PublishEventDate": "2009-03-03T16:48:30.3499334+01:00",
  "PublishTo": "2010-11-30T16:48:30.3499334+01:00",
  "PublishFrom": "2009-12-14T16:48:30.3499334+01:00",
  "IsPublished": true,
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
      "FieldType": "System.String",
      "FieldLength": 761
    }
  }
}
```