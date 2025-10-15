---
uid: help-de-ai-copilot
title: SuperOffice Copilot
description: SuperOffice KI-Services - Copilot
keywords: KI, ChatGPT, OpenAI, Bing, Copilot
author: digitaldiina, Filip Norman
date: 10.15.2025
version: 11.5
content_type: concept
license: aiplatform
pilot: yes
category: automation
topic: ai
deployment: online
platform: web
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# SuperOffice Copilot

Der SuperOffice Copilot integriert nahtlos eine ChatGPT-ähnliche Benutzererfahrung in SuperOffice und bietet ein leistungsstarkes KI-Tool im CRM-Kontext. Unser Ziel ist es, generative KI nahtlos in SuperOffice CRM einzubetten, wodurch der Zugang zu externen Apps überflüssig wird und Ihr Workflow direkt innerhalb der Plattform verbessert wird.

Sie können Zeit sparen und Erkenntnisse gewinnen, indem Sie die verschiedenen vorgefertigten Fragen (Prompts) in den Ansichten Firma, Person, Kalender, Verkauf, Projekt, Anfrage und Selektion verwenden.

> [!NOTE]
> Diese Funktion ist über unser [AI lab-Programm][9] verfügbar. SuperOffice KI ist nur in der Cloud verfügbar.

## Datenschutz und DSGVO

SuperOffice Copilot weiß nichts über Ihre Kundendaten und wird Ihnen Antworten mit Hilfe eines großen Sprachmodells (LLM) wie Bing von Microsoft oder ChatGPT von OpenAI geben.

## Erste Schritte

Der SuperOffice Copilot ist in allen Ansichten mit dem [Seitenpanel][1] verfügbar. Standardmäßig zeigt das Seitenpanel eine Vorschau des ausgewählten Datensatzes.

1. Gehen Sie zu einer Firma, Person, Kalender, Verkauf, Projekt, Anfrage oder Selektion.

1. Klicken Sie auf <i class="ph ph-caret-down" aria-label="Chevron"></i> neben dem Namen des Seitenpanels und wählen Sie **SuperOffice Copilot**.

    ![SuperOffice Copilot aktivieren -screenshot][img2]

1. Wählen Sie einen der vordefinierten Prompts oder stellen Sie eine beliebige Frage, um Antworten von der KI-Technologie zu erhalten.

    ![SuperOffice Copilot bei einem Verkauf -screenshot][img3]

1. Nachdem die KI eine Antwort generiert hat, haben Sie folgende Optionen:

    * Wählen Sie das Plus- oder Minus-Symbol, um mehr oder weniger Text zu erhalten.
    * Kopieren Sie das Ergebnis in die Zwischenablage.
    * Stellen Sie eine weitere Frage.
    * Löschen Sie den Chat.

    ![SuperOffice Copilot bei einem Verkauf -screenshot][img4]

## Kontext und Sprache

SuperOffice Copilot verwendet die Sprache Ihrer SuperOffice-Anwendung. Wenn Sie beispielsweise *Deutsch* in den **Lokalen Einstellungen** ausgewählt haben, antwortet Ihnen die KI auf Deutsch.

Der Kontext ist immer das aktuell betrachtete Element. Wenn Sie beispielsweise die Firma "SuperOffice AS" betrachten, erzählt Ihnen die KI über SuperOffice. Wenn Sie zu "Visma" wechseln, erzählt die KI stattdessen über diese Firma. Wenn Sie zu **Projekt** wechseln, wird der Chat zurückgesetzt und Sie können projektbezogene Prompts auswählen. Und so weiter.

## Verfügbare Prompts

Prompts können sich während der Pilotphase ohne vorherige Ankündigung ändern!

### Firma

* **Firmendetails:** KI erzählt Ihnen über die aktuelle Firma.
* **Konkurrenten:** KI präsentiert allgemeine Informationen über Konkurrenten und Wettbewerbsanalyse.
* **Geschäft:** KI erzählt Ihnen über das Geschäft, in dem die Firma tätig ist.

### Person

* **Firmendetails:** KI erzählt Ihnen über die aktuelle Firma.
* **Personendetails:** KI erzählt Ihnen über die aktuelle Person.
* **Pitch schreiben:** KI schreibt einen auf die Person zugeschnittenen Pitch.

### Kalender

* **Heute:** KI listet alle Ihre geplanten Kalendereinträge für das aktuelle Datum auf.

### Verkauf

* **Firmendetails:** KI erzählt Ihnen über die Firma des aktuellen Verkaufs.
* **Konkurrenten:** KI präsentiert allgemeine Informationen über Konkurrenten und Wettbewerbsanalyse.
* **Geschäft:** KI erzählt Ihnen über das Geschäft, in dem die Firma tätig ist.
* **Vorschlag:** KI erstellt einen Vorschlag für die Verkaufschance.

### Projekt

* **Projektplanung:** KI erstellt einen Projektplan für das aktuelle Projekt.
* **Ideen:** KI gibt Ihnen einige Ideen zu Dingen, die Sie für das aktuelle Projekt basierend auf seinem Titel und seiner Beschreibung berücksichtigen sollten.

### Anfragen

* **Zusammenfassen:** KI analysiert die Anfrage und Anfragennachrichten, extrahiert wichtige Informationen und präsentiert eine kurze, kohärente Zusammenfassung.

  * Wenn eine Anfrage 3 oder mehr Nachrichten enthält, können Sie **Zusammenfassen** aus dem **Alle anzeigen** Dropdown-Menü in der **Nachrichten**-Registerkarte der Anfragen-Ansicht auswählen.
  * Wenn die Anfrage mehr als 5 Nachrichten hat, erscheint auch eine separate **Zusammenfassen**-Schaltfläche neben der **Kommentar hinzufügen**-Schaltfläche.

### Selektion

* Demnächst verfügbar

## Verwandte Inhalte

* [Andere KI-Services][2]
* [Trust center | DSGVO & SuperOffice-Produkte][8]

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/side-panel.md
[2]: index.md
[8]: https://www.superoffice.com/trust-center/gdpr-and-crm/
[9]: https://community.superoffice.com/en/product-releases/pilot-programs/current-pilot-programs/ai-lab/

<!-- Referenced image -->
[img2]: ../../../media/loc/en/ai/copilot-in-sidepanel-list.png
[img3]: ../../../media/loc/en/ai/copilot-on-sale.png
[img4]: ../../../media/loc/en/ai/copilot-about-superoffice.png
