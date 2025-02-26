---
uid: dp-app-settings
title: Application settings
description: Reference of application settings in the SuperOffice Developer Portal.
keywords: apps, Developer Portal
author: Bergfrid Dias
date: 02.26.2025
version: 2.0
version_devportal: 2.0
topic: reference
envir: cloud
---

# Application settings

![Application settings in the SuperOffice Developer Portal -screenshot][img1]

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| Application name | The human-readable name of the application. | [Update app info][3] | [Naming requirements][8] |
| SEO-friendly name | For search engines. | [Update partner profile][2], [Update the product page][3] | [Improve SEO][1] |
| Technical contact | The contact person for this app. | [Update contact person][21], [Review and update all your technical contacts][22] | |
| Error reporting emails | Semicolon-separated list of email addresses that should receive error emails. If empty, technical contact will get these. | [Set state change URL][26], [Get error emails][28] | [About tenant status][27] |
| Uninstall reporting emails | Where SuperOffice sends requests to uninstall an app. If left blank, these emails go to the *partner's* Uninstall reporting emails list. | [Update app info][3], [Get error emails][28] | |
| Hidden from Our Apps | If checked, this app will not show up when customers go to the App Store and see their installed apps. | | |
| Is custom app | Whether this is a one-off customization or if we should provide the option to publish to the app store as a standard app. | [Create app][13] | [About custom apps][16] |
| Is beta | Whether the app is currently in beta in the App Store. | [Publish app][10] | [About the beta period][9] |

As a partner, you may change the technical contact and the list of error reporting emails. Other settings may only be changed by SuperOffice app managers. Contact us via chat or support if you want to request any changes.

## App Store information

The [steps to update all App Store information][3] are the same.

### <a id="links"></a>Details

| Setting | Description | Read more |
|---|---|---|
| Green button text | The label of the green button on your App Store entry. | [Details tab][5] |
| Links | Any additional links. Each link has a type (see list below), URL, and text. | [Details tab][5] |
| Categories | Apps are divided into categories in the App Store to help visitors navigate. See list below. | [Marketing requirements][7] |
| Languages | The languages the app is available in. Danish, Dutch, English, Finnish, French, German, Italian, Norwegian, Romansh, Swedish | [Marketing requirements][7] |
| Markets | In which markets should the app be available? Benelux, Denmark, Finland, Germany, Norway,Sweden, Switzerland, United Kingdom | [Marketing requirements][7] |

**Link types:**

* Install: Where the App Store links to when the user clicks **Buy**.
* Configure: Where the App Store links to when the user clicks **Configure**.
* Support
* Report a problem
* Disabled: Where the App Store links to when the user clicks **Uninstall**.

**Categories:**

* Email document & calendar
* Digital Signature
* Business Intelligence & reporting
* Prospecting & data quality
* Integration tools
* CTI
* Productivity
* Email marketing & SMS
* ERP
* Quotations

### Description tab

| Setting | Description | Read more |
|---|---|---|
| Header | A one-liner to introduce the App and make visitors curious. The bold text below your company name on the App Store entry. | [Marketing requirements][7] |
| About this app| In more detail (max 200 words), explain what your application does and what the customers get when they use it. Include the key benefit statements and customer testimonials if you have any. | [Marketing requirements][7] |
| Key features | What does the app do? List the key features in bullet style. (max 10 features) | [Marketing requirements][7] |
| What's new | Information to help boost visibility when you release a new version of your application. | |

### Prices and terms

| Setting | Description | Read more |
|---|---|---|
| Is free | Marks the app as 100 percent free and hides the price field. | [Price info][6] |
| Price | Lowest starting price in EUR (amount). | [Price info][6] |
| Pricing information | Describe your pricing. Clarify whether the price is by site or user, with or without VAT. | [Price info][6] |
| Terms and conditions | List rules related to using the application, such as availability and your liability. | [Price info][6] |

### How to install

| Setting | Description | Read more |
|---|---|---|
| SuperOffice CRM plan | Which SuperOffice user plans are supported. | [How to install tab][4] |
| Getting started | The steps needed to install and use the application. | [How to install tab][4] |
| Additional requirements | All system requirements. | [How to install tab][4] |

### SEO tab

| Setting | Description | Read more |
|---|---|---|
| Meta description | A meta description is a brief summary of a web page and should give the user an idea of the content. It is placed in the HTML tag and displayed in search engine results pages and can impact the click-through rate (CTR). | [Improve SEO][1] |
| Meta keywords | Meta keywords range from single words to complex phrases and are used to inform website content in a more focused way than the description. | [Improve SEO][1] |

## See also

* [Application configuration][12]
* [Partner settings][23]
* [User settings][24]

<!-- Referenced links -->
[1]: seo.md
[2]: update-partner-profile.md
[3]: update-app-page.md
[4]: user-guide.md#how-to-install
[5]: user-guide.md#links
[6]: prices-and-terms.md

[7]: ../requirements/marketing.md#application-description
[8]: ../requirements/marketing.md#application-name
[9]: ../publish.md#beta
[10]: ../publish.md

[12]: ../../create-app/config/app-config.md
[13]: ../../create-app/index.md
[16]: ../../custom-app/index.md

[21]: ../../faq/update-contact-person.md
[22]: ../../partner/manage-technical-contacts.md
[23]: ../../partner/partner-settings.md
[24]: ../../partner/user-settings.md
[26]: ../../best-practices/tenant-status/get-notifications.md
[27]: ../../best-practices/tenant-status/index.md
[28]: ../../best-practices/error-emails.md

<!-- Referenced images -->
[img1]: ../../media/app-overview.png
