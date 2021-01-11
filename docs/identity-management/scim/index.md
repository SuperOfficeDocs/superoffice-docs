---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: scim_intro       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: What is SCIM? Why use SCIM?                # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {frodeb@superoffice.com}             # Your GitHub alias.
keywords: SCIM
so.topic: concept                    # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir:  cloud                   # cloud or onsite
so.client:  online                  # online, web, win, pocket, or mobile
---

# System for Cross-domain Identity Management (SCIM)

SCIM is a common language to describe what an identity is and how to handle it. With SuperOffice you can user SCIM to automate user provisioning from Azure AD.

## What is SCIM?

**System for Cross-domain Identity Management** (SCIM) is an open REST- and JSON-based standard designed to simplify identity management in a diverse cloud environment.

The standard has 2 main components:

* **RFC 7643** is the core schema
* **RFC 7644** is the protocol

Cross-domain identity management is not a new thing. There are many APIs and connectors for moving user objects between systems. However, the challenge has been that you had to build your own connector for each pair of connected systems. Every time you brought in a new application and wanted to provision it, you had to write a connector for it. This obviously does not scale well in large enterprises. Also, the custom APIs introduce problems with diversity and keeping up with changes.

SCIM introduces interoperability, portability, and a single standardized API. It is **not a substitution** for your established identity management solution, but rather a standardizing wrapper -  or a thin top layer if you prefer the protocol stack view.

> [!NOTE]
> Because SCIM defines a small mandatory core plus a wide range of optional stuff, you will most likely find that SCIM implementations differ despite being compliant.

### Schema - users and groups

The schema ([RFC 7643][1]) defines how we **model data**. Every identity has a unique ID, a user name, and some metadata. The minimal **JSON** representation of a user looks like this in the spec:

```json
{
  "schemas": ["urn:ietf:params:scim:schemas:core:2.0:User"],
  "id": "2819c223-7f76-453a-919d-413861904646",
  "userName": "bjensen@example.com",
  "meta": {
    "resourceType": "User",
    "created": "2010-01-23T04:56:22Z",
    "lastModified": "2011-05-13T04:42:34Z",
    "version": "W\/\"3694e05e9dff590\"",
    "location":
     "https://example.com/v2/Users/2819c223-7f76-453a-919d-413861904646"
  }
}
```

Passwords are part of the schema, but you can't read out the password from the payload!

### Protocol

The light-weight protocol ([RFC 7644][2]) defines how we **interact with** the data. Because it is HTTP-based, SCIM is **firewall-friendly and platform-independent**.

> [!NOTE]
> SCIM does **not** define authentication, only provisioning.

**CRUD operations / REST verbs:**

SCIM verbs *Source: RFC 7844, section 3,2*

| HTTP method | SCIM usage |
|--------|-------|
| GET | Retrieves one or more complete or partial resources. |
| POST | Depending on the endpoint, creates new resources, creates a search request, or MAY be used to bulk-modify resources. |
| PUT | Modifies a resource by replacing existing attributes with a specified set of replacement attributes (replace). PUT MUST NOT be used to create new resources. |
| PATCH | Modifies a resource with a set of client-specified changes (partial update). |
| DELETE | Deletes a resource. |

The protocol has also optional support for attribute filters and search criteria.

**Example request and response:**

```json
POST /Users  HTTP/1.1
   Host: example.com
   Accept: application/scim+json
   Content-Type: application/scim+json
   Authorization: Bearer h480djs93hd8
   Content-Length: ...

   {
     "schemas":["urn:ietf:params:scim:schemas:core:2.0:User"],
     "userName":"bjensen",
     "externalId":"bjensen",
     "name":{
       "formatted":"Ms. Barbara J Jensen III",
       "familyName":"Jensen",
       "givenName":"Barbara"
     }
   }

HTTP/1.1 201 Created
   Content-Type: application/scim+json
   Location:
    https://example.com/v2/Users/2819c223-7f76-453a-919d-413861904646
   ETag: W/"e180ee84f0671b1"

   {
     "schemas":["urn:ietf:params:scim:schemas:core:2.0:User"],
     "id":"2819c223-7f76-453a-919d-413861904646",
     "externalId":"bjensen",
     "meta":{
       "resourceType":"User",
       "created":"2011-08-01T21:32:44.882Z",
       "lastModified":"2011-08-01T21:32:44.882Z",
       "location":
   "https://example.com/v2/Users/2819c223-7f76-453a-919d-413861904646",
       "version":"W\/\"e180ee84f0671b1\""
     },
     "name":{
       "formatted":"Ms. Barbara J Jensen III",
       "familyName":"Jensen",
       "givenName":"Barbara"
     },
     "userName":"bjensen"
   }
```

*Source: RFC 7844, section 3,3*

## Why use SCIM?

User provisioning with SCIM is rapidly gaining popularity and adoption and it puts your organization in a position to better tackle diversity and compliance while boosting productivity and security.

> [!NOTE]
> Because we don't have an exposed user management API, SCIM is the only way you can automate user provisioning and de-provisioning in SuperOffice.

Manual entry by hand is time-consuming, labor-intensive, and error-prone in large organizations. You can also save money on licenses by automatically de-allocating them from former employees and updating license type when an employee switches department and work responsibilities.

<!-- Referenced links -->
[1]: https://tools.ietf.org/html/rfc7643
[2]: https://tools.ietf.org/html/rfc7644
