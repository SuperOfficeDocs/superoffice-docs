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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 607,
  "Name": "Jones-Daniel",
  "Department": "",
  "OrgNr": "367712",
  "Number1": "434902",
  "Number2": "1146961",
  "UpdatedDate": "2013-06-09T13:28:31.4136779+02:00",
  "CreatedDate": "2014-11-10T13:28:31.4136779+01:00",
  "Emails": [
    {
      "Value": "dolorem",
      "StrippedValue": "neque",
      "Description": "Innovative executive hardware"
    },
    {
      "Value": "dolorem",
      "StrippedValue": "neque",
      "Description": "Innovative executive hardware"
    }
  ],
  "Interests": [
    {
      "Id": 214,
      "Name": "Dicki-Daugherty",
      "ToolTip": "Vitae laborum cumque.",
      "Deleted": false,
      "Rank": 282,
      "Type": "quo",
      "ColorBlock": 734,
      "IconHint": "voluptas",
      "Selected": false,
      "LastChanged": "2013-03-19T13:28:31.4136779+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequatur",
      "StyleHint": "assumenda",
      "Hidden": false,
      "FullName": "Alejandrin Zoila Littel I"
    }
  ],
  "Urls": [
    {
      "Value": "molestiae",
      "StrippedValue": "aut",
      "Description": "Fully-configurable maximized conglomeration"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "aut",
      "Description": "Fully-configurable maximized conglomeration"
    }
  ],
  "Phones": [
    {
      "Value": "quod",
      "StrippedValue": "fugiat",
      "Description": "Visionary user-facing pricing structure"
    },
    {
      "Value": "quod",
      "StrippedValue": "fugiat",
      "Description": "Visionary user-facing pricing structure"
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "quaerat",
      "Description": "Visionary 6th generation process improvement"
    },
    {
      "Value": "qui",
      "StrippedValue": "quaerat",
      "Description": "Visionary 6th generation process improvement"
    }
  ],
  "Description": "Virtual heuristic encryption",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sed",
      "PersonId": 621,
      "Mrmrs": "labore",
      "Firstname": "Alexa",
      "Lastname": "Klein",
      "MiddleName": "Denesik, Schroeder and Harber",
      "Title": "enim",
      "Description": "Multi-channelled bifurcated secured line",
      "Email": "brielle_bartell@roberts.name",
      "FullName": "Mrs. Ayana Kirlin II",
      "DirectPhone": "089.254.1886 x789",
      "FormalName": "McCullough, Schumm and Auer",
      "CountryId": 102,
      "ContactId": 5,
      "ContactName": "Stokes, Bashirian and Rogahn",
      "Retired": 337,
      "Rank": 616,
      "ActiveInterests": 41,
      "ContactDepartment": "",
      "ContactCountryId": 834,
      "ContactOrgNr": "1386067",
      "FaxPhone": "(787)276-3340",
      "MobilePhone": "(407)519-1690",
      "ContactPhone": "257.374.9696 x3714",
      "AssociateName": "Stamm LLC",
      "AssociateId": 538,
      "UsePersonAddress": true,
      "ContactFax": "qui",
      "Kanafname": "eum",
      "Kanalname": "et",
      "Post1": "odit",
      "Post2": "minus",
      "Post3": "molestiae",
      "EmailName": "rosella@fahey.info",
      "ContactFullName": "Dr. Gladys Conroy II",
      "ActiveErpLinks": 138,
      "TicketPriorityId": 414,
      "SupportLanguageId": 467,
      "SupportAssociateId": 194,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "occaecati",
  "Xstop": true,
  "ActiveInterests": 2,
  "GroupId": 211,
  "ActiveStatusMonitorId": 584,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 600,
  "DbiAgentId": 822,
  "DbiLastSyncronized": "2009-04-26T13:28:31.4292958+02:00",
  "DbiKey": "quo",
  "DbiLastModified": "2010-08-07T13:28:31.4292958+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 568,
  "ActiveErpLinks": 46,
  "BounceEmails": [
    "tevin_blick@nitzschefranecki.co.uk",
    "gudrun.morar@padbergpfannerstill.com"
  ],
  "Domains": [
    "et",
    "omnis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Haven Watsica II",
    "SuperOffice:2": "Dr. Hailee Monica Hirthe DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "iure"
  },
  "CustomFields": {
    "CustomFields1": "recusandae",
    "CustomFields2": "aliquam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 504,
  "Name": "Schinner-Balistreri",
  "Department": "monetize killer bandwidth",
  "OrgNr": "1797328",
  "Number1": "1411657",
  "Number2": "1698043",
  "UpdatedDate": "2002-11-10T13:28:31.4292958+01:00",
  "CreatedDate": "2015-10-02T13:28:31.4292958+02:00",
  "Emails": [
    {
      "Value": "nostrum",
      "StrippedValue": "accusamus",
      "Description": "Total incremental attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "accusamus",
      "Description": "Total incremental attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 552,
      "Name": "Maggio, Reynolds and Tremblay",
      "ToolTip": "Neque iusto ab sed ab earum non.",
      "Deleted": true,
      "Rank": 445,
      "Type": "sint",
      "ColorBlock": 472,
      "IconHint": "eius",
      "Selected": false,
      "LastChanged": "2006-12-06T13:28:31.4292958+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "incidunt",
      "StyleHint": "sed",
      "Hidden": true,
      "FullName": "Miss Geovanny Johnson I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 363
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sint",
      "StrippedValue": "quo",
      "Description": "Decentralized didactic ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 385
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "quo",
      "Description": "Decentralized didactic ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 385
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "exercitationem",
      "StrippedValue": "rerum",
      "Description": "Horizontal bi-directional info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 191
        }
      }
    },
    {
      "Value": "exercitationem",
      "StrippedValue": "rerum",
      "Description": "Horizontal bi-directional info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 191
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eos",
      "StrippedValue": "repellendus",
      "Description": "Synergized asynchronous initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 765
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "repellendus",
      "Description": "Synergized asynchronous initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 765
        }
      }
    }
  ],
  "Description": "Fully-configurable dedicated project",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quaerat",
      "PersonId": 505,
      "Mrmrs": "molestiae",
      "Firstname": "Ambrose",
      "Lastname": "Farrell",
      "MiddleName": "Volkman-Will",
      "Title": "ut",
      "Description": "Streamlined demand-driven function",
      "Email": "watson@hermiston.uk",
      "FullName": "Jazlyn Beer",
      "DirectPhone": "240-888-3531",
      "FormalName": "Rice, McKenzie and Treutel",
      "CountryId": 289,
      "ContactId": 813,
      "ContactName": "Zemlak-Oberbrunner",
      "Retired": 106,
      "Rank": 74,
      "ActiveInterests": 177,
      "ContactDepartment": "",
      "ContactCountryId": 27,
      "ContactOrgNr": "616795",
      "FaxPhone": "1-194-300-3970 x04101",
      "MobilePhone": "371.560.3707 x99273",
      "ContactPhone": "(828)558-6199 x100",
      "AssociateName": "Kuhn-Bauch",
      "AssociateId": 298,
      "UsePersonAddress": false,
      "ContactFax": "fugiat",
      "Kanafname": "dolore",
      "Kanalname": "qui",
      "Post1": "excepturi",
      "Post2": "nostrum",
      "Post3": "dolor",
      "EmailName": "zane@gutmannwyman.us",
      "ContactFullName": "Mr. Felipe Vernon Strosin",
      "ActiveErpLinks": 153,
      "TicketPriorityId": 940,
      "SupportLanguageId": 691,
      "SupportAssociateId": 125,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 364
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "quia",
  "Xstop": false,
  "ActiveInterests": 657,
  "GroupId": 602,
  "ActiveStatusMonitorId": 876,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 17,
  "DbiAgentId": 416,
  "DbiLastSyncronized": "1997-10-26T13:28:31.4449206+01:00",
  "DbiKey": "atque",
  "DbiLastModified": "2007-07-07T13:28:31.4449206+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 248,
  "ActiveErpLinks": 832,
  "BounceEmails": [
    "favian.gottlieb@heller.ca",
    "randall@gerlachschuppe.info"
  ],
  "Domains": [
    "nisi",
    "quia"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Rosetta Walter",
    "SuperOffice:2": "Ms. Chauncey Amanda Wuckert"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "sed"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 343
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```