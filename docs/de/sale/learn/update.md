---
uid: help-de-sale-update
title: Einen Verkauf aktualisieren
description: So aktualisieren Sie bestehende Verkaufsinformationen, ändern die Verkaufsstufe (einschließlich Markierung als pausiert, gewonnen oder verloren) oder löschen einen Verkauf, wenn er nicht mehr relevant ist.
keywords: Verkauf aktualisieren, Verkauf bearbeiten, Verkauf löschen, pausiert, verloren, gewonnen, Verkauf
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
content_type: howto
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Einen Verkauf aktualisieren

Sie können bestehende Verkaufsinformationen aktualisieren, die Verkaufsstufe ändern (einschließlich Markierung als pausiert, gewonnen oder verloren) oder einen Verkauf löschen, wenn er nicht mehr relevant ist.

## Verkauf bearbeiten

1. Öffnen Sie den **Verkaufskarte** für den Verkauf, den Sie aktualisieren möchten. Siehe [Suchansicht verwenden][5].

1. Klicken Sie oben rechts auf <i class="ph ph-pencil-simple" aria-hidden="true"></i>, um den Bearbeitungsmodus zu aktivieren.

1. Nehmen Sie die erforderlichen Änderungen vor. Sie können zwischen Registerkarten wechseln, während Sie im Bearbeitungsmodus bleiben.

    * **Gesamtkosten, Gewinn und Prozentsatz-Felder:** Wenn Sie ein Feld ändern, werden die anderen automatisch aktualisiert, um Konsistenz zu gewährleisten.

    * **Ändern die Stufe:** Wenn Sie die Stufe aktualisieren, wird das Feld **Wahrscheinlichkeit** automatisch angepasst. Sie können den Wert aber weiterhin manuell überschreiben. Falls der Verkaufstyp mit einem [Verkaufsleitfaden][1] verknüpft ist, werden die vorherigen Stufen im Leitfaden als abgeschlossen markiert.

    > [!CAUTION]
    > Wenn Sie den **Verkaufstyp** ändern, der mit einem Verkaufsleitfaden verknüpft ist, wird der Leitfaden entfernt. Folgeaufgaben und Dokumente bleiben in der Registerkarte **Aktivitäten** erhalten und werden wieder verknüpft, wenn Sie den ursprünglichen Typ wiederherstellen.

1. Klicken Sie auf **Speichern**, um die Änderungen zu übernehmen, oder auf **Abbrechen**, um sie zu verwerfen. Beide Aktionen beenden den Bearbeitungsmodus.

    > [!NOTE]
    > Wenn die **Speichern**-Schaltfläche ausgegraut ist, stellen Sie sicher, dass alle Pflichtfelder ausgefüllt sind.

## <a id="stalled"></a>Einen Verkauf als aufgeschoben markieren

Dieser Status kann verwendet werden, wenn z. B. ein Kunde seine Kaufentscheidung auf einen späteren Zeitpunkt verschiebt.

1. Aktivieren Sie das Kontrollkästchen **Aufgeschoben** im Verkaufsansicht.

1. Füllen Sie die folgenden zusätzlichen Felder aus:
    * **Wiederaufnahme-Datum:** Datum, an dem der Verkauf erneut überprüft werden sollte.
    * **Grund (aufgeschoben):** Erklärung, warum der Verkauf nicht fortgesetzt werden kann.

    ![Aufgeschobener Verkauf -screenshot][img1]

1. Klicken Sie auf **Speichern**. Der Dialog **Folgeaufgabe** öffnet sich, sodass Sie ein zukünftiges Besprechung oder einen Anruf planen können.

> [!NOTE]
> Die Felder **Wiederaufnahme-Datum** und **Grund** ersetzen das Feld **Nächste Aktivität**.

## Einen Verkauf als gewonnen markieren

1. Wählen Sie **Gewonnen** im Dropdown-Menü **Stufe**.

1. Aktualisieren Sie das Feld **Datum** (Standard ist das heutige Datum) auf das tatsächliche Abschlussdatum.

1. Wählen Sie den **Grund**, warum der Verkauf erfolgreich war.

    ![Gewonnener Verkauf -screenshot][img2]

1. Passen Sie den Verkaufsbetrag an und aktualisieren Sie die Finanzdetails in der Registerkarte **Details**.

1. Klicken Sie auf **Speichern**.

## Einen Verkauf als verloren markieren

1. Wählen Sie **Verloren** im Dropdown-Menü **Stufe**.

1. Wählen Sie den **Grund**, warum der Verkauf nicht erfolgreich war.

    ![Verlorener Verkauf -screenshot][img3]

1. Aktualisieren Sie andere Felder, falls erforderlich.

1. Klicken Sie auf **Speichern**.

Wenn der Verkauf den Status **Gewonnen** oder **Verloren** hat, können Sie das Feld **Abgeschlossen** aktivieren.

## <a id="delete"></a>Einen Verkauf löschen

1. Öffnen Sie den Verkaufsansicht für den Verkauf, den Sie löschen möchten.

1. Klicken Sie auf die **Aufgabe**-Schaltfläche (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) oben rechts im Verkaufskarte und wählen Sie **Löschen**.

1. Überprüfen Sie im Dialog **Verkauf löschen** die Verkaufsdetails, um sicherzustellen, dass Sie den richtigen Verkauf löschen. **Diese Aktion kann nicht rückgängig gemacht werden.**

    > [!NOTE]
    > Wenn die **Löschen**-Option nicht verfügbar ist, haben Sie möglicherweise nicht die erforderlichen Berechtigungen. Sie können keine Verkäufe löschen, die Ihnen nicht gehören, es sei denn, Sie haben spezielle Rechte.

1. Klicken Sie auf **Ja**, um das Löschen zu bestätigen.

## Verwandte Inhalte

* [Einen Verkauf erstellen][2]
* [Verkaufsleitfäden][1]
* [Erklärung der Felder][3]

<!-- Referenced links -->
[1]: sales-guides.md
[2]: create.md
[3]: create.md#fields
[5]: ../../search-options/learn/find-screen.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/stalled-sale.png
[img2]: ../../../media/loc/en/sale/won-sale.png
[img3]: ../../../media/loc/en/sale/lost-sale.png
