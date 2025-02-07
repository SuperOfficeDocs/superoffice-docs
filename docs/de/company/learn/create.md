---
uid: help-de-company-create
title: Neue Firma erstellen
description: Schritte zur Erstellung einer neuen Firma
keywords: neue Firma, Firma erstellen, Duplikaterkennung, Interessen hinzufügen, Firmeninteressen, Firma
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Neue Firma erstellen

In der **Ansicht Firma** können Sie Firmen erstellen und verwalten, einschließlich benutzerdefinierter Felder und zusätzlicher Daten. Sehen Sie sich dieses [Video-Tutorial zur Erstellung einer neuen Firma][1] an.

## Schritte zur Erstellung einer Firma

1. Klicken Sie auf **Neu** in der oberen Leiste und wählen Sie **Firma**.

2. Geben Sie in der **Registerkarte Firma** Folgendes ein:
    * **Firmenname** (Pflichtfeld, rot markiert).
    * **Land**. Das Adressformat wird basierend auf dem ausgewählten Land automatisch aktualisiert. Ihr Heimatland ist standardmäßig vorausgewählt und kann unter **Einstellungen** > **System** geändert werden.
    * Anderen Felder wie **PLZ**, **Telefon**, **E-Mail** und **Website**.

   ![Leere Firmenkarte mit Pflicht- und optionalen Feldern -screenshot][img1]

3. Wählen Sie in den Feldern **Kategorie** und **Branche** aus den Listen aus. Beide Felder sind Pflichtfelder.

4. (Optional) Geben Sie weitere Details ein:
    * Wechseln Sie zur Registerkarte **Mehr**, um [benutzerdefinierte Felder einzugeben][12].
    * Wechseln Sie zur Registerkarte **Interessen**, um [Interessen hinzuzufügen](#interests-tab).
    * Wechseln Sie zur Registerkarte **Notiz**, um [Notizen hinzuzufügen][5].

5. Klicken Sie auf **Speichern**, um die Informationen zu sichern.

## <a id="fields"></a>Wichtige Felder und deren Bedeutung

Nachfolgend sind die verfügbaren Felder in der Firmenkarte beschrieben. Einige Felder werden automatisch ausgefüllt, während andere Eingaben erfordern.

> [!NOTE]
> Felder und Layout können je nach [Ansichtsdesigner][9]-Konfigurationen und anderen Anpassungen variieren.

* **Abteilung:** Geben Sie eine Abteilung ein, falls die Firma mehrere Niederlassungen oder Abteilungen hat.
* **Adressfelder:** Automatische Anpassung basierend auf dem ausgewählten Land.
* **PLZ und Ort:** Wenn Sie eine in der SuperOffice-Datenbank definierte Postleitzahl eingeben, wird der Ort automatisch eingetragen. Sie können den Ort auch manuell eingeben, woraufhin eine PLZ vorgeschlagen wird.
* **Telefon/Fax/E-Mail/Website:** Geben Sie mehrere Einträge mit Beschreibungen wie *Telefonzentrale* ein. Klicken Sie außerhalb der Tabelle oder drücken Sie TAB, um die Eingabe zu beenden.
* **Verantwortlich:** Ihr Name wird automatisch zugewiesen. Klicken Sie auf den Pfeil, um eine andere Person auszuwählen.
* **Hauptperson:** Wählen Sie die Hauptansprechpartner für den Kunden aus. Personen müssen zuerst zur Firma hinzugefügt werden.
* **Code:** Wird nach dem Speichern automatisch vorgeschlagen und basiert auf dem Firmennamen. Kann manuell geändert werden.
* **Nummer:** Die nächste verfügbare Firmennummer wird automatisch zugewiesen. Standard ist 10001 und erhöht sich mit jedem neuen Eintrag. Diese Einstellung kann in **Einstellungen und Verwaltung** geändert werden.
* **USt. ID-Nr.:** Geben Sie die Umsatzsteuernummer oder eine ähnliche Nummer der Firma ein.
* **Stopp** und **Mailsperre**-Kontrollkästchen:
  * **Stopp:** Weist darauf hin, dass die Firma besondere Aufmerksamkeit erfordert. Ein Stopp-Symbol erscheint auf der Firmenkarte. Sie können auch eine Notiz hinzufügen, die den Grund erklärt. Diese Option ist nur im Bearbeitungsmodus verfügbar.
  * **Mailsperre:** Verhindert, dass die Firma Direktwerbung erhält. Diese Option ist nur im Bearbeitungsmodus verfügbar.

[!include[3 udef](../../learn/includes/more-udef.md)]

## Duplikaterkennung

Wenn Sie eine Firma eingeben, die einer bereits bestehenden Firma ähnelt, erscheint das Dialogfeld **Duplikate**. Dies hilft, [versehentliche Doppeleinträge][2] zu vermeiden.

* Überprüfen Sie die angezeigten Duplikate, um Datenkonsistenz sicherzustellen.
* Entscheiden Sie, ob Sie mit dem neuen Eintrag fortfahren oder zu einer der aufgelisteten Firmen wechseln möchten.

## <a id="interests-tab"></a>Interessen hinzufügen

Interessen können helfen, gezielte Selektionen zu erstellen. Zum Beispiel können Sie *Referenzkunde* als Interesse definieren und eine Selektion für Marketingkampagnen mit diesen Kunden erstellen.

1. Wechseln Sie zur **Registerkarte Interessen**.

2. Aktivieren Sie im Bearbeitungsmodus die relevanten Kontrollkästchen. Verfügbare Interessen werden in **Einstellungen und Verwaltung** definiert.

    > [!NOTE]
    > Im Übersichtsmodus werden nur ausgewählte Interessen angezeigt. Im Bearbeitungsmodus können weitere Optionen sichtbar sein.

3. Wenn Sie ein oder mehrere Interessen auswählen, erscheint ein Punkt neben dem Namen der Registerkarte **Interessen**.

    ![Registerkarte Interessen mit Kontrollkästchen für Firmeninteressen -screenshot][img2]

4. Klicken Sie auf **Speichern**, um die gewählten Interessen zu speichern.

## Verwandte Inhalte

* [Datensatz als Favoriten hinzufügen][4]
* [Voreinstellungen Dialogfenster][3] – Standardwerte und Listenwerte

<!-- Referenced links -->
[1]: https://community.superoffice.com/globalassets/user--admin/learning/user-guide/company--contact/add-company.mp4
[2]: ../../learn/basics/duplicates.md
[3]: ../../learn/getting-started/preferences.md
[4]: ../../learn/basics/fav.md
[5]: ../../learn/basics/notes.md
[9]: ../../ui/screen-designer/learn/index.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/new-company.png
[img2]: ../../../media/loc/en/company/interests.png
