---
uid: help-de-request-status
title: Anfragestatus
description: Anfragestatus
keywords: Anfragestatus, Anfragestatus-Registerkarte, Anfrage, Status
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
content_type: concept
license: serviceessentials
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
redirect_from: /de/request/learn/status/index
---

# Anfragestatus

Alle in SuperOffice erfassten Anfragen haben einen Status wie **Offen**, **Bearbeitet** oder **Auf Termin gelegt**. Wenn Sie im Navigator und in der Registerkarte **Anfragestatus** **Anfrage**auswählen, können Sie die bereits im System festgelegten Anfragenstatus sehen und zusätzliche Status erstellen. Ein Anfragestatus muss mit einem internen Status des Systems wie **Offen** oder **Bearbeitet** verknüpft werden. Jeder interne Status muss mit mindestens einem Anfragestatus verknüpft sein.

Sie könnten beispielsweise den neuen Status "Warten auf Antwort" als Variante zu **Geschlossen** oder **Geöffnet** erstellen, je nachdem, wie das System den Status intern verarbeiten soll. Sie können diesen Statuswerten auch logische Funktionen zuordnen, um Ihre Branchenprozesse zu vereinfachen.

## Einstellungen

| Einstellung | Beschreibung |
|---|---|
| Name | Der Name des Anfragestatus. Standardmäßig hat jeder interne Status einen Anfragestatus mit demselben Namen. |
| Interner Status | Die internen Statuswerte des Systems. Jeder interne Status muss mit mindestens einem Anfragestatus verknüpft sein. Die Systemstatuswerte **Verbunden** und **Gelöscht** werden nur für zusammengeführte bzw. gelöschte Anfragen verwendet und werden für die Benutzer nicht angezeigt. |
| Standard | Gibt an, ob es sich um einen Standardstatus für den internen Status handelt. |
| Warteschlangenstatus | Gibt an, ob Anfragen mit diesem Status in die Warteschlange gestellt werden sollen. Relevant, wenn Sie die Funktion **Nächste Anfrage in der Warteschlange anzeigen** verwenden. |
| Zeit nachverfolgen als | Wird verwendet, um den Zeitverbrauch in mehreren Stufen der Anfragenverwaltung zu melden. Das System berechnet den Zeitverbrauch bezüglich der definierten "Geschäftszeiten" sowie des gesamten 24-Stunden-Zeitraums. Wählen Sie aus: in der Warteschlange und in Erwartung der Verarbeitung; in der Phase der internen Entscheidung; in der Phase der externen Entscheidung |

## Was möchten Sie als Nächstes tun?

* [Anfragestatus erstellen][1]
* [Anfragestatus löschen][2]
* [Nächste Anfrage in der Warteschlange abrufen einrichten][3]

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: ../next-in-queue.md
