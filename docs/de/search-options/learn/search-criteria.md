---
uid: help-de-search-criteria
title: Suchkriterien verwenden
description: Suchkriterien verwenden
author: Bergfrid Dias
date: 05.25.2023
keywords: Suchen, Kriterien
topic: howto
language: de
---

# Suchkriterien verwenden

Suchkriterien werden verwendet, um Suchanfragen zu definieren, wie zum Beispiel "Firmen mit Sitz in Dänemark". Suchkriterien werden an mehreren Stellen in SuperOffice CRM verwendet, u. a. in der Ansicht **Suchen** und wenn Selektionen erstellt werden. Ungeachtet dessen, wofür Sie die Kriterien verwenden, arbeiten Sie damit jedoch immer auf dieselbe Weise.

Überall dort, wo Sie Suchkriterien eingeben können, finden Sie eine Kriterienliste mit den ausgewählten Suchkriterien.

Typische Suchanfragen sollen Ihnen den Einstieg und die Erstellung Ihrer eigenen Suche nach CRM-Daten erleichtern. Nachdem Sie eine typische Suchanfrage ausgewählt haben, können Sie die Suchkriterien hinzufügen und bearbeiten. Und nachdem Sie eine nützliche Suche erstellt haben, die Sie erneut verwenden möchten, können Sie diese als Selektion speichern.

Sehen Sie sich dieses Video an, um zu lernen, wie Sie eine typische Suchanfrage durchführen und ändern können, indem Sie neue Suchkriterien hinzufügen oder der folgenden Schritt-für-Schritt-Anleitung folgen (Videolänge – 3:01):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/gx-vXm-b_7g]

## Suchkriterien hinzufügen

1. Wechseln Sie zur Kriterienliste.
    * Klicken Sie in der oberen Leiste auf **Suchen**. Die Kriterienliste befindet sich auf der Registerkarte **Kriterien**.
    * Oder gehen Sie zur gewünschten Selektion und wählen Sie die Registerkarte **Kriterien** aus.

2. Klicken Sie auf die Schaltfläche **Hinzufügen**.
    In die Kriterienliste wird eine neue Zeile eingefügt, und es wird eine Liste mit wählbaren Feldern angezeigt.

3. Wählen Sie das Feld aus, in dem Sie nach Informationen suchen möchten. Sie können auch im entsprechenden Feld den [Anfang des Namens eingeben][2]. Es gibt verschiedene Typen von Feldern:

    * [Langer](#text)
    * [Ja/Nein](#yes-no)
    * [Datum](#date)
    * [Nummer](#number)
    * [Liste](#list)
    * [Status](#status)
    * [Zähler](#counter)

4. Wählen Sie die Werte für die Suchkriterien in den verschiedenen Feldern der Zeile aus.

5. Klicken Sie auf **Hinzufügen**, um eine neue Zeile hinzuzufügen, oder klicken Sie auf **Oder**, um einen neuen Kriteriensatz hinzuzufügen.

## Feldtypen

### <a id="text"></a>Textfeld

Wenn Sie in einem Textfeld suchen (wie einen Namen), wird nach eingegebenem Text oder eingegebenen Zahlen gesucht. Eine Liste mit den folgenden Optionen wird angezeigt:

[!include[Search criteria](includes/list-search-criteria.md)]

Wählen Sie eine dieser Optionen und geben Sie dann im Textfeld auf der rechten Seite die Suchkriterien ein.

### <a id="yes-no"></a>Ja/Nein-Feld

Handelt es sich bei dem gesuchten Feld um ein Ja/Nein-Feld (zum Beispiel das Feld **Mailsperre** in der Ansicht Firma), werden zwei Optionsfelder angezeigt. Sie können zwischen **Ja** und **Nein** wählen.

### <a id="date"></a>Datumsfeld

Wenn das Feld, das Sie durchsuchen, ein Datumsfeld ist (zum Beispiel das Feld **Datum** im Dialogfeld **Dokument**), wird ein Listenfeld mit den folgenden Optionen angezeigt:

[!include[Search criteria](includes/list-date-criteria.md)]

Wählen Sie die gewünschte Option. Je nach Ihrer Auswahl wird das Feld automatisch mit einem Datum oder Datumsbereich ausgefüllt, oder Sie können das gewünschte Datum auch selbst eingeben. Sie können auch ein Datum aus dem Kalender auswählen, der angezeigt wird, wenn Sie auf die Pfeilschaltfläche ![Symbol][img1] klicken.

### <a id="number"></a>Nummernfeld

Wenn das gesuchte Feld einen numerischen Wert enthält (zum Beispiel das Feld **Betrag** in der Ansicht Verkauf), wird ein Listenfeld mit den folgenden Optionen angezeigt:

[!include[Search criteria](includes/table-number-criteria.md)]

Wählen Sie die erforderliche Option und geben Sie im Textfeld auf der rechten Seite den gewünschten numerischen Wert ein.

### <a id="list"></a>Listenfeld

Enthält das durchsuchte Feld Listen (zum Beispiel das Feld **Branche** in der Ansicht Firma), wird ein Listenfeld mit den Optionen **Ist eines von** und **Ist nicht eines von** angezeigt.

1. Klicken Sie auf das Feld **Objekte auswählen**, um die Werteliste anzuzeigen.
1. Wenn die Liste lang ist, können Sie Text in die Felder **Suchkriterien** eingeben, um nach Werten zu suchen.
1. Klicken Sie außerhalb der Liste, um sie zu schließen.

### <a id="status"></a>Statusfeld

Handelt es sich bei dem zu durchsuchenden Feld um ein Statusfeld, müssen Sie den erforderlichen Status auswählen.

Die Statusangaben werden in Einstellungen und Verwaltung erstellt und verwaltet. Statusfelder sind nur relevant, wenn Sie eine Lizenz für Statuskontrollen erworben und aktiviert haben.

### <a id="counter"></a>Zählerfeld

[Zähler][3] können zum Beispiel die Anzahl von Verkäufen innerhalb eines bestimmten Zeitraums oder das Datum des zuletzt abgeschlossenen Verkaufs angeben.

Zählerfelder finden Sie unter **Zähler (SAINT)** in der Liste der Kriterien.

1. Rechts neben den Feldern können Sie auf die Verknüpfungen klicken, um zusätzliche Kriterien für die Zähler anzugeben. Die verfügbaren Optionen hängen vom Typ des verwendeten Datensatzes und Zählers ab.

    * **SAINT-Typ**: Wählen Sie hier den Aktivitätstyp, nach dem Sie suchen möchten.
    * **Status**: Wählen Sie hier den Status des Datensatzes, nach dem Sie suchen möchten.
    * **Richtung**: Hier können Sie wählen, ob es sich um eine ein- oder ausgehende Aktivität handelt.
    * **Betragsklasse**: Wählen Sie hier die Betragsklasse des Verkaufs.
    * **Zweck**: Wählen Sie hier den Zweck der Aktivität.

1. Je nach der obigen Auswahl wird ein Listenfeld für ein Datumsfeld oder ein numerisches Feld angezeigt. Diese Listenfelder funktionieren wie oben beschrieben. Wählen Sie die erforderliche Option, und geben Sie im Textfeld den gewünschten numerischen Wert oder das Datum ein.

Die Zähler werden in Einstellungen und Verwaltung erstellt und verwaltet. Zählerfelder sind nur relevant, wenn Sie eine Lizenz für Statuskontrollen erworben und aktiviert haben.

## Arbeiten mit Suchkriterien

Die Kriterienliste enthält Standardkriterien, die Sie nach Bedarf bearbeiten oder entfernen können.

Wenn Sie die Ansicht **Suchen** öffnen, enthält diese die Standardsuchkriterien oder die Suchkriterien, die Sie bei Ihrer letzten Suche in diesem Dialogfeld angegeben haben. Um andere Suchkriterien als die angezeigten zu verwenden, haben Sie folgende Optionen:

| Aufgabe | Action |
|---|---|
| Suchkriterien verschieben | Klicken und ziehen Sie ![Symbol][img2]. |
| Suchkriterien ändern | Darauf klicken und ein anderes Kriterium aus der angezeigten Liste auswählen. |
| Ein oder mehrere Suchkriterien deaktivieren | Lassen Sie das Wertfeld leer. |
| Alle Suchkriterien deaktivieren | Klicken Sie auf **Alle löschen**. |
| Ein Suchkriterium zu löschen | Klicken Sie auf ![Symbol][img3]. |
| Standardsuchkriterien wiederherstellen | Klicken Sie **Auf Standard zurücksetzen**. |

> [!NOTE]
> Um Kriterien zu verschieben, ziehen Sie mit gedrückter Maustaste ![Symbol][img2]. Dies hat keine praktischen Auswirkungen auf die Suche, aber Sie können so die Kriterien in der gewünschten Reihenfolge anordnen. Wenn einige der Kriterien nicht verwendet werden, Sie sie aber beibehalten möchten, können Sie inaktive Kriterien in der Liste nach unten verschieben.
>
> Ein deaktiviertes Suchkriterium bleibt in der Kriterienliste erhalten und kann bei Bedarf einfach wieder aktiviert werden.

## Was möchten Sie jetzt tun?

* [Suchansicht verwenden][1]

<!-- Referenced links -->
[1]: find-screen.md
[2]: in-navigator.md
[3]: ../../saint/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/dropdown-icon.png
[img2]: ../../../media/icons/criteria-move.png
[img3]: ../../../../common/icons/delete-circle-red.png
