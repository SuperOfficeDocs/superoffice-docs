---
uid: help-de-request-close
title: Anfrage schließen
description: So schließen Sie eine oder mehrere Anfragen in SuperOffice.
keywords: Anfrage schließen, Status auf geschlossen setzen, geschlossen, Massenaktualisierung, Anfrage
author: Bergfrid Dias, kirstiaa
date: 02.14.2025
version: 10.5.1
topic: howto
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: de
---

# Anfragen schließen

Eine Anfrage zu schließen bedeutet, ihren [Status][5] auf *Geschlossen* zu setzen.

## Eine Anfrage schließen

Nachdem Sie [auf die Anfrage geantwortet haben][3], wählen Sie im **Status**-Feld in den Seiteneigenschaften **Geschlossen** aus.

## Mehrere Anfragen mit Massenaktualisierung schließen

Sie können mehrere Anfragen schnell schließen, indem Sie im Dialog **Massenaktualisierung** das **Status**-Feld auf *Geschlossen* setzen.

1. Öffnen Sie die Liste der Anfragen, die Sie aktualisieren möchten. Sie können Folgendes verwenden:
    * Eine **gespeicherte Suche** in der Selektionansicht.
    * Suchergebnisse aus der Ansicht **Anfragen finden**.
    * Den **Bereichstab Anfragen** (bei einer Firma oder Person).

1. Öffnen Sie den Dialog **Massenaktualisierung**:
    * **Selektionen:** Klicken Sie auf <i class="ph ph-dots-three-circle-vertical" aria-label="Aufgaben-Schaltfläche"></i> und wählen Sie **Massenaktualisierung**.
    * **Anfragen finden:** Wählen Sie die Anfragen aus, klicken Sie auf die <i class="ph ph-list" aria-hidden="true"></i> **Aufgaben**-Schaltfläche in der unteren linken Ecke und wählen Sie **Massenaktualisierung**.
    * **Bereichstab:** Wählen Sie die Anfragen aus, klicken Sie mit der rechten Maustaste und wählen Sie **Massenaktualisierung**.

1. Im Dialog **Massenaktualisierung**:
    * Geben Sie in der Spalte **Feld** **Status** ein oder wählen Sie es aus.
    * Wählen Sie in der Spalte **Aktion** **Einen auswählen**.
    * Wählen Sie in der Spalte **Neuer Wert** **Geschlossen** aus.
    * Stellen Sie sicher, dass nur das Kontrollkästchen neben **Status** aktiviert ist.

    ![Dialog Massenaktualisierung -screenshot][img1]

    Optional können Sie weitere Felder aktualisieren, jedoch mit Vorsicht.

1. Klicken Sie auf **Aktualisieren**.

1. Überprüfen Sie die Zusammenfassung im **Bestätigungs**-Dialog. Dort wird das zu aktualisierende Feld und die Anzahl der betroffenen Anfragen aufgelistet.

    ![Bestätigungsdialog -screenshot][img2]

1. Klicken Sie auf **Ja**, um die Änderungen zu übernehmen. Die ausgewählten Anfragen sind nun geschlossen.

    > [!CAUTION]
    > Eine durchgeführte Aktualisierung kann nicht rückgängig gemacht werden. Sie können jedoch die Aktualisierung während des Vorgangs stoppen. Alle Datensätze, die noch nicht aktualisiert wurden, bleiben unverändert.

## Verwandte Inhalte

* [Mehrere Datensätze aktualisieren (Massenaktualisierung)][1]
* [Eine Selektion erstellen][6]
* [Bereichstab Anfragen][2]
* [Anfragen finden][4]

<!-- Referenced links -->
[1]: ../../learn/basics/bulk-update.md
[2]: ../../learn/section-tabs/requests-tab.md
[3]: reply.md
[4]: find.md
[5]: ../admin/status/index.md
[6]: ../../search-options/selection/learn/create.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/bulk-update-requests.png
[img2]: ../../../media/loc/en/request/bulk-update-confirm.png
