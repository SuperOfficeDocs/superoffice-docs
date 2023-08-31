---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 07 Feb 2001 03:31:32 G2T

{
  "ContactId": 668,
  "Name": "Nienow, Purdy and Deckow",
  "Department": "",
  "OrgNr": "1240043",
  "Number1": "1082055",
  "Number2": "860390",
  "UpdatedDate": "2001-02-07T03:31:32.3945891+01:00",
  "CreatedDate": "2015-06-08T03:31:32.3945891+02:00",
  "Emails": [
    {
      "Value": "esse",
      "StrippedValue": "rerum",
      "Description": "Vision-oriented maximized orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 651
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "rerum",
      "Description": "Vision-oriented maximized orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 651
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 435,
      "Name": "Tremblay, Windler and Bernier",
      "ToolTip": "Molestiae aliquam labore ipsa.",
      "Deleted": false,
      "Rank": 950,
      "Type": "qui",
      "ColorBlock": 124,
      "IconHint": "autem",
      "Selected": true,
      "LastChanged": "2021-03-14T03:31:32.3945891+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "eveniet",
      "Hidden": false,
      "FullName": "Prof. Lucinda Lionel Runolfsdottir II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 435
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "id",
      "StrippedValue": "aliquid",
      "Description": "Proactive dynamic knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 658
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "aliquid",
      "Description": "Proactive dynamic knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 658
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "omnis",
      "Description": "Automated mission-critical matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 293
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "omnis",
      "Description": "Automated mission-critical matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 293
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "molestiae",
      "StrippedValue": "distinctio",
      "Description": "Pre-emptive holistic migration",
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
      "Value": "molestiae",
      "StrippedValue": "distinctio",
      "Description": "Pre-emptive holistic migration",
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
  "Description": "Multi-lateral intermediate project",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "distinctio",
      "PersonId": 448,
      "Mrmrs": "voluptatem",
      "Firstname": "Claudia",
      "Lastname": "Murphy",
      "MiddleName": "Hansen LLC",
      "Title": "sint",
      "Description": "De-engineered discrete artificial intelligence",
      "Email": "jaron.luettgen@koelpin.info",
      "FullName": "Mr. Betty Stamm Jr.",
      "DirectPhone": "1-383-901-2839 x31340",
      "FormalName": "Kemmer-Robel",
      "CountryId": 497,
      "ContactId": 243,
      "ContactName": "Heller LLC",
      "Retired": 435,
      "Rank": 800,
      "ActiveInterests": 218,
      "ContactDepartment": "",
      "ContactCountryId": 324,
      "ContactOrgNr": "736586",
      "FaxPhone": "635.601.8406 x6321",
      "MobilePhone": "550-451-8381 x48082",
      "ContactPhone": "184.971.3433 x20053",
      "AssociateName": "Bechtelar Group",
      "AssociateId": 502,
      "UsePersonAddress": true,
      "ContactFax": "similique",
      "Kanafname": "dolore",
      "Kanalname": "aperiam",
      "Post1": "et",
      "Post2": "voluptas",
      "Post3": "hic",
      "EmailName": "drew@hamillbrekke.name",
      "ContactFullName": "Ms. Isabella Jakubowski",
      "ActiveErpLinks": 703,
      "TicketPriorityId": 516,
      "SupportLanguageId": 966,
      "SupportAssociateId": 709,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 639
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quidem",
  "Xstop": true,
  "ActiveInterests": 922,
  "GroupId": 9,
  "ActiveStatusMonitorId": 160,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 384,
  "DbiAgentId": 554,
  "DbiLastSyncronized": "2006-09-25T03:31:32.3945891+02:00",
  "DbiKey": "aut",
  "DbiLastModified": "2016-06-22T03:31:32.3945891+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 294,
  "ActiveErpLinks": 322,
  "BounceEmails": [
    "greg.weimann@larson.co.uk",
    "mia@hayes.co.uk"
  ],
  "Domains": [
    "et",
    "veniam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Frederic Kuvalis",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsum",
    "ExtraFields2": "neque"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "fugit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 911
    }
  }
}
```