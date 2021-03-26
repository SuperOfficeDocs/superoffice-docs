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
  "ContactId": 614,
  "CredentialType": "excepturi",
  "CredentialValue": "est",
  "CredentialDisplayValue": "animi"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 643,
  "Firstname": "Griffin",
  "MiddleName": "Bogan, Okuneva and Nikolaus",
  "Lastname": "Roob",
  "Mrmrs": "sequi",
  "Title": "aperiam",
  "UpdatedDate": "2016-10-19T16:48:30.1819383+02:00",
  "CreatedDate": "2004-06-14T16:48:30.1819383+02:00",
  "BirthDate": "2007-03-03T16:48:30.1819383+01:00",
  "CreatedBy": {
    "AssociateId": 767,
    "Name": "Weissnat Group",
    "PersonId": 457,
    "Rank": 179,
    "Tooltip": "tempora",
    "Type": "AnonymousAssociate",
    "GroupIdx": 292,
    "FullName": "Evalyn Cronin",
    "FormalName": "Haag Inc and Sons",
    "Deleted": true,
    "EjUserId": 749,
    "UserName": "Cronin-Kiehn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 864
      }
    }
  },
  "Emails": [
    {
      "Value": "quasi",
      "StrippedValue": "dolor",
      "Description": "Ergonomic transitional definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "dolor",
      "Description": "Ergonomic transitional definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    }
  ],
  "Description": "Monitored intangible hub",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "esse",
      "StrippedValue": "occaecati",
      "Description": "De-engineered eco-centric infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 207
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "occaecati",
      "Description": "De-engineered eco-centric infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 207
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "id",
      "StrippedValue": "quasi",
      "Description": "Integrated bandwidth-monitored adapter",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 269
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "quasi",
      "Description": "Integrated bandwidth-monitored adapter",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 269
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "consectetur",
      "StrippedValue": "rerum",
      "Description": "Automated homogeneous help-desk",
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
      "Value": "consectetur",
      "StrippedValue": "rerum",
      "Description": "Automated homogeneous help-desk",
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
  "OfficePhones": [
    {
      "Value": "expedita",
      "StrippedValue": "ea",
      "Description": "Open-architected radical intranet",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 138
        }
      }
    },
    {
      "Value": "expedita",
      "StrippedValue": "ea",
      "Description": "Open-architected radical intranet",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 138
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "dolorum",
      "StrippedValue": "nulla",
      "Description": "Phased encompassing flexibility",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 289
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "nulla",
      "Description": "Phased encompassing flexibility",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 289
        }
      }
    }
  ],
  "Position": {
    "Id": 235,
    "Value": "omnis",
    "Tooltip": "non",
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
  "UpdatedBy": {
    "AssociateId": 372,
    "Name": "Zieme, Quigley and Schinner",
    "PersonId": 39,
    "Rank": 994,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 587,
    "FullName": "Rowland Vandervort",
    "FormalName": "Ruecker Inc and Sons",
    "Deleted": true,
    "EjUserId": 872,
    "UserName": "Langosh Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 426
      }
    }
  },
  "Contact": {
    "ContactId": 666,
    "Name": "Hodkiewicz-Fadel",
    "OrgNr": "462745",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "voluptas",
    "DirectPhone": "1-570-536-1106",
    "AssociateId": 384,
    "CountryId": 457,
    "EmailAddress": "garth.block@bayer.co.uk",
    "Kananame": "eum",
    "EmailAddressName": "gabrielle.hilll@batz.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Rosendo Considine",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "dolores",
    "FullName": "Cali Gulgowski",
    "IsOwnerContact": false,
    "ActiveErpLinks": 788,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 75
      }
    }
  },
  "Country": {
    "CountryId": 43,
    "Name": "Abernathy Inc and Sons",
    "CurrencyId": 799,
    "EnglishName": "Bergnaum Inc and Sons",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Configurable multimedia leverage",
    "OrgNrText": "1106969",
    "InterAreaPrefix": "velit",
    "DialInPrefix": "et",
    "ZipPrefix": "consequatur",
    "DomainName": "Hyatt, Lemke and Hagenes",
    "AddressLayoutId": 810,
    "DomesticAddressLayoutId": 242,
    "ForeignAddressLayoutId": 162,
    "Rank": 932,
    "Tooltip": "corporis",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 894
      }
    }
  },
  "Interests": [
    {
      "Id": 331,
      "Name": "Hettinger Inc and Sons",
      "ToolTip": "A voluptas ut.",
      "Deleted": false,
      "Rank": 500,
      "Type": "eveniet",
      "ColorBlock": 402,
      "IconHint": "aspernatur",
      "Selected": false,
      "LastChanged": "2013-05-05T16:48:30.1839352+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "cum",
      "Hidden": false,
      "FullName": "Clementine Ruecker",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 2
        }
      }
    }
  ],
  "PersonNumber": "1611982",
  "FullName": "Gardner Wiza",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "officiis",
      "StrippedValue": "quis",
      "Description": "Managed regional protocol",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "quis",
      "Description": "Managed regional protocol",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    }
  ],
  "FormalName": "Lind, Senger and Beahan",
  "Address": {
    "Wgs84Latitude": 6095.63,
    "Wgs84Longitude": 1545.062,
    "LocalizedAddress": [
      [
        {
          "Name": "Schuster Inc and Sons",
          "Value": "laudantium",
          "Tooltip": "optio",
          "Label": "ut",
          "ValueLength": 755,
          "AddressType": "fuga",
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
              "FieldLength": 17
            }
          }
        }
      ],
      [
        {
          "Name": "Rempel LLC",
          "Value": "porro",
          "Tooltip": "et",
          "Label": "debitis",
          "ValueLength": 802,
          "AddressType": "praesentium",
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
              "FieldLength": 527
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "ducimus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 276
      }
    }
  },
  "Post3": "eaque",
  "Post2": "hic",
  "Post1": "suscipit",
  "Kanalname": "nam",
  "Kanafname": "consequatur",
  "CorrespondingAssociate": {
    "AssociateId": 944,
    "Name": "Mitchell-Wisoky",
    "PersonId": 106,
    "Rank": 186,
    "Tooltip": "quae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 898,
    "FullName": "Johann McDermott",
    "FormalName": "Effertz Inc and Sons",
    "Deleted": false,
    "EjUserId": 601,
    "UserName": "Powlowski Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 791
      }
    }
  },
  "Category": {
    "Id": 682,
    "Value": "libero",
    "Tooltip": "ut",
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
  "Business": {
    "Id": 632,
    "Value": "quisquam",
    "Tooltip": "quam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 539
      }
    }
  },
  "Associate": {
    "AssociateId": 458,
    "Name": "Wiegand, King and Murray",
    "PersonId": 740,
    "Rank": 624,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 706,
    "FullName": "Benjamin Bogisich",
    "FormalName": "Daugherty-Johnston",
    "Deleted": true,
    "EjUserId": 887,
    "UserName": "Dickens-Kautzer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 675
      }
    }
  },
  "Salutation": "deleniti",
  "ActiveInterests": 878,
  "SupportAssociate": {
    "AssociateId": 180,
    "Name": "Schmeler, Kilback and Gusikowski",
    "PersonId": 923,
    "Rank": 497,
    "Tooltip": "incidunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 930,
    "FullName": "Selena Renner",
    "FormalName": "Hermann-Rosenbaum",
    "Deleted": false,
    "EjUserId": 863,
    "UserName": "Moore Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 351
      }
    }
  },
  "TicketPriority": {
    "Id": 28,
    "Value": "et",
    "Tooltip": "a",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "extend efficient systems"
        },
        "FieldType": "System.String",
        "FieldLength": 153
      }
    }
  },
  "CustomerLanguage": {
    "Id": 808,
    "Value": "itaque",
    "Tooltip": "adipisci",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 313
      }
    }
  },
  "DbiAgentId": 702,
  "DbiKey": "explicabo",
  "DbiLastModified": "2008-05-11T16:48:30.1869321+02:00",
  "DbiLastSyncronized": "2017-02-25T16:48:30.1869321+01:00",
  "SentInfo": 404,
  "ShowContactTickets": 193,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 183,
    "UserName": "Schamberger Inc and Sons",
    "PersonId": 951,
    "Rank": 897,
    "Tooltip": "suscipit",
    "UserGroupId": 9,
    "EjUserId": 560,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "dicta",
      "dolorem"
    ],
    "CanLogon": true,
    "RoleName": "Raynor-Powlowski",
    "RoleTooltip": "ad",
    "UserGroupName": "Bailey, Becker and Simonis",
    "UserGroupTooltip": "voluptas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 810
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "hic",
      "StrippedValue": "autem",
      "Description": "Multi-lateral background access",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 4
        }
      }
    },
    {
      "Value": "hic",
      "StrippedValue": "autem",
      "Description": "Multi-lateral background access",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 4
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "sapiente",
      "StrippedValue": "est",
      "Description": "Enhanced intangible info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 709
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "est",
      "Description": "Enhanced intangible info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 709
        }
      }
    }
  ],
  "Source": 842,
  "ActiveErpLinks": 991,
  "ShipmentTypes": [
    {
      "Id": 380,
      "Name": "Rippin Inc and Sons",
      "ToolTip": "Similique aut non aliquam placeat eum debitis.",
      "Deleted": false,
      "Rank": 799,
      "Type": "suscipit",
      "ColorBlock": 596,
      "IconHint": "nihil",
      "Selected": false,
      "LastChanged": "2013-10-13T16:48:30.1879412+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "veritatis",
      "StyleHint": "sit",
      "Hidden": false,
      "FullName": "Bruce Runolfsdottir",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 113
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 538,
      "Comment": "enim",
      "Registered": "2010-11-21T16:48:30.1879412+01:00",
      "RegisteredAssociateId": 704,
      "Updated": "1995-05-18T16:48:30.1879412+02:00",
      "UpdatedAssociateId": 703,
      "LegalBaseId": 381,
      "LegalBaseKey": "non",
      "LegalBaseName": "Cartwright Group",
      "ConsentPurposeId": 666,
      "ConsentPurposeKey": "aut",
      "ConsentPurposeName": "Gleichner LLC",
      "ConsentSourceId": 285,
      "ConsentSourceKey": "porro",
      "ConsentSourceName": "Borer, Dibbert and Cassin",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 165
        }
      }
    }
  ],
  "BounceEmails": [
    "gabrielle@runolfsson.info",
    "vernie@vonrueden.com"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Hassie Cormier",
    "SuperOffice:2": "Liana Schroeder"
  },
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "consectetur",
    "CustomFields2": "nulla"
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
      "FieldLength": 105
    }
  }
}
```