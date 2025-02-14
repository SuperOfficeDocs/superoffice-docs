---
uid: help-de-contact-dial
title: Personen anrufen
description: Personen anrufen; Telefoneinstellungen
author: SuperOffice RnD
date: 09.22.2023
keywords: Kalender, Folgeaufgabe, Telefon, Anruf, Anrufen
topic: howto
language: de
---

# Personen anrufen

Wenn Ihre IP-Telefonlösung richtig konfiguriert ist, können Sie eine Person direkt aus SuperOffice CRM anrufen auf eine der folgenden Weisen:

* Klicken Sie auf eine Telefonnummer in der Ansicht Firma
* Klicken Sie auf <i class="ph ph-phone" aria-label="Phone icon"></i> in einem Dialogfeld.
* Klicken Sie mit der rechten Maustaste auf eine Person in einer Bereichsregisterkarte und wählen Sie **Anruf *Name***.
* Personen anrufen.

## Anruf über die Dialogfelder Folgeaufgabe und Dokument

Zu diesem Zweck verwenden Sie die Telefon-Schaltfläche, die z. B. in den Dialogfeldern **Folgeaufgabe** und **Dokument** angezeigt wird:

1. Öffnen Sie eine Folgeaufgabe oder ein Dokument.
2. Wählen Sie im betreffenden Dialogfeld die gewünschte Person im Feld **Person** aus.
3. Klicken Sie auf die Anruf-Schaltfläche neben dem Feld Person. Eine Liste von Nummern, die mit der ausgewählten Person verknüpft sind, wird angezeigt.
4. Wählen Sie die Telefonnummer, die Sie anrufen möchten. Die Person wird daraufhin angerufen.

<!-- markdownlint-disable-next-line MD013 -->
## Anruf von Bereichsregisterkarten (Personen, Selektionsmitglieder, Beteiligte und Teilnehmer)

1. Wechseln Sie zu einer Bereichsregisterkarte, die Personen enthält.
2. Klicken Sie auf einer Spalte mit Telefonnummern auf eine Telefonnummer. Die Person wird daraufhin angerufen.

## Technische Anforderungen

Um die Telefonfunktionen in SuperOffice nutzen zu können, müssen Sie unter Umständen TAPI-Software installieren.

### Vorgeschlagene Anbieter

* Standard-Windows-Wählsoftware
* Panasonic TSP
* PBX Dial

## Voreinstellungen

Wenn ein IP-Telefon, Skype oder FaceTime installiert ist, können Sie aus SuperOffice CRM Anrufe führen. Die Einstellung **Telefon-Link Format** muss richtig eingestellt sein, entweder in **Einstellungen** > **Standardwerte** oder in Einstellungen und Verwaltung. In Einstellungen und Verwaltung können die Telefoneinstellungen für einzelne Benutzer, Benutzergruppen oder global eingestellt werden.

### Verfügbare Parameter

* **IP-telefon**: `tel:%p` (standardverdi)
* **Skype**: `callto:%p`
* **FaceTime**: `facetime:%p`

[Vorlagenvariablen][2] können ebenfalls in den Telefonparametern verwendet werden.

<!-- Referenced links -->
[2]: ../../document/templates/learn/template-variables.md
