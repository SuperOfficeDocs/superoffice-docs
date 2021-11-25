---
title: POST Agents/Contact/GetMyContact
id: v1ContactAgent_GetMyContact
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
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
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 106,
  "Name": "Kuphal-Lynch",
  "Department": "",
  "OrgNr": "1204837",
  "Number1": "585044",
  "Number2": "1407957",
  "UpdatedDate": "2001-08-01T18:28:48.5046235+02:00",
  "CreatedDate": "2006-03-12T18:28:48.5046235+01:00",
  "Emails": [
    {
      "Value": "similique",
      "StrippedValue": "ea",
      "Description": "Automated scalable circuit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 570
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "ea",
      "Description": "Automated scalable circuit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 570
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 553,
      "Name": "Boyle Inc and Sons",
      "ToolTip": "Sit natus qui.",
      "Deleted": false,
      "Rank": 696,
      "Type": "repellendus",
      "ColorBlock": 646,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2009-12-13T18:28:48.5046235+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "atque",
      "Hidden": false,
      "FullName": "Ms. Geovanny Kihn",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 367
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ab",
      "StrippedValue": "recusandae",
      "Description": "Adaptive modular process improvement",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "recusandae",
      "Description": "Adaptive modular process improvement",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "consequuntur",
      "StrippedValue": "aut",
      "Description": "Seamless zero tolerance protocol",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "scale cross-media platforms"
          },
          "FieldType": "System.String",
          "FieldLength": 86
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "aut",
      "Description": "Seamless zero tolerance protocol",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "scale cross-media platforms"
          },
          "FieldType": "System.String",
          "FieldLength": 86
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "tempora",
      "StrippedValue": "repudiandae",
      "Description": "Seamless value-added strategy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 687
        }
      }
    },
    {
      "Value": "tempora",
      "StrippedValue": "repudiandae",
      "Description": "Seamless value-added strategy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 687
        }
      }
    }
  ],
  "Description": "Triple-buffered next generation intranet",
  "UpdatedBy": {
    "AssociateId": 290,
    "Name": "Hoppe, Schmitt and O'Kon",
    "PersonId": 14,
    "Rank": 155,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 604,
    "FullName": "Henri Luettgen",
    "FormalName": "Mosciski LLC",
    "Deleted": false,
    "EjUserId": 299,
    "UserName": "Boyle, Jakubowski and Bosco",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "envisioneer mission-critical channels"
        },
        "FieldType": "System.String",
        "FieldLength": 383
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 425,
    "Name": "Goyette, Goodwin and Smith",
    "PersonId": 261,
    "Rank": 361,
    "Tooltip": "quos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 932,
    "FullName": "Arvid Heller",
    "FormalName": "Harvey LLC",
    "Deleted": true,
    "EjUserId": 981,
    "UserName": "Abbott-Schaden",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 884
      }
    }
  },
  "Associate": {
    "AssociateId": 802,
    "Name": "Olson LLC",
    "PersonId": 820,
    "Rank": 966,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 724,
    "FullName": "Caleigh Reichel PhD",
    "FormalName": "Mertz LLC",
    "Deleted": false,
    "EjUserId": 918,
    "UserName": "Hammes, Ritchie and Shields",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 212
      }
    }
  },
  "Business": {
    "Id": 246,
    "Value": "rerum",
    "Tooltip": "quam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 114
      }
    }
  },
  "Category": {
    "Id": 239,
    "Value": "possimus",
    "Tooltip": "facere",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 169
      }
    }
  },
  "Country": {
    "CountryId": 374,
    "Name": "Blick-Hills",
    "CurrencyId": 408,
    "EnglishName": "Thompson-White",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Re-engineered leading edge application",
    "OrgNrText": "1275813",
    "InterAreaPrefix": "itaque",
    "DialInPrefix": "qui",
    "ZipPrefix": "aliquam",
    "DomainName": "Rohan-Hahn",
    "AddressLayoutId": 768,
    "DomesticAddressLayoutId": 443,
    "ForeignAddressLayoutId": 149,
    "Rank": 359,
    "Tooltip": "delectus",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 243
      }
    }
  },
  "Persons": [
    {
      "Position": "voluptate",
      "PersonId": 289,
      "Mrmrs": "officiis",
      "Firstname": "Waylon",
      "Lastname": "Gerlach",
      "MiddleName": "Konopelski-Boyle",
      "Title": "in",
      "Description": "Quality-focused exuding knowledge user",
      "Email": "coty.welch@conroy.co.uk",
      "FullName": "Lottie Ernser",
      "DirectPhone": "088-756-1115",
      "FormalName": "Leannon-Jakubowski",
      "CountryId": 996,
      "ContactId": 50,
      "ContactName": "Emard LLC",
      "Retired": 44,
      "Rank": 454,
      "ActiveInterests": 979,
      "ContactDepartment": "",
      "ContactCountryId": 148,
      "ContactOrgNr": "1327432",
      "FaxPhone": "(001)344-5814",
      "MobilePhone": "(275)413-1574 x101",
      "ContactPhone": "456-036-2146 x08711",
      "AssociateName": "Kris, Spencer and Mante",
      "AssociateId": 810,
      "UsePersonAddress": false,
      "ContactFax": "quam",
      "Kanafname": "illum",
      "Kanalname": "voluptatibus",
      "Post1": "facere",
      "Post2": "debitis",
      "Post3": "dicta",
      "EmailName": "adeline_thompson@rowe.co.uk",
      "ContactFullName": "Timothy Kertzmann",
      "ActiveErpLinks": 164,
      "TicketPriorityId": 564,
      "SupportLanguageId": 977,
      "SupportAssociateId": 465,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 526
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "ut",
  "Xstop": true,
  "ActiveInterests": 836,
  "GroupId": 255,
  "ActiveStatusMonitorId": 66,
  "SupportAssociate": {
    "AssociateId": 790,
    "Name": "Kilback Inc and Sons",
    "PersonId": 818,
    "Rank": 72,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 224,
    "FullName": "Liza Block",
    "FormalName": "Mertz, Schmitt and Feil",
    "Deleted": true,
    "EjUserId": 498,
    "UserName": "Runolfsdottir-Abshire",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 514
      }
    }
  },
  "TicketPriority": {
    "Id": 484,
    "Value": "sunt",
    "Tooltip": "minus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 924
      }
    }
  },
  "CustomerLanguage": {
    "Id": 104,
    "Value": "nemo",
    "Tooltip": "consequatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 242
      }
    }
  },
  "Deleted": 975,
  "DbiAgentId": 431,
  "DbiLastSyncronized": "2014-01-31T18:28:48.5503699+01:00",
  "DbiKey": "qui",
  "DbiLastModified": "2018-04-24T18:28:48.5503699+02:00",
  "SupportPerson": {
    "Position": "soluta",
    "PersonId": 340,
    "Mrmrs": "ullam",
    "Firstname": "Otilia",
    "Lastname": "Johnston",
    "MiddleName": "Little-Gutmann",
    "Title": "sequi",
    "Description": "Reduced analyzing initiative",
    "Email": "aleen.weber@considineward.uk",
    "FullName": "Gus Larson I",
    "DirectPhone": "702-703-3060 x316",
    "FormalName": "Rosenbaum, Schoen and Sauer",
    "CountryId": 98,
    "ContactId": 502,
    "ContactName": "Rohan, Balistreri and Jacobson",
    "Retired": 904,
    "Rank": 732,
    "ActiveInterests": 238,
    "ContactDepartment": "",
    "ContactCountryId": 737,
    "ContactOrgNr": "509341",
    "FaxPhone": "758.740.6125",
    "MobilePhone": "208-771-1532 x046",
    "ContactPhone": "520.746.6475 x5612",
    "AssociateName": "Altenwerth, Witting and Donnelly",
    "AssociateId": 90,
    "UsePersonAddress": true,
    "ContactFax": "vel",
    "Kanafname": "recusandae",
    "Kanalname": "quo",
    "Post1": "est",
    "Post2": "rerum",
    "Post3": "vitae",
    "EmailName": "angeline@romaguera.info",
    "ContactFullName": "Marquise Rodriguez",
    "ActiveErpLinks": 217,
    "TicketPriorityId": 370,
    "SupportLanguageId": 231,
    "SupportAssociateId": 116,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 338
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 10589.786,
    "Wgs84Longitude": 25805.356,
    "LocalizedAddress": [
      [
        {
          "Name": "Howe-Abbott",
          "Value": "voluptate",
          "Tooltip": "quis",
          "Label": "eos",
          "ValueLength": 31,
          "AddressType": "molestiae",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "harness holistic e-services"
              },
              "FieldType": "System.String",
              "FieldLength": 349
            }
          }
        }
      ],
      [
        {
          "Name": "Mraz Inc and Sons",
          "Value": "unde",
          "Tooltip": "nemo",
          "Label": "harum",
          "ValueLength": 879,
          "AddressType": "perspiciatis",
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
              "FieldLength": 347
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "sapiente",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 116
      }
    }
  },
  "Source": 292,
  "ActiveErpLinks": 513,
  "BounceEmails": [
    "maureen_mertz@ankunding.com",
    "vesta.stokes@bergesatterfield.ca"
  ],
  "Domains": [
    "aut",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "fugit",
    "ExtraFields2": "delectus"
  },
  "CustomFields": {
    "CustomFields1": "officiis",
    "CustomFields2": "a"
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
      "FieldLength": 848
    }
  }
}
```