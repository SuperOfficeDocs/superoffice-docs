---
title: POST Agents/Person/CreateDefaultFromCredential
uid: v1PersonAgent_CreateDefaultFromCredential
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
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
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
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
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
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/CreateDefaultFromCredential
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 306,
  "CredentialType": "occaecati",
  "CredentialValue": "suscipit",
  "CredentialDisplayValue": "blanditiis"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 133,
  "Firstname": "Tianna",
  "MiddleName": "Daugherty-Larkin",
  "Lastname": "D'Amore",
  "Mrmrs": "et",
  "Title": "nihil",
  "UpdatedDate": "2013-11-06T15:29:22.3182685+01:00",
  "CreatedDate": "2016-03-16T15:29:22.3182685+01:00",
  "BirthDate": "2011-03-24T15:29:22.3182685+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "reiciendis",
      "StrippedValue": "dolor",
      "Description": "Distributed bifurcated hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 862
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "dolor",
      "Description": "Distributed bifurcated hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 862
        }
      }
    }
  ],
  "Description": "Focused 24 hour capacity",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "voluptate",
      "StrippedValue": "aut",
      "Description": "Polarised 24/7 approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 862
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "aut",
      "Description": "Polarised 24/7 approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 862
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sed",
      "StrippedValue": "eos",
      "Description": "Stand-alone upward-trending archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 300
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "eos",
      "Description": "Stand-alone upward-trending archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 300
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "dolores",
      "StrippedValue": "autem",
      "Description": "Versatile 24/7 moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 616
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "autem",
      "Description": "Versatile 24/7 moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 616
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "non",
      "StrippedValue": "ut",
      "Description": "Ameliorated 24 hour standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 57
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "ut",
      "Description": "Ameliorated 24 hour standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 57
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "explicabo",
      "StrippedValue": "ad",
      "Description": "Synergistic 6th generation definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 535
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "ad",
      "Description": "Synergistic 6th generation definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 535
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
      "Id": 864,
      "Name": "Wehner LLC",
      "ToolTip": "Saepe laudantium ad sint tenetur.",
      "Deleted": true,
      "Rank": 348,
      "Type": "cum",
      "ColorBlock": 92,
      "IconHint": "architecto",
      "Selected": false,
      "LastChanged": "2023-02-12T15:29:22.321268+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "illo",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Marian Larson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 652
        }
      }
    }
  ],
  "PersonNumber": "1397632",
  "FullName": "Golda Hoppe",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "vitae",
      "Description": "Optional motivating service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 297
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "vitae",
      "Description": "Optional motivating service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 297
        }
      }
    }
  ],
  "FormalName": "Ondricka, Herman and Kub",
  "Address": null,
  "Post3": "amet",
  "Post2": "molestiae",
  "Post1": "dolore",
  "Kanalname": "at",
  "Kanafname": "expedita",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quod",
  "ActiveInterests": 508,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 507,
  "DbiKey": "facere",
  "DbiLastModified": "2021-03-15T15:29:22.3232686+01:00",
  "DbiLastSyncronized": "2003-01-12T15:29:22.3232686+01:00",
  "SentInfo": 947,
  "ShowContactTickets": 859,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "et",
      "Description": "Vision-oriented incremental strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 672
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "et",
      "Description": "Vision-oriented incremental strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 672
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "et",
      "Description": "Switchable bottom-line project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 542
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "et",
      "Description": "Switchable bottom-line project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 542
        }
      }
    }
  ],
  "Source": 326,
  "ActiveErpLinks": 247,
  "ShipmentTypes": [
    {
      "Id": 690,
      "Name": "Wyman, Sanford and Paucek",
      "ToolTip": "Sapiente porro inventore at et.",
      "Deleted": false,
      "Rank": 521,
      "Type": "illum",
      "ColorBlock": 610,
      "IconHint": "voluptatibus",
      "Selected": false,
      "LastChanged": "2004-01-27T15:29:22.3242682+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quasi",
      "StyleHint": "aliquam",
      "Hidden": false,
      "FullName": "Nikko Bayer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 388
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 797,
      "Comment": "qui",
      "Registered": "2018-06-19T15:29:22.3247675+02:00",
      "RegisteredAssociateId": 657,
      "Updated": "2007-03-12T15:29:22.3247675+01:00",
      "UpdatedAssociateId": 767,
      "LegalBaseId": 83,
      "LegalBaseKey": "et",
      "LegalBaseName": "Witting, Smitham and Bogisich",
      "ConsentPurposeId": 701,
      "ConsentPurposeKey": "ut",
      "ConsentPurposeName": "Huels-Walter",
      "ConsentSourceId": 63,
      "ConsentSourceKey": "nihil",
      "ConsentSourceName": "Simonis, Kuhn and Schultz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 65
        }
      }
    }
  ],
  "BounceEmails": [
    "berry@dubuque.info",
    "mack@grimesschinner.name"
  ],
  "ActiveStatusMonitorId": 821,
  "UserDefinedFields": {
    "SuperOffice:1": "Daphnee Sasha Eichmann MD",
    "SuperOffice:2": "Mr. Toy Bethel Wolf"
  },
  "ExtraFields": {
    "ExtraFields1": "quod",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "quis",
    "CustomFields2": "accusamus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 755
    }
  }
}
```