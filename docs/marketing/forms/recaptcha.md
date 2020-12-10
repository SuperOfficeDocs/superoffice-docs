---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: recaptcha       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Google reCaptcha in Forms # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Google reCaptcha in Forms

Since SuperOffice 8.5 R04 we have introduced a new feature in Forms - Google reCaptcha. It is possible to use it in both Onsite and Online offerings.

reCaptcha is found in Form - Fields - add element - Form elements:

![imagehkoheq.png][1]

> [!NOTE]
> It is only possible to add one reCaptcha per form.

When the element is added you can decide how you'll use the Site and Secret keys:

## SuperOffice Online

In SuperOffice Online we, by default, provide you with our default keys. If you do not want to setup your own reCaptcha profile and do not need the statistics, you do not need to fill in anything to the Site key and Secret key. This way the reCaptcha element will work out-of-the-box using our predefined set of keys protecting your form from robots.

If you are interested in the reCaptcha statistics, you can make your reCaptcha profile (see below) and enter your own Site key and Secret key. Statistics provide information like Requests passed & failed, Average Score, Sessions completed, Average Response Time (for more info see [https://www.google.com/recaptcha/admin][2].

![imagehekct.png][3]

## SuperOffice Onsite

For SuperOffice Onsite you need to make your own reCaptcha profile and get your Site and Secret key. If you do not want to enter the keys every time to the reCaptcha form element, you can specify them in the web.config for the NetServer used by Service. Then you do not need to give the keys for each form you create.

For reCaptcha to work in an Onsite installation, the NetServer needs to have access to the Google verification URL (see below). This is used to verify the reCaptcha attempt.

You need to add this line under the `<sectionGroup name="SuperOffice">`:

```xml
<section name="GoogleRecaptcha" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
```

And these lines under the section `<SuperOffice>`:

```xml
<GoogleRecaptcha>
  <add key="VerificationUrl" value="[https://www.google.com/recaptcha/api/siteverify](https://www.google.com/recaptcha/api/siteverify)" />
  <add key="SiteKey" value="<sitekey>" />
  <add key="SecretKey" value="<secretkey>" />
</GoogleRecaptcha>
```

The above web.config changes need to be done only if you want to specify the keys in the web.config. reCaptcha will work without these but you will have to add the keys to the form each time.

If you add the keys to the web.config you still will be able to overwrite them and add different ones directly to the reCaptcha form element.

## How to create Google reCaptcha profile

To create custom keys, sign in with a Google account to [https://www.google.com/u/0/recaptcha/admin/create][4].

1. Enter a site label
2. Select "reCAPTCHA v2"
3. And then the ""I'm not a robot" Checkbox"
4. Add the domain. Under "domains", you must insert the domain that the Customer Center (customer.fcgi) is running on, or a parent domain of that sub domain.

![imagerlc6j.png][4]

After you press Submit, your Site key and Secret key will be shown:

![imagehn8rh.png][6]

<!-- Referenced links -->
[1]: https://community.superoffice.com/contentassets/47fc398b6a304fe2813c451e7d72f6b3/imagehkoheq.png
[2]: https://www.google.com/recaptcha/admin
[3]: https://community.superoffice.com/contentassets/47fc398b6a304fe2813c451e7d72f6b3/imagehekct.png
[4]: https://www.google.com/u/0/recaptcha/admin/create "https://www.google.com/u/0/recaptcha/admin/create
[5]: https://community.superoffice.com/contentassets/47fc398b6a304fe2813c451e7d72f6b3/imagerlc6j.png
[6]: https://community.superoffice.com/contentassets/47fc398b6a304fe2813c451e7d72f6b3/imagehn8rh.png