---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
---

# GET Contact/default

```http
GET /api/v1/Contact/default
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Contact agent service CreateDefaultContactEntity.







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

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

## Sample request

```http!
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 30 Jan 2001 11:22:44 G1T

{
  "ContactId": 586,
  "Name": "Carter-Tremblay",
  "Department": "",
  "OrgNr": "1644363",
  "Number1": "227567",
  "Number2": "1741367",
  "UpdatedDate": "2001-01-30T11:22:44.4601431+01:00",
  "CreatedDate": "2022-04-19T11:22:44.4601431+02:00",
  "Emails": [
    {
      "Value": "quae",
      "StrippedValue": "aliquam",
      "Description": "Persevering demand-driven contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 437
        }
      }
    },
    {
      "Value": "quae",
      "StrippedValue": "aliquam",
      "Description": "Persevering demand-driven contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 437
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 220,
      "Name": "Turner LLC",
      "ToolTip": "Sed esse blanditiis.",
      "Deleted": true,
      "Rank": 571,
      "Type": "dignissimos",
      "ColorBlock": 932,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "2018-10-06T11:22:44.4601431+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "deleniti",
      "StyleHint": "explicabo",
      "Hidden": false,
      "FullName": "Miss Eloise Auer Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 343
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "cupiditate",
      "StrippedValue": "rem",
      "Description": "Self-enabling explicit service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 966
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "rem",
      "Description": "Self-enabling explicit service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 966
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "omnis",
      "StrippedValue": "excepturi",
      "Description": "Organic impactful data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 436
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "excepturi",
      "Description": "Organic impactful data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 436
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "exercitationem",
      "StrippedValue": "et",
      "Description": "Persistent maximized function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 134
        }
      }
    },
    {
      "Value": "exercitationem",
      "StrippedValue": "et",
      "Description": "Persistent maximized function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 134
        }
      }
    }
  ],
  "Description": "Distributed scalable throughput",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "minima",
      "PersonId": 880,
      "Mrmrs": "quas",
      "Firstname": "Dimitri",
      "Lastname": "Schinner",
      "MiddleName": "Ledner, Maggio and Predovic",
      "Title": "qui",
      "Description": "Visionary client-driven leverage",
      "Email": "ward@harveybaumbach.name",
      "FullName": "Ronaldo Turcotte",
      "DirectPhone": "496-268-5218 x166",
      "FormalName": "Streich-Stokes",
      "CountryId": 999,
      "ContactId": 87,
      "ContactName": "Pouros, Maggio and Monahan",
      "Retired": 932,
      "Rank": 645,
      "ActiveInterests": 989,
      "ContactDepartment": "",
      "ContactCountryId": 741,
      "ContactOrgNr": "1289733",
      "FaxPhone": "058-517-6168 x79779",
      "MobilePhone": "(969)597-2757",
      "ContactPhone": "(014)650-4464 x37011",
      "AssociateName": "Rice-Prosacco",
      "AssociateId": 513,
      "UsePersonAddress": true,
      "ContactFax": "tempora",
      "Kanafname": "eveniet",
      "Kanalname": "vitae",
      "Post1": "quod",
      "Post2": "reprehenderit",
      "Post3": "hic",
      "EmailName": "dillon@doyle.uk",
      "ContactFullName": "Susanna Macejkovic",
      "ActiveErpLinks": 959,
      "TicketPriorityId": 835,
      "SupportLanguageId": 543,
      "SupportAssociateId": 813,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 916
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "vero",
  "Xstop": true,
  "ActiveInterests": 246,
  "GroupId": 123,
  "ActiveStatusMonitorId": 509,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 769,
  "DbiAgentId": 312,
  "DbiLastSyncronized": "1999-10-16T11:22:44.4601431+02:00",
  "DbiKey": "quae",
  "DbiLastModified": "2004-11-02T11:22:44.4601431+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 311,
  "ActiveErpLinks": 784,
  "BounceEmails": [
    "jamar_leuschke@croninhermann.co.uk",
    "alysha@hilpert.ca"
  ],
  "Domains": [
    "pariatur",
    "sunt"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Jensen Abbott DVM",
    "SuperOffice:2": "1306415036"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "accusantium"
  },
  "CustomFields": {
    "CustomFields1": "sunt",
    "CustomFields2": "tenetur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 662
    }
  }
}
```