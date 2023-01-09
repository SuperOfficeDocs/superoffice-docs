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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Person/CreateDefaultFromCredential
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 408,
  "CredentialType": "mollitia",
  "CredentialValue": "sit",
  "CredentialDisplayValue": "debitis"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 494,
  "Firstname": "Verona",
  "MiddleName": "Hessel-Wintheiser",
  "Lastname": "Haag",
  "Mrmrs": "natus",
  "Title": "ab",
  "UpdatedDate": "2003-06-25T17:37:18.5082417+02:00",
  "CreatedDate": "2010-01-28T17:37:18.5082417+01:00",
  "BirthDate": "2008-01-28T17:37:18.5082417+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ea",
      "StrippedValue": "quo",
      "Description": "Integrated client-server matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 302
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "quo",
      "Description": "Integrated client-server matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 302
        }
      }
    }
  ],
  "Description": "Decentralized user-facing extranet",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "aliquid",
      "StrippedValue": "cumque",
      "Description": "Phased even-keeled circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 317
        }
      }
    },
    {
      "Value": "aliquid",
      "StrippedValue": "cumque",
      "Description": "Phased even-keeled circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 317
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "consectetur",
      "StrippedValue": "est",
      "Description": "Front-line attitude-oriented array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 225
        }
      }
    },
    {
      "Value": "consectetur",
      "StrippedValue": "est",
      "Description": "Front-line attitude-oriented array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 225
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "sed",
      "StrippedValue": "ducimus",
      "Description": "Horizontal bottom-line portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 632
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "ducimus",
      "Description": "Horizontal bottom-line portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 632
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "qui",
      "StrippedValue": "sapiente",
      "Description": "Reverse-engineered regional hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 109
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "sapiente",
      "Description": "Reverse-engineered regional hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 109
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "est",
      "StrippedValue": "minima",
      "Description": "Grass-roots encompassing collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 746
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "minima",
      "Description": "Grass-roots encompassing collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 746
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
      "Id": 328,
      "Name": "Larson Inc and Sons",
      "ToolTip": "Magni et harum earum omnis.",
      "Deleted": false,
      "Rank": 322,
      "Type": "nemo",
      "ColorBlock": 425,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "1998-08-14T17:37:18.5112425+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "autem",
      "Hidden": true,
      "FullName": "Morton Nathaniel Bailey Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 885
        }
      }
    }
  ],
  "PersonNumber": "1193444",
  "FullName": "Rylee Koepp",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "enim",
      "StrippedValue": "itaque",
      "Description": "Assimilated object-oriented structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 387
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "itaque",
      "Description": "Assimilated object-oriented structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 387
        }
      }
    }
  ],
  "FormalName": "Mante, Kuphal and Sporer",
  "Address": null,
  "Post3": "magnam",
  "Post2": "dolores",
  "Post1": "rerum",
  "Kanalname": "occaecati",
  "Kanafname": "qui",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "dignissimos",
  "ActiveInterests": 223,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 756,
  "DbiKey": "sit",
  "DbiLastModified": "2020-02-18T17:37:18.5132416+01:00",
  "DbiLastSyncronized": "2020-02-03T17:37:18.5132416+01:00",
  "SentInfo": 399,
  "ShowContactTickets": 1001,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "blanditiis",
      "StrippedValue": "voluptatem",
      "Description": "Centralized intangible Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 659
        }
      }
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "voluptatem",
      "Description": "Centralized intangible Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 659
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ipsa",
      "StrippedValue": "doloremque",
      "Description": "Re-contextualized heuristic hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 201
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "doloremque",
      "Description": "Re-contextualized heuristic hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 201
        }
      }
    }
  ],
  "Source": 371,
  "ActiveErpLinks": 152,
  "ShipmentTypes": [
    {
      "Id": 219,
      "Name": "Leuschke, Ankunding and Koch",
      "ToolTip": "Earum consequuntur est autem.",
      "Deleted": true,
      "Rank": 413,
      "Type": "hic",
      "ColorBlock": 825,
      "IconHint": "ex",
      "Selected": false,
      "LastChanged": "2017-09-25T17:37:18.5142417+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repellendus",
      "StyleHint": "fugiat",
      "Hidden": false,
      "FullName": "Callie Cormier",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 168
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 185,
      "Comment": "dolores",
      "Registered": "2015-11-11T17:37:18.5142417+01:00",
      "RegisteredAssociateId": 573,
      "Updated": "2000-04-05T17:37:18.5142417+02:00",
      "UpdatedAssociateId": 925,
      "LegalBaseId": 498,
      "LegalBaseKey": "nulla",
      "LegalBaseName": "Pfeffer, Hirthe and Casper",
      "ConsentPurposeId": 176,
      "ConsentPurposeKey": "accusamus",
      "ConsentPurposeName": "Bergstrom, Ward and Yost",
      "ConsentSourceId": 3,
      "ConsentSourceKey": "rem",
      "ConsentSourceName": "Cartwright Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 196
        }
      }
    }
  ],
  "BounceEmails": [
    "beverly@mcclure.ca",
    "tiana_funk@hand.name"
  ],
  "ActiveStatusMonitorId": 237,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Lelia Jacobi",
    "SuperOffice:2": "1660121633"
  },
  "ExtraFields": {
    "ExtraFields1": "cumque",
    "ExtraFields2": "quasi"
  },
  "CustomFields": {
    "CustomFields1": "fugit",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 461
    }
  }
}
```