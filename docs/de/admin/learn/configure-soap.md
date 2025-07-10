---
uid: help-de-settings-soap-configure
title: SOAP-Schnittstelle konfigurieren
description: SOAP-Schnittstelle konfigurieren
keywords: SOAP, Schnittstelle, IP-Adresse, Port konfigurieren
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: howto
category: service
topic: soap
deployment: onsite
audience: settings
audience_tooltip: Settings and maintenance
language: de
redirect_from: /de/admin/learn/screen/soap-config
---

# SOAP (nur VOR ORT)

In der Ansicht SOAP können Sie die SOAP-Oberfläche konfigurieren. Sie können drei Typen von Portzugriff einstellen:

* **Port: Kunde**: Auf dieser Registerkarte wird festgelegt, welche IP-Adressen Zugriff auf den Anschluss haben sollen, der auf das Kundenportal bezogene Funktionen bietet. Dazu gehören die Anfragen und externen Nachrichten des Kunden und die Wissensdatenbank.
* **Port: Anfrage**: Diese Registerkarte bezieht sich auf die Funktionen bezüglich der Bearbeitung der Anfrage in SuperOffice Service. Computer mit IP-Adressen innerhalb der hier festgelegten Bereiche erhalten Zugriff auf SOAP-Funktionen, die entsprechende Funktionalität bereitstellen.
* **Port: Admin**: Diese Registerkarte behandelt die Funktionen in Bezug auf das Setup und Konfiguration von SuperOffice Service. Computer mit IP-Adressen innerhalb der hier festgelegten Bereiche erhalten Zugriff auf SOAP-Funktionen, die entsprechende Funktionalität bereitstellen.

## IP-Adressen-Bereich hinzufügen

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Klicken Sie auf **Anfragen** und wählen Sie die Registerkarte **SOAP** aus.

1. Wählen Sie in der Liste **Port** den erforderlichen Zugriffstyp.

1. Geben Sie in den Feldern neben **Von** die Anfangsadresse für den IP-Adressen-Bereich ein.

1. Geben Sie in den Feldern neben **Bis** die Endadresse für den IP-Adressen-Bereich ein.

1. Klicken Sie auf die Schaltfläche **Hinzufügen**, um den IP-Adressen-Bereich der Liste unten hinzuzufügen.

> [!TIP]
> Klicken Sie auf <i class="ph ph-x-circle" aria-label="Remove icon"></i>, um einen IP-Adressen-Bereich von der Liste zu entfernen.
