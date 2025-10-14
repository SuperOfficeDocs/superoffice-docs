---
uid: help-de-add-web-panel
title: Web-Bildschirm hinzufügen
description: So fügen Sie Elemente zur Web-Bildschirm-Liste in Einstellungen und Verwaltung hinzu.
keywords: Web-Bildschirm, Liste GUI - Web-Bildschirm
author: digitaldiina
date: 10.13.2025
version: 11.5
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: web panel
content_type: howto
language: de
index: true
redirect_from: /de/admin/lists/learn/web-panel-add-item
---

# Web-Bildschirm hinzufügen

[!include[Must be admin](../../../learn/includes/req-admin.md)]

Web-Bildschirme werden in der Liste **GUI - Web-Bildschirm** definiert, die Sie in **Einstellungen und Verwaltung** unter **Listen** verwalten können.

## Schritte

1. Wählen Sie <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listen** im Navigator.

1. Wählen Sie **GUI - Web-Bildschirm** aus dem Dropdown-Menü. Die Registerkarte **Elemente** zeigt alle vorhandenen Web-Bildschirme an.

1. Klicken Sie auf **Hinzufügen**, um das Dialogfeld **Listenelement bearbeiten** zu öffnen.

1. Geben Sie den gewünschten Namen für das Objekt in das Feld **Name** ein. *(Obligatorisch)*

    * Dieser Name wird angezeigt, wenn Sie die URL-Adresse in SuperOffice CRM hinzufügen.

1. Geben Sie im Feld **URL** die URL-Adresse an, wie zum Beispiel eine Webseite oder eine serverbasierte HTML-Datei. Für Details zu unterstützten URL-Typen siehe [Verwenden von HTTP vs HTTPS URLs](#https).

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

1. Klicken Sie auf **Speichern**, um die Änderungen zu speichern, oder auf **Abbrechen**, um sie zu verwerfen.

> [!TIP]
> Wenn Sie eine URL-Adresse hinzufügen, könnte es nützlich sein, Vorlagenvariablen für die aktive Firma zu verwenden, um zum Beispiel über eine URL Informationen von anderen Anwendungen abzurufen. Es müssen die URL-Adresse Parameter angegeben werden, wie in folgendem Beispiel: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn ist die Vorlagenvariable für die Organisationsnummer, andere Variablen wie Firmenname &lt;name&gt;, Firmentelefonnummer &lt;cpho&gt; und Personenname &lt;attn&gt; können ebenfalls verwendet werden.

## <a id="options"></a>Optionen

### Bildschirm

* **Firmenkarte**, **Personenkarte**, **Projektkarte**, **Selektionskarte** und **Verkaufskarte**: Oben auf der Registerkarte **www** der Ansichten Firma, Person, Projekt, Selektion und Verkauf wird eine Verknüpfung zur URL-Adresse eingefügt. Wenn Sie auf eine Verknüpfung in SuperOffice CRM klicken, wird die zugehörige Webseite in einem kleinen Fenster auf der Registerkarte angezeigt, in dem Sie einen Bildlauf durchführen können. Sie können anschließend auf **In separatem Fenster öffnen** klicken, um die Webseite in einem eigenen Browser-Fenster anzuzeigen.

* **Web-Bildschirm**: Die URL-Adresse wird im Web-Bildschirm in SuperOffice CRM hinzugefügt. Die Adresse kann anschließend als Internetseite geöffnet werden. Wurden mehrere URL-Adressen für den Web-Bildschirm definiert, werden sie rechts im Web-Bildschirm als Registerkarten angezeigt. Der Web-Bildschirm wird durch Klicken auf das SuperOffice-Logo oben links in SuperOffice CRM geöffnet.

* Bereichsregisterkarten in den Ansichten Firma, Person, Projekt und Verkauf: Die URL-Adresse wird als zusätzliche Bereichsregisterkarte in der Ansicht Firma/Person/Projekt/Lernen/Verkauf hinzugefügt. Wenn Sie die Bereichsregisterkarte in SuperOffice CRM auswählen, wird die URL geöffnet. Sie können anschließend auf **In separatem Fenster öffnen** klicken, um die Webseite in einem eigenen Browser-Fenster anzuzeigen.

### Dialogfeld

* **Dialogfeld für Folgeaufgaben**: Oben auf der Registerkarte **www** des Dialogfeld **Folgeaufgabe** wird eine Verknüpfung zur URL-Adresse eingefügt. Sie können anschließend auf **In separatem Fenster öffnen** klicken, um die Webseite in einem eigenen Browser-Fenster anzuzeigen.

* **Das Dialogfeld Dokument/Angebot/Produkt**: Oben auf der Registerkarte **www** des Dialogfelds wird eine Verknüpfung zur URL-Adresse eingefügt.

### Menü

* **Werkzeuge**: Die URL-Adresse wird angezeigt, wenn der Benutzer im Navigator auf die Schaltfläche **Tools** (<i class="ph ph-wrench" aria-hidden="true"></i>) oder in SuperOffice CRM auf **Andere Anwendungen** klickt.

* **Menü Ansicht**: Die URL-Adresse wird angezeigt, wenn der Benutzer die Option **Andere Anwendungen** in SuperOffice CRM wählt.

## <a id="fields"></a>Referenz

| Einstellung | Beschreibung |
|---|---|
| Name | UI-Beschriftung |
| Fenstername | ID des Panels, verwendet im HTML, das in die Panels geladen wird. Muss eindeutig sein, Präfixe verwenden |
| Beschreibung | Tooltip-Text |
| URL | Speicherort der Webseite |
| URL-Codierung | Keine, ANSI oder Unicode |
| Sichtbar in | Anzeigeposition |
| Verfügbar auf | Gerätetyp (Web, Mobil) |
| Anzeigen | Ob Menüleiste, Symbolleiste, Adressleiste und/oder Statusleiste angezeigt werden |

## <a id="https"></a>Verwenden von HTTP vs HTTPS URLs

[!include[HTTPS restriction](../../../admin/lists/learn/includes/web-panels-and-https.md)]

## Web-Bildschirm in Service hinzufügen (veraltet)

In Service werden Web-Bildschirme als **zusätzliche Browser-Tabs** bezeichnet. Sie können denselben Inhaltstyp hinzufügen wie bei [zusätzlichen Menüs][4].

1. Melden Sie sich bei SuperOffice Service an.
1. Wählen Sie im Hamburger-Menü **Systemdesign** und dann **Web-Bildschirme**.
1. Zeigen Sie auf die gewünschte Anzeigeposition und klicken Sie auf **Neuer Web-Bildschirm**.
1. Geben Sie eine UI-Beschriftung ein (der Text im Tab).
1. Wählen Sie entweder **URL verwenden** oder **Bildschirm verwenden** und dann die entsprechenden Details.
1. Wählen Sie in der Liste **Position** aus, wo das neue Menüelement eingefügt werden soll (0 = oben).
1. Klicken Sie auf **OK**.
1. Testen Sie das Ergebnis.

## Verwandte Inhalte

* [Menüpunkt "Aufgabe" hinzufügen][1]
* [Basisprogramme und URL-Parameter][5]

<!-- Referenced links -->
[1]: ../../../admin/lists/learn/add-items-to-task-menu.md
[2]: url-encoding.md
[3]: ../../../localization/learn/translate-fields.md
[4]: ../../../ui/blogic/learn/extra-menus/index.md
[5]: ../../../../en/ui/blogic/url-parameters.md

<!-- Referenced images -->