---
title: GET Contact/default
id: v1ContactEntity_DefaultContactEntity
---

# GET Contact/default

```http
GET /api/v1/Contact/default
```

Set default values into a new ContactEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Contact agent service CreateDefaultContactEntity.






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

The Contact Service. The service implements all services working with the Contact object



Carrier object for ContactEntity.
Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 05 Dec 2005 09:40:58 G12T

{
  "ContactId": 961,
  "Name": "Parker, Blanda and Nienow",
  "Department": "",
  "OrgNr": "877613",
  "Number1": "1557703",
  "Number2": "1528047",
  "UpdatedDate": "2005-12-05T09:40:58.864376+01:00",
  "CreatedDate": "2011-03-10T09:40:58.864376+01:00",
  "Emails": [
    {
      "Value": "officiis",
      "StrippedValue": "voluptas",
      "Description": "Realigned modular framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "syndicate 24/7 experiences"
          },
          "FieldType": "System.String",
          "FieldLength": 529
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "voluptas",
      "Description": "Realigned modular framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "syndicate 24/7 experiences"
          },
          "FieldType": "System.String",
          "FieldLength": 529
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 566,
      "Name": "Homenick, O'Kon and Harris",
      "ToolTip": "Aliquam autem ipsum voluptatem ullam.",
      "Deleted": false,
      "Rank": 614,
      "Type": "iste",
      "ColorBlock": 930,
      "IconHint": "culpa",
      "Selected": false,
      "LastChanged": "2001-10-20T09:40:58.864376+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "dicta",
      "Hidden": true,
      "FullName": "Jewell Quigley",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 690
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "amet",
      "StrippedValue": "deserunt",
      "Description": "Polarised zero defect knowledge user",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "repurpose cross-media deliverables"
          },
          "FieldType": "System.Int32",
          "FieldLength": 132
        }
      }
    },
    {
      "Value": "amet",
      "StrippedValue": "deserunt",
      "Description": "Polarised zero defect knowledge user",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "repurpose cross-media deliverables"
          },
          "FieldType": "System.Int32",
          "FieldLength": 132
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "ut",
      "Description": "Enterprise-wide multimedia analyzer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 998
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "ut",
      "Description": "Enterprise-wide multimedia analyzer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 998
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nisi",
      "StrippedValue": "magni",
      "Description": "Optimized stable website",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 427
        }
      }
    },
    {
      "Value": "nisi",
      "StrippedValue": "magni",
      "Description": "Optimized stable website",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 427
        }
      }
    }
  ],
  "Description": "Pre-emptive well-modulated extranet",
  "UpdatedBy": {
    "AssociateId": 285,
    "Name": "Wiza LLC",
    "PersonId": 46,
    "Rank": 453,
    "Tooltip": "dolorum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 831,
    "FullName": "Adrain Gutkowski",
    "FormalName": "Dickinson, Nienow and Reinger",
    "Deleted": true,
    "EjUserId": 189,
    "UserName": "Hahn-Nienow",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 875
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 713,
    "Name": "Stiedemann-Jewess",
    "PersonId": 596,
    "Rank": 528,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 632,
    "FullName": "Ms. Monte Willms",
    "FormalName": "Parisian, Cronin and O'Hara",
    "Deleted": false,
    "EjUserId": 536,
    "UserName": "Baumbach-Wyman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 437
      }
    }
  },
  "Associate": {
    "AssociateId": 366,
    "Name": "Nolan Group",
    "PersonId": 179,
    "Rank": 37,
    "Tooltip": "quod",
    "Type": "AnonymousAssociate",
    "GroupIdx": 763,
    "FullName": "Darron Shanahan",
    "FormalName": "Homenick Group",
    "Deleted": false,
    "EjUserId": 562,
    "UserName": "Parker Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 425
      }
    }
  },
  "Business": {
    "Id": 18,
    "Value": "nisi",
    "Tooltip": "deserunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 92
      }
    }
  },
  "Category": {
    "Id": 368,
    "Value": "nemo",
    "Tooltip": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 134
      }
    }
  },
  "Country": {
    "CountryId": 920,
    "Name": "Jewess-Wilderman",
    "CurrencyId": 254,
    "EnglishName": "Beatty LLC",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Inverse responsive flexibility",
    "OrgNrText": "751639",
    "InterAreaPrefix": "dolorem",
    "DialInPrefix": "neque",
    "ZipPrefix": "eum",
    "DomainName": "Becker Group",
    "AddressLayoutId": 338,
    "DomesticAddressLayoutId": 655,
    "ForeignAddressLayoutId": 736,
    "Rank": 917,
    "Tooltip": "nobis",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 7
      }
    }
  },
  "Persons": [
    {
      "Position": "porro",
      "PersonId": 90,
      "Mrmrs": "veritatis",
      "Firstname": "Oral",
      "Lastname": "Dickinson",
      "MiddleName": "Cummings-Kozey",
      "Title": "magnam",
      "Description": "Team-oriented solution-oriented knowledge user",
      "Email": "carroll@kunze.co.uk",
      "FullName": "Mr. Norbert Emmerich",
      "DirectPhone": "1-634-611-1750",
      "FormalName": "Boyle-Fay",
      "CountryId": 637,
      "ContactId": 453,
      "ContactName": "Jacobs, Quigley and Jacobs",
      "Retired": 854,
      "Rank": 93,
      "ActiveInterests": 917,
      "ContactDepartment": "",
      "ContactCountryId": 716,
      "ContactOrgNr": "1098928",
      "FaxPhone": "756.027.3425",
      "MobilePhone": "1-406-880-5520 x6153",
      "ContactPhone": "326.777.8732",
      "AssociateName": "Bayer, Glover and Funk",
      "AssociateId": 794,
      "UsePersonAddress": true,
      "ContactFax": "voluptatem",
      "Kanafname": "sed",
      "Kanalname": "ipsum",
      "Post1": "sit",
      "Post2": "et",
      "Post3": "voluptates",
      "EmailName": "carli@bartolettipaucek.name",
      "ContactFullName": "Claudine Rodriguez",
      "ActiveErpLinks": 438,
      "TicketPriorityId": 793,
      "SupportLanguageId": 895,
      "SupportAssociateId": 561,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 921
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "iure",
  "Xstop": true,
  "ActiveInterests": 973,
  "GroupId": 505,
  "ActiveStatusMonitorId": 931,
  "SupportAssociate": {
    "AssociateId": 966,
    "Name": "Abshire Inc and Sons",
    "PersonId": 125,
    "Rank": 750,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 37,
    "FullName": "Claudia Shields",
    "FormalName": "Herzog, Howe and Ryan",
    "Deleted": false,
    "EjUserId": 380,
    "UserName": "Koss, Sawayn and Nolan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 99
      }
    }
  },
  "TicketPriority": {
    "Id": 461,
    "Value": "necessitatibus",
    "Tooltip": "voluptas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 542
      }
    }
  },
  "CustomerLanguage": {
    "Id": 880,
    "Value": "quasi",
    "Tooltip": "aspernatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 721
      }
    }
  },
  "Deleted": 142,
  "DbiAgentId": 899,
  "DbiLastSyncronized": "1994-07-27T09:40:58.8693757+02:00",
  "DbiKey": "doloribus",
  "DbiLastModified": "2004-06-10T09:40:58.8693757+02:00",
  "SupportPerson": {
    "Position": "deserunt",
    "PersonId": 745,
    "Mrmrs": "sit",
    "Firstname": "Jewel",
    "Lastname": "Thompson",
    "MiddleName": "Reilly-O'Conner",
    "Title": "architecto",
    "Description": "Programmable methodical collaboration",
    "Email": "eunice_schumm@kuhnlehner.uk",
    "FullName": "Ines Kessler",
    "DirectPhone": "1-364-176-2568",
    "FormalName": "Torp Inc and Sons",
    "CountryId": 999,
    "ContactId": 930,
    "ContactName": "Hegmann-Emmerich",
    "Retired": 957,
    "Rank": 682,
    "ActiveInterests": 926,
    "ContactDepartment": "",
    "ContactCountryId": 603,
    "ContactOrgNr": "652758",
    "FaxPhone": "413-100-6345 x24033",
    "MobilePhone": "452-874-5103",
    "ContactPhone": "(617)080-8211 x470",
    "AssociateName": "O'Kon LLC",
    "AssociateId": 275,
    "UsePersonAddress": true,
    "ContactFax": "eos",
    "Kanafname": "exercitationem",
    "Kanalname": "beatae",
    "Post1": "dolore",
    "Post2": "veritatis",
    "Post3": "natus",
    "EmailName": "charley@lebsackwuckert.com",
    "ContactFullName": "Keanu Goyette",
    "ActiveErpLinks": 499,
    "TicketPriorityId": 126,
    "SupportLanguageId": 147,
    "SupportAssociateId": 231,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 295
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 26554.381999999998,
    "Wgs84Longitude": 3795.274,
    "LocalizedAddress": [
      [
        {
          "Name": "Green, Bernier and Emard",
          "Value": "et",
          "Tooltip": "nemo",
          "Label": "consequuntur",
          "ValueLength": 697,
          "AddressType": "saepe",
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
              "FieldLength": 493
            }
          }
        }
      ],
      [
        {
          "Name": "Konopelski Group",
          "Value": "quo",
          "Tooltip": "perferendis",
          "Label": "et",
          "ValueLength": 66,
          "AddressType": "ipsum",
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
              "FieldLength": 85
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "sit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 815
      }
    }
  },
  "Source": 434,
  "ActiveErpLinks": 588,
  "BounceEmails": [
    "darlene_nader@mckenzie.biz",
    "arnaldo_feest@grimes.com"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "2054555695",
    "SuperOffice:2": "Earnestine Hansen"
  },
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "accusamus"
  },
  "CustomFields": {
    "CustomFields1": "deserunt",
    "CustomFields2": "veniam"
  },
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
      "FieldLength": 309
    }
  }
}
```