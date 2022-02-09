---
title: POST Agents/Contact/ChangeCountry
id: v1ContactAgent_ChangeCountry
---

# POST Agents/Contact/ChangeCountry

```http
POST /api/v1/Agents/Contact/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/ChangeCountry?$select=name,department,category/id
```


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

## Request Body: request  

ContactEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity |  | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| ToCountryId | int32 |  |


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
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": {
    "ContactId": 296,
    "Name": "Bartell-Dietrich",
    "Department": "",
    "OrgNr": "1295692",
    "Number1": "717600",
    "Number2": "1368228",
    "UpdatedDate": "2013-09-09T18:28:48.5669269+02:00",
    "CreatedDate": "2017-12-02T18:28:48.5669269+01:00",
    "Emails": [
      {},
      {}
    ],
    "Interests": [
      {},
      {}
    ],
    "Urls": [
      {},
      {}
    ],
    "Phones": [
      {},
      {}
    ],
    "Faxes": [
      {},
      {}
    ],
    "Description": "Optimized uniform info-mediaries",
    "UpdatedBy": {},
    "CreatedBy": {},
    "Associate": {},
    "Business": {},
    "Category": {},
    "Country": {},
    "Persons": [
      {},
      {}
    ],
    "NoMailing": false,
    "Kananame": "voluptas",
    "Xstop": true,
    "ActiveInterests": 548,
    "GroupId": 203,
    "ActiveStatusMonitorId": 272,
    "SupportAssociate": {},
    "TicketPriority": {},
    "CustomerLanguage": {},
    "Deleted": 940,
    "DbiAgentId": 817,
    "DbiLastSyncronized": "2009-04-05T18:28:48.5669269+02:00",
    "DbiKey": "veritatis",
    "DbiLastModified": "2011-06-06T18:28:48.5669269+02:00",
    "SupportPerson": {},
    "Address": {},
    "Source": 775,
    "ActiveErpLinks": 555,
    "BounceEmails": [
      "rosalyn@wuckert.ca",
      "colten@aufderhar.us"
    ],
    "Domains": [
      "qui",
      "omnis"
    ],
    "UserDefinedFields": {
      "SuperOffice:1": "True",
      "SuperOffice:2": "1591912843"
    },
    "ExtraFields": {
      "ExtraFields1": "qui",
      "ExtraFields2": "veritatis"
    },
    "CustomFields": {
      "CustomFields1": "vel",
      "CustomFields2": "veniam"
    }
  },
  "ToCountryId": 403
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 745,
  "Name": "Moen, Weimann and Johnson",
  "Department": "",
  "OrgNr": "653345",
  "Number1": "1036920",
  "Number2": "866732",
  "UpdatedDate": "2011-10-30T18:28:48.5749572+01:00",
  "CreatedDate": "2012-11-21T18:28:48.5749572+01:00",
  "Emails": [
    {
      "Value": "rerum",
      "StrippedValue": "praesentium",
      "Description": "Monitored secondary throughput",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 209
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "praesentium",
      "Description": "Monitored secondary throughput",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 209
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 810,
      "Name": "Schneider-Cormier",
      "ToolTip": "Aut eos mollitia nemo.",
      "Deleted": true,
      "Rank": 646,
      "Type": "sed",
      "ColorBlock": 706,
      "IconHint": "in",
      "Selected": false,
      "LastChanged": "2019-10-28T18:28:48.5759565+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "saepe",
      "StyleHint": "fugit",
      "Hidden": true,
      "FullName": "Lelia Grant DDS",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 717
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "laborum",
      "Description": "Multi-channelled eco-centric function",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 133
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "laborum",
      "Description": "Multi-channelled eco-centric function",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 133
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quia",
      "StrippedValue": "facilis",
      "Description": "Persevering radical system engine",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "productize out-of-the-box architectures"
          },
          "FieldType": "System.Int32",
          "FieldLength": 696
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "facilis",
      "Description": "Persevering radical system engine",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "productize out-of-the-box architectures"
          },
          "FieldType": "System.Int32",
          "FieldLength": 696
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "animi",
      "StrippedValue": "ab",
      "Description": "Configurable analyzing portal",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 846
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "ab",
      "Description": "Configurable analyzing portal",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 846
        }
      }
    }
  ],
  "Description": "Multi-lateral asynchronous analyzer",
  "UpdatedBy": {
    "AssociateId": 257,
    "Name": "Conn-Waelchi",
    "PersonId": 896,
    "Rank": 631,
    "Tooltip": "architecto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 962,
    "FullName": "Alayna Conn",
    "FormalName": "Batz-Runolfsdottir",
    "Deleted": true,
    "EjUserId": 592,
    "UserName": "Von Inc and Sons",
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
  "CreatedBy": {
    "AssociateId": 931,
    "Name": "Wiegand-Murphy",
    "PersonId": 166,
    "Rank": 803,
    "Tooltip": "distinctio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 982,
    "FullName": "Raoul Senger",
    "FormalName": "Schumm-Nitzsche",
    "Deleted": true,
    "EjUserId": 986,
    "UserName": "Hayes-Boehm",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "optimize bricks-and-clicks experiences"
        },
        "FieldType": "System.Int32",
        "FieldLength": 185
      }
    }
  },
  "Associate": {
    "AssociateId": 176,
    "Name": "Lemke LLC",
    "PersonId": 253,
    "Rank": 151,
    "Tooltip": "labore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 447,
    "FullName": "Carmelo Metz",
    "FormalName": "Gibson-Nicolas",
    "Deleted": true,
    "EjUserId": 952,
    "UserName": "Walsh-Konopelski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 255
      }
    }
  },
  "Business": {
    "Id": 548,
    "Value": "repellat",
    "Tooltip": "debitis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 929
      }
    }
  },
  "Category": {
    "Id": 488,
    "Value": "ducimus",
    "Tooltip": "natus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 541
      }
    }
  },
  "Country": {
    "CountryId": 908,
    "Name": "Jones-Roberts",
    "CurrencyId": 724,
    "EnglishName": "Kuhic, Sanford and Sanford",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Front-line empowering paradigm",
    "OrgNrText": "1248283",
    "InterAreaPrefix": "quia",
    "DialInPrefix": "praesentium",
    "ZipPrefix": "reiciendis",
    "DomainName": "Littel Inc and Sons",
    "AddressLayoutId": 613,
    "DomesticAddressLayoutId": 671,
    "ForeignAddressLayoutId": 876,
    "Rank": 415,
    "Tooltip": "magni",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 737
      }
    }
  },
  "Persons": [
    {
      "Position": "sed",
      "PersonId": 830,
      "Mrmrs": "delectus",
      "Firstname": "Erica",
      "Lastname": "Ryan",
      "MiddleName": "Casper Group",
      "Title": "numquam",
      "Description": "Persevering hybrid moderator",
      "Email": "russell.reynolds@hahnhessel.us",
      "FullName": "April Stamm",
      "DirectPhone": "(253)207-1554",
      "FormalName": "Kulas, Nitzsche and Douglas",
      "CountryId": 130,
      "ContactId": 423,
      "ContactName": "Huel LLC",
      "Retired": 289,
      "Rank": 915,
      "ActiveInterests": 543,
      "ContactDepartment": "",
      "ContactCountryId": 534,
      "ContactOrgNr": "1248847",
      "FaxPhone": "(338)061-0446",
      "MobilePhone": "033.803.8603 x188",
      "ContactPhone": "553-637-5546 x164",
      "AssociateName": "Hirthe LLC",
      "AssociateId": 728,
      "UsePersonAddress": false,
      "ContactFax": "id",
      "Kanafname": "et",
      "Kanalname": "doloribus",
      "Post1": "rerum",
      "Post2": "eaque",
      "Post3": "saepe",
      "EmailName": "janessa@mertz.biz",
      "ContactFullName": "Aylin Thompson",
      "ActiveErpLinks": 20,
      "TicketPriorityId": 495,
      "SupportLanguageId": 860,
      "SupportAssociateId": 685,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 784
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "tempore",
  "Xstop": false,
  "ActiveInterests": 255,
  "GroupId": 238,
  "ActiveStatusMonitorId": 138,
  "SupportAssociate": {
    "AssociateId": 555,
    "Name": "Heller, Gleichner and Jaskolski",
    "PersonId": 279,
    "Rank": 531,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 700,
    "FullName": "Shaun Berge",
    "FormalName": "Stamm, Adams and Marvin",
    "Deleted": false,
    "EjUserId": 720,
    "UserName": "DuBuque, Davis and Feil",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 695
      }
    }
  },
  "TicketPriority": {
    "Id": 884,
    "Value": "qui",
    "Tooltip": "optio",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 375
      }
    }
  },
  "CustomerLanguage": {
    "Id": 452,
    "Value": "id",
    "Tooltip": "ad",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 613
      }
    }
  },
  "Deleted": 983,
  "DbiAgentId": 723,
  "DbiLastSyncronized": "2007-06-21T18:28:48.579956+02:00",
  "DbiKey": "nam",
  "DbiLastModified": "1996-05-02T18:28:48.579956+02:00",
  "SupportPerson": {
    "Position": "sint",
    "PersonId": 349,
    "Mrmrs": "sint",
    "Firstname": "Bettie",
    "Lastname": "Corkery",
    "MiddleName": "Kris Group",
    "Title": "quam",
    "Description": "Robust homogeneous analyzer",
    "Email": "joan@kovacek.com",
    "FullName": "Jonathon Yost DVM",
    "DirectPhone": "400.115.7611",
    "FormalName": "Heaney Inc and Sons",
    "CountryId": 305,
    "ContactId": 366,
    "ContactName": "O'Conner Group",
    "Retired": 803,
    "Rank": 411,
    "ActiveInterests": 576,
    "ContactDepartment": "",
    "ContactCountryId": 559,
    "ContactOrgNr": "787221",
    "FaxPhone": "002.273.4852",
    "MobilePhone": "617-867-2251 x240",
    "ContactPhone": "515.584.7504 x648",
    "AssociateName": "Stark Group",
    "AssociateId": 324,
    "UsePersonAddress": false,
    "ContactFax": "quo",
    "Kanafname": "illum",
    "Kanalname": "et",
    "Post1": "cum",
    "Post2": "molestiae",
    "Post3": "reiciendis",
    "EmailName": "june.quitzon@daniel.us",
    "ContactFullName": "Marlin Lowe",
    "ActiveErpLinks": 75,
    "TicketPriorityId": 106,
    "SupportLanguageId": 414,
    "SupportAssociateId": 231,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 441
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 24796.208,
    "Wgs84Longitude": 27983.486,
    "LocalizedAddress": [
      [
        {
          "Name": "Homenick-Hills",
          "Value": "possimus",
          "Tooltip": "sequi",
          "Label": "veniam",
          "ValueLength": 297,
          "AddressType": "facilis",
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
              "FieldLength": 21
            }
          }
        }
      ],
      [
        {
          "Name": "Trantow, Zemlak and Yost",
          "Value": "nesciunt",
          "Tooltip": "quo",
          "Label": "sed",
          "ValueLength": 680,
          "AddressType": "non",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "evolve global platforms"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "syndicate plug-and-play users"
              },
              "FieldType": "System.String",
              "FieldLength": 400
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "fuga",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 14
      }
    }
  },
  "Source": 817,
  "ActiveErpLinks": 808,
  "BounceEmails": [
    "nola@tromp.com",
    "ally_wiegand@medhurst.uk"
  ],
  "Domains": [
    "tenetur",
    "quasi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "152250972",
    "SuperOffice:2": "1610899743"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "veritatis"
  },
  "CustomFields": {
    "CustomFields1": "voluptatum",
    "CustomFields2": "quo"
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
      "FieldLength": 267
    }
  }
}
```