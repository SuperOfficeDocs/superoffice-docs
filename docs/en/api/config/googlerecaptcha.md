---
uid: ns_config_googlerecaptcha
title: GoogleRecaptcha element
description: NetServer configuration values for the Google reCAPTCHA validation service.
keywords: config, NetServer, web.config, Google reCAPTCHA, GoogleRecaptcha, SecretKey, SiteKey, VerificationUrl
author: Bergfrid Dias
date: 03.05.2024
content_type: reference
redirect_from: /en/api/netserver/config/googlerecaptcha
---

# NetServer GoogleRecaptcha element

Configuration values for the Google reCAPTCHA validation service.

| Name | Description |
|---|---|
| SecretKey | The secret key from the Google reCAPTCHA instance. |
| SiteKey | The site key from the Google reCAPTCHA instance. |
| VerificationUrl | URL for Google reCAPTCHA validation service. |

See the [NetServer Core reference][1] for details about handling this programmatically.

## Set VerificationUrl

For reCAPTCHA to work in an Onsite installation, the NetServer needs to have access to the Google verification URL. This is used to verify the reCAPTCHA attempt.

Add this line under the `<sectionGroup name="SuperOffice">`:

```xml
<section name="GoogleRecaptcha" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
```

## Set keys

As an alternative to setting keys manually in each reCAPTCHA form element, add these lines under the section `<SuperOffice>`:

```xml
<GoogleRecaptcha>
  <add key="VerificationUrl" value="[https://www.google.com/recaptcha/api/siteverify](https://www.google.com/recaptcha/api/siteverify)" />
  <add key="SiteKey" value="<sitekey>" />
  <add key="SecretKey" value="<secretkey>" />
</GoogleRecaptcha>
```

These keys can be overwritten for a specific form by entering the keys when [adding the reCAPTCHA element to the form][2].

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.GoogleRecaptcha>
[2]: ../../marketing/forms/learn/recaptcha.md
