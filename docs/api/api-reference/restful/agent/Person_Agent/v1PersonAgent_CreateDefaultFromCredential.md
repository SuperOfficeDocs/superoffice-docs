---
title: CreateDefaultFromCredential
id: v1PersonAgent_CreateDefaultFromCredential
---

# CreateDefaultFromCredential

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
  "ContactId": 69,
  "CredentialType": "odio",
  "CredentialValue": "dignissimos",
  "CredentialDisplayValue": "quas"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 437,
  "Firstname": "Naomie",
  "MiddleName": "Treutel Inc and Sons",
  "Lastname": "McDermott",
  "Mrmrs": "aperiam",
  "Title": "qui",
  "UpdatedDate": "2011-03-01T14:58:04.80446+01:00",
  "CreatedDate": "2005-08-23T14:58:04.80446+02:00",
  "BirthDate": "2008-03-28T14:58:04.80446+01:00",
  "CreatedBy": {
    "AssociateId": 708,
    "Name": "Koss-Braun",
    "PersonId": 528,
    "Rank": 657,
    "Tooltip": "veniam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 57,
    "FullName": "Jessyca Kuhn DDS",
    "FormalName": "Kuphal, Stark and Smitham",
    "Deleted": false,
    "EjUserId": 544,
    "UserName": "Mosciski, Rempel and Wilderman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 206
      }
    }
  },
  "Emails": [
    {
      "Value": "saepe",
      "StrippedValue": "omnis",
      "Description": "Robust upward-trending infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 833
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "omnis",
      "Description": "Robust upward-trending infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 833
        }
      }
    }
  ],
  "Description": "Extended regional Graphic Interface",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "sit",
      "StrippedValue": "eum",
      "Description": "Seamless fresh-thinking internet solution",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 44
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "eum",
      "Description": "Seamless fresh-thinking internet solution",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 44
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dicta",
      "StrippedValue": "occaecati",
      "Description": "Expanded transitional frame",
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
    {
      "Value": "dicta",
      "StrippedValue": "occaecati",
      "Description": "Expanded transitional frame",
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
    }
  ],
  "MobilePhones": [
    {
      "Value": "est",
      "StrippedValue": "voluptatem",
      "Description": "Robust systemic array",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 383
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "voluptatem",
      "Description": "Robust systemic array",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 383
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ipsa",
      "StrippedValue": "odio",
      "Description": "Secured impactful project",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 330
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "odio",
      "Description": "Secured impactful project",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 330
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "non",
      "StrippedValue": "voluptatem",
      "Description": "Cross-group homogeneous system engine",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 186
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "voluptatem",
      "Description": "Cross-group homogeneous system engine",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 186
        }
      }
    }
  ],
  "Position": {
    "Id": 880,
    "Value": "tempore",
    "Tooltip": "laudantium",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 886
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 759,
    "Name": "Harris Inc and Sons",
    "PersonId": 854,
    "Rank": 583,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 57,
    "FullName": "Jace Kirlin",
    "FormalName": "Ziemann LLC",
    "Deleted": false,
    "EjUserId": 456,
    "UserName": "Murazik, Block and Runolfsson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 166
      }
    }
  },
  "Contact": {
    "ContactId": 354,
    "Name": "Legros, Beahan and Corkery",
    "OrgNr": "952774",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "odio",
    "DirectPhone": "(044)570-8663 x46841",
    "AssociateId": 915,
    "CountryId": 936,
    "EmailAddress": "yolanda.lockman@pfeffer.ca",
    "Kananame": "voluptates",
    "EmailAddressName": "paula_lehner@krissteuber.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Wava Gibson MD",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "doloremque",
    "FullName": "Myron Strosin",
    "IsOwnerContact": true,
    "ActiveErpLinks": 629,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 729
      }
    }
  },
  "Country": {
    "CountryId": 667,
    "Name": "Willms-Hansen",
    "CurrencyId": 310,
    "EnglishName": "Haag, Metz and Feil",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Expanded zero defect complexity",
    "OrgNrText": "1384461",
    "InterAreaPrefix": "quia",
    "DialInPrefix": "est",
    "ZipPrefix": "optio",
    "DomainName": "Lindgren, Grady and Macejkovic",
    "AddressLayoutId": 520,
    "DomesticAddressLayoutId": 917,
    "ForeignAddressLayoutId": 951,
    "Rank": 360,
    "Tooltip": "tenetur",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 316
      }
    }
  },
  "Interests": [
    {
      "Id": 954,
      "Name": "Cremin-Littel",
      "ToolTip": "Voluptates autem accusantium.",
      "Deleted": true,
      "Rank": 939,
      "Type": "ut",
      "ColorBlock": 295,
      "IconHint": "delectus",
      "Selected": true,
      "LastChanged": "1999-03-31T14:58:04.80746+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "soluta",
      "StyleHint": "quia",
      "Hidden": true,
      "FullName": "Ralph Huel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 286
        }
      }
    }
  ],
  "PersonNumber": "994412",
  "FullName": "Dr. Breanna Zieme",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "temporibus",
      "StrippedValue": "sint",
      "Description": "Streamlined modular open architecture",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 1000
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "sint",
      "Description": "Streamlined modular open architecture",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 1000
        }
      }
    }
  ],
  "FormalName": "Kozey, Dickinson and Kulas",
  "Address": {
    "Wgs84Latitude": 9345.588,
    "Wgs84Longitude": 5985.94,
    "LocalizedAddress": [
      [
        {
          "Name": "Dietrich-Heaney",
          "Value": "eum",
          "Tooltip": "quod",
          "Label": "deleniti",
          "ValueLength": 911,
          "AddressType": "accusantium",
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
              "FieldLength": 772
            }
          }
        }
      ],
      [
        {
          "Name": "Daugherty, Mohr and Kling",
          "Value": "quia",
          "Tooltip": "ipsum",
          "Label": "quidem",
          "ValueLength": 539,
          "AddressType": "fugiat",
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
              "FieldLength": 928
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "id",
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
  "Post3": "aut",
  "Post2": "quos",
  "Post1": "natus",
  "Kanalname": "quibusdam",
  "Kanafname": "id",
  "CorrespondingAssociate": {
    "AssociateId": 121,
    "Name": "Dooley-Johnson",
    "PersonId": 223,
    "Rank": 773,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 206,
    "FullName": "Aracely Goodwin",
    "FormalName": "Fadel-McDermott",
    "Deleted": true,
    "EjUserId": 11,
    "UserName": "Cummerata, Bergnaum and Harris",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "streamline 24/7 niches"
        },
        "FieldType": "System.String",
        "FieldLength": 998
      }
    }
  },
  "Category": {
    "Id": 75,
    "Value": "eligendi",
    "Tooltip": "molestiae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 916
      }
    }
  },
  "Business": {
    "Id": 707,
    "Value": "reprehenderit",
    "Tooltip": "quod",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 607
      }
    }
  },
  "Associate": {
    "AssociateId": 536,
    "Name": "Walter LLC",
    "PersonId": 803,
    "Rank": 108,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 749,
    "FullName": "Mrs. Willard Hirthe",
    "FormalName": "Kling-Bartoletti",
    "Deleted": true,
    "EjUserId": 298,
    "UserName": "Heller-Zemlak",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 306
      }
    }
  },
  "Salutation": "omnis",
  "ActiveInterests": 693,
  "SupportAssociate": {
    "AssociateId": 595,
    "Name": "Reilly LLC",
    "PersonId": 636,
    "Rank": 863,
    "Tooltip": "quasi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 927,
    "FullName": "Candido Hoppe",
    "FormalName": "Mohr, Bashirian and Lowe",
    "Deleted": false,
    "EjUserId": 842,
    "UserName": "Von, Purdy and Bosco",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 543
      }
    }
  },
  "TicketPriority": {
    "Id": 403,
    "Value": "enim",
    "Tooltip": "harum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 483
      }
    }
  },
  "CustomerLanguage": {
    "Id": 380,
    "Value": "ut",
    "Tooltip": "consequuntur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 712
      }
    }
  },
  "DbiAgentId": 512,
  "DbiKey": "quia",
  "DbiLastModified": "2014-07-26T14:58:04.8094597+02:00",
  "DbiLastSyncronized": "2010-06-22T14:58:04.8094597+02:00",
  "SentInfo": 637,
  "ShowContactTickets": 582,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 920,
    "UserName": "Towne, Daniel and O'Conner",
    "PersonId": 445,
    "Rank": 381,
    "Tooltip": "consequatur",
    "UserGroupId": 587,
    "EjUserId": 346,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "tempore",
      "deleniti"
    ],
    "CanLogon": true,
    "RoleName": "Monahan-Hirthe",
    "RoleTooltip": "minus",
    "UserGroupName": "Graham-Lind",
    "UserGroupTooltip": "totam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 76
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "sint",
      "StrippedValue": "error",
      "Description": "Centralized disintermediate encryption",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 196
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "error",
      "Description": "Centralized disintermediate encryption",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 196
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "quia",
      "Description": "Reverse-engineered stable hardware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "unleash value-added channels"
          },
          "FieldType": "System.Int32",
          "FieldLength": 188
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quia",
      "Description": "Reverse-engineered stable hardware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "unleash value-added channels"
          },
          "FieldType": "System.Int32",
          "FieldLength": 188
        }
      }
    }
  ],
  "Source": 246,
  "ActiveErpLinks": 603,
  "ShipmentTypes": [
    {
      "Id": 635,
      "Name": "Wolff Inc and Sons",
      "ToolTip": "Et excepturi.",
      "Deleted": false,
      "Rank": 513,
      "Type": "odit",
      "ColorBlock": 467,
      "IconHint": "illum",
      "Selected": false,
      "LastChanged": "2018-08-15T14:58:04.81046+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "magni",
      "StyleHint": "qui",
      "Hidden": true,
      "FullName": "Lenny Murazik",
      "TableRight": {},
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
  "Consents": [
    {
      "ConsentPersonId": 610,
      "Comment": "est",
      "Registered": "2011-04-29T14:58:04.81046+02:00",
      "RegisteredAssociateId": 830,
      "Updated": "2002-06-02T14:58:04.81046+02:00",
      "UpdatedAssociateId": 675,
      "LegalBaseId": 441,
      "LegalBaseKey": "debitis",
      "LegalBaseName": "Fritsch Inc and Sons",
      "ConsentPurposeId": 367,
      "ConsentPurposeKey": "et",
      "ConsentPurposeName": "Willms, Ortiz and Hahn",
      "ConsentSourceId": 821,
      "ConsentSourceKey": "autem",
      "ConsentSourceName": "Marks LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 351
        }
      }
    }
  ],
  "BounceEmails": [
    "modesta@dibbert.us",
    "louie.considine@mckenzielehner.co.uk"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "934493354",
    "SuperOffice:2": "Stacey Tromp"
  },
  "ExtraFields": {
    "ExtraFields1": "optio",
    "ExtraFields2": "eligendi"
  },
  "CustomFields": {
    "CustomFields1": "excepturi",
    "CustomFields2": "enim"
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
      "FieldLength": 371
    }
  }
}
```