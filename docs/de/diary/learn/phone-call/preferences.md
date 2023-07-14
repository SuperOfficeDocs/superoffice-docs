---
uid: help-de-phone-preferences
title: Telefoneinstellungen
description: Telefoneinstellungen
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Kalender, Folgeaufgabe, Telefon, Anruf, Anrufen
so.topic: howto
language: de
---

# Telefoneinstellungen

Sie können aus SuperOffice CRM auf eine der folgenden Weisen eine Telefonnummer anwählen:

* Klicken Sie auf eine Telefonnummer in der Ansicht Firma
* Klicken Sie auf ![Symbol][img1] in einem Dialogfeld.
* Klicken Sie mit der rechten Maustaste auf eine Person in einer Bereichsregisterkarte und wählen Sie **Anruf *Name***.
* [Personen anrufen][1].

Telefoneinstellungen werden bei Windows- und Web-Clients unterschiedlich bearbeitet. Unten erfahren Sie mehr über Telefoneinstellungen für Windows und Web.

## Technische Anforderungen

Um die Telefonfunktionen in SuperOffice nutzen zu können, müssen Sie unter Umständen TAPI-Software installieren.

### Vorgeschlagene Anbieter

* Standard-Windows-Wählsoftware
* Panasonic TSP
* PBX Dial

## Voreinstellungen

Wenn ein IP-Telefon, Skype oder FaceTime installiert ist, können Sie aus SuperOffice CRM Anrufe führen. Die Einstellung **Telefon-Link Format** muss richtig eingestellt sein, entweder in **Einstellungen** > **Standardwerte** oder in Einstellungen und Verwaltung. In Einstellungen und Verwaltung können die Telefoneinstellungen für einzelne Benutzer, Benutzergruppen oder global eingestellt werden.

### Verfügbare Parameter

**IP-Telefon**: Tel:%p (Standardwert)
**Skype**: callto:%p
**FaceTime**: FaceTime:%p

[Vorlagenvariablen][2] können ebenfalls in den Telefonparametern verwendet werden.

<!-- Referenced links -->
[1]: dial.md
[2]: ../../../document/learn/template-variables.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/phone.png
