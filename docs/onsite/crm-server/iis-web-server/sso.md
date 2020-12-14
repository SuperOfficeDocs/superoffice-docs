---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: configure_sso_in_iis_onsite        # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Configure single sign-on in iis onsite # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
so.client: web                # online, web, win, pocket, or mobile
---

# Single sign-on

SuperOffice CRM Web supports single sign-on using Windows Authentication.

## Checklist for CRM 8

* Web server is enlisted in Active Directory
* The hostname used for accessing is registered in DNS (not hosts file)
* Remote NetServer (where Web and NetServer are on different servers) is not supported due to Kerberos double-hop issues
* Users are configured with Active Directory authentication in SuperOffice
* The IIS site where SuperOffice is located is configured to use Windows Authentication
* Customer Service & Pocket CRM must use a separate NetServer site where Windows Authentication is turned off. It can point to the same physical path as NetServer for Sales but with its own IIS Application with Windows auth turned off.
* You should now be able to test with your browser to see if SSO works for users.
* To enable SSO with Mail Link and TrayApp, you will need to change the protocolMapping to use WindowsAuth in the *web.config* file.

You will need to add the site to trusted sites in IE if you are using IE and if IE thinks that the site is not local intranet. Other browsers don't need configuration to give an SSO experience.

Testing SSO on the same server as SuperOffice usually fails. Accessing the site from internet will prompt the user for credentials since the KDC is unavailable.

## Single sign-on with Windows authentication

The following process is carried out when a windows user is automatically signed in to SuperOffice Web:

1. Authenticate the user with IIS
2. Pass the IIS Authentication on to CRM Web
3. Authenticate the Windows user with CRM Web

## Authenticate the user with IIS

### Windows 2016 Server

1. Open Server Manager
2. Make sure Windows Authentication is checked.

![imagegb896.png][img1]

3. Open Internet Information Server (IIS) Manager.
4. Select the SuperOffice CRM Web site again and double-click on the **Authentication** Feature:

![imagef1ptl.png][img2]

5. Make sure that only Windows Authentication is enabled. We do not recommend other authentication methods such as Basic and Digest.

## SuperOffice WebTools

To enable Single sign-on for Web Tools (MailLink and Web Extensions) the bindingConfiguration must be changed to WindowsAuth (and WindowsAuths for HTTPS) in *Web.config*.

![x][img3]

## SuperOffice Service

**SuperOffice 8.4 R04** and newer includes support for NetServer communicating with Service (for instance through the ticket or crmscript agent).

### Impersonation user

To support this functionality for single sign-on scenarios, we have to use an impersonation user for the communication between NetServer and Service.

The impersonation user must exist in Active Directory but does not need to be a SuperOffice user.

Steps to configure in the web.config file:

1. Configure the installation as SSO

2. Make sure the [symmetricKey and symmetricSecret values are the same between SuperOffice Web and Customer Service config files][1]

3. Add a `CustomerService` section in the `SuperOffice` section group:

```xml
<sectionGroup name="SuperOffice">
  <section name="CustomerService" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
...
```

4. Add this section under SuperOffice:

```xml
<CustomerService>
  <add key="ImpersonateCsUser" value="True" />
  <add key="CsUserName" value="" />
  <add key="CsPassword" value="" />
  <add key="CsDomain" value="" />
</CustomerService>
```

5. Update the values to be correct for the installation:

* ImpersonateCsUser must be set to True
* CsUserName is the AD user to impersonate
* CsPassword is the corresponding password
* CsDomain is the AD domain where the user is registered

## Other configuration options

### Single sign-on for Web Tools alone

1. Open IIS Manager.
2. Select the Services folder in the CRM Web site.
3. Enable Windows Authentication in Authentication. Disable other authentication methods.
4. Apply the configuration changes related to bindings and WindowsAuth.

<!-- Referenced links -->
[1]: ../../service/set-up-guide.md

<!-- Referenced images -->
[img1]: ../media/imagegb896.png
[img2]: ../media/imagef1ptl.png
[img3]: ../media/75sr1trayappwindowsauth.jpg