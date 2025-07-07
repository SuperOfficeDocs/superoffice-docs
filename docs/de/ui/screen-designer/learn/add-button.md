---
uid: help-de-screen-designer-button
title: Schaltfläche oder Link hinzufügen
description: So fügen Sie mit dem Ansichtsdesigner in Einstellungen und Verwaltung eine Schaltfläche oder einen Link zu einem Layout hinzu.
keywords: Ansichtsdesigner, Benutzeroberfläche, Layout, Schaltfläche, Link
author: Bergfrid Dias
date: 10.07.2024
version: 10.3.7
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Schaltfläche oder Link hinzufügen

[!include[Anforderung](../../../includes/req-dev-tools.md)]

Benutzerdefinierte Schaltflächen und Links werden im **Vorschau**-Bereich hinzugefügt, wenn Sie ein Layout bearbeiten. Die URL wird verwendet, um eine Webseite im aktuellen oder neuer Registerkarte zu öffnen, ein CRMScript von der Ansicht auszuführen oder mit [SoProtocol][3] zu anderen Teilen von SuperOffice zu navigieren.

Schaltflächen und Links funktionieren ähnlich. Der Unterschied besteht darin, dass Sie eine Schaltfläche gestalten können, einen Link jedoch nicht.

> [!TIP]
> Sie können [Vorlagenvariablen][1] in den URLs nutzen.

Die folgenden Anweisungen gehen davon aus, dass Sie bereits das [Layout bearbeiten][4].

## Schaltfläche hinzufügen

1. Wählen Sie die Registerkarte, die Sie bearbeiten möchten.

1. Wählen Sie den Abschnitt **Elemente** auf der linken Seite.

1. Klicken und ziehen Sie das Element **Schaltfläche** ins Layout.

1. Klicken Sie, um die neue Schaltfläche auszuwählen.

1. Ersetzen Sie im Abschnitt **Einstellungen** den Text "Schaltfläche" durch den neuen Schaltflächennamen.

    ![Ansichtsdesigner, Einstellungen für Schaltflächenelement -screenshot][img1]

    > [!TIP]
    > Sie können den Schaltflächennamen auch in anderen Sprachen hinzufügen.

1. Wählen Sie in der Liste **Aktion** die Aktion aus, die beim Klicken auf die Schaltfläche ausgeführt werden soll. Weitere Informationen zu jeder Aktion finden Sie im Referenzabschnitt am Ende dieser Seite.

    * Website öffnen: Wählen Sie diese Option, um einen Link zu einer Website hinzuzufügen. Wählen Sie bei Bedarf die URL-Codierung und das Ziel aus.

    * CRMScript ausführen: Wählen Sie diese Option, um ein [CRMScript][2] hinzuzufügen, um bestimmte Aktionen in SuperOffice auszuführen.

    * Shortcut ([SoProtocol][3]): Wählen Sie diese Option, um eine Steuerung hinzuzufügen, die beim Klicken zu einem anderen Bereich oder Bildschirm in SuperOffice navigiert.

1. Wählen Sie in der Liste **Modus**, ob die Schaltfläche immer verfügbar sein soll oder nur im Lese- oder Bearbeitungsmodus.

1. Wählen Sie in der Liste **Stil** das Design der Schaltfläche aus.

## <a id="link"></a>Links hinzufügen

1. Wählen Sie die Registerkarte, die Sie bearbeiten möchten.

1. Wählen Sie den Abschnitt **Elemente** auf der linken Seite.

1. Klicken und ziehen Sie das Element **Link** ins Layout.

1. Klicken Sie, um das neue Link-Feld auszuwählen.

1. Ersetzen Sie im Abschnitt **Einstellungen** den Text "Link" durch den neuen Linknamen.

    > [!TIP]
    > Sie können den Linknamen auch in anderen Sprachen hinzufügen.

1. Wählen Sie in der Liste **Aktion** die Aktion aus, die beim Klicken auf den Link ausgeführt werden soll. (Gleiche Liste wie bei den Schaltflächen.)

1. Wählen Sie in der Liste **Modus**, ob der Link immer verfügbar sein soll oder nur im Lese- oder Bearbeitungsmodus.

## Übersetzung von Beschriftungen

Der Name und der Quickinfo-Text können in andere Sprachen übersetzt werden.

Wenn das Element ausgewählt ist:

1. Klicken Sie auf <i class="ph ph-translate" aria-label="Translate"></i> neben der Beschriftung.
1. Klicken Sie auf **Hinzufügen** und wählen Sie eine Sprache aus der Liste aus.
1. Geben Sie den Text für die neue Sprache ein.

    ![Ansichtsdesigner, Beschriftung übersetzen -screenshot][img2]

1. Wiederholen Sie die Schritte 2-3 für zusätzliche Sprachen.
1. Klicken Sie auf **Schließen**, um den Übersetzungsdialog zu verlassen.

Denken Sie daran, das Layout neu zu veröffentlichen.

## Referenz

| Einstellung | Beschreibung | Kommentar |
|---|---|---|
| Name | Text | Kann übersetzt werden |
| Aktion | Was passiert, wenn geklickt wird: Website öffnen, CRMScript, SoProtocol | |
| URL | URL | HTTP-Präfix wird automatisch hinzugefügt. Sie müssen 'https://' selbst hinzufügen, falls zutreffend. |
| Modus | Wann das Element angezeigt wird: Immer, Lesemodus, Bearbeitungsmodus | |
| Quickinfo | Text | Kann übersetzt werden |
| Stil | Aktion, Normal, Löschen, OK, Bearbeiten | Nicht zutreffend für Links |

Einige Einstellungen hängen von der gewählten Aktion ab.

### Website öffnen

* URL-Verschlüsselung: Keine, ANSI oder Unicode
* Ziel: Neue oder gleiche Registerkarte

![Ansichtsdesigner, Website auf Schaltfläche öffnen -screenshot][img4]

> [!NOTE]
> Es wird empfohlen, das Protokoll anzugeben, z. B. `https://www.superoffice.com`, andernfalls wird HTTP standardmäßig verwendet.

### CRMScript ausführen

* CRMScript: Wählen Sie das spezifische Skript aus, das ausgeführt werden soll.

![Ansichtsdesigner, CRMScript auf Schaltfläche ausführen -screenshot][img3]

[Erfahren Sie mehr über CRMScript][2]

### Verknüpfung (SoProtocol)

* SoProtocol: Der Navigations- und Inhaltsteil der URL ohne das Präfix `superoffice:`.

![Ansichtsdesigner, SoProtocol auf Schaltfläche -screenshot][img5]

[Erfahren Sie mehr über SoProtocol][3]

<!-- Referenced links -->
[1]: ../../../document/templates/variables/from-company-card.md
[2]: ../../../../en/automation/crmscript/overview/index.md
[3]: ../../../../en/ui/soprotocol/index.md
[4]: edit-layout.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/ui/new-button.png
[img2]: ../../../../media/loc/en/ui/translate-button-label.png
[img3]: ../../../../media/loc/en/ui/button-script.png
[img4]: ../../../../media/loc/en/ui/button-website.png
[img5]: ../../../../media/loc/en/ui/button-soprotocol.png
