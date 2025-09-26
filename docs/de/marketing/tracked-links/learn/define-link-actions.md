---
uid: help-de-define-link-actions
title: Automatisierte Linkaktionen definieren
description: In dieser Anleitung lernen Sie, wie Sie Links in Kampagnen verwenden, um Aktionen zu automatisieren.
keywords: Marketing, Kampagne, Aussendung, Überwachte Links, Linkaktion, automatisieren
author: Bergfrid Dias
date: 09.26.2025
version: 10.5
content_type: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: de
---

# Automatisierte Linkaktionen definieren

Das manuelle Aktualisieren von 500 Personenkarten ist zeitaufwendig und unnötig. Automatisierte Linkaktionen können diesen Prozess optimieren.

So funktionieren automatisierte Linkaktionen:

* Das Klicken eines Empfängers auf einen Call-to-Action-Link kann sie automatisch zu einer Selektion oder einem Projekt in SuperOffice CRM hinzufügen.
* SuperOffice CRM kann automatisch relevante Informationen wie Interessen auf der Personenkarte aktualisieren.

Automatisierung spart Zeit, die sonst für die Bearbeitung von Antworten aufgewendet würde. Wenn ein Leser auf einen Link in Ihrer Kampagne klickt, führt das System die Linkaktionen für Sie aus!

Sie können die gesammelten Informationen auf verschiedene Arten nutzen:

* Generieren Sie eine Selektion basierend auf denen, die auf einen bestimmten Link geklickt haben, und senden Sie eine gezielte Antwort an diese Gruppe mit einer maßgeschneiderten Mitteilung.
* Planen Sie Folgeaufgabeen für Ihre Teammitglieder, um persönlich mit den Respondenten zu interagieren.
* Erstellen Sie Anfragen für Ihr Kundendienst-Team, um diese zu aufgreifen und zu untersuchen.

![Definieren Sie Ihre Linkaktionen -screenshot][img3]

## Verfügbare Aktionen

Je nach Ziel und Handlungsaufforderung Ihrer Kampagne können Sie Ihre Datenbank aktualisieren. Diese Informationen können die Segmentierung verbessern oder helfen, mit interessierten Personen in Kontakt zu bleiben. Du kannst mehr als eine Aktion für einen verfolgten Link auswählen.

| Registerkarte | Aktion |
|---|---|
| [Antwort](#response) | Zielseite oder benutzerdefinierten Text hinzufügen, oder ein Formular öffnen. |
| [Feld festlegen](#set-field) | Einem [Zusatzfeld][5] einen Wert für die Personen des Kunden hinzufügen |
| [Interessen](#interests) | Interessen aktualisieren. |
| [Selektion/Projekt](#selection) | Ansprechpartner zu Selektion oder Projekt hinzufügen bzw. daraus entfernen. |
| [Folgeaufgabe](#follow-up) | Erstellt eine Folgeaufgabe (Aufgabe oder Besprechung) in SuperOffice CRM. |
| [Anfrage](#request) | Eine neue Anfrage erstellen. |
| [Skript](#script) | Ein Skript ausführen. |

> [!TIP]
> Wenn Sie einen überwachten Link aktualisieren, denken Sie daran, dass er von mehreren Kampagnen und/oder automatisierten Flows verwendet werden kann. Stellen Sie sicher, dass es keine duplizierten oder widersprüchlichen Aktionen gibt.

## <a id="response"></a>Antwort

Wählen Sie aus, was passieren soll, wenn der Empfänger auf den Link klickt.

* **Auf neue Webseite umleiten**: Geben Sie die URL im vorgesehenen Feld ein.
* Oder, **Benutzerdefinierten Text anzeigen**: Geben Sie den anzuzeigenden Text ein. Klicken Sie auf das Bearbeitungssymbol ![Symbol][img4], um die Rich-Text-Toolbar anzuzeigen.
* Oder, **Formular öffnen**: Wählen Sie den Namen des Formulars. Optional wählen Sie, welche Felder mit bekannten Kontaktdaten vorausgefüllt werden sollen.

## <a id="set-field"></a>Feld festlegen

Auf der Registerkarte **Feld festlegen** können Sie einen Wert festlegen, der einem Zusatzfeld hinzugefügt wird, wenn der Empfänger auf den Link klickt. Dies zeichnet zusätzliche Kundendaten auf.

Wählen Sie ein Feld aus und geben Sie einen Wert ein.

## <a id="interests"></a>Interessen

Geben Sie an, dass ein Link-Klick die Interessen des Kontakts ändern soll. Fügen Sie zum Beispiel das Interesse "Neuigkeiten zu Produkten" hinzu, wenn auf den Link "Ja, ich möchte über neue Produkte informiert werden" geklickt wird, oder entfernen Sie es, wenn auf den Link "Abmelden" geklickt wird.

* **Interesse festlegen**: Wählen Sie ein Interesse aus, das für den Personen hinzugefügt werden soll, wenn sie auf den Link klicken.
* **Interesse löschen** wählen Sie ein Interesse aus, das für den Personen entfernt werden soll, wenn sie auf den Link klicken.

[Wie man ein Anmeldeformular für den Newsletter erstellt][1]

## <a id="selection"></a>Selektion/Projekt

Geben Sie an, dass Empfänger, die auf den Link klicken, zu Selektion oder Projekten hinzugefügt oder daraus entfernt werden. Beginnen Sie einen Namen zu tippen, um die Schnellsuche zu starten.

## <a id="follow-up"></a>Folgeaufgabe (Aufgabe/Besprechung)

Auf der Registerkarte **Folgeaufgabe** setzen Sie einen Link-Klick, um Aufgaben bzw. Besprechungen in SuperOffice CRM zu generieren. Wählen Sie der Folgeaufgabentyp, geben Sie eine Beschreibung an, verlinke sie mit einem Projekt, wählen Sie den Aufgabentyp, ordnen die Verantwortlichkeit zu und setzen Sie die Dauer.

Aktiviere diese Funktion, indem du **Folgeaufgabe** auswählst.

[Wie man eine Folgeaufgabe erstellt][4]

> [!TIP]
> Als Beschreibung geben Sie an, zu welcher Kampagne es gehört, welchen Link der Empfänger geklickt hat und möglicherweise, wie die Aufgabe bzw. die Besprechung weiterverfolgt werden soll.
>
> Bei der Einstellung von **Erstellt von** oder **Standardempfänger** können Sie auf die Schaltfläche **Aktiven Benutzer auswählen** (<i class="ph ph-user-circle" aria-hidden="true"></i>) klicken, um sich selbst auszuwählen.

## <a id="request"></a>Anfrage

Auf der Registerkarte **Anfrage** setzen Sie einen Link-Klick, um eine Service-Anfrage zu erstellen. Setzen Sie das Häkchen, um eine neue Anfrage zu registrieren, geben Sie einen Titel an, wählen Sie die Priorität und Kategorie aus und wählen Sie den Eigentümer. Du kannst auch **Automatisch zugeordnet** oder **Nicht zugeordnet** auswählen.

[Wie man eine Anfrage erstellt][3]

## <a id="script"></a>Skript

Auf der Registerkarte **Skript** wählen Sie ein CRMSkript oder eine Makro aus, das beim Klicken des Links ausgeführt werden soll. Aktiviere diese Funktion, indem Sie **Skript ausführen** wählen und dann das erforderliche Skript aus der Liste auswählen.

In dem Skript verfügbare Variablen sind custId, linkId, shipmentId, linkUrl, linkHits und returnUrl.

[Wie man ein CRMSkript erstellt oder bearbeitet][6]

<!-- Referenced links -->
[1]: ../../forms/learn/tutorial-sign-up.md
[3]: ../../../request/learn/create.md
[4]: ../../../diary/learn/create-follow-up.md
[5]: ../../../custom-objects/learn/extra-field.md
[6]: ../../../automation/crmscript/learn/create-script.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/marketing/link-properties-follow-up.png
[img4]: ../../../../media/icons/marketing-and-forms/side-panel-content-text.png
