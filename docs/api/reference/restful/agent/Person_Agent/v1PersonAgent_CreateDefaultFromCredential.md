---
title: POST Agents/Person/CreateDefaultFromCredential
id: v1PersonAgent_CreateDefaultFromCredential
---

# POST Agents/Person/CreateDefaultFromCredential

```http
POST /api/v1/Agents/Person/CreateDefaultFromCredential
```

Creates a PersonEntity with default values based on the contactId and credentials.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/CreateDefaultFromCredential?$select=name,department,category/id
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

ContactId, CredentialType, CredentialValue, CredentialDisplayValue 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |
| CredentialType | string |  |
| CredentialValue | string |  |
| CredentialDisplayValue | string |  |


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as Date |
| CreatedBy |  | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position |  | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy |  | The person that last updated the person object |
| Contact |  | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country |  | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address |  | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate |  | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category |  | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business |  | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate |  | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo |  | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Person/CreateDefaultFromCredential
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 980,
  "CredentialType": "culpa",
  "CredentialValue": "iste",
  "CredentialDisplayValue": "et"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 727,
  "Firstname": "Pierre",
  "MiddleName": "Gorczany, Keeling and Jacobs",
  "Lastname": "Batz",
  "Mrmrs": "qui",
  "Title": "ullam",
  "UpdatedDate": "2017-11-06T18:28:49.7261421+01:00",
  "CreatedDate": "2011-11-07T18:28:49.7261421+01:00",
  "BirthDate": "2005-01-21T18:28:49.7261421+01:00",
  "CreatedBy": {
    "AssociateId": 893,
    "Name": "Jacobs, McKenzie and Cole",
    "PersonId": 536,
    "Rank": 930,
    "Tooltip": "neque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 181,
    "FullName": "Stephen Veum",
    "FormalName": "Hettinger LLC",
    "Deleted": false,
    "EjUserId": 20,
    "UserName": "Homenick, Greenholt and Predovic",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 552
      }
    }
  },
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "illum",
      "Description": "Robust upward-trending matrix",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "illum",
      "Description": "Robust upward-trending matrix",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    }
  ],
  "Description": "Operative bifurcated support",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "ut",
      "StrippedValue": "quae",
      "Description": "Object-based bandwidth-monitored encryption",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 131
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "quae",
      "Description": "Object-based bandwidth-monitored encryption",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 131
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "incidunt",
      "StrippedValue": "beatae",
      "Description": "Visionary analyzing application",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 72
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "beatae",
      "Description": "Visionary analyzing application",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 72
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "in",
      "StrippedValue": "ullam",
      "Description": "Balanced full-range frame",
      "TableRight": {},
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
    },
    {
      "Value": "in",
      "StrippedValue": "ullam",
      "Description": "Balanced full-range frame",
      "TableRight": {},
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
  ],
  "OfficePhones": [
    {
      "Value": "distinctio",
      "StrippedValue": "voluptatem",
      "Description": "Multi-layered local Graphical User Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "brand value-added systems"
          },
          "FieldType": "System.Int32",
          "FieldLength": 371
        }
      }
    },
    {
      "Value": "distinctio",
      "StrippedValue": "voluptatem",
      "Description": "Multi-layered local Graphical User Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "brand value-added systems"
          },
          "FieldType": "System.Int32",
          "FieldLength": 371
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "omnis",
      "StrippedValue": "vero",
      "Description": "Multi-lateral bottom-line approach",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 700
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "vero",
      "Description": "Multi-lateral bottom-line approach",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 700
        }
      }
    }
  ],
  "Position": {
    "Id": 587,
    "Value": "beatae",
    "Tooltip": "vero",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 404
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 579,
    "Name": "Reinger, O'Reilly and Mertz",
    "PersonId": 500,
    "Rank": 562,
    "Tooltip": "similique",
    "Type": "AnonymousAssociate",
    "GroupIdx": 545,
    "FullName": "Vincenza Ward",
    "FormalName": "Swaniawski, Heidenreich and Stamm",
    "Deleted": false,
    "EjUserId": 725,
    "UserName": "Mills, Boyer and Mante",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 347
      }
    }
  },
  "Contact": {
    "ContactId": 924,
    "Name": "Larkin Inc and Sons",
    "OrgNr": "494061",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "dolorem",
    "DirectPhone": "1-285-048-2852",
    "AssociateId": 292,
    "CountryId": 4,
    "EmailAddress": "assunta.leffler@wolfspinka.com",
    "Kananame": "impedit",
    "EmailAddressName": "cristopher@hamill.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Santa Conn",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quae",
    "FullName": "Ms. Kaela Champlin",
    "IsOwnerContact": false,
    "ActiveErpLinks": 118,
    "TableRight": {},
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
  },
  "Country": {
    "CountryId": 95,
    "Name": "VonRueden Group",
    "CurrencyId": 430,
    "EnglishName": "Swaniawski, Nolan and Schumm",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Multi-tiered multi-tasking encryption",
    "OrgNrText": "1388507",
    "InterAreaPrefix": "recusandae",
    "DialInPrefix": "pariatur",
    "ZipPrefix": "animi",
    "DomainName": "Collier, Simonis and Wilkinson",
    "AddressLayoutId": 508,
    "DomesticAddressLayoutId": 505,
    "ForeignAddressLayoutId": 789,
    "Rank": 401,
    "Tooltip": "vero",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 41
      }
    }
  },
  "Interests": [
    {
      "Id": 162,
      "Name": "Mayer Group",
      "ToolTip": "Deleniti modi voluptatem reiciendis.",
      "Deleted": true,
      "Rank": 701,
      "Type": "cumque",
      "ColorBlock": 750,
      "IconHint": "hic",
      "Selected": true,
      "LastChanged": "2009-11-02T18:28:49.7281082+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "excepturi",
      "StyleHint": "modi",
      "Hidden": false,
      "FullName": "Tia Boehm IV",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 841
        }
      }
    }
  ],
  "PersonNumber": "1037779",
  "FullName": "Daisha Roberts",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "provident",
      "StrippedValue": "at",
      "Description": "Organized scalable info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 911
        }
      }
    },
    {
      "Value": "provident",
      "StrippedValue": "at",
      "Description": "Organized scalable info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 911
        }
      }
    }
  ],
  "FormalName": "Howe-Gutmann",
  "Address": {
    "Wgs84Latitude": 29149.334,
    "Wgs84Longitude": 2507.2,
    "LocalizedAddress": [
      [
        {
          "Name": "Fahey, Hayes and Roberts",
          "Value": "consequatur",
          "Tooltip": "commodi",
          "Label": "ut",
          "ValueLength": 775,
          "AddressType": "et",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "utilize collaborative methodologies"
              },
              "FieldType": "System.Int32",
              "FieldLength": 371
            }
          }
        }
      ],
      [
        {
          "Name": "Kassulke-Kirlin",
          "Value": "qui",
          "Tooltip": "quae",
          "Label": "qui",
          "ValueLength": 621,
          "AddressType": "porro",
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
              "FieldLength": 117
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 553
      }
    }
  },
  "Post3": "quia",
  "Post2": "unde",
  "Post1": "ex",
  "Kanalname": "hic",
  "Kanafname": "error",
  "CorrespondingAssociate": {
    "AssociateId": 841,
    "Name": "Green, Jacobs and Denesik",
    "PersonId": 583,
    "Rank": 316,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 740,
    "FullName": "Dejuan Ratke Sr.",
    "FormalName": "Aufderhar, Sipes and Mante",
    "Deleted": false,
    "EjUserId": 705,
    "UserName": "Huel-Turcotte",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 500
      }
    }
  },
  "Category": {
    "Id": 111,
    "Value": "voluptatem",
    "Tooltip": "dolor",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 147
      }
    }
  },
  "Business": {
    "Id": 611,
    "Value": "fugiat",
    "Tooltip": "accusamus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 995
      }
    }
  },
  "Associate": {
    "AssociateId": 877,
    "Name": "Kerluke-Miller",
    "PersonId": 338,
    "Rank": 526,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 488,
    "FullName": "Giles McLaughlin",
    "FormalName": "Hodkiewicz-Schultz",
    "Deleted": false,
    "EjUserId": 995,
    "UserName": "Labadie, Jaskolski and Leffler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 412
      }
    }
  },
  "Salutation": "id",
  "ActiveInterests": 564,
  "SupportAssociate": {
    "AssociateId": 836,
    "Name": "Langosh-Bogisich",
    "PersonId": 819,
    "Rank": 826,
    "Tooltip": "veritatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 761,
    "FullName": "Rosina Littel",
    "FormalName": "Dicki, Schultz and Roob",
    "Deleted": true,
    "EjUserId": 448,
    "UserName": "Halvorson-Davis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 588
      }
    }
  },
  "TicketPriority": {
    "Id": 349,
    "Value": "distinctio",
    "Tooltip": "molestiae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 30
      }
    }
  },
  "CustomerLanguage": {
    "Id": 82,
    "Value": "corporis",
    "Tooltip": "distinctio",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 235
      }
    }
  },
  "DbiAgentId": 155,
  "DbiKey": "eos",
  "DbiLastModified": "2003-06-22T18:28:49.7321401+02:00",
  "DbiLastSyncronized": "1998-09-20T18:28:49.7321401+02:00",
  "SentInfo": 964,
  "ShowContactTickets": 780,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 458,
    "UserName": "Flatley LLC",
    "PersonId": 454,
    "Rank": 526,
    "Tooltip": "incidunt",
    "UserGroupId": 479,
    "EjUserId": 1000,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "fugiat",
      "sed"
    ],
    "CanLogon": false,
    "RoleName": "Brown, Schowalter and Klein",
    "RoleTooltip": "repellendus",
    "UserGroupName": "Macejkovic-Abbott",
    "UserGroupTooltip": "quo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 738
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "quis",
      "StrippedValue": "dolorem",
      "Description": "Horizontal global framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 544
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "dolorem",
      "Description": "Horizontal global framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 544
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "quibusdam",
      "StrippedValue": "id",
      "Description": "Intuitive 4th generation hub",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 154
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "id",
      "Description": "Intuitive 4th generation hub",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 154
        }
      }
    }
  ],
  "Source": 325,
  "ActiveErpLinks": 148,
  "ShipmentTypes": [
    {
      "Id": 671,
      "Name": "Parisian-O'Hara",
      "ToolTip": "Est magni molestias et voluptatem nihil.",
      "Deleted": true,
      "Rank": 300,
      "Type": "voluptas",
      "ColorBlock": 443,
      "IconHint": "atque",
      "Selected": true,
      "LastChanged": "1996-04-21T18:28:49.7321401+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "id",
      "StyleHint": "quia",
      "Hidden": true,
      "FullName": "Peyton Dietrich",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 546
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 966,
      "Comment": "dolores",
      "Registered": "2001-10-27T18:28:49.7331375+02:00",
      "RegisteredAssociateId": 751,
      "Updated": "2002-02-21T18:28:49.7331375+01:00",
      "UpdatedAssociateId": 898,
      "LegalBaseId": 794,
      "LegalBaseKey": "aperiam",
      "LegalBaseName": "Lesch-O'Hara",
      "ConsentPurposeId": 584,
      "ConsentPurposeKey": "sunt",
      "ConsentPurposeName": "Lockman-Huels",
      "ConsentSourceId": 256,
      "ConsentSourceKey": "iure",
      "ConsentSourceName": "Bergstrom-Rutherford",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 894
        }
      }
    }
  ],
  "BounceEmails": [
    "ole_gibson@dickens.uk",
    "mason@mcdermott.biz"
  ],
  "ActiveStatusMonitorId": 226,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Chyna Keebler"
  },
  "ExtraFields": {
    "ExtraFields1": "quisquam",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "sapiente",
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
      "FieldType": "System.Int32",
      "FieldLength": 277
    }
  }
}
```