---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: files       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:                    # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# nuSoapSample solution

The minimal PHP example application comes with a set of files and directories.

In your download, the solution's directory contains the following:

## Directories

### / website root

### certificates directory

* *federatedlogin.cer*: certificate for SOD, used to verify tokens from SuperID

### helpers directory

* ClaimHelper
* ContactEntityHelper
* SessionHelper
* SystemUserHelper
* UrlHelper

### lib directory

* *soAgents* directory
  * Agent classes for each NetServer endpoint
* *JWT.php*: Base class responsible for verifying the JWT token
* *nusoap.php*: Contains Web Services Toolkit for PHP
* *SoAgent.php*: Is the base class for all agents in the soAgents directory
* *SoJWT.php*: SuperOffice wrapper around the base class in *JWT.php*
* *SoSAML.php*: Class responsible for verifying the SAML token
* *SystemUserAgent.php*: Class responsible for calling PartnerSystemUserService endpoint to exchange a system user token for a JWT token that contains a system user ticket

### WSDL directory

* \[version number\] directory: contains all WSDL files for a specific NetServer version
* *PartnerSystemUserService.wsdl* for token to ticket exchange with SuperID

## Files

* *callback.php*: the page that receives a POST after a user successfully logs into SuperID
* *contactEntity.php*: the page responsible for displaying company details
* *createFollowUpListItems.php*: a page that demonstrates creating a follow-up list item
* *createProject.php*: a page that demonstrates how to create a new Project
* *createSaleType.php*: a page that demonstrates how to create a new Sale Type
* *createUserDefinedField.php*: a page that demonstrates how to create a new user-defined field
* *createWebPanel.php*: a page that demonstrates how to create a new web panel
* *getWebPanels.php*: a page that demonstrates how to get all web panels
* *header.php*: the page responsible for checking authorized session
* *index.php*: the page that starts the federated login process with SuperID
* *reset.php*: the page that removes the session state. Useful when re-login is desired
* *settings.php*: the file containing all of the configuration settings this project has. Use this file to specify:
  * Application ID
  * Application token
  * NetServer version
  * Protocol
  * SuperID URL
  * Certificate path
  * Token type (JWT or SAML)
* *webServiceCall.php*: the page that demonstrates instantiating the ContactAgent and invoking both the GetContactEntity and SaveContactEntity methods
* *welcome.php*: the page that displays a link to the index page
