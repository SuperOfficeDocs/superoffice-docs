---
title: Application settings
uid: dp-app-settings
description: Reference of application settings in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 06.08.2022
keywords: apps, Developer Portal
so.topic: reference
so.version:
so.envir: cloud
so.client:
---

# Application settings

These settings may only be changed by SuperOffice app managers. Contact us via chat or support if you want to request any changes.

![Application settings in the SuperOffice Developer Portal -screenshot][img1]

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| Application name | The human-readable name of the application. | [Update app info][9] | [Naming requirements][8] |
| SEO-friendly name | For search engines. | [Update partner profile][2], [Update the product page][9] | [Improve SEO][10] |
| Authorize | The description shown in the concent dialog when the admin is prompted to approve the application. | [Get consent][5] | [About consent][15] |
| Technical contact | The contact person for this app. | [Update contact person][1] | |
| Error reporting emails | Semicolon-separated list of email addresses that should receive error emails. If empty, technical contact will get these. | [Set state change URL][11], [Get error emails][11] | [About tenant status][17] |
| Hidden from Our Apps | If checked, this app will not show up when customers go to the App Store and see their installed apps. | | |
| Is custom app | Whether this is a one-off customization or if we should provide the option to publish to the app store as a standard app. | [Create app][13] | [About custom apps][6] |
| Is beta | Whether the app is currently in beta in the App Store. | [Publish app][14] | [About the beta period][7] |

## App Store information

The [steps to update all App Store information][9] are the same.

### Description tab

Setting | Description | Read more |
|---|---|---|
| Header | A one-liner to introduce the App and make visitors curious. The bold text below your company name on the App Store entry. | [Marketing requirements][12] |
| About this app| In more detail (max 200 words), explain what your application does and what the customers get when they use it. Include the key benefit statements and customer testimonials if you have any. | [Marketing requirements][12] |
| Key features | What does the app do? List the key features in bullet style. (max 10 features) | [Marketing requirements][12] |
| What's new | Information to help boost visibility when you release a new version of your application. | |

### Search engine optimization tab

Setting | Description | Read more |
|---|---|---|
| Meta description | A meta description is a brief summary of a web page and should give the user an idea of the content. It is placed in the HTML tag and displayed in search engine results pages and can impact the click-through rate (CTR). | [Improve SEO][10] |
| Meta keywords | Meta keywords range from single words to complex phrases and are used to inform website content in a more focused way than the description. | [Improve SEO][10] |

### Prices and terms

Setting | Description | Read more |
|---|---|---|
| Is free | Marks the app as 100 percent free and hides the price field. | [Price info][16] |
| Price | Lowest starting price in EUR (amount). | [Price info][16] |
| Pricing information | Describe your pricing. Clarify whether the price is by site or user, with or without VAT. | [Price info][16] |
| Terms and conditions | List rules related to using the application, such as availability and your liability. | [Price info][16] |

### How to install

Setting | Description | Read more |
|---|---|---|
| SuperOffice CRM plan | Which SuperOffice user plans are supported. | [How to install tab][18] |
| Getting started | The steps needed to install and use the application. | [How to install tab][18] |
| Additional requirements | All system requirements. | [How to install tab][18] |

### Links

| Type | Description | Read more |
|---|---|---|
| Green button text | The label of the green button on your App Store entry. | [Links tab][19] |
| Links | Any additional links. Each link has a type (see list below), URL, and text. | [Links tab][19] |
| Categories | Apps are divided into categories in the App Store to help visitors navigate. See list below. | [Marketing requirements][12] |
| Languages | The languages the app is available in. Danish, Dutch, English, Finnish, French, German, Italian, Norwegian, Romansh, Swedish | [Marketing requirements][12] |
| Markets | In which markets should the app be available? Benelux, Denmark, Finland, Germany, Norway,Sweden, Switzerland, United Kingdom | [Marketing requirements][12] |

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

<!-- Coming soon?
* Customer service
  * Agent Productivity
  * Field service
  * Surveys
  * Telephony
* Marketing
  * Campaign management
  * Event management
  * Marketing Automation
  * Mass Emails
  * Websites
* IT & Administration
  * Admin & Developer Tools
  * Data Cleansing
  * Integration
  * IT Management
* Human Resources
* Finance
  * Accounting
  * Payment Processing
  * Time & Expense
* Collaboration
  * Chat & Web Conferencing
  * Chatter
  * Document Management
  * Project Management
* Analytics -->

## See also

* [Application configuration][2]
* [Partner settings][3]
* [User settings][4]

<!-- Referenced links -->
[1]: ../howto/update-contact-person.md
[2]: app-config.md
[3]: partner-settings.md
[4]: user-settings.md
[5]: ../../apps/provisioning/get-consent.md
[6]: ../../apps/custom.md
[7]: ../../apps/publish/beta-period.md
[8]: ../../apps/requirements/marketing.md#application-name
[9]: ../app-store/update-app-page.md#update-app-store-information
[10]: ../app-store/seo.md
[11]: ../howto/notifications.md#tenant-status
[12]: ../../apps/requirements/marketing.md#application-description
[13]: ../create-app/index.md
[14]: ../../apps/publish/index.md
[15]: ../../apps/provisioning/consent.md
[16]: ../app-store/prices-and-terms.md
[17]: ../../apps/tenant-status/index.md
[18]: ../app-store/user-guide.md#how-to-install
[19]: ../app-store/user-guide.md#links

<!-- Referenced images -->
[img1]: ../media/app-overview.png
