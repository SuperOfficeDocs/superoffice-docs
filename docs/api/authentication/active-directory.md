---
title: netserver-authentication-ad
description: Active Directory
so.date: 05.08.2018
keywords: web.config
so.topic: concept
---

# Active Directory

![AD screen][img1]

![Auth types][img2]

The user list is already filtered against current users. If you see someone in the list, it means that the AD user is not currently bound to a SuperOffice user.

The gray ones? They don’t have a valid first name / last name in AD, so we can’t populate our person from them. Talk to your admin! – Or create a new user, using password authentication (that means **you** fill in the **Person** dialog yourself). Then click the [...] to change the authentication to the AD user you need (who is not going to be grayed out in this mode).

## Maintaining links

The link to an AD identity is based on the SID, not the name, thereby unaffected when an AD user name changes – everything still works.

A SuperOffice user name can be renamed, and we’ll try to rename so_arc for you. Do this if you need to, not for fun.

In most cases, SuperOffice name equal to AD name is the way to go. But sometimes that does not fit.

The little [...] button can be used to change the authentication method. You can link up an existing user to AD, and vice versa. This does not change anything about the associate, only the authentication method.

Columns in the user list can be set to show authentication type.

Changing the authentication method is like changing your socks – it may get you into your Club or not, but it doesn’t change who you are inside of SuperOffice. Remember that a SuperOffice identity is an associate, and those are not affected by authentication changes. Only how you convince the system you are that associate changes. So you can play with this safely, as much as you want.

## Integrated login

### Integrated logon - Windows

Remember that we now try to log in, using the Windows Identity, before the login dialog is shown (it takes a few seconds more to show up). If you are set up with AD authentication, then you will never see the login dialog.

To log on as someone else, right-click the program shortcut and choose the Run as... option. You then need to know the password of that user. This is used to be a property of the ODBC connection. That is no longer the case and it is important to turn that option off.

* Otherwise the Windows user needs to be a database user, and we’re no longer in the database-user business.

Integrated login is a catch-all: since it is integrated, it happens automatically. That means you can’t override it once it has started – you have to override it before you start.

"Integrated login" in ODBC is a completely different matter. In effect, you are telling the ODBC driver, "ignore whatever username and password are present, and log on as my Windows Identity". That is NOT the same as integrated logon to SuperOffice!  **Turn off** integrated logon in ODBC, unless you really want to have a policy where every AD user is mapped to a database user, and want to maintain things that way.

### Integrated login - Web

The logic is the same as Windows: first, we try to log on using what we know. If that doesn’t work the login dialog is shown.

You must **turn off anonymous access** and **turn on ASP.NET impersonation** on IIS.

* The first forces the browser to authenticate using Windows identity. Internet Explorer may transfer your current identity automatically, Firefox will show a domain login box. This establishes your Windows identity in IIS, for this request.

* The second option transfers that identity from IIS into the actual SuperOffice Web client application, so it can do its usual authentication.

* Remote setups have an additional hop from the web client to the NetServer back-end.

Chain-of-trust yet again – you present evidence to the Browser, which sends it to IIS. IIS resolves it and knows who you are. Then that is transported to NetServer, which trusts its environment. And hey presto, we know who you are.

Essentially, if your user is a domain user...

* ... and your web server is in the domain
* ... and you have set up IIS authentication
* ... and your client computer is in the domain
* ... and you’re running a compatible browser (IE)
* ... and your SuperOffice web site is in the Intranet Zone
* ... and it’s not a Remote installation

...then you will log on directly and never see a login dialog!

Otherwise, type in domain username and password into the login dialog shown.

The long list of if’s is not dictated by us, but mostly by Microsoft and other browser vendors.

## AD username and password

The login dialog accepts Active Directory domain username and password.

* If a SuperOffice login dialog is shown, type in your Windows credentials
  * NetServer asks Windows if it recognizes the credentials, and if recognized the resulting Windows Identity is used as input for authentication.

This is a ”safety valve” for users that are AD authenticated, but for any reason can’t succeed the integrated login phase.

The idea is that _**if**_ users see a login dialog, then their "usual" user should work, whether that is a SuperOffice or AD user; which is why NetServer will accept both types of credentials in the username+password strings.

The SuperOffice user is checked first since that happens with a known speed (database lookup). AD user lookup **can** take a long time if your server has a difficult relationship with the domain controller (think DMZ+firewalls+complicated setups).

## Identity distribution

At the most basic level, what we want to achieve is to carry a set of credentials (evidence of your identity) from the client into our application.

This involves the client OS, browser, IIS on the web server, our application (incl login page), IIS on the application server, and finally our application on the application server.

![Identity transference][img3]

Transfer-of-identity is complicated and dependent on all components. For instance, IE will automatically send your domain credentials to the Intranet Zone only, while Firefox won’t at all.

The connection between a Web and an App server in a remote configuration introduces a new level of complexity and inter-dependence.

### Services vs. the Web application

Using SuperOffice, you interact through a Browser that provides authentication and session handling capabilities. However, there are also programs that interact directly with Services

* TrayApp, aka SuperOffice Web Extensions
* MailLink for Web
* Pocket Server
* Customer Service

These do not involve a browser and need to access the Web Services and get work done too.

## Single server configuration

![Single server][img4]

IIS Authentication can be used together with Services, but not in a Remote setup: the identity cannot be transferred that many times.  This is an MS design parameter, not changeable.

## Two server (remote) configuration

![Two servers]()

The AD User’s identity transfers from the Browser to the Web Server, but the web server cannot transfer this identity on to the app server – the web server cannot prove to the app server that it knows the user’s identity. The web server can only prove the that web-browser knows the user’s identity.

<!-- Referenced images -->
[img1]: media/image002.jpg
[img2]: media/image003.jpg
[img3]: media/image004.gif
[img4]: media/image005.gif
[img5]: media/image006.gif
