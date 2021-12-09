---
title: Google reCAPTCHA in Forms
uid: recaptcha
description: Google reCAPTCHA in Forms
author: {github-id}
keywords: reCAPTCHA, forms, Google
so.topic: concept
so.version: 8.5 R04
---

# Google reCAPTCHA in Forms

Since SuperOffice 8.5 R04 we have introduced a new feature in Forms - Google reCAPTCHA. It is possible to use it in both Onsite and Online offerings.

reCAPTCHA is found in Form - Fields - add element - Form elements:

![imagehkoheq.png -screenshot][img1]

> [!NOTE]
> It is only possible to add 1 reCAPTCHA per form.

When the element is added you can decide how you'll use the Site and Secret keys:

## SuperOffice Online

In SuperOffice Online we, by default, provide you with our default keys. If you do not want to set up your reCAPTCHA profile and do not need the statistics, you do not need to fill in anything to the Site key and Secret key. This way the reCAPTCHA element will work out-of-the-box using our predefined set of keys protecting your form from robots.

If you are interested in the reCAPTCHA statistics, you can make your reCAPTCHA profile (see below) and enter your `SiteKey` and `SecretKey`. Statistics provide information like Requests passed and failed, Average Score, Sessions completed, Average Response Time (for more info see [https://www.google.com/recaptcha/admin][1].

![imagehekct.png -screenshot][img2]

## SuperOffice Onsite

For SuperOffice Onsite you need to make your reCAPTCHA profile and get your Site and Secret key. If you do not want to enter the keys every time to the reCAPTCHA form element, you can specify them in the *web.config* file for the NetServer used by Service. Then you do not need to give the keys for each form you create.

For reCAPTCHA to work in an Onsite installation, the NetServer needs to have access to the Google verification URL (see below). This is used to verify the reCAPTCHA attempt.

The following *web.config* changes need to be done only if you want to [specify the keys in the file][3]. reCAPTCHA will work without these but you will have to add the keys to the form each time.

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

If you add the keys to *web.config*, you still will be able to overwrite them and add different ones directly to the reCAPTCHA form element.

## How to create a Google reCAPTCHA profile

To create custom keys, sign in with a Google account to [https://www.google.com/u/0/recaptcha/admin/create][2].

1. Enter a site label
2. Select "reCAPTCHA v2"
3. And then the "I'm not a robot" checkbox
4. Add the domain. Under "domains", you must insert the domain that the Customer Center (customer.fcgi) is running on or a parent domain of that sub-domain.

![imagerlc6j.png -screenshot][img3]

After you press Submit, your Site key and Secret key will be shown:

![imagehn8rh.png -screenshot][img4]

<!-- Referenced links -->
[1]: https://www.google.com/recaptcha/admin
[2]: https://www.google.com/u/0/recaptcha/admin/create
[3]: ../../../data-access/docs/netserver/config/recaptcha.md

<!-- Referenced images -->
[img1]: media/imagehkoheq.png
[img2]: media/imagehekct.png
[img3]: media/imagerlc6j.png
[img4]: media/imagehn8rh.png
