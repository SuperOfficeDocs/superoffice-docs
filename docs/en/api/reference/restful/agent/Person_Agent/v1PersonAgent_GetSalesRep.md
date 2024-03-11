---
title: POST Agents/Person/GetSalesRep
uid: v1PersonAgent_GetSalesRep
generated: true
---

# POST Agents/Person/GetSalesRep

```http
POST /api/v1/Agents/Person/GetSalesRep
```

Returns the sales representative for an external user.


If this method is accessed with anonymous authentication the external user is recognized by contact and name, or by email, or phone number. If the external user is recognized as an CRM5 user (internal or external) the input fields can be left blank.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetSalesRep?$select=name,department,category/id
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

ContactName, PersonFirstname, PersonLastname, EmailAddress, PhoneNumber 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactName | String |  |
| PersonFirstname | String |  |
| PersonLastname | String |  |
| EmailAddress | String |  |
| PhoneNumber | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  Use MDO List name "mrmrs" to get list items. |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  Use MDO List name "perspos" to get list items. |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  Use MDO List name "contact_new" to get list items. |
| Country | Country | The country this contact person is located in.  Use MDO List name "country" to get list items. |
| Interests | array | The person's available and selected interests.  Use MDO List name "persint" to get list items. |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "category" to get list items. |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "business" to get list items. |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  Use MDO List name "associate" to get list items. |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  Use MDO List name "salutation" to get list items. |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | Use MDO List name "customerlanguage" to get list items. |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/GetSalesRep
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactName": "Waters-Hermann",
  "PersonFirstname": "Mervin",
  "PersonLastname": "Turner",
  "EmailAddress": "gisselle_lowe@littel.info",
  "PhoneNumber": "870653"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 863,
  "Firstname": "Pat",
  "MiddleName": "Nitzsche-Torphy",
  "Lastname": "Bauch",
  "Mrmrs": "doloremque",
  "Title": "perspiciatis",
  "UpdatedDate": "2005-01-06T14:23:47.0036348+01:00",
  "CreatedDate": "2017-08-14T14:23:47.0036348+02:00",
  "BirthDate": "2005-06-01T14:23:47.0036348+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "accusamus",
      "StrippedValue": "aspernatur",
      "Description": "Customizable zero administration attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "aspernatur",
      "Description": "Customizable zero administration attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    }
  ],
  "Description": "Cross-platform clear-thinking secured line",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "User-centric cohesive hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 601
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "User-centric cohesive hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 601
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "animi",
      "StrippedValue": "sed",
      "Description": "Team-oriented assymetric forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 693
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "sed",
      "Description": "Team-oriented assymetric forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 693
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quidem",
      "StrippedValue": "consectetur",
      "Description": "Profound incremental toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 561
        }
      }
    },
    {
      "Value": "quidem",
      "StrippedValue": "consectetur",
      "Description": "Profound incremental toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 561
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ipsa",
      "StrippedValue": "voluptatem",
      "Description": "Balanced user-facing projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 15
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "voluptatem",
      "Description": "Balanced user-facing projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 15
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "expedita",
      "Description": "Synergistic 24/7 artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 925
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "expedita",
      "Description": "Synergistic 24/7 artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 925
        }
      }
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 326,
      "Name": "Leffler-Orn",
      "ToolTip": "Et vel alias minima accusantium.",
      "Deleted": false,
      "Rank": 596,
      "Type": "labore",
      "ColorBlock": 736,
      "IconHint": "minus",
      "Selected": false,
      "LastChanged": "2002-02-13T14:23:47.0036348+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorum",
      "StyleHint": "suscipit",
      "Hidden": false,
      "FullName": "Mr. Keira Howe",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 762
        }
      }
    }
  ],
  "PersonNumber": "904172",
  "FullName": "Prof. Easter Frami PhD",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "illum",
      "StrippedValue": "voluptatem",
      "Description": "Streamlined hybrid emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 77
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "voluptatem",
      "Description": "Streamlined hybrid emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 77
        }
      }
    }
  ],
  "FormalName": "Schuppe Inc and Sons",
  "Address": null,
  "Post3": "laboriosam",
  "Post2": "et",
  "Post1": "quo",
  "Kanalname": "possimus",
  "Kanafname": "possimus",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "tenetur",
  "ActiveInterests": 645,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 478,
  "DbiKey": "qui",
  "DbiLastModified": "2017-07-22T14:23:47.0192616+02:00",
  "DbiLastSyncronized": "2015-01-12T14:23:47.0192616+01:00",
  "SentInfo": 273,
  "ShowContactTickets": 382,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "occaecati",
      "StrippedValue": "doloribus",
      "Description": "Proactive content-based info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 930
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "doloribus",
      "Description": "Proactive content-based info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 930
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "sunt",
      "StrippedValue": "ad",
      "Description": "Operative mission-critical definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 546
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "ad",
      "Description": "Operative mission-critical definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 546
        }
      }
    }
  ],
  "Source": 584,
  "ActiveErpLinks": 535,
  "ShipmentTypes": [
    {
      "Id": 836,
      "Name": "Oberbrunner, Deckow and Blanda",
      "ToolTip": "Corrupti minus perspiciatis asperiores recusandae qui totam.",
      "Deleted": false,
      "Rank": 626,
      "Type": "dolore",
      "ColorBlock": 753,
      "IconHint": "optio",
      "Selected": false,
      "LastChanged": "2017-11-11T14:23:47.0192616+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ea",
      "StyleHint": "beatae",
      "Hidden": false,
      "FullName": "Mrs. Sebastian Johnson I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 353
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 2,
      "Comment": "exercitationem",
      "Registered": "2012-03-21T14:23:47.0192616+01:00",
      "RegisteredAssociateId": 951,
      "Updated": "2009-05-23T14:23:47.0192616+02:00",
      "UpdatedAssociateId": 878,
      "LegalBaseId": 417,
      "LegalBaseKey": "aut",
      "LegalBaseName": "Waelchi-Becker",
      "ConsentPurposeId": 669,
      "ConsentPurposeKey": "eaque",
      "ConsentPurposeName": "Ortiz, Koelpin and Anderson",
      "ConsentSourceId": 104,
      "ConsentSourceKey": "commodi",
      "ConsentSourceName": "Zboncak-Ledner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 339
        }
      }
    }
  ],
  "BounceEmails": [
    "lulu.shields@williamson.ca",
    "barbara_gibson@sporer.biz"
  ],
  "ActiveStatusMonitorId": 835,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Alyce Lemuel Russel",
    "SuperOffice:2": "Marlene Heaney"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "voluptate"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 683
    }
  }
}
```