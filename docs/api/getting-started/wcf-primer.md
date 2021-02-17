---
# Mandatory fields.
title: wcf_primer       # (Required) Very important for SEO.
description: Windows Communication Foundation (WCF) # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: guide           # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Windows Communication Foundation (WCF)

## Terminology

* **Service** - web service that implements a contract. Equivalent to an .asmx web service
* **Endpoint** - Address, port, and protocol a web service is exposed through
* **Binding** - Configuration of a binding including SOAP version, protocol, security, etc…
* **Behavior** - How the service behaves – yet another place to configure

## Endpoints

**Providers:**

| Provider | Description |
|---|---|
| NetServer Application Serve | Classic back-end for web when in remote mode. |
| Sales & Marketing Web (CRM.web) | Services exposed as part of the web client. |
| SoWcfHost | Developer tool for working with NetServer WebServices |

**Consumers:**

| Consumer | Description |
|---|---|
| Sales & Marketing Web (CRM.web) | The web server talks to the back-end web-services using NetServer proxies. |
| Customer Service | The CGI scripts in C++ use the gSOAP library to talk to the back-end web services. |
| Pocket | Pocket uses Java and Sun Metro to generate proxies. |
| Third-party clients | Use the SDK or PHP/Java/Perl to talk to the web services. |

## Deployment

Do you want to deploy NetServer web services as part of the Sales & Marketing Web client?

### StandAlone

Install the web services on a separate server, or as a separate web application on the same server.

* Several installations = several configurations, more stuff to maintain.
* More flexibility.
  * When are you upgrading which SuperOffice 7 product to 7.1 or SR?
* More Control?
  * Do you want your web services exposed to the internet?
  * Do you need System users to access your web services?
  * Is the user in your .mst file a valid system user?

### With Sales and Services web

Install the web services as part of the Sales & Marketing or the Customer Service web client.

* One installation – one configuration – less stuff to maintain.
* Web and Web Services has always the same version.
  * What version is required by Pocket and Customer Service?
  * You will not be guarantied that all products are released at the same time in the future.
* Do you want Web to be accessible from Internet?
  * What about your web services? Security considerations...

## Configuration

### App server

![config-app-server][img1]

In the *web.config* file for the application server you can turn on help pages to verify that the services are working. They also describe the API, so you should probably turn these off when exposing services on the open internet.

### Web server

![config-web-server][img2]

For the web server to talk to the backend you must change the `DefaultMode` to "Remote".

* With ASMX services that was enough.
* With WCF you must also set up the WCF binding to connect the web server to the app server.

## Troubleshooting

Where to look if something goes wrong.

### Configuration

The most common issue by far is to low default values on the bindings. Remember to Increase both server and client sides when there are problems.

![troubleshooting][img3]

### Use a browser

Use the web browser to navigate to the web-service end-point and see what you get back.

![trouble-svc][img4]

### Fiddler

Use Fiddler to look at the HTTP traffic between the client and the web service to see what is really going on.

Fiddler is a HTTP Proxy that allows you to look at HTTP traffic between local clients and a server (possibly running on your local machine).

### Use SoWcfHost

This is a stand-alone EXE that you can use to host web-services locally without relying on IIS or the development web-server. This makes it a little easier to attach a debugger to, and you have more control over what services are running.

<!-- Referenced images -->
[img1]: media/config-app-server.png
[img2]: media/config-web-server.png
[img3]: media/troubleshooting.png
[img4]: media/trouble-svc.png
