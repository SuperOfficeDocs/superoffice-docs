---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: soap_envelope       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: SOAP envelope # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: web services
so.topic: reference         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# SOAP envelope

Basic envelope for sending SOAP requests to SuperOffice web services to exchange a system user token for a system user ticket.

```xml
<?xml version="1.0" encoding="UTF-8"?>
    <SOAP-ENV:Envelope xmlns:ns0="http://schemas.xmlsoap.org/soap/envelope/"
                                        xmlns:ns1="http://www.superoffice.com/superid/partnersystemuser/0.1"
                                        xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
                                        xmlns:tns="http://www.superoffice.com/superid/partnersystemuser/0.1"
                                        xmlns:SOAP-ENV="http://schemas.xmlsoap.org/soap/envelope/">
        <SOAP-ENV:Header>
            <tns:ApplicationToken>${appToken}</tns:ApplicationToken>
            <tns:ContextIdentifier>${contextId}</tns:ContextIdentifier>
        </SOAP-ENV:Header>
        <ns0:Body>
            <ns1:AuthenticationRequest>
                <ns1:SignedSystemToken>${signedToken}</ns1:SignedSystemToken>
                <ns1:ReturnTokenType>Jwt</ns1:ReturnTokenType>
            </ns1:AuthenticationRequest>
        </ns0:Body>
    </SOAP-ENV:Envelope>
```
