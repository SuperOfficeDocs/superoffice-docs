---
uid: help-de-service-settings-system-sms
title: SMS
description: SMS
author: SuperOffice RnD
date: 03.27.2023
keywords: Service, Einstellungen
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# SMS-Konfiguration in Globale Einstellungen

Gehen Sie im Navigator zum <i class="ph ph-gear" aria-hidden="true"></i> **Einstellungen** und wählen Sie die Registerkarte **Globale Einstellungen** aus. Der Bereich **SMS-Konfiguration** enthält Optionen zum Konfigurieren von SMS-Lösungen in SuperOffice.

## Allgemeine Felder

[!include[Settings for mailings - SMS](../../../../marketing/learn/includes/mailing-settings-sms.md)]

### SMS-Einstellungen testen

Zum Testen der Einstellungen geben Sie eine Mobiltelefonnummer und etwas Text ein und klicken dann auf **Test**.

## Für Intelecom verfügbare Felder (nur VOR ORT)

* **SMS-Endpunkt**: Dieses Feld sollte Code enthalten, mit dem SuperOffice Service eine eingehende SMS erkennt.
* **Web Services verwenden**: Wenn diese Option aktiviert ist, werden SMS-Nachrichten über einen Web Service statt per E-Mail gesendet. Diese Methode sollte verwendet werden, weil sie mehr Funktionen bietet. Jedoch muss eine eventuell vorhandene Firewall so konfiguriert werden, dass der Datenverkehr zu SMS-Gateways zugelassen wird.
* **Sendebericht**: Wenn diese Option aktiviert ist, wird die Sendebestätigung für SMS-Nachrichten in SuperOffice Service unterstützt. Dies bedeutet, dass Sie sehen können, ob eine SMS-Nachricht an das entsprechende Mobiltelefon gesendet wurde. Dazu ist zusätzlich eine Konfiguration auf Anbieterseite erforderlich.
* **Dienst-ID**: Die Dienst-ID des SMS-Dienstes. Von SuperOffice AS bereitgestellt.
* **Benutzername**: Geben Sie hier den Benutzernamen ein, der Ihnen von Intelecom zugeteilt wurde.
* **Kennwort**: Geben Sie hier das Kennwort ein, das Ihnen von Intelecom zugeteilt wurde.
* **SMS-Priorität**: Geben Sie hier 1, 2 oder 3 ein. Die Zahl gibt an, wie schnell die SMS-Nachrichten gesendet werden.

## Für PsWinCom verfügbare Felder (nur VOR ORT)

* **SMS-Endpunkt**: Dieses Feld sollte Code enthalten, mit dem SuperOffice Service eine eingehende SMS erkennt.
* **Benutzername**: Geben Sie hier den Benutzernamen ein, der Ihnen von PsWinCom zugeteilt wurde.
* **Kennwort**: Geben Sie hier das Kennwort ein, das Ihnen von PsWinCom zugeteilt wurde.
