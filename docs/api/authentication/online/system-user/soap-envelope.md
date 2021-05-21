---
title: SOAP envelope
uid: soap_envelope
description: SOAP envelope
author: {github-id}
keywords: web services
so.topic: reference
so.envir: cloud
so.client: online
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
