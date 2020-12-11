---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: service_setup_guide # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Service set-up guide # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: guide                # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Service setup guide

From SuperOffice 8 you also need to install Service which is used by mailings inside both Sales & Marketing and Service.

A typical first-time installation of SuperOffice Customer Service on Windows 2012 server using IIS web server and Microsoft SQL server 2014. There is no client install necessary outside of a supported web client like Internet Explorer, as this is a web-based application.

## Prepare

### Domain name

A domain name like **socrm.myorganization.com** must be created and registered in the DNS for SuperOffice Customer Service and CRM Web to be able to run.

Default installation of Service does not allow you to install it in a sub application. With SuperOffice 8.1 both Sale and Service must be installed on the same root domain. It will be easier to create Application Routing Routing rules (ARR) if you do the manual installation and place Service in a sub application.

### Email server

SuperOffice Customer Service requires access to an email server to work, using either POP3 or IMAP to retrieve emails, and SMTP to send emails. MAPI can also be used (Exchange), but requires additional licenses. Any email account on Exchange servers can be configured to use POP3/IMAP instead of the standard MAPI protocol.

It is important that the email server allows “relaying”, allowing SuperOffice Service to send emails “outside” the domain. Please be sure that any firewalls must be configured to allow this type of communication.

### Network location

Where on the network should SuperOffice Service be located?

For security reasons, the SuperOffice Service solution, like all other Internet-connected servers, should be placed in a DMZ (de-militarized zone) or Secure Server Net. A DMZ is a zone in the firewall which is protected against breaches from the outside and inside of the firewall. As long as the solution is on the same LAN as the email server, no configurations in the Firewall is necessary. If there are firewalls between SuperOffice Service and the email server, the firewall must be configured as described below.

**NetServer:**

SuperOffice Service supports only HTTP connection to NetServer. If you are running all servers only on HTTPS, you need to set up an extra NetServer available on HTTP to be used by Service.

### Module: SuperOffice Customer Service Customer Centre

To provide the SuperOffice Customer Center on the internet, the server must be reached by external users by HTTP or HTTPS. The firewall must be configured to handle these requests from the “outside” to the SuperOffice Customer Service server.

#### Configuration of firewalls

Applicable if the email server is on a separate LAN as SuperOffice Customer Service.

* The ports for retrieving email by the protocols POP3/IMAP must be opened

* The ports for sending emails by the protocol SMTP must be opened

* If the ports cannot be opened for security reasons, the alternative is to install a new email server on the same LAN or server as SuperOffice Customer Service, and forward incoming emails from the original email server to this one. All email accounts that are supposed to be handled by SuperOffice Customer Service must be created, and in the setup of email accounts in SuperOffice Service must be set up to add the original.

### Setup ODBC

Even though we now have a common database, there are still Service entities that NetServer is not aware of. Thus, we still need an ODBC data source to connect to the database.

In MSSQL, create a user, which has **dbowner** access (and not sysadmin access) to the database. Make sure that the **CRM7** schema or the database schema your database is set up with, is set for this user on the database.

## Install Service

### Prerequisites

We assume you have already run the general SuperOffice CRM server setup to create a database primed with necessary startup data in the language of your choice.

You need to have a working SuperOffice web services installation before you proceed with the installation of Service as *ejTermsetup.exe* requires it. Both Service and SuperOffice web services must be of the same version and run on the same domain from our [release 8.1][1].

### Run the installer

The installer will copy the necessary files to the Service program folder.

1. Run the SuperOffice.CustomerService.exe

2. When asked, select a destination folder for the installation of SuperOffice Service.

3. **Choose your hostname**. The hostname should be the registered DNS name you will be using to access both CRM web and Customer Service request management interface in your web browser.

4. You also have the option of installing and overwriting the customer web templates, or leave your own customized one in place (if you have done customizations). If you choose to install/overwrite the templates, the installer will attempt to make a backup copy. For new installations, always leave this field checked.

5. Let the installer  create an IIS site based on the hostname you entered. If the IIS website it already available on the webserver then you need to uncheck the **Create IIS web site**.

### Configure startup data

You need to configure some startup data that is specific to your installation – among else you need to specify the mail server to use, default from address, the company name, the ODBC database user, NetServer system users and a few other things.

1. Start cmd.exe as an administrator from the start menu and navigate to your installation directory, and then to the subdirectoy /bin under that.
2. Run the application **ejtermsetup.exe**, and you will be prompted for the necessary settings (see below).
3. When ejtermsetup.exe is done, it will tell you that your installation is ready to run and the address where it should be available in a web browser. You can log in with the administrator user you entered earlier, and start configuring the system.

#### Settings

**Choose system language:**

Customer Service will use this language to prime the database with different things that are not multi-language (for example the default system templates, priorities and so on). You will not be able to changes this later.

**Hostname:**

This should be the hostname which application will be access on. Normally this is the same as the DNS address you entered when installing Customer Service. Note - this is where you may add hostname/applicationname if you have followed the steps for [manual installation][2].

**What is your name:**

Enter your name here. This is only used for information about who has installed the application.

**What database system will you use:**

Choose the database type which your database is running on.

**Username:**

This is the same username as you used in the ODBC setup.

**Password:**

This is the same password as you used in the ODBC setup.

**DSN:**

The name of the ODBC/DSN source.

**NetServer endpoint:**

Enter the URL for the NetServer installed for this Service installation.

**SuperOffice CRM administrator user:**

Here you must enter a user which has NetServer administrator rights. This user will be used to create a NetServer system user, which will be used by the Service application. If you have just run the server setup, you configured a first user there, and you should use that one.
  
**Password for this user:**

The password for this CRM administrator user. After pressing "enter" you may have to wait.

**Basepath:**

This is where the application is installed. Normally there should be no reason to use anything but the default value, as this is picked up from the installer.
  
**Login name of existing CRM user:**

If you have an upgraded pre-seven CRM database, you must connect the first Customer Service user to an existing CRM user. Enter his/her username here.
  
**Email for the first user/administrator email:**

If the first user does not have an email address, you must enter it here.
  
**Default email:**

This is the default email address which will be used when sending emails. This should be an email address of a mail box that is intended to be imported into Customer Service.
  
**SMTP hostname:**

The address of your SMTP address, which will be used to send emails
**  
SMTP port:** The port number used by your SMTP server. This is normally 25.
  
**Cgi-bin path:**

The path to the cgi-bin folder on the web server when accessed using HTTP. If you let the installer set up the IIS site, you can use the default value.
  
**HTTP path:**

The full HTTP path to your server, except the cgi-bin part. If you let the installer set up the IIS site and you entered the same under “hostname”, you can use the default value.

**Available on the Internet:**

Enable this option if your Service Server installation is online on the Internet. This will unlock some functionality in the Service Server that relies on an Internet connection.

**Do  you want to start the ejScheduler service:**

If you start the service, the application will begin to import and send email as soon as you configure it. The service is also used for all background processes, like escalating request, sending alerts and so forth. If you answer “no” here, the service will still be installed and enabled, but not started. That means it will start when you boot the system if you do not disable it. You can go to service management to start the service when you are ready.

#### From 8.4

From version **8.4 R04**, Service needs to know NetServer's symmetric keys which are used to encrypt traffic from NetServer to Service. This is used to enable NetServer to call Service.

When prompted:

1. Enter the SymmetricKey value without quotes found in the web.config file for NetServer.
2. Enter the SymmetricSecret value without quotes found in the web.config file for NetServer.

You will find both values in the NetServer's Web.config, in the Security - Cryptography section.

For installations where you run upgrade.exe (or ejTermsetup.exe for new installations), the program asks for the keys if they do not exist. It will then test whether the keys are correct.

When running upgrade.exe interactively, upgrade.exe must update its config file with these values. If you do not run upgrade.exe, then the values ​​must be manually added to the config file.

#### Form 8.5

In version **8.5 R06**, we have rewritten the CRMScript triggers in Sales to use the same communication system as the Service entities, so that we standardize on one way of doing API calls from Sales to Service. Previously, the connections originate from the Web client, now they originate from NetServer.

As a consequence, you must verify that this communication system is working when upgrading. Otherwise, CRMScript triggers from Sales will stop working. Specifically, this means:

* Make sure the authentication keys are present, and equal, in all config files (web.config(s) and config.
* Make sure your network topology allows HTTP(s) communication from the NetServer installation to the Service installation.

> [!CAUTION]
> If you use encrypted Web.config you can't read the Symmetric key values directly. You need to open the SuperOffice Web Product configuration tool, go to the Security section and copy the keys from there.![image.png][3].

### Start the scheduler

The ejtermsetup.exe application would have asked you if you wanted to start the ejScheduler service that is responsible for periodically running the console applications ejournalcron.exe and importmail.exe.

These applications in turn will perform tasks like importing email, sending email, activating postponed tickets, and other tasks. If you did not let the ejtermsetup.exe start the scheduler for you, you should do it manually when you are ready:

1. Open the **Control panel**
2. Choose **Administrative tools**
3. Click **Services**
4. Click the appropriate **eJournal Scheduler \<sitename>** for your site.
5. Select **Start Service**
6. To start the service at boot, right-click **eJournal Scheduler**, select **Properties** and make sure **Startup type** is set to **Automatic**.
7. Click **Start** to start the service

You are now ready to log in and use Service by opening your client browser and go to *\[Hostname\]/scripts/ticket.fcgi*

<!-- Referenced links -->
[1]: HTTPs://community.superoffice.com/en/product-releases/
[2]: https://community.superoffice.com/en/technical/documentation/install-upgrade/service/manual-steps-service/
[3]: media/image.png
