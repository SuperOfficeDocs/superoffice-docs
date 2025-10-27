---
uid: help-de-add-web-panel
title: Web-Bildschirm hinzufügen
description: So fügen Sie Elemente zur Web-Bildschirm-Liste in Einstellungen und Verwaltung hinzu.
keywords: Web-Bildschirm, Liste GUI - Web-Bildschirm
author: digitaldiina
date: 11.04.2025
version: 11.6
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

Web-Bildschirme werden in der Liste **GUI - Web-Bildschirm** definiert, die Sie in **Einstellungen und Verwaltung** unter **Listen** verwalten können. Wo Ihr Web-Bildschirm erscheint, wird durch *Sichtbar in* bestimmt. Der Inhalt Ihres Web-Bildschirms wird durch die URL bestimmt.

## Schritte

1. Wählen Sie <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listen** im Navigator.

1. Wählen Sie **GUI - Web-Bildschirm** aus dem Dropdown-Menü. Die Registerkarte **Elemente** zeigt alle vorhandenen Web-Bildschirme an.

1. Klicken Sie auf **Hinzufügen**, um das Dialogfeld **Listenelement bearbeiten** zu öffnen.

1. Geben Sie den gewünschten Namen für das Objekt in das Feld **Name** ein. *(Obligatorisch)*

    * Dieser Name wird angezeigt, wenn Sie die URL-Adresse in SuperOffice CRM hinzufügen.

1. Geben Sie im Feld **URL** die URL-Adresse an, wie zum Beispiel eine Webseite oder eine serverbasierte HTML-Datei. Für Details zu unterstützten URL-Typen siehe [Verwenden von HTTP vs HTTPS URLs](#https).

1. Geben Sie im Feld **Fenstername** den Namen für das Browser-Fenster ein, in dem die URL-Adresse geöffnet werden soll. Falls Sie bereits einen oder mehrere Fensternamen hinzugefügt haben und sie erneut verwenden möchten, können Sie auf das Feld klicken und einen Namen in der Liste auswählen. Sie können auch einen neuen Namen direkt in das Feld eingeben. Der künftig angezeigte Fenstername wird als unterstrichener Text unter dem Feld angezeigt.

1. Wählen Sie im Listenfeld **Sichtbar in** aus, wo der Web-Bildschirm in SuperOffice CRM angezeigt werden soll.

    * Sie können zwischen Panels, Dialogen, Menüs, Symbolleiste oder Seitenleisten-Standorten wählen.
    * Für eine vollständige Liste der Anzeigeoptionen, siehen Sie [Anzeigeorte für Web-Bildschirme][8].

1. Im Listenfeld **URL-Verschlüsselung** können Sie auswählen, ob die [URL][2] das Format ANSI oder Unicode (oder kein Format) haben soll.

1. Wählen Sie unter **Verfügbar auf**, wo die URL-Adresse verfügbar sein soll. Sie können mehrere Optionen gleichzeitig auswählen.
    * **SuperOffice CRM for Web**: Bei Verwendung der Web-Version von SuperOffice CRM.
    * **Mobile CRM**: Bei Verwendung der mobilen Version von SuperOffice CRM.

    Zusatzeinstellungen:
    * Den Inhalt bei Navigation zwischen Registerkarten **immer neu laden**.
    * **Link anzeigen**, um die Öffnung in separatem Fenster zu ermöglichen.

1. Klicken Sie auf die Liste **Symbol**, um ein Symbol für den Web-Bildschirm auszuwählen.

1. Geben Sie optional in das Feld **Beschreibung** eine Beschreibung für das Objekt ein. Lesen Sie mehr über die [Übersetzung][3].

1. Klicken Sie auf **Speichern**, um die Änderungen zu speichern, oder auf **Abbrechen**, um sie zu verwerfen.

## Nach dem Speichern

Sobald das Objekt gespeichert ist, können Sie:

* Die Reihenfolge der Objekte mit den Pfeilschaltflächen links von der Liste ändern (<i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i>).

* Zusätzliche Einstellungen für jedes Objekt festlegen:
  * Für welche [Benutzergruppen das Objekt sichtbar ist][7].
  * Unter welcher [Überschrift][6] es angezeigt wird.

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

### <a id="https"></a>Verwenden von HTTP vs HTTPS URLs

[!include[HTTPS restriction](../../../admin/lists/learn/includes/web-panels-and-https.md)]

### Verwenden von Template-Variablen

Wenn Sie eine URL-Adresse hinzufügen, kann es nützlich sein, Template-Variablen für das aktive Unternehmen zu verwenden, um beispielsweise Informationen von anderen Anwendungen über eine URL abzurufen. Die URL-Adresse muss Parameter angeben, wie in diesem fiktiven Beispiel: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn ist hier die Template-Variable für die Organisationsnummer, aber auch andere Variablen wie Firmenname &lt;name&gt;, Firmentelefonnummer &lt;cpho&gt;, Kontaktname &lt;attn&gt; können verwendet werden.

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
[6]: ../../../admin/lists/learn/organize/headings.md
[7]: ../../../admin/lists/learn/organize/user-group-filtering.md
[8]: index.md

<!-- Referenced images -->