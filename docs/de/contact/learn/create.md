---
uid: help-de-contact-create
title: Neue Person erstellen
description: So erstellen Sie eine neue Person in SuperOffice.
keywords: Person erstellen, Interessen hinzufügen, Registerkarte Interessen, Kontaktbild, bevorzugte Sprache, Rechtsgrundlage, Person, Kontaktperson
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Neue Person erstellen

Sie können eine Person in SuperOffice CRM auf verschiedene Weise hinzufügen:

* Über die obere Leiste oder die Ansicht Firma (siehe unten).
* [Scannen Sie eine Branchenkarte][1] mit der SuperOffice Mobile CRM-App.
* [Massenimport von Personen][2] (erfordert Administratorrechte).

## Schritte

1. **Öffnen Sie die Ansicht Person:**

    * Klicken Sie auf **Neu** in der **oberen Leiste** und wählen Sie **Person**.
    * Oder, wechseln Sie zur entsprechenden Firma in der **Ansicht Firma**, wählen Sie die Bereichsregisterkarte **Personen** und klicken Sie auf **Hinzufügen**.

2. **Geben Sie die wichtigsten daten ein:**

    * **Vorname** und/oder **Nachname** (Pflichtfeld: mindestens eines muss ausgefüllt sein).
    * Optional: Wählen Sie eine Anrede (***Hr./Fr.***).
    * **Firma**:
      * Beginnen Sie zu tippen, um eine Firma zu suchen, oder wählen Sie **(Keine Selektion)**, wenn die Person keiner Firma zugeordnet ist.
    * Optional: **Personenbild** hinzufügen, indem Sie eine Bilddatei per Drag & Drop in das Bildfeld ziehen oder über das Kontextmenü hochladen.

    ![Leere Personenkarte mit hervorgehobenen Pflichtfeldern Vorname und Nachname sowie optionalen Feldern wie Titel und Firma -screenshot][img1]

3. Füllen Sie die Felder in der Registerkarte **Person** aus.

    * Geben Sie das **Land** an. Dies aktualisiert das Adressformat für dieses Land automatisch.
    * Erfassen Sie weitere relevante Felder, wie **Mobiltelefon** und **E-Mail**.

4. Fügen Sie in der Registerkarte **Details** weitere Informationen hinzu (optional):

    * Erfassen Sie **Position**, **Geburtsdatum** und **Bevorzugte Sprache**.
    * Geben Sie Kommunikationsdetails an: **Website**, **Chat** und **Internet-Telefon** (z. B. Skype oder Microsoft Teams).
    * Falls erforderlich, legen Sie die Servicepriorität fest und wählen Sie einen Service-Verantwortlichen aus (erfordert eine SuperOffice Service- oder Kundenportal-Lizenz).

    ![Details-Registerkarte mit zusätzlichen Feldern -screenshot][img2]

5. Wechseln Sie zur Registerkarte **Interessen**, um Interessen und Abonnements festzulegen:

    * Aktivieren Sie die passenden Interessen (in **Einstellungen und Verwaltung** definiert).
    * Konfigurieren Sie **E-Marketing/Abonnements** zur Einwilligung für E-Mail-Kampagnen.

6. **Datenschutzpräferenzen prüfen:**

    * Klicken Sie unten in der Personenkarte auf **Rechtsgrundlage**, um die [DSGVO-Einwilligung zu überprüfen oder zu aktualisieren][7]. Schließen Sie den Dialog nach der Bearbeitung.

7. **Als Ausgeschiedene Mitarbeiter markieren (optional):**

    * Aktivieren Sie **Ausgeschiedene Mitarbeiter**, wenn die Person die Firma verlassen hat. Ehemalige Mitarbeiteren erscheinen nicht in der Personenliste oder in Projekten.

8. Klicken Sie auf **Speichern**, um die Personendaten zu speichern.

Die Person wird in der Datenbank gespeichert und auf der Personenkarte angezeigt. Falls eine Firma verknüpft ist, erscheint die Person in der Registerkarte **Personen** in der Ansicht Firma.

## <a id="fields"></a>Wichtige Felder erklärt

Die folgenden Felder sind in der Personenkarte verfügbar. Einige Felder werden automatisch ausgefüllt, andere erfordern manuelle Eingaben.

> [!NOTE]
> Felder und Layout können je nach [Bildschirmdesigner][9] und benutzerdefinierten Anpassungen variieren.

<!-- markdownlint-disable-file MD051 -->
### [Registerkarte Person](#tab/contacts)

**Grundlegende Details:**

* **Vorname** / **Nachname**: Mindestens eines dieser Felder muss ausgefüllt sein (Pflichtfeld).
* **Anrede**: Optional. Wählen Sie **Hr./Fr.** entsprechend der Präferenz der Person.
* **Titel**: Geben Sie die Position oder Berufsbezeichnung der Person ein (auf der Visitenkarte).

**Kontaktinformationen:**

* **E-Mail**: Erfassen Sie mehrere E-Mail-Adressen mit Beschreibungen, z. B. *Geschäftlich* oder *Privat*.
* **Mobiltelefon** / **Direktwahl**: Erfassen Sie mehrere Telefonnummern mit Bezeichnungen, z. B. *Mobil* oder *Büro*.
  * Drücken Sie **TAB** oder klicken Sie außerhalb des Eingabefelds, um die Einträge zu speichern.

**Adresse:**

* **Wohnadresse**: Geben Sie die Adressdetails der Person ein.
  * Das Adressformat wird automatisch basierend auf dem Wert im **Land**-Feld aktualisiert.
* **Land**: Gibt das Land der Person an. Standardmäßig wird das mit der Firma verknüpfte Land übernommen.
* **Als Postadresse verwenden**: Aktivieren Sie dieses Feld, wenn Direktwerbung an die Adresse der Person anstatt an die Firmenadresse gesendet werden sollen.

**Geerbte Felder:**

* **Verantwortlich**: Weist automatisch Ihren Namen zu. Klicken Sie auf den Pfeil, um eine andere Person aus Ihrer Organisation auszuwählen.
* **Kategorie**: Wählen Sie eine vordefinierte Kategorie aus. Falls die Person mit einer Firma verknüpft ist, wird standardmäßig die Kategorie der Firma übernommen.
* **Branche**: Wählen Sie die relevante Branche aus. Falls die Person mit einer Firma verknüpft ist, wird standardmäßig die Branche der Firma übernommen.

**Systemfelder:**

* **Nummer**: Wird automatisch als nächste verfügbare Personennummer generiert, falls in **Einstellungen und Verwaltung** konfiguriert. Falls erforderlich, können Sie diese Nummer manuell bearbeiten.

[!include[3 udef](../../learn/includes/more-udef.md)]

### [Registerkarte Details](#tab/details)

**Persönliche Informationen:**

* **Position:** Wählen Sie eine Position aus einer vordefinierten Liste.
* **Geburtsdatum:** Erfassen Sie das Geburtsdatum der Person.

### Kommunikationsdetails

* **Website:** Geben Sie eine URL für die Website der Person oder ihre Profile auf LinkedIn, Facebook oder anderen Plattformen ein. Fügen Sie einen Titel für mehr Klarheit hinzu.
* **Chat:** Erfassen Sie Chat-Adressen für Anwendungen wie Microsoft Teams oder Google Chat. Wählen Sie einen Dienstanbieter aus der Liste aus.
* **Internet-Telefon:** Geben Sie eine VOIP-Adresse ein, zum Beispiel für Skype oder einen anderen internetbasierten Telefondienst.
* **Direktfax:** Erfassen Sie die Faxnummer der Person.

### Service-spezifische Felder *(erfordert eine SuperOffice Service- oder CEP-Lizenz)*

* **Bevorzugte Sprache:** Wählen Sie die bevorzugte Sprache der Person für alle Antwortvorlagen aus.
* **Service-Priorität:** Legen Sie die Standardpriorität für neue Serviceanfragen fest (z. B. Niedrig, Mittel, Hoch oder individuell angepasst). Falls nicht festgelegt, wird die Priorität der verknüpften Firma verwendet.
* **Service-Verantwortlicher:** Wählen Sie eine Service-Verantwortliche Person zur Betreuung dieser Person.

### Private Felder

* **Privat:** Erfassen Sie persönliche Telefonnummern oder andere Kontaktdaten, die nicht mit der Firma verknüpft sind.

### [Registerkarte Mehr](#tab/more)

Hier können Sie [benutzerdefinierte Felder][12] eingeben, die für Ihr CRM-Setup spezifisch sind.

### [Registerkarte Interessen](#tab/interests)

**Interessen und Abonnements:**

* **Interessen:** Wählen Sie die Interessen der Person aus, indem Sie die entsprechenden Kästchen aktivieren. Interessen werden zur Erstellung gezielter Selektionen genutzt, beispielsweise für Mailings oder Kampagnen.

  * Die Interessen sind in **Einstellungen und Verwaltung** vordefiniert.
  * Sobald eine oder mehrere Interessen ausgewählt sind, erscheint ein Punkt neben dem Namen der Registerkarte **Interessen**.

* **E-Marketing/Abonnements:** Verwalten Sie die Einwilligung zum Erhalt von E-Mail-Kampagnen.

  * Falls die Person zugestimmt hat, aktivieren Sie die Option **E-Marketing**, um die rechtliche Einwilligung für den Versand von Mailings zu bestätigen. Die Rechtsgrundlage wird automatisch auf **Berechtigtes Interesse** gesetzt.
  * Legen Sie fest, welche Arten von E-Marketing die Person erhalten soll (Abonnementtypen).
  * Diese Abonnementeinstellungen können auch direkt von der Person über ein Kundenportal geändert werden.

### [Registerkarte Notiz](#tab/note)

[Beliebige Freitextnotizen erfassen][5].

***

## <a id="interests-tab"></a>Interessen hinzufügen

Interessen sind hilfreich, um gezielte Selektionen zu erstellen, beispielsweise für Marketingkampagnen. Wenn Sie *Referenzkunde* als Interesse definieren, können Sie schnell eine Selektion aller Referenzkunden erstellen.

1. Wechseln Sie zur Registerkarte **Interessen**.

1. Wählen Sie im Bearbeitungsmodus die relevanten Interessen aus, indem Sie die Kästchen aktivieren. Die verfügbaren Optionen sind in **Einstellungen und Verwaltung** definiert.

1. Sobald Sie eine oder mehrere Interessen ausgewählt haben, erscheint ein Punkt neben dem Namen der Registerkarte.

1. Klicken Sie auf **Speichern**, um Ihre Änderungen zu sichern.

## Tipps

* Sie können mehrere Telefonnummern, E-Mails und andere Einträge mit Beschreibungen (z. B. Zentrale) hinzufügen.

    Wenn Sie auf die E-Mail-Adresse der Person in der **Registerkarte Person** klicken, können Sie in der Liste die gewünschte Adresse auswählen. Eine neue E-Mail wird geöffnet, mit der gewählten Adresse im **An**-Feld.

* Verwenden Sie das Telefonsymbol, um die Person direkt anzurufen, falls Ihr System entsprechend konfiguriert ist.

* Falls die Person mit einer Firma verknüpft ist, werden Felder wie **Kategorie**, **Branche** und **Unser Kontakt** aus den Firmendaten übernommen und können nicht bearbeitet werden.

* Wechseln Sie zur [Bereichsregisterkarte Beziehungen][8], um diese Person mit anderen Firmen oder Personen zu verknüpfen.

## Verwandte Inhalte

* [Person als Favorit speichern][4]
* [Branchenkarte scannen][1]

<!-- Referenced links -->
[1]: ../../../en/mobile/superoffice-mobile/company-contact/scan-business-card.md
[2]: ../../admin/import/learn/index.md
[4]: ../../learn/basics/fav.md
[7]: ../../security/privacy/learn/edit-legal-base.md
[8]: ../../learn/basics/relations.md
[5]: ../../learn/basics/notes.md
[9]: ../../ui/screen-designer/learn/index.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/contact/new-contact.png
[img2]: ../../../media/loc/en/contact/contact-details.png
