---
uid: help-en-form-recaptcha
title: Google reCAPTCHA in Forms
description: Google reCAPTCHA in Forms. Note - this page is NOT translated.
keywords: reCAPTCHA, reCAPTCHA profile, form, Google reCAPTCHA, I'm not a robot, site key, secret key
author: Bergfrid Dias
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
redirect_from:
  - /de/marketing/forms/learn/recaptcha
  - /da/marketing/forms/learn/recaptcha
  - /no/marketing/forms/learn/recaptcha
  - /sv/marketing/forms/learn/recaptcha
  - /nl/marketing/forms/learn/recaptcha
  - /en/marketing/forms/recaptcha
language: en
---

# Google reCAPTCHA in Forms

## Add reCAPTCHA element

1. Create or open a form.
1. Select **Fields**.
1. Click **Add element** and choose **Form elements** > **Google reCAPTCHA**.

    ![imagehkoheq.png -screenshot][img1]

When the element is added you can decide how you will use the Site and Secret keys.

> [!NOTE]
> It is only possible to add 1 reCAPTCHA per form.

## SuperOffice Online

SuperOffice Online gives you default keys for reCAPTCHA, which protects your form from robots. You do not need to enter anything for Site key and Secret key unless you want to create your own reCAPTCHA profile and see statistics. To do that, follow the steps below and enter your SiteKey and SecretKey. [Statistics][1] show you how many requests passed or failed, the average score, the sessions completed, and the average response time.

![imagehekct.png -screenshot][img2]

## SuperOffice Onsite

For SuperOffice Onsite you need to make your reCAPTCHA profile and get your Site and Secret key.

> [!TIP]
> If you do not want to enter the keys every time to the reCAPTCHA form element, you can specify them in the [GoogleRecaptcha section][3] of the *web.config* file for the NetServer used by Service,

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
[3]: ../../../../en/api/config/googlerecaptcha.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/add-element-dialog.png
[img2]: ../../../../media/loc/en/marketing/recaptcha-form-element.png
[img3]: ../../../../media/loc/en/marketing/imagerlc6j.png
[img4]: ../../../../media/loc/en/marketing/imagehn8rh.png
