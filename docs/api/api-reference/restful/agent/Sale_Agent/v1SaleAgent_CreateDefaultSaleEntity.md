---
title: CreateDefaultSaleEntity
id: v1SaleAgent_CreateDefaultSaleEntity
---

# CreateDefaultSaleEntity

```http
POST /api/v1/Agents/Sale/CreateDefaultSaleEntity
```

Set default values into a new SaleEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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

Partial SaleEntity class associating the generated SaleEntity with an interface.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment |  | Simple read-only appointment data. <para /> Carrier object for Appointment. Services for the Appointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>. |
| Associate |  | The sale owner  <para>Use MDO List name "associate" to get list items.</para> |
| UpdatedBy |  | Who updated the sale |
| CreatedBy |  | Who created to sale |
| Contact |  | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  <para>Use MDO List name "contact" to get list items.</para> |
| Project |  | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| SaleText | string | Text describing the sale |
| Person |  | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Currency |  | The currency the sale object was sold in  <para>Use MDO List name "currency" to get list items.</para> |
| Competitor |  | List of all possible competitors.   <para>Use MDO List name "comptr" to get list items.</para> |
| Credited |  | List of who is to be credited for the sale.  <para>Use MDO List name "credited" to get list items.</para> |
| Rating |  | The sale rating  <para>Use MDO List name "prob" to get list items.</para> |
| Reason |  | The sale reason  <para>Use MDO List name "reason" to get list items.</para> |
| Source |  | The sale source  <para>Use MDO List name "source" to get list items.</para> |
| Status | string | The state of the Sale: Open / Sold / Lost / Stalled |
| Saledate | date-time | (expected / lost / won) sales date |
| Amount | double | Total sale amount |
| SaleId | int32 | Primary key |
| Earning | double | Earning on sale |
| EarningPercent | double | Earning as percent of total |
| Heading | string | Sale heading (short description?) |
| Number | string | Alphanumeric user field |
| Probability | int32 | Actual probability, may differ from the one in the list |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated  in UTC. |
| Completed | string | The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field. |
| ActiveLinks | int32 | Number of active links to sale, document, appointment. |
| Links | array | List of all elements linked to the sale. |
| NextDueDate | date-time | Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching. |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| SaleType |  | <para>Use MDO List name "saletype" to get list items.</para> |
| ReasonSold |  | <para>Use MDO List name "reasonsold" to get list items.</para> |
| ReasonStalled |  | <para>Use MDO List name "reasonstalled" to get list items.</para> |
| ReopenDate | date-time | Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate. |
| SaleStakeholders | array |  |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.SaleEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.SaleEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Sale/CreateDefaultSaleEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 641,
    "StartDate": "1998-08-29T14:58:05.1276278+02:00",
    "EndDate": "1995-04-20T14:58:05.1276278+02:00",
    "Type": "BookingForChecklist",
    "Task": "dolorum",
    "AssociateFullName": "Jacynthe Jones",
    "ContactName": "Blanda-Haag",
    "Description": "Function-based cohesive benchmark",
    "PersonFullName": "Skye Bosco",
    "PersonId": 82,
    "ContactId": 26,
    "ProjectId": 485,
    "ProjectName": "Bernhard Inc and Sons",
    "IsPublished": true,
    "AssociateId": 242,
    "ColorIndex": 914,
    "IsFree": true,
    "HasAlarm": true,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 80,
    "PriorityName": "Schuster-Bednar",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": false,
    "IsBooking": true,
    "ActiveDate": "2001-01-01T14:58:05.1286304+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "1996-01-01T14:58:05.1286304+01:00",
    "RecurringEndDate": "2012-02-04T14:58:05.1286304+01:00",
    "MotherId": 629,
    "AssignedBy": 228,
    "AssignedByFullName": "Pearlie Lehner II",
    "RejectReason": "",
    "Location": "perspiciatis",
    "AlarmLeadTime": "debitis",
    "SaleId": 248,
    "SaleName": "Purdy LLC",
    "AssociateName": "Marquardt, Nitzsche and Zieme",
    "CreatedDate": "1999-04-21T14:58:05.1286304+02:00",
    "CreatedBy": "qui",
    "CreatedByFullName": "Delphia Hegmann",
    "CreatedByAssociateId": 654,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 37
      }
    }
  },
  "Associate": {
    "AssociateId": 725,
    "Name": "Toy Inc and Sons",
    "PersonId": 4,
    "Rank": 286,
    "Tooltip": "corrupti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 593,
    "FullName": "Johnpaul Kozey",
    "FormalName": "Gusikowski-Considine",
    "Deleted": true,
    "EjUserId": 437,
    "UserName": "Auer, Howell and Hilll",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 350
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 930,
    "Name": "Thompson-Zemlak",
    "PersonId": 828,
    "Rank": 515,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 16,
    "FullName": "Heidi Langworth",
    "FormalName": "Langosh, Crona and Feest",
    "Deleted": true,
    "EjUserId": 763,
    "UserName": "Jacobs-O'Connell",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 637
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 656,
    "Name": "Oberbrunner-Hermann",
    "PersonId": 113,
    "Rank": 43,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 615,
    "FullName": "Ofelia Runolfsdottir",
    "FormalName": "Koss Group",
    "Deleted": true,
    "EjUserId": 287,
    "UserName": "Murazik, Waelchi and DuBuque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 897
      }
    }
  },
  "Contact": {
    "ContactId": 90,
    "Name": "West, Gottlieb and Jacobi",
    "OrgNr": "1088716",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "omnis",
    "DirectPhone": "(783)573-8444",
    "AssociateId": 537,
    "CountryId": 161,
    "EmailAddress": "colt_runolfsson@rauking.name",
    "Kananame": "modi",
    "EmailAddressName": "veda@quigley.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ms. Fredrick VonRueden",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "et",
    "FullName": "Gayle Altenwerth",
    "IsOwnerContact": true,
    "ActiveErpLinks": 852,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 437
      }
    }
  },
  "Project": {
    "ProjectId": 554,
    "Name": "Goyette, Blick and Nienow",
    "Description": "Phased actuating info-mediaries",
    "URL": "http://www.example.com/",
    "Type": "sunt",
    "AssociateId": 680,
    "AssociateFullName": "Marta Jast",
    "TypeId": 672,
    "Updated": "2017-06-08T14:58:05.1306273+02:00",
    "StatusId": 279,
    "Status": "voluptatem",
    "TextId": 412,
    "PublishTo": "1997-05-30T14:58:05.1316289+02:00",
    "PublishFrom": "2017-01-21T14:58:05.1316289+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "568560",
    "ActiveErpLinks": 381,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 601
      }
    }
  },
  "SaleText": "minus",
  "Person": {
    "Position": "dolor",
    "PersonId": 402,
    "Mrmrs": "nihil",
    "Firstname": "Abbey",
    "Lastname": "Mayer",
    "MiddleName": "Yundt-Boyle",
    "Title": "ut",
    "Description": "Versatile analyzing open system",
    "Email": "eulalia_marquardt@herzog.uk",
    "FullName": "Dillan Ledner",
    "DirectPhone": "(137)718-0803",
    "FormalName": "Goodwin, Brekke and Predovic",
    "CountryId": 423,
    "ContactId": 789,
    "ContactName": "Toy Inc and Sons",
    "Retired": 475,
    "Rank": 687,
    "ActiveInterests": 422,
    "ContactDepartment": "",
    "ContactCountryId": 754,
    "ContactOrgNr": "483183",
    "FaxPhone": "220.714.2352",
    "MobilePhone": "1-100-788-1275",
    "ContactPhone": "615-105-7107 x65668",
    "AssociateName": "Mante-Schmidt",
    "AssociateId": 793,
    "UsePersonAddress": true,
    "ContactFax": "molestias",
    "Kanafname": "id",
    "Kanalname": "esse",
    "Post1": "praesentium",
    "Post2": "in",
    "Post3": "facilis",
    "EmailName": "jairo.spinka@west.biz",
    "ContactFullName": "Humberto Eichmann",
    "ActiveErpLinks": 369,
    "TicketPriorityId": 418,
    "SupportLanguageId": 453,
    "SupportAssociateId": 338,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 607
      }
    }
  },
  "Currency": {
    "Id": 498,
    "Value": "quis",
    "Tooltip": "aliquam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 638
      }
    }
  },
  "Competitor": {
    "Id": 676,
    "Value": "placeat",
    "Tooltip": "ab",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 210
      }
    }
  },
  "Credited": {
    "Id": 152,
    "Value": "fuga",
    "Tooltip": "quae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 694
      }
    }
  },
  "Rating": {
    "Id": 321,
    "Value": "beatae",
    "Tooltip": "dolores",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 628
      }
    }
  },
  "Reason": {
    "Id": 341,
    "Value": "numquam",
    "Tooltip": "esse",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 271
      }
    }
  },
  "Source": {
    "Id": 689,
    "Value": "ipsam",
    "Tooltip": "officia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 946
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2018-05-30T14:58:05.1326274+02:00",
  "Amount": 30434.273999999998,
  "SaleId": 687,
  "Earning": 17425.04,
  "EarningPercent": 30102.07,
  "Heading": "quas",
  "Number": "1174303",
  "Probability": 886,
  "CreatedDate": "1998-08-16T14:58:05.1326274+02:00",
  "UpdatedDate": "2002-10-31T14:58:05.1326274+01:00",
  "Completed": "Completed",
  "ActiveLinks": 819,
  "Links": [
    {
      "EntityName": "Leannon-Ryan",
      "Id": 996,
      "Description": "Managed web-enabled strategy",
      "ExtraInfo": "reiciendis",
      "LinkId": 417,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 997
        }
      }
    }
  ],
  "NextDueDate": "1994-09-20T14:58:05.1326274+02:00",
  "Postit": "necessitatibus",
  "SaleType": {
    "Id": 681,
    "Value": "doloribus",
    "Tooltip": "expedita",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 307
      }
    }
  },
  "ReasonSold": {
    "Id": 913,
    "Value": "tempora",
    "Tooltip": "molestiae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 860
      }
    }
  },
  "ReasonStalled": {
    "Id": 69,
    "Value": "et",
    "Tooltip": "doloribus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 272
      }
    }
  },
  "ReopenDate": "1999-02-24T14:58:05.1326274+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Bayer-Lakin",
      "Comment": "iste",
      "StakeholderRoleId": 998,
      "CountryId": 163,
      "PersonId": 572,
      "EmailDescription": "maymie_strosin@robel.biz",
      "EmailId": 364,
      "EmailAddress": "xander_hessel@collins.name",
      "PhoneId": 289,
      "ContactName": "Terry LLC",
      "ContactId": 663,
      "SaleId": 384,
      "Mrmrs": "eos",
      "Firstname": "Devante",
      "MiddleName": "Labadie-Osinski",
      "Lastname": "Dickens",
      "SaleStakeholderId": 268,
      "Rank": 431,
      "Phone": "(701)412-8311 x2001",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 18
        }
      }
    }
  ],
  "ActiveErpLinks": 876,
  "UserDefinedFields": {
    "SuperOffice:1": "1397503423",
    "SuperOffice:2": "Narciso Thiel"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "eligendi"
  },
  "CustomFields": {
    "CustomFields1": "quisquam",
    "CustomFields2": "soluta"
  },
  "PublishEventDate": "2019-05-21T14:58:05.1336276+02:00",
  "PublishTo": "2019-03-26T14:58:05.1336276+01:00",
  "PublishFrom": "2001-12-23T14:58:05.1336276+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 815,
      "Visibility": "All",
      "DisplayValue": "quos",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 18
        }
      }
    },
    {
      "VisibleId": 815,
      "Visibility": "All",
      "DisplayValue": "quos",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 18
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "utilize impactful schemas"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 31
    }
  }
}
```