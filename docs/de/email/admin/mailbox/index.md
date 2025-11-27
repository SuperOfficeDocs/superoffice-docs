---
uid: help-de-email-service
title: Service-E-Mails
description: Service-E-Mails
author: SuperOffice Product and Engineering
keywords: postfach
date: 07.10.2025
version: 10.5
content_type: concept
category: service
topic: email
functional_right:
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: de
redirect_from:
  - /de/email/service/learn/index
  - /de/email/service/learn/screen/tab-inbox-for-email
  - /de/email/service/learn/screen/tab-outbox-for-email
  - /de/email/service/learn/screen/tab-blocked-email
  - /de/email/service/learn/screen/sms-inbox
  - /de/email/service/learn/screen/sms-outbox
  - /de/email/service/learn/email-filters/index
---

# Service-E-Mails

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

In der Ansicht **E-Mail** konfigurieren Sie die Mechanismen, nach denen eingehende und ausgehende E-Mails verwaltet werden. E-Mails werden von SuperOffice Service regelmäßig importiert, wobei Nachrichten von einem oder mehreren Postfächern gesammelt werden. Diese E-Mails können mit E-Mail-Filtern gescannt werden, um sie entsprechend ihrem Inhalt zu verarbeiten und Anfragen zu erzeugen. Ausgehende E-Mails (Antworten) werden in den Postausgang gestellt und regelmäßig zur Weiterleitung an den konfigurierten E-Mail-Server gesendet. Importierte E-Mails, die (durch einen Filter) blockiert sind, werden auf der Registerkarte **Blockierte E-Mails** angezeigt und müssen manuell überprüft werden.

## Postfächer

Die Registerkarte **Postfächer** enthält eine Liste der installierten Postfächer. Diese Liste enthält folgende Spalten:

* **Adresse**: Die Absenderadresse des Postfachs.
* **Kategorie**: Anfragen aus dem Postfach werden dieser Kategorie zugewiesen.
* **Priorität**: Die Priorität, die neue Anfragen zugewiesen wird, wenn sie vom Postfach erfasst werden.
* **Weiterleitungsadresse**: Wenn Sie die E-Mail-Funktionen in SuperOffice nicht verwenden, werden die E-Mails an diese Adresse weitergeleitet.
* **Protokoll**: Das von den Postfächern verwendete Protokoll.

### <a id="email-in"></a>Posteingang für E-Mail

Die Registerkarte **E-Mail-Posteingang** enthält eine Liste der E-Mails in der Warteschlange, die eingelesen werden sollen. Die folgenden Optionen sind auch unter der Schaltfläche <i class="ph ph-dots-three-circle-vertical" aria-label="Aufgabe"></i> verfügbar:

* **Exportieren**: Wird für den Export der Liste in eine Datei verwendet. Sie können unter diesen Formaten auswählen: Excel, HTML und Nur-Text.

* **Löschen**: Wird zum Löschen der ausgewählten E-Mails verwendet.

    > [!NOTE]
    > Dieser Vorgang lässt sich nicht rückgängig machen.

Wenn Sie auf eine der Nachrichten auf dieser Registerkarte klicken, wird die Ansicht **Eingehende E-Mail** angezeigt. Diese Ansicht enthält Informationen über die Nachricht. Im Feld **Letzte Fehlermeldung** können Sie die Ursache des Problems feststellen, ob zum Beispiel ein Problem mit der E-Mail-Adresse oder dem E-Mail-Server vorliegt. Wenn SuperOffice Service einen Fehler meldet, können Sie auf **Import mit Fehlerbehebung** klicken, um technische Informationen anzuzeigen, die dem Kundensupport helfen, den Fehler zu beheben.

### <a id="email-out"></a>Postausgang für E-Mail

Die Registerkarte **E-Mail-Postausgang** enthält eine Liste der E-Mails in der Warteschlange zum Senden.

Wählen Sie **Gesendete E-Mails anzeigen** unten rechts, um auch die zuletzt gesendeten E-Mails anzuzeigen.

Die folgenden Optionen sind auch unter der Schaltfläche <i class="ph ph-dots-three-circle-vertical" aria-label="Aufgabe"></i> verfügbar:

* **Exportieren**: Wird für den Export der Liste in eine Datei verwendet. Sie können unter diesen Formaten auswählen: Excel, HTML und Nur-Text.

* **Senden**: Wird nur für das erneute Senden der ausgewählten E-Mails verwendet, wenn ein Fehler in der automatischen Kampagne aufgetreten ist.

* **Löschen**: Wird zum Löschen der ausgewählten E-Mails verwendet.

    > [!NOTE]
    > Dieser Vorgang lässt sich nicht rückgängig machen.

Wenn Sie auf eine der Nachrichten auf dieser Registerkarte klicken, wird die Ansicht **Ausgehende E-Mails** angezeigt. Sie enthält Informationen über die ausgewählte Nachricht, z. B. die Größe und den Benutzer, der sie erstellt hat. Fehlermeldungen werden ggf. ebenfalls angezeigt.

### <a id="email-blocked"></a>Blockierte E-Mails

Die Registerkarte **Blockierte E-Mails** enthält eine Liste der eingehenden E-Mails, die durch einen E-Mail-Filter blockiert wurden. Klicken Sie auf eine E-Mail, um ihren Inhalt anzuzeigen. Wenn auf einer Seite nicht genug Platz für alle E-Mails ist, können Sie auf <i class="ph ph-arrow-right" aria-label="Arrow right"></i> klicken, um zur nächsten Seite zu navigieren. Diese Liste enthält folgende Spalten:

* **Zeitpunkt**: Diese Spalte gibt den Zeitpunkt an, zu dem die E-Mail blockiert wurde.
* **Postfach**: Diese Spalte gibt das Postfach an, in das die E-Mail importiert wurde.
* **E-Mail-Filter**: Diese Spalte enthält den E-Mail-Filter, durch den die E-Mail blockiert wurde.
* **E-Mail-Betreff**: Zeigt den Betreff der E-Mail an.

Die folgenden Optionen sind auch unter <i class="ph ph-dots-three-circle-vertical" aria-label="Aufgabe"></i> verfügbar:

* **Exportieren**: Wird für den Export der Liste in eine Datei verwendet. Sie können unter diesen Formaten auswählen: Excel, HTML und Nur-Text.
* **Importieren**: Wird zum Importieren der ausgewählten E-Mails verwendet. Der E-Mail-Filter, von dem die E-Mail blockiert wurde, wird dann ignoriert. Die anderen Filter sind jedoch weiterhin aktiviert.
* **Löschen**: Wird zum Löschen der ausgewählten blockierten E-Mails verwendet.

### <a id="sms-in"></a>SMS-Eingang

> [!NOTE]
> Wenn diese Registerkarte nicht angezeigt wird, ist das SMS-Modul nicht installiert oder die SMS-Funktion wurde für die verwendete Lizenz nicht aktiviert. Weitere Informationen erhalten Sie von Ihrem Systemadministrator.

Die Registerkarte **E-Mail-Posteingang** enthält eine Liste der SMS-Nachrichten in der Warteschlange, die eingelesen werden sollen. Die folgenden Optionen sind auch unter der Menüschaltfläche verfügbar:

* **Exportieren**: Wird für den Export der Liste in eine Datei verwendet. Sie können unter diesen Formaten auswählen: Excel, HTML und Nur-Text.

* **Löschen**: Wird zum Löschen der ausgewählten Nachrichten verwendet.

    > [!NOTE]
    > Dieser Vorgang lässt sich nicht rückgängig machen.

Klicken Sie in dieser Registerkarte auf eine der Nachrichten, um Informationen zur ausgewählten Mitteilung einzublenden.

### <a id="sms-out"></a>SMS-Postausgang

Auf der Registerkarte **SMS-Postausgang** werden alle abgehenden SMS-Nachrichten angezeigt, die noch nicht gesendet wurden oder bei denen ein Fehler aufgetreten ist.

> [!NOTE]
> Wenn diese Registerkarte nicht angezeigt wird, ist das SMS-Modul nicht installiert oder die SMS-Funktion wurde für die verwendete Lizenz nicht aktiviert. Weitere Informationen erhalten Sie von Ihrem Systemadministrator.

Die folgenden Optionen sind auch unter der Menüschaltfläche verfügbar:

* **Exportieren**: Wird für den Export der Liste in eine Datei verwendet. Sie können unter diesen Formaten auswählen: Excel, HTML und Nur-Text.

* **Senden**: Wird nur für das erneute Senden der ausgewählten Nachrichten verwendet, wenn ein Fehler in der automatischen Kampagne aufgetreten ist.

* **Löschen**: Wird zum Löschen der ausgewählten Nachrichten verwendet.

    > [!NOTE]
    > Dieser Vorgang lässt sich nicht rückgängig machen.

Wenn Sie auf eine der Nachrichten auf dieser Registerkarte klicken, wird die Ansicht **Abgehende SMS** angezeigt. Sie enthält Informationen über die ausgewählte Nachricht, z. B. die Größe und den Benutzer, der sie erstellt hat. Fehlermeldungen werden ggf. ebenfalls angezeigt.

## <a id="filter"></a>E-Mail-Filter

Mit einem E-Mail-Filter können Sie den Inhalt eingehender E-Mails analysieren und auf der Grundlage des Inhalts eine Anfrage erzeugen.

Zudem können Sie komplexe Regeln für die Verarbeitung der E-Mails von bestimmten Absendern hinzufügen. E-Mail-Filter werden häufig in Verbindung mit Internetformularen verwendet, die von der Firma veröffentlicht wurden und die eine E-Mail-Mitteilung mit einem festen Format generieren, die in SuperOffice Service importiert wird.

### Beispiel für eingehende E-Mails aus Web-Formularen

Sie können beispielsweise mithilfe fester Ausdrücke Informationen aus einem Web-Formular extrahieren, das von einem Kunden ausgefüllt wurde. Die Daten aus dem Formular werden anhand eines definierten Regelsatzes in die Kundendatenbank eingetragen. Die aus der E-Mail bzw. dem Formular erzeugte Anfrage wird dann in eine bestimmte Kategorie eingeordnet und ein Bearbeiter wird ausgewählt. Danach wird die Anfrage abgeschlossen und der Kunde erhält auf Grundlage einer Antwortvorlage eine angepasste Empfangsbestätigung. Es gibt also zahlreiche Optionen für die automatische Bearbeitung eingehender E-Mails.

* Eine über ein Web-Formular erhaltene E-Mail verfügt normalerweise über eine Standardabsenderadresse. Sie können diese Adresse durch die E-Mail-Adresse des Kunden ersetzen.
* Sie können die Kundentelefonnummer mit den Informationen in der Kundendatenbank abgleichen und die Anfrage auf dieser Basis dem entsprechenden Kunden zuordnen.
* Adressdaten können bei einer Adressänderung überschrieben werden.
* Sie können eine Empfangsbestätigung mit abgestimmten Informationen senden, wenn der Kunde mehr Informationen über ein bestimmtes Produkt wünscht, und die Anfrage der entsprechenden Unterkategorie und dem entsprechenden Bearbeiter zuordnen.

### Spalten in der Filterliste

Die Registerkarte **E-Mail-Filter** enthält eine Liste der vorhandenen E-Mail-Filter. Diese Liste enthält folgende Spalten:

| Spalte | Beschreibung |
|---|---|
| Beschreibung | Eine Beschreibung des E-Mail-Filters. |
| Priorität | Die Priorität des E-Mail-Filters. Pro E-Mail wird nur ein Filter aktiviert. Wenn mehrere Filter Suchkriterien für eingehende E-Mails enthalten, die einer eingehenden E-Mail entsprechen, wird der Filter mit der höchsten Priorität aktiviert. |
| E-Mail-Adressen | Die Adresse(n) des Postfachs, das gefiltert wird. |
| Suchzeichenfolge | Die vom E-Mail-Filter verwendete Suchzeichenfolge. |

## Verwandte Themen

* [Postfächer erstellen][1]
* [Postfächer löschen][2]
* [E-Mail-Filter][3]

<!-- Referenced links -->
[1]: create-mailbox.md
[2]: delete-mailbox.md
[3]: email-filters/create-email-filter.md

<!-- Referenced images -->
