---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
---

# POST Contact

```http
POST /api/v1/Contact
```

Creates a new ContactEntity


Calls the Contact agent service SaveContactEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Contact?$select=name,department,category/id
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

## Request Body: newEntity 

The ContactEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 568,
  "Name": "Dare Group",
  "Department": "",
  "OrgNr": "502352",
  "Number1": "856251",
  "Number2": "1479594",
  "UpdatedDate": "2020-04-01T12:15:26.5796409+02:00",
  "CreatedDate": "1998-08-25T12:15:26.5796409+02:00",
  "Emails": [
    {
      "Value": "unde",
      "StrippedValue": "praesentium",
      "Description": "Centralized bi-directional framework"
    },
    {
      "Value": "unde",
      "StrippedValue": "praesentium",
      "Description": "Centralized bi-directional framework"
    }
  ],
  "Interests": [
    {
      "Id": 272,
      "Name": "Rosenbaum-Hermiston",
      "ToolTip": "Rerum temporibus at quia.",
      "Deleted": true,
      "Rank": 342,
      "Type": "aut",
      "ColorBlock": 217,
      "IconHint": "alias",
      "Selected": false,
      "LastChanged": "2000-10-25T12:15:26.5796409+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "mollitia",
      "StyleHint": "beatae",
      "Hidden": false,
      "FullName": "Coy Jones DVM"
    }
  ],
  "Urls": [
    {
      "Value": "a",
      "StrippedValue": "non",
      "Description": "Reduced local customer loyalty"
    },
    {
      "Value": "a",
      "StrippedValue": "non",
      "Description": "Reduced local customer loyalty"
    }
  ],
  "Phones": [
    {
      "Value": "itaque",
      "StrippedValue": "animi",
      "Description": "Sharable system-worthy portal"
    },
    {
      "Value": "itaque",
      "StrippedValue": "animi",
      "Description": "Sharable system-worthy portal"
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "consequuntur",
      "Description": "Visionary impactful database"
    },
    {
      "Value": "aut",
      "StrippedValue": "consequuntur",
      "Description": "Visionary impactful database"
    }
  ],
  "Description": "Visionary modular access",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "tempore",
      "PersonId": 713,
      "Mrmrs": "autem",
      "Firstname": "Terrence",
      "Lastname": "Balistreri",
      "MiddleName": "Borer, Swaniawski and Mann",
      "Title": "in",
      "Description": "Focused uniform parallelism",
      "Email": "nelle@klocko.co.uk",
      "FullName": "Mr. Merritt August Senger DVM",
      "DirectPhone": "000.982.5697 x572",
      "FormalName": "Schimmel Group",
      "CountryId": 502,
      "ContactId": 797,
      "ContactName": "Gutkowski, Abbott and Baumbach",
      "Retired": 104,
      "Rank": 548,
      "ActiveInterests": 864,
      "ContactDepartment": "",
      "ContactCountryId": 424,
      "ContactOrgNr": "1139144",
      "FaxPhone": "(020)881-7088 x79143",
      "MobilePhone": "1-290-336-6147",
      "ContactPhone": "161.243.3655",
      "AssociateName": "Hirthe LLC",
      "AssociateId": 300,
      "UsePersonAddress": false,
      "ContactFax": "omnis",
      "Kanafname": "voluptatem",
      "Kanalname": "ipsa",
      "Post1": "nemo",
      "Post2": "delectus",
      "Post3": "asperiores",
      "EmailName": "johanna@ortiz.com",
      "ContactFullName": "Krystal Von",
      "ActiveErpLinks": 2,
      "TicketPriorityId": 322,
      "SupportLanguageId": 197,
      "SupportAssociateId": 371,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "quibusdam",
  "Xstop": false,
  "ActiveInterests": 50,
  "GroupId": 602,
  "ActiveStatusMonitorId": 101,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 291,
  "DbiAgentId": 169,
  "DbiLastSyncronized": "2005-06-02T12:15:26.5856407+02:00",
  "DbiKey": "sunt",
  "DbiLastModified": "1996-08-04T12:15:26.5856407+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 4,
  "ActiveErpLinks": 277,
  "BounceEmails": [
    "kendrick.stark@kuvalis.co.uk",
    "randall_douglas@dare.name"
  ],
  "Domains": [
    "id",
    "nulla"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mitchel McDermott",
    "SuperOffice:2": "1944835089"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "unde",
    "CustomFields2": "vel"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 221,
  "Name": "Green, Upton and Wehner",
  "Department": "",
  "OrgNr": "770982",
  "Number1": "1468426",
  "Number2": "1431149",
  "UpdatedDate": "2011-07-19T12:15:26.5946407+02:00",
  "CreatedDate": "2012-02-13T12:15:26.5946407+01:00",
  "Emails": [
    {
      "Value": "consequuntur",
      "StrippedValue": "rerum",
      "Description": "Synergized reciprocal process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 158
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "rerum",
      "Description": "Synergized reciprocal process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 158
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 380,
      "Name": "Mueller, Leuschke and Gaylord",
      "ToolTip": "Nisi necessitatibus omnis ut occaecati autem natus quisquam.",
      "Deleted": false,
      "Rank": 337,
      "Type": "sint",
      "ColorBlock": 477,
      "IconHint": "eos",
      "Selected": true,
      "LastChanged": "2018-09-21T12:15:26.5956409+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "optio",
      "StyleHint": "quibusdam",
      "Hidden": true,
      "FullName": "Hollie Becker",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 700
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "delectus",
      "StrippedValue": "nihil",
      "Description": "Automated dynamic structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 197
        }
      }
    },
    {
      "Value": "delectus",
      "StrippedValue": "nihil",
      "Description": "Automated dynamic structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 197
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "earum",
      "Description": "Realigned motivating frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 5
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "earum",
      "Description": "Realigned motivating frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 5
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "vel",
      "Description": "Phased mobile support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 595
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "vel",
      "Description": "Phased mobile support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 595
        }
      }
    }
  ],
  "Description": "Programmable mission-critical time-frame",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "minima",
      "PersonId": 696,
      "Mrmrs": "excepturi",
      "Firstname": "Ruben",
      "Lastname": "Marquardt",
      "MiddleName": "O'Kon LLC",
      "Title": "ut",
      "Description": "Visionary dedicated pricing structure",
      "Email": "romaine_schuppe@hauck.biz",
      "FullName": "Miss Estevan Goyette PhD",
      "DirectPhone": "1-908-708-7510",
      "FormalName": "Koepp Group",
      "CountryId": 923,
      "ContactId": 268,
      "ContactName": "Ziemann-Fahey",
      "Retired": 151,
      "Rank": 19,
      "ActiveInterests": 56,
      "ContactDepartment": "",
      "ContactCountryId": 78,
      "ContactOrgNr": "1124748",
      "FaxPhone": "(037)798-1338 x29958",
      "MobilePhone": "565.183.5654",
      "ContactPhone": "615-160-9604",
      "AssociateName": "Hansen-Koss",
      "AssociateId": 120,
      "UsePersonAddress": false,
      "ContactFax": "sed",
      "Kanafname": "enim",
      "Kanalname": "quibusdam",
      "Post1": "dolorem",
      "Post2": "tempora",
      "Post3": "atque",
      "EmailName": "alison@sanford.uk",
      "ContactFullName": "Estel Hackett",
      "ActiveErpLinks": 467,
      "TicketPriorityId": 474,
      "SupportLanguageId": 656,
      "SupportAssociateId": 753,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 757
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "ratione",
  "Xstop": false,
  "ActiveInterests": 469,
  "GroupId": 999,
  "ActiveStatusMonitorId": 739,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 306,
  "DbiAgentId": 370,
  "DbiLastSyncronized": "2002-10-23T12:15:26.5996407+02:00",
  "DbiKey": "earum",
  "DbiLastModified": "1998-06-20T12:15:26.5996407+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 745,
  "ActiveErpLinks": 525,
  "BounceEmails": [
    "dulce.hagenes@kirlin.name",
    "oswaldo@hudsonjenkins.us"
  ],
  "Domains": [
    "illo",
    "sit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Kira Cremin",
    "SuperOffice:2": "Ethan Fay"
  },
  "ExtraFields": {
    "ExtraFields1": "expedita",
    "ExtraFields2": "suscipit"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "laudantium"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 681
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```