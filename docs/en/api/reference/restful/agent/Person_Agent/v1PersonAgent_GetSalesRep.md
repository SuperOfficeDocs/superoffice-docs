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
| CreatedByFormId | int32 | The form id of the form that created the person |
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
  "ContactName": "Gaylord, Schuster and Friesen",
  "PersonFirstname": "Paul",
  "PersonLastname": "McClure",
  "EmailAddress": "leonardo_crist@wisozk.us",
  "PhoneNumber": "1064545"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 171,
  "Firstname": "Buck",
  "MiddleName": "Kozey Inc and Sons",
  "Lastname": "Emmerich",
  "Mrmrs": "neque",
  "Title": "cupiditate",
  "UpdatedDate": "2005-01-17T14:13:40.6721693+01:00",
  "CreatedDate": "2023-04-24T14:13:40.6721693+02:00",
  "BirthDate": "1999-07-15T14:13:40.6721693+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "nostrum",
      "Description": "Phased uniform implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 238
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "nostrum",
      "Description": "Phased uniform implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 238
        }
      }
    }
  ],
  "Description": "Switchable object-oriented task-force",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "id",
      "StrippedValue": "necessitatibus",
      "Description": "Business-focused encompassing knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 620
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "necessitatibus",
      "Description": "Business-focused encompassing knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 620
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "repudiandae",
      "StrippedValue": "magni",
      "Description": "Virtual intermediate hub",
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
      "Value": "repudiandae",
      "StrippedValue": "magni",
      "Description": "Virtual intermediate hub",
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
  "MobilePhones": [
    {
      "Value": "autem",
      "StrippedValue": "labore",
      "Description": "Function-based even-keeled core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 697
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "labore",
      "Description": "Function-based even-keeled core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 697
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "dolorum",
      "StrippedValue": "porro",
      "Description": "Realigned reciprocal pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 918
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "porro",
      "Description": "Realigned reciprocal pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 918
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "facere",
      "StrippedValue": "quae",
      "Description": "Multi-tiered modular challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 255
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "quae",
      "Description": "Multi-tiered modular challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 255
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
      "Id": 780,
      "Name": "Medhurst, Rodriguez and Daugherty",
      "ToolTip": "Deserunt nisi ducimus dicta quam asperiores.",
      "Deleted": false,
      "Rank": 752,
      "Type": "aut",
      "ColorBlock": 512,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "2011-11-09T14:13:40.6721693+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eaque",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Antonina Zieme III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 572
        }
      }
    }
  ],
  "PersonNumber": "1326541",
  "FullName": "Cali Kole Kuhn I",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "omnis",
      "StrippedValue": "tempora",
      "Description": "Object-based global methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 493
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "tempora",
      "Description": "Object-based global methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 493
        }
      }
    }
  ],
  "FormalName": "Ziemann-Pagac",
  "Address": null,
  "Post3": "debitis",
  "Post2": "perferendis",
  "Post1": "eius",
  "Kanalname": "qui",
  "Kanafname": "harum",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 680,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 202,
  "DbiKey": "inventore",
  "DbiLastModified": "2016-12-20T14:13:40.6877907+01:00",
  "DbiLastSyncronized": "1998-12-19T14:13:40.6877907+01:00",
  "SentInfo": 845,
  "ShowContactTickets": 226,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "id",
      "StrippedValue": "suscipit",
      "Description": "Inverse 24 hour extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 729
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "suscipit",
      "Description": "Inverse 24 hour extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 729
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "nesciunt",
      "StrippedValue": "velit",
      "Description": "Ergonomic well-modulated moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 858
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "velit",
      "Description": "Ergonomic well-modulated moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 858
        }
      }
    }
  ],
  "Source": 880,
  "ActiveErpLinks": 894,
  "ShipmentTypes": [
    {
      "Id": 349,
      "Name": "Grady, McClure and Hammes",
      "ToolTip": "Quidem cupiditate quia architecto architecto.",
      "Deleted": false,
      "Rank": 702,
      "Type": "rem",
      "ColorBlock": 167,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2005-02-15T14:13:40.6877907+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "magnam",
      "StyleHint": "quas",
      "Hidden": false,
      "FullName": "Miss Genesis Ryan Wuckert IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 332
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 481,
      "Comment": "cum",
      "Registered": "2017-11-06T14:13:40.6877907+01:00",
      "RegisteredAssociateId": 993,
      "Updated": "2011-07-23T14:13:40.6877907+02:00",
      "UpdatedAssociateId": 535,
      "LegalBaseId": 529,
      "LegalBaseKey": "laudantium",
      "LegalBaseName": "Metz Inc and Sons",
      "ConsentPurposeId": 725,
      "ConsentPurposeKey": "quidem",
      "ConsentPurposeName": "Mann-Runolfsdottir",
      "ConsentSourceId": 41,
      "ConsentSourceKey": "odit",
      "ConsentSourceName": "Swift, Bruen and Ortiz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 142
        }
      }
    }
  ],
  "BounceEmails": [
    "jazmin@rippinrolfson.com",
    "reina@douglastillman.info"
  ],
  "ActiveStatusMonitorId": 8,
  "CreatedByFormId": 914,
  "UserDefinedFields": {
    "SuperOffice:1": "1600398675",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "animi",
    "ExtraFields2": "nulla"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 596
    }
  }
}
```