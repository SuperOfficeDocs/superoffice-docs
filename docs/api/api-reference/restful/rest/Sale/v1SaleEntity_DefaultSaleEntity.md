---
title: GET Sale/default
id: v1SaleEntity_DefaultSaleEntity
---

# GET Sale/default

```http
GET /api/v1/Sale/default
```

Set default values into a new SaleEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Sale agent service CreateDefaultSaleEntity.






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
GET /api/v1/Sale/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 20 Oct 1999 18:25:50 G10T

{
  "Appointment": {
    "AppointmentId": 18,
    "StartDate": "2012-09-07T18:25:50.9312228+02:00",
    "EndDate": "2014-10-19T18:25:50.9312228+02:00",
    "Type": "BookingForChecklist",
    "Task": "itaque",
    "AssociateFullName": "Hortense Boyle",
    "ContactName": "Buckridge Group",
    "Description": "Multi-tiered didactic capacity",
    "PersonFullName": "Omer Mayert II",
    "PersonId": 974,
    "ContactId": 833,
    "ProjectId": 489,
    "ProjectName": "Kohler, Baumbach and Doyle",
    "IsPublished": true,
    "AssociateId": 44,
    "ColorIndex": 520,
    "IsFree": true,
    "HasAlarm": true,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 733,
    "PriorityName": "Conn-Morar",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": false,
    "IsBooking": true,
    "ActiveDate": "2019-07-04T18:25:50.932254+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2018-01-04T18:25:50.932254+01:00",
    "RecurringEndDate": "2011-05-17T18:25:50.932254+02:00",
    "MotherId": 457,
    "AssignedBy": 899,
    "AssignedByFullName": "Merle Mohr",
    "RejectReason": "",
    "Location": "molestias",
    "AlarmLeadTime": "est",
    "SaleId": 102,
    "SaleName": "Hammes, Volkman and Reinger",
    "AssociateName": "Reinger, Ullrich and Rohan",
    "CreatedDate": "1998-09-30T18:25:50.932254+02:00",
    "CreatedBy": "similique",
    "CreatedByFullName": "Ms. Jaron Rippin",
    "CreatedByAssociateId": 746,
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
        "FieldLength": 507
      }
    }
  },
  "Associate": {
    "AssociateId": 101,
    "Name": "Berge-Kozey",
    "PersonId": 694,
    "Rank": 677,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 633,
    "FullName": "Wilmer Welch",
    "FormalName": "Veum Inc and Sons",
    "Deleted": false,
    "EjUserId": 742,
    "UserName": "Gusikowski-Wiegand",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 832
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 42,
    "Name": "Strosin Inc and Sons",
    "PersonId": 624,
    "Rank": 181,
    "Tooltip": "necessitatibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 597,
    "FullName": "Roxanne Fritsch",
    "FormalName": "Bechtelar LLC",
    "Deleted": false,
    "EjUserId": 955,
    "UserName": "Rogahn-Boehm",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 574
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 55,
    "Name": "Schmitt-Lemke",
    "PersonId": 557,
    "Rank": 805,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 653,
    "FullName": "Karli Mraz",
    "FormalName": "King Inc and Sons",
    "Deleted": true,
    "EjUserId": 351,
    "UserName": "Franecki-Hamill",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 811
      }
    }
  },
  "Contact": {
    "ContactId": 7,
    "Name": "Wyman-Connelly",
    "OrgNr": "1199409",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "laborum",
    "DirectPhone": "563.073.6535 x826",
    "AssociateId": 934,
    "CountryId": 447,
    "EmailAddress": "dax_marvin@kirlin.uk",
    "Kananame": "unde",
    "EmailAddressName": "elliott@tremblay.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Adella Prohaska",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "qui",
    "FullName": "Elroy Roberts",
    "IsOwnerContact": false,
    "ActiveErpLinks": 647,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 867
      }
    }
  },
  "Project": {
    "ProjectId": 684,
    "Name": "Bechtelar-Pouros",
    "Description": "Reverse-engineered composite archive",
    "URL": "http://www.example.com/",
    "Type": "ea",
    "AssociateId": 117,
    "AssociateFullName": "Estell Murazik",
    "TypeId": 492,
    "Updated": "2012-10-19T18:25:50.9342586+02:00",
    "StatusId": 73,
    "Status": "quo",
    "TextId": 218,
    "PublishTo": "2020-01-25T18:25:50.9342586+01:00",
    "PublishFrom": "2009-09-08T18:25:50.9342586+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1054246",
    "ActiveErpLinks": 864,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 703
      }
    }
  },
  "SaleText": "praesentium",
  "Person": {
    "Position": "culpa",
    "PersonId": 862,
    "Mrmrs": "et",
    "Firstname": "Demetrius",
    "Lastname": "Heaney",
    "MiddleName": "Yundt LLC",
    "Title": "et",
    "Description": "Persevering client-server customer loyalty",
    "Email": "rebeca@schmittadams.us",
    "FullName": "Miss Heather Hills",
    "DirectPhone": "(874)206-6506 x6547",
    "FormalName": "Marvin Inc and Sons",
    "CountryId": 612,
    "ContactId": 420,
    "ContactName": "Huel-Toy",
    "Retired": 614,
    "Rank": 138,
    "ActiveInterests": 115,
    "ContactDepartment": "",
    "ContactCountryId": 901,
    "ContactOrgNr": "780890",
    "FaxPhone": "734-124-5632 x8814",
    "MobilePhone": "1-178-667-1062",
    "ContactPhone": "(131)371-4382",
    "AssociateName": "Jerde LLC",
    "AssociateId": 785,
    "UsePersonAddress": false,
    "ContactFax": "sit",
    "Kanafname": "omnis",
    "Kanalname": "qui",
    "Post1": "autem",
    "Post2": "assumenda",
    "Post3": "rerum",
    "EmailName": "raegan@kertzmann.com",
    "ContactFullName": "Demetrius Leuschke",
    "ActiveErpLinks": 53,
    "TicketPriorityId": 388,
    "SupportLanguageId": 749,
    "SupportAssociateId": 461,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 69
      }
    }
  },
  "Currency": {
    "Id": 467,
    "Value": "non",
    "Tooltip": "nostrum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 826
      }
    }
  },
  "Competitor": {
    "Id": 360,
    "Value": "qui",
    "Tooltip": "est",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 594
      }
    }
  },
  "Credited": {
    "Id": 201,
    "Value": "nisi",
    "Tooltip": "ea",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 132
      }
    }
  },
  "Rating": {
    "Id": 776,
    "Value": "alias",
    "Tooltip": "provident",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 481
      }
    }
  },
  "Reason": {
    "Id": 959,
    "Value": "sint",
    "Tooltip": "animi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 193
      }
    }
  },
  "Source": {
    "Id": 670,
    "Value": "dignissimos",
    "Tooltip": "atque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 132
      }
    }
  },
  "Status": "Lost",
  "Saledate": "1997-08-31T18:25:50.9362628+02:00",
  "Amount": 2375.572,
  "SaleId": 441,
  "Earning": 1830.2559999999999,
  "EarningPercent": 9690.328,
  "Heading": "veritatis",
  "Number": "1763174",
  "Probability": 396,
  "CreatedDate": "2006-05-05T18:25:50.9362628+02:00",
  "UpdatedDate": "1999-10-20T18:25:50.9362628+02:00",
  "Completed": "Completed",
  "ActiveLinks": 305,
  "Links": [
    {
      "EntityName": "Haag-Goodwin",
      "Id": 77,
      "Description": "Mandatory directional installation",
      "ExtraInfo": "provident",
      "LinkId": 300,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 345
        }
      }
    }
  ],
  "NextDueDate": "2007-05-26T18:25:50.9362628+02:00",
  "Postit": "autem",
  "SaleType": {
    "Id": 151,
    "Value": "consequuntur",
    "Tooltip": "ea",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 951
      }
    }
  },
  "ReasonSold": {
    "Id": 540,
    "Value": "amet",
    "Tooltip": "fuga",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 957
      }
    }
  },
  "ReasonStalled": {
    "Id": 176,
    "Value": "explicabo",
    "Tooltip": "nulla",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 142
      }
    }
  },
  "ReopenDate": "2021-01-30T18:25:50.9362628+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Christiansen-Reichel",
      "Comment": "quis",
      "StakeholderRoleId": 602,
      "CountryId": 420,
      "PersonId": 164,
      "EmailDescription": "shawn@schamberger.info",
      "EmailId": 485,
      "EmailAddress": "lessie.brakus@cummings.uk",
      "PhoneId": 356,
      "ContactName": "Predovic-Dooley",
      "ContactId": 800,
      "SaleId": 911,
      "Mrmrs": "eos",
      "Firstname": "Gayle",
      "MiddleName": "McGlynn-Schuppe",
      "Lastname": "Schumm",
      "SaleStakeholderId": 486,
      "Rank": 900,
      "Phone": "165-273-5240 x58347",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 57
        }
      }
    }
  ],
  "ActiveErpLinks": 939,
  "UserDefinedFields": {
    "SuperOffice:1": "Forest Sanford",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "nam",
    "ExtraFields2": "magni"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "totam"
  },
  "PublishEventDate": "2017-04-07T18:25:50.9382594+02:00",
  "PublishTo": "2013-12-11T18:25:50.9382594+01:00",
  "PublishFrom": "2008-02-03T18:25:50.9382594+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 775,
      "Visibility": "All",
      "DisplayValue": "optio",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 915
        }
      }
    },
    {
      "VisibleId": 775,
      "Visibility": "All",
      "DisplayValue": "optio",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 915
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
      "FieldType": "System.Int32",
      "FieldLength": 963
    }
  }
}
```