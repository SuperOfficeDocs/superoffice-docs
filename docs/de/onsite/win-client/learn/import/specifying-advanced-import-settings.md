---
uid: help-de-specifying-advanced-import-settings
title: Erweiterte Importeinstellungen festlegen
description: Erweiterte Importeinstellungen festlegen
author: SuperOffice RnD
date: 06.29.2022
keywords: Einstellungen für den Windows-Client
content_type: howto
language: de
client: win
deployment: onsite
---

# Erweiterte Importeinstellungen festlegen

Die erweiterten Importeinstellungen umfassen Einstellungen für Datumsformat und Trennzeichen. Sie dienen dazu sicherzustellen, dass SuperOffice die Importdatei richtig interpretiert.

> [!NOTE]
> Um die Felder von der Importdatei richtig zuzuordnen, müssen Sie gegebenenfalls die Einstellungen für Textbegrenzungszeichen, Feldbegrenzung und Zeilenbegrenzung bearbeiten.

1. [!include[How to open import](includes/open-import.md)]

1. [!include[Select file](includes/step-select-file.md)]

1. Klicken Sie auf die Schaltfläche **Erweitert**.

1. Wählen Sie im Dialogfeld **Erweiterte Optionen** ein vordefiniertes Format vom Listenfeld **Datumsformat** aus. Sie können keine Monatsnamen verwenden, sondern nur Zahlen.

    > [!NOTE]
    > **Native ID** steht für ein SuperOffice-Datum. SuperOffice zählt die Sekunden seit dem 01.01.1970\. Diese Zahl entspricht dem Wert unter **Native ID**.

1. Wählen Sie im Listenfeld **Nummernformat** eine der vordefinierten Optionen für Dezimaltrennzeichen aus.

1. Geben Sie im Feld **Kontrollkästchenformat** das oder die Zeichen ein, die in der Importdatei zur Angabe eines aktivierten Kontrollkästchens verwendet werden.

1. Geben Sie im Feld **Textbegrenzungszeichen** das Zeichen ein, das in der Importdatei normalen Text einschließen soll.

    > [!NOTE]
    > Textbegrenzungszeichen überschreiben alle Feld- und Zeilentrennzeichen (siehe unten). Wenn es zum Beispiel eine Feldbegrenzung zwischen zwei Textbegrenzungszeichen gibt, wird es als reiner Text interpretiert. Wenn Ihre Importdateien jedoch Feld- oder Zeilenbegrenzungszeichen enthalten, sind keine Textbegrenzungszeichen erforderlich.

1. Wählen Sie im Listenfeld **Feldbegrenzung** eine der vordefinierten Optionen für die Zeichen aus, die Felder voneinander trennen.

1. Wählen Sie im Listenfeld **Zeilenbegrenzung** eine der vordefinierten Optionen für die Zeichen aus, die Zeilen voneinander trennen.

1. Wählen Sie im Listenfeld **Mitarbeiterformatierung** eines der vordefinierten Formate zur Interpretation von Namen in der Importdatei aus, beispielsweise, ob zum Beispiel der Vorname vor dem Nachnamen steht.

    > [!NOTE]
    > **Native ID** steht für die in der Datenbank erfasste **Mitarbeiter** des Mitarbeiters. Wird eine solche ID nicht gefunden, wird der Inhalt des Felds **Voreinstellung Mitarbeiter** verwendet.

1. Legen Sie im Listenfeld **Voreinstellung Mitarbeiter** fest, welcher Name als Standardname eingetragen werden soll, wenn die SuperOffice-Datenbank die Mitarbeiterformatierung nicht in der Importdatei interpretieren kann.

1. Wählen Sie im Listenfeld **Länderformat** eines der vordefinierten Formate von der Länderinterpretation aus, wenn der Ländername zum Beispiel lokalisiert wird oder auf Englisch bleibt).

    > [!NOTE]
    > **Native ID** steht für die in der Datenbank erfasste **Land_ID**.

1. Legen Sie im Listenfeld **Standardland** fest, welches Land eingetragen werden soll, wenn die SuperOffice-Datenbank das Länderformat nicht in der Importdatei interpretieren kann.

1. Legen Sie im Listenfeld **Währung** fest, welche Währung eingetragen werden soll, wenn die SuperOffice-Datenbank das Währungsformat nicht in der Importdatei interpretieren kann.

1. Aktivieren Sie die Option **Volltextindex aktualisieren**, wenn Sie den Volltextindex während des Imports kontinuierlich aktualisieren möchten, damit er bei Fertigstellung des Importvorgangs vollständig aktualisiert ist.

    > [!NOTE]
    > Wenn Sie die Option **Volltextindex aktualisieren** aktivieren, wird die Importgeschwindigkeit verringert. Um größere Datenmengen zu importieren, können Sie zum Beispiel als Alternative den Import ohne diese Option durchführen und später in der Ansicht **Optionen** einen [neuen Volltextindex erstellen][2].

1. Nachdem Sie die erforderlichen Einstellungen angegeben haben, klicken Sie auf **OK**.

    [!include[Save mapping](includes/tip-save-mapping.md)]

> [!NOTE]
> Wenn Sie im Feld **Importbeschreibung laden** eine Importdatei festgelegt haben, sind bereits Informationen in das Dialogfeld **Erweiterte Optionen** eingetragen. Sie können diese Informationen jedoch wie oben beschrieben ändern. Denken Sie daran, dass die Importbeschreibungsdatei gespeichert werden muss, bevor sie mit neuen Optionen aktualisiert werden kann.

<!-- Referenced links -->
[2]: ../../../../admin/options/learn/freetext-search/regenerate-index.md

<!-- Referenced images -->
