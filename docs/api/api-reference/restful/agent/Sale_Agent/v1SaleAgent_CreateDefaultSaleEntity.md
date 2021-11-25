---
title: POST Agents/Sale/CreateDefaultSaleEntity
id: v1SaleAgent_CreateDefaultSaleEntity
---

# POST Agents/Sale/CreateDefaultSaleEntity

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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 288,
    "StartDate": "1998-09-23T18:28:50.0686992+02:00",
    "EndDate": "2000-12-10T18:28:50.0686992+01:00",
    "Type": "BookingForChecklist",
    "Task": "aliquam",
    "AssociateFullName": "Amelie Hickle III",
    "ContactName": "Christiansen Group",
    "Description": "Reduced 24/7 frame",
    "PersonFullName": "Maximilian Lowe I",
    "PersonId": 968,
    "ContactId": 297,
    "ProjectId": 991,
    "ProjectName": "Ferry-Romaguera",
    "IsPublished": true,
    "AssociateId": 831,
    "ColorIndex": 776,
    "IsFree": false,
    "HasAlarm": true,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 869,
    "PriorityName": "Cole-Kuhic",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": true,
    "IsBooking": true,
    "ActiveDate": "2009-11-02T18:28:50.0686992+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "1997-09-01T18:28:50.0686992+02:00",
    "RecurringEndDate": "2020-12-27T18:28:50.0686992+01:00",
    "MotherId": 759,
    "AssignedBy": 773,
    "AssignedByFullName": "Issac Schumm",
    "RejectReason": "",
    "Location": "vero",
    "AlarmLeadTime": "et",
    "SaleId": 769,
    "SaleName": "Heaney Inc and Sons",
    "AssociateName": "Swaniawski-Wilkinson",
    "CreatedDate": "2016-05-05T18:28:50.0686992+02:00",
    "CreatedBy": "reprehenderit",
    "CreatedByFullName": "Sasha Fisher",
    "CreatedByAssociateId": 197,
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
        "FieldLength": 247
      }
    }
  },
  "Associate": {
    "AssociateId": 658,
    "Name": "Hoeger Inc and Sons",
    "PersonId": 798,
    "Rank": 18,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 110,
    "FullName": "Floyd Goodwin",
    "FormalName": "Grady Group",
    "Deleted": true,
    "EjUserId": 678,
    "UserName": "Treutel Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 496
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 154,
    "Name": "Leffler, Herman and Fay",
    "PersonId": 615,
    "Rank": 362,
    "Tooltip": "laborum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 620,
    "FullName": "Murl Littel",
    "FormalName": "Klocko Group",
    "Deleted": true,
    "EjUserId": 95,
    "UserName": "Bartell LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 941
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 530,
    "Name": "Witting-Hilpert",
    "PersonId": 677,
    "Rank": 982,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 131,
    "FullName": "Laney Pfannerstill",
    "FormalName": "Mosciski-Ferry",
    "Deleted": false,
    "EjUserId": 802,
    "UserName": "Heidenreich-Littel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 948
      }
    }
  },
  "Contact": {
    "ContactId": 947,
    "Name": "Crona, Koelpin and Little",
    "OrgNr": "901143",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "dicta",
    "DirectPhone": "127.528.8183 x35478",
    "AssociateId": 756,
    "CountryId": 296,
    "EmailAddress": "glenda@klockolehner.uk",
    "Kananame": "quae",
    "EmailAddressName": "forrest.schmeler@price.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ms. Vicky Balistreri",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quidem",
    "FullName": "Oliver Leannon V",
    "IsOwnerContact": false,
    "ActiveErpLinks": 337,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 579
      }
    }
  },
  "Project": {
    "ProjectId": 277,
    "Name": "Treutel, Pfannerstill and Leuschke",
    "Description": "Polarised secondary array",
    "URL": "http://www.example.com/",
    "Type": "voluptas",
    "AssociateId": 552,
    "AssociateFullName": "Esteban White",
    "TypeId": 637,
    "Updated": "1995-11-04T18:28:50.0706987+01:00",
    "StatusId": 189,
    "Status": "cumque",
    "TextId": 516,
    "PublishTo": "2000-02-29T18:28:50.0706987+01:00",
    "PublishFrom": "2014-08-07T18:28:50.0706987+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "929104",
    "ActiveErpLinks": 688,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 711
      }
    }
  },
  "SaleText": "est",
  "Person": {
    "Position": "eius",
    "PersonId": 696,
    "Mrmrs": "et",
    "Firstname": "Mitchell",
    "Lastname": "Boehm",
    "MiddleName": "Morar-Stark",
    "Title": "quod",
    "Description": "Cloned full-range help-desk",
    "Email": "whitney_cormier@wisozk.co.uk",
    "FullName": "Brock Langworth",
    "DirectPhone": "(588)707-2126 x44728",
    "FormalName": "Sipes, Gutkowski and Pacocha",
    "CountryId": 751,
    "ContactId": 248,
    "ContactName": "Smith-Kuhic",
    "Retired": 563,
    "Rank": 510,
    "ActiveInterests": 721,
    "ContactDepartment": "",
    "ContactCountryId": 439,
    "ContactOrgNr": "863369",
    "FaxPhone": "127.574.6202",
    "MobilePhone": "1-216-861-7134",
    "ContactPhone": "511.424.1865 x4025",
    "AssociateName": "Graham-Bernier",
    "AssociateId": 280,
    "UsePersonAddress": false,
    "ContactFax": "est",
    "Kanafname": "quia",
    "Kanalname": "exercitationem",
    "Post1": "occaecati",
    "Post2": "sed",
    "Post3": "molestias",
    "EmailName": "sonny.mueller@kirlin.com",
    "ContactFullName": "Mr. Maddison Rogahn",
    "ActiveErpLinks": 718,
    "TicketPriorityId": 101,
    "SupportLanguageId": 429,
    "SupportAssociateId": 428,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 900
      }
    }
  },
  "Currency": {
    "Id": 839,
    "Value": "sed",
    "Tooltip": "quae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 12
      }
    }
  },
  "Competitor": {
    "Id": 169,
    "Value": "beatae",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 656
      }
    }
  },
  "Credited": {
    "Id": 835,
    "Value": "quae",
    "Tooltip": "quis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 864
      }
    }
  },
  "Rating": {
    "Id": 197,
    "Value": "sunt",
    "Tooltip": "ullam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 884
      }
    }
  },
  "Reason": {
    "Id": 324,
    "Value": "expedita",
    "Tooltip": "consectetur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "iterate bleeding-edge interfaces"
        },
        "FieldType": "System.String",
        "FieldLength": 917
      }
    }
  },
  "Source": {
    "Id": 905,
    "Value": "corrupti",
    "Tooltip": "architecto",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 645
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2010-04-18T18:28:50.0736794+02:00",
  "Amount": 21138.829999999998,
  "SaleId": 723,
  "Earning": 31292.989999999998,
  "EarningPercent": 31133.156,
  "Heading": "culpa",
  "Number": "671636",
  "Probability": 452,
  "CreatedDate": "1997-04-23T18:28:50.0736794+02:00",
  "UpdatedDate": "2013-04-13T18:28:50.0736794+02:00",
  "Completed": "Completed",
  "ActiveLinks": 3,
  "Links": [
    {
      "EntityName": "Wintheiser, Kulas and Gerhold",
      "Id": 265,
      "Description": "Multi-channelled 24 hour open architecture",
      "ExtraInfo": "rerum",
      "LinkId": 294,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 226
        }
      }
    }
  ],
  "NextDueDate": "2001-08-06T18:28:50.0746758+02:00",
  "Postit": "quos",
  "SaleType": {
    "Id": 240,
    "Value": "excepturi",
    "Tooltip": "ratione",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 336
      }
    }
  },
  "ReasonSold": {
    "Id": 40,
    "Value": "labore",
    "Tooltip": "officia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 110
      }
    }
  },
  "ReasonStalled": {
    "Id": 593,
    "Value": "ratione",
    "Tooltip": "rerum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 708
      }
    }
  },
  "ReopenDate": "2017-08-26T18:28:50.0746758+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Reilly Inc and Sons",
      "Comment": "eligendi",
      "StakeholderRoleId": 408,
      "CountryId": 78,
      "PersonId": 822,
      "EmailDescription": "agnes@gutkowski.co.uk",
      "EmailId": 972,
      "EmailAddress": "irma@prosacco.co.uk",
      "PhoneId": 118,
      "ContactName": "Cruickshank LLC",
      "ContactId": 51,
      "SaleId": 34,
      "Mrmrs": "doloribus",
      "Firstname": "Gail",
      "MiddleName": "Nikolaus-Ward",
      "Lastname": "Mohr",
      "SaleStakeholderId": 843,
      "Rank": 819,
      "Phone": "1-542-862-2110 x634",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 200
        }
      }
    }
  ],
  "ActiveErpLinks": 607,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Meta Balistreri"
  },
  "ExtraFields": {
    "ExtraFields1": "illum",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "magni",
    "CustomFields2": "eveniet"
  },
  "PublishEventDate": "2013-02-22T18:28:50.0756702+01:00",
  "PublishTo": "2016-08-22T18:28:50.0756702+02:00",
  "PublishFrom": "2010-04-17T18:28:50.0756702+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 403,
      "Visibility": "All",
      "DisplayValue": "aperiam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 403
        }
      }
    },
    {
      "VisibleId": 403,
      "Visibility": "All",
      "DisplayValue": "aperiam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 403
        }
      }
    }
  ],
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
      "FieldLength": 6
    }
  }
}
```