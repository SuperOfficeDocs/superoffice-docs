---
title: Single sign-on
uid: configure_sso_in_iis_onsite
description: Configure single sign-on in IIS onsite
author: Martin Pavlas
date: 04.20.2023
keywords: authentication, SSO, single sign-on, log in, IIS, Windows Authentication
content_type: howto
deployment: onsite
platform: web
---

# Single sign-on

SuperOffice CRM Web supports single sign-on (SSO) using Windows Authentication.

## Checklist for CRM 8

* Web server is enlisted in Active Directory
* The hostname used for accessing is registered in DNS (not hosts file)
* Remote NetServer (where Web and NetServer are on different servers) is not supported due to Kerberos double-hop issues
* Users are configured with Active Directory authentication in SuperOffice
* The IIS site where SuperOffice is located is configured to use Windows Authentication
* Customer Service & Pocket CRM must use a separate NetServer site where Windows Authentication is turned off. It can point to the same physical path as NetServer for Sales but with its own IIS Application with Windows auth turned off.
* You should now be able to test with your browser to see if SSO works for users.
* To enable SSO with Mail Link and TrayApp, you will need to change the protocolMapping to use WindowsAuth in the *web.config* file.

You will need to add the site to trusted sites in IE if you are using IE and if IE thinks that the site is not on a local intranet. Other browsers don't need configuration to give an SSO experience.

Testing SSO on the same server as SuperOffice usually fails. Accessing the site from the internet will prompt the user for credentials since the KDC is unavailable.

SSO will not work when using [the recommended installation scenario][4], but the user may still authenticate with their AD username and password.

> [!NOTE]
> A change in SuperOffice version 10.1.5 prevented logging in to SuperOffice with AD credentials without SSO. This was corrected in version 10.1.6.
>
> Using Remote web services for Web (where Web and NetServer are on different servers) is not supported due to [Kerberos double-hop issues][3].

## Single sign-on with Windows authentication

The following process is carried out when a windows user is automatically signed in to SuperOffice Web:

1. Authenticate the user with IIS
2. Pass the IIS Authentication on to CRM Web
3. Authenticate the Windows user with CRM Web

## Authenticate the user with IIS

### Windows 2016 Server

1. Open Server Manager
2. Make sure Windows Authentication is checked.

    ![imagegb896.png -screenshot][img1]

3. Open Internet Information Server (IIS) Manager.
4. Select the SuperOffice CRM Web site again and double-click on the **Authentication** Feature:

    ![imagef1ptl.png -screenshot][img2]

5. Make sure that only Windows Authentication is enabled. We do not recommend other authentication methods such as Basic and Digest.

## SuperOffice WebTools

To enable Single sign-on for Web Tools (MailLink and Web Extensions) the bindingConfiguration must be changed to WindowsAuth (and WindowsAuths for HTTPS) in *Web.config*.

![x -screenshot][img3]

## SuperOffice Service

**SuperOffice 8.4 R04** and newer includes support for NetServer communicating with Service (for instance through the ticket or CRMScript agent).

### Impersonation user

To support this functionality for single sign-on scenarios, we have to use an impersonation user for the communication between NetServer and Service.

The impersonation user must exist in Active Directory but does not need to be a SuperOffice user.

Steps to configure in the *web.config* file:

1. Configure the installation as SSO.

2. Make sure the [SymmetricKey and SymmetricSecret values][1] are the same between SuperOffice Web and Customer Service config files.

3. Add a [CustomerService section][2] in the `SuperOffice` section group:

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

    * `ImpersonateCsUser` must be set to True.
    * `CsUserName` is the AD user to impersonate.
    * `CsPassword` is the corresponding password.
    * `CsDomain` is the AD domain where the user is registered.

## Other configuration options

### Single sign-on for WebTools alone

1. Open IIS Manager.
2. Select the Services folder for the CRM Web site.
3. Enable Windows Authentication in Authentication. Disable other authentication methods.
4. Apply the configuration changes related to bindings and WindowsAuth.

<!-- Referenced links -->
[1]: ../../../onsite/install/service/index.md
[2]: ../../../api/config/customerservice.md
[3]: https://blogs.technet.microsoft.com/askds/2008/06/13/understanding-kerberos-double-hop/
[4]: ../../../onsite/security/deployment-scenarios.md

<!-- Referenced images -->
[img1]: media/imagegb896.png
[img2]: media/imagef1ptl.png
[img3]: media/75sr1trayappwindowsauth.jpg
