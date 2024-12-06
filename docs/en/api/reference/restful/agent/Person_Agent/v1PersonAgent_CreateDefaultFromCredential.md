---
title: POST Agents/Person/CreateDefaultFromCredential
uid: v1PersonAgent_CreateDefaultFromCredential
generated: true
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
| ContactId | Integer |  |
| CredentialType | String |  |
| CredentialValue | String |  |
| CredentialDisplayValue | String |  |

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
| CreatedByFormId | int32 | The form id of the form that created the person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/CreateDefaultFromCredential
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 500,
  "CredentialType": "veritatis",
  "CredentialValue": "ea",
  "CredentialDisplayValue": "fugiat"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 651,
  "Firstname": "Simone",
  "MiddleName": "Hudson-Hamill",
  "Lastname": "Klocko",
  "Mrmrs": "blanditiis",
  "Title": "amet",
  "UpdatedDate": "2018-10-11T10:17:55.8321779+02:00",
  "CreatedDate": "2020-07-25T10:17:55.8321779+02:00",
  "BirthDate": "2014-08-25T10:17:55.8321779+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "officiis",
      "StrippedValue": "atque",
      "Description": "Fully-configurable homogeneous workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 323
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "atque",
      "Description": "Fully-configurable homogeneous workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 323
        }
      }
    }
  ],
  "Description": "Configurable national solution",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "rem",
      "StrippedValue": "esse",
      "Description": "Fundamental zero defect function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 718
        }
      }
    },
    {
      "Value": "rem",
      "StrippedValue": "esse",
      "Description": "Fundamental zero defect function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 718
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "tempore",
      "Description": "Configurable high-level help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 843
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "tempore",
      "Description": "Configurable high-level help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 843
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "sit",
      "StrippedValue": "sunt",
      "Description": "Organized stable benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 903
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "sunt",
      "Description": "Organized stable benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 903
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "earum",
      "StrippedValue": "voluptas",
      "Description": "Future-proofed tangible task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 110
        }
      }
    },
    {
      "Value": "earum",
      "StrippedValue": "voluptas",
      "Description": "Future-proofed tangible task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 110
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "error",
      "StrippedValue": "ut",
      "Description": "Streamlined intangible support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 550
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "ut",
      "Description": "Streamlined intangible support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 550
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
      "Id": 771,
      "Name": "Bartoletti LLC",
      "ToolTip": "Ea et enim omnis necessitatibus hic nihil ut.",
      "Deleted": false,
      "Rank": 759,
      "Type": "omnis",
      "ColorBlock": 69,
      "IconHint": "quo",
      "Selected": false,
      "LastChanged": "2013-06-06T10:17:55.8321779+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eligendi",
      "StyleHint": "autem",
      "Hidden": false,
      "FullName": "Miss Connor Susan Streich",
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
  "PersonNumber": "1022288",
  "FullName": "Lessie Beier",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "voluptas",
      "StrippedValue": "quo",
      "Description": "Reactive national emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 108
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "quo",
      "Description": "Reactive national emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 108
        }
      }
    }
  ],
  "FormalName": "Kutch-Harris",
  "Address": null,
  "Post3": "quos",
  "Post2": "maxime",
  "Post1": "vel",
  "Kanalname": "perferendis",
  "Kanafname": "et",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "consequuntur",
  "ActiveInterests": 788,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 435,
  "DbiKey": "itaque",
  "DbiLastModified": "2021-02-19T10:17:55.8321779+01:00",
  "DbiLastSyncronized": "2024-08-18T10:17:55.8321779+02:00",
  "SentInfo": 173,
  "ShowContactTickets": 299,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "et",
      "StrippedValue": "aut",
      "Description": "Customizable static alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 226
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "aut",
      "Description": "Customizable static alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 226
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ut",
      "StrippedValue": "odio",
      "Description": "Synergistic dynamic customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 762
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "odio",
      "Description": "Synergistic dynamic customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 762
        }
      }
    }
  ],
  "Source": 757,
  "ActiveErpLinks": 975,
  "ShipmentTypes": [
    {
      "Id": 886,
      "Name": "Botsford, Legros and Lang",
      "ToolTip": "Sit dignissimos inventore perspiciatis.",
      "Deleted": false,
      "Rank": 334,
      "Type": "velit",
      "ColorBlock": 977,
      "IconHint": "adipisci",
      "Selected": false,
      "LastChanged": "2010-11-15T10:17:55.8321779+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "enim",
      "Hidden": false,
      "FullName": "Katlynn Abbott",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 851
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 90,
      "Comment": "qui",
      "Registered": "2024-03-07T10:17:55.8321779+01:00",
      "RegisteredAssociateId": 872,
      "Updated": "2009-10-15T10:17:55.8321779+02:00",
      "UpdatedAssociateId": 622,
      "LegalBaseId": 810,
      "LegalBaseKey": "quam",
      "LegalBaseName": "Nikolaus LLC",
      "ConsentPurposeId": 892,
      "ConsentPurposeKey": "aliquid",
      "ConsentPurposeName": "Stracke-Glover",
      "ConsentSourceId": 491,
      "ConsentSourceKey": "et",
      "ConsentSourceName": "Streich, Orn and Rogahn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 980
        }
      }
    }
  ],
  "BounceEmails": [
    "terry@mraz.name",
    "mustafa.dietrich@cormierbeatty.uk"
  ],
  "ActiveStatusMonitorId": 473,
  "CreatedByFormId": 492,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Ben Conroy I",
    "SuperOffice:2": "Miss Valerie Cordie Tremblay I"
  },
  "ExtraFields": {
    "ExtraFields1": "consectetur",
    "ExtraFields2": "ad"
  },
  "CustomFields": {
    "CustomFields1": "eaque",
    "CustomFields2": "culpa"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 240
    }
  }
}
```