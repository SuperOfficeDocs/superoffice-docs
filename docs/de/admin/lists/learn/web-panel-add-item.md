---
uid: help-de-adding-items-to-web-panel-list
title: Objekte zur Liste Web-Bildschirm hinzufügen
description: Objekte zur Liste Web-Bildschirm hinzufügen
author: SuperOffice RnD
so.date: 01.20.2023
keywords: Liste, Web-Bildschirm
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: de
---

# Objekte zur Liste GUI - Web-Bildschirm hinzufügen

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

## Wie man Felder ausfüllt, wenn es sich bei den Objekten um URL-Adressen handelt

1. Geben Sie den gewünschten Namen für das Objekt in das Feld **Name** ein. Dieser Name wird angezeigt, wenn Sie die URL-Adresse in SuperOffice CRM hinzufügen.

    > [!include[Mandatory](includes/note-mandatory-field.md)]

1. Geben Sie im Feld **URL** die URL-Adresse an, wie zum Beispiel eine Webseite oder eine serverbasierte HTML-Datei. Siehe die Informationen oben bezüglich der Verwendung von HTTP-/HTTPS-URLs.

1. Geben Sie im Feld **Fenstername** den Namen für das Browser-Fenster ein, in dem die URL-Adresse geöffnet werden soll. Falls Sie bereits einen oder mehrere Fensternamen hinzugefügt haben und sie erneut verwenden möchten, können Sie auf das Feld klicken und einen Namen in der Liste auswählen. Sie können auch einen neuen Namen direkt in das Feld eingeben. Der künftig angezeigte Fenstername wird als unterstrichener Text unter dem Feld angezeigt.

1. Wählen Sie im Listenfeld **Sichtbar in** aus, an welcher Stelle in SuperOffice CRM auf die URL-Adresse zugegriffen werden kann.
    * **Seitenleiste**: Bei Auswahl dieser Option werden die URL-Adressen auf den Seitenleisten in SuperOffice CRM verfügbar.

    * **Symbolleiste**: Bei Auswahl dieser Option wird die URL als Schaltfläche auf der Symbolleiste verfügbar.

    * **Schaltfläche Navigator**: Bei Auswahl dieser Option wird die URL als Schaltfläche im Navigator in SuperOffice CRM verfügbar.

    * **Bildschirm**: Wählen Sie [eine Option aus dieser Liste](#options) auswählen, um die URL als Bildschirm/Registerkarte in SuperOffice CRM zugänglich zu machen.

    * **Dialogfeld**: Wählen Sie [eine Option in dieser Liste](#options) aus, um die URL-Adresse in einem Dialogfeld verfügbar zu machen.

    * **Menü**: Wählen Sie [eine Option in dieser Liste](#options) aus, um die URL in einem der Menüs in SuperOffice CRM zugänglich zu machen.

1. Im Listenfeld **URL-Verschlüsselung** können Sie auswählen, ob die [URL][2] das Format ANSI oder Unicode (oder kein Format) haben soll.

1. Wählen Sie unter **Anzeigen** die Leisten aus, die im Browser, in dem die URL-Adresse geöffnet wird, zur Verfügung stehen sollen: Menüleiste, Symbolleiste, Adressleiste oder Statusleiste.

1. Wählen Sie unter **Verfügbar auf**, wo die URL-Adresse verfügbar sein soll. Sie können mehrere Optionen gleichzeitig auswählen.
    * **SuperOffice CRM for Web**: Bei Verwendung der Web-Version von SuperOffice CRM.
    * **Mobile CRM**: Bei Verwendung der mobilen Version von SuperOffice CRM.

    Zusatzeinstellungen:
    * Den Inhalt bei Navigation zwischen Registerkarten **immer neu laden**.
    * **Link anzeigen**, um die Öffnung in separatem Fenster zu ermöglichen.

1. Klicken Sie auf die Liste **Symbol**, um ein Symbol für den Web-Bildschirm auszuwählen.

1. Geben Sie optional in das Feld **Beschreibung** eine Beschreibung für das Objekt ein. Lesen Sie mehr über die [Übersetzung][3].

1. [!include[Save or cancel](includes/save-or-cancel.md)]

> [!TIP]
> Wenn Sie eine URL-Adresse hinzufügen, könnte es nützlich sein, Vorlagenvariablen für die aktive Firma zu verwenden, um zum Beispiel über eine URL Informationen von anderen Anwendungen abzurufen. Es müssen die URL-Adresse Parameter angegeben werden, wie in folgendem Beispiel: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn ist die Vorlagenvariable für die Organisationsnummer, andere Variablen wie Firmenname &lt;name&gt;, Firmentelefonnummer &lt;cpho&gt; und Personenname &lt;attn&gt; können ebenfalls verwendet werden.

## <a id="options" />Optionen

### Bildschirm

* **Firmenkarte**, **Personenkarte**, **Projektkarte**, **Selektionskarte** und **Verkaufskarte**: Oben auf der Registerkarte **www** der Ansichten Firma, Person, Projekt, Selektion und Verkauf wird eine Verknüpfung zur URL-Adresse eingefügt. Wenn Sie auf eine Verknüpfung in SuperOffice CRM klicken, wird die zugehörige Webseite in einem kleinen Fenster auf der Registerkarte angezeigt, in dem Sie einen Bildlauf durchführen können. Sie können anschließend auf **In separatem Fenster öffnen** klicken, um die Webseite in einem eigenen Browser-Fenster anzuzeigen.

* **Web-Bildschirm**: Die URL-Adresse wird im Web-Bildschirm in SuperOffice CRM hinzugefügt. Die Adresse kann anschließend als Internetseite geöffnet werden. Wurden mehrere URL-Adressen für den Web-Bildschirm definiert, werden sie rechts im Web-Bildschirm als Registerkarten angezeigt. Der Web-Bildschirm wird durch Klicken auf das SuperOffice-Logo oben links in SuperOffice CRM geöffnet.

* Bereichsregisterkarten in den Ansichten Firma, Person, Projekt und Verkauf: Die URL-Adresse wird als zusätzliche Bereichsregisterkarte in der Ansicht Firma/Person/Projekt/Lernen/Verkauf hinzugefügt. Wenn Sie die Bereichsregisterkarte in SuperOffice CRM auswählen, wird die URL geöffnet. Sie können anschließend auf **In separatem Fenster öffnen** klicken, um die Webseite in einem eigenen Browser-Fenster anzuzeigen.

### Dialogfeld

* **Dialogfeld für Folgeaufgaben**: Oben auf der Registerkarte **www** des Dialogfeld **Folgeaufgabe** wird eine Verknüpfung zur URL-Adresse eingefügt. Sie können anschließend auf **In separatem Fenster öffnen** klicken, um die Webseite in einem eigenen Browser-Fenster anzuzeigen.

* **Das Dialogfeld Dokument/Angebot/Produkt**: Oben auf der Registerkarte **www** des Dialogfelds wird eine Verknüpfung zur URL-Adresse eingefügt.

### Menü

* **Werkzeuge**: Die URL-Adresse wird angezeigt, wenn der Benutzer im Navigator auf die Schaltfläche **Tools** ![Symbol][img1] oder in SuperOffice CRM auf **Andere Anwendungen** klickt.

* **Menü Ansicht**: Die URL-Adresse wird angezeigt, wenn der Benutzer die Option **Andere Anwendungen** in SuperOffice CRM wählt.

## Ist SuperOffice CRM for Web auf einer HTTPS-Seite installiert?

[!include[HTTPS restriction](includes/web-panels-and-https.md)]

## Verwandte Themen

* [Menüpunkt "Aufgabe" hinzufügen][1]
* [Übersetzung hinzufügen][3]

<!-- Referenced links -->
[1]: add-items-to-task-menu.md
[2]: ../../../../en/ui/web-panels/url-encoding.md
[3]: ../../../globalization-and-localization/learn/translate-fields.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-tools.png
