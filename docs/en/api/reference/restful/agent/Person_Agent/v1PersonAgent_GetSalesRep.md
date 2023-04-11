---
title: POST Agents/Person/GetSalesRep
uid: v1PersonAgent_GetSalesRep
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
POST /api/v1/Agents/Person/GetSalesRep
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactName": "Zemlak, Stroman and Strosin",
  "PersonFirstname": "Jeramy",
  "PersonLastname": "Olson",
  "EmailAddress": "triston_fisher@kub.ca",
  "PhoneNumber": "1228856"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 440,
  "Firstname": "Lazaro",
  "MiddleName": "Hills Inc and Sons",
  "Lastname": "Heaney",
  "Mrmrs": "aut",
  "Title": "ipsum",
  "UpdatedDate": "2003-08-11T15:29:22.2587692+02:00",
  "CreatedDate": "2011-11-09T15:29:22.2587692+01:00",
  "BirthDate": "2015-09-13T15:29:22.2587692+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "accusamus",
      "StrippedValue": "incidunt",
      "Description": "Extended user-facing support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 603
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "incidunt",
      "Description": "Extended user-facing support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 603
        }
      }
    }
  ],
  "Description": "Integrated assymetric capacity",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "nostrum",
      "StrippedValue": "totam",
      "Description": "Distributed dedicated application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "totam",
      "Description": "Distributed dedicated application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quisquam",
      "StrippedValue": "sunt",
      "Description": "Up-sized user-facing database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 809
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "sunt",
      "Description": "Up-sized user-facing database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 809
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "possimus",
      "Description": "De-engineered value-added moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 200
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "possimus",
      "Description": "De-engineered value-added moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 200
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "magni",
      "StrippedValue": "optio",
      "Description": "Grass-roots 4th generation access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 764
        }
      }
    },
    {
      "Value": "magni",
      "StrippedValue": "optio",
      "Description": "Grass-roots 4th generation access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 764
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ab",
      "StrippedValue": "soluta",
      "Description": "Enhanced assymetric intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 808
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "soluta",
      "Description": "Enhanced assymetric intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 808
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
      "Id": 525,
      "Name": "Kulas-Harris",
      "ToolTip": "Adipisci veritatis est molestiae.",
      "Deleted": false,
      "Rank": 801,
      "Type": "aut",
      "ColorBlock": 732,
      "IconHint": "numquam",
      "Selected": false,
      "LastChanged": "2006-08-26T15:29:22.2627681+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "voluptatibus",
      "Hidden": true,
      "FullName": "Mr. Olaf Isabel Nolan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 801
        }
      }
    }
  ],
  "PersonNumber": "947381",
  "FullName": "Mr. Randall Howell DVM",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "inventore",
      "StrippedValue": "quia",
      "Description": "User-friendly 6th generation orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 207
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "quia",
      "Description": "User-friendly 6th generation orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 207
        }
      }
    }
  ],
  "FormalName": "Senger, Schmitt and Larson",
  "Address": null,
  "Post3": "dignissimos",
  "Post2": "eveniet",
  "Post1": "vitae",
  "Kanalname": "iusto",
  "Kanafname": "laudantium",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quis",
  "ActiveInterests": 310,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 542,
  "DbiKey": "sit",
  "DbiLastModified": "2013-08-12T15:29:22.2647691+02:00",
  "DbiLastSyncronized": "2018-11-04T15:29:22.2647691+01:00",
  "SentInfo": 686,
  "ShowContactTickets": 121,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "at",
      "StrippedValue": "facere",
      "Description": "Proactive next generation website",
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
      "Value": "at",
      "StrippedValue": "facere",
      "Description": "Proactive next generation website",
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
  "InternetPhones": [
    {
      "Value": "rerum",
      "StrippedValue": "iure",
      "Description": "Customer-focused client-server application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 150
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "iure",
      "Description": "Customer-focused client-server application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 150
        }
      }
    }
  ],
  "Source": 378,
  "ActiveErpLinks": 130,
  "ShipmentTypes": [
    {
      "Id": 271,
      "Name": "Flatley Inc and Sons",
      "ToolTip": "Aspernatur consectetur non reiciendis quam quos.",
      "Deleted": false,
      "Rank": 296,
      "Type": "dicta",
      "ColorBlock": 976,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2014-04-13T15:29:22.2652688+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aspernatur",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Mariana Schoen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 551
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 982,
      "Comment": "nemo",
      "Registered": "1998-12-27T15:29:22.2657684+01:00",
      "RegisteredAssociateId": 511,
      "Updated": "2015-04-19T15:29:22.2657684+02:00",
      "UpdatedAssociateId": 508,
      "LegalBaseId": 921,
      "LegalBaseKey": "voluptatem",
      "LegalBaseName": "Monahan-Considine",
      "ConsentPurposeId": 961,
      "ConsentPurposeKey": "et",
      "ConsentPurposeName": "Heller LLC",
      "ConsentSourceId": 389,
      "ConsentSourceKey": "vel",
      "ConsentSourceName": "Bosco, Schiller and Koelpin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 759
        }
      }
    }
  ],
  "BounceEmails": [
    "chasity_cole@connelly.com",
    "sammy@stiedemann.us"
  ],
  "ActiveStatusMonitorId": 781,
  "UserDefinedFields": {
    "SuperOffice:1": "Noemi Bayer",
    "SuperOffice:2": "Prof. Marcelo Kuhic"
  },
  "ExtraFields": {
    "ExtraFields1": "temporibus",
    "ExtraFields2": "dicta"
  },
  "CustomFields": {
    "CustomFields1": "sint",
    "CustomFields2": "nam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 886
    }
  }
}
```