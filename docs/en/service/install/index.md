---
title: Set-up guide
uid: install_service
description: "Guide to installing SuperOffice Service and what to do before you start."
author: Martin Pavlas
date: 12.17.2021
keywords: install, Service, ejTermsetup.exe, CustomerService.exe, SymmetricKey, SymmetricSecret
topic: howto
envir: onsite
version: 8.1
# client:
---

# Install Service

From SuperOffice 8 you also need to install Service, which is used by mailings inside both Sales & Marketing and Service.

A typical first-time installation of SuperOffice Customer Service on Windows server using an IIS web server and Microsoft SQL server. There is no client install necessary outside of a supported web client like Internet Explorer, as this is a web-based application.

## Prerequisites

We assume you have already run the general SuperOffice CRM server setup to create a database primed with necessary startup data in the language of your choice.

You need to have a working SuperOffice web services installation before you proceed with the installation of Service as *ejTermsetup.exe* requires it. Both Service and SuperOffice web services must be of the same version and run on the same domain from our SuperOffice 8.1.

## Run the installer

The installer will copy the necessary files to the Service program folder.

1. Run **SuperOffice.CustomerService.exe**.

2. When asked, select a destination folder for the installation of SuperOffice Service.

3. **Choose your hostname**. The hostname should be the registered DNS name you will be using to access both CRM web and Customer Service request management interface in your web browser.

4. You also have the option of installing and overwriting the customer web templates, or leaving your own customized one in place (if you have done customizations). If you choose to install/overwrite the templates, the installer will attempt to make a backup copy. For new installations, always leave this field checked.

5. Let the installer create an IIS site based on the hostname you entered. If the IIS website is already available on the web server then you need to uncheck the **Create IIS website**.

## Configure startup data

You need to configure some startup data that is specific to your installation – among else you need to specify the mail server to use, default from address, the company name, the ODBC database user, NetServer system users, and a few other things.

1. Start cmd.exe as an administrator from the start menu and navigate to your installation directory, and then to the sub-directory */bin* under that.
2. Run the application **ejtermsetup.exe**, and you will be prompted for the necessary settings (see below).
3. When ejtermsetup.exe is done, it will tell you that your installation is ready to run and the address where it should be available in a web browser. You can log in with the administrator user you entered earlier, and start configuring the system.

### Settings

**Choose system language:**

Customer Service will use this language to prime the database with different things that are not multi-language (for example the default system templates, priorities, and so on). You will not be able to change this later.

**Hostname:**

This should be the hostname that the application will be accessed on. Normally this is the same as the DNS address you entered when installing Customer Service.

> [!NOTE]
> This is where you may add hostname/applicationname if you have followed the steps for [manual installation][2].

**What is your name:**

Enter your name here. This is only used for information about who has installed the application.

**What database system will you use:**

Choose the database type that your database is running on.

**Username:**

This is the same username as you used in the ODBC setup.

**Password:**

This is the same password that you used in the ODBC setup.

**DSN:**

The name of the ODBC/DSN source.

**NetServer endpoint:**

Enter the URL for the NetServer installed for this Service installation.

**SuperOffice CRM administrator user:**

Here you must enter a user that has NetServer administrator rights. This user will be used to create a NetServer system user, which will be used by the Service application. If you have just run the server setup, you configured a first user there, and you should use that one.

**Password for this user:**

The password for this CRM administrator user. After pressing "enter" you may have to wait.

**Basepath:**

This is where the application is installed. Normally there should be no reason to use anything but the default value, as this is picked up from the installer.

**Login name of existing CRM user:**

If you have an upgraded pre-seven CRM database, you must connect the first Customer Service user to an existing CRM user. Enter his/her username here.

**Email for the first user/administrator email:**

If the first user does not have an email address, you must enter it here.

**Default email:**

This is the default email address, which will be used when sending emails. This should be an email address of a mailbox that is intended to be imported into Customer Service.

**SMTP hostname:**

The address of your SMTP address, which will be used to send emails
**
SMTP port:** The port number used by your SMTP server. This is normally 25.

**Cgi-bin path:**

The path to the *cgi-bin* folder on the web server when accessed using HTTP. If you let the installer set up the IIS site, you can use the default value.

**HTTP path:**

The full HTTP path to your server, except the cgi-bin part. If you let the installer set up the IIS site and you entered the same under "hostname", you can use the default value.

**Available on the Internet:**

Enable this option if your Service Server installation is online on the Internet. This will unlock some functionality in the Service Server that relies on an Internet connection.

**Do you want to start the ejScheduler service:**

If you start the service, the application will begin to import and send emails as soon as you configure it. The service is also used for all background processes, like escalating requests, sending alerts, and so forth. If you answer "no" here, the service will still be installed and enabled, but not started. That means it will start when you boot the system if you do not disable it. You can go to service management to start the service when you are ready.

### From 8.4

From version **8.4 R04**, Service needs to know NetServer's symmetric keys, which are used to encrypt traffic from NetServer to Service. This is used to enable NetServer to call Service.

When prompted:

1. Enter the `SymmetricKey` value without quotes.
2. Enter the `SymmetricSecret` value without quotes.

You will find both values in the NetServer's *web.config*, in the [Security - Cryptography section][1].

For installations where you run upgrade.exe (or ejTermsetup.exe for new installations), the program asks for the keys if they do not exist. It will then test whether the keys are correct.

When running upgrade.exe interactively, upgrade.exe must update its config file with these values. If you do not run upgrade.exe, then the values ​​must be manually added to the config file.

### From 8.5

In version **8.5 R06**, we have rewritten the CRMScript triggers in Sales to use the same communication system as the Service entities, so that we standardize on one way of doing API calls from Sales to Service. Previously, the connections originate from the Web client, now they originate from NetServer.

As a consequence, you must verify that this communication system is working when upgrading. Otherwise, CRMScript triggers from Sales will stop working. Specifically, this means:

* Make sure the authentication keys are present and equal, in all config files (web.config(s) and config).
* Make sure your network topology allows HTTP(s) communication from the NetServer installation to the Service installation.

> [!CAUTION]
> If you use encrypted *web.config* you can't read the Symmetric key values directly. You need to open the SuperOffice Web Product configuration tool, go to the Security section, and copy the keys from there.

![image.png -screenshot][img1].

## Start the scheduler

The ejtermsetup.exe application would have asked you if you wanted to start the ejScheduler service that is responsible for periodically running the console applications ejournalcron.exe and importmail.exe.

These applications in turn will perform tasks like importing email, sending email, activating postponed tickets, and other tasks. If you did not let the ejtermsetup.exe start the scheduler for you, you should do it manually when you are ready:

1. Open the **Control panel**
2. Choose **Administrative tools**
3. Click **Services**
4. Click the appropriate **ejSchedule \<sitename>** for your site.
5. Select **Start Service**
6. To start the service at boot, right-click **ejSchedule**, select **Properties** and make sure **Startup type** is set to **Automatic**.
7. Click **Start** to start the service

You are now ready to log in and use Service by opening your client browser and going to *[Hostname]/scripts/ticket.fcgi*

***

[Previous][15] | [Next][14] | [Back to guide][13]

<!-- Referenced links -->
[1]: ../../api/config/security.md
[2]: manual-steps.md
[13]: ../../onsite/install/guide.md
[14]: ../../onsite/install/web-client/index.md
[15]: ../../onsite/install/server/index.md

<!-- Referenced images -->
[img1]: media/image.png
