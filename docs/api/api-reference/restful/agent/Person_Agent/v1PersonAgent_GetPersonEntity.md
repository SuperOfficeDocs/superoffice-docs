---
title: GetPersonEntity
id: v1PersonAgent_GetPersonEntity
---

# GetPersonEntity

```http
POST /api/v1/Agents/Person/GetPersonEntity
```

Gets a PersonEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| personEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonEntity?personEntityId=839
POST /api/v1/Agents/Person/GetPersonEntity?$select=name,department,category/id
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
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Person/GetPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 501,
  "Firstname": "Filomena",
  "MiddleName": "Towne-Kunze",
  "Lastname": "Bayer",
  "Mrmrs": "dolorem",
  "Title": "laborum",
  "UpdatedDate": "2004-01-23T14:58:04.6664621+01:00",
  "CreatedDate": "1998-08-20T14:58:04.6664621+02:00",
  "BirthDate": "2018-08-13T14:58:04.6664621+02:00",
  "CreatedBy": {
    "AssociateId": 111,
    "Name": "Bartoletti Group",
    "PersonId": 175,
    "Rank": 465,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 724,
    "FullName": "Autumn Reilly",
    "FormalName": "Howe, Cronin and Flatley",
    "Deleted": true,
    "EjUserId": 76,
    "UserName": "Dach, McCullough and Hoeger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "expedite best-of-breed convergence"
        },
        "FieldType": "System.String",
        "FieldLength": 396
      }
    }
  },
  "Emails": [
    {
      "Value": "sint",
      "StrippedValue": "repellendus",
      "Description": "Inverse system-worthy initiative",
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
    {
      "Value": "sint",
      "StrippedValue": "repellendus",
      "Description": "Inverse system-worthy initiative",
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
    }
  ],
  "Description": "Customizable context-sensitive migration",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "est",
      "StrippedValue": "iusto",
      "Description": "Adaptive regional internet solution",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 528
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "iusto",
      "Description": "Adaptive regional internet solution",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 528
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eos",
      "StrippedValue": "sed",
      "Description": "Balanced full-range service-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 436
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "sed",
      "Description": "Balanced full-range service-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 436
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "corrupti",
      "StrippedValue": "nam",
      "Description": "Profound static secured line",
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
    {
      "Value": "corrupti",
      "StrippedValue": "nam",
      "Description": "Profound static secured line",
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
    }
  ],
  "OfficePhones": [
    {
      "Value": "quia",
      "StrippedValue": "ut",
      "Description": "Cloned user-facing methodology",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 845
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "ut",
      "Description": "Cloned user-facing methodology",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 845
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "aut",
      "StrippedValue": "quo",
      "Description": "Public-key coherent help-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 361
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "quo",
      "Description": "Public-key coherent help-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 361
        }
      }
    }
  ],
  "Position": {
    "Id": 360,
    "Value": "expedita",
    "Tooltip": "nisi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 917
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 922,
    "Name": "Cremin LLC",
    "PersonId": 553,
    "Rank": 678,
    "Tooltip": "laboriosam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 266,
    "FullName": "Miss Miracle Boyer",
    "FormalName": "Lemke-Gutmann",
    "Deleted": false,
    "EjUserId": 159,
    "UserName": "Mertz-Prohaska",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 965
      }
    }
  },
  "Contact": {
    "ContactId": 29,
    "Name": "Crona-McGlynn",
    "OrgNr": "1339321",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "et",
    "DirectPhone": "1-761-030-3086 x5603",
    "AssociateId": 41,
    "CountryId": 179,
    "EmailAddress": "bertram.emmerich@huels.ca",
    "Kananame": "dolor",
    "EmailAddressName": "elvera@friesen.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Merritt Marvin",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ratione",
    "FullName": "Jettie Goyette DVM",
    "IsOwnerContact": false,
    "ActiveErpLinks": 472,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 770
      }
    }
  },
  "Country": {
    "CountryId": 550,
    "Name": "Halvorson LLC",
    "CurrencyId": 480,
    "EnglishName": "Lowe, Kassulke and Fritsch",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Organized executive core",
    "OrgNrText": "1023198",
    "InterAreaPrefix": "rerum",
    "DialInPrefix": "quo",
    "ZipPrefix": "ipsum",
    "DomainName": "Koepp, Hudson and Howell",
    "AddressLayoutId": 894,
    "DomesticAddressLayoutId": 820,
    "ForeignAddressLayoutId": 937,
    "Rank": 246,
    "Tooltip": "consequatur",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 764
      }
    }
  },
  "Interests": [
    {
      "Id": 466,
      "Name": "McCullough, Kihn and Kohler",
      "ToolTip": "Veniam quia non dolor.",
      "Deleted": false,
      "Rank": 588,
      "Type": "laborum",
      "ColorBlock": 230,
      "IconHint": "laborum",
      "Selected": false,
      "LastChanged": "2011-03-15T14:58:04.6684606+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vitae",
      "StyleHint": "non",
      "Hidden": false,
      "FullName": "Odie Haag",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 5
        }
      }
    }
  ],
  "PersonNumber": "1109978",
  "FullName": "Rosamond Purdy",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "sit",
      "Description": "Phased transitional core",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 143
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "sit",
      "Description": "Phased transitional core",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 143
        }
      }
    }
  ],
  "FormalName": "Nader-Fisher",
  "Address": {
    "Wgs84Latitude": 10138.49,
    "Wgs84Longitude": 21267.324,
    "LocalizedAddress": [
      [
        {
          "Name": "Abshire-Wunsch",
          "Value": "optio",
          "Tooltip": "eum",
          "Label": "eveniet",
          "ValueLength": 780,
          "AddressType": "dicta",
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
              "FieldLength": 632
            }
          }
        }
      ],
      [
        {
          "Name": "Predovic-Weimann",
          "Value": "voluptatem",
          "Tooltip": "molestiae",
          "Label": "tempore",
          "ValueLength": 605,
          "AddressType": "libero",
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
              "FieldLength": 702
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "deleniti",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 67
      }
    }
  },
  "Post3": "eum",
  "Post2": "ratione",
  "Post1": "accusamus",
  "Kanalname": "exercitationem",
  "Kanafname": "alias",
  "CorrespondingAssociate": {
    "AssociateId": 697,
    "Name": "Rippin-Schoen",
    "PersonId": 687,
    "Rank": 290,
    "Tooltip": "eligendi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 781,
    "FullName": "Daphnee Jaskolski",
    "FormalName": "Upton Inc and Sons",
    "Deleted": true,
    "EjUserId": 823,
    "UserName": "Stroman, Feeney and Ritchie",
    "TableRight": {},
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
  },
  "Category": {
    "Id": 166,
    "Value": "quasi",
    "Tooltip": "eum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 674
      }
    }
  },
  "Business": {
    "Id": 552,
    "Value": "quos",
    "Tooltip": "placeat",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 231
      }
    }
  },
  "Associate": {
    "AssociateId": 93,
    "Name": "Johnson LLC",
    "PersonId": 239,
    "Rank": 778,
    "Tooltip": "tenetur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 432,
    "FullName": "Verlie Wehner",
    "FormalName": "Herman, Dickinson and Casper",
    "Deleted": true,
    "EjUserId": 621,
    "UserName": "Wiegand-Cummings",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 360
      }
    }
  },
  "Salutation": "ut",
  "ActiveInterests": 808,
  "SupportAssociate": {
    "AssociateId": 56,
    "Name": "Leffler, Graham and Klocko",
    "PersonId": 785,
    "Rank": 400,
    "Tooltip": "facilis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 297,
    "FullName": "Selena Haley",
    "FormalName": "Mertz, Rau and Moore",
    "Deleted": true,
    "EjUserId": 143,
    "UserName": "Murazik, Bayer and Bogan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 197
      }
    }
  },
  "TicketPriority": {
    "Id": 381,
    "Value": "debitis",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 244
      }
    }
  },
  "CustomerLanguage": {
    "Id": 671,
    "Value": "vitae",
    "Tooltip": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 149
      }
    }
  },
  "DbiAgentId": 76,
  "DbiKey": "et",
  "DbiLastModified": "2009-07-02T14:58:04.6704602+02:00",
  "DbiLastSyncronized": "2004-09-10T14:58:04.6704602+02:00",
  "SentInfo": 747,
  "ShowContactTickets": 165,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 986,
    "UserName": "Prohaska-Kessler",
    "PersonId": 385,
    "Rank": 182,
    "Tooltip": "sed",
    "UserGroupId": 692,
    "EjUserId": 462,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "ut",
      "debitis"
    ],
    "CanLogon": true,
    "RoleName": "Beahan-Collier",
    "RoleTooltip": "amet",
    "UserGroupName": "Cormier, Anderson and Ruecker",
    "UserGroupTooltip": "sed",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 565
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "eum",
      "StrippedValue": "neque",
      "Description": "Advanced zero defect projection",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 752
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "neque",
      "Description": "Advanced zero defect projection",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 752
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "sit",
      "StrippedValue": "in",
      "Description": "Devolved encompassing utilisation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "incubate seamless initiatives"
          },
          "FieldType": "System.String",
          "FieldLength": 287
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "in",
      "Description": "Devolved encompassing utilisation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "incubate seamless initiatives"
          },
          "FieldType": "System.String",
          "FieldLength": 287
        }
      }
    }
  ],
  "Source": 281,
  "ActiveErpLinks": 692,
  "ShipmentTypes": [
    {
      "Id": 682,
      "Name": "Wolff-Schamberger",
      "ToolTip": "Possimus eveniet doloremque consequatur consequatur similique et.",
      "Deleted": true,
      "Rank": 555,
      "Type": "fugiat",
      "ColorBlock": 766,
      "IconHint": "ut",
      "Selected": true,
      "LastChanged": "2017-10-02T14:58:04.6734599+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "in",
      "StyleHint": "explicabo",
      "Hidden": false,
      "FullName": "Yolanda Leannon",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 732
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 294,
      "Comment": "expedita",
      "Registered": "2012-11-06T14:58:04.6734599+01:00",
      "RegisteredAssociateId": 432,
      "Updated": "1999-03-08T14:58:04.6734599+01:00",
      "UpdatedAssociateId": 678,
      "LegalBaseId": 123,
      "LegalBaseKey": "quia",
      "LegalBaseName": "Sanford, Brekke and Huel",
      "ConsentPurposeId": 537,
      "ConsentPurposeKey": "omnis",
      "ConsentPurposeName": "Durgan-Auer",
      "ConsentSourceId": 151,
      "ConsentSourceKey": "quos",
      "ConsentSourceName": "Carter Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 511
        }
      }
    }
  ],
  "BounceEmails": [
    "hailie@collins.co.uk",
    "esther_mclaughlin@gutmann.info"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Else Dare DDS",
    "SuperOffice:2": "Krista Rodriguez"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "minus"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "voluptas"
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
      "FieldLength": 104
    }
  }
}
```