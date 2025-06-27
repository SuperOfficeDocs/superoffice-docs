---
uid: help-de-flow-run-pause-end
title: Ausführen, pausieren und beenden des Flow
description: Ausführen, pausieren und beenden des Flow
keywords: Marketing, Flow, Ausführen, Pausieren, Beenden, Status
author: Bergfrid Dias
date: 02.17.2025
version: 10.5.2
content_type: howto
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: de
---

# Ausführen, pausieren und beenden des Flow

## <a id="status"></a>Flowstatus

* **Wird nicht ausgeführt:** Stellt einen neuen Flow dar, der nicht gestartet wurde (oder ein beendeter Flow). Trigger sind nicht aktiviert.

* **Wird ausgeführt:** Keine Änderungen sind während des laufenden Flows zulässig. Automatisierte Trigger sind aktiviert, und Teilnehmer werden dem Flow hinzugefügt.

* **Pausiert:** Trigger bleiben aktiviert. Teilnehmer werden dem Flow hinzugefügt, aber sie warten auf Bewegung zum ersten Schritt. Bestehende Teilnehmer bleiben auf ihrem aktuellen Schritt, wenn der Flow angehalten ist. Dieser Status wird verwendet, um Änderungen oder Verbesserungen an einem Flow vorzunehmen.

![Marketing-Flow mit unterschiedlichem Status und Statistiken -screenshot][img1]

## Flow zum ersten Mal starten

Um einen neuen Flow zu starten:

1. Gehen Sie zu **Marketing** > **Flows**.
1. Wählen Sie den Flow aus, den Sie starten möchten.
1. Klicken Sie im Header auf den Schalter **AN**. Der Status ändert sich in **Wird ausgeführ**.

Dies aktiviert die Trigger des Flow. Neue Teilnehmer werden basierend auf diesen Triggern der Teilnehmerliste des Flow hinzugefügt. Teilnehmer durchlaufen den Flow, Aktionen werden ausgeführt, bis sie die Erfolgskriterien des Flow erfüllen, den Endschritt erreichen oder ausscheiden.

## Flow pausieren

Um einen laufenden Flow vorübergehend anzuhalten:

1. Öffnen Sie den Flow, den Sie pausieren möchten.
1. Klicken Sie im Header auf den Schalter **AUS**. Der Status ändert sich in **Angehalten**.

* Diese Aktion friert den aktuellen Status für alle Teilnehmer ein, die an ihrem aktuellen Schritt bleiben.
* **Trigger bleiben aktiv**, was dazu führt, dass die Teilnehmerliste weiter wächst. Neue Teilnehmer werden eingeschrieben, aber in eine Warteschlange gestellt.
* Die Schaltfläche **Bearbeiten** ist zugänglich, damit Flowadministratoren Aktualisierungen am Flow vornehmen können (mit einigen Einschränkungen).

## Flow fortsetzen (pausiert > wird ausgeführ)

Um einen angehaltenen Flow neu zu starten, klicken Sie im Bildschirm **Flow anzeigen** auf den Schalter **AN**.

* Alle Teilnehmer setzen ihren Fortschritt am Schritt fort, an dem der Flow pausiert wurde.
* Teilnehmer, die sich während der Pause eingeschrieben und in der Warteschlange befanden, wechseln zum ersten Schritt.
* Alle Änderungen am Flow werden auf einen Teilnehmer angewendet, wenn er den relevanten Schritt noch nicht überschritten hat.

## Flow beenden

Um den Flow zu beenden:

1. Öffnen Sie den Flow.
1. Wählen Sie **Aufgabe** > **Flow beenden**.

* Der Status des Flow ändert sich in **Wird nicht ausgeführt**.
* Alle Trigger für diesen Flow werden deaktiviert, und die Einschreibung endet. Es werden keine neuen Teilnehmer mehr dem Flow hinzugefügt.
* Aktive Teilnehmer erhalten den Status = *Abbruch*. Sie werden den Flow nicht abschließen.

> [!CAUTION]
> Diese Aufgabe sollte nur für Flows verwendet werden, die nicht mehr relevant sind. Das Beenden eines Flow ist nicht dafür gedacht, kleinere Anpassungen vorzunehmen - verwenden Sie stattdessen Pause. **Abbruche Teilnehmer werden den Flow nicht fortsetzen, wenn Sie sich entscheiden, ihn erneut auszuführen.**

Wenn der Flow nach dem Beenden erneut gestartet wird, gehen nur neue Teilnehmer durch den Flow, alte Teilnehmer behalten den Status Abbruch bei.

## <a id="delete"></a>Flow löschen

1. Pausieren Sie den Flow. Der Flow-Status ändert sich zu **Pausiert**.
1. Beenden Sie den Flow. Der Status ändert sich zu **Wird nicht ausgeführt**.
1. Klicken Sie auf <i class="ph ph-dots-three-circle-vertical" aria-label="Aufgabenmenü"></i> und wählen Sie **Flow löschen**.
1. Bestätigen Sie die Aktion.

Diese Option ist sowohl im Bildschirm **Flow anzeigen** als auch in der Übersicht aller Flows verfügbar.

## Fehlerbehebung

### Flow kann nicht ausgeführt werden

Alle erforderlichen Einstellungen müssen gültig sein, bevor der Flow ausgeführt werden kann. Zum Beispiel kann ein Flow mit einem E-Mail-Schritt nicht ausgeführt werden, wenn E-Mail-Einstellungen wie Absenderadresse oder Antwortadresse fehlen. Suchen Sie nach dem Warnsymbol - das Tooltip beschreibt das Problem.

### Flow kann nicht gelöscht werden

Sie können keinen laufenden Flow löschen. Pausieren Sie zuerst den Flow, damit sich der Status zu **Pausiert** ändert. Beenden Sie dann den Flow, damit sich der Status zu **Wird nicht ausgeführt** ändert. Danach klicken Sie auf <i class="ph ph-dots-three-circle-vertical" aria-label="Aufgabenmenü"></i> und wählen **Flow löschen**.

## Verwandte Inhalte

* [Flow aktualisieren][1]

<!-- Referenced links -->
[1]: update.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-status.png
