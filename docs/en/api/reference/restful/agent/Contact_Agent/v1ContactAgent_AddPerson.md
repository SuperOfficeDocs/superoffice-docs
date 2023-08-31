---
title: POST Agents/Contact/AddPerson
uid: v1ContactAgent_AddPerson
generated: true
---

# POST Agents/Contact/AddPerson

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
| ContactId | Integer |  |
| NewPersonEntity | PersonEntity |  |

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
POST /api/v1/Agents/Contact/AddPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 914,
  "NewPersonEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 337,
  "Firstname": "Neoma",
  "MiddleName": "Macejkovic, Crooks and Langworth",
  "Lastname": "Crooks",
  "Mrmrs": "sint",
  "Title": "est",
  "UpdatedDate": "2003-03-29T03:31:25.9478205+01:00",
  "CreatedDate": "2002-02-22T03:31:25.9478205+01:00",
  "BirthDate": "1998-02-18T03:31:25.9478205+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "mollitia",
      "StrippedValue": "vero",
      "Description": "Fully-configurable real-time standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 991
        }
      }
    },
    {
      "Value": "mollitia",
      "StrippedValue": "vero",
      "Description": "Fully-configurable real-time standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 991
        }
      }
    }
  ],
  "Description": "Robust 6th generation instruction set",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "possimus",
      "StrippedValue": "eos",
      "Description": "Mandatory assymetric internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 506
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "eos",
      "Description": "Mandatory assymetric internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 506
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "maiores",
      "StrippedValue": "recusandae",
      "Description": "Realigned 4th generation collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 410
        }
      }
    },
    {
      "Value": "maiores",
      "StrippedValue": "recusandae",
      "Description": "Realigned 4th generation collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 410
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "temporibus",
      "StrippedValue": "laboriosam",
      "Description": "Exclusive motivating extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 373
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "laboriosam",
      "Description": "Exclusive motivating extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 373
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "nisi",
      "StrippedValue": "dolores",
      "Description": "Cloned foreground archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 174
        }
      }
    },
    {
      "Value": "nisi",
      "StrippedValue": "dolores",
      "Description": "Cloned foreground archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 174
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "atque",
      "StrippedValue": "fuga",
      "Description": "Customer-focused scalable analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 701
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "fuga",
      "Description": "Customer-focused scalable analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 701
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
      "Id": 258,
      "Name": "Zboncak-Fadel",
      "ToolTip": "Facilis repellendus repellendus ut voluptatem quisquam.",
      "Deleted": true,
      "Rank": 984,
      "Type": "non",
      "ColorBlock": 287,
      "IconHint": "velit",
      "Selected": true,
      "LastChanged": "2008-10-02T03:31:25.9478205+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rem",
      "StyleHint": "autem",
      "Hidden": false,
      "FullName": "Hector Maggio",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 483
        }
      }
    }
  ],
  "PersonNumber": "959096",
  "FullName": "Willa Hackett",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "dolores",
      "Description": "Monitored logistical model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 537
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "dolores",
      "Description": "Monitored logistical model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 537
        }
      }
    }
  ],
  "FormalName": "Lakin, Heidenreich and Trantow",
  "Address": null,
  "Post3": "et",
  "Post2": "ratione",
  "Post1": "esse",
  "Kanalname": "nesciunt",
  "Kanafname": "aut",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "fuga",
  "ActiveInterests": 381,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 42,
  "DbiKey": "et",
  "DbiLastModified": "1998-03-13T03:31:25.9478205+01:00",
  "DbiLastSyncronized": "2002-07-28T03:31:25.9478205+02:00",
  "SentInfo": 375,
  "ShowContactTickets": 473,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quis",
      "StrippedValue": "nobis",
      "Description": "Versatile discrete encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 318
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "nobis",
      "Description": "Versatile discrete encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 318
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "eius",
      "StrippedValue": "dolor",
      "Description": "Fully-configurable object-oriented encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 367
        }
      }
    },
    {
      "Value": "eius",
      "StrippedValue": "dolor",
      "Description": "Fully-configurable object-oriented encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 367
        }
      }
    }
  ],
  "Source": 924,
  "ActiveErpLinks": 316,
  "ShipmentTypes": [
    {
      "Id": 923,
      "Name": "Greenholt-Heller",
      "ToolTip": "Consequatur delectus.",
      "Deleted": false,
      "Rank": 918,
      "Type": "quisquam",
      "ColorBlock": 753,
      "IconHint": "ad",
      "Selected": false,
      "LastChanged": "2004-04-13T03:31:25.9478205+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quos",
      "StyleHint": "quia",
      "Hidden": true,
      "FullName": "Jillian Thompson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 513
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 14,
      "Comment": "sit",
      "Registered": "2009-12-14T03:31:25.9478205+01:00",
      "RegisteredAssociateId": 787,
      "Updated": "2013-09-19T03:31:25.9478205+02:00",
      "UpdatedAssociateId": 586,
      "LegalBaseId": 756,
      "LegalBaseKey": "molestias",
      "LegalBaseName": "O'Reilly LLC",
      "ConsentPurposeId": 912,
      "ConsentPurposeKey": "optio",
      "ConsentPurposeName": "Schamberger-Bernhard",
      "ConsentSourceId": 933,
      "ConsentSourceKey": "dolor",
      "ConsentSourceName": "Hodkiewicz, Reinger and Nitzsche",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 35
        }
      }
    }
  ],
  "BounceEmails": [
    "camron@maggiopurdy.co.uk",
    "aniya.cronin@gusikowski.co.uk"
  ],
  "ActiveStatusMonitorId": 168,
  "UserDefinedFields": {
    "SuperOffice:1": "Jovany Ortiz",
    "SuperOffice:2": "109382976"
  },
  "ExtraFields": {
    "ExtraFields1": "expedita",
    "ExtraFields2": "delectus"
  },
  "CustomFields": {
    "CustomFields1": "autem",
    "CustomFields2": "in"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 937
    }
  }
}
```