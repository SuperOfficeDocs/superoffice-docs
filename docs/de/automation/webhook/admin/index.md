---
uid: help-de-webhook-panel
title: Webhooks-Panel
description: Webhooks in Einstellungen und Verwaltung anzeigen, verwalten und überwachen.
keywords: Webhook-Panel, Webhook-Status, deaktivierter Webhook, Webhook neu starten, Webhooks überwachen
author: digitaldiina
date: 06.16.2026
version: 12.1
content_type: concept
tier: core
category: automation
topic: webhook
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: de
---

# Webhooks-Panel

Das Webhooks-Panel ist der zentrale Ort für Administratoren und Berater, um Webhook-Abonnements in SuperOffice zu verwalten. Sie finden es unter **Einstellungen und Verwaltung** > **System design** > **Webhooks**.

Von diesem Panel aus können Sie den Status aller Webhooks auf einen Blick sehen, neue Abonnements erstellen, vorhandene bearbeiten und Webhooks wiederherstellen, die aufgrund von Lieferfehlern automatisch deaktiviert wurden.

![Übersicht über das Webhooks-Panel in Einstellungen und Verwaltung -screenshot][img1]

## Die Webhook-Liste

Die Liste zeigt alle registrierten Webhooks. Sie können nach jeder Spalte sortieren und filtern.

| Spalte | Beschreibung |
| --- | --- |
| Name | Der Anzeigename des Webhooks. |
| Status | Statusabzeichen, das den aktuellen Zustand anzeigt. |
| Ereignisanzahl | Die Anzahl der Ereignistypen, die der Webhook abonniert. |
| Ziel-URL | Die Ziel-URL oder der CRMScript-Name. |
| Letztes Ereignis | Zeitstempel des letzten Lieferversuchs. |
| Aufeinanderfolgende Fehlversuche | Anzahl aufeinanderfolgender Lieferfehler in den letzten 24 Stunden. |
| Aktualisiert von | Wer den Webhook zuletzt geändert hat. |

## Statusabzeichen

Jeder Webhook hat ein Statusabzeichen, das den aktuellen Zustand anzeigt.

| Status | Farbe | Bedeutung |
| --- | --- | --- |
| Aktiv | Grün | Läuft ohne Fehler in den letzten 24 Stunden. |
| Aktiv mit Fehlern | Gelb | Läuft, hatte aber Lieferfehler in den letzten 24 Stunden. |
| Gestoppt | Grau | Manuell von einem Administrator gestoppt. |
| Deaktiviert | Rot | Vom System nach 9 aufeinanderfolgenden Lieferfehlern automatisch deaktiviert. |

## Kontextmenüaktionen

Klicken Sie mit der rechten Maustaste auf eine Webhook-Zeile, um auf folgende Aktionen zuzugreifen.

| Aktion | Beschreibung |
| --- | --- |
| Bearbeiten | Öffnet das Webhook-Formular mit allen aktuellen Werten vorausgefüllt. |
| Kopieren | Erstellt ein Duplikat mit "(copy)" im Namen. Die Kopie wird im Zustand Gestoppt erstellt. |
| Aktivieren/Stoppen | Startet oder stoppt die Lieferung für den Webhook. |
| Neustart | Reaktiviert einen deaktivierten Webhook. Nur sichtbar, wenn der Webhook-Status Deaktiviert ist. |
| Löschen | Entfernt den Webhook dauerhaft. Vor dem Löschen wird eine Bestätigung angezeigt. |

## Lieferverlauf

Wählen Sie eine Webhook-Zeile aus, um den Detailbereich zu öffnen. Die Registerkarte **Ereignisse** zeigt ein Lieferprotokoll pro Webhook.

| Spalte | Beschreibung |
| --- | --- |
| Zeitstempel | Wann die Lieferung versucht wurde. |
| Status | Ergebnis des Versuchs. |
| Versuche | Anzahl der Lieferversuche für dieses Ereignis. |
| Fehlercode | Der zurückgegebene Fehler, wenn die Lieferung fehlschlug. |

Sie können einzelne fehlgeschlagene Ereignisse direkt aus dieser Liste erneut versuchen und die gesamte Liste als CSV exportieren.

## Automatische Deaktivierung und Wiederherstellung

Wenn ein Webhook 9 aufeinanderfolgende Lieferfehler erhält, deaktiviert das System ihn automatisch. Die Zeile zeigt einen Fehlerzähler (zum Beispiel 7/9) und den letzten Fehler.

So stellen Sie einen deaktivierten Webhook wieder her:

1. Beheben Sie das Problem, das die Lieferfehler verursacht hat.
1. Klicken Sie mit der rechten Maustaste auf die Webhook-Zeile und wählen Sie **Neustart**.

Der Webhook kehrt zum Aktiv-Status zurück und nimmt die normale Lieferung wieder auf.

## Benachrichtigungen in SuperOffice

Benachrichtigungsempfänger sehen eine Benachrichtigung in SuperOffice, wenn ein Webhook automatisch deaktiviert wird. Wählen Sie die Benachrichtigung aus, um das Webhooks-Panel zu öffnen.

## Verwandte Inhalte

* [Webhook erstellen][1]
* [Webhooks-Entwicklerhandbuch][2]

<!-- Referenced links -->
[1]: create.md
[2]: ../../../../en/automation/webhook/dev/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/admin/admin-system-design-webhook-overview.png
