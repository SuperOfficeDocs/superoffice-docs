---
title: CreateDefaultContactEntity
id: v1ContactAgent_CreateDefaultContactEntity
---

# CreateDefaultContactEntity

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
  "ContactId": 580,
  "Name": "Mohr, Grady and Brown",
  "Department": "",
  "OrgNr": "453161",
  "Number1": "880458",
  "Number2": "1546730",
  "UpdatedDate": "1999-08-16T14:58:03.5453104+02:00",
  "CreatedDate": "1996-09-11T14:58:03.5453104+02:00",
  "Emails": [
    {
      "Value": "asperiores",
      "StrippedValue": "assumenda",
      "Description": "Open-architected explicit service-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 291
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "assumenda",
      "Description": "Open-architected explicit service-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 291
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 90,
      "Name": "Turner LLC",
      "ToolTip": "Vero non qui ex.",
      "Deleted": false,
      "Rank": 986,
      "Type": "quia",
      "ColorBlock": 26,
      "IconHint": "consectetur",
      "Selected": false,
      "LastChanged": "2006-06-29T14:58:03.5463101+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vero",
      "StyleHint": "occaecati",
      "Hidden": true,
      "FullName": "Ceasar Hessel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 91
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "saepe",
      "StrippedValue": "asperiores",
      "Description": "Ameliorated static groupware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 723
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "asperiores",
      "Description": "Ameliorated static groupware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 723
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ducimus",
      "StrippedValue": "sunt",
      "Description": "Expanded transitional portal",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    },
    {
      "Value": "ducimus",
      "StrippedValue": "sunt",
      "Description": "Expanded transitional portal",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "similique",
      "Description": "Business-focused discrete firmware",
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
    {
      "Value": "ut",
      "StrippedValue": "similique",
      "Description": "Business-focused discrete firmware",
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
    }
  ],
  "Description": "Expanded systemic archive",
  "UpdatedBy": {
    "AssociateId": 880,
    "Name": "Abbott Group",
    "PersonId": 783,
    "Rank": 875,
    "Tooltip": "laboriosam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 756,
    "FullName": "Dr. Josiah Ullrich",
    "FormalName": "Emard-Conroy",
    "Deleted": true,
    "EjUserId": 780,
    "UserName": "Glover-Wiegand",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 115
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 327,
    "Name": "Yundt-Raynor",
    "PersonId": 584,
    "Rank": 182,
    "Tooltip": "repellat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 778,
    "FullName": "Stephania Hyatt",
    "FormalName": "Hane-Grady",
    "Deleted": false,
    "EjUserId": 705,
    "UserName": "Douglas-Sanford",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 860
      }
    }
  },
  "Associate": {
    "AssociateId": 351,
    "Name": "Friesen-Schuppe",
    "PersonId": 930,
    "Rank": 590,
    "Tooltip": "odit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 549,
    "FullName": "Ferne Johns",
    "FormalName": "Trantow LLC",
    "Deleted": false,
    "EjUserId": 521,
    "UserName": "Kovacek, Flatley and Rogahn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 188
      }
    }
  },
  "Business": {
    "Id": 835,
    "Value": "in",
    "Tooltip": "voluptates",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 234
      }
    }
  },
  "Category": {
    "Id": 692,
    "Value": "dolor",
    "Tooltip": "amet",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 891
      }
    }
  },
  "Country": {
    "CountryId": 26,
    "Name": "Heathcote, Legros and Mills",
    "CurrencyId": 684,
    "EnglishName": "Tremblay Group",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Diverse mobile matrix",
    "OrgNrText": "1104916",
    "InterAreaPrefix": "quod",
    "DialInPrefix": "officia",
    "ZipPrefix": "sit",
    "DomainName": "Hettinger-Beahan",
    "AddressLayoutId": 560,
    "DomesticAddressLayoutId": 941,
    "ForeignAddressLayoutId": 204,
    "Rank": 419,
    "Tooltip": "veritatis",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 453
      }
    }
  },
  "Persons": [
    {
      "Position": "inventore",
      "PersonId": 843,
      "Mrmrs": "ex",
      "Firstname": "Sincere",
      "Lastname": "Bode",
      "MiddleName": "Wuckert Inc and Sons",
      "Title": "harum",
      "Description": "Optimized bifurcated forecast",
      "Email": "hope_gibson@fritschokuneva.name",
      "FullName": "Lane Jacobi",
      "DirectPhone": "(874)815-6668",
      "FormalName": "Fay-Nienow",
      "CountryId": 251,
      "ContactId": 626,
      "ContactName": "White-Hahn",
      "Retired": 310,
      "Rank": 663,
      "ActiveInterests": 276,
      "ContactDepartment": "",
      "ContactCountryId": 349,
      "ContactOrgNr": "733930",
      "FaxPhone": "515.106.8511",
      "MobilePhone": "1-100-745-7835 x152",
      "ContactPhone": "1-426-884-3288 x40576",
      "AssociateName": "Anderson Inc and Sons",
      "AssociateId": 447,
      "UsePersonAddress": false,
      "ContactFax": "labore",
      "Kanafname": "illum",
      "Kanalname": "nihil",
      "Post1": "vitae",
      "Post2": "error",
      "Post3": "sunt",
      "EmailName": "dayton@kautzeremmerich.biz",
      "ContactFullName": "Mathilde Cartwright DVM",
      "ActiveErpLinks": 99,
      "TicketPriorityId": 77,
      "SupportLanguageId": 348,
      "SupportAssociateId": 383,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 106
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "sit",
  "Xstop": true,
  "ActiveInterests": 157,
  "GroupId": 237,
  "ActiveStatusMonitorId": 21,
  "SupportAssociate": {
    "AssociateId": 923,
    "Name": "Kuphal Group",
    "PersonId": 317,
    "Rank": 965,
    "Tooltip": "quas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 743,
    "FullName": "Dion Hahn",
    "FormalName": "Hintz Group",
    "Deleted": false,
    "EjUserId": 746,
    "UserName": "Connelly, Dibbert and Konopelski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 844
      }
    }
  },
  "TicketPriority": {
    "Id": 191,
    "Value": "in",
    "Tooltip": "molestiae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 299
      }
    }
  },
  "CustomerLanguage": {
    "Id": 464,
    "Value": "quod",
    "Tooltip": "hic",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 641
      }
    }
  },
  "Deleted": 615,
  "DbiAgentId": 701,
  "DbiLastSyncronized": "1996-04-20T14:58:03.5492812+02:00",
  "DbiKey": "labore",
  "DbiLastModified": "2015-07-21T14:58:03.5492812+02:00",
  "SupportPerson": {
    "Position": "nam",
    "PersonId": 290,
    "Mrmrs": "fugiat",
    "Firstname": "Ivah",
    "Lastname": "Ritchie",
    "MiddleName": "Homenick LLC",
    "Title": "laudantium",
    "Description": "Configurable intangible secured line",
    "Email": "thalia@roob.co.uk",
    "FullName": "Terrill Kling",
    "DirectPhone": "077-781-6182 x7257",
    "FormalName": "Pouros, Hermiston and Harris",
    "CountryId": 175,
    "ContactId": 222,
    "ContactName": "Trantow-Schuster",
    "Retired": 342,
    "Rank": 780,
    "ActiveInterests": 25,
    "ContactDepartment": "",
    "ContactCountryId": 329,
    "ContactOrgNr": "537962",
    "FaxPhone": "1-351-381-4556 x8554",
    "MobilePhone": "(281)355-6211 x8408",
    "ContactPhone": "304-435-3374 x76444",
    "AssociateName": "Gibson Group",
    "AssociateId": 108,
    "UsePersonAddress": false,
    "ContactFax": "eos",
    "Kanafname": "omnis",
    "Kanalname": "fuga",
    "Post1": "et",
    "Post2": "ut",
    "Post3": "nihil",
    "EmailName": "pedro.terry@barrows.co.uk",
    "ContactFullName": "Jana Jaskolski",
    "ActiveErpLinks": 928,
    "TicketPriorityId": 815,
    "SupportLanguageId": 833,
    "SupportAssociateId": 210,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 713
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 19822.55,
    "Wgs84Longitude": 30794.683999999997,
    "LocalizedAddress": [
      [
        {
          "Name": "Klocko Inc and Sons",
          "Value": "temporibus",
          "Tooltip": "et",
          "Label": "exercitationem",
          "ValueLength": 193,
          "AddressType": "voluptas",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "scale leading-edge bandwidth"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.String",
              "FieldLength": 45
            }
          }
        }
      ],
      [
        {
          "Name": "Von, Rempel and Schamberger",
          "Value": "quis",
          "Tooltip": "rerum",
          "Label": "nihil",
          "ValueLength": 260,
          "AddressType": "dignissimos",
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
              "FieldLength": 620
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "vero",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 161
      }
    }
  },
  "Source": 399,
  "ActiveErpLinks": 721,
  "BounceEmails": [
    "mackenzie@langworth.name",
    "kane@littlesporer.co.uk"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1209556268",
    "SuperOffice:2": "Marlen Wiza"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptate",
    "ExtraFields2": "consequuntur"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "sit"
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
      "FieldLength": 571
    }
  }
}
```