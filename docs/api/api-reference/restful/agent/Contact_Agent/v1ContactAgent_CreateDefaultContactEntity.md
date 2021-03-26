---
title: POST Agents/Contact/CreateDefaultContactEntity
id: v1ContactAgent_CreateDefaultContactEntity
---

# POST Agents/Contact/CreateDefaultContactEntity

```http
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
```

Set default values into a new ContactEntity.

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
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 258,
  "Name": "Osinski, Renner and Auer",
  "Department": "",
  "OrgNr": "466733",
  "Number1": "387552",
  "Number2": "418393",
  "UpdatedDate": "2001-02-02T16:48:29.0239337+01:00",
  "CreatedDate": "2012-12-17T16:48:29.0239337+01:00",
  "Emails": [
    {
      "Value": "consequuntur",
      "StrippedValue": "dolorum",
      "Description": "Compatible impactful circuit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 792
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "dolorum",
      "Description": "Compatible impactful circuit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 792
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 856,
      "Name": "Miller Inc and Sons",
      "ToolTip": "Iste tempora ad voluptatem optio consequatur.",
      "Deleted": false,
      "Rank": 516,
      "Type": "quae",
      "ColorBlock": 585,
      "IconHint": "autem",
      "Selected": true,
      "LastChanged": "2021-01-23T16:48:29.0239337+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "consequatur",
      "Hidden": true,
      "FullName": "Robyn Kulas V",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 359
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "neque",
      "StrippedValue": "placeat",
      "Description": "Secured interactive matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 606
        }
      }
    },
    {
      "Value": "neque",
      "StrippedValue": "placeat",
      "Description": "Secured interactive matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 606
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "eum",
      "StrippedValue": "animi",
      "Description": "Automated upward-trending leverage",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 155
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "animi",
      "Description": "Automated upward-trending leverage",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 155
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "numquam",
      "StrippedValue": "ullam",
      "Description": "Multi-lateral non-volatile parallelism",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 243
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "ullam",
      "Description": "Multi-lateral non-volatile parallelism",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 243
        }
      }
    }
  ],
  "Description": "Innovative local standardization",
  "UpdatedBy": {
    "AssociateId": 775,
    "Name": "Schowalter, Franecki and Mitchell",
    "PersonId": 828,
    "Rank": 898,
    "Tooltip": "eum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 647,
    "FullName": "Mrs. Isobel Parker",
    "FormalName": "White, Roberts and Beahan",
    "Deleted": false,
    "EjUserId": 117,
    "UserName": "Williamson LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 79
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 552,
    "Name": "Roberts-Zemlak",
    "PersonId": 642,
    "Rank": 745,
    "Tooltip": "aspernatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 511,
    "FullName": "Jaylon Gaylord",
    "FormalName": "Sipes-Wisozk",
    "Deleted": false,
    "EjUserId": 443,
    "UserName": "Goyette-Wuckert",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 341
      }
    }
  },
  "Associate": {
    "AssociateId": 788,
    "Name": "Rath, Swift and Haley",
    "PersonId": 168,
    "Rank": 733,
    "Tooltip": "illum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 770,
    "FullName": "Miss Gene Kuhn",
    "FormalName": "McDermott Inc and Sons",
    "Deleted": true,
    "EjUserId": 968,
    "UserName": "Legros-Kling",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 641
      }
    }
  },
  "Business": {
    "Id": 390,
    "Value": "aspernatur",
    "Tooltip": "similique",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 4
      }
    }
  },
  "Category": {
    "Id": 561,
    "Value": "blanditiis",
    "Tooltip": "quae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 64
      }
    }
  },
  "Country": {
    "CountryId": 891,
    "Name": "Berge Group",
    "CurrencyId": 105,
    "EnglishName": "Tromp-Moen",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Operative reciprocal database",
    "OrgNrText": "767121",
    "InterAreaPrefix": "voluptatum",
    "DialInPrefix": "nisi",
    "ZipPrefix": "quisquam",
    "DomainName": "Dooley Group",
    "AddressLayoutId": 999,
    "DomesticAddressLayoutId": 526,
    "ForeignAddressLayoutId": 492,
    "Rank": 619,
    "Tooltip": "rerum",
    "Deleted": true,
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
  "Persons": [
    {
      "Position": "aut",
      "PersonId": 842,
      "Mrmrs": "qui",
      "Firstname": "Anita",
      "Lastname": "Prosacco",
      "MiddleName": "Windler-Rau",
      "Title": "mollitia",
      "Description": "Realigned analyzing focus group",
      "Email": "raymond_tremblay@lemke.co.uk",
      "FullName": "Jewel Kub",
      "DirectPhone": "245-215-2758",
      "FormalName": "Considine, Auer and Nader",
      "CountryId": 238,
      "ContactId": 118,
      "ContactName": "Walter Group",
      "Retired": 542,
      "Rank": 23,
      "ActiveInterests": 660,
      "ContactDepartment": "",
      "ContactCountryId": 217,
      "ContactOrgNr": "936872",
      "FaxPhone": "1-207-085-6340",
      "MobilePhone": "306.537.6668 x587",
      "ContactPhone": "680-523-6740 x6780",
      "AssociateName": "Heidenreich-Ferry",
      "AssociateId": 786,
      "UsePersonAddress": true,
      "ContactFax": "quos",
      "Kanafname": "dolor",
      "Kanalname": "enim",
      "Post1": "blanditiis",
      "Post2": "tempore",
      "Post3": "cum",
      "EmailName": "vallie@cummeratanader.biz",
      "ContactFullName": "Daisy Quitzon",
      "ActiveErpLinks": 815,
      "TicketPriorityId": 643,
      "SupportLanguageId": 522,
      "SupportAssociateId": 751,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 709
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "distinctio",
  "Xstop": false,
  "ActiveInterests": 930,
  "GroupId": 333,
  "ActiveStatusMonitorId": 121,
  "SupportAssociate": {
    "AssociateId": 27,
    "Name": "Little Inc and Sons",
    "PersonId": 821,
    "Rank": 939,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 335,
    "FullName": "Roscoe Kuhic",
    "FormalName": "Watsica, Pollich and Kilback",
    "Deleted": false,
    "EjUserId": 303,
    "UserName": "Stark, Deckow and Bartell",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 751
      }
    }
  },
  "TicketPriority": {
    "Id": 629,
    "Value": "sed",
    "Tooltip": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 470
      }
    }
  },
  "CustomerLanguage": {
    "Id": 111,
    "Value": "in",
    "Tooltip": "officiis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 188
      }
    }
  },
  "Deleted": 706,
  "DbiAgentId": 467,
  "DbiLastSyncronized": "1998-09-05T16:48:29.0279297+02:00",
  "DbiKey": "distinctio",
  "DbiLastModified": "2015-05-15T16:48:29.0279297+02:00",
  "SupportPerson": {
    "Position": "et",
    "PersonId": 593,
    "Mrmrs": "voluptas",
    "Firstname": "Brice",
    "Lastname": "Turner",
    "MiddleName": "Herzog-Dickens",
    "Title": "quibusdam",
    "Description": "Sharable hybrid hub",
    "Email": "chris@koepp.com",
    "FullName": "Sammy Hansen",
    "DirectPhone": "540-883-5254",
    "FormalName": "Batz Inc and Sons",
    "CountryId": 334,
    "ContactId": 207,
    "ContactName": "Bauch, McCullough and Macejkovic",
    "Retired": 728,
    "Rank": 358,
    "ActiveInterests": 921,
    "ContactDepartment": "",
    "ContactCountryId": 480,
    "ContactOrgNr": "363899",
    "FaxPhone": "021.068.7444 x3281",
    "MobilePhone": "(881)131-3818 x255",
    "ContactPhone": "(656)755-0442 x0476",
    "AssociateName": "Pacocha-Hammes",
    "AssociateId": 627,
    "UsePersonAddress": false,
    "ContactFax": "voluptatibus",
    "Kanafname": "minima",
    "Kanalname": "quidem",
    "Post1": "nihil",
    "Post2": "doloribus",
    "Post3": "quam",
    "EmailName": "celine@reichel.uk",
    "ContactFullName": "Keagan Kertzmann",
    "ActiveErpLinks": 495,
    "TicketPriorityId": 459,
    "SupportLanguageId": 896,
    "SupportAssociateId": 47,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 475
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 14093.598,
    "Wgs84Longitude": 19562.428,
    "LocalizedAddress": [
      [
        {
          "Name": "Anderson, Schiller and Rath",
          "Value": "exercitationem",
          "Tooltip": "quia",
          "Label": "officiis",
          "ValueLength": 756,
          "AddressType": "corporis",
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
              "FieldLength": 601
            }
          }
        }
      ],
      [
        {
          "Name": "Ullrich Inc and Sons",
          "Value": "nihil",
          "Tooltip": "commodi",
          "Label": "explicabo",
          "ValueLength": 665,
          "AddressType": "sunt",
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
              "FieldLength": 381
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "vel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 415
      }
    }
  },
  "Source": 686,
  "ActiveErpLinks": 686,
  "BounceEmails": [
    "carleton@goyette.us",
    "scot.raynor@wolffhickle.com"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1954437332",
    "SuperOffice:2": "1168192809"
  },
  "ExtraFields": {
    "ExtraFields1": "repellendus",
    "ExtraFields2": "sint"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "sint"
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
      "FieldType": "System.String",
      "FieldLength": 866
    }
  }
}
```