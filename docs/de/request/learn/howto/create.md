---
uid: help-de-request-create
author: Hanne Gunnarsson
title: Anfrage erstellen
description: Anfrage erstellen
so.date: 22.02.24
so.version: 10.3.2
keywords: Anfrage
so.topic: howto
so.audience: person
so.audience.tooltip: SuperOffice Service
language: de
---

# Anfrage erstellen

Eine Anfrage kann per E-Mail vom Kunden im System eingehen, alternativ können Sie diese auch manuell über die Ansicht **Neue Anfrage** registrieren. Dies ist z. B. der Fall, wenn ein Kunden eine Anfrage telefonisch stellt.

## Workflow

1. Wählen Sie **Neu** > **Anfrage** aus.

1. Geben Sie im Feld **Titel** einen aussagekräftigen Namen für die Anfrage ein.

1. Fügen Sie eine Person im Feld **Suche nach Personen** hinzu.
   Möchten Sie eine Person hinzufügen? Sie können ein Ticket erstellen, ohne eine Person hinzuzufügen, und diese Informationen später hinzufügen, wenn Sie es eilig haben.

1. Beim Erstellen einer neuen Anfrage dient das Feld **An** folgenden Verwendungen:

    * Standardmäßig werden die hier eingegebenen Personen auch für die neue Anfrage als Personen verwendet.
    * Wenn Sie mehr als eine Person eingeben, wird die erste Person zur Hauptperson für die Anfrage. Sie können die Reihenfolge der Personen ändern, indem Sie auf Personen klicken und an die gewünschte Position ziehen.

    Geben Sie in das Feld **Person** (Suche nach Personen) die ersten Zeichen des Namens (oder der Telefonnummer) der Person ein. Wählen Sie in der Liste der Suchergebnisse mit den Nach-oben-/Nach-unten-Tasten auf der Tastatur eine Person aus und drücken Sie die **EINGABETASTE**. Oder verwenden Sie den Mauszeiger, um die Person auszuwählen.

    Stattdessen können Sie auch eine E-Mail-Adresse eingeben, wenn Sie einen Empfänger hinzufügen möchten, ohne ihn im System zu erfassen. In diesem Fall wird der Empfänger nicht als Kontaktperson für die Anfrage hinzugefügt.
    </details>

    > [!NOTE]
    > Sie können dieses Feld leer lassen, wenn Sie die Mitteilung an niemanden senden möchten.

1. Optional: Klicken Sie auf die Schaltfläche **Cc/Bcc** ganz rechts, um Personen als Empfänger einer Kopie oder Blindkopie hinzuzufügen.

1. Gehen Sie zum **Bildschirm Eigenschaften** auf der rechten Seite der Anzeige und geben Sie Informationen ein, um die Anfrage korrekt zuzuordnen und zu priorisieren.

    * Wählen Sie im Listenfeld **Anfragetyp** einen Typ aus, der Standardwerte sowie verfügbare Status und Prioritäten beeinflusst.

   * Wählen Sie im Listenfeld **Status** eine der folgenden Optionen:
     * **Öffnen**: Wählen Sie diese Option, wenn die Anfrage noch nicht abgeschlossen ist.
     * **Bearbeitet**: Wählen Sie diese Option, wenn die Anfrage abgeschlossen ist.
     * **Auf Termin gelegt**: Wählen Sie diese Option aus, um die Bearbeitung einer Anfrage aufzuschieben, und geben Sie Datum und Uhrzeit in das Feld **Festgelegt** oder eine voreingestellte Uhrzeit in der folgenden Liste ein. An diesem Tag und Uhrzeit wird die Anfrage zu dem Status **Unbearbeitet** zurückversetzt.

   * Wählen Sie im Feld **Eigentümer** eine der folgenden Optionen:
     * Wählen Sie den Namen der betreffenden Person, um einer bestimmten Person eine Anfrage zuzuordnen. Wählen Sie Ihren eigenen Namen aus, um sich selbst das Ticket zuzuordnen.
     * **(Automatische Zuweisung)**: Wenn Sie diese Option wählen, weist das System die Anfrage in Übereinstimmung mit den anwendbaren Zuweisungsregeln zu.
     * **(Nicht zugeordnet)**: Sie können aber auch wählen, dass die Anfrage nicht zugeordnet wird. In diesem Fall sind die Mitglieder der entsprechenden Kategorie für die Handhabung der Anfrage verantwortlich.

   * Wählen Sie im Feld **Kategorie** aus der daraufhin angezeigten Liste die gewünschte Kategorie aus.

   * Im Listenfeld **Priorität** stehen die Optionen **Niedrig**, **Mittel** und **Hoch** zur Auswahl. Sie können die Priorität jedoch auch automatisch zuweisen lassen. Dies kann z. B. auf der Grundlage von für verschiedene Personen und Firmen gesetzten [Eskalationsstufen][3] erfolgen.

   * Wählen Sie im Listenfeld **Zugriffsstufe für Anfrage** eine der folgenden Optionen:
     * **Extern**: Wählen Sie diese Option, wenn die Person über SuperOffice Kundenzentrum Zugriff auf die Anfrage erhalten soll.
     * **Intern**: Wählen Sie diese Option, wenn die Person keinen Zugriff auf die Anfrage erhalten soll. Die Anfrage wird im SuperOffice Kundenzentrum aufgeführt, aber die Person kann keine Details oder Nachrichten zur Anfrage anzeigen.

   * Im Listenfeld **Tags** müssen Sie für diese Anfrage [relevante Tags auswählen][4].

    ![Request properties sidebar -screenshot][img7]

1. Geben Sie in der Registerkarte **Nachrichten** die eigentliche [Mitteilung](#message) ein, die der Anfrage hinzugefügt werden soll.

1. Klicken Sie auf **Senden**, um die Anfrage zu senden und zu speichern.

## <a id="message" />Mitteilung

> [!NOTE]
> Wenn Sie die Mitteilung an jemanden senden möchten, müssen Sie Empfänger in das Feld **An** unter den Registerkarten eingeben. Wenn die Mitteilung über das SuperOffice Kundenzentrum für die Person verfügbar sein soll, müssen Sie die Zugriffsstufe (für die Meldung) auf **Extern** einstellen.

Hier geben Sie die Nachricht ein, die Sie der Anfrage hinzufügen möchten. Sie können dabei wie bei der Eingabe von Text in einem Textverarbeitungsprogramm arbeiten. Sie können der Mitteilung auch Anlagen, [Antwortvorlagen][2] und FAQs hinzufügen.

Der untere Bereich enthält folgende Optionen:

* ![Symbol][img1] – Klicken Sie hier, um die Werkzeugleiste im Mitteilungseditor ein- bzw. auszublenden
* ![Symbol][img2] – Klicken Sie hier, um die Optionen für Anlagen einzublenden. Hier können Sie einer Anfrage relevante Dokumente als Anlagen hinzufügen.
  * Klicken Sie auf **Dateien hochladen (oder hierhin ziehen und ablegen)**, um eine Datei auf einer Festplatte oder einem Server zu suchen und hinzuzufügen.
  * Ziehen Sie das Dokument aus dem Windows Explorer in das Feld Anlagen und legen Sie es dort ab.
  * Klicken Sie auf **Ein CRM-Dokument auswählen**, um ein Dokument in SuperOffice CRM auszuwählen.
* **Einfügen**: Klicken Sie auf die Listenschaltfläche (![Symbol][img3]) und wählen Sie aus, was in der Mitteilung eingefügt werden soll. Sie können eine Antwortvorlage, einen FAQ-Eintrag, eine frühere Nachricht oder eine Anlage hinzufügen. Optional: Sie können [Antwortvorlagen in anderen Sprachen hinzufügen][7]. Wählen Sie eine Sprache aus der Sprachliste aus. Sofern verfügbar, wird der Text in der ausgewählten Sprache eingefügt. Andernfalls wird die Standardsprache verwendet.
* **Intern/Extern**: Hier können Sie **Extern** wählen, wenn die Person über das SuperOffice Kundenzentrum Zugriff auf die Nachricht erhalten soll. Wählen Sie **Intern**, wenn die Person keinen Zugriff auf die Mitteilung erhalten soll.
* **Aufgewendete Zeit**: Hier können Sie die Zeit erfassen, die Sie für die Nachricht aufgewendet haben. Die Zeitmessung startet automatisch, wenn Sie die Anfrage erstellen. Sie können die Zeitmessung unterbrechen, indem Sie auf das ![Symbol][img4] der Schaltfläche Stopp klicken, und auch die Zeitmessung neu starten, indem Sie auf das ![Symbol][img5] der Schaltfläche Start klicken. Klicken Sie auf das ![Symbol][img6] der Schaltfläche (**Zeitspanne auswählen**), um die aufgewendete Zeit zu erfassen.

> [!NOTE]
> Die Standardanfragesignatur wird zur Mitteilung hinzugefügt. Sie können die Signatur direkt in der Mitteilung bearbeiten oder Ihre Standard-[E-Mail-Signatur][1] bearbeiten.

## <a id="details" />Details

Die Registerkarte **Details** enthält weitere Details zur Anfrage. Hier finden Sie Zusatzfelder und Informationen, wann zum Beispiel die Anfrage erstellt, zuletzt geändert, geschlossen oder beantwortet wurde, wann sie vom Eigentümer oder von der Person gelesen wurde. Diese Informationen werden während der Lebensdauer der Anfrage automatisch aktualisiert, dennoch gibt es einige Felder, die bei der Erstellung der Anfrage bearbeitet werden können:

* **Beziehung**: Hier können Sie wählen, ob Sie die Anfrage mit einer anderen Anfrage verknüpfen möchten, wenn die neue Anfrage mit einer anderen vorhandenen Anfrage verknüpft ist.
* **Zugriffsstufe**: Dies ist eine weitere Möglichkeit, die Zugriffsstufe für die Anfrage festzulegen. Dies kann auch im **Bildschirm Eigenschaften** erfolgen. Wenn Sie hier die Zugriffsebene ändern, ändert sie sich automatisch auch im **Bildschirm Eigenschaften**.
* **Verkauf**: Hier können Sie die Anfrage mit einem vorhandenen Verkauf verknüpfen, indem Sie nach dem gewünschten Verkauf suchen oder ihn von der Liste auswählen.
* **Projekt**: Hier können Sie die Anfrage mit einem vorhandenen Projekt verknüpfen, indem Sie nach dem gewünschten Projekt suchen oder ihn von der Liste auswählen.

## Automatische Speicherung

Wenn Sie an einer Anfrage arbeiten und plötzlich eine dringendere Anfrage eingeht, können Sie nicht weiter an der ersten Anfrage arbeiten und kümmern sich um die vorrangige Anfrage.

Mit der automatischen Speicherung werden Ihre Änderungen automatisch gespeichert, bis Sie auf **Senden** klicken, um die Änderungen an der Anfrage zu senden, oder die Änderungen verwerfen.
Automatisch gespeicherte Informationen befinden sich im lokalen Speicher des Browsers, sodass die Daten sogar bei Browser-Absturz, Neustart, Ab- und Anmeldung bestehen bleiben.

Die automatische Speicherung wird standardmäßig aktiviert, wenn Sie Anfragen ansehen und bearbeiten und beantworten/alle beantworten.

### Einschränkungen

* Automatisch gespeicherte Daten werden nicht von einem Computer auf einen anderen übertragen. Das heißt, Sie können nicht im Büro an der Antwort auf eine Anfrage arbeiten und dann zuhause fortfahren.
* Automatisch gespeicherte Daten werden zwischen zwei verschiedenen Browsern nicht weitergegeben.
* Die automatische Speicherung ist sehr nützlich, kann aber das ordnungsgemäße Speichern Ihrer Arbeit nicht ersetzen.

## Details

Diese Registerkarte enthält für alle Anfragen festgelegte Zusatzfelder. Diese unterscheiden sich von Firma zu Firma.

## Was möchten Sie jetzt tun?

* [Nachricht bearbeiten][5]
* [Anfragen verarbeiten][8]
* [E-Mail-Signatur bearbeiten][1]
* [Eskalationsstufen][3]
* [Verwenden von Tags in Anfragen][4]
* [Antwortvorlagen zu Nachrichten hinzufügen][2]
* [Antwortvorlage erstellen][9]
* [Neue Sprachversion der Antwortvorlage erstellen][7]

<!-- Referenced links -->
[1]: ../../../learn/getting-started/edit-email-signature.md
[2]: reply.md#reply-templ
[3]: ../priority/escalation-levels.md
[4]: ../tags.md
[5]: edit-message.md
[7]: ../../reply-templates/learn/new-language.md
[8]: ../index.md
[9]: ../../reply-templates/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/format-font.png
[img2]: ../../../../../common/icons/attachments-theme.png
[img3]: ../../../../../common/icons/copy-paste-icon.png
[img4]: ../../../../../common/icons/stop.png
[img5]: ../../../../../common/icons/play.png
[img6]: ../../../../../common/icons/timespan.png
[img7]: ../../../../media/loc/en/request/requests-select-request-types.png
