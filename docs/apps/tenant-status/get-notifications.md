---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: get_notifications       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Get notifications when tenant status changes # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Get notifications when tenant status changes

When a tenant installation undergoes changes, SuperOffice sends a change notification to each approved application.

## To receive notifications (onetime set-up)

1. Set up a web service listening for state changes. For example:

```csharp
https://www.awesomeapp.com/NotifyCustomerStateChange
```

2. Notify SuperOffice about your **State Change URL**, which specifies where SuperOffice sends notifications.

## Parsing notifications

The JSON payload contains the following information:

* tenant context identifier
* the [change type][1]
* a text representation of the installation version
* the version of the file set
* a JWT to verify it was sent by SuperOffice

```javascript
{
  "ChangeType": 0,
  "ContextIdentifier": "Cust12345",
  "VersionName": "Release 8.4 R08",
  "FileVersion": "8.4.12.1234",
  "Token": "ejy234ASD...1234#"
}
```

Check out our [sample notification code][2].

<!-- Referenced links -->
[1]: index.md
[2]: notifications-example.md
