---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
generated: true
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
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 859,
  "Name": "Turner, Rempel and Price",
  "Department": "",
  "OrgNr": "1206028",
  "Number1": "1867813",
  "Number2": "1354834",
  "UpdatedDate": "2019-06-27T10:30:31.8699343+02:00",
  "CreatedDate": "2014-08-31T10:30:31.8699343+02:00",
  "Emails": [
    {
      "Value": "deserunt",
      "StrippedValue": "cumque",
      "Description": "Multi-channelled client-driven structure"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "cumque",
      "Description": "Multi-channelled client-driven structure"
    }
  ],
  "Interests": [
    {
      "Id": 225,
      "Name": "Ruecker LLC",
      "ToolTip": "Voluptas aspernatur eius rerum voluptatem necessitatibus sint placeat.",
      "Deleted": true,
      "Rank": 372,
      "Type": "libero",
      "ColorBlock": 397,
      "IconHint": "quisquam",
      "Selected": true,
      "LastChanged": "2001-12-03T10:30:31.8699343+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "temporibus",
      "StyleHint": "reiciendis",
      "Hidden": true,
      "FullName": "Alford Champlin"
    }
  ],
  "Urls": [
    {
      "Value": "velit",
      "StrippedValue": "rem",
      "Description": "Customizable web-enabled middleware"
    },
    {
      "Value": "velit",
      "StrippedValue": "rem",
      "Description": "Customizable web-enabled middleware"
    }
  ],
  "Phones": [
    {
      "Value": "beatae",
      "StrippedValue": "et",
      "Description": "Customer-focused optimal leverage"
    },
    {
      "Value": "beatae",
      "StrippedValue": "et",
      "Description": "Customer-focused optimal leverage"
    }
  ],
  "Faxes": [
    {
      "Value": "unde",
      "StrippedValue": "facilis",
      "Description": "User-friendly regional functionalities"
    },
    {
      "Value": "unde",
      "StrippedValue": "facilis",
      "Description": "User-friendly regional functionalities"
    }
  ],
  "Description": "Self-enabling contextually-based standardization",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quo",
      "PersonId": 46,
      "Mrmrs": "et",
      "Firstname": "Alexandro",
      "Lastname": "Cremin",
      "MiddleName": "Koss, Dicki and Greenfelder",
      "Title": "molestias",
      "Description": "Innovative systematic encryption",
      "Email": "julianne@shanahan.name",
      "FullName": "Diana Mosciski",
      "DirectPhone": "186.258.5307 x0010",
      "FormalName": "Balistreri, Mertz and Kling",
      "CountryId": 41,
      "ContactId": 387,
      "ContactName": "Wiza, Marquardt and Langworth",
      "Retired": 952,
      "Rank": 748,
      "ActiveInterests": 686,
      "ContactDepartment": "",
      "ContactCountryId": 653,
      "ContactOrgNr": "1256466",
      "FaxPhone": "1-090-366-0415 x379",
      "MobilePhone": "561-735-6339",
      "ContactPhone": "146-726-4050 x70089",
      "AssociateName": "Witting, Shanahan and Donnelly",
      "AssociateId": 991,
      "UsePersonAddress": true,
      "ContactFax": "mollitia",
      "Kanafname": "voluptate",
      "Kanalname": "tempora",
      "Post1": "quia",
      "Post2": "eaque",
      "Post3": "ipsam",
      "EmailName": "camren_medhurst@miller.uk",
      "ContactFullName": "Miss Sage Homenick IV",
      "ActiveErpLinks": 279,
      "TicketPriorityId": 197,
      "SupportLanguageId": 16,
      "SupportAssociateId": 226,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "eum",
  "Xstop": false,
  "ActiveInterests": 708,
  "GroupId": 528,
  "ActiveStatusMonitorId": 597,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 516,
  "DbiAgentId": 380,
  "DbiLastSyncronized": "2013-10-16T10:30:31.8699343+02:00",
  "DbiKey": "laboriosam",
  "DbiLastModified": "2008-10-13T10:30:31.8699343+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 255,
  "ActiveErpLinks": 246,
  "BounceEmails": [
    "cordie@boehmlittel.ca",
    "dolly_nicolas@toyosinski.us"
  ],
  "Domains": [
    "est",
    "nemo"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Jaylin Lowe",
    "SuperOffice:2": "753602333"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "nisi"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "eaque"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 983,
  "Name": "Lueilwitz-Feil",
  "Department": "expedite dynamic vortals",
  "OrgNr": "1147903",
  "Number1": "971923",
  "Number2": "931310",
  "UpdatedDate": "2013-02-21T10:30:31.8699343+01:00",
  "CreatedDate": "2012-07-28T10:30:31.8699343+02:00",
  "Emails": [
    {
      "Value": "possimus",
      "StrippedValue": "omnis",
      "Description": "Pre-emptive motivating ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 787
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "omnis",
      "Description": "Pre-emptive motivating ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 787
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 226,
      "Name": "Robel-Kiehn",
      "ToolTip": "Vel harum aut ad earum repellendus est aliquid.",
      "Deleted": true,
      "Rank": 194,
      "Type": "aut",
      "ColorBlock": 74,
      "IconHint": "reprehenderit",
      "Selected": false,
      "LastChanged": "2012-07-01T10:30:31.8699343+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ea",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Ines Terry",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 361
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "tenetur",
      "StrippedValue": "odio",
      "Description": "User-centric eco-centric artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 490
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "odio",
      "Description": "User-centric eco-centric artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 490
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "veniam",
      "StrippedValue": "voluptatum",
      "Description": "Realigned 5th generation conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 875
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "voluptatum",
      "Description": "Realigned 5th generation conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 875
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sunt",
      "StrippedValue": "non",
      "Description": "Expanded modular productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 474
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "non",
      "Description": "Expanded modular productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 474
        }
      }
    }
  ],
  "Description": "Pre-emptive content-based pricing structure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quos",
      "PersonId": 515,
      "Mrmrs": "neque",
      "Firstname": "Jensen",
      "Lastname": "Rodriguez",
      "MiddleName": "Nicolas Group",
      "Title": "et",
      "Description": "Synchronised multimedia architecture",
      "Email": "jo@gutmannjacobson.biz",
      "FullName": "Ms. Brody Von Sr.",
      "DirectPhone": "(605)592-5085 x8883",
      "FormalName": "Wolf-Crooks",
      "CountryId": 13,
      "ContactId": 681,
      "ContactName": "Towne-Wisozk",
      "Retired": 958,
      "Rank": 716,
      "ActiveInterests": 792,
      "ContactDepartment": "",
      "ContactCountryId": 68,
      "ContactOrgNr": "756725",
      "FaxPhone": "339-989-2253 x9334",
      "MobilePhone": "126-702-7219 x1396",
      "ContactPhone": "974-390-0721",
      "AssociateName": "Rath-Mitchell",
      "AssociateId": 464,
      "UsePersonAddress": false,
      "ContactFax": "cumque",
      "Kanafname": "asperiores",
      "Kanalname": "nobis",
      "Post1": "eos",
      "Post2": "recusandae",
      "Post3": "ipsum",
      "EmailName": "elva@satterfield.ca",
      "ContactFullName": "Dr. Eliane Emilie Bins DVM",
      "ActiveErpLinks": 311,
      "TicketPriorityId": 783,
      "SupportLanguageId": 826,
      "SupportAssociateId": 782,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 724
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "veritatis",
  "Xstop": true,
  "ActiveInterests": 653,
  "GroupId": 425,
  "ActiveStatusMonitorId": 781,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 212,
  "DbiAgentId": 310,
  "DbiLastSyncronized": "2001-03-27T10:30:31.8855621+02:00",
  "DbiKey": "neque",
  "DbiLastModified": "2018-08-22T10:30:31.8855621+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 607,
  "ActiveErpLinks": 359,
  "BounceEmails": [
    "felton@orn.info",
    "danyka_hettinger@little.co.uk"
  ],
  "Domains": [
    "facilis",
    "rerum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Raheem Greenholt",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "nisi",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "occaecati",
    "CustomFields2": "illum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 283
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```