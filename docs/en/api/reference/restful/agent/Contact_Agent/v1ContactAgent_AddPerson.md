---
title: POST Agents/Contact/AddPerson
uid: v1ContactAgent_AddPerson
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
| ContactId | int32 |  |
| NewPersonEntity |  |  |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/AddPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 281,
  "NewPersonEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 184,
  "Firstname": "Florence",
  "MiddleName": "Bins, Shanahan and Cole",
  "Lastname": "Mohr",
  "Mrmrs": "earum",
  "Title": "harum",
  "UpdatedDate": "2017-09-16T02:49:43.9816534+02:00",
  "CreatedDate": "1999-08-16T02:49:43.9816534+02:00",
  "BirthDate": "2011-03-17T02:49:43.9816534+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "aperiam",
      "StrippedValue": "enim",
      "Description": "Adaptive impactful knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 980
        }
      }
    },
    {
      "Value": "aperiam",
      "StrippedValue": "enim",
      "Description": "Adaptive impactful knowledge base",
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
  "Description": "Proactive 3rd generation definition",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "est",
      "StrippedValue": "ut",
      "Description": "Seamless user-facing project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 987
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "ut",
      "Description": "Seamless user-facing project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 987
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sint",
      "StrippedValue": "impedit",
      "Description": "Organic local process improvement",
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
      "Value": "sint",
      "StrippedValue": "impedit",
      "Description": "Organic local process improvement",
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
  "MobilePhones": [
    {
      "Value": "velit",
      "StrippedValue": "id",
      "Description": "Cross-group zero administration leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 89
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "id",
      "Description": "Cross-group zero administration leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 89
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "aut",
      "StrippedValue": "quod",
      "Description": "Re-engineered context-sensitive knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 374
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "quod",
      "Description": "Re-engineered context-sensitive knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 374
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "nulla",
      "StrippedValue": "perferendis",
      "Description": "Balanced directional hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 149
        }
      }
    },
    {
      "Value": "nulla",
      "StrippedValue": "perferendis",
      "Description": "Balanced directional hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 149
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
      "Id": 631,
      "Name": "Rempel, Wilderman and Strosin",
      "ToolTip": "Placeat maxime cum et natus.",
      "Deleted": false,
      "Rank": 602,
      "Type": "ea",
      "ColorBlock": 347,
      "IconHint": "commodi",
      "Selected": true,
      "LastChanged": "2008-07-25T02:49:43.9816534+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repudiandae",
      "StyleHint": "nam",
      "Hidden": true,
      "FullName": "Ms. Mya Blanda Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 640
        }
      }
    }
  ],
  "PersonNumber": "1747716",
  "FullName": "Finn Hammes",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "corrupti",
      "StrippedValue": "architecto",
      "Description": "Intuitive fault-tolerant collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 448
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "architecto",
      "Description": "Intuitive fault-tolerant collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 448
        }
      }
    }
  ],
  "FormalName": "Effertz, Pagac and Breitenberg",
  "Address": null,
  "Post3": "eligendi",
  "Post2": "assumenda",
  "Post1": "et",
  "Kanalname": "quibusdam",
  "Kanafname": "vel",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "consequatur",
  "ActiveInterests": 106,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 427,
  "DbiKey": "nemo",
  "DbiLastModified": "1997-02-28T02:49:43.9816534+01:00",
  "DbiLastSyncronized": "2010-11-10T02:49:43.9816534+01:00",
  "SentInfo": 860,
  "ShowContactTickets": 397,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "magni",
      "StrippedValue": "corrupti",
      "Description": "Customizable stable software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 380
        }
      }
    },
    {
      "Value": "magni",
      "StrippedValue": "corrupti",
      "Description": "Customizable stable software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 380
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "aliquid",
      "StrippedValue": "aut",
      "Description": "Fundamental content-based open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 663
        }
      }
    },
    {
      "Value": "aliquid",
      "StrippedValue": "aut",
      "Description": "Fundamental content-based open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 663
        }
      }
    }
  ],
  "Source": 831,
  "ActiveErpLinks": 768,
  "ShipmentTypes": [
    {
      "Id": 782,
      "Name": "McDermott, Sawayn and Toy",
      "ToolTip": "Itaque et odit eos dignissimos porro.",
      "Deleted": false,
      "Rank": 698,
      "Type": "aut",
      "ColorBlock": 866,
      "IconHint": "maiores",
      "Selected": true,
      "LastChanged": "2018-11-27T02:49:43.9816534+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "adipisci",
      "StyleHint": "non",
      "Hidden": false,
      "FullName": "Rahul Towne",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 560
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 648,
      "Comment": "quidem",
      "Registered": "2012-03-22T02:49:43.9816534+01:00",
      "RegisteredAssociateId": 235,
      "Updated": "2020-02-04T02:49:43.9816534+01:00",
      "UpdatedAssociateId": 61,
      "LegalBaseId": 417,
      "LegalBaseKey": "ut",
      "LegalBaseName": "O'Conner Inc and Sons",
      "ConsentPurposeId": 617,
      "ConsentPurposeKey": "debitis",
      "ConsentPurposeName": "Sauer-Padberg",
      "ConsentSourceId": 92,
      "ConsentSourceKey": "quod",
      "ConsentSourceName": "Sanford-Champlin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 664
        }
      }
    }
  ],
  "BounceEmails": [
    "marley@pfannerstill.ca",
    "hector_schimmel@toygibson.com"
  ],
  "ActiveStatusMonitorId": 1002,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Mrs. Dominic Sauer II"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "tempora"
  },
  "CustomFields": {
    "CustomFields1": "vero",
    "CustomFields2": "amet"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 902
    }
  }
}
```