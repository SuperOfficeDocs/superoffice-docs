---
uid: help-de-screen-designer-archive
title: Arbeiten mit Bereichsregisterkarten (Archive)
description: Ansichtsdesigner - arbeiten mit Bereichsregisterkarten (Archive)
keywords: Bereichsregisterkarte hinzufügen, neue Bereichsregisterkarte, Archivregisterkarte hinzufügen, Bereichsregisterkarte anpassen, Bereichsregisterkarten-Layout
author: digitaldiina
date: 11.20.2025
version: 11.6
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: de
index: true
redirect_from:
  - /de/ui/screen-designer/learn/edit-layout-archives
  - /de/customization/screen-designer/working-with-archives
---

# Arbeiten mit Bereichsregisterkarten (Archive)

Sie können das Layout anpassen, indem Sie Bereichsregisterkarten (auch Archive genannt) auf den Hauptkarten für die Bildschirme Firma, Person, Verkauf, Projekt und Anfrage hinzufügen oder entfernen.

Das Anpassen von Bereichsregisterkarten erfolgt typischerweise, um den spezifischen Bedürfnissen verschiedener Benutzergruppen gerecht zu werden. Sie können ein Layout erstellen, das auf eine bestimmte Benutzergruppe zugeschnitten ist und sicherstellen, dass die Bereichsregisterkarten relevante Inhalte für diese Gruppe anzeigen.

![Fügen Sie den Namen zur neuen Bereichsregisterkarte/Archivlayout hinzu und wählen Sie die Benutzergruppe(n) aus, für die sie angezeigt werden soll -screenshot][img6]

## Verständnis der Bereichsregisterkarten

Bereichsregisterkarten, die sich am unteren Rand der meisten SuperOffice CRM-Bildschirme befinden, zeigen verwandte Daten wie Personen, Aktivitäten, Projekte und Verkäufe an. Während einige Bereichsregisterkarten, wie Verkaufsleitfäden und Angebote, keine Archive sind, bezeichnen wir zur Vereinfachung alle als Archive oder Archivregisterkarten.

Wenn Sie ein neues Layout für eine Benutzergruppe erstellen, sollten Sie überlegen, welche Daten diese am dringendsten benötigen. Das Anpassen von Archiven ermöglicht es Ihnen, Informationen zu filtern und zu priorisieren, sodass Benutzer schneller finden, was sie benötigen.

## Bereichsregisterkarten hinzufügen

Sie können auf jedem Bildschirm mit einem Bereichsregisterkartenbereich eine neue Registerkarte hinzufügen. Je nach gewähltem Bildschirm können Sie eine neue Registerkarte mit folgenden Inhalten hinzufügen: Dokument, Folgeaufgabe, Produkt, Projekt, Projektmitglied, Verkauf, Verkaufsbeteiligter, Anfrage, Person und Beziehung.

![Wählen Sie den Inhaltstyp, den Sie in der Bereichsregisterkarte anzeigen möchten -screenshot][img5]

**Schritte:**

1. Öffnen Sie den Ansichtsdesigner.

1. Wählen Sie oben eine Ansicht aus, die Sie anpassen möchten, und klicken Sie auf **Archive**.

1. Wählen Sie ein Layout aus der Liste und klicken Sie unter der Vorschau auf <i class="ph ph-pencil-simple" aria-label="Layout bearbeiten"></i>.

1. Klicken Sie auf **Hinzufügen**, um den Abschnitt **Registerkarte** zu öffnen.

1. Ersetzen Sie "Neue Registerkarte" durch den Archivnamen und geben Sie eine Beschreibung für das neue Archiv ein.

    Optional klicken Sie auf <i class="ph ph-translate" aria-label="Translate"></i>, um die Texte in anderen Sprachen hinzuzufügen.

1. Passen Sie den **Eindeutigen Namen für die Registerkarte** (soprotocol) nach Bedarf an.

1. Wählen Sie im Bereich **Einstellungen** den anzuzeigenden Datentyp (Inhalt) im Archiv aus.

    Die Daten sind auf den aktuellen Bildschirm beschränkt. Wenn Sie z.B. ein Archiv zur Ansicht Firma hinzufügen, werden nur Daten angezeigt, die mit der **aktuellen** Firma verknüpft sind.

1. Fügen Sie unter **Filter** Kriterien hinzu oder bearbeiten Sie sie, um die angezeigten Daten zu verfeinern. Diese Kriterien funktionieren ähnlich wie die [Suchfilter im Bildschirm **Suchen**][2] und in Selektionen.

    Klicken Sie auf **Vorschau aktualisieren**, um die gefilterten Daten anzuzeigen.

1. (Optional) Verwenden Sie **Erweiterte Optionen**, um Aktionen für Einzel- und Doppelklicks anzupassen. Standardmäßig wird bei einem Einzelklick eine Zeile ausgewählt und bei einem Doppelklick ein Datensatz/Eintrag in SuperOffice geöffnet.

    > [!TIP]
    > Stellen Sie den Mauszeiger über <i class="ph ph-info" aria-label="Info"></i>, um Beispiele zu sehen.

1. Ziehen Sie das Archiv an die gewünschte Position in der Vorschau.

1. Wählen Sie **Entwurf speichern** oder **Speichern + Veröffentlichen**, um Ihre Änderungen zu speichern. Klicken Sie auf **Abbrechen**, um Ihre Änderungen zu verwerfen.

## Bestehende Bereichsregisterkarte bearbeiten

Um eine vorhandene Bereichsregisterkarte zu ändern, wählen Sie sie aus und aktualisieren die Felder und Einstellungen in den Bereich **Registerkarte** und **Einstellungen**. Sie können die Registerkarte auch durch Ziehen an eine andere Position verschieben.

### Einschränkungen

* Standardregisterkarten können nicht bearbeitet werden.

* Einige Registerkarten wie **Angebot**, **Verkaufsleitfaden** und **Projektleitfaden** können nicht bearbeitet werden, da sie spezifische Funktionen haben.

## Bereichsregisterkarte entfernen

1. Wählen Sie das Archiv oder die Bereichsregisterkarte aus.

1. Klicken Sie auf **Aufgabe** > **Registerkarte entfernen**.

1. Bestätigen Sie mit **OK**. Die Registerkarte wird ausgeblendet, aber nicht gelöscht.

![Klicken Sie auf Aufgabe und dann auf Registerkarte entfernen, um unerwünschte Registerkarten in der Bereichsregisterkarte (Archiv) zu entfernen -screenshot][img1]

Um diese Änderungen rückgängig zu machen, klicken Sie auf **Registerkarten wiederherstellen**.

## Verwandte Inhalte

* [Neues Layout erstellen][4]

<!-- Referenced links -->
[2]: ../../../search-options/learn/search-criteria.md
[4]: add-layout.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/admin-screendesigner-edit-archive.png
[img5]: ../../../../media/loc/en/customization/admin-screendesigner-edit-archive-add-tab.png
[img6]: ../../../../media/loc/en/customization/admin-screendesigner-add-archive-layout.png
