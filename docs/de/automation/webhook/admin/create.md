---
uid: help-de-webhook-create
title: Webhook erstellen
description: Webhook in Einstellungen und Verwaltung ohne Code oder API-Aufrufe erstellen.
keywords: Webhook erstellen, Webhook bearbeiten, Benachrichtigung, Ereignis
author: digitaldiina
date: 06.16.2026
version: 12.1
content_type: howto
tier: core
category: automation
topic: webhook
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: de
---

# Webhook erstellen

Sie können Webhook-Abonnements direkt in **Einstellungen und Verwaltung** erstellen und verwalten, ohne Code zu schreiben oder die API aufzurufen.

> [!NOTE]
> Um einen vorhandenen Webhook zu bearbeiten, klicken Sie mit der rechten Maustaste auf die Webhook-Zeile in der Liste **Webhooks** und wählen Sie **Bearbeiten**. Das Formular öffnet sich mit allen aktuellen Werten vorausgefüllt.

## Schritte

1. Gehen Sie zu **Einstellungen und Verwaltung** > **System design** und wählen Sie die Registerkarte **Webhooks**.

1. Klicken Sie auf **Hinzufügen**.

    ![Neues Webhook-Formular in Einstellungen und Verwaltung -screenshot][img1]

1. Geben Sie einen **Name des Webhooks** ein, um den Webhook zu identifizieren (erforderlich). Maximal 100 Zeichen.

1. Optional können Sie eine **Beschreibung** hinzufügen. Diese wird im Webhooks-Panel angezeigt.

1. **Ereignisse, die diesen Webhook auslösen** (erforderlich).

    Wählen Sie ein oder mehrere Ereignisse aus der Liste **Ereignis hinzufügen**. Jedes ausgewählte Ereignis wird als Tag angezeigt. Um ein Ereignis zu entfernen, wählen Sie **x** auf dem Tag.

    > [!TIP]
    > Sie können auch einen benutzerdefinierten Ereignisnamen direkt in das Feld eingeben und **Enter** drücken.

1. **Ziel festlegen** (erforderlich).

    Wählen Sie, wohin der Webhook geliefert werden soll:

    * **Externe URL:** Geben Sie die **Endpunkt-URL** ein. Die URL muss HTTPS verwenden und über ein gültiges TLS-Zertifikat verfügen. Der Endpunkt wird beim Speichern validiert — eine nicht erreichbare oder fehlerhafte URL verhindert das Speichern. Wählen Sie **Test senden**, um die Verbindung vor dem Speichern zu überprüfen.
    * **CRMScript:** Wählen Sie ein Skript aus der Liste.

1. **Fehlermeldung** (erforderlich).

    Geben Sie an, wen Sie benachrichtigen möchten, wie diese Personen erreichbar sind und wann die Benachrichtigung gesendet werden soll.

    * **Empfänger:** Fügen Sie CRM-Benutzer hinzu oder geben Sie externe E-Mail-Adressen ein. Empfänger werden als Tags angezeigt.
    * **Benachrichtigen über:** Wählen Sie den Benachrichtigungskanal.
    * **Benachrichtigung auslösen:** Wählen Sie eine oder beide Optionen:
      * **Beim ersten Fehlversuch:** Sendet eine Benachrichtigung, wenn der Webhook zum ersten Mal die Lieferung nicht schafft.
      * **Wenn deaktiviert:** Sendet eine Benachrichtigung, wenn der Webhook nach wiederholten Fehlern automatisch deaktiviert wird.

    ![Webhook-Formular mit konfigurierten Ereignissen, Ziel und Fehlerbenachrichtigung -screenshot][img2]

1. (Optional) Erweitern Sie **Sicherheit und erweiterte Einstellungen**.

    * **Gemeinsames Geheimnis:** Wählen Sie **Generieren**, um einen kryptografisch zufälligen Wert für die Signierung jeder Nutzlast zu erstellen. Das Secret wird nur bei der Erstellung angezeigt — kopieren Sie es sofort. Um es später zu ersetzen, wählen Sie **Regenerieren**.
    * **Benutzerdefinierte Kopfzeilen:** Schlüssel-Wert-Paare, die jedem HTTP POST hinzugefügt werden. Nur für Externe URL-Webhooks verfügbar.
    * **Benutzerdefinierte Eigenschaften:** Zusätzliche Daten, die in jede Nutzlast eingefügt werden.

    ![Abschnitt Sicherheit und erweiterte Einstellungen erweitert -screenshot][img3]

1. (Optional) Schalten Sie den **Aktiv**-Schalter (obere rechte Ecke) aus, um den Webhook im Zustand *Gestoppt* zu speichern.

1. Klicken Sie auf **Speichern**.

    ![Lieferstatus unterhalb des Aktiv-Schalters nach dem Speichern angezeigt -screenshot][img4]

Nach dem Speichern werden Informationen zum Lieferstatus unterhalb des **Aktiv**-Schalters angezeigt. Klicken Sie oben auf **Zurück zu Webhooks**, um zur Liste zurückzukehren.

## Verwandte Inhalte

* [Webhooks-Panel][1]
* [Webhook über die API registrieren][2]
* [CRMScript erstellen][3]

<!-- Referenced links -->
[1]: index.md
[2]: ../dev/register.md
[3]: ../../../customization/macros-and-scripts/admin/create-script.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/automation/new-webhook-required-fields.png
[img2]: ../../../../media/loc/en/automation/create-webhook-in-ui.png
[img3]: ../../../../media/loc/en/automation/webhook-advanced-settings.png
[img4]: ../../../../media/loc/en/automation/webhook-delivery-status.png
