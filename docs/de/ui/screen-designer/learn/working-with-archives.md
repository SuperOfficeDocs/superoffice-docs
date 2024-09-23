---
uid: help-de-archive-edit-layout
title: Layout in Bereichsregisterkarten/Archiven bearbeiten
description: Ansichtsdesigner Layout bearbeiten – Archive (Bereichsregisterkarten)
author: SuperOffice RnD
date: 02.23.2023
keywords: Ansichtsdesigner, Bereichsregisterkarte, Archiv
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Layout in Bereichsregisterkarten/Archiven bearbeiten

Sie können das Layout bearbeiten, indem Sie Bereichsregisterkarten/Archive auf den verschiedenen Hauptkarten für Firma, Person, Verkauf, Projekt, und Anfragen hinzufügen oder entfernen.

## Begriffsklärung

Bereichsregisterkarten sind die Registerkarten unten in den meisten Ansichten in SuperOffice CRM. Beispiel: Die Ansicht Firma enthält Bereichsregisterkarten mit Personen, Aktivitäten, Projekten und Verkäufen. Diese werden auch als Archive bezeichnet. Es gibt aber auch Bereichsregisterkarten, die nicht als Archive gelten, wie zum Beispiel Bereichsregisterkarten mit Verkaufs- und Projektleitfäden, sowie Angebote. Im Rahmen dieses Themas bezeichnen wir sie als Archive oder Archivregisterkarten (wenn die eigentliche Registerkarte mit dem Archiv gemeint ist).

Wenn Sie wie unter Neues Layout hinzufügen beschrieben ein neues Layout für Archive (Bereichsregisterkarten) erstellt haben, können Sie es nun gemäß den Bedürfnissen der zugewiesenen Benutzergruppe(n) anpassen. Wenn Sie ein Layout für das Verkaufsteam anpassen, sollten Sie die Bedürfnissen des Teams an das Layout, die Formatierung und die Inhalte der Archive genau kennen. Brauchen sie benutzerdefinierte Archive mit gefilterten Daten? Welche Daten müssen zuerst und am einfachsten zu finden sein? Benötigen sie alle Archive?

## Schritte

Sie können eine neue Bereichsregisterkarte auf allen gewünschten Hauptkarten hinzufügen. Je nach der gewählten Hauptkarte können Sie eine neue Registerkarte mit folgenden Inhalten hinzufügen: Dokument, Termin, Produkt, Projekt, Projektmitglied, Verkauf, Verkaufsbeteiligter, Anfrage, Person und Beziehung.

![Wählen Sie den Inhaltstyp aus, den Sie in der Registerkarte auswählen möchten -screenshot][img5]

<!-- markdownlint-disable MD029 -->
[!include[Go to screen designer](includes/goto-screen-designer.md)]
<!-- List starts in the include. Next line MUST be 3. -->
3. Klicken Sie auf **Archive**.

4. Wählen Sie in der Liste links ein Layout aus.

5. Klicken Sie unter der Vorschau auf **Layout bearbeiten**. Ein neues Fenster öffnet sich.

6. Weitere Informationen zum Bearbeiten des Layouts finden Sie in den Bereichen unten.

7. Wenn das Bearbeiten des Layouts abgeschlossen ist, klicken Sie auf eine der folgenden Schaltflächen:

    * **Entwurf speichern**: Klicken Sie auf diese Schaltfläche, wenn das Layout noch nicht ganz fertiggestellt ist.
    * **Speichern + Veröffentlichen**: Klicken Sie auf diese Schaltfläche, wenn Sie das Layout für die ausgewählten Benutzergruppen veröffentlichen wollen.
    * **Abbrechen**: Klicken Sie auf die diese Schaltfläche, damit Sie [alle Änderungen verwerfen](#undo-changes) können.
<!-- markdownlint-restore -->

## Registerkarte Archiv hinzufügen

1. Klicken Sie auf das ![Symbol][img2] **Hinzufügen**. Der Bereich **Registerkarte** wird auf der linken Seite geöffnet.

2. Geben Sie in **Name** anstelle des Textes **Neue Registerkarte** den Namen des Archivs ein. Sie können auch den Namen in [andere Sprachen][1] hinzufügen, indem Sie das ![Symbol][img3] anklicken.

3. Bearbeiten Sie gegebenenfalls **Eindeutiger Name für Registerkarte (SOProtocol)**. Dieser Name lässt sich später nicht mehr ändern.

4. Geben Sie eine Beschreibung für das Archiv in das Feld **Beschreibung** ein. Sie können auch die Beschreibung in [andere Sprachen][1] hinzufügen, indem Sie auf ![Symbol][img3] klicken.

5. Wählen Sie den Bereich **Einstellungen** aus.

6. Wählen Sie in der Liste **Inhalt** den Datentyp aus, der im Archiv angezeigt werden soll. Die Daten im Archiv sind auf Daten für die aktuelle Ansicht beschränkt.

    Beispiel: Wenn Sie ein Archiv für die Ansicht Firma hinzufügen, werden nur mit der aktuellen Firma verknüpfte Daten angezeigt.

7. Unter **Filter** können Sie die relevanten Kriterien wie folgt hinzufügen/bearbeiten:

    * [Kriterium bearbeiten][2].

        Beispiel: Wählen Sie **Termin** in der Liste **Inhalt** aus und fügen Sie Kriterien hinzu, mit denen nur interne und externe Meetings für diese und nächste Woche angezeigt werden.

    * Klicken Sie zum Festlegen weiterer Kriterien auf **Hinzufügen**. In die Kriterienliste wird eine neue Zeile eingefügt.

    * Um Kriterien zu verschieben, ziehen Sie es mit gedrückter Maustaste.

    * Klicken Sie auf **Oder**, um einen weiteren Satz von Kriterien hinzuzufügen.

8. Klicken Sie auf **Vorschau aktualisieren**, um in der Vorschau auf der rechten Seite Daten für die aktuellen Kriterien anzuzeigen. Wählen Sie in der Liste **Vorschau von Firma** die Firma für die Vorschau aus.

9. Wenn Sie auf **Erweiterte Optionen**klicken, können Sie die Standardaktionen bei einmaligem und doppeltem Klicken im Archiv ändern. Beispiele für diese Konfiguration finden Sie unter **Syntaxbeispiel** und indem Sie den Mauszeiger auf das Symbol (![Symbol][img4]) stellen.

    > [!NOTE]
    > Standardmäßig wird bei einmaligem Klicken eine Zeile ausgewählt und bei doppeltem Klicken ein Datensatz/eine Entität in SuperOffice geöffnet. Wenn Ihre Firma mit benutzerdefinierten Archiven jedoch Daten aus anderen Systemen anzeigt, können Sie diese Einstellungen ändern und einen Datensatz in einem externen System öffnen.

10. Ziehen Sie das neu erstellte Archiv in der Vorschau mit gedrückter Maustaste und verschieben Sie es an die gewünschte Position.

11. Speichern Sie die Änderungen wie oben erläutert.

## Bestehende Bereichsregisterkarten bearbeiten

Wenn Sie ein bestehendes Archiv bearbeiten wollen, wählen Sie es aus und bearbeiten die verfügbaren Felder und Einstellungen in den Bereichen **Registerkarte** und **Einstellungen**. Sie können es auch mit gedrückter Maustaste an eine neue Position ziehen.

## Einschränkungen

* Standardregisterkarten können nicht bearbeitet werden.

* Manche Registerkarten wie beispielsweise **Angebot**, **Verkaufsleitfaden** und **Projektleitfaden** können nicht bearbeitet werden, weil sie bestimmte Funktionen haben.

## Archive entfernen

1. Wählen Sie das Archiv (oder eine andere Bereichsregisterkarte) aus und klicken Sie auf **Aufgabe** > **Registerkarte entfernen**.

1. Klicken Sie in dem angezeigten Dialogfeld auf **OK**. Die Registerkarte wird entfernt (ausgeblendet, aber nicht gelöscht).

![Klicken Sie auf Aufgabe und dann auf Registerkarte entfernen, um unerwünschte Registerkarten in der Bereichsregisterkarte (Archiv) zu entfernen -screenshot][img1]

Sie können jederzeit auf **Registerkarten wiederherstellen** klicken, um diese Änderung rückgängig zu machen.

## <a id="undo-changes"></a>Änderungen rückgängig machen

Wenn Sie wieder eine frühere Version der Ansicht nutzen möchten, stehen über die Schaltfläche **Aufgabe** folgende Optionen zur Verfügung:

* **Auf werkseitige Einstellung zurücksetzen**: Mit dieser Option werden alle Änderungen verworfen und das Layout auf das von SuperOffice bereitgestellte Standardlayout zurückgesetzt.

* **Registerkarten wiederherstellen**: Mit dieser Option werden alle entfernten Registerkarten wiederhergestellt.

* **Entwurf verwerfen**: Alle Änderungen werden verworfen und die veröffentlichte Version des Layouts wird wiederhergestellt.

## Verwandt

* [Wie man Felder in der Registerkarte Mehr in den Ansichten Firma und Person nach dem Upgrade auf die SuperOffice Version 10 neu organisiert?][3] - FAQ
* [Neues Layout erstellen][4]

<!-- Referenced links -->
[1]: ../../../globalization-and-localization/learn/translate-fields.md
[2]: ../../../search-options/learn/search-criteria.md
[3]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-reorganize-the-fields-in-the-more-tab-in-company-and-contact-screenscards-after-the-upgrade-to-superoffice-version-10/
[4]: add-layout.md

<!-- Referenced images -->
[img2]: ../../../../../common/icons/add-icon.png
[img3]: ../../../../../common/icons/az.png
[img4]: ../../../../../common/icons/info-ball.png
[img1]: ../../../../media/loc/en/ui/admin-screendesigner-edit-archive.png
[img5]: ../../../../media/loc/en/ui/admin-screendesigner-edit-archive-add-tab.png
