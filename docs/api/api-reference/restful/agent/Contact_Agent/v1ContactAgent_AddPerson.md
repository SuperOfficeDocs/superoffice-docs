---
title: AddPerson
id: v1ContactAgent_AddPerson
---

# AddPerson

```http
POST /api/v1/Agents/Contact/AddPerson
```

Add a person to the given contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/AddPerson?$select=name,department,category/id
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

ContactId, NewPersonEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |
| NewPersonEntity |  |  |


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
POST /api/v1/Agents/Contact/AddPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 525,
  "NewPersonEntity": {
    "PersonId": 960,
    "Firstname": "Carlos",
    "MiddleName": "Dare-Leuschke",
    "Lastname": "Weissnat",
    "Mrmrs": "corporis",
    "Title": "est",
    "UpdatedDate": "2007-08-11T14:58:03.6983168+02:00",
    "CreatedDate": "2019-09-19T14:58:03.6983168+02:00",
    "BirthDate": "2001-10-22T14:58:03.6983168+02:00",
    "CreatedBy": {},
    "Emails": [
      {},
      {}
    ],
    "Description": "Enhanced clear-thinking migration",
    "IsAssociate": true,
    "PrivatePhones": [
      {},
      {}
    ],
    "Faxes": [
      {},
      {}
    ],
    "MobilePhones": [
      {},
      {}
    ],
    "OfficePhones": [
      {},
      {}
    ],
    "OtherPhones": [
      {},
      {}
    ],
    "Position": {},
    "UpdatedBy": {},
    "Contact": {},
    "Country": {},
    "Interests": [
      {},
      {}
    ],
    "PersonNumber": "1392408",
    "FullName": "Mr. Hiram Haag",
    "NoMailing": true,
    "UsePersonAddress": false,
    "Retired": false,
    "Urls": [
      {},
      {}
    ],
    "FormalName": "Bauch-Connelly",
    "Address": {},
    "Post3": "qui",
    "Post2": "cumque",
    "Post1": "praesentium",
    "Kanalname": "et",
    "Kanafname": "quo",
    "CorrespondingAssociate": {},
    "Category": {},
    "Business": {},
    "Associate": {},
    "Salutation": "est",
    "ActiveInterests": 404,
    "SupportAssociate": {},
    "TicketPriority": {},
    "CustomerLanguage": {},
    "DbiAgentId": 814,
    "DbiKey": "quibusdam",
    "DbiLastModified": "2002-05-10T14:58:03.6993159+02:00",
    "DbiLastSyncronized": "2005-12-17T14:58:03.6993159+01:00",
    "SentInfo": 232,
    "ShowContactTickets": 494,
    "UserInfo": {},
    "ChatEmails": [
      {},
      {}
    ],
    "InternetPhones": [
      {},
      {}
    ],
    "Source": 323,
    "ActiveErpLinks": 128,
    "ShipmentTypes": [
      {},
      {}
    ],
    "Consents": [
      {},
      {}
    ],
    "BounceEmails": [
      "davonte@kuvalis.ca",
      "nicholaus@goyettecruickshank.biz"
    ],
    "UserDefinedFields": {
      "SuperOffice:1": "Hiram Runolfsdottir",
      "SuperOffice:2": "Miss Darrick Jakubowski"
    },
    "ExtraFields": {
      "ExtraFields1": "et",
      "ExtraFields2": "incidunt"
    },
    "CustomFields": {
      "CustomFields1": "non",
      "CustomFields2": "unde"
    }
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 778,
  "Firstname": "Janessa",
  "MiddleName": "Lubowitz LLC",
  "Lastname": "Bechtelar",
  "Mrmrs": "et",
  "Title": "consequatur",
  "UpdatedDate": "2001-05-03T14:58:03.7073283+02:00",
  "CreatedDate": "2011-08-18T14:58:03.7073283+02:00",
  "BirthDate": "2005-02-13T14:58:03.7073283+01:00",
  "CreatedBy": {
    "AssociateId": 278,
    "Name": "Pfannerstill Inc and Sons",
    "PersonId": 966,
    "Rank": 509,
    "Tooltip": "eveniet",
    "Type": "AnonymousAssociate",
    "GroupIdx": 233,
    "FullName": "Lawrence Collins DVM",
    "FormalName": "Russel-Schmitt",
    "Deleted": false,
    "EjUserId": 281,
    "UserName": "Effertz LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 501
      }
    }
  },
  "Emails": [
    {
      "Value": "exercitationem",
      "StrippedValue": "earum",
      "Description": "Cloned clear-thinking customer loyalty",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "visualize robust applications"
          },
          "FieldType": "System.Int32",
          "FieldLength": 910
        }
      }
    },
    {
      "Value": "exercitationem",
      "StrippedValue": "earum",
      "Description": "Cloned clear-thinking customer loyalty",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "visualize robust applications"
          },
          "FieldType": "System.Int32",
          "FieldLength": 910
        }
      }
    }
  ],
  "Description": "Cross-group incremental open system",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "tenetur",
      "StrippedValue": "vitae",
      "Description": "Monitored static interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 393
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "vitae",
      "Description": "Monitored static interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 393
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "omnis",
      "StrippedValue": "dicta",
      "Description": "Multi-lateral coherent service-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "enable rich action-items"
          },
          "FieldType": "System.Int32",
          "FieldLength": 805
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "dicta",
      "Description": "Multi-lateral coherent service-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "enable rich action-items"
          },
          "FieldType": "System.Int32",
          "FieldLength": 805
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "cumque",
      "StrippedValue": "unde",
      "Description": "Implemented coherent open system",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 1001
        }
      }
    },
    {
      "Value": "cumque",
      "StrippedValue": "unde",
      "Description": "Implemented coherent open system",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 1001
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "incidunt",
      "StrippedValue": "optio",
      "Description": "Inverse 3rd generation orchestration",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 940
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "optio",
      "Description": "Inverse 3rd generation orchestration",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 940
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "quo",
      "Description": "Face to face clear-thinking knowledge user",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "maximize rich solutions"
          },
          "FieldType": "System.String",
          "FieldLength": 147
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "quo",
      "Description": "Face to face clear-thinking knowledge user",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "maximize rich solutions"
          },
          "FieldType": "System.String",
          "FieldLength": 147
        }
      }
    }
  ],
  "Position": {
    "Id": 572,
    "Value": "sunt",
    "Tooltip": "optio",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 87
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 165,
    "Name": "Wunsch, O'Kon and Reichert",
    "PersonId": 117,
    "Rank": 299,
    "Tooltip": "distinctio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 919,
    "FullName": "Claud Moore",
    "FormalName": "Ullrich-Legros",
    "Deleted": true,
    "EjUserId": 171,
    "UserName": "Hyatt Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 847
      }
    }
  },
  "Contact": {
    "ContactId": 518,
    "Name": "Hand-Sporer",
    "OrgNr": "495441",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "assumenda",
    "DirectPhone": "1-247-873-2661 x3838",
    "AssociateId": 168,
    "CountryId": 89,
    "EmailAddress": "thad@stiedemann.co.uk",
    "Kananame": "animi",
    "EmailAddressName": "rodrick_kshlerin@grantlangosh.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Leatha Bailey",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "consectetur",
    "FullName": "Vernice Wolf",
    "IsOwnerContact": true,
    "ActiveErpLinks": 578,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 179
      }
    }
  },
  "Country": {
    "CountryId": 367,
    "Name": "Wintheiser, Buckridge and Rohan",
    "CurrencyId": 992,
    "EnglishName": "Rempel, Marvin and Jacobi",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "User-friendly exuding attitude",
    "OrgNrText": "1115799",
    "InterAreaPrefix": "sed",
    "DialInPrefix": "et",
    "ZipPrefix": "occaecati",
    "DomainName": "Conroy-Schimmel",
    "AddressLayoutId": 138,
    "DomesticAddressLayoutId": 576,
    "ForeignAddressLayoutId": 731,
    "Rank": 884,
    "Tooltip": "sequi",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 474
      }
    }
  },
  "Interests": [
    {
      "Id": 142,
      "Name": "Herzog-Leuschke",
      "ToolTip": "Non sit doloremque fuga suscipit.",
      "Deleted": false,
      "Rank": 228,
      "Type": "praesentium",
      "ColorBlock": 952,
      "IconHint": "laudantium",
      "Selected": false,
      "LastChanged": "2006-03-13T14:58:03.7103101+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "ipsum",
      "Hidden": false,
      "FullName": "Devin Bartell DVM",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 401
        }
      }
    }
  ],
  "PersonNumber": "739295",
  "FullName": "Nannie Spencer",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "voluptas",
      "StrippedValue": "blanditiis",
      "Description": "Function-based even-keeled framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 283
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "blanditiis",
      "Description": "Function-based even-keeled framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 283
        }
      }
    }
  ],
  "FormalName": "Jerde, Stark and Koelpin",
  "Address": {
    "Wgs84Latitude": 18938.762,
    "Wgs84Longitude": 10821.702,
    "LocalizedAddress": [
      [
        {
          "Name": "Hessel-Gerlach",
          "Value": "voluptatem",
          "Tooltip": "ut",
          "Label": "velit",
          "ValueLength": 618,
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
              "FieldLength": 325
            }
          }
        }
      ],
      [
        {
          "Name": "Aufderhar, Ratke and O'Keefe",
          "Value": "rerum",
          "Tooltip": "et",
          "Label": "autem",
          "ValueLength": 734,
          "AddressType": "omnis",
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
              "FieldLength": 85
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "architecto",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 916
      }
    }
  },
  "Post3": "ratione",
  "Post2": "est",
  "Post1": "sit",
  "Kanalname": "aut",
  "Kanafname": "dolor",
  "CorrespondingAssociate": {
    "AssociateId": 587,
    "Name": "Reinger-Lemke",
    "PersonId": 376,
    "Rank": 291,
    "Tooltip": "sapiente",
    "Type": "AnonymousAssociate",
    "GroupIdx": 61,
    "FullName": "Rusty Macejkovic",
    "FormalName": "Schulist Inc and Sons",
    "Deleted": true,
    "EjUserId": 172,
    "UserName": "Friesen Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 97
      }
    }
  },
  "Category": {
    "Id": 741,
    "Value": "quam",
    "Tooltip": "adipisci",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 883
      }
    }
  },
  "Business": {
    "Id": 185,
    "Value": "id",
    "Tooltip": "impedit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 957
      }
    }
  },
  "Associate": {
    "AssociateId": 608,
    "Name": "Swift-McDermott",
    "PersonId": 17,
    "Rank": 834,
    "Tooltip": "vitae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 757,
    "FullName": "Reina Buckridge",
    "FormalName": "Yost-Kertzmann",
    "Deleted": false,
    "EjUserId": 15,
    "UserName": "Lynch, Jacobi and Torp",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 136
      }
    }
  },
  "Salutation": "laboriosam",
  "ActiveInterests": 638,
  "SupportAssociate": {
    "AssociateId": 462,
    "Name": "Hills Inc and Sons",
    "PersonId": 516,
    "Rank": 443,
    "Tooltip": "eius",
    "Type": "AnonymousAssociate",
    "GroupIdx": 263,
    "FullName": "Darren Bruen",
    "FormalName": "Gaylord, Wilkinson and Beier",
    "Deleted": true,
    "EjUserId": 184,
    "UserName": "Bailey, Blanda and Waelchi",
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
  "TicketPriority": {
    "Id": 76,
    "Value": "et",
    "Tooltip": "repellendus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 473
      }
    }
  },
  "CustomerLanguage": {
    "Id": 908,
    "Value": "animi",
    "Tooltip": "id",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 189
      }
    }
  },
  "DbiAgentId": 329,
  "DbiKey": "aut",
  "DbiLastModified": "2017-05-06T14:58:03.7134546+02:00",
  "DbiLastSyncronized": "2003-04-21T14:58:03.7134546+02:00",
  "SentInfo": 621,
  "ShowContactTickets": 67,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 591,
    "UserName": "Howe-Hessel",
    "PersonId": 268,
    "Rank": 11,
    "Tooltip": "quisquam",
    "UserGroupId": 177,
    "EjUserId": 972,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "et",
      "libero"
    ],
    "CanLogon": false,
    "RoleName": "Beahan, Kessler and Kohler",
    "RoleTooltip": "perferendis",
    "UserGroupName": "Medhurst, Dach and Von",
    "UserGroupTooltip": "enim",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 288
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "sint",
      "StrippedValue": "fugiat",
      "Description": "Optimized background model",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 562
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "fugiat",
      "Description": "Optimized background model",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 562
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ut",
      "StrippedValue": "eum",
      "Description": "Up-sized mobile customer loyalty",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 599
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "eum",
      "Description": "Up-sized mobile customer loyalty",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 599
        }
      }
    }
  ],
  "Source": 826,
  "ActiveErpLinks": 579,
  "ShipmentTypes": [
    {
      "Id": 809,
      "Name": "Dickinson, Heller and Connelly",
      "ToolTip": "Aut quaerat reprehenderit sapiente error rerum.",
      "Deleted": true,
      "Rank": 837,
      "Type": "cum",
      "ColorBlock": 409,
      "IconHint": "dolorem",
      "Selected": false,
      "LastChanged": "2009-04-20T14:58:03.7134546+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ea",
      "StyleHint": "provident",
      "Hidden": false,
      "FullName": "Garnett Lindgren",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "architect scalable bandwidth"
          },
          "FieldType": "System.Int32",
          "FieldLength": 750
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 917,
      "Comment": "totam",
      "Registered": "1995-07-11T14:58:03.7144618+02:00",
      "RegisteredAssociateId": 321,
      "Updated": "2013-05-24T14:58:03.7144618+02:00",
      "UpdatedAssociateId": 858,
      "LegalBaseId": 274,
      "LegalBaseKey": "et",
      "LegalBaseName": "Sawayn, Waters and Price",
      "ConsentPurposeId": 217,
      "ConsentPurposeKey": "est",
      "ConsentPurposeName": "Cassin Inc and Sons",
      "ConsentSourceId": 435,
      "ConsentSourceKey": "illum",
      "ConsentSourceName": "Bashirian Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 350
        }
      }
    }
  ],
  "BounceEmails": [
    "jewell_mann@carter.us",
    "maximo@zboncak.com"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Sigmund Lesch"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsam",
    "ExtraFields2": "rem"
  },
  "CustomFields": {
    "CustomFields1": "sint",
    "CustomFields2": "officia"
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
      "FieldLength": 974
    }
  }
}
```