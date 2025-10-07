---
uid: help-de-screen-designer
title: Ansichtsdesigner
description: In dieser Anleitung lernen Sie, wie Sie Ihre Karten/Ansichten konfigurieren.
keywords: Ansichtsdesigner, Benutzeroberfläche, Layout, anpassen
author: Bergfrid Dias
date: 10.29.2024
version: 10.3.11
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: de
redirect_from: /de/customization/screen-designer/index
---

# Ansichtsdesigner <i class="ph ph-squares-four" aria-hidden="true"></i>

Der **Ansichtsdesigner** in SuperOffice CRM ermöglicht es Ihnen, das Layout der Hauptanzeigen anzupassen, sodass die Benutzeroberfläche den spezifischen Anforderungen verschiedener Benutzergruppen in Ihrer Organisation entspricht. Diese Funktion ersetzt das alte [PageBuilder][9]-Tool und bietet eine effizientere und flexiblere Möglichkeit, Bildschirme ohne Programmierkenntnisse zu konfigurieren.

![Ansichtsdesigner, Firmenkarte, Standard-Feldlayout -screenshot][img5]

> [!NOTE]
> Diese Funktion erfordert die Lizenz Development Tools und das Funktionsrecht "Feldadministrator".

## Warum den Ansichtsdesigner verwenden?

SuperOffice CRM bietet Standardlayouts für die Personen-, Firmen-, Verkaufs-, Projekt- und Anfragenansicht sowie den Folgeaufgabedialog. Allerdings haben verschiedene Teams oft unterschiedliche Informationsbedürfnisse. Mit dem Ansichtsdesigner können Sie:

* Ihr eigenes Layouts erstellen, die auf die Arbeitsabläufen und Prioritäten bestimmter Benutzergruppen (wie Verkauf, Support, Management) zugeschnitten sind.

* Die Effizienz steigern, indem Sie Ihren Teams den schnellen Zugriff auf die wichtigsten Informationen ermöglichen.

* Unnötige Felder entfernen, neue hinzufügen und Daten in logische Gruppen unterteilen, indem Sie Registerkarten, Spalten und Bezeichnungen verwenden.

Zum Beispiel, wenn Ihr Vertriebsteam den Fokus auf Kundeninteraktionen legt, können Sie sicherstellen, dass Kontaktdetails prominent angezeigt werden, während weniger relevante Felder in sekundäre Registerkarten verschoben werden.

## Was kann ich anpassen?

Mit dem Ansichtsdesigner können Sie:

* Das Standardlayout von Ansichten für alle Benutzer ändern oder benutzerdefinierte Layouts für bestimmte Benutzergruppen erstellen.

* Layouts erstellen, die auf bestimmte Projekttypen, Verkaufstypen, Anfragetypen, Folgeaufgabetypen, oder Dokumentvorlagen optimiert sind.

* Felder ausblenden, die nie verwendet werden.

* Wichtige Daten hervorheben, indem Sie Felder formatieren (zum Beispiel fett oder in großer Schrift).

* Schaltflächen und Links hinzufügen, um automatisierte Prozesse (CRMScript) oder externe Abfragen auszulösen.

* Benutzerdefinierte Felder im **Mehr**-Tab oder anderen Registerkarten organisieren.

* Registerkarten hinzufügen, umorganisieren oder entfernen, wie es erforderlich ist.

## Welche Ansichten kann ich konfigurieren?

Sie können die folgenden Ansichte und Dialoge anpassen:

* Firma
* Person
* Verkauf
* Projekt
* Anfrage
* Folgeaufgabedialog
* Dokumentdialog

## Wie funktionieren Layouts?

Layouts in SuperOffice CRM steuern, wie Informationen für Benutzer angezeigt werden. Die Standard- (System-) Layouts werden auf alle Benutzer angewendet, es sei denn, ein eigenes Layout wurde erstellt und einer bestimmten Benutzergruppe zugewiesen.

* **Eigene Layouts**: Erstellen Sie Layouts, die speziell auf die Bedürfnisse von Benutzergruppen abgestimmt sind.

* **Layout-Zuweisung**: Layouts für die Verkaufs-, Projekt- und Anfrageseiten können weiter verfeinert werden, indem sie bestimmten Verkaufstypen, Projekttypen und Anfragetypen zugewiesen werden. Ebenso kann der Folgeaufgabedialog den Folgeaufgabetypen und der Dokumentdialog den Dokumentvorlagen zugewiesen werden.

* **Layout-Status**: Layouts können sich im *Entwurf* oder *veröffentlicht* Zustand befinden. Veröffentlichten Layouts sind die zugewiesenen Benutzergruppen zugeordnet.

![Entwurf eines Ansichtsdesigners -screenshot][img3]

![Veröffentlichtes Layout eines Ansichtsdesigners -screenshot][img4]

Die **Layouts**-Liste zeigt alle vorhandenen Layouts an, einschließlich einer Vorschau der Ansicht.

## Arbeiten mit dem Ansichtsdesigner

Um mit der Anpassung von Bildschirmen zu beginnen:

1. Öffnen Sie den Ansichtsdesigner, indem Sie auf <i class="ph ph-list" aria-label="Main menu"></i> klicken, **Einstellungen und Verwaltung** auswählen und dann **Ansichtsdesigner** aus dem Navigator wählen.

2. Ziehen Sie Felder in den Editor, um sie zu Ihrem Layout hinzuzufügen.

3. Klicken Sie auf ein Feld, um es zu verschieben oder seine Einstellungen zu aktualisieren. Die verfügbaren Einstellungen hängen vom ausgewählten Feldtyp ab.

### Layout-Komponenten

* **Felder:** Zeigt alle Datenfelder an, die für das ausgewählte Ansichtslayout verfügbar sind. Verwenden Sie Filter, um bestimmte Felder schnell zu finden.

* **Elemente:** Enthält nicht-datenbezogene Elemente wie Beschriftungen, Trennlinien, Links und Schaltflächen.

* **Einstellungen:** Ermöglicht die Anpassung des Erscheinungsbildes und Verhaltens des ausgewählten Feldes.

* **Registerkarten-Layout:** Bietet Optionen zum Anordnen von Feldern und Elementen in Spalten.

* **Registerkarten:** Können hinzugefügt, umorganisiert oder gelöscht werden, um Informationen logisch zu organisieren.

> [!NOTE]
> Nachdem ein Layout veröffentlicht wurde, müssen sich Benutzer in den zugewiesenen Gruppen abmelden und erneut anmelden, um die Änderungen zu sehen.

## Was, wenn ich den Ansichtsdesigner nicht benutze?

Wenn Sie keine Development Tools Lizenz haben, organisiert der **Mehr**-Tab automatisch alle benutzerdefinierten Felder in zwei Spalten. Diese Standardkonfiguration bietet eine funktionale Ansicht, jedoch ohne die erweiterten Anpassungsoptionen des Ansichtsdesigners.

## Zusammenfassung

Durch die Anpassung der Ansichtslayouts mit dem Ansichtsdesigner können Sie unnötige Informationen eliminieren, wodurch die Ansicht für Ihre Teams sauberer und effizienter wird. Wenn Ihr Support-Team beispielsweise die Firmenadresse nicht prominent angezeigt haben muss, können Sie sie auf eine sekundäre Registerkarte verschieben und so Platz für relevantere Felder schaffen.

## Verwandte Themen

* [Layout hinzufügen][2]
* [Layout bearbeiten (Hauptkarten)][1]
* [Arbeiten mit Feldern][4]
* [Arbeiten mit Archiven (Bereichsregisterkarten)][3]

<!-- Referenced links -->
[1]: edit-layout.md
[2]: add-layout.md
[3]: working-with-archives.md
[4]: working-with-fields.md
[9]: ../../../../en/ui/web-app/pagebuilder/index.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/customization/status-draft.png
[img4]: ../../../../media/loc/en/customization/status-published.png
[img5]: ../../../../media/loc/en/customization/edit-card-layout-fields.png
