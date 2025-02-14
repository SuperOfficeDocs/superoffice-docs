---
uid: help-de-reply-template-create
title: Antwortvorlagen erstellen
description: In dieser Anleitung erfahren Sie, wie Sie eine Antwortvorlage erstellen.
keywords: Antwortvorlage erstellen, neue Antwortvorlage, Antwortvorlage kopieren, Antwortvorlageneigenschaften, Antwortvorlage, Anfrage, Antwort, Vorlage, vorbereiteter Text, Wissensdatenbank
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: howto
license: serviceessentials
functional_right: knowledge-base
audience: person
audience_tooltip: SuperOffice Service
language: de
---

# Antwortvorlage erstellen

Eine Antwortvorlage ist ein vorbereiteter Text, der in eine Nachricht eingefügt werden kann. Die Verwendung von Antwortvorlagen spart Zeit und ermöglicht das Versenden personalisierter Nachrichten.

Antwortvorlagen können auch eine Anlage enthalten, die der Mitteilung hinzugefügt wird. Bevor Sie die Antwort an die Person senden, können Sie den Text bearbeiten sowie Anhänge hinzufügen oder entfernen.

> [!NOTE]
> Sie benötigen das funktionale Recht *Wissensdatenbank*, um Antwortvorlagen zu erstellen.

## Schritte – von Grund auf neu erstellen

1. Gehen Sie zum <i class="ph ph-list" aria-label="Hauptmenü"></i> in der oberen Leiste und wählen Sie **Wissensdatenbank** > **Antwortvorlagen**.

1. Wechseln Sie zum gewünschten Ordner. Falls er nicht existiert, können Sie einen [neuen Ordner erstellen][2].

1. Klicken Sie auf die Schaltfläche **Neue Antwortvorlage**.

1. Geben Sie auf der Registerkarte **Eigenschaften** folgende Informationen ein:

    * **Name**: Einen aussagekräftigen Namen für die Antwortvorlage.
    * **Beschreibung**: Eine kurze Beschreibung des Inhalts.
    * **Ordner**: Standardmäßig der ausgewählte Ordner, kann aber geändert werden.
    * **Zugriff**: Legen Sie fest, wer die Antwortvorlage lesen und bearbeiten darf (Zugriffsrechte).

1. Wählen Sie die Registerkarte **(Nicht angegebene Sprache)**.

1. Geben Sie unter der Registerkarte **Eigenschaften** folgende Informationen ein:
    * **Sprache**: Wählen Sie die [Kundensprache][7] der Antwortvorlage aus.
    * **Standard**: Aktivieren Sie diese Option, wenn diese Sprache die Standardsprache sein soll.
    * **Betreff**: Titel der Antwortvorlage, der in der E-Mail als Betreff eingefügt wird.
    * **Nachrichtenkopfzeilen**: Vordefinierte Inhalte für Felder wie **An** und **Betreff** (nur in speziellen Fällen genutzt).

1. In der Registerkarte **Nur-Text** geben Sie folgende Informationen ein:

    * **Nur-Text hinzufügen**: Wenn Sie eine HTML-Version erstellen, sollten Sie zusätzlich eine Nur-Textversion für E-Mail-Programme eingeben, die das HTML-Format nicht unterstützen. Das E-Mail-Programm wählt dann automatisch das geeignete Format aus. Wenn Sie diese Option nicht aktivieren, wird der Text unten ignoriert. Er wird jedoch gespeichert, sodass Sie ihn auch noch später hinzufügen können.

    > [!NOTE]
    > Wenn Sie sowohl Nur-Text als auch HTML-Text hinzufügen, wählt das E-Mail-Programm des Empfängers automatisch die am besten geeignete Version (normalerweise HTML) aus. Beachten Sie, dass Nachrichten, die ohne eine Nur-Text-Version gesendet werden, nur von E-Mail-Programmen mit HTML-Unterstützung gelesen werden können.

    * In das große Feld in der Mitte der Ansicht geben Sie den Inhalt der Antwortvorlage ein. Dieser Text wird immer verwendet, wenn Sie [Antwortvorlagen zu Nachrichten hinzufügen][4].
    * **Rechtschreibung**: Klicken Sie darauf, um die Nachricht einer Rechtschreibprüfung in der Sprache zu unterziehen, die in der Liste **Sprache** ausgewählt ist.

1. In der Registerkarte **HTML-Text** geben Sie folgende Informationen ein:

    * **HTML-Text hinzufügen**: Aktivieren Sie diese Option, um den unten angezeigten Text als HTML-Version der E-Mail hinzuzufügen. Der HTML-Text wird für Kunden mit E-Mail-Programmen verwendet, die HTML lesen können (z. B. Outlook). E-Mails im HTML-Format können aussagekräftiger gestaltet werden, weil Sie zusätzlich zum Text Bilder und Farben verwenden können.
    * In das große Feld in der Mitte der Ansicht geben Sie den gewünschten HTML-formatierten Text ein, der in die Mitteilung an die Person eingefügt werden soll. Beachten Sie, dass eingebundene Grafikdateien auf einem Server verfügbar sein müssen, auf den die Empfänger der E-Mail zugreifen können. Sie können zum Beispiel Grafikdateien hinzufügen, die zuvor in **Externe Dokumente** hochgeladen wurden.

1. In der Registerkarte **SMS-Text**:

    * **SMS-Text**: Geben Sie den Antwortvorlagentext für SMS ein.
    * **Zeichenanzahl**: Überblick über die eingegebenen Zeichen.

1. In der Registerkarte **Anhänge**:

    1. Klicken Sie auf **Dateien auswählen**.
    2. Wählen Sie das gewünschte Dokument aus.
    3. Klicken Sie auf **Hinzufügen**, um die Anlage hinzuzufügen.
    4. Wiederholen Sie den Vorgang für weitere Anhänge.

    > [!TIP]
    > Um eine Anlage zu entfernen, klicken Sie auf **Löschen**.

1. Klicken Sie auf **OK**, um die Antwortvorlage zu speichern. Die Registerkarte **(Nicht angegebene Sprache)** ändert sich zur gewählten Sprache. Klicken Sie auf **Zurück**, um zur Ordnerstruktur der Antwortvorlagen zu gelangen. Die Antwortvorlage ist nun zur Nutzung bei der [Beantwortung von Kundenanfragen][4] verfügbar.

## <a id="copy"></a>Antwortvorlage kopieren

Um eine neue Antwortvorlage basierend auf einer bestehenden Antwortvorlage zu erstellen, können Sie diese kopieren.

1. Gehen Sie zum <i class="ph ph-list" aria-label="Hauptmenü"></i> in der oberen Leiste und wählen Sie **Wissensdatenbank** > **Antwortvorlagen**.
1. Wechseln Sie zum Ordner, in dem sich die Antwortvorlage befindet.
1. Klicken Sie auf die Antwortvorlage. Dies öffnet die Ansicht **Antwortvorlagen anzeigen**.
1. Klicken Sie auf die Schaltfläche **Kopieren**. Eine Kopie der Antwortvorlage wird im Bearbeitungsmodus geöffnet.
1. Bearbeiten Sie den Namen der Antwortvorlage und nehmen Sie die gewünschten Änderungen vor.
1. Klicken Sie auf **OK**, um die Änderungen zu speichern.

## Individuelles Layout für Antworten mit Kategorien erstellen

Um jeder Abteilung in Ihrer Firma ein individuelles Layout für ihre Korrespondenz zuzuweisen, können Sie Antwortvorlagen mit unterschiedlichen Layouts erstellen. Jede Antwortvorlage kann mit einer [Kategorie][1] verknüpft werden, die eine Abteilung repräsentiert. Alle ausgehenden Antworten dieser Kategorien (Abteilungen) werden mit dem jeweiligen abteilungsspezifischen Design zusammengeführt.

Neben dem Layout bzw. der Formatierung der Antwortvorlage muss sie die folgenden Vorlagenvariablen enthalten, um mit der Antwort zusammengeführt zu werden:

```text
[[IF:message.bodyHtml!=""]]
[[message.bodyHtml]]
[[ELSE]]
[[message.body]]
[[ENDIF]]
```

## <a id="faq"></a>Automatische FAQ-Antwort

SuperOffice Service enthält eine Reihe vorgefertigter Antwortvorlagen. Eine davon ist "Beispiel einer automatisierten FAQ-Antwort". Diese Vorlage enthält ein Beispiel zur Automatisierung von Antworten an Kunden auf der Registerkarte **HTML-Text**.

Das System sucht anhand der Kundenanfrage nach passenden Begriffen (einschließlich Schlüsselwörtern) in FAQ-Einträgen von SuperOffice Service. Entsprechend der Übereinstimmung werden relevante FAQ-Einträge automatisch in die Antwort eingefügt, die der Kunde als Empfangsbestätigung erhält.

Der Korrelationsgrad zwischen Anfrage und FAQ-Einträgen kann unter <i class="ph ph-list" aria-label="Hauptmenü"></i> **Systemeinstellungen** > **System** > **Einstellungen** im Feld **Mindestwert für FAQ-Suchergebnisse (in Prozent)** festgelegt werden.

## Verwandte Inhalte

* [Neue Sprachversion einer Antwortvorlage erstellen][5]
* [Antwortvorlagen bearbeiten][6]
* [Antwortvorlagen kopieren][7]

<!-- Referenced links -->
[1]: ../../admin/category/index.md
[2]: manage-folders.md
[4]: ../../learn/reply.md
[5]: new-language.md
[6]: edit.md
[7]: copy.md
