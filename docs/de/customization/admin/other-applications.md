---
uid: help-de-other-applications
title: Externe Anwendungen hinzufügen
description: Externe Anwendungen zur Liste Anwendung hinzufügen
keywords: Externe Anwendungen, Liste GUI - Anwendung
author: digitaldiina
date: 10.28.2025
version: 10.5
content_type: howto
category: customization
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: 
  - /de/admin/lists/learn/applications
  - /de/admin/lists/learn/adding-external-applications-to-application-list
language: de
---

# Externe Anwendungen hinzufügen

Sie können Verknüpfungen zu externen Anwendungen in SuperOffice CRM einrichten, sodass Sie diese direkt von SuperOffice CRM for Windows öffnen können. Sie definieren, welche URL-Adressen den Benutzern in der Ansicht **Listen** in Einstellungen und Verwaltung zur Verfügung stehen.

> [!NOTE]
> Dateien oder Anwendungen, die lokal ausgeführt werden müssen (zum Beispiel Dateien mit der Erweiterung exe), sind nicht über SuperOffice CRM for Web zugreifbar.

## Schritte

1. Wählen Sie <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listen** im Navigator.

1. Wählen Sie **GUI - Anwendung** aus dem Dropdown-Menü.

1. Klicken Sie unter der Liste Objekte auf die Schaltfläche **Hinzufügen**.

1. Geben Sie den gewünschten Namen für das Objekt in das Feld **Name** ein. Dieser Name wird dort angezeigt, wo Sie die Anwendung in SuperOffice CRM einfügen (siehe Schritt 7 in Bezug auf das Listenfeld **Anzeigen**). *(Obligatorisch)*

1. Wählen Sie unter **Hinzufügen als** aus, in welcher Form die Anwendung hinzugefügt werden soll:

    * **Schaltfläche**: Das Anwendungssymbol wird im Navigator angezeigt. Benutzer können die Anwendung dann durch Klicken auf das Symbol im Navigator direkt öffnen.
    * **Menüpunkt**: Der Benutzer kann auf die Anwendung zugreifen, indem er im Navigator auf die Schaltfläche **Tools** (<i class="ph ph-wrench" aria-hidden="true"></i>) klickt und/oder im Hauptmenü (<i class="ph ph-list" aria-hidden="true"></i>) die Option **Andere Anwendungen** auswählt.
    * **Ereignis**: Die Anwendung wird ausgeführt, wenn SuperOffice CRM aufgerufen bzw. geschlossen wird oder bei einer lokalen Aktualisierung (Travel). Siehe Schritt 8. Sie können zum Beispiel ein Synchronisationsprogramm für einen PDA ausführen, wenn SuperOffice CRM geschlossen wird.
    * **Aufgabe**: Wählen Sie eine Option aus diesem Listenfeld aus, um die Anwendung von der Registerkarte **Aufgabe** in der Ansicht Selektion oder über die Schaltflächen **Aufgabe** verfügbar zu machen.

        <details><summary>Suchen Sie mehr Infos über die verschiedenen Optionen.</summary>

        Die Namen in Klammern geben die Bereichsregisterkarte an, in der die Anwendung verfügbar ist.

        Beispiele:

        * **Selektion - Verkauf (Verkäufe)**: Nachdem Sie eine Verkaufsselektion in der Ansicht Selektion geöffnet haben und die Bereichsregisterkarte **Verkäufe** aktiviert ist, wird die Anwendung als Aufgabe auf der Registerkarte **Aufgabe** angezeigt.
        * **Selektion - Verkauf (Firmen)**: Nachdem Sie eine Verkaufsselektion in der Ansicht Selektion geöffnet haben und die Bereichsregisterkarte **Firmen** aktiviert ist, wird die Anwendung als Aufgabe auf der Registerkarte **Aufgabe** angezeigt.
        * **Selektion - Verkauf (extern)**: Falls Ihre SuperOffice CRM-Installation mit der Anwendung eines Drittanbieters verknüpft ist, können für die einzelnen Selektionen andere Bereichsregisterkarten angezeigt werden. Sie können dann zum Beispiel die Option **Selektion - Verkauf (extern)** auswählen, um die Anwendung als Aufgabe auf der Registerkarte **Aufgabe** anzuzeigen, wenn Sie eine Verkaufsselektion in der Ansicht Selektion öffnen und die Bereichsregisterkarte der Drittanwendung aktiv ist.

        Weitere Optionen:

        * **Symbolleiste**: Die Anwendung wird als Option in der Symbolleiste angezeigt. Die Benutzer müssen zunächst die Werkzeugleiste in SuperOffice CRM konfigurieren und festlegen, dass die Anwendung angezeigt werden soll.

        * **Dialogfeld Folgeaufgabe**: Die Anwendung wird als Option unter der Schaltfläche **Aufgabe** im Dialogfeld für Folgeaufgaben angezeigt.

        * **Dialogfeld Dokument**: Die Anwendung wird als Option unter der Schaltfläche **Aufgabe** im ausgewählten Dialogfeld angezeigt. Dieselbe Option steht für die Ansichten Person, Angebot und Produkt zur Verfügung.

        </details>

    > [!NOTE]
    > Die Optionen, die Sie unter **Hinzufügen als** wählen, bestimmen, welche Optionen im übrigen Dialogfeld verfügbar sind.

1. Wählen Sie unter **Verfügbar auf**, wo die Anwendung verfügbar ist. Sie können mehrere Optionen gleichzeitig auswählen.

    * **Zentrale Datenbank**: Beim Arbeiten in der zentralen Datenbank
    * **Satellite**: Beim Arbeiten mit einem Satelliten
    * **Travel**: Beim Arbeiten mit einer lokalen Datenbank und der Travel-Funktion

1. Geben Sie die gewünschte Anwendung in das Feld **Dateiname** ein.

1. Geben Sie in das Feld **Parameter** Startparameter für die Anwendung ein.

1. Im Feld **Arbeitsverzeichnis** können Sie angeben, welches Verzeichnis bei Ausführung des Programms das aktuelle Verzeichnis sein soll. Geben Sie den Pfad manuell ein. Dieses Feld bleibt im Allgemeinen leer.

1. Wählen Sie im Listenfeld **Anzeigen** die gewünschte Option. Das Listenfeld wird nur angezeigt, wenn Sie **Menüpunkt** unter **Hinzufügen als** ausgewählt haben.

    * **Werkzeuge**: Der Benutzer kann auf die Anwendung zugreifen, indem er im Navigator auf die Schaltfläche **Tools** klickt oder im Hauptmenü von SuperOffice CRM die Option **Andere Anwendungen** auswählt.
    * **Menü 'Ansicht'**: Der Benutzer kann über die Option **Andere Anwendungen** im Menü **Ansicht** von SuperOffice CRM auf die Anwendung zugreifen.

1. Wählen Sie im Listenfeld **Ausführen, wenn** aus, wenn die Anwendung ausgeführt werden soll. Das Listenfeld wird nur angezeigt, wenn Sie **Ereignis** unter **Hinzufügen als** ausgewählt haben.

    * **SuperOffice CRM wird gestartet**: Die Anwendung wird ausgeführt, wenn SuperOffice CRM gestartet wird.
    * **SuperOffice CRM wird beendet**: Die Anwendung wird ausgeführt, wenn SuperOffice CRM geschlossen wird.
    * **Lokale Aktualisierung**: Die Anwendung wird ausgeführt, wenn Travel verwendet wird.

1. Aktivieren Sie die Option **Auf Beenden der Anwendung warten**, wenn SuperOffice CRM auf das Schließen der externen Anwendung warten soll, bevor es beendet wird. Wenn Sie dieses Kontrollkästchen nicht aktivieren, können Sie SuperOffice CRM beenden, ohne die externe Anwendung zu schließen. Das Listenfeld wird nur angezeigt, wenn Sie **Ereignis** unter **Hinzufügen als** ausgewählt haben.

1. Unter **Startmodus** können Sie wählen, in welchem Fenstertyp die Anwendung gestartet wird: Maximiert, Minimiert oder Wiederhergestellt.

1. Wählen Sie im Feld **Symbol** das Symbol aus, das im Navigator in SuperOffice CRM für die Anwendung angezeigt werden soll (siehe Schritt 7 in Bezug auf das Listenfeld **Anzeigen**). Das Listenfeld wird nur angezeigt, wenn Sie **Schaltfläche** unter **Hinzufügen als** ausgewählt haben.

    * **Aus der Bibliothek**: Wählen Sie eines der verfügbaren Symbole in der Liste aus.
    * **Programmsymbol verwenden**: Verwenden Sie das Standardsymbol für die ausgewählte Anwendung.

1. Geben Sie optional in das Feld **Beschreibung** eine Beschreibung für das Objekt ein.

1. Klicken Sie auf **Speichern**. Das Objekt wird zur Liste **Objekte** hinzugefügt. Wiederholen Sie diesen Vorgang, wenn Sie weitere Objekte hinzufügen möchten.

> [!NOTE]
> Benutzer müssen sich erneut bei SuperOffice CRM anmelden, um die Anwendung anzuzeigen.

## Nach dem Speichern

Nachdem dem Hinzufügen von Objekten können Sie für jedes einzelne Objekt Details festlegen. Sie können Folgendes festlegen:

* Für welche [Benutzergruppen ist das Objekt sichtbar][2].
* Unter welcher [Überschrift][1] es angezeigt wird.

Die Objekte werden in der Reihenfolge angezeigt, in der Sie sie eingegeben haben. Wenn Sie die Reihenfolge ändern möchten, wählen Sie das gewünschte Objekt aus und verschieben Sie es mit den Pfeiltasten links von der Liste (<i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i>) nach oben oder unten.

<!-- Referenced links -->
[1]: ../../admin/lists/learn/organize/headings.md
[2]: ../../admin/lists/user-group-filtering.md
