---
uid: help-de-project-create
title: Ein neues Projekt erstellen
description: Wie man ein Projekt erstellt und bei der Arbeit noch besser organisiert ist.
keywords: Projekt erstellen, neues Projekt, Projekt hinzufügen, Registerkarte Projekt, Projekt
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Ein neues Projekt erstellen

Sie können in SuperOffice CRM ein Projekt über die Schaltfläche **Neu** in der oberen Leiste hinzufügen. Sehen Sie sich dieses Video an oder befolgen Sie die unten stehenden Schritte, um zu lernen, wie Sie ein Projekt erstellen:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/zLJwNll223w]

(Videolänge – 2:49)

## Schritte

1. Klicken Sie auf **Neu** in der oberen Leiste und wählen Sie **Projekt**.

1. Geben Sie einen **Projektnamen** ein (Pflichtfeld, rot markiert).

    Wenn der Projektname bereits existiert, wird das Dialogfeld **Duplikate** angezeigt, um doppelte Einträge zu vermeiden.

    ![Die Projektansicht im Bearbeitungsmodus mit Projektdetails -screenshot][img1]

1. Verwenden Sie das große Textfeld, um eine detaillierte Übersicht oder Zusammenfassung des Projekts einzugeben. Dies ist das Feld **Beschreibung**.

1. Wählen Sie den **Typ** des Projekts aus (Pflichtfeld). Die verfügbaren Werte sind in **Einstellungen und Verwaltung** vordefiniert.

1. **Optional: Geben Sie zusätzliche Informationen in der Registerkarte Projekt ein:**
    * Fügen Sie eine **Website**-Adresse und einen Titel hinzu.
    * Wählen Sie einen **Verantwortlichen** für das Projekt aus.
    * Wählen Sie den **Status** des Projekts. Werte sind in **Einstellungen und Verwaltung** vordefiniert.
    * Legen Sie ein **Enddatum** mit dem Kalenderauswahl-Tool fest.

1. **Weitere Details hinzufügen:**
    * Wechseln Sie zur Registerkarte **Mehr**, um [benutzerdefinierte Felder einzugeben][12].
    * Wechseln Sie zur Registerkarte **Bild**, um [ein Projektbild hochzuladen und festzulegen][2].
    * Wechseln Sie zur Registerkarte **Notiz**, um [Notizen hinzuzufügen][11].
    * Wechseln Sie zur Registerkarte **Verknüpfungen**, um [Aktivitäten, Verkäufe, Dokumente oder Websites mit dem Projekt zu verbinden][10].

1. Klicken Sie auf **Speichern**, um die Projektdetails zu speichern. Sie können nun [Projektmitglieder hinzufügen][5].

## <a id="fields"></a>Wichtige Felder erklärt

Die folgenden Felder sind auf der Projektkarte verfügbar. Einige Felder werden automatisch ausgefüllt, während andere manuell eingetragen werden müssen.

> [!NOTE]
> Felder und Layout können je nach Konfiguration im [Ansichtsdesigner][13] und anderen UI-Anpassungen variieren.

* **Projektname:** Der Hauptidentifikator des Projekts. Dies ist ein *Pflichtfeld*.
* **Nummer:** Wird automatisch als nächste verfügbare Projektnummer generiert, wenn diese Funktion in **Einstellungen und Verwaltung** aktiviert ist. Kann bei Bedarf manuell geändert werden.
* **Website:** Hier können Sie Webadressen mit kurzen Beschreibungen hinzufügen. Klicken Sie außerhalb der Tabelle oder drücken Sie **TAB**, um die Eingabe abzuschließen.
* **Beschreibung:** Zusammenfassung der Projektziele, des Umfangs oder Zwecks. Optional, aber nützlich für die Nachverfolgung.
* **Verantwortlicher:** Weist eine verantwortliche Person für das Projekt zu. Wenn Sie auf den Pfeil klicken, öffnet sich eine Liste mit Benutzern, Benutzergruppen und Ressourcen in der Datenbank.
* **Typ:** Vordefinierte Projekttypen. Einige Typen können mit einem [Projektleitfaden][1] verknüpft sein. *Pflichtfeld*.
* **Status:** Verfolgt den aktuellen Stand des Projekts (z. B. Geplant, In Bearbeitung, Abgeschlossen). Falls ein Projektleitfaden verknüpft ist, erscheinen spezifische Statusoptionen.
* **Enddatum:** Gibt das erwartete Enddatum des Projekts an. Kann bei Bedarf angepasst werden.
* **Nächster Meilenstein:** Falls das Projekt mit einem Leitfaden verknüpft ist, zeigt dieses Feld das Datum der nächsten geplanten Folgeaufgabe an. Das Datum wird automatisch basierend auf verknüpften Aktivitäten oder dem Projektleitfaden berechnet. Falls kein Leitfaden vorhanden ist, wird das Enddatum des Projekts angezeigt. Vergangene Daten werden rot markiert.

[!include[3 udef](../../learn/includes/more-udef.md)]

## Duplikaterkennung

Falls der Projektname mit einem bestehenden Eintrag übereinstimmt oder diesem ähnelt, hilft das **Duplikate**-Dialogfeld, [Doppelungen zu vermeiden][6]. Überprüfen Sie die Vorschläge und fahren Sie entsprechend fort.

## Verwandte Inhalte

* [Projektbild hinzufügen oder ändern][2]
* [Projektmitglieder hinzufügen][5]
* [Projekte bearbeiten][7]
* [Projekte zusammenführen][8]
* [Projekte löschen][9]
* [Projektleitfäden][1]
* [Aktivitäten][3]

<!-- Referenced links -->
[5]: project-members/add.md
[2]: add-image.md
[7]: edit.md
[8]: merge-projects.md
[9]: delete.md
[1]: project-guides.md
[3]: ../../learn/basics/activity.md
[6]: ../../learn/basics/duplicates.md
[10]: ../../learn/basics/links.md
[11]: ../../learn/basics/notes.md
[12]: ../../custom-objects/learn/more-tab.md
[13]: ../../ui/screen-designer/learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/create-project.png
