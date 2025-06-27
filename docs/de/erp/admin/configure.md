---
uid: help-de-erp-configure
title: ERP-Verbindung konfigurieren
description: Synchronisation zwischen SuperOffice CRM und Ihrem ERP-System konfigurieren, indem Sie Felder zuordnen, Standardwerte festlegen und ERP-Verbindungen priorisieren.
keywords: ERP-Verbindung, Synchronisation konfigurieren, Feldzuordnung, Listenzuordnung, Standardwerte, ERP-Felder sortieren, Sync-Priorität festlegen, ERP-Verbindung aktivieren, ERP-Verbindung bearbeiten, SuperOffice ERP-Integration, ERP-Registerkarte, Sync Connector
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
---

# ERP-Verbindung konfigurieren

Nachdem Sie eine ERP-Verbindung hinzugefügt haben, müssen Sie konfigurieren, wie Daten zwischen SuperOffice und dem ERP-System synchronisiert werden. Dies erfolgt über die Schaltflächen unten auf der Registerkarte **Sync** in der Ansicht Angebot/Sync.

![Liste der ERP-Verbindungen mit Optionen darunter -screenshot][img1]

## Feldzuordnung

Die Feldzuordnung definiert, wie ERP-Felder SuperOffice-Feldern zugeordnet werden und wie der Datenfluss zwischen den Systemen erfolgt. Die verfügbaren ERP-Aktoren und ERP-Felder werden vom Sync Connector bereitgestellt und können je nach ERP-System variieren. Zusätzlich zur Festlegung der Synchronisationsrichtung können Sie auch auswählen, welche Felder im Suchfenster und in der Registerkarte **ERP** in SuperOffice CRM angezeigt werden sollen.

1. Wählen Sie die ERP-Verbindung aus und klicken Sie unten links auf **Zuordnungen**.

    Das Dialogfeld **Zuordnungen** wird geöffnet und zeigt Registerkarten für die verfügbaren ERP-Aktoren (z. B. Kunde, Lieferant, Kontakt oder Projekt).

1. Wählen Sie die Registerkarte für den Aktor, den Sie konfigurieren möchten.

1. Aktivieren Sie **ERP-"[Aktor]" mit SuperOffice-"[Eintrag]" synchronisieren**, um die Synchronisation zu ermöglichen.

1. Für jedes ERP-Feld in der Liste geben Sie an:

    * **SuperOffice-Feld:** Wählen Sie aus, welchem SuperOffice-Feld das ERP-Feld zugeordnet werden soll.
    * **Richtung:** Legen Sie die Synchronisationsrichtung fest. Verwenden Sie **&gt;** für ERP zur SuperOffice, **&lt;** für SuperOffice zur ERP oder **&lt; &gt;** für bidirektionale Synchronisation.

        Die Richtungsschaltflächen haben drei Zustände:
        * **Grau:** Deaktiviert. Sie müssen zuerst ein SuperOffice-Feld auswählen.
        * **Weiß:** Aktiviert, aber nicht ausgewählt.
        * **Blau:** Ausgewählt.

    * **In Suche anzeigen:** Aktivieren Sie dieses Feld, damit es in den Suchergebnissen angezeigt wird.
    * **In ERP-Registerkarte anzeigen:** Aktivieren Sie dieses Feld, damit es in der ERP-Registerkarte in SuperOffice CRM angezeigt wird (Firma, Person und Projekt).

        Wenn ein Feld synchronisiert wird, muss es in der Registerkarte **ERP** in der Regel nicht angezeigt werden.

    ![ERP-Feldzuordnung konfigurieren -screenshot][img2]

1. Wiederholen Sie diese Schritte bei Bedarf für andere Aktoren.

1. Klicken Sie auf **Fertig**, wenn Sie fertig sind.

Sie können jetzt mit Listenzuordnung, Standardwerten oder Sortierung der Felder fortfahren – oder die Verbindung aktivieren, wenn keine weitere Konfiguration erforderlich ist.

## <a id="list-mapping"></a>Listenzuordnung

Wenn Sie Listenfelder wie Kategorie oder Status zugeordnet haben, müssen Sie auch die einzelnen Listenelemente zwischen dem ERP-System und SuperOffice abgleichen.

1. Wählen Sie die ERP-Verbindung aus und klicken Sie unten links auf **Listenzuordnung**.

1. Wählen Sie im Dialog eine Liste aus. Die zugehörigen ERP- und CRM-Einträge werden angezeigt.

    Wenn keine Listen angezeigt werden, überprüfen Sie, ob die zugehörigen Felder in der **Feldzuordnung** zugewiesen wurden.

1. Wählen Sie für jedes ERP-Element den passenden CRM-Eintrag.

    Jedes ERP-Element kann nur einem CRM-Eintrag zugeordnet werden. Doppelte Zuordnungen werden rot markiert. Um ein ERP-Element nicht zuzuordnen, wählen Sie **(Keine Selektion)**.

1. Wiederholen Sie dies für alle relevanten Listen.

1. Klicken Sie auf **Speichern** und aktivieren Sie anschließend die ERP-Verbindung, wenn keine weitere Konfiguration notwendig ist.

## <a id="defaults"></a>Standardwerte für Synchronisation

Standardwerte helfen dabei, die manuelle Dateneingabe für Felder zu reduzieren, die typischerweise einen festen oder vorhersehbaren Wert haben. Dies ist besonders hilfreich bei der Verarbeitung großer Datenmengen oder wenn Benutzer nicht wiederholt denselben Wert eingeben oder eine Option aktivieren sollen, die immer ausgewählt sein sollte.

1. Wählen Sie die ERP-Verbindung aus und klicken Sie unten links auf **Standards**.

1. Wählen Sie im Dialogfeld die Registerkarte für den Aktor, den Sie konfigurieren möchten.

    ![Konfigurieren von Standardwerten für die Synchronisation -screenshot][img3]

1. Klicken Sie auf **Hinzufügen**, um einen neuen Standardwert zu definieren. Das Dialogfeld **Sync-Standardwert hinzufügen** wird geöffnet.

1. Im Dialogfeld:

    * **ERP-Feld:** Wählen Sie das Feld, für das Sie einen Standardwert definieren möchten.

    Wählen Sie anschließend, wie dieses Feld behandelt werden soll:

    * **Standardwert festlegen:** Automatisch einen bestimmten Wert bei der Synchronisation verwenden. Diese Option erfordert die Eingabe eines Wertes.
    * **Benutzer nach Wert fragen:** Der Benutzer gibt den Wert manuell ein.
    * **Obligatorisch – Benutzer muss einen Wert angeben:** Ein Wert muss zwingend angegeben werden. Wenn diese Option ausgewählt ist, müssen Sie zusätzlich eine der beiden obigen Optionen auswählen.

    ![Sync-Standardwert hinzufügen -screenshot][img4]

1. Klicken Sie auf **OK**, um zu speichern.

1. Wiederholen Sie diesen Vorgang, um weitere Standardwerte zu definieren.

## <a id="rank"></a>Felder, die auf der ERP-Registerkarte angezeigt werden, sortieren

Legen Sie die Reihenfolge der Felder fest, die auf der Registerkarte **ERP** in den Ansichten Firma, Person und Projekt angezeigt werden. Alle verfügbaren Felder werden hier aufgelistet, aber nur die markierten Felder erscheinen tatsächlich auf der Registerkarte.

1. Wählen Sie die ERP-Verbindung aus und klicken Sie unten links auf **Felder sortieren**.

1. Wählen Sie im Dialogfeld die Registerkarte für den Aktor, den Sie konfigurieren möchten.

    Alle verfügbaren Felder werden aufgelistet, einschließlich derer, die nicht in der Registerkarte **ERP** angezeigt werden.

    ![Felder auf der Registerkarte ERP sortieren -screenshot][img5]

1. Wählen Sie ein Feld aus und verwenden Sie <i class="ph ph-arrow-circle-up" aria-label="Arrow up"></i> <i class="ph ph-arrow-circle-down" aria-label="Arrow down"></i>, um die Position des Felds in der Liste zu ändern.

1. Wiederholen Sie den Vorgang nach Bedarf für andere Aktoren.

1. Klicken Sie auf **Fertig**, um Ihre Änderungen zu speichern.

## <a id="priority"></a>Sync-Priorität festlegen

Wenn mehrere ERP-Verbindungen gleichzeitig aktiv sind, können Sie festlegen, welche Verbindung bei starkem Datenverkehr Priorität haben soll.

1. Klicken Sie unter der Liste **ERP-Verbindungen** auf **Sync-Priorität festlegen**.

1. Wählen Sie im Dialogfeld eine Verbindung aus.

1. Verwenden Sie <i class="ph ph-arrow-circle-up" aria-label="Arrow up"></i> und <i class="ph ph-arrow-circle-down" aria-label="Arrow down"></i>, um die gewählte Verbindung in der Liste nach oben oder unten zu verschieben.

1. Klicken Sie auf **Fertig**, um Ihre Änderungen zu speichern.

## Fehlerbehebung

### ERP-Verbindung kann nicht aktiviert werden

Wenn die ERP-Verbindung nicht aktiviert werden kann, prüfen Sie die Feldzuordnungen:

* Pflichtfelder müssen eine Synchronisationsrichtung haben.
* Konfigurationsfehler lösen eine beschreibende Fehlermeldung aus.
* Sie müssen die Fehler beheben, bevor die Verbindung aktiviert werden kann.

### Sync-Richtungsschaltflächen sind nicht verfügbar

Wenn die Richtungspfeile ausgegraut bleiben, obwohl ein SuperOffice-Feld ausgewählt wurde, kann dies folgende Ursachen haben:

* Das Feld kann nicht synchronisiert werden (zum Beispiel eine ID oder ein schreibgeschütztes Feld).
* Das Feld ist für den ausgewählten ERP-Aktor nicht gültig.

Fahren Sie mit der Maus über den Pfeil, um eine Erläuterung anzuzeigen.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../media/loc/en/erp/erp-connection-settings.png
[img2]: ../../../media/loc/en/erp/configure-field-mapping.png
[img3]: ../../../media/loc/en/erp/list-of-default-values.png
[img4]: ../../../media/loc/en/erp/add-sync-default-value.png
[img5]: ../../../media/loc/en/erp/rank-fields.png
